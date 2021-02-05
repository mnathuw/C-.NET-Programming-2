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
using RRCAG.Data;
using System.Data.OleDb;

namespace RRCAGApp
{
    public partial class SalesQuoteForm : Form
    {
        private BindingSource _bindingSource;

        public SalesQuoteForm()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = DataRetriever.GetVehicles();

            cboVehicle.DataSource = _bindingSource;
            cboVehicle.DisplayMember = "stockID";
            cboVehicle.ValueMember = "basePrice";
            cboVehicle.SelectedIndex = -1;
            cboVehicle.Focus();
            InputControls();
        }

        private void Clear()
        {
            txtTradeIn.Text = String.Empty;
            lblVehicle.Text = String.Empty;
            lblOption.Text = String.Empty;
            lblSales.Text = String.Empty;
            lblSub.Text = String.Empty;
            lblTota.Text = String.Empty;
            lblTrade.Text = String.Empty;
            lblAmount.Text = String.Empty;
            lblMonthlyPayment.Text = String.Empty;
        }

        /// <summary>
        /// Handle the event when selectedindex of cboVechicleInformation changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            if (lblSales.Text != "")
            {
                Clear();
            }
            if (cboVehicle.SelectedIndex > -1)
            {
                mnuViewVehicle.Enabled = true;
            }
        }

        private void errorVehicleSelected()
        {
            errorProvider1.SetError(cboVehicle, "A vehicle must be selected.");
            errorProvider1.SetIconPadding(cboVehicle, 3);
            Clear();
        }

        private void errorTradeRequiredField()
        {
            errorProvider2.SetError(txtTradeIn, "Trade-in value is a required field.");
            errorProvider2.SetIconPadding(txtTradeIn, 3);
            Clear();
        }

        private void errorTradeContain()
        {
            errorProvider2.SetError(txtTradeIn, "Trade-in value cannot contain letters or special characters");
            errorProvider2.SetIconPadding(txtTradeIn, 3);
            Clear();
        }

        private void errorTradeLess()
        {
            errorProvider2.SetError(txtTradeIn, "Trade-in value cannot less or equal to 0");
            errorProvider2.SetIconPadding(txtTradeIn, 3);
            Clear();
        }

        private void errorTradeExceed()
        {
            errorProvider2.SetError(txtTradeIn, "Trade-in value cannot exceed the vehicle sale price");
            errorProvider2.SetIconPadding(txtTradeIn, 3);
            Clear();
        }

        decimal tradeInValue = 1M;
        decimal vehicleSalePrice = 1M;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            mnuViewVehicle.Visible = true;
            if (cboVehicle.SelectedItem == null)
            {
                errorVehicleSelected();
                if (txtTradeIn.Text == "")
                {
                    errorTradeRequiredField();
                }
                else if (!decimal.TryParse(txtTradeIn.Text, out tradeInValue))
                {
                    errorTradeContain();
                }
                else if (tradeInValue < 0)
                {
                    errorTradeLess();
                }
                else if (tradeInValue > vehicleSalePrice)
                {
                    errorTradeExceed();
                }
                else
                {
                    errorProvider2.SetError(txtTradeIn, "");
                    errorProvider2.Clear();
                }
            }

            else
            {
                if (tradeInValue > vehicleSalePrice)
                {
                    errorTradeExceed();
                }
                else
                {

                    summary_TextChanged();

                    errorProvider1.SetError(cboVehicle, "");
                    errorProvider1.Clear();

                    errorProvider2.SetError(txtTradeIn, "");
                    errorProvider2.Clear();
                }

            }
        }

        private void summary_TextChanged()
        {
            vehicleSalePrice = Convert.ToDecimal(cboVehicle.SelectedValue);
            tradeInValue = decimal.Parse(txtTradeIn.Text);

            lblVehicle.Text = vehicleSalePrice.ToString("C2");

            lblTrade.Text = tradeInValue.ToString("-#0,0.00");

            SalesQuote sale1 = new SalesQuote(vehicleSalePrice, tradeInValue, .13M);

            void exteriorFinish_Checked()
            {
                if (radStandard.Checked && !radPearlized.Checked && !radCustomizedDetailing.Checked)
                {
                    sale1.ExteriorFinishChosen = ExteriorFinish.Standard;
                }

                else if (radPearlized.Checked && !radStandard.Checked && !radCustomizedDetailing.Checked)
                {
                    sale1.ExteriorFinishChosen = ExteriorFinish.Pearlized;
                }

                else if (radCustomizedDetailing.Checked && !radStandard.Checked && !radPearlized.Checked)
                {
                    sale1.ExteriorFinishChosen = ExteriorFinish.Custom;
                }
            }

            if (!chkLeatherInterior.Checked && !chkComputerNavigation.Checked && !chkStereoSystem.Checked)
            {
                sale1.AccessoriesChosen = Accessories.None;
                exteriorFinish_Checked();
            }

            else if (chkLeatherInterior.Checked && !chkComputerNavigation.Checked && !chkStereoSystem.Checked)
            {
                sale1.AccessoriesChosen = Accessories.LeatherInterior;
                exteriorFinish_Checked();
            }

            else if (chkLeatherInterior.Checked && chkComputerNavigation.Checked && !chkStereoSystem.Checked)
            {
                sale1.AccessoriesChosen = Accessories.LeatherAndNavigation;
                exteriorFinish_Checked();
            }

            else if (chkLeatherInterior.Checked && chkComputerNavigation.Checked && chkStereoSystem.Checked)
            {
                sale1.AccessoriesChosen = Accessories.All;
                exteriorFinish_Checked();
            }

            else if (!chkLeatherInterior.Checked && !chkComputerNavigation.Checked && chkStereoSystem.Checked)
            {
                sale1.AccessoriesChosen = Accessories.StereoSystem;
                exteriorFinish_Checked();
            }

            else if (!chkLeatherInterior.Checked && chkComputerNavigation.Checked && !chkStereoSystem.Checked)
            {
                sale1.AccessoriesChosen = Accessories.ComputerNavigation;
                exteriorFinish_Checked();
            }

            else if (!chkLeatherInterior.Checked && chkComputerNavigation.Checked && chkStereoSystem.Checked)
            {
                sale1.AccessoriesChosen = Accessories.StereoAndNavigation;
                exteriorFinish_Checked();
            }

            else if (chkLeatherInterior.Checked && !chkComputerNavigation.Checked && chkStereoSystem.Checked)
            {
                sale1.AccessoriesChosen = Accessories.StereoAndLeather;
                exteriorFinish_Checked();
            }

            decimal option = sale1.FinishCost + sale1.AccessoryCost;

            lblOption.Text = option.ToString("#0,0.00");

            lblSub.Text = sale1.SubTotal.ToString("C2");

            lblSales.Text = sale1.SalesTax.ToString("#0,0.00");

            decimal total = sale1.SubTotal + sale1.SalesTax;

            lblTota.Text = total.ToString("C2");

            lblAmount.Text = sale1.AmountDue.ToString("C2");

            nudAnnualInterestRate.Text = decimal.TryParse(nudAnnualInterestRate.Text, out decimal rate).ToString();
            nudNoOfYears.Text = int.TryParse(nudNoOfYears.Text, out int numberOfPaymentPeriods).ToString();

            rate /= 100;
            numberOfPaymentPeriods *= 12;

            lblMonthlyPayment.Text = Financial.GetPayment(rate, numberOfPaymentPeriods, sale1.AmountDue).ToString("C2");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to reset the form?", "Reset Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Utilities.ResetAllControls(this);
                radPearlized.Checked = false;
                radCustomizedDetailing.Checked = false;
                radStandard.Checked = true;
                chkComputerNavigation.Checked = false;
                chkLeatherInterior.Checked = false;
                chkStereoSystem.Checked = false;
                nud_Clear();
                cboVehicle.SelectedValue = "";
                cboVehicle.Focus();

            }
        }

        public class Utilities
        {
            public static void ResetAllControls(Control form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.Text = null;
                    }

                    if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.Items.Count > 0)
                            comboBox.SelectedIndex = 0;
                    }

                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        checkBox.Checked = false;
                    }

                    if (control is ListBox)
                    {
                        ListBox listBox = (ListBox)control;
                        listBox.ClearSelected();
                    }
                }
            }
        }


        private void tradeInValue_TextChanged(object sender, EventArgs e)
        {
            if (txtTradeIn.Text == "")
            {
                Clear();
            }
        }

        private void stereo_CheckedChanged(object sender, EventArgs e)
        {
            checkedChanged();
        }

        private void leather_CheckedChanged(object sender, EventArgs e)
        {
            checkedChanged();
        }

        private void computer_CheckedChanged(object sender, EventArgs e)
        {
            checkedChanged();
        }

        private void standard_CheckedChanged(object sender, EventArgs e)
        {
            checkedChanged();
        }

        private void pearlized_CheckedChanged(object sender, EventArgs e)
        {
            checkedChanged();
        }

        private void customized_CheckedChanged(object sender, EventArgs e)
        {
            checkedChanged();
        }

        private void checkedChanged()
        {
            if (lblVehicle.Text != "" && lblOption.Text != "" && lblSub.Text != "" && lblSales.Text != "" && lblTota.Text != "" && lblTrade.Text != "" && lblAmount.Text != "")
            {
                summary_TextChanged();
            }
        }

        private void nud_Clear()
        {
            this.nudNoOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nudAnnualInterestRate.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
        }

        private void nudYears_Click(object sender, EventArgs e)
        {
            if (lblVehicle.Text != "" && lblOption.Text != "" && lblSub.Text != "" && lblSales.Text != "" && lblTota.Text != "" && lblTrade.Text != "" && lblAmount.Text != "")
            {
                summary_TextChanged();
            }
        }
        private void nudAnnualInterestRate_Click(object sender, EventArgs e)
        {
            if (lblVehicle.Text != "" && lblOption.Text != "" && lblSub.Text != "" && lblSales.Text != "" && lblTota.Text != "" && lblTrade.Text != "" && lblAmount.Text != "")
            {
                summary_TextChanged();
            }
        }
        private BindingSource bindingSourceVehicles;
        private OleDbDataAdapter _dataAdapter;
        private DataSet _dataSet;


        /// <summary>
        /// Binds form controls to data object.
        /// </summary>
        private void InputControls()
        {
            OleDbConnection _connection = new OleDbConnection();

            _connection.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" +
                "Data Source = AMDatabase.mdb";
            _connection.Open();

            OleDbCommand _command = new OleDbCommand();
            _command.CommandText = "SELECT * FROM VehicleStock WHERE SoldBy = 0;";
            _command.Connection = _connection;

            _dataAdapter = new OleDbDataAdapter();
            _dataAdapter.SelectCommand = _command;

            _dataSet = new DataSet();
            _dataAdapter.Fill(_dataSet);

            bindingSourceVehicles = new BindingSource();
            bindingSourceVehicles.DataSource = _dataSet.Tables[0];

            this.cboVehicle.DataSource = bindingSourceVehicles;
            this.cboVehicle.DisplayMember = "StockNumber";
            this.cboVehicle.ValueMember = "BasePrice";
        }
       

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuVehicleInformation_Click(object sender, EventArgs e)
        {
            VehicleInformationForm vehicleInformationForm = new VehicleInformationForm(bindingSourceVehicles);
            vehicleInformationForm.ShowDialog();
        }

    }
}
