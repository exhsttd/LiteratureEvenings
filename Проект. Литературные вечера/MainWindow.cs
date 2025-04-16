using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using Проект.Литературные_вечера.Data;

namespace Проект.Литературные_вечера
{
    /// <summary>
    /// Главное окно приложения со списком всех событий и кнопками для их управления
    /// </summary>
    public partial class MainWindow : Form
    {
        private string connectionString = "Host=localhost;Port=5433;Database=EventManagement;Username=postgres;Password=bednistudentkpfu11;";

        /// <summary>
        /// Инициализация нового экземпляра главного окна 
        /// </summary>
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
            var columns = new (string Text, int Width)[]
            {
              ("Название", 150),
              ("Дата", 100),
              ("Категория", 100),
              ("Описание", 250)
            };

            foreach (var column in columns)
            {
                listViewEvents.Columns.Add(column.Text, column.Width);
            }

            comboFilterParam.Visible = false;
        }

        private void LoadAllEvents()
        {
            listViewEvents.Items.Clear();

            using (var db = new AppDbContext()) 
            {
                var today = DateTime.Today;
                var events = db.Events
                    .Where(e => e.Date >= today)
                    .OrderBy(e => e.Date)
                    .ToList();

                foreach (var ev in events)
                {
                    var item = new ListViewItem(ev.Title);
                    item.SubItems.Add(ev.Date.ToString("dd.MM.yyyy"));
                    item.SubItems.Add(ev.Category);
                    item.SubItems.Add(ev.Description);
                    item.Tag = ev.EventId;

                    if (ev.Date <= today.AddDays(7))
                    {
                        item.BackColor = Color.LightYellow;
                        item.ToolTipText = "Ближайшее событие";
                    }

                    listViewEvents.Items.Add(item);
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

            using (var db = new AppDbContext())
            {
                IQueryable<Event> query = db.Events.Where(e => e.Date >= DateTime.Today);

                switch (comboSortType.SelectedIndex)
                {
                    case 0:
                        if (comboFilterParam.SelectedIndex == 0)
                        {
                            query = query.Where(e => e.Date <= DateTime.Today.AddDays(7));
                        }
                        else
                        {
                            query = query.Where(e => e.Date > DateTime.Today.AddDays(7));
                        }
                        break;

                    case 1:
                        if (comboFilterParam.SelectedIndex != 0)
                        {
                            string selectedCategory = comboFilterParam.SelectedItem.ToString();
                            query = query.Where(e => e.Category == selectedCategory);
                        }
                        break;

                    default:
                        LoadAllEvents();
                        return;
                }

                var events = query.OrderBy(e => e.Date).ToList();

                foreach (var ev in events)
                {
                    var item = new ListViewItem(ev.Title);
                    item.SubItems.Add(ev.Date.ToString("dd.MM.yyyy"));
                    item.SubItems.Add(ev.Category);
                    item.SubItems.Add(ev.Description);
                    item.Tag = ev.EventId;

                    if (ev.Date <= DateTime.Today.AddDays(7))
                    {
                        item.BackColor = Color.LightYellow;
                        item.ToolTipText = "Ближайшее событие";
                    }

                    listViewEvents.Items.Add(item);
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
                    comboSortType.SelectedIndex = -1;
                    comboFilterParam.SelectedIndex = -1;
                    comboFilterParam.Visible = false;
                    LoadAllEvents();
                    if (listViewEvents.Items.Count > 0)
                    {
                        listViewEvents.Items[listViewEvents.Items.Count - 1].EnsureVisible();
                    }
                }
            }
        }

        private void listViewEvents_DoubleClick(object sender, EventArgs e)
        {

            Guid eventId = (Guid)listViewEvents.SelectedItems[0].Tag;
            using (var infoForm = new EventInfo(eventId, connectionString))
            {
                var result = infoForm.ShowDialog();
                if (result == DialogResult.Abort)
                {
                    var itemToRemove = listViewEvents.Items
                        .Cast<ListViewItem>()
                        .FirstOrDefault(item => item.Tag != null && (Guid)item.Tag == eventId);

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

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            using (var excelPackage = new ExcelPackage())
            {
                var column = excelPackage.Workbook.Worksheets.Add("События");
                string[] headers = { "Название", "Дата", "Категория", "Описание" };

                for (int col = 0; col < headers.Length; col++)
                {
                    column.Cells[1, col + 1].Value = headers[col];
                }

                for (int row = 0; row < listViewEvents.Items.Count; row++)
                {
                    for (int col = 0; col < listViewEvents.Items[row].SubItems.Count; col++)
                    {
                        column.Cells[row + 2, col + 1].Value = listViewEvents.Items[row].SubItems[col].Text;
                    }
                }
                column.Cells[column.Dimension.Address].AutoFitColumns();
                using (var saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveDialog.FileName = $"Отчет_фильтрации_событий.xlsx";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        excelPackage.SaveAs(new FileInfo(saveDialog.FileName));
                    }
                }
            }
        }
    }
}
