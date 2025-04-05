using System;
using System.Windows.Forms;
using Npgsql;
using Проект.Литературные_вечера.Data;

namespace Проект.Литературные_вечера
{
    public partial class EventInfo : Form
    {
        private readonly int _eventId;
        private readonly string _connectionString;

        public EventInfo(int eventId, string connectionString)
        {
            InitializeComponent();
            _eventId = eventId;
            _connectionString = connectionString;
            LoadEventData();
        }

        private void LoadEventData()
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
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
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            using (var dbContext = new AppDbContext())
            using (var editForm = new EventEditor(_eventId, dbContext)) 
            {
                var result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadEventData();
                    this.DialogResult = DialogResult.OK;
                }
                else if (result == DialogResult.Abort)
                {
                    this.DialogResult = DialogResult.Abort;
                    this.Close(); 
                }
            }
        }
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить это событие?",
                                      "Подтверждение удаления",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var dbContext = new AppDbContext())
                    {
                        var eventToDelete = dbContext.Events.Find(_eventId);
                        if (eventToDelete != null)
                        {
                            dbContext.Events.Remove(eventToDelete);
                            int rowsAffected = dbContext.SaveChanges();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Событие успешно удалено", "Успех",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.Abort;
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении события: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

