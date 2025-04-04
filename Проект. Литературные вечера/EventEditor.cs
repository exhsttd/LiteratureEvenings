using System;
using System.Windows.Forms;
using Npgsql;
using Проект.Литературные_вечера.Data;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace Проект.Литературные_вечера
{
    public partial class EventEditor : Form
    {
        private int _eventId;
        public EventEditor(int eventId)
        {
            InitializeComponent();
            _eventId = eventId;
            LoadEventData();
            dateTimePickerEditor.MinDate = DateTime.Today;
        }
        private void LoadEventData()
        {
            // Реализация загрузки данных для редактирования
            string connectionString = "Host=localhost;Port=5433;Database=EventManagement;Username=postgres;Password=bednistudentkpfu11;";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT title, category, date, description FROM events WHERE event_id = @id";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", _eventId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nameOfEventChange.Text = reader["title"].ToString();
                            cmbCategory.Text = reader["category"].ToString();
                            dateTimePickerEditor.Value = (DateTime)reader["date"];
                            infoOfEventChange.Text = reader["description"].ToString();
                        }
                    }
                }
            }
        }

        private void nameOfEventChange_Click(object sender, EventArgs e)
        {
            string userText = nameOfEventChange.Text;
        }

        private void dateTimePickerEditor_ValueChanged(object sender, EventArgs e)
        {
       
        }

        private void loadBtnEditor_Click(object sender, EventArgs e)
        {

        }

        private void unloadBtnEditor_Click(object sender, EventArgs e)
        {

        }

    }
}
