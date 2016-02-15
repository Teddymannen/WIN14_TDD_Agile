namespace CarRent
{
    partial class ReturnCar
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
            this.welcomeAdmin = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalCostAmount = new System.Windows.Forms.Label();
            this.milesDrivenLabel = new System.Windows.Forms.Label();
            this.actualReturnDateLabel = new System.Windows.Forms.Label();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.milesDriven_TextBox = new System.Windows.Forms.TextBox();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.carType = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.daysBooked = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.actualDays = new System.Windows.Forms.Label();
            this.totalDailyCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalMilesCost = new System.Windows.Forms.Label();
            this.totalPenaltyCost = new System.Windows.Forms.Label();
            this.extraInsurance = new System.Windows.Forms.Label();
            this.extraInsuranceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeAdmin
            // 
            this.welcomeAdmin.AutoSize = true;
            this.welcomeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeAdmin.Location = new System.Drawing.Point(212, 9);
            this.welcomeAdmin.Name = "welcomeAdmin";
            this.welcomeAdmin.Size = new System.Drawing.Size(224, 31);
            this.welcomeAdmin.TabIndex = 0;
            this.welcomeAdmin.Text = "Welcome (admin)";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(26, 393);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 20);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "Total";
            // 
            // totalCostAmount
            // 
            this.totalCostAmount.AutoSize = true;
            this.totalCostAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalCostAmount.Location = new System.Drawing.Point(138, 393);
            this.totalCostAmount.Name = "totalCostAmount";
            this.totalCostAmount.Size = new System.Drawing.Size(54, 20);
            this.totalCostAmount.TabIndex = 2;
            this.totalCostAmount.Text = "$4000";
            // 
            // milesDrivenLabel
            // 
            this.milesDrivenLabel.AutoSize = true;
            this.milesDrivenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesDrivenLabel.Location = new System.Drawing.Point(20, 238);
            this.milesDrivenLabel.Name = "milesDrivenLabel";
            this.milesDrivenLabel.Size = new System.Drawing.Size(91, 20);
            this.milesDrivenLabel.TabIndex = 3;
            this.milesDrivenLabel.Text = "Miles driven";
            // 
            // actualReturnDateLabel
            // 
            this.actualReturnDateLabel.AutoSize = true;
            this.actualReturnDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualReturnDateLabel.Location = new System.Drawing.Point(20, 176);
            this.actualReturnDateLabel.Name = "actualReturnDateLabel";
            this.actualReturnDateLabel.Size = new System.Drawing.Size(97, 20);
            this.actualReturnDateLabel.TabIndex = 5;
            this.actualReturnDateLabel.Text = "Return Date";
            // 
            // returnDate
            // 
            this.returnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.returnDate.Location = new System.Drawing.Point(155, 174);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(200, 22);
            this.returnDate.TabIndex = 7;
            this.returnDate.ValueChanged += new System.EventHandler(this.returnDate_ValueChanged);
            // 
            // milesDriven_TextBox
            // 
            this.milesDriven_TextBox.Location = new System.Drawing.Point(154, 240);
            this.milesDriven_TextBox.Name = "milesDriven_TextBox";
            this.milesDriven_TextBox.Size = new System.Drawing.Size(100, 20);
            this.milesDriven_TextBox.TabIndex = 8;
            this.milesDriven_TextBox.TextChanged += new System.EventHandler(this.milesDriven_TextBox_TextChanged);
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carTypeLabel.Location = new System.Drawing.Point(20, 110);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(68, 20);
            this.carTypeLabel.TabIndex = 9;
            this.carTypeLabel.Text = "Car type";
            // 
            // carType
            // 
            this.carType.AutoSize = true;
            this.carType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.carType.Location = new System.Drawing.Point(152, 113);
            this.carType.Name = "carType";
            this.carType.Size = new System.Drawing.Size(80, 16);
            this.carType.TabIndex = 10;
            this.carType.Text = "placeholder";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(30, 416);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(65, 27);
            this.calcButton.TabIndex = 12;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Penalty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Days booked";
            // 
            // daysBooked
            // 
            this.daysBooked.AutoSize = true;
            this.daysBooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.daysBooked.Location = new System.Drawing.Point(152, 147);
            this.daysBooked.Name = "daysBooked";
            this.daysBooked.Size = new System.Drawing.Size(80, 16);
            this.daysBooked.TabIndex = 14;
            this.daysBooked.Text = "placeholder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total daily cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Actual days";
            // 
            // actualDays
            // 
            this.actualDays.AutoSize = true;
            this.actualDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.actualDays.Location = new System.Drawing.Point(152, 210);
            this.actualDays.Name = "actualDays";
            this.actualDays.Size = new System.Drawing.Size(80, 16);
            this.actualDays.TabIndex = 17;
            this.actualDays.Text = "placeholder";
            // 
            // totalDailyCost
            // 
            this.totalDailyCost.AutoSize = true;
            this.totalDailyCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.totalDailyCost.Location = new System.Drawing.Point(139, 271);
            this.totalDailyCost.Name = "totalDailyCost";
            this.totalDailyCost.Size = new System.Drawing.Size(125, 16);
            this.totalDailyCost.TabIndex = 18;
            this.totalDailyCost.Text = "days * cost-per-day";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Miles cost";
            // 
            // totalMilesCost
            // 
            this.totalMilesCost.AutoSize = true;
            this.totalMilesCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.totalMilesCost.Location = new System.Drawing.Point(139, 294);
            this.totalMilesCost.Name = "totalMilesCost";
            this.totalMilesCost.Size = new System.Drawing.Size(129, 16);
            this.totalMilesCost.TabIndex = 20;
            this.totalMilesCost.Text = "miles * cost-per-mile";
            // 
            // totalPenaltyCost
            // 
            this.totalPenaltyCost.AutoSize = true;
            this.totalPenaltyCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.totalPenaltyCost.Location = new System.Drawing.Point(139, 318);
            this.totalPenaltyCost.Name = "totalPenaltyCost";
            this.totalPenaltyCost.Size = new System.Drawing.Size(154, 16);
            this.totalPenaltyCost.TabIndex = 21;
            this.totalPenaltyCost.Text = "extradays * cost-per-day";
            // 
            // extraInsurance
            // 
            this.extraInsurance.AutoSize = true;
            this.extraInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.extraInsurance.Location = new System.Drawing.Point(139, 343);
            this.extraInsurance.Name = "extraInsurance";
            this.extraInsurance.Size = new System.Drawing.Size(95, 16);
            this.extraInsurance.TabIndex = 23;
            this.extraInsurance.Text = "extraInsurance";
            this.extraInsurance.Visible = false;
            // 
            // extraInsuranceLabel
            // 
            this.extraInsuranceLabel.AutoSize = true;
            this.extraInsuranceLabel.Location = new System.Drawing.Point(21, 343);
            this.extraInsuranceLabel.Name = "extraInsuranceLabel";
            this.extraInsuranceLabel.Size = new System.Drawing.Size(80, 13);
            this.extraInsuranceLabel.TabIndex = 22;
            this.extraInsuranceLabel.Text = "Extra insurance";
            this.extraInsuranceLabel.Visible = false;
            // 
            // ReturnCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 457);
            this.Controls.Add(this.extraInsurance);
            this.Controls.Add(this.extraInsuranceLabel);
            this.Controls.Add(this.totalPenaltyCost);
            this.Controls.Add(this.totalMilesCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalDailyCost);
            this.Controls.Add(this.actualDays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daysBooked);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.carType);
            this.Controls.Add(this.carTypeLabel);
            this.Controls.Add(this.milesDriven_TextBox);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.actualReturnDateLabel);
            this.Controls.Add(this.milesDrivenLabel);
            this.Controls.Add(this.totalCostAmount);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.welcomeAdmin);
            this.Name = "ReturnCar";
            this.Text = "ReturnCar";
            this.Load += new System.EventHandler(this.ReturnCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeAdmin;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalCostAmount;
        private System.Windows.Forms.Label milesDrivenLabel;
        private System.Windows.Forms.Label actualReturnDateLabel;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.TextBox milesDriven_TextBox;
        private System.Windows.Forms.Label carTypeLabel;
        private System.Windows.Forms.Label carType;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label daysBooked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label actualDays;
        private System.Windows.Forms.Label totalDailyCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalMilesCost;
        private System.Windows.Forms.Label totalPenaltyCost;
        private System.Windows.Forms.Label extraInsurance;
        private System.Windows.Forms.Label extraInsuranceLabel;
    }
}