namespace Проект.Литературные_вечера
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(254, 626);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // listViewEvents
            // 
            this.listViewEvents.HideSelection = false;
            this.listViewEvents.Location = new System.Drawing.Point(252, 55);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(600, 507);
            this.listViewEvents.TabIndex = 1;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.DoubleClick += new System.EventHandler(this.listViewEvents_DoubleClick);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(273, 577);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(141, 27);
            this.btnCreateEvent.TabIndex = 4;
            this.btnCreateEvent.Text = "создать";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(853, 626);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.listViewEvents);
            this.Controls.Add(this.splitter1);
            this.Name = "MainWindow";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.Button btnCreateEvent;
    }
   #endregion
}