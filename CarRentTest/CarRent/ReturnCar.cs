using System;
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
    public partial class ReturnCar : Form
    {
        Rent rent;

        public ReturnCar(Rent rent)
        {
            InitializeComponent();
            this.rent = rent;
            carType.Text = rent.SelectedCar.ToString();
            daysBooked.Text = rent.calcDaysRent(rent.StartDate, rent.EndDate).ToString();
            returnDate.Value = rent.EndDate;
            actualDays.Text = rent.Days.ToString();
            totalDailyCost.Text = (rent.SelectedCar.DailyCost * rent.Days).ToString();
            totalMilesCost.Text = "0";
            totalPenaltyCost.Text = "0";
            totalCostAmount.Text = "0";
        }

        private void ReturnCar_Load(object sender, EventArgs e)
        {

        }

        private void returnDate_ValueChanged(object sender, EventArgs e)
        {
            actualDays.Text = rent.calcDaysRent(rent.StartDate, returnDate.Value).ToString();
            totalDailyCost.Text = (rent.SelectedCar.DailyCost * rent.Days).ToString();
            rent.CalculatePenaltyOrDiscount(returnDate.Value);
            totalPenaltyCost.Text = rent.penaltyCost.ToString();
        }

        private void milesDriven_TextBox_TextChanged(object sender, EventArgs e)
        {
            if(milesDriven_TextBox.Text != string.Empty)
            {
                totalMilesCost.Text = (double.Parse(milesDriven_TextBox.Text) * rent.SelectedCar.MilageCost).ToString();
            }
            else
            {
                totalMilesCost.Text = "0";
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            totalCostAmount.Text = rent.CalcTotal(double.Parse(milesDriven_TextBox.Text), rent.Days, carType.Text).ToString();
        }
    }
}
