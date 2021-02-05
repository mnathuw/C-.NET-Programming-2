
namespace RRCAGApp
{
    public partial class CarWashInvoiceForm 
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
            this.lblPackagePrice = new System.Windows.Forms.Label();
            this.lblPackageP = new System.Windows.Forms.Label();
            this.lblFragrancePrice = new System.Windows.Forms.Label();
            this.lblFragranceP = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubt = new System.Windows.Forms.Label();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.lblTaxe = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPackagePrice
            // 
            this.lblPackagePrice.AutoSize = true;
            this.lblPackagePrice.Location = new System.Drawing.Point(372, 243);
            this.lblPackagePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackagePrice.Name = "lblPackagePrice";
            this.lblPackagePrice.Size = new System.Drawing.Size(80, 13);
            this.lblPackagePrice.TabIndex = 0;
            this.lblPackagePrice.Text = "Package Price:";
            this.lblPackagePrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPackageP
            // 
            this.lblPackageP.AutoSize = true;
            this.lblPackageP.Location = new System.Drawing.Point(473, 243);
            this.lblPackageP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackageP.Name = "lblPackageP";
            this.lblPackageP.Size = new System.Drawing.Size(83, 13);
            this.lblPackageP.TabIndex = 1;
            this.lblPackageP.Text = "[Package Price]";
            this.lblPackageP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFragrancePrice
            // 
            this.lblFragrancePrice.AutoSize = true;
            this.lblFragrancePrice.Location = new System.Drawing.Point(364, 264);
            this.lblFragrancePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFragrancePrice.Name = "lblFragrancePrice";
            this.lblFragrancePrice.Size = new System.Drawing.Size(85, 13);
            this.lblFragrancePrice.TabIndex = 2;
            this.lblFragrancePrice.Text = "Fragrance Price:";
            this.lblFragrancePrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFragranceP
            // 
            this.lblFragranceP.AutoSize = true;
            this.lblFragranceP.Location = new System.Drawing.Point(466, 264);
            this.lblFragranceP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFragranceP.Name = "lblFragranceP";
            this.lblFragranceP.Size = new System.Drawing.Size(88, 13);
            this.lblFragranceP.TabIndex = 3;
            this.lblFragranceP.Text = "[Fragrance Price]";
            this.lblFragranceP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(401, 286);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSubt
            // 
            this.lblSubt.AutoSize = true;
            this.lblSubt.Location = new System.Drawing.Point(502, 286);
            this.lblSubt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubt.Name = "lblSubt";
            this.lblSubt.Size = new System.Drawing.Size(52, 13);
            this.lblSubt.TabIndex = 5;
            this.lblSubt.Text = "[Subtotal]";
            this.lblSubt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Location = new System.Drawing.Point(412, 310);
            this.lblTaxes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(39, 13);
            this.lblTaxes.TabIndex = 6;
            this.lblTaxes.Text = "Taxes:";
            this.lblTaxes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTaxe
            // 
            this.lblTaxe.AutoSize = true;
            this.lblTaxe.Location = new System.Drawing.Point(513, 310);
            this.lblTaxe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaxe.Name = "lblTaxe";
            this.lblTaxe.Size = new System.Drawing.Size(42, 13);
            this.lblTaxe.TabIndex = 7;
            this.lblTaxe.Text = "[Taxes]";
            this.lblTaxe.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(416, 333);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Location = new System.Drawing.Point(518, 333);
            this.lblTot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(37, 13);
            this.lblTot.TabIndex = 9;
            this.lblTot.Text = "[Total]";
            this.lblTot.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CarWashInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTaxe);
            this.Controls.Add(this.lblTaxes);
            this.Controls.Add(this.lblSubt);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblFragranceP);
            this.Controls.Add(this.lblFragrancePrice);
            this.Controls.Add(this.lblPackageP);
            this.Controls.Add(this.lblPackagePrice);
            this.Name = "CarWashInvoiceForm";
            this.Text = "Car Wash Invoice";
            this.Controls.SetChildIndex(this.lblPackagePrice, 0);
            this.Controls.SetChildIndex(this.lblPackageP, 0);
            this.Controls.SetChildIndex(this.lblFragrancePrice, 0);
            this.Controls.SetChildIndex(this.lblFragranceP, 0);
            this.Controls.SetChildIndex(this.lblSubtotal, 0);
            this.Controls.SetChildIndex(this.lblSubt, 0);
            this.Controls.SetChildIndex(this.lblTaxes, 0);
            this.Controls.SetChildIndex(this.lblTaxe, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.lblTot, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPackagePrice;
        private System.Windows.Forms.Label lblPackageP;
        private System.Windows.Forms.Label lblFragrancePrice;
        private System.Windows.Forms.Label lblFragranceP;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubt;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.Label lblTaxe;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTot;
    }
}