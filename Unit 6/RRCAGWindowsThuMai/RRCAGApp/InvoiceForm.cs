using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mai.Thu.Business;

namespace RRCAGApp
{
    public partial class InvoiceForm : Form 
    {
        public InvoiceForm()
        {
            InitializeComponent();
            lblInvoiceTitle.Text = "Car Wash Invoice";
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            BindControls();
        }

        private string companyName = "RRC Automotive Group";
        private string address = "777 Inheritance Drive";
        private string city = "Winnipeg, Manitoba, I0I 0I0";
        private string phone = "204-867-5309";
        private string date = DateTime.Now.ToString("M-dd-yyyy");


        private void BindControls()
        {
            Binding companyNameBind = new Binding("Text", companyName, null);
            this.lblCompanyName.DataBindings.Add(companyNameBind);

            Binding addressBind = new Binding("Text", address, null);
            this.lblAddress.DataBindings.Add(addressBind);

            Binding cityBind = new Binding("Text", city, null);
            this.lblCity.DataBindings.Add(cityBind);

            Binding phoneBind = new Binding("Text", phone, null);
            this.lblPhone.DataBindings.Add(phoneBind);

            Binding dateBind = new Binding("Text", date, null);
            this.lblDat.DataBindings.Add(dateBind);
        }
    }
}
