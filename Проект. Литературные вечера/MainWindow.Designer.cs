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
            this.labelMainWindow = new System.Windows.Forms.Label();
            this.labelSort = new System.Windows.Forms.Label();
            this.comboSortType = new System.Windows.Forms.ComboBox();
            this.comboFilterParam = new System.Windows.Forms.ComboBox();
            this.listViewFilterResults = new System.Windows.Forms.ListView();
            this.btnResetFilters = new System.Windows.Forms.Button();
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
            this.listViewEvents.BackColor = System.Drawing.Color.Silver;
            this.listViewEvents.HideSelection = false;
            this.listViewEvents.Location = new System.Drawing.Point(260, 64);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(592, 507);
            this.listViewEvents.TabIndex = 1;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.DoubleClick += new System.EventHandler(this.listViewEvents_DoubleClick);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(700, 577);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(141, 27);
            this.btnCreateEvent.TabIndex = 4;
            this.btnCreateEvent.Text = "Создать событие";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // labelMainWindow
            // 
            this.labelMainWindow.AutoSize = true;
            this.labelMainWindow.BackColor = System.Drawing.Color.Silver;
            this.labelMainWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainWindow.Location = new System.Drawing.Point(409, 13);
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
            this.labelSort.BackColor = System.Drawing.Color.Silver;
            this.labelSort.Location = new System.Drawing.Point(28, 18);
            this.labelSort.MinimumSize = new System.Drawing.Size(200, 30);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(200, 30);
            this.labelSort.TabIndex = 6;
            this.labelSort.Text = "Фильтровать события";
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
            this.comboSortType.Location = new System.Drawing.Point(73, 51);
            this.comboSortType.Name = "comboSortType";
            this.comboSortType.Size = new System.Drawing.Size(155, 24);
            this.comboSortType.TabIndex = 7;
            this.comboSortType.SelectedIndexChanged += new System.EventHandler(this.comboSortType_SelectedIndexChanged);
            // 
            // comboFilterParam
            // 
            this.comboFilterParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterParam.FormattingEnabled = true;
            this.comboFilterParam.Location = new System.Drawing.Point(73, 75);
            this.comboFilterParam.Name = "comboFilterParam";
            this.comboFilterParam.Size = new System.Drawing.Size(155, 24);
            this.comboFilterParam.TabIndex = 8;
            this.comboFilterParam.Visible = false;
            this.comboFilterParam.SelectedIndexChanged += new System.EventHandler(this.comboFilterParam_SelectedIndexChanged);
            // 
            // listViewFilterResults
            // 
            this.listViewFilterResults.BackColor = System.Drawing.Color.Silver;
            this.listViewFilterResults.HideSelection = false;
            this.listViewFilterResults.Location = new System.Drawing.Point(12, 112);
            this.listViewFilterResults.Name = "listViewFilterResults";
            this.listViewFilterResults.Size = new System.Drawing.Size(228, 459);
            this.listViewFilterResults.TabIndex = 9;
            this.listViewFilterResults.UseCompatibleStateImageBehavior = false;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Location = new System.Drawing.Point(31, 580);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(197, 24);
            this.btnResetFilters.TabIndex = 10;
            this.btnResetFilters.Text = "Сбросить фильтры";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(853, 626);
            this.Controls.Add(this.btnResetFilters);
            this.Controls.Add(this.listViewFilterResults);
            this.Controls.Add(this.comboFilterParam);
            this.Controls.Add(this.comboSortType);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.labelMainWindow);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.listViewEvents);
            this.Controls.Add(this.splitter1);
            this.Name = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Label labelMainWindow;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.ComboBox comboSortType;
        private System.Windows.Forms.ComboBox comboFilterParam;
        private System.Windows.Forms.ListView listViewFilterResults;
        private System.Windows.Forms.Button btnResetFilters;
    }
   #endregion
}