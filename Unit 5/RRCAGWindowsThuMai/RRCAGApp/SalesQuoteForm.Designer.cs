namespace RRCAGApp
{
    partial class SalesQuoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblVehicleSalePrice = new System.Windows.Forms.Label();
            this.lblTradeInValue = new System.Windows.Forms.Label();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkComputerNavigation = new System.Windows.Forms.CheckBox();
            this.chkLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkStereoSystem = new System.Windows.Forms.CheckBox();
            this.txtVehicleSalePrice = new System.Windows.Forms.TextBox();
            this.txtTradeIn = new System.Windows.Forms.TextBox();
            this.grpExteriorFinish = new System.Windows.Forms.GroupBox();
            this.radCustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblTrade = new System.Windows.Forms.Label();
            this.lblTota = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblOption = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblTradeIn = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblVehicleSale = new System.Windows.Forms.Label();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblAnnualInterest = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.nudAnnualInterestRate = new System.Windows.Forms.NumericUpDown();
            this.nudNoOfYears = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAccessories.SuspendLayout();
            this.grpExteriorFinish.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehicleSalePrice
            // 
            this.lblVehicleSalePrice.AutoSize = true;
            this.lblVehicleSalePrice.Location = new System.Drawing.Point(30, 30);
            this.lblVehicleSalePrice.Name = "lblVehicleSalePrice";
            this.lblVehicleSalePrice.Size = new System.Drawing.Size(136, 17);
            this.lblVehicleSalePrice.TabIndex = 0;
            this.lblVehicleSalePrice.Text = "Vehicle\'s Sale Price:";
            // 
            // lblTradeInValue
            // 
            this.lblTradeInValue.AutoSize = true;
            this.lblTradeInValue.Location = new System.Drawing.Point(60, 60);
            this.lblTradeInValue.Name = "lblTradeInValue";
            this.lblTradeInValue.Size = new System.Drawing.Size(106, 17);
            this.lblTradeInValue.TabIndex = 0;
            this.lblTradeInValue.Text = "Trade-in Value:";
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkComputerNavigation);
            this.grpAccessories.Controls.Add(this.chkLeatherInterior);
            this.grpAccessories.Controls.Add(this.chkStereoSystem);
            this.grpAccessories.Location = new System.Drawing.Point(33, 94);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(293, 186);
            this.grpAccessories.TabIndex = 3;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkComputerNavigation
            // 
            this.chkComputerNavigation.AutoSize = true;
            this.chkComputerNavigation.Location = new System.Drawing.Point(21, 121);
            this.chkComputerNavigation.Name = "chkComputerNavigation";
            this.chkComputerNavigation.Size = new System.Drawing.Size(158, 21);
            this.chkComputerNavigation.TabIndex = 2;
            this.chkComputerNavigation.Text = "ComputerNavigation";
            this.chkComputerNavigation.UseVisualStyleBackColor = true;
            this.chkComputerNavigation.CheckedChanged += new System.EventHandler(this.computer_CheckedChanged);
            // 
            // chkLeatherInterior
            // 
            this.chkLeatherInterior.AutoSize = true;
            this.chkLeatherInterior.Location = new System.Drawing.Point(21, 83);
            this.chkLeatherInterior.Name = "chkLeatherInterior";
            this.chkLeatherInterior.Size = new System.Drawing.Size(127, 21);
            this.chkLeatherInterior.TabIndex = 1;
            this.chkLeatherInterior.Text = "Leather Interior";
            this.chkLeatherInterior.UseVisualStyleBackColor = true;
            this.chkLeatherInterior.CheckedChanged += new System.EventHandler(this.leather_CheckedChanged);
            // 
            // chkStereoSystem
            // 
            this.chkStereoSystem.AutoSize = true;
            this.chkStereoSystem.Location = new System.Drawing.Point(21, 46);
            this.chkStereoSystem.Name = "chkStereoSystem";
            this.chkStereoSystem.Size = new System.Drawing.Size(122, 21);
            this.chkStereoSystem.TabIndex = 0;
            this.chkStereoSystem.Text = "Stereo System";
            this.chkStereoSystem.UseVisualStyleBackColor = true;
            this.chkStereoSystem.CheckedChanged += new System.EventHandler(this.stereo_CheckedChanged);
            // 
            // txtVehicleSalePrice
            // 
            this.errorProvider1.SetIconPadding(this.txtVehicleSalePrice, 3);
            this.txtVehicleSalePrice.Location = new System.Drawing.Point(172, 27);
            this.txtVehicleSalePrice.Name = "txtVehicleSalePrice";
            this.txtVehicleSalePrice.Size = new System.Drawing.Size(154, 22);
            this.txtVehicleSalePrice.TabIndex = 1;
            this.txtVehicleSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVehicleSalePrice.TextChanged += new System.EventHandler(this.vehicle_TextChanged);
            // 
            // txtTradeIn
            // 
            this.errorProvider2.SetIconPadding(this.txtTradeIn, 3);
            this.txtTradeIn.Location = new System.Drawing.Point(172, 57);
            this.txtTradeIn.Name = "txtTradeIn";
            this.txtTradeIn.Size = new System.Drawing.Size(154, 22);
            this.txtTradeIn.TabIndex = 2;
            this.txtTradeIn.Text = "0";
            this.txtTradeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTradeIn.TextChanged += new System.EventHandler(this.tradeInValue_TextChanged);
            // 
            // grpExteriorFinish
            // 
            this.grpExteriorFinish.Controls.Add(this.radCustomizedDetailing);
            this.grpExteriorFinish.Controls.Add(this.radPearlized);
            this.grpExteriorFinish.Controls.Add(this.radStandard);
            this.grpExteriorFinish.Location = new System.Drawing.Point(33, 314);
            this.grpExteriorFinish.Name = "grpExteriorFinish";
            this.grpExteriorFinish.Size = new System.Drawing.Size(293, 186);
            this.grpExteriorFinish.TabIndex = 4;
            this.grpExteriorFinish.TabStop = false;
            this.grpExteriorFinish.Text = "Exterior Finish";
            // 
            // radCustomizedDetailing
            // 
            this.radCustomizedDetailing.AutoSize = true;
            this.radCustomizedDetailing.Location = new System.Drawing.Point(21, 126);
            this.radCustomizedDetailing.Name = "radCustomizedDetailing";
            this.radCustomizedDetailing.Size = new System.Drawing.Size(161, 21);
            this.radCustomizedDetailing.TabIndex = 2;
            this.radCustomizedDetailing.Text = "Customized Detailing";
            this.radCustomizedDetailing.UseVisualStyleBackColor = true;
            this.radCustomizedDetailing.CheckedChanged += new System.EventHandler(this.customized_CheckedChanged);
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Location = new System.Drawing.Point(21, 88);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(88, 21);
            this.radPearlized.TabIndex = 1;
            this.radPearlized.Text = "Pearlized";
            this.radPearlized.UseVisualStyleBackColor = true;
            this.radPearlized.CheckedChanged += new System.EventHandler(this.pearlized_CheckedChanged);
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Location = new System.Drawing.Point(21, 47);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(87, 21);
            this.radStandard.TabIndex = 0;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            this.radStandard.CheckedChanged += new System.EventHandler(this.standard_CheckedChanged);
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblTrade);
            this.grpSummary.Controls.Add(this.lblTota);
            this.grpSummary.Controls.Add(this.lblSales);
            this.grpSummary.Controls.Add(this.lblSub);
            this.grpSummary.Controls.Add(this.lblOption);
            this.grpSummary.Controls.Add(this.lblVehicle);
            this.grpSummary.Controls.Add(this.lblAmount);
            this.grpSummary.Controls.Add(this.lblAmountDue);
            this.grpSummary.Controls.Add(this.lblTradeIn);
            this.grpSummary.Controls.Add(this.lblTotal);
            this.grpSummary.Controls.Add(this.lblSalesTax);
            this.grpSummary.Controls.Add(this.lblSubtotal);
            this.grpSummary.Controls.Add(this.lblOptions);
            this.grpSummary.Controls.Add(this.lblVehicleSale);
            this.grpSummary.Location = new System.Drawing.Point(424, 20);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(341, 327);
            this.grpSummary.TabIndex = 0;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblTrade
            // 
            this.lblTrade.BackColor = System.Drawing.SystemColors.Control;
            this.lblTrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrade.Location = new System.Drawing.Point(168, 221);
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(154, 23);
            this.lblTrade.TabIndex = 23;
            // 
            // lblTota
            // 
            this.lblTota.BackColor = System.Drawing.SystemColors.Control;
            this.lblTota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTota.Location = new System.Drawing.Point(168, 183);
            this.lblTota.Name = "lblTota";
            this.lblTota.Size = new System.Drawing.Size(154, 23);
            this.lblTota.TabIndex = 22;
            // 
            // lblSales
            // 
            this.lblSales.BackColor = System.Drawing.SystemColors.Control;
            this.lblSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSales.Location = new System.Drawing.Point(168, 145);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(154, 23);
            this.lblSales.TabIndex = 21;
            // 
            // lblSub
            // 
            this.lblSub.BackColor = System.Drawing.SystemColors.Control;
            this.lblSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSub.Location = new System.Drawing.Point(168, 107);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(154, 23);
            this.lblSub.TabIndex = 20;
            // 
            // lblOption
            // 
            this.lblOption.BackColor = System.Drawing.SystemColors.Control;
            this.lblOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOption.Location = new System.Drawing.Point(168, 70);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(154, 23);
            this.lblOption.TabIndex = 19;
            // 
            // lblVehicle
            // 
            this.lblVehicle.BackColor = System.Drawing.SystemColors.Control;
            this.lblVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicle.Location = new System.Drawing.Point(168, 32);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(154, 23);
            this.lblVehicle.TabIndex = 7;
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.SystemColors.Control;
            this.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmount.Location = new System.Drawing.Point(168, 260);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(154, 23);
            this.lblAmount.TabIndex = 8;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(72, 261);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(90, 17);
            this.lblAmountDue.TabIndex = 17;
            this.lblAmountDue.Text = "Amount Due:";
            // 
            // lblTradeIn
            // 
            this.lblTradeIn.AutoSize = true;
            this.lblTradeIn.Location = new System.Drawing.Point(96, 222);
            this.lblTradeIn.Name = "lblTradeIn";
            this.lblTradeIn.Size = new System.Drawing.Size(66, 17);
            this.lblTradeIn.TabIndex = 14;
            this.lblTradeIn.Text = "Trade-in:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(118, 184);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total:";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(46, 146);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(116, 17);
            this.lblSalesTax.TabIndex = 10;
            this.lblSalesTax.Text = "Sales Tax (13%):";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(98, 108);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(64, 17);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(101, 71);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(61, 17);
            this.lblOptions.TabIndex = 6;
            this.lblOptions.Text = "Options:";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVehicleSale
            // 
            this.lblVehicleSale.AutoSize = true;
            this.lblVehicleSale.Location = new System.Drawing.Point(26, 33);
            this.lblVehicleSale.Name = "lblVehicleSale";
            this.lblVehicleSale.Size = new System.Drawing.Size(136, 17);
            this.lblVehicleSale.TabIndex = 8;
            this.lblVehicleSale.Text = "Vehicle\'s Sale Price:";
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.lblMonthly);
            this.grpFinance.Controls.Add(this.lblMonthlyPayment);
            this.grpFinance.Controls.Add(this.lblAnnualInterest);
            this.grpFinance.Controls.Add(this.lblYears);
            this.grpFinance.Controls.Add(this.nudAnnualInterestRate);
            this.grpFinance.Controls.Add(this.nudNoOfYears);
            this.grpFinance.Location = new System.Drawing.Point(424, 353);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Size = new System.Drawing.Size(341, 147);
            this.grpFinance.TabIndex = 7;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // lblMonthly
            // 
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Location = new System.Drawing.Point(199, 71);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(116, 17);
            this.lblMonthly.TabIndex = 22;
            this.lblMonthly.Text = "Monthly Payment";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(199, 101);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(113, 23);
            this.lblMonthlyPayment.TabIndex = 0;
            // 
            // lblAnnualInterest
            // 
            this.lblAnnualInterest.AutoSize = true;
            this.lblAnnualInterest.Location = new System.Drawing.Point(104, 54);
            this.lblAnnualInterest.Name = "lblAnnualInterest";
            this.lblAnnualInterest.Size = new System.Drawing.Size(89, 34);
            this.lblAnnualInterest.TabIndex = 21;
            this.lblAnnualInterest.Text = "Annual \r\nInterest Rate";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(11, 71);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(87, 17);
            this.lblYears.TabIndex = 20;
            this.lblYears.Text = "No. of Years";
            // 
            // nudAnnualInterestRate
            // 
            this.nudAnnualInterestRate.DecimalPlaces = 2;
            this.nudAnnualInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAnnualInterestRate.Location = new System.Drawing.Point(107, 102);
            this.nudAnnualInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudAnnualInterestRate.Name = "nudAnnualInterestRate";
            this.nudAnnualInterestRate.Size = new System.Drawing.Size(71, 22);
            this.nudAnnualInterestRate.TabIndex = 2;
            this.nudAnnualInterestRate.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            this.nudAnnualInterestRate.Click += new System.EventHandler(this.nudAnnualInterestRate_Click);
            // 
            // nudNoOfYears
            // 
            this.nudNoOfYears.Location = new System.Drawing.Point(14, 102);
            this.nudNoOfYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNoOfYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfYears.Name = "nudNoOfYears";
            this.nudNoOfYears.Size = new System.Drawing.Size(71, 22);
            this.nudNoOfYears.TabIndex = 1;
            this.nudNoOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfYears.Click += new System.EventHandler(this.nudYears_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(33, 520);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 37);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.Location = new System.Drawing.Point(635, 522);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(130, 33);
            this.btnCalculateQuote.TabIndex = 8;
            this.btnCalculateQuote.Text = "Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = true;
            this.btnCalculateQuote.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // SalesQuoteForm
            // 
            this.AcceptButton = this.btnCalculateQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 579);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpExteriorFinish);
            this.Controls.Add(this.txtTradeIn);
            this.Controls.Add(this.txtVehicleSalePrice);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.lblTradeInValue);
            this.Controls.Add(this.lblVehicleSalePrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.Text = "Vehicle Sales Quote";
            this.Load += new System.EventHandler(this.VehicleSalesQuoteForm_Load);
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExteriorFinish.ResumeLayout(false);
            this.grpExteriorFinish.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicleSalePrice;
        private System.Windows.Forms.Label lblTradeInValue;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.CheckBox chkComputerNavigation;
        private System.Windows.Forms.CheckBox chkLeatherInterior;
        private System.Windows.Forms.CheckBox chkStereoSystem;
        private System.Windows.Forms.TextBox txtVehicleSalePrice;
        private System.Windows.Forms.TextBox txtTradeIn;
        private System.Windows.Forms.GroupBox grpExteriorFinish;
        private System.Windows.Forms.RadioButton radCustomizedDetailing;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblTradeIn;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblVehicleSale;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.Label lblAnnualInterest;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.NumericUpDown nudAnnualInterestRate;
        private System.Windows.Forms.NumericUpDown nudNoOfYears;
        private System.Windows.Forms.Label lblTrade;
        private System.Windows.Forms.Label lblTota;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}