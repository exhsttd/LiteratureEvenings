using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Build.Framework.XamlTypes;

namespace Проект.Литературные_вечера
{
    public partial class EventCreator : Form
    {
        public string Title { get; private set; }
        public DateTime Date { get; private set; }
        public string Category { get; private set; }
        public string Description { get; private set; }
        public EventCreator()
        {
            InitializeComponent();
        }

        private void unloadBtnCreator_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите отменить изменения?", "Подтверждение",
            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Title = nameOfEventCreator.Text;
                this.Date = dateTimePickerCreator.Value;
                this.Category = comboBoxCreator.Text;
                this.Description = infoOfEventCreator.Text;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void loadBtnCreator_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameOfEventCreator.Text))
            {
                MessageBox.Show("Введите название события!");
                return;
            }

            // Сохраняем значения
            this.Title = nameOfEventCreator.Text;
            this.Date = dateTimePickerCreator.Value;
            this.Category = comboBoxCreator.SelectedItem?.ToString();
            this.Description = infoOfEventCreator.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
