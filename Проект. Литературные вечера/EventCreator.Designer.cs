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
            this.lblNameCreator = new System.Windows.Forms.Label();
            this.lblCategoryCreator = new System.Windows.Forms.Label();
            this.lblDateCreator = new System.Windows.Forms.Label();
            this.lblDescriptionCreator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unloadBtnCreator
            // 
            this.unloadBtnCreator.Location = new System.Drawing.Point(59, 538);
            this.unloadBtnCreator.Name = "unloadBtnCreator";
            this.unloadBtnCreator.Size = new System.Drawing.Size(182, 29);
            this.unloadBtnCreator.TabIndex = 23;
            this.unloadBtnCreator.Text = "Отменить изменения";
            this.unloadBtnCreator.UseVisualStyleBackColor = true;
            this.unloadBtnCreator.Click += new System.EventHandler(this.unloadBtnCreator_Click);
            // 
            // loadBtnCreator
            // 
            this.loadBtnCreator.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.loadBtnCreator.Location = new System.Drawing.Point(558, 538);
            this.loadBtnCreator.Name = "loadBtnCreator";
            this.loadBtnCreator.Size = new System.Drawing.Size(182, 29);
            this.loadBtnCreator.TabIndex = 21;
            this.loadBtnCreator.Text = "Создать событие";
            this.loadBtnCreator.UseVisualStyleBackColor = false;
            this.loadBtnCreator.Click += new System.EventHandler(this.loadBtnCreator_Click);
            // 
            // infoOfEventCreator
            // 
            this.infoOfEventCreator.Location = new System.Drawing.Point(393, 155);
            this.infoOfEventCreator.Multiline = true;
            this.infoOfEventCreator.Name = "infoOfEventCreator";
            this.infoOfEventCreator.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoOfEventCreator.Size = new System.Drawing.Size(372, 257);
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
            this.comboBoxCreator.Location = new System.Drawing.Point(64, 245);
            this.comboBoxCreator.Name = "comboBoxCreator";
            this.comboBoxCreator.Size = new System.Drawing.Size(177, 24);
            this.comboBoxCreator.TabIndex = 19;
            this.comboBoxCreator.SelectedIndexChanged += new System.EventHandler(this.comboBoxCreator_SelectedIndexChanged);
            // 
            // dateTimePickerCreator
            // 
            this.dateTimePickerCreator.Location = new System.Drawing.Point(64, 322);
            this.dateTimePickerCreator.Name = "dateTimePickerCreator";
            this.dateTimePickerCreator.Size = new System.Drawing.Size(177, 22);
            this.dateTimePickerCreator.TabIndex = 18;
            // 
            // nameOfEventCreator
            // 
            this.nameOfEventCreator.Location = new System.Drawing.Point(64, 155);
            this.nameOfEventCreator.Multiline = true;
            this.nameOfEventCreator.Name = "nameOfEventCreator";
            this.nameOfEventCreator.Size = new System.Drawing.Size(284, 22);
            this.nameOfEventCreator.TabIndex = 17;
            this.nameOfEventCreator.TextChanged += new System.EventHandler(this.nameOfEventCreator_TextChanged);
            // 
            // lblNameCreator
            // 
            this.lblNameCreator.AutoSize = true;
            this.lblNameCreator.Location = new System.Drawing.Point(67, 133);
            this.lblNameCreator.Name = "lblNameCreator";
            this.lblNameCreator.Size = new System.Drawing.Size(73, 16);
            this.lblNameCreator.TabIndex = 24;
            this.lblNameCreator.Text = "Название";
            // 
            // lblCategoryCreator
            // 
            this.lblCategoryCreator.AutoSize = true;
            this.lblCategoryCreator.Location = new System.Drawing.Point(67, 226);
            this.lblCategoryCreator.Name = "lblCategoryCreator";
            this.lblCategoryCreator.Size = new System.Drawing.Size(75, 16);
            this.lblCategoryCreator.TabIndex = 25;
            this.lblCategoryCreator.Text = "Категория";
            // 
            // lblDateCreator
            // 
            this.lblDateCreator.AutoSize = true;
            this.lblDateCreator.Location = new System.Drawing.Point(67, 303);
            this.lblDateCreator.Name = "lblDateCreator";
            this.lblDateCreator.Size = new System.Drawing.Size(39, 16);
            this.lblDateCreator.TabIndex = 26;
            this.lblDateCreator.Text = "Дата";
            // 
            // lblDescriptionCreator
            // 
            this.lblDescriptionCreator.AutoSize = true;
            this.lblDescriptionCreator.Location = new System.Drawing.Point(399, 133);
            this.lblDescriptionCreator.Name = "lblDescriptionCreator";
            this.lblDescriptionCreator.Size = new System.Drawing.Size(72, 16);
            this.lblDescriptionCreator.TabIndex = 27;
            this.lblDescriptionCreator.Text = "Описание";
            this.lblDescriptionCreator.Click += new System.EventHandler(this.lblDescriptionCreator_Click);
            // 
            // EventCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 661);
            this.Controls.Add(this.lblDescriptionCreator);
            this.Controls.Add(this.lblDateCreator);
            this.Controls.Add(this.lblCategoryCreator);
            this.Controls.Add(this.lblNameCreator);
            this.Controls.Add(this.unloadBtnCreator);
            this.Controls.Add(this.loadBtnCreator);
            this.Controls.Add(this.infoOfEventCreator);
            this.Controls.Add(this.comboBoxCreator);
            this.Controls.Add(this.dateTimePickerCreator);
            this.Controls.Add(this.nameOfEventCreator);
            this.Name = "EventCreator";
            this.Text = "Создание события";
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
        private System.Windows.Forms.Label lblNameCreator;
        private System.Windows.Forms.Label lblCategoryCreator;
        private System.Windows.Forms.Label lblDateCreator;
        private System.Windows.Forms.Label lblDescriptionCreator;
    }
}