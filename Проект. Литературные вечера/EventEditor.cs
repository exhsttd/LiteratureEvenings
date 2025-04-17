using System;
using System.Linq;
using System.Windows.Forms;
using Проект.Литературные_вечера.Data;

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

            if (_currentEvent == null)
            {
                MessageBox.Show("Событие не найдено", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            InitializeForm();
            LoadEventData();
        }

        private void InitializeForm()
        {
            dateTimePickerEditor.MinDate = DateTime.Today;
            nameOfEventChange.Text = _currentEvent.Title ?? string.Empty;
            cmbCategory.Text = _currentEvent.Category ?? string.Empty;
            infoOfEventChange.Text = _currentEvent.Description ?? string.Empty;

            if (_currentEvent.Date != default && _currentEvent.Time != default)
            {
                dateTimePickerEditor.Value = _currentEvent.Date.Add(_currentEvent.Time);
            }
        }

        private void LoadEventData()
        {
                var categories = _dbContext.Events
                    .Select(e => e.Category)
                    .Where(c => !string.IsNullOrEmpty(c))
                    .Distinct()
                    .OrderBy(c => c)
                    .ToArray();

                cmbCategory.Items.AddRange(categories);
                cmbCategory.SelectedItem = _currentEvent.Category;

        }

        private void loadBtnEditor_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

                _currentEvent.Title = nameOfEventChange.Text.Trim();
                _currentEvent.Category = cmbCategory.Text.Trim();
                _currentEvent.Description = infoOfEventChange.Text.Trim();
                _currentEvent.Date = dateTimePickerEditor.Value.Date;
                _currentEvent.Time = dateTimePickerEditor.Value.TimeOfDay;

                _dbContext.SaveChanges();

                MessageBox.Show("Изменения сохранены успешно!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                    MessageBox.Show("Событие удалено успешно!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Событие не удалось удалить. Попробуйте позже.", "Ошибка",
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
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private bool ValidateFields()
        {
            return FormValidator.ValidateCurrentForm(
                new[] { nameOfEventChange, infoOfEventChange },
                cmbCategory
            );
        }
    }
}