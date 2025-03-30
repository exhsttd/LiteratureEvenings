using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект.Литературные_вечера
{
    public partial class EventEditor : Form
    {
        public EventEditor()
        {
            InitializeComponent();
            dateTimePickerEditor.MinDate = DateTime.Today;
        }

        private void nameOfEventChange_Click(object sender, EventArgs e)
        {
            string userText = nameOfEventChange.Text;
        }

        private void dateTimePickerEditor_ValueChanged(object sender, EventArgs e)
        {
       
        }

        private void loadBtnEditor_Click(object sender, EventArgs e)
        {

        }

        private void unloadBtnEditor_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtnEditor_Click(object sender, EventArgs e)
        {

        }
    }
}
