using System;
using System.Linq;
using System.Windows.Forms;
using Проект.Литературные_вечера.Data;
using System.Data.Entity;
using Проект.Литературные_вечера.Validator4000;

namespace Проект.Литературные_вечера
{
    /// <summary>
    /// Окно редактирования события
    /// </summary>
    public partial class EventEditor : Form
    {
        private readonly Guid _eventId;
        private readonly AppDbContext _dbContext;
        private readonly Event _currentEvent;

        /// <summary>
        /// Инициализация нового экземпляра окна редактирования события
        /// </summary>
        public EventEditor(Guid eventId, AppDbContext dbContext)
        {
            InitializeComponent();
            _eventId = eventId;
            _dbContext = dbContext;
            _currentEvent = _dbContext.Events.Find(eventId);
            InitializeForm();
            LoadEventData();
        }

        private void InitializeForm()
        {
            dateTimePickerEditor.MinDate = DateTime.Today;
            nameOfEventChange.Text = _currentEvent?.Title ?? String.Empty;
            cmbCategory.Text = _currentEvent?.Category ?? String.Empty;
            infoOfEventChange.Text = _currentEvent?.Description ?? String.Empty;

            if (_currentEvent != null)
            {
                dateTimePickerEditor.Value = _currentEvent.Date + _currentEvent.Time;
            }
        }

        private void LoadEventData()
        {

                if (_currentEvent == null)
                {
                    MessageBox.Show("Событие не найдено", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                var categories = _dbContext.Events
                    .Select(e => e.Category)
                    .Distinct()
                    .OrderBy(c => c)
                    .ToArray();

                cmbCategory.Items.AddRange(categories);
        }

        private void loadBtnEditor_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            _currentEvent.Title = nameOfEventChange.Text;
            _currentEvent.Category = cmbCategory.Text;
            _currentEvent.Description = infoOfEventChange.Text;
            _currentEvent.Date = dateTimePickerEditor.Value.Date;
            _currentEvent.Time = dateTimePickerEditor.Value.TimeOfDay;

            if (_dbContext.Entry(_currentEvent).State == EntityState.Modified)
            {
                _dbContext.SaveChanges();
            }
                this.DialogResult = DialogResult.OK;
                this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить это событие?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _dbContext.Events.Remove(_currentEvent);
                    _dbContext.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Возникла ошибка при удалении события. Пожалуйста, попробуйте позже.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void unloadBtnEditor_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы хотите отменить изменения?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var entry = _dbContext.Entry(_currentEvent);
                if (entry.State == EntityState.Modified)
                {
                    entry.CurrentValues.SetValues(entry.OriginalValues);
                    entry.State = EntityState.Unchanged;
                }

                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private bool ValidateFields()
        {
            return FormValidator.ValidateFormFields(
                textControls: new Control[] { nameOfEventChange, infoOfEventChange },
                comboBox: cmbCategory,
                comboBoxError: "Необходимо выбрать категорию!"
            );
        }

    }
}