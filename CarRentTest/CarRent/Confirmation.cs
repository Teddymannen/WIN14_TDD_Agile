﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class Confirmation : Form
    {
        Rent rent;
        public Confirmation(Rent rent)
        {
            InitializeComponent();
            this.rent = rent;
            StartDate.Text = rent.StartDate.ToShortDateString();
            EndDate.Text = rent.EndDate.ToShortDateString();
            CarType.Text = rent.SelectedCar.ToString();
            MileageCost.Text = rent.SelectedCar.MilageCost.ToString() + " kr/km";
            DailyFee.Text = rent.SelectedCar.DailyCost.ToString() + " kr/day";
            if (rent.SelectedCar is SportCar)
            {
                InsuranceLabel.Visible = true;
                ExtraInsurance.Visible = true;
                ExtraInsurance.Text = rent.SelectedCar.ExtraInsurance.ToString() + " kr";
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            ReturnCar frm = new ReturnCar(this.rent);
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            // Return to rent window
            this.Close();
            ChooseCar chooseCar = new ChooseCar();
            chooseCar.ShowDialog();
        }
    }
}
