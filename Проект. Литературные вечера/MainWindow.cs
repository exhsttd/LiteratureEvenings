using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Npgsql;
using Проект.Литературные_вечера.Data;

namespace Проект.Литературные_вечера
{
    public partial class MainWindow : Form
    {
        private string connectionString = "Host=localhost;Port=5433;Database=EventManagement;Username=postgres;Password=bednistudentkpfu11;";

        public MainWindow()
        {
            InitializeComponent();
            InitializeComponents();
            LoadAllEvents();
        }

        private void InitializeComponents()
        {

            listViewEvents.View = View.Details;
            listViewEvents.FullRowSelect = true;
            listViewEvents.GridLines = true;
            listViewEvents.Columns.Add("Название", 150);
            listViewEvents.Columns.Add("Дата", 100);
            listViewEvents.Columns.Add("Категория", 100);
            listViewEvents.Columns.Add("Описание", 250);

            comboFilterParam.Visible = false;
        }

        private void LoadAllEvents()
        {
            listViewEvents.Items.Clear();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT event_id, title, date, category, description FROM events WHERE date >= @today ORDER BY date", conn))
                {
                    cmd.Parameters.AddWithValue("@today", DateTime.Today);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new ListViewItem(reader["title"].ToString());
                            item.SubItems.Add(((DateTime)reader["date"]).ToString("dd.MM.yyyy"));
                            item.SubItems.Add(reader["category"].ToString());
                            item.SubItems.Add(reader["description"].ToString());
                            item.Tag = Convert.ToInt32(reader["event_id"]);

                            if (((DateTime)reader["date"]) <= DateTime.Today.AddDays(7))
                            {
                                item.BackColor = Color.LightYellow;
                                item.ToolTipText = "Ближайшее событие";
                            }

                            listViewEvents.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void comboSortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSortType.SelectedIndex == -1) return;

            comboFilterParam.Items.Clear();
            comboFilterParam.Visible = true;

            switch (comboSortType.SelectedIndex)
            {
                case 0: 
                    comboFilterParam.Items.Add("Ближайшие 7 дней");
                    comboFilterParam.Items.Add("Остальные события");
                    break;

                case 1: 
                    comboFilterParam.Items.Add("Выберите категорию");
                    using (var db = new AppDbContext())
                    {
                        var categories = db.Events
                            .Select(ev => ev.Category)
                            .Distinct()
                            .OrderBy(c => c)
                            .ToArray();
                        comboFilterParam.Items.AddRange(categories);
                    }
                    break;
            }

            comboFilterParam.SelectedIndex = 0;
            ApplyFilters();
        }

        private void ComboFilterParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            listViewEvents.Items.Clear();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlCommand cmd;

                switch (comboSortType.SelectedIndex)
                {
                    case 0: // Фильтр по дате
                        if (comboFilterParam.SelectedIndex == 0) // "Ближайшие 7 дней"
                        {
                            cmd = new NpgsqlCommand(
                                "SELECT event_id, title, date, category, description FROM events " +
                                "WHERE date BETWEEN @today AND @nextWeek " +
                                "ORDER BY date", conn);
                            cmd.Parameters.AddWithValue("@today", DateTime.Today);
                            cmd.Parameters.AddWithValue("@nextWeek", DateTime.Today.AddDays(7));
                        }
                        else // "Остальные события"
                        {
                            cmd = new NpgsqlCommand(
                                "SELECT event_id, title, date, category, description FROM events " +
                                "WHERE date > @nextWeek " +
                                "ORDER BY date", conn);
                            cmd.Parameters.AddWithValue("@nextWeek", DateTime.Today.AddDays(7));
                        }
                        break;

                    case 1: // Фильтр по категории
                        if (comboFilterParam.SelectedIndex == 0) // "Выберите категорию"
                        {
                            LoadAllEvents();
                            return;
                        }
                        else
                        {
                            string selectedCategory = comboFilterParam.SelectedItem.ToString();
                            cmd = new NpgsqlCommand(
                                "SELECT event_id, title, date, category, description FROM events " +
                                "WHERE category = @category AND date >= @today " +
                                "ORDER BY date", conn);
                            cmd.Parameters.AddWithValue("@category", selectedCategory);
                            cmd.Parameters.AddWithValue("@today", DateTime.Today);
                        }
                        break;

                    default:
                        LoadAllEvents();
                        return;
                }

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["title"].ToString());
                        item.SubItems.Add(((DateTime)reader["date"]).ToString("dd.MM.yyyy"));
                        item.SubItems.Add(reader["category"].ToString());
                        item.SubItems.Add(reader["description"].ToString());
                        item.Tag = Convert.ToInt32(reader["event_id"]);

                        if (((DateTime)reader["date"]) <= DateTime.Today.AddDays(7))
                        {
                            item.BackColor = Color.LightYellow;
                            item.ToolTipText = "Ближайшее событие";
                        }

                        listViewEvents.Items.Add(item);
                    }
                }
            }
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            using (var form = new EventCreator(db))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadAllEvents();
                }
            }
        }

        private void listViewEvents_DoubleClick(object sender, EventArgs e)
        {

            int eventId = (int)listViewEvents.SelectedItems[0].Tag;
            using (var infoForm = new EventInfo(eventId, connectionString))
            {
                var result = infoForm.ShowDialog();
                if (result == DialogResult.Abort)
                {
                    var itemToRemove = listViewEvents.Items
                        .Cast<ListViewItem>()
                        .FirstOrDefault(item => item.Tag != null && (int)item.Tag == eventId);

                    if (itemToRemove != null)
                    {
                        listViewEvents.Items.Remove(itemToRemove);
                    }
                }
                else if (result == DialogResult.OK)
                {
                    LoadAllEvents();
                }
            }
        }
        private void comboFilterParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            comboSortType.SelectedIndex = -1;
            comboFilterParam.SelectedIndex = -1;

            comboFilterParam.Visible = false;
            var item = new ListViewItem();
            LoadAllEvents();
        }

        private void listViewEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}