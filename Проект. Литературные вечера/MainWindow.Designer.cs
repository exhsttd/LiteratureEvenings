﻿namespace Проект.Литературные_вечера
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.labelMainWindow = new System.Windows.Forms.Label();
            this.labelSort = new System.Windows.Forms.Label();
            this.comboSortType = new System.Windows.Forms.ComboBox();
            this.comboFilterParam = new System.Windows.Forms.ComboBox();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewEvents
            // 
            this.listViewEvents.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listViewEvents.HideSelection = false;
            this.listViewEvents.Location = new System.Drawing.Point(32, 129);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(522, 367);
            this.listViewEvents.TabIndex = 1;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.DoubleClick += new System.EventHandler(this.listViewEvents_DoubleClick);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateEvent.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateEvent.Location = new System.Drawing.Point(42, 516);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(167, 27);
            this.btnCreateEvent.TabIndex = 4;
            this.btnCreateEvent.Text = "Создать событие";
            this.btnCreateEvent.UseVisualStyleBackColor = false;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // labelMainWindow
            // 
            this.labelMainWindow.AutoSize = true;
            this.labelMainWindow.BackColor = System.Drawing.Color.Peru;
            this.labelMainWindow.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainWindow.Location = new System.Drawing.Point(64, 76);
            this.labelMainWindow.MinimumSize = new System.Drawing.Size(300, 40);
            this.labelMainWindow.Name = "labelMainWindow";
            this.labelMainWindow.Size = new System.Drawing.Size(300, 40);
            this.labelMainWindow.TabIndex = 5;
            this.labelMainWindow.Text = "Список событий";
            this.labelMainWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.BackColor = System.Drawing.Color.Peru;
            this.labelSort.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSort.Location = new System.Drawing.Point(570, 129);
            this.labelSort.MinimumSize = new System.Drawing.Size(200, 30);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(200, 30);
            this.labelSort.TabIndex = 6;
            this.labelSort.Text = "Фильтровать события по";
            this.labelSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboSortType
            // 
            this.comboSortType.AutoCompleteCustomSource.AddRange(new string[] {
            "По дате",
            "По категории"});
            this.comboSortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSortType.FormattingEnabled = true;
            this.comboSortType.Items.AddRange(new object[] {
            "По дате",
            "По категории"});
            this.comboSortType.Location = new System.Drawing.Point(573, 172);
            this.comboSortType.Name = "comboSortType";
            this.comboSortType.Size = new System.Drawing.Size(155, 26);
            this.comboSortType.TabIndex = 7;
            this.comboSortType.SelectedIndexChanged += new System.EventHandler(this.comboSortType_SelectedIndexChanged);
            // 
            // comboFilterParam
            // 
            this.comboFilterParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterParam.FormattingEnabled = true;
            this.comboFilterParam.Location = new System.Drawing.Point(573, 202);
            this.comboFilterParam.Name = "comboFilterParam";
            this.comboFilterParam.Size = new System.Drawing.Size(155, 26);
            this.comboFilterParam.TabIndex = 8;
            this.comboFilterParam.Visible = false;
            this.comboFilterParam.SelectedIndexChanged += new System.EventHandler(this.comboFilterParam_SelectedIndexChanged);
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.BackColor = System.Drawing.Color.Peru;
            this.btnResetFilters.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetFilters.Location = new System.Drawing.Point(379, 515);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(167, 27);
            this.btnResetFilters.TabIndex = 12;
            this.btnResetFilters.Text = "Сбросить фильтры";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Peru;
            this.btnGenerate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerate.Location = new System.Drawing.Point(573, 235);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(197, 27);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Генерировать отчет ";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = global::Проект.Литературные_вечера.Properties.Resources.library_small1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 679);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnResetFilters);
            this.Controls.Add(this.comboFilterParam);
            this.Controls.Add(this.comboSortType);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.labelMainWindow);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.listViewEvents);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Список событий";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Label labelMainWindow;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.ComboBox comboSortType;
        private System.Windows.Forms.ComboBox comboFilterParam;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnGenerate;
    }
   #endregion
}