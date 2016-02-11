﻿namespace CarRent
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
            this.returnDate = new System.Windows.Forms.MonthCalendar();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.sportCar = new System.Windows.Forms.RadioButton();
            this.familyCar = new System.Windows.Forms.RadioButton();
            this.carType = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.dateTextLabel = new System.Windows.Forms.Label();
            this.cancleBtn = new System.Windows.Forms.Button();
            this.rentBtn = new System.Windows.Forms.Button();
            this.sportCarAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(43, 167);
            this.startDate.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.startDate.Name = "startDate";
            this.startDate.TabIndex = 0;
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(360, 167);
            this.returnDate.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.returnDate.Name = "returnDate";
            this.returnDate.TabIndex = 1;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startDateLabel.Location = new System.Drawing.Point(37, 143);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(99, 25);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "Start Date";
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.returnDateLabel.Location = new System.Drawing.Point(355, 143);
            this.returnDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(115, 25);
            this.returnDateLabel.TabIndex = 3;
            this.returnDateLabel.Text = "Return Date";
            // 
            // sportCar
            // 
            this.sportCar.AutoSize = true;
            this.sportCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sportCar.Location = new System.Drawing.Point(43, 437);
            this.sportCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sportCar.Name = "sportCar";
            this.sportCar.Size = new System.Drawing.Size(107, 29);
            this.sportCar.TabIndex = 4;
            this.sportCar.TabStop = true;
            this.sportCar.Text = "Sportcar";
            this.sportCar.UseVisualStyleBackColor = true;
            // 
            // familyCar
            // 
            this.familyCar.AutoSize = true;
            this.familyCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.familyCar.Location = new System.Drawing.Point(191, 437);
            this.familyCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.familyCar.Name = "familyCar";
            this.familyCar.Size = new System.Drawing.Size(117, 29);
            this.familyCar.TabIndex = 5;
            this.familyCar.TabStop = true;
            this.familyCar.Text = "Familycar";
            this.familyCar.UseVisualStyleBackColor = true;
            // 
            // carType
            // 
            this.carType.AutoSize = true;
            this.carType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carType.Location = new System.Drawing.Point(37, 404);
            this.carType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carType.Name = "carType";
            this.carType.Size = new System.Drawing.Size(387, 25);
            this.carType.TabIndex = 6;
            this.carType.Text = "Choose what cartype you would like to rent.";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(35, 17);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(159, 39);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = "Welcome";
            // 
            // dateTextLabel
            // 
            this.dateTextLabel.AutoSize = true;
            this.dateTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTextLabel.Location = new System.Drawing.Point(37, 73);
            this.dateTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateTextLabel.Name = "dateTextLabel";
            this.dateTextLabel.Size = new System.Drawing.Size(343, 50);
            this.dateTextLabel.TabIndex = 8;
            this.dateTextLabel.Text = "How long would you like to rent a car? \r\nPlease choose a start and return date.";
            // 
            // cancleBtn
            // 
            this.cancleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancleBtn.Location = new System.Drawing.Point(445, 514);
            this.cancleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(100, 48);
            this.cancleBtn.TabIndex = 9;
            this.cancleBtn.Text = "Cancle";
            this.cancleBtn.UseVisualStyleBackColor = true;
            // 
            // rentBtn
            // 
            this.rentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rentBtn.Location = new System.Drawing.Point(553, 514);
            this.rentBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rentBtn.Name = "rentBtn";
            this.rentBtn.Size = new System.Drawing.Size(100, 48);
            this.rentBtn.TabIndex = 10;
            this.rentBtn.Text = "Rent";
            this.rentBtn.UseVisualStyleBackColor = true;
            // 
            // sportCarAlert
            // 
            this.sportCarAlert.AutoSize = true;
            this.sportCarAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.sportCarAlert.ForeColor = System.Drawing.Color.Red;
            this.sportCarAlert.Location = new System.Drawing.Point(39, 478);
            this.sportCarAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sportCarAlert.Name = "sportCarAlert";
            this.sportCarAlert.Size = new System.Drawing.Size(340, 22);
            this.sportCarAlert.TabIndex = 11;
            this.sportCarAlert.Text = "Sportcar includes an extra insurance cost";
            // 
            // ChooseCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 588);
            this.Controls.Add(this.sportCarAlert);
            this.Controls.Add(this.rentBtn);
            this.Controls.Add(this.cancleBtn);
            this.Controls.Add(this.dateTextLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.carType);
            this.Controls.Add(this.familyCar);
            this.Controls.Add(this.sportCar);
            this.Controls.Add(this.returnDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.startDate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChooseCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Car and Date";
            this.Load += new System.EventHandler(this.ChooseCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar startDate;
        private System.Windows.Forms.MonthCalendar returnDate;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.RadioButton sportCar;
        private System.Windows.Forms.RadioButton familyCar;
        private System.Windows.Forms.Label carType;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label dateTextLabel;
        private System.Windows.Forms.Button cancleBtn;
        private System.Windows.Forms.Button rentBtn;
        private System.Windows.Forms.Label sportCarAlert;
    }
}
