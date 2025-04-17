namespace Проект.Литературные_вечера
{
    partial class EventEditor
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                _dbContext?.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventEditor));
            this.nameOfEventChange = new System.Windows.Forms.TextBox();
            this.dateTimePickerEditor = new System.Windows.Forms.DateTimePicker();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.infoOfEventChange = new System.Windows.Forms.TextBox();
            this.loadBtnEditor = new System.Windows.Forms.Button();
            this.unloadBtnEditor = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblNameEditor = new System.Windows.Forms.Label();
            this.lblCategoryEditor = new System.Windows.Forms.Label();
            this.lblDateEditor = new System.Windows.Forms.Label();
            this.lblDescriptionEditor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameOfEventChange
            // 
            this.nameOfEventChange.BackColor = System.Drawing.Color.AntiqueWhite;
            this.nameOfEventChange.Location = new System.Drawing.Point(64, 153);
            this.nameOfEventChange.Multiline = true;
            this.nameOfEventChange.Name = "nameOfEventChange";
            this.nameOfEventChange.Size = new System.Drawing.Size(284, 24);
            this.nameOfEventChange.TabIndex = 5;
            // 
            // dateTimePickerEditor
            // 
            this.dateTimePickerEditor.CalendarMonthBackground = System.Drawing.Color.AntiqueWhite;
            this.dateTimePickerEditor.Location = new System.Drawing.Point(64, 351);
            this.dateTimePickerEditor.Name = "dateTimePickerEditor";
            this.dateTimePickerEditor.Size = new System.Drawing.Size(177, 25);
            this.dateTimePickerEditor.TabIndex = 6;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbCategory.Items.AddRange(new object[] {
            "Тема 1",
            "Тема 2",
            "Тема 3"});
            this.cmbCategory.Location = new System.Drawing.Point(64, 254);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(177, 26);
            this.cmbCategory.TabIndex = 7;
            // 
            // infoOfEventChange
            // 
            this.infoOfEventChange.BackColor = System.Drawing.Color.AntiqueWhite;
            this.infoOfEventChange.Location = new System.Drawing.Point(393, 153);
            this.infoOfEventChange.Multiline = true;
            this.infoOfEventChange.Name = "infoOfEventChange";
            this.infoOfEventChange.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoOfEventChange.Size = new System.Drawing.Size(372, 289);
            this.infoOfEventChange.TabIndex = 8;
            // 
            // loadBtnEditor
            // 
            this.loadBtnEditor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.loadBtnEditor.Location = new System.Drawing.Point(583, 548);
            this.loadBtnEditor.Name = "loadBtnEditor";
            this.loadBtnEditor.Size = new System.Drawing.Size(182, 33);
            this.loadBtnEditor.TabIndex = 9;
            this.loadBtnEditor.Text = "Сохранить изменения";
            this.loadBtnEditor.UseVisualStyleBackColor = false;
            this.loadBtnEditor.Click += new System.EventHandler(this.loadBtnEditor_Click);
            // 
            // unloadBtnEditor
            // 
            this.unloadBtnEditor.BackColor = System.Drawing.Color.Peru;
            this.unloadBtnEditor.Location = new System.Drawing.Point(349, 548);
            this.unloadBtnEditor.Name = "unloadBtnEditor";
            this.unloadBtnEditor.Size = new System.Drawing.Size(182, 33);
            this.unloadBtnEditor.TabIndex = 11;
            this.unloadBtnEditor.Text = "Отменить изменения";
            this.unloadBtnEditor.UseVisualStyleBackColor = false;
            this.unloadBtnEditor.Click += new System.EventHandler(this.unloadBtnEditor_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Location = new System.Drawing.Point(64, 548);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 33);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "удалить событие";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblNameEditor
            // 
            this.lblNameEditor.AutoSize = true;
            this.lblNameEditor.Location = new System.Drawing.Point(64, 132);
            this.lblNameEditor.Name = "lblNameEditor";
            this.lblNameEditor.Size = new System.Drawing.Size(66, 18);
            this.lblNameEditor.TabIndex = 13;
            this.lblNameEditor.Text = "Название";
            // 
            // lblCategoryEditor
            // 
            this.lblCategoryEditor.AutoSize = true;
            this.lblCategoryEditor.Location = new System.Drawing.Point(64, 233);
            this.lblCategoryEditor.Name = "lblCategoryEditor";
            this.lblCategoryEditor.Size = new System.Drawing.Size(72, 18);
            this.lblCategoryEditor.TabIndex = 14;
            this.lblCategoryEditor.Text = "Категория";
            // 
            // lblDateEditor
            // 
            this.lblDateEditor.AutoSize = true;
            this.lblDateEditor.Location = new System.Drawing.Point(64, 330);
            this.lblDateEditor.Name = "lblDateEditor";
            this.lblDateEditor.Size = new System.Drawing.Size(38, 18);
            this.lblDateEditor.TabIndex = 15;
            this.lblDateEditor.Text = "Дата";
            // 
            // lblDescriptionEditor
            // 
            this.lblDescriptionEditor.AutoSize = true;
            this.lblDescriptionEditor.Location = new System.Drawing.Point(390, 132);
            this.lblDescriptionEditor.Name = "lblDescriptionEditor";
            this.lblDescriptionEditor.Size = new System.Drawing.Size(69, 18);
            this.lblDescriptionEditor.TabIndex = 16;
            this.lblDescriptionEditor.Text = "Описание";
            // 
            // EventEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = global::Проект.Литературные_вечера.Properties.Resources.library_small1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 661);
            this.Controls.Add(this.lblDescriptionEditor);
            this.Controls.Add(this.lblDateEditor);
            this.Controls.Add(this.lblCategoryEditor);
            this.Controls.Add(this.lblNameEditor);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.unloadBtnEditor);
            this.Controls.Add(this.loadBtnEditor);
            this.Controls.Add(this.infoOfEventChange);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.dateTimePickerEditor);
            this.Controls.Add(this.nameOfEventChange);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventEditor";
            this.Text = "Редактирование события";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameOfEventChange;
        private System.Windows.Forms.DateTimePicker dateTimePickerEditor;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox infoOfEventChange;
        private System.Windows.Forms.Button loadBtnEditor;
        private System.Windows.Forms.Button unloadBtnEditor;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblNameEditor;
        private System.Windows.Forms.Label lblCategoryEditor;
        private System.Windows.Forms.Label lblDateEditor;
        private System.Windows.Forms.Label lblDescriptionEditor;
    }
}