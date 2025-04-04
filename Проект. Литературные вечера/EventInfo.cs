using System;
using System.Windows.Forms;
using Npgsql;
using Проект.Литературные_вечера.Data;

namespace Проект.Литературные_вечера
{
    public partial class EventInfo : Form
    {
        private int _eventId;

        public EventInfo(int eventId)
        {
            InitializeComponent();
            this._eventId = eventId;
            LoadEventData();

        }
        private void LoadEventData()
        {
            try
            {
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
                                this.Text = reader["title"].ToString(); 
                                lblTitle.Text = reader["title"].ToString(); 
                                lblCategory.Text = reader["category"].ToString();
                                lblDate.Text = ((DateTime)reader["date"]).ToString("dd.MM.yyyy");  
                                txtDescription.Text = reader["description"].ToString(); 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            using (var editForm = new EventEditor(_eventId))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadEventData();
                }
            }

        }
    }
}
