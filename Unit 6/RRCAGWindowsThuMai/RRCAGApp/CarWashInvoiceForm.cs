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
    public partial class CarWashInvoiceForm : InvoiceForm 
    {
        public CarWashInvoiceForm()
        {
        }

        public CarWashInvoiceForm(CarWashInvoice invoice)
        {
            InitializeComponent();
            BindControls(invoice);
        }


        private void BindControls(CarWashInvoice carWashInvoice)
        {
            Binding packagePriceBind = new Binding("Text", carWashInvoice, "PackageCost");
            packagePriceBind.Format += new ConvertEventHandler(DecimalToCurrencyString);
            lblPackageP.DataBindings.Add(packagePriceBind);

            Binding fragrancePriceBind = new Binding("Text", carWashInvoice, "FragranceCost");
            fragrancePriceBind.Format += new ConvertEventHandler(DecimalToNumberString);
            lblFragranceP.DataBindings.Add(fragrancePriceBind);

            Binding subTotalBind = new Binding("Text", carWashInvoice, "SubTotal");
            subTotalBind.Format += new ConvertEventHandler(DecimalToCurrencyString);
            lblSubt.DataBindings.Add(subTotalBind);

            Binding taxesBind = new Binding("Text", carWashInvoice, "GoodsAndServicesTaxCharged");
            taxesBind.Format += new ConvertEventHandler(DecimalToNumberString);
            lblTaxe.DataBindings.Add(taxesBind);

            Binding totalBind = new Binding("Text", carWashInvoice, "Total");
            totalBind.Format += new ConvertEventHandler(DecimalToCurrencyString);
            lblTot.DataBindings.Add(totalBind);
        }
        private void DecimalToCurrencyString(object sender, ConvertEventArgs e)
        {
            // Use the ToString method to format the value as currency ("c").
            e.Value = ((decimal)e.Value).ToString("c");
        }

        private void DecimalToNumberString(object sender, ConvertEventArgs e)
        {
            // Use the ToString method to format the value as number ("n").
            e.Value = ((decimal)e.Value).ToString("n");
        }
    }
}
