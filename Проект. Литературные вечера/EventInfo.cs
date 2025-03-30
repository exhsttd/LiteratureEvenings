using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект.Литературные_вечера
{
    public partial class EventInfo : Form
    {
        public EventInfo(string eventName)
        {
            InitializeComponent();
            this.Text = eventName;
        }

   

        private void editbtn1_Click(object sender, EventArgs e)
        {
            EventEditor eventEditor = new EventEditor();
            eventEditor.Show();
            this.Hide();
            eventEditor.FormClosed += (s, args) => this.Close();
        }

        private void infoOfEvent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
