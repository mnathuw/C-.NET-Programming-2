using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RRCAG.Data;

namespace RRCAGApp
{
    public partial class VehicleInformationForm : Form
    {
        public VehicleInformationForm(BindingSource bindingSourceVehicles)
        {
            InitializeComponent();

            BindControl(bindingSourceVehicles);
        }

        private void BindControl(BindingSource bindingSourceVehicles)
        {
            Binding stockIDBind = new Binding("Text", bindingSourceVehicles, "StockNumber");
            lblStock.DataBindings.Add(stockIDBind);

            Binding yearBind = new Binding("Text", bindingSourceVehicles, "ManufacturedYear");
            lblYea.DataBindings.Add(yearBind);

            Binding manufacturerBind = new Binding("Text", bindingSourceVehicles, "Make");
            lblManu.DataBindings.Add(manufacturerBind);

            Binding modelBind = new Binding("Text", bindingSourceVehicles, "Model");
            lblMode.DataBindings.Add(modelBind);

            Binding transmissionBind = new Binding("Text", bindingSourceVehicles, "Automatic");
            transmissionBind.Format += new ConvertEventHandler(IsAutomatic);
            lblTrans.DataBindings.Add(transmissionBind);

            Binding mileageBind = new Binding("Text", bindingSourceVehicles, "Mileage", true);
            mileageBind.FormatString = "n0";
            lblMile.DataBindings.Add(mileageBind);

            Binding colourrBind = new Binding("Text", bindingSourceVehicles, "Colour");
            lblColo.DataBindings.Add(colourrBind);

            Binding basePriceBind = new Binding("Text", bindingSourceVehicles, "BasePrice");
            basePriceBind.FormatString = "c";
            lblBase.DataBindings.Add(basePriceBind);

            this.Text = bindingSourceVehicles.Current.ToString();

        }

        private void IsAutomatic(object sender, ConvertEventArgs e)
        {
            if ((string)e.ToString() == "true")
            {
                e.Value = "Automatic";
            }
            else
            {
                e.Value = "Manual";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
