namespace Проект.Литературные_вечера
{
    partial class EventCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.unloadBtnCreator = new System.Windows.Forms.Button();
            this.loadBtnCreator = new System.Windows.Forms.Button();
            this.infoOfEventCreator = new System.Windows.Forms.TextBox();
            this.comboBoxCreator = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCreator = new System.Windows.Forms.DateTimePicker();
            this.nameOfEventCreator = new System.Windows.Forms.TextBox();
            this.textBoxEventCreator5 = new System.Windows.Forms.TextBox();
            this.textBoxEventCreator4 = new System.Windows.Forms.TextBox();
            this.textBoxEventCreator3 = new System.Windows.Forms.TextBox();
            this.textBoxEventCreator2 = new System.Windows.Forms.TextBox();
            this.textBoxEventCreator1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // unloadBtnCreator
            // 
            this.unloadBtnCreator.Location = new System.Drawing.Point(67, 559);
            this.unloadBtnCreator.Name = "unloadBtnCreator";
            this.unloadBtnCreator.Size = new System.Drawing.Size(182, 29);
            this.unloadBtnCreator.TabIndex = 23;
            this.unloadBtnCreator.Text = "Отменить изменения";
            this.unloadBtnCreator.UseVisualStyleBackColor = true;
            this.unloadBtnCreator.Click += new System.EventHandler(this.unloadBtnCreator_Click);
            // 
            // loadBtnCreator
            // 
            this.loadBtnCreator.Location = new System.Drawing.Point(558, 559);
            this.loadBtnCreator.Name = "loadBtnCreator";
            this.loadBtnCreator.Size = new System.Drawing.Size(182, 29);
            this.loadBtnCreator.TabIndex = 21;
            this.loadBtnCreator.Text = "Создать событие";
            this.loadBtnCreator.UseVisualStyleBackColor = true;
            this.loadBtnCreator.Click += new System.EventHandler(this.loadBtnCreator_Click);
            // 
            // infoOfEventCreator
            // 
            this.infoOfEventCreator.Location = new System.Drawing.Point(272, 327);
            this.infoOfEventCreator.Multiline = true;
            this.infoOfEventCreator.Name = "infoOfEventCreator";
            this.infoOfEventCreator.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoOfEventCreator.Size = new System.Drawing.Size(395, 184);
            this.infoOfEventCreator.TabIndex = 20;
            this.infoOfEventCreator.TextChanged += new System.EventHandler(this.infoOfEventCreator_TextChanged);
            // 
            // comboBoxCreator
            // 
            this.comboBoxCreator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCreator.FormattingEnabled = true;
            this.comboBoxCreator.Items.AddRange(new object[] {
            "Тема 1",
            "Тема 2",
            "Тема 3"});
            this.comboBoxCreator.Location = new System.Drawing.Point(272, 280);
            this.comboBoxCreator.Name = "comboBoxCreator";
            this.comboBoxCreator.Size = new System.Drawing.Size(177, 24);
            this.comboBoxCreator.TabIndex = 19;
            this.comboBoxCreator.SelectedIndexChanged += new System.EventHandler(this.comboBoxCreator_SelectedIndexChanged);
            // 
            // dateTimePickerCreator
            // 
            this.dateTimePickerCreator.Location = new System.Drawing.Point(272, 227);
            this.dateTimePickerCreator.Name = "dateTimePickerCreator";
            this.dateTimePickerCreator.Size = new System.Drawing.Size(177, 22);
            this.dateTimePickerCreator.TabIndex = 18;
            // 
            // nameOfEventCreator
            // 
            this.nameOfEventCreator.Location = new System.Drawing.Point(272, 177);
            this.nameOfEventCreator.Multiline = true;
            this.nameOfEventCreator.Name = "nameOfEventCreator";
            this.nameOfEventCreator.Size = new System.Drawing.Size(395, 22);
            this.nameOfEventCreator.TabIndex = 17;
            this.nameOfEventCreator.TextChanged += new System.EventHandler(this.nameOfEventCreator_TextChanged);
            // 
            // textBoxEventCreator5
            // 
            this.textBoxEventCreator5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxEventCreator5.Enabled = false;
            this.textBoxEventCreator5.Location = new System.Drawing.Point(67, 327);
            this.textBoxEventCreator5.Name = "textBoxEventCreator5";
            this.textBoxEventCreator5.ReadOnly = true;
            this.textBoxEventCreator5.Size = new System.Drawing.Size(140, 22);
            this.textBoxEventCreator5.TabIndex = 16;
            this.textBoxEventCreator5.Text = "Добавить описание";
            // 
            // textBoxEventCreator4
            // 
            this.textBoxEventCreator4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxEventCreator4.Enabled = false;
            this.textBoxEventCreator4.Location = new System.Drawing.Point(67, 280);
            this.textBoxEventCreator4.Name = "textBoxEventCreator4";
            this.textBoxEventCreator4.ReadOnly = true;
            this.textBoxEventCreator4.Size = new System.Drawing.Size(140, 22);
            this.textBoxEventCreator4.TabIndex = 15;
            this.textBoxEventCreator4.Text = "Выбрать категорию";
            // 
            // textBoxEventCreator3
            // 
            this.textBoxEventCreator3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxEventCreator3.Enabled = false;
            this.textBoxEventCreator3.Location = new System.Drawing.Point(67, 228);
            this.textBoxEventCreator3.Name = "textBoxEventCreator3";
            this.textBoxEventCreator3.ReadOnly = true;
            this.textBoxEventCreator3.Size = new System.Drawing.Size(140, 22);
            this.textBoxEventCreator3.TabIndex = 14;
            this.textBoxEventCreator3.Text = "Установить дату";
            // 
            // textBoxEventCreator2
            // 
            this.textBoxEventCreator2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxEventCreator2.Enabled = false;
            this.textBoxEventCreator2.Location = new System.Drawing.Point(67, 177);
            this.textBoxEventCreator2.Name = "textBoxEventCreator2";
            this.textBoxEventCreator2.ReadOnly = true;
            this.textBoxEventCreator2.Size = new System.Drawing.Size(140, 22);
            this.textBoxEventCreator2.TabIndex = 13;
            this.textBoxEventCreator2.Text = "Ввести название";
            // 
            // textBoxEventCreator1
            // 
            this.textBoxEventCreator1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEventCreator1.Enabled = false;
            this.textBoxEventCreator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEventCreator1.Location = new System.Drawing.Point(67, 79);
            this.textBoxEventCreator1.Multiline = true;
            this.textBoxEventCreator1.Name = "textBoxEventCreator1";
            this.textBoxEventCreator1.ReadOnly = true;
            this.textBoxEventCreator1.Size = new System.Drawing.Size(424, 43);
            this.textBoxEventCreator1.TabIndex = 12;
            this.textBoxEventCreator1.Text = "Ввести название события";
            // 
            // EventCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 666);
            this.Controls.Add(this.unloadBtnCreator);
            this.Controls.Add(this.loadBtnCreator);
            this.Controls.Add(this.infoOfEventCreator);
            this.Controls.Add(this.comboBoxCreator);
            this.Controls.Add(this.dateTimePickerCreator);
            this.Controls.Add(this.nameOfEventCreator);
            this.Controls.Add(this.textBoxEventCreator5);
            this.Controls.Add(this.textBoxEventCreator4);
            this.Controls.Add(this.textBoxEventCreator3);
            this.Controls.Add(this.textBoxEventCreator2);
            this.Controls.Add(this.textBoxEventCreator1);
            this.Name = "EventCreator";
            this.Text = "EventCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button unloadBtnCreator;
        private System.Windows.Forms.Button loadBtnCreator;
        private System.Windows.Forms.TextBox infoOfEventCreator;
        private System.Windows.Forms.ComboBox comboBoxCreator;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreator;
        private System.Windows.Forms.TextBox nameOfEventCreator;
        private System.Windows.Forms.TextBox textBoxEventCreator5;
        private System.Windows.Forms.TextBox textBoxEventCreator4;
        private System.Windows.Forms.TextBox textBoxEventCreator3;
        private System.Windows.Forms.TextBox textBoxEventCreator2;
        private System.Windows.Forms.TextBox textBoxEventCreator1;
    }
}