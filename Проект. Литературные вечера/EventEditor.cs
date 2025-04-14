using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Проект.Литературные_вечера.Data;
using System.Data.Entity;

namespace Проект.Литературные_вечера
{
    public partial class EventEditor : Form
    {
        private readonly int _eventId;
        private readonly AppDbContext _dbContext;
        private readonly Event _currentEvent;

        public EventEditor(int eventId, AppDbContext dbContext)
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
            nameOfEventChange.Text = _currentEvent?.Title ?? "";
            cmbCategory.Text = _currentEvent?.Category ?? "";
            infoOfEventChange.Text = _currentEvent?.Description ?? "";

            if (_currentEvent != null)
            {
                dateTimePickerEditor.Value = _currentEvent.Date + _currentEvent.Time;
            }
        }

        private void LoadEventData()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadBtnEditor_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            try
            {
                (_currentEvent.Title, _currentEvent.Category, _currentEvent.Description) =
                    (nameOfEventChange.Text, cmbCategory.Text, infoOfEventChange.Text);

                _currentEvent.Date = dateTimePickerEditor.Value.Date;
                _currentEvent.Time = dateTimePickerEditor.Value.TimeOfDay;

                if (_dbContext.Entry(_currentEvent).State == EntityState.Modified)
                    _dbContext.SaveChanges();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
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
            ResetFieldStyles();
            bool isValid = true;

            foreach (var control in new Control[] { nameOfEventChange, infoOfEventChange })
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    control.BackColor = Color.LightPink;
                    isValid = false;
                }
            }

            if (string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                cmbCategory.BackColor = Color.LightPink;
                MessageBox.Show("Пожалуйста, выберите категорию!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            return isValid;
        }

        private void ResetFieldStyles()
        {
            nameOfEventChange.BackColor = SystemColors.Window;
            cmbCategory.BackColor = SystemColors.Window;
            infoOfEventChange.BackColor = SystemColors.Window;
        }

        private void nameOfEventChange_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePickerEditor_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}