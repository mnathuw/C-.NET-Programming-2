namespace RRCAGApp
{
    partial class CarWashEntryForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblFragrance = new System.Windows.Forms.Label();
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.cboFragrance = new System.Windows.Forms.ComboBox();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lstExterior = new System.Windows.Forms.ListBox();
            this.lstInterior = new System.Windows.Forms.ListBox();
            this.lblExterior = new System.Windows.Forms.Label();
            this.lblInterior = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblPST = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblPs = new System.Windows.Forms.Label();
            this.lblGS = new System.Windows.Forms.Label();
            this.lblTota = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(326, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenerateInvoice,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuGenerateInvoice
            // 
            this.mnuGenerateInvoice.Enabled = false;
            this.mnuGenerateInvoice.Name = "mnuGenerateInvoice";
            this.mnuGenerateInvoice.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.mnuGenerateInvoice.Size = new System.Drawing.Size(240, 22);
            this.mnuGenerateInvoice.Text = "&Generate Invoice...";
            this.mnuGenerateInvoice.Click += new System.EventHandler(this.mnuGenerate_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(240, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(9, 41);
            this.lblPackage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(53, 13);
            this.lblPackage.TabIndex = 0;
            this.lblPackage.Text = "Package:";
            // 
            // lblFragrance
            // 
            this.lblFragrance.AutoSize = true;
            this.lblFragrance.Location = new System.Drawing.Point(189, 41);
            this.lblFragrance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFragrance.Name = "lblFragrance";
            this.lblFragrance.Size = new System.Drawing.Size(58, 13);
            this.lblFragrance.TabIndex = 0;
            this.lblFragrance.Text = "Fragrance:";
            // 
            // cboPackage
            // 
            this.cboPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackage.FormattingEnabled = true;
            this.cboPackage.Items.AddRange(new object[] {
            "Standard",
            "Delixe",
            "Executive",
            "Luxury"});
            this.cboPackage.Location = new System.Drawing.Point(11, 58);
            this.cboPackage.Margin = new System.Windows.Forms.Padding(2);
            this.cboPackage.Name = "cboPackage";
            this.cboPackage.Size = new System.Drawing.Size(122, 21);
            this.cboPackage.TabIndex = 3;
            this.cboPackage.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // cboFragrance
            // 
            this.cboFragrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFragrance.FormattingEnabled = true;
            this.cboFragrance.Items.AddRange(new object[] {
            "Hawaiian Mist",
            "Baby Powder",
            "Pine",
            "Country Floral",
            "Pina Colada",
            "Vanilla"});
            this.cboFragrance.Location = new System.Drawing.Point(191, 58);
            this.cboFragrance.Margin = new System.Windows.Forms.Padding(2);
            this.cboFragrance.Name = "cboFragrance";
            this.cboFragrance.Size = new System.Drawing.Size(115, 21);
            this.cboFragrance.TabIndex = 4;
            this.cboFragrance.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lstExterior);
            this.grpSummary.Controls.Add(this.lstInterior);
            this.grpSummary.Controls.Add(this.lblExterior);
            this.grpSummary.Controls.Add(this.lblInterior);
            this.grpSummary.Location = new System.Drawing.Point(11, 97);
            this.grpSummary.Margin = new System.Windows.Forms.Padding(2);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Padding = new System.Windows.Forms.Padding(2);
            this.grpSummary.Size = new System.Drawing.Size(299, 156);
            this.grpSummary.TabIndex = 0;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lstExterior
            // 
            this.lstExterior.FormattingEnabled = true;
            this.lstExterior.Location = new System.Drawing.Point(180, 55);
            this.lstExterior.Margin = new System.Windows.Forms.Padding(2);
            this.lstExterior.Name = "lstExterior";
            this.lstExterior.Size = new System.Drawing.Size(115, 82);
            this.lstExterior.TabIndex = 0;
            // 
            // lstInterior
            // 
            this.lstInterior.FormattingEnabled = true;
            this.lstInterior.Location = new System.Drawing.Point(7, 55);
            this.lstInterior.Margin = new System.Windows.Forms.Padding(2);
            this.lstInterior.Name = "lstInterior";
            this.lstInterior.Size = new System.Drawing.Size(115, 82);
            this.lstInterior.TabIndex = 0;
            // 
            // lblExterior
            // 
            this.lblExterior.AutoSize = true;
            this.lblExterior.Location = new System.Drawing.Point(177, 39);
            this.lblExterior.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExterior.Name = "lblExterior";
            this.lblExterior.Size = new System.Drawing.Size(45, 13);
            this.lblExterior.TabIndex = 0;
            this.lblExterior.Text = "Exterior:";
            // 
            // lblInterior
            // 
            this.lblInterior.AutoSize = true;
            this.lblInterior.Location = new System.Drawing.Point(4, 39);
            this.lblInterior.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterior.Name = "lblInterior";
            this.lblInterior.Size = new System.Drawing.Size(42, 13);
            this.lblInterior.TabIndex = 0;
            this.lblInterior.Text = "Interior:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(159, 274);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblPST
            // 
            this.lblPST.AutoSize = true;
            this.lblPST.Location = new System.Drawing.Point(178, 297);
            this.lblPST.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPST.Name = "lblPST";
            this.lblPST.Size = new System.Drawing.Size(31, 13);
            this.lblPST.TabIndex = 0;
            this.lblPST.Text = "PST:";
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Location = new System.Drawing.Point(176, 321);
            this.lblGST.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(32, 13);
            this.lblGST.TabIndex = 0;
            this.lblGST.Text = "GST:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(174, 344);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // lblSub
            // 
            this.lblSub.BackColor = System.Drawing.SystemColors.Control;
            this.lblSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSub.Location = new System.Drawing.Point(212, 273);
            this.lblSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(100, 19);
            this.lblSub.TabIndex = 0;
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPs
            // 
            this.lblPs.BackColor = System.Drawing.SystemColors.Control;
            this.lblPs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPs.Location = new System.Drawing.Point(212, 296);
            this.lblPs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPs.Name = "lblPs";
            this.lblPs.Size = new System.Drawing.Size(100, 19);
            this.lblPs.TabIndex = 0;
            this.lblPs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGS
            // 
            this.lblGS.BackColor = System.Drawing.SystemColors.Control;
            this.lblGS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGS.Location = new System.Drawing.Point(212, 320);
            this.lblGS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGS.Name = "lblGS";
            this.lblGS.Size = new System.Drawing.Size(100, 19);
            this.lblGS.TabIndex = 0;
            this.lblGS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTota
            // 
            this.lblTota.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTota.Location = new System.Drawing.Point(212, 344);
            this.lblTota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTota.Name = "lblTota";
            this.lblTota.Size = new System.Drawing.Size(100, 19);
            this.lblTota.TabIndex = 0;
            this.lblTota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CarWashEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 379);
            this.Controls.Add(this.lblTota);
            this.Controls.Add(this.lblGS);
            this.Controls.Add(this.lblPs);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.lblPST);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.cboFragrance);
            this.Controls.Add(this.cboPackage);
            this.Controls.Add(this.lblFragrance);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CarWashEntryForm";
            this.ShowIcon = false;
            this.Text = "Car Wash";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblFragrance;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.ComboBox cboFragrance;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.ListBox lstExterior;
        private System.Windows.Forms.ListBox lstInterior;
        private System.Windows.Forms.Label lblExterior;
        private System.Windows.Forms.Label lblInterior;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPST;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblPs;
        private System.Windows.Forms.Label lblGS;
        private System.Windows.Forms.Label lblTota;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateInvoice;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}