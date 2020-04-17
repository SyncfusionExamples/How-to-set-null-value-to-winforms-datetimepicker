namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePickerAdv1 = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv1.Calendar)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerAdv1
            // 
            this.dateTimePickerAdv1.BorderColor = System.Drawing.Color.Empty;
            // 
            // 
            // 
            this.dateTimePickerAdv1.Calendar.AllowMultipleSelection = false;
            this.dateTimePickerAdv1.Calendar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dateTimePickerAdv1.Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTimePickerAdv1.Calendar.BottomHeight = 33;
            this.dateTimePickerAdv1.Calendar.Culture = new System.Globalization.CultureInfo("en-US");
            this.dateTimePickerAdv1.Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerAdv1.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePickerAdv1.Calendar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerAdv1.Calendar.HighlightColor = System.Drawing.Color.Black;
            this.dateTimePickerAdv1.Calendar.Iso8601CalenderFormat = false;
            this.dateTimePickerAdv1.Calendar.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerAdv1.Calendar.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dateTimePickerAdv1.Calendar.Name = "monthCalendar";
            this.dateTimePickerAdv1.Calendar.Size = new System.Drawing.Size(306, 174);
            this.dateTimePickerAdv1.Calendar.SizeToFit = true;
            this.dateTimePickerAdv1.Calendar.TabIndex = 0;
            this.dateTimePickerAdv1.Calendar.WeekFont = new System.Drawing.Font("Verdana", 8F);
            // 
            // 
            // 
            this.dateTimePickerAdv1.Calendar.NoneButton.AutoSize = true;
            this.dateTimePickerAdv1.Calendar.NoneButton.BackColor = System.Drawing.SystemColors.Window;
            this.dateTimePickerAdv1.Calendar.NoneButton.Location = new System.Drawing.Point(233, 1);
            this.dateTimePickerAdv1.Calendar.NoneButton.Size = new System.Drawing.Size(72, 29);
            this.dateTimePickerAdv1.Calendar.NoneButton.Text = "None";
            this.dateTimePickerAdv1.Calendar.NoneButton.ThemeName = "None";
            this.dateTimePickerAdv1.Calendar.NoneButton.UseVisualStyle = false;
            // 
            // 
            // 
            this.dateTimePickerAdv1.Calendar.TodayButton.AutoSize = true;
            this.dateTimePickerAdv1.Calendar.TodayButton.BackColor = System.Drawing.SystemColors.Window;
            this.dateTimePickerAdv1.Calendar.TodayButton.Location = new System.Drawing.Point(2, 1);
            this.dateTimePickerAdv1.Calendar.TodayButton.Size = new System.Drawing.Size(231, 29);
            this.dateTimePickerAdv1.Calendar.TodayButton.Text = "Today";
            this.dateTimePickerAdv1.Calendar.TodayButton.ThemeName = "None";
            this.dateTimePickerAdv1.Calendar.TodayButton.UseVisualStyle = false;
            this.dateTimePickerAdv1.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerAdv1.CalendarSize = new System.Drawing.Size(189, 176);
            this.dateTimePickerAdv1.DropDownImage = null;
            this.dateTimePickerAdv1.DropDownNormalColor = System.Drawing.SystemColors.Control;
            this.dateTimePickerAdv1.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dateTimePickerAdv1.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.dateTimePickerAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAdv1.Location = new System.Drawing.Point(68, 102);
            this.dateTimePickerAdv1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dateTimePickerAdv1.MinValue = new System.DateTime(((long)(0)));
            this.dateTimePickerAdv1.Name = "dateTimePickerAdv1";
            this.dateTimePickerAdv1.NullString = "";
            this.dateTimePickerAdv1.ShowCheckBox = false;
            this.dateTimePickerAdv1.Size = new System.Drawing.Size(308, 24);
            this.dateTimePickerAdv1.TabIndex = 0;
            this.dateTimePickerAdv1.Value = new System.DateTime(2014, 7, 7, 1, 42, 23, 863);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 374);
            this.Controls.Add(this.dateTimePickerAdv1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.TitleBar.BackColor = System.Drawing.Color.Silver;
            this.Text = "DateTimePicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv1.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dateTimePickerAdv1;
    }
}

