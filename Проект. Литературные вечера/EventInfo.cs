using System;
using System.Windows.Forms;
using Проект.Литературные_вечера.Data;

namespace Проект.Литературные_вечера
{
    /// <summary>
    /// Окно информации о событии
    /// </summary>
    public partial class EventInfo : Form
    {
        private readonly Guid _eventId;

        /// <summary>
        /// Инициализация нового экземпляра окна информации о событии
        /// </summary>
        public EventInfo(Guid eventId, string connectionString)
        {
            InitializeComponent();
            _eventId = eventId;
            LoadEventData();
        }

        private void LoadEventData()
        {
            using (var context = new AppDbContext())
            {
                var eventItem = context.Events.Find(_eventId);
                if (eventItem != null)
                {
                    this.Text = eventItem.Title;
                    lblTitle.Text = eventItem.Title;
                    lblCategory.Text = eventItem.Category;
                    lblDate.Text = eventItem.Date.ToString("dd.MM.yyyy");
                    lblDescription.Text = eventItem.Description;
                }
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
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Возникла ошибка при удалении события. Пожалуйста, попробуйте позже.", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

