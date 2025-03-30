namespace Проект.Литературные_вечера
{
    partial class EventInfo
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
            this.editbtn1 = new System.Windows.Forms.Button();
            this.infoOfEvent = new System.Windows.Forms.TextBox();
            this.nameOfEvent = new System.Windows.Forms.TextBox();
            this.cotegoryInfoEvent = new System.Windows.Forms.TextBox();
            this.dateInfoEvent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editbtn1
            // 
            this.editbtn1.Location = new System.Drawing.Point(541, 539);
            this.editbtn1.Name = "editbtn1";
            this.editbtn1.Size = new System.Drawing.Size(203, 29);
            this.editbtn1.TabIndex = 0;
            this.editbtn1.Text = "Редактировать событие";
            this.editbtn1.UseVisualStyleBackColor = true;
            this.editbtn1.Click += new System.EventHandler(this.editbtn1_Click);
            // 
            // infoOfEvent
            // 
            this.infoOfEvent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoOfEvent.Location = new System.Drawing.Point(111, 196);
            this.infoOfEvent.Multiline = true;
            this.infoOfEvent.Name = "infoOfEvent";
            this.infoOfEvent.ReadOnly = true;
            this.infoOfEvent.Size = new System.Drawing.Size(576, 311);
            this.infoOfEvent.TabIndex = 2;
            this.infoOfEvent.Text = "Информация о событии";
            this.infoOfEvent.TextChanged += new System.EventHandler(this.infoOfEvent_TextChanged);
            // 
            // nameOfEvent
            // 
            this.nameOfEvent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameOfEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameOfEvent.Location = new System.Drawing.Point(130, 68);
            this.nameOfEvent.Multiline = true;
            this.nameOfEvent.Name = "nameOfEvent";
            this.nameOfEvent.ReadOnly = true;
            this.nameOfEvent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameOfEvent.Size = new System.Drawing.Size(526, 44);
            this.nameOfEvent.TabIndex = 3;
            this.nameOfEvent.Text = "Название события";
            this.nameOfEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameOfEvent.UseWaitCursor = true;
            // 
            // cotegoryInfoEvent
            // 
            this.cotegoryInfoEvent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cotegoryInfoEvent.Location = new System.Drawing.Point(326, 132);
            this.cotegoryInfoEvent.Multiline = true;
            this.cotegoryInfoEvent.Name = "cotegoryInfoEvent";
            this.cotegoryInfoEvent.ReadOnly = true;
            this.cotegoryInfoEvent.Size = new System.Drawing.Size(171, 30);
            this.cotegoryInfoEvent.TabIndex = 5;
            this.cotegoryInfoEvent.Text = "Категория";
            this.cotegoryInfoEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateInfoEvent
            // 
            this.dateInfoEvent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateInfoEvent.Location = new System.Drawing.Point(521, 132);
            this.dateInfoEvent.Multiline = true;
            this.dateInfoEvent.Name = "dateInfoEvent";
            this.dateInfoEvent.ReadOnly = true;
            this.dateInfoEvent.Size = new System.Drawing.Size(166, 30);
            this.dateInfoEvent.TabIndex = 6;
            this.dateInfoEvent.Text = "Дата проведения";
            this.dateInfoEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EventInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 625);
            this.Controls.Add(this.dateInfoEvent);
            this.Controls.Add(this.cotegoryInfoEvent);
            this.Controls.Add(this.nameOfEvent);
            this.Controls.Add(this.infoOfEvent);
            this.Controls.Add(this.editbtn1);
            this.Name = "EventInfo";
            this.Text = "EnentInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editbtn1;
        private System.Windows.Forms.TextBox infoOfEvent;
        private System.Windows.Forms.TextBox nameOfEvent;
        private System.Windows.Forms.TextBox cotegoryInfoEvent;
        private System.Windows.Forms.TextBox dateInfoEvent;
    }
}