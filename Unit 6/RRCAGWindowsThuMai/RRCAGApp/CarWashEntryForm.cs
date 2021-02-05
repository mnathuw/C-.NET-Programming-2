using Mai.Thu.Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RRCAGApp
{
    public partial class CarWashEntryForm : Form
    {
        decimal packageCost = 0;
        decimal fragranceCost = 0;
        BindingList<string> interior = new BindingList<string>();
        BindingList<string> exterior = new BindingList<string>();
        BindingList<string> fragrance = new BindingList<string>();
        BindingList<string> package = new BindingList<string>();
        BindingList<decimal> packages = new BindingList<decimal>();
        BindingList<decimal> fragrances = new BindingList<decimal>();

        public CarWashEntryForm()
        {
            InitializeComponent();
            interior.Add("Fragrance");
            interior.Add("Shampoo Carpets");
            interior.Add("Shampoo Upholstery");
            interior.Add("Interior Protection Coat");

            exterior.Add("Hand Wash");
            exterior.Add("Hand Wax");
            exterior.Add("Wheel Polish");
            exterior.Add("Detail Engine Compartment");

            package.Add("Standard");
            package.Add("Deluxe");
            package.Add("Executive");
            package.Add("Luxury");

            packages.Add(7.5m);
            packages.Add(15m);
            packages.Add(35m);
            packages.Add(55m);

            fragrance.Add("Hawaiian Mist");
            fragrance.Add("Baby Powder");
            fragrance.Add("Pine");
            fragrance.Add("Country Floral");
            fragrance.Add("Pina Colada");
            fragrance.Add("Vanilla");

            fragrances.Add(2.75m);
            fragrances.Add(1.5m);
            fragrances.Add(0);
            fragrances.Add(2.25m);
            fragrances.Add(0.75m);
            fragrances.Add(2m);

            BindingSource bindingPackage = new BindingSource();
            bindingPackage.DataSource = package;
            this.cboPackage.DataSource = bindingPackage;

            BindingSource bindingFragrance = new BindingSource();
            bindingFragrance.DataSource = fragrance;
            this.cboFragrance.DataSource = bindingFragrance;

            cboFragrance.SelectedItem = "Pine";
            cboPackage.SelectedIndex = -1;
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            packageCost = 0;
            fragranceCost = 0;
            lstInterior.Items.Clear();
            lstExterior.Items.Clear();

            if (cboPackage.SelectedIndex == -1)
            {
                packageCost = packages[cboPackage.SelectedIndex + 1];
            }
            else
            {
                packageCost = packages[cboPackage.SelectedIndex];
            }

            if (cboFragrance.SelectedIndex == -1)
            {
                fragranceCost = fragrances[cboFragrance.SelectedIndex + 1];
            }
            else
            {
                fragranceCost = fragrances[cboFragrance.SelectedIndex];
            }

            interior[0] = String.Format("Fragrance - " + Convert.ToString(cboFragrance.SelectedItem));

            for (int i = 0; i <= cboPackage.SelectedIndex; i++)
            {
                lstInterior.Items.Add(interior[i]);
                lstExterior.Items.Add(exterior[i]);
            }

            if (Convert.ToString(cboPackage.SelectedItem) != "" && Convert.ToString(cboFragrance.SelectedItem) != "")
            {
                CarWashInvoice invoice = new CarWashInvoice(0.05m, 0.08m, packageCost, fragranceCost);
                lblSub.Text = String.Format("{0:c}", invoice.SubTotal);
                decimal pstCharged = invoice.ProvincialSalesTaxCharged;
                decimal gstCharged = invoice.GoodsAndServicesTaxCharged;
                lblPs.Text = pstCharged.ToString("n");
                lblGS.Text = gstCharged.ToString("n");
                lblTota.Text = String.Format("{0:c}", invoice.Total);
            }

            if (lblTota.Text != "")
            {
                mnuGenerateInvoice.Enabled = true;
            }
            else
            {
                mnuGenerateInvoice.Enabled = false;
            }
        }
        private void mnuGenerate_Click(object sender, EventArgs e)
        {
            CarWashInvoiceForm form = new CarWashInvoiceForm();
            form.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
