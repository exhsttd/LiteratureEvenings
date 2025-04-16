using System;
using System.Linq;
using System.Windows.Forms;
using Проект.Литературные_вечера.Data;
using Проект.Литературные_вечера.Validator4000;

namespace Проект.Литературные_вечера
{
    /// <summary>
    /// Окно создания события
    /// </summary>
    public partial class EventCreator : Form
    {
        private readonly AppDbContext _dbContext;

        /// <summary>
        /// Инициализация нового экземпляра окна создания события
        /// </summary>
        public EventCreator(AppDbContext dbContext)
        {
            InitializeComponent();
            dateTimePickerCreator.MinDate = DateTime.Today;
            _dbContext = dbContext;
            LoadCategories();
        }

        private void LoadCategories()
        {
           var categories = _dbContext.Events
           .Select(e => e.Category)
           .Distinct()
           .OrderBy(c => c)
           .ToArray();
           comboBoxCreator.Items.AddRange(categories);
        }

        private void unloadBtnCreator_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите отменить изменения?", "Подтверждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void loadBtnCreator_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }    

            try
            {
                var newEvent = new Event
                {
                    Title = nameOfEventCreator.Text,
                    Date = dateTimePickerCreator.Value.Date,
                    Time = dateTimePickerCreator.Value.TimeOfDay,
                    Category = comboBoxCreator.SelectedItem.ToString(),
                    Description = infoOfEventCreator.Text
                };

                _dbContext.Events.Add(newEvent);
                _dbContext.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при создании события. Пожалуйста, попробуйте позже.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            return FormValidator.ValidateFormFields(
                textControls: new Control[] { nameOfEventCreator, infoOfEventCreator },
                comboBox: comboBoxCreator,
                comboBoxError: "Необходимо выбрать категорию!"
            );
        }
    }
}