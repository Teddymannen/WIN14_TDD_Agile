namespace CarRent
{
    partial class ChooseCar
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
            this.startDate = new System.Windows.Forms.MonthCalendar();
            this.endDate = new System.Windows.Forms.MonthCalendar();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.sportCar = new System.Windows.Forms.RadioButton();
            this.familyCar = new System.Windows.Forms.RadioButton();
            this.carType = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.dateTextLabel = new System.Windows.Forms.Label();
            this.cancleBtn = new System.Windows.Forms.Button();
            this.rentBtn = new System.Windows.Forms.Button();
            this.sportCarAlert = new System.Windows.Forms.Label();
            this.Today = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.startDate.Location = new System.Drawing.Point(32, 122);
            this.startDate.MaxSelectionCount = 1;
            this.startDate.Name = "startDate";
            this.startDate.TabIndex = 0;
            this.startDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.startDate_DateChanged);
            this.startDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.startDate_DateChanged);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(270, 122);
            this.endDate.MaxSelectionCount = 1;
            this.endDate.Name = "endDate";
            this.endDate.TabIndex = 1;
            this.endDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.endDate_DateChanged);
            this.endDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.endDate_DateChanged);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startDateLabel.Location = new System.Drawing.Point(28, 99);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(50, 20);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "From:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.endDateLabel.Location = new System.Drawing.Point(266, 99);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(31, 20);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "To:";
            // 
            // sportCar
            // 
            this.sportCar.AutoSize = true;
            this.sportCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sportCar.Location = new System.Drawing.Point(32, 355);
            this.sportCar.Name = "sportCar";
            this.sportCar.Size = new System.Drawing.Size(88, 24);
            this.sportCar.TabIndex = 4;
            this.sportCar.TabStop = true;
            this.sportCar.Text = "Sportcar";
            this.sportCar.UseVisualStyleBackColor = true;
            this.sportCar.CheckedChanged += new System.EventHandler(this.AlertBoxTrigger);
            // 
            // familyCar
            // 
            this.familyCar.AutoSize = true;
            this.familyCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.familyCar.Location = new System.Drawing.Point(143, 355);
            this.familyCar.Name = "familyCar";
            this.familyCar.Size = new System.Drawing.Size(94, 24);
            this.familyCar.TabIndex = 5;
            this.familyCar.TabStop = true;
            this.familyCar.Text = "Familycar";
            this.familyCar.UseVisualStyleBackColor = true;
            this.familyCar.CheckedChanged += new System.EventHandler(this.AlertBoxTrigger);
            // 
            // carType
            // 
            this.carType.AutoSize = true;
            this.carType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carType.Location = new System.Drawing.Point(28, 328);
            this.carType.Name = "carType";
            this.carType.Size = new System.Drawing.Size(313, 20);
            this.carType.TabIndex = 6;
            this.carType.Text = "Choose what cartype you would like to rent.";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(26, 10);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(126, 31);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = "Welcome";
            // 
            // dateTextLabel
            // 
            this.dateTextLabel.AutoSize = true;
            this.dateTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTextLabel.Location = new System.Drawing.Point(28, 48);
            this.dateTextLabel.Name = "dateTextLabel";
            this.dateTextLabel.Size = new System.Drawing.Size(279, 40);
            this.dateTextLabel.TabIndex = 8;
            this.dateTextLabel.Text = "How long would you like to rent a car? \r\nPlease choose a start and return date.";
            // 
            // cancleBtn
            // 
            this.cancleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancleBtn.Location = new System.Drawing.Point(334, 418);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(75, 39);
            this.cancleBtn.TabIndex = 9;
            this.cancleBtn.Text = "Cancel";
            this.cancleBtn.UseVisualStyleBackColor = true;
            this.cancleBtn.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // rentBtn
            // 
            this.rentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rentBtn.Location = new System.Drawing.Point(415, 418);
            this.rentBtn.Name = "rentBtn";
            this.rentBtn.Size = new System.Drawing.Size(75, 39);
            this.rentBtn.TabIndex = 10;
            this.rentBtn.Text = "Rent";
            this.rentBtn.UseVisualStyleBackColor = true;
            this.rentBtn.Click += new System.EventHandler(this.rentBtn_Click);
            // 
            // sportCarAlert
            // 
            this.sportCarAlert.AutoSize = true;
            this.sportCarAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sportCarAlert.ForeColor = System.Drawing.Color.Red;
            this.sportCarAlert.Location = new System.Drawing.Point(29, 388);
            this.sportCarAlert.Name = "sportCarAlert";
            this.sportCarAlert.Size = new System.Drawing.Size(280, 18);
            this.sportCarAlert.TabIndex = 11;
            this.sportCarAlert.Text = "Sportcar includes an extra insurance cost";
            this.sportCarAlert.Visible = false;
            // 
            // Today
            // 
            this.Today.AutoSize = true;
            this.Today.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Today.ForeColor = System.Drawing.Color.Red;
            this.Today.Location = new System.Drawing.Point(286, 466);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(204, 18);
            this.Today.TabIndex = 12;
            this.Today.Text = "End date cant be before today";
            // 
            // ChooseCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 497);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.sportCarAlert);
            this.Controls.Add(this.rentBtn);
            this.Controls.Add(this.cancleBtn);
            this.Controls.Add(this.dateTextLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.carType);
            this.Controls.Add(this.familyCar);
            this.Controls.Add(this.sportCar);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Name = "ChooseCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Car and Date";
            this.Load += new System.EventHandler(this.ChooseCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar startDate;
        private System.Windows.Forms.MonthCalendar endDate;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.RadioButton sportCar;
        private System.Windows.Forms.RadioButton familyCar;
        private System.Windows.Forms.Label carType;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label dateTextLabel;
        private System.Windows.Forms.Button cancleBtn;
        private System.Windows.Forms.Button rentBtn;
        private System.Windows.Forms.Label sportCarAlert;
        private System.Windows.Forms.Label Today;
    }
}

