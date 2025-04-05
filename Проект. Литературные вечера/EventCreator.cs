using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Проект.Литературные_вечера.Data;

namespace Проект.Литературные_вечера
{
    public partial class EventCreator : Form
    {
        private readonly AppDbContext _dbContext;

        public EventCreator(AppDbContext dbContext)
        {
            InitializeComponent();
            dateTimePickerCreator.MinDate = DateTime.Today;
            _dbContext = dbContext;
            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                var categories = _dbContext.Events
                    .Select(e => e.Category)
                    .Distinct()
                    .OrderBy(c => c)
                    .ToArray();

                comboBoxCreator.Items.AddRange(categories);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки категорий: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                return;

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

                MessageBox.Show("Событие успешно создано!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании события: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            ResetFieldHints();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(nameOfEventCreator.Text))
            {
                nameOfEventCreator.Text = "Заполните поле";
                nameOfEventCreator.ForeColor = Color.Red;
                isValid = false;
            }

            if (comboBoxCreator.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите категорию!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCreator.Focus();
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(infoOfEventCreator.Text))
            {
                infoOfEventCreator.Text = "Заполните поле";
                infoOfEventCreator.ForeColor = Color.Red;
                isValid = false;
            }

            return isValid;
        }

        private void ResetFieldHints()
        {
            if (nameOfEventCreator.Text == "Заполните поле")
            {
                nameOfEventCreator.Text = "";
                nameOfEventCreator.ForeColor = SystemColors.WindowText;
            }

            if (comboBoxCreator.Text == "Заполните поле")
            {
                comboBoxCreator.Text = "";
                comboBoxCreator.ForeColor = SystemColors.WindowText;
            }

            if (infoOfEventCreator.Text == "Заполните поле")
            {
                infoOfEventCreator.Text = "";
                infoOfEventCreator.ForeColor = SystemColors.WindowText;
            }
        }

        private void infoOfEventCreator_TextChanged(object sender, EventArgs e)
        {
            infoOfEventCreator.ForeColor = SystemColors.WindowText;
            infoOfEventCreator.BackColor = SystemColors.Window;
        }

        private void nameOfEventCreator_TextChanged(object sender, EventArgs e)
        {
            nameOfEventCreator.ForeColor = SystemColors.WindowText;
            nameOfEventCreator.BackColor = SystemColors.Window;
        }

        private void nameOfEventCreator_Enter(object sender, EventArgs e)
        {
            if (nameOfEventCreator.Text == "Заполните поле")
            {
                nameOfEventCreator.Text = "";
                nameOfEventCreator.ForeColor = SystemColors.WindowText;
            }
        }

        private void comboBoxCreator_Enter(object sender, EventArgs e)
        {
            if (comboBoxCreator.Text == "Заполните поле")
            {
                comboBoxCreator.Text = "";
                comboBoxCreator.ForeColor = SystemColors.WindowText;
            }
        }

        private void infoOfEventCreator_Enter(object sender, EventArgs e)
        {
            if (infoOfEventCreator.Text == "Заполните поле")
            {
                infoOfEventCreator.Text = "";
                infoOfEventCreator.ForeColor = SystemColors.WindowText;
            }
        }

        private void comboBoxCreator_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}