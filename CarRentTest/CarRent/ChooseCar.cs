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
    public partial class ChooseCar : Form
    {
        Rent rent;
        public ChooseCar()
        {
            InitializeComponent();
            rent = new Rent();
            rent.StartDate = startDate.SelectionRange.Start;
        }

        private void ChooseCar_Load(object sender, EventArgs e)
        {

            

        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            Confirmation frm = new Confirmation(rent);
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }

        public void startDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            rent.StartDate = startDate.SelectionRange.Start; 
        }

        private void endDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            rent.EndDate = endDate.SelectionRange.Start;
        }

        private void AlertBoxTrigger(object sender, EventArgs e)
        {
            if(sportCar.Checked)
            {
                sportCarAlert.Visible = true;
                rent.ChooseCar("sportcar");
            }
            else
            {
                rent.ChooseCar("familycar");
                sportCarAlert.Visible = false;
            }
            
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            // This will close the Rent window.
            this.Close();
        }
    }
}
