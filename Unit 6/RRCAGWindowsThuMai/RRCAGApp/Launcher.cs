﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRCAGApp
{
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void mnuFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
            SalesQuoteForm sales = new SalesQuoteForm();
            sales.ShowDialog();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuCarWash_Click(object sender, EventArgs e)
        {
            CarWashEntryForm carWashForm = new CarWashEntryForm();
            carWashForm.Show();
        }

        private void mnuVehicle_Click(object sender, EventArgs e)
        {
            VehicleDataForm vehicleDataForm = new VehicleDataForm();
            vehicleDataForm.ShowDialog();
        }
    }
}