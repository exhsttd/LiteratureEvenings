using System;
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
            InitializeEventsListView();
            LoadEvents();
        }

        private void InitializeEventsListView()
        {

            listViewEvents.View = View.Details;
            listViewEvents.FullRowSelect = true;
            listViewEvents.GridLines = true;

            listViewEvents.Columns.Add("Название", 150);
            listViewEvents.Columns.Add("Дата", 100);
            listViewEvents.Columns.Add("Категория", 100);
            listViewEvents.Columns.Add("Описание", 250);
        }

        private void SaveToDatabase(string title, DateTime date, string category, string description)
        {
            string connString = "Host=localhost;...";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO events (title, date, category, description) VALUES (@title, @date, @cat, @desc)";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@cat", category ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@desc", description ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void LoadEvents()
        {
            listViewEvents.Items.Clear();

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT event_id, title, date, category, description FROM events", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new ListViewItem(reader["title"].ToString());
                            item.SubItems.Add(((DateTime)reader["date"]).ToString("dd.MM.yyyy"));
                            item.SubItems.Add(reader["category"].ToString());
                            item.SubItems.Add(reader["description"].ToString());
                            item.Tag = Convert.ToInt32(reader["event_id"]);

                            listViewEvents.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки событий: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            using (var form = new EventCreator())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                    SaveToDatabase(
                        form.Title,
                        form.Date,
                        form.Category,
                        form.Description
                    );
                    LoadEvents();
                }
            }
        }

        private void listViewEvents_DoubleClick(object sender, EventArgs e)
        {
            if (listViewEvents.SelectedItems.Count > 0 && listViewEvents.SelectedItems[0].Tag != null)
            {
                // Получаем ID события из Tag
                int eventId = (int)listViewEvents.SelectedItems[0].Tag;

                // Создаем и показываем форму с деталями события
                var detailsForm = new EventInfo(eventId);
                detailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите событие", "Информация",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

