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
    public partial class ChooseCar : Form
    {
        public ChooseCar()
        {
            InitializeComponent();
        }

        private void ChooseCar_Load(object sender, EventArgs e)
        {

        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            Confirmation frm = new Confirmation();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }
    }
}
