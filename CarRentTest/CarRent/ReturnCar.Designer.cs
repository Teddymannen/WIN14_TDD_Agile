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
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalCostAmount = new System.Windows.Forms.Label();
            this.milesDrivenAmount = new System.Windows.Forms.Label();
            this.milesDrivenLabel = new System.Windows.Forms.Label();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome back";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(13, 346);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 20);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "Total";
            // 
            // totalCostAmount
            // 
            this.totalCostAmount.AutoSize = true;
            this.totalCostAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalCostAmount.Location = new System.Drawing.Point(78, 346);
            this.totalCostAmount.Name = "totalCostAmount";
            this.totalCostAmount.Size = new System.Drawing.Size(54, 20);
            this.totalCostAmount.TabIndex = 2;
            this.totalCostAmount.Text = "$4000";
            // 
            // milesDrivenAmount
            // 
            this.milesDrivenAmount.AutoSize = true;
            this.milesDrivenAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.milesDrivenAmount.Location = new System.Drawing.Point(109, 227);
            this.milesDrivenAmount.Name = "milesDrivenAmount";
            this.milesDrivenAmount.Size = new System.Drawing.Size(36, 20);
            this.milesDrivenAmount.TabIndex = 4;
            this.milesDrivenAmount.Text = "200";
            // 
            // milesDrivenLabel
            // 
            this.milesDrivenLabel.AutoSize = true;
            this.milesDrivenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesDrivenLabel.Location = new System.Drawing.Point(12, 227);
            this.milesDrivenLabel.Name = "milesDrivenLabel";
            this.milesDrivenLabel.Size = new System.Drawing.Size(91, 20);
            this.milesDrivenLabel.TabIndex = 3;
            this.milesDrivenLabel.Text = "Miles driven";
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateLabel.Location = new System.Drawing.Point(12, 173);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(97, 20);
            this.returnDateLabel.TabIndex = 5;
            this.returnDateLabel.Text = "Return Date";
            // 
            // returnDate
            // 
            this.returnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.returnDate.Location = new System.Drawing.Point(129, 173);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(200, 26);
            this.returnDate.TabIndex = 7;
            // 
            // ReturnCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 457);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.returnDateLabel);
            this.Controls.Add(this.milesDrivenAmount);
            this.Controls.Add(this.milesDrivenLabel);
            this.Controls.Add(this.totalCostAmount);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label1);
            this.Name = "ReturnCar";
            this.Text = "ReturnCar";
            this.Load += new System.EventHandler(this.ReturnCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalCostAmount;
        private System.Windows.Forms.Label milesDrivenAmount;
        private System.Windows.Forms.Label milesDrivenLabel;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.DateTimePicker returnDate;
    }
}