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
    public partial class Confirmation : Form
    {

        public Confirmation()
        {
            InitializeComponent();
            StartDate.Text = "";
            EndDate.Text = "";
            CarType.Text = "";
            MileageCost.Text = "";
            DailyFee.Text = "";
        }
        public Confirmation(Rent rent)
        {
            InitializeComponent();
            StartDate.Text = rent.StartDate.ToShortDateString();
            EndDate.Text = rent.EndDate.ToShortDateString();
            CarType.Text = rent.SelectedCar.ToString();
            MileageCost.Text = rent.SelectedCar.MilageCost.ToString();
            DailyFee.Text = rent.SelectedCar.DailyCost.ToString();
            if (rent.SelectedCar is SportCar)
            {
                InsuranceLabel.Visible = true;
                ExtraInsurance.Visible = true;
                ExtraInsurance.Text = rent.SelectedCar.ExtraInsurance.ToString();
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            ReturnCar frm = new ReturnCar();
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
