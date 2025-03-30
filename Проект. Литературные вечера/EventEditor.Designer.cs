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
            this.textBoxEventEditor1 = new System.Windows.Forms.TextBox();
            this.textBoxEventEditor2 = new System.Windows.Forms.TextBox();
            this.textBoxEventEditor3 = new System.Windows.Forms.TextBox();
            this.textBoxEventEditor4 = new System.Windows.Forms.TextBox();
            this.textBoxEventEditor5 = new System.Windows.Forms.TextBox();
            this.nameOfEventChange = new System.Windows.Forms.TextBox();
            this.dateTimePickerEditor = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.infoOfEventChange = new System.Windows.Forms.TextBox();
            this.loadBtnEditor = new System.Windows.Forms.Button();
            this.deleteBtnEditor = new System.Windows.Forms.Button();
            this.unloadBtnEditor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEventEditor1
            // 
            this.textBoxEventEditor1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEventEditor1.Enabled = false;
            this.textBoxEventEditor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEventEditor1.Location = new System.Drawing.Point(64, 90);
            this.textBoxEventEditor1.Multiline = true;
            this.textBoxEventEditor1.Name = "textBoxEventEditor1";
            this.textBoxEventEditor1.ReadOnly = true;
            this.textBoxEventEditor1.Size = new System.Drawing.Size(424, 43);
            this.textBoxEventEditor1.TabIndex = 0;
            this.textBoxEventEditor1.Text = "Редактировать событие";
            // 
            // textBoxEventEditor2
            // 
            this.textBoxEventEditor2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxEventEditor2.Enabled = false;
            this.textBoxEventEditor2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxEventEditor2.Location = new System.Drawing.Point(64, 188);
            this.textBoxEventEditor2.Name = "textBoxEventEditor2";
            this.textBoxEventEditor2.ReadOnly = true;
            this.textBoxEventEditor2.Size = new System.Drawing.Size(150, 22);
            this.textBoxEventEditor2.TabIndex = 1;
            this.textBoxEventEditor2.Text = "Изменить название";
            // 
            // textBoxEventEditor3
            // 
            this.textBoxEventEditor3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxEventEditor3.Enabled = false;
            this.textBoxEventEditor3.Location = new System.Drawing.Point(64, 239);
            this.textBoxEventEditor3.Name = "textBoxEventEditor3";
            this.textBoxEventEditor3.ReadOnly = true;
            this.textBoxEventEditor3.Size = new System.Drawing.Size(150, 22);
            this.textBoxEventEditor3.TabIndex = 2;
            this.textBoxEventEditor3.Text = "Изменить дату";
            // 
            // textBoxEventEditor4
            // 
            this.textBoxEventEditor4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxEventEditor4.Enabled = false;
            this.textBoxEventEditor4.Location = new System.Drawing.Point(64, 291);
            this.textBoxEventEditor4.Name = "textBoxEventEditor4";
            this.textBoxEventEditor4.ReadOnly = true;
            this.textBoxEventEditor4.Size = new System.Drawing.Size(150, 22);
            this.textBoxEventEditor4.TabIndex = 3;
            this.textBoxEventEditor4.Text = "Выбрать категорию";
            // 
            // textBoxEventEditor5
            // 
            this.textBoxEventEditor5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxEventEditor5.Enabled = false;
            this.textBoxEventEditor5.Location = new System.Drawing.Point(64, 338);
            this.textBoxEventEditor5.Name = "textBoxEventEditor5";
            this.textBoxEventEditor5.ReadOnly = true;
            this.textBoxEventEditor5.Size = new System.Drawing.Size(150, 22);
            this.textBoxEventEditor5.TabIndex = 4;
            this.textBoxEventEditor5.Text = "Изменить описание";
            // 
            // nameOfEventChange
            // 
            this.nameOfEventChange.Location = new System.Drawing.Point(269, 188);
            this.nameOfEventChange.Multiline = true;
            this.nameOfEventChange.Name = "nameOfEventChange";
            this.nameOfEventChange.Size = new System.Drawing.Size(395, 22);
            this.nameOfEventChange.TabIndex = 5;
            this.nameOfEventChange.Click += new System.EventHandler(this.nameOfEventChange_Click);
            // 
            // dateTimePickerEditor
            // 
            this.dateTimePickerEditor.Location = new System.Drawing.Point(269, 238);
            this.dateTimePickerEditor.Name = "dateTimePickerEditor";
            this.dateTimePickerEditor.Size = new System.Drawing.Size(177, 22);
            this.dateTimePickerEditor.TabIndex = 6;
            this.dateTimePickerEditor.ValueChanged += new System.EventHandler(this.dateTimePickerEditor_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Тема 1",
            "Тема 2",
            "Тема 3"});
            this.comboBox1.Location = new System.Drawing.Point(269, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // infoOfEventChange
            // 
            this.infoOfEventChange.Location = new System.Drawing.Point(269, 338);
            this.infoOfEventChange.Multiline = true;
            this.infoOfEventChange.Name = "infoOfEventChange";
            this.infoOfEventChange.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoOfEventChange.Size = new System.Drawing.Size(395, 184);
            this.infoOfEventChange.TabIndex = 8;
            // 
            // loadBtnEditor
            // 
            this.loadBtnEditor.Location = new System.Drawing.Point(555, 570);
            this.loadBtnEditor.Name = "loadBtnEditor";
            this.loadBtnEditor.Size = new System.Drawing.Size(182, 29);
            this.loadBtnEditor.TabIndex = 9;
            this.loadBtnEditor.Text = "Сохранить изменения";
            this.loadBtnEditor.UseVisualStyleBackColor = true;
            this.loadBtnEditor.Click += new System.EventHandler(this.loadBtnEditor_Click);
            // 
            // deleteBtnEditor
            // 
            this.deleteBtnEditor.Location = new System.Drawing.Point(64, 570);
            this.deleteBtnEditor.Name = "deleteBtnEditor";
            this.deleteBtnEditor.Size = new System.Drawing.Size(150, 29);
            this.deleteBtnEditor.TabIndex = 10;
            this.deleteBtnEditor.Text = "Удалить событие";
            this.deleteBtnEditor.UseVisualStyleBackColor = true;
            this.deleteBtnEditor.Click += new System.EventHandler(this.deleteBtnEditor_Click);
            // 
            // unloadBtnEditor
            // 
            this.unloadBtnEditor.Location = new System.Drawing.Point(347, 570);
            this.unloadBtnEditor.Name = "unloadBtnEditor";
            this.unloadBtnEditor.Size = new System.Drawing.Size(182, 29);
            this.unloadBtnEditor.TabIndex = 11;
            this.unloadBtnEditor.Text = "Отменить изменения";
            this.unloadBtnEditor.UseVisualStyleBackColor = true;
            this.unloadBtnEditor.Click += new System.EventHandler(this.unloadBtnEditor_Click);
            // 
            // EventEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 661);
            this.Controls.Add(this.unloadBtnEditor);
            this.Controls.Add(this.deleteBtnEditor);
            this.Controls.Add(this.loadBtnEditor);
            this.Controls.Add(this.infoOfEventChange);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePickerEditor);
            this.Controls.Add(this.nameOfEventChange);
            this.Controls.Add(this.textBoxEventEditor5);
            this.Controls.Add(this.textBoxEventEditor4);
            this.Controls.Add(this.textBoxEventEditor3);
            this.Controls.Add(this.textBoxEventEditor2);
            this.Controls.Add(this.textBoxEventEditor1);
            this.Name = "EventEditor";
            this.Text = "EventEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEventEditor1;
        private System.Windows.Forms.TextBox textBoxEventEditor2;
        private System.Windows.Forms.TextBox textBoxEventEditor3;
        private System.Windows.Forms.TextBox textBoxEventEditor4;
        private System.Windows.Forms.TextBox textBoxEventEditor5;
        private System.Windows.Forms.TextBox nameOfEventChange;
        private System.Windows.Forms.DateTimePicker dateTimePickerEditor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox infoOfEventChange;
        private System.Windows.Forms.Button loadBtnEditor;
        private System.Windows.Forms.Button deleteBtnEditor;
        private System.Windows.Forms.Button unloadBtnEditor;
    }
}