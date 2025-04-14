using System;
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
            ResetFieldStyles();
            bool isValid = true;

            foreach (var control in new Control[] { nameOfEventCreator, infoOfEventCreator })
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    control.BackColor = Color.LightPink;
                    isValid = false;
                }
            }

            if (string.IsNullOrWhiteSpace(comboBoxCreator.Text))
            {
                comboBoxCreator.BackColor = Color.LightPink;
                MessageBox.Show("Пожалуйста, выберите категорию!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            return isValid;
        }

        private void ResetFieldStyles()
        {
            nameOfEventCreator.BackColor = SystemColors.Window;
            infoOfEventCreator.BackColor = SystemColors.Window;
            comboBoxCreator.BackColor = SystemColors.Window;
        }

        private void AnyTextChanged(object sender, EventArgs e)
        {
            var control = (Control)sender;
            control.ForeColor = SystemColors.WindowText;
            control.BackColor = SystemColors.Window;
        }

        private void AnyControlEnter(object sender, EventArgs e)
        {
            var control = (Control)sender;
            if (control.Text == "Заполните поле")
            {
                control.Text = "";
                control.ForeColor = SystemColors.WindowText;
            }
        }

        private void comboBoxCreator_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblDescriptionCreator_Click(object sender, EventArgs e)
        {

        }
    }
}