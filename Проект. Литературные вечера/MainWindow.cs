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
    public partial class MainWindow : Form
    {
        private void LoadSampleData()
        {
            listView1.Items.Add(new ListViewItem(new[] { "Событие", "20.05.2023", "Чтение стихов" }));
            listView1.Items.Add(new ListViewItem(new[] { "еще событие", "15.05.2023", "Чтение рассказов" }));
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadSampleData();
        }
        public MainWindow()
        {
            InitializeComponent();
            this.Load += MainWindow_Load;
            listView1.DoubleClick += listView1_DoubleClick;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string eventName = listView1.SelectedItems[0].SubItems[0].Text;
                EventInfo infoForm = new EventInfo(eventName);
                infoForm.Show();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createbtnEvents_Click(object sender, EventArgs e)
        {
            EventCreator eventCreator = new EventCreator();
            eventCreator.Show();
            this.Hide();
            eventCreator.FormClosed += (s, args) => this.Close();
        }
    }
}
