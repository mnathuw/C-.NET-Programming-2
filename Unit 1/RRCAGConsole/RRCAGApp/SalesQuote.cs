using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    /// <summary>
    /// Represents a SalesQuote object.
    /// </summary>
    class SalesQuote
    {
        /// <summary>
        /// The selling price of the vehicle being sold.
        /// </summary>
        private decimal vehicleSalePrice;

        /// <summary>
        /// The amount offered to the customer for the trade in of their vehicle.
        /// </summary>
        private decimal tradeInAmount;

        /// <summary>
        /// The tax rate applied to the sale of a vehicle.
        /// </summary>
        private decimal salesTaxRate;

        /// <summary>
        /// The chosen accessories.
        /// </summary>
        private Accessories accessoriesChosen;

        /// <summary>
        /// The chosen exterior finish.
        /// </summary>
        private ExteriorFinish exteriorFinishChosen;

        /// <summary>
        /// Initializes a new instance of the SalesQuote class with a vehicle price, trade-in amount, sales tax rate, accessories chosen and exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice"> The selling price of the vehicle being sold. </param>
        /// <param name="tradeInAmount"> The amount offered to the customer for the trade in of their vehicle. </param>
        /// <param name="salesTaxRate"> The tax rate applied to the sale of a vehicle. </param>
        /// <param name="accessoriesChosen"> The value of the chosen accessories. </param>
        /// <param name="exteriorFinishChosen"> The value of the chosen exterior finish. </param>
        public SalesQuote (decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate, Accessories accessoriesChosen, ExteriorFinish exteriorFinishChosen)
        {
            this.vehicleSalePrice = vehicleSalePrice;
            this.tradeInAmount = tradeInAmount;
            this.salesTaxRate = salesTaxRate;
            this.accessoriesChosen = accessoriesChosen;
            this.exteriorFinishChosen = exteriorFinishChosen;
        }

        /// <summary>
        /// Initializes a new instance of the SalesQuote class with a vehicle price, trade-in amount, sales tax rate, no accessories chosen and no exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice"> The selling price of the vehicle being sold. </param>
        /// <param name="tradeInAmount"> The amount offered to the custoer for the trade in their vehicle. </param>
        /// <param name="salesTaxRate"> The tax rate applied to the sale of a vehicle. </param>
        public SalesQuote (decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate) 
            : this(vehicleSalePrice, tradeInAmount, salesTaxRate, Accessories.None, ExteriorFinish.None)
        {
        }

        /// <summary>
        /// Gets the sale price of the vehicle.
        /// </summary>
        /// <returns> The sale price of the vehicle. </returns>
        public decimal GetVehicleSalePrice()
        {
            return this.vehicleSalePrice;
        }

        /// <summary>
        /// Sets the sale price of the vehicle.
        /// </summary>
        /// <param name="vehicleSalesPrice">  The selling price of the vehicle. </param>
        public void SetVehicleSalePrice (decimal vehicleSalesPrice)
        {
            this.vehicleSalePrice = vehicleSalesPrice;
        }

        /// <summary>
        /// Gets the trade in amount.
        /// </summary>
        /// <returns> The trade in amount. </returns>
        public decimal GetTradeInAmount()
        {
            return this.tradeInAmount;
        }

        /// <summary>
        /// Sets the trade in amount
        /// </summary>
        /// <param name="tradeInAmount"> The amount offered to the customer for the trade in of their vehicle. </param>
        public void SetTradeInAmount (decimal tradeInAmount)
        {
            this.tradeInAmount = tradeInAmount;
        }

        /// <summary>
        /// Gets the accessories chosen for the vehicle.
        /// </summary>
        /// <returns> The chosen accessories. </returns>
        public Accessories GetAccessoriesChosen()
        {
            return this.accessoriesChosen;
        }

        /// <summary>
        /// Sets the accessories chosen for the vehicle.
        /// </summary>
        /// <param name="accessoriesChosen"> The chosen accessories. </param>
        public void SetAccessoriesChosen (Accessories accessoriesChosen)
        {
            this.accessoriesChosen = accessoriesChosen;
        }

        /// <summary>
        /// Gets the exterior finish chosen for the vehicle.
        /// </summary>
        /// <returns> The chosen exterior finish. </returns>
        public ExteriorFinish GetExteriorFinishChosen()
        {
            return this.exteriorFinishChosen;
        }

        /// <summary>
        /// Sets the exterior finish chosen for the vehicle.
        /// </summary>
        /// <param name="exteriorFinishChosen"> The chosen exterior finish. </param>
        public void SetExteriorFinishChosen (ExteriorFinish exteriorFinishChosen)
        {
            this.exteriorFinishChosen = exteriorFinishChosen;
        }


        /// <summary>
        /// Returns the cost of the accessories chosen.
        /// </summary>
        /// <returns> The cost of the chosen accessories. </returns>
        public decimal GetAccessoryCost()
        {
            decimal stereoSystem = 505.05M;
            decimal leatherInterior = 1010.10M;
            decimal computerNavigation = 1515.15M;
            switch (this.accessoriesChosen)
            {
                case Accessories.StereoSystem:
                    return stereoSystem;
                case Accessories.LeatherInterior:
                    return leatherInterior;
                case Accessories.ComputerNavigation:
                    return computerNavigation;
                case Accessories.StereoAndLeather:
                    return stereoSystem + leatherInterior;
                case Accessories.StereoAndNavigation:
                    return stereoSystem + computerNavigation;
                case Accessories.LeatherAndNavigation:
                    return leatherInterior + computerNavigation;
                case Accessories.None:
                    return 0M;
                case Accessories.All:
                    return stereoSystem + computerNavigation + leatherInterior;
                default:
                    return 0M;
            }
        }

        /// <summary>
        /// Returns the cost of the exterior finish chosen.
        /// </summary>
        /// <returns> The cost of the chosen exterior finish. </returns>
        public decimal GetExteriorFinishCost()
        {
            switch (this.exteriorFinishChosen)
            {
                case ExteriorFinish.Standard:
                    return 202.02M;
                case ExteriorFinish.Pearlized:
                    return 404.04M;
                case ExteriorFinish.Custom:
                    return 606.06M;
                case ExteriorFinish.None:
                    return 0M;
                default:
                    return 0M;
            }
        }


        /// <summary>
        /// Returns the sum of the vehicle's sale price, accessories and exterior finish costs.
        /// </summary>
        /// <returns> The sum of the vehicle's sale price, accessories and exterior finish costs. </returns>
        public decimal GetSubTotal()
        {
            return this.vehicleSalePrice + GetAccessoryCost() + GetExteriorFinishCost();
        }

        /// <summary>
        /// Returns the amount of tax to charge based on the subtotal.
        /// </summary>
        /// <returns> The amount of tax to charge based on the subtotal. </returns>
        public decimal GetSalesTax()
        {
            return this.salesTaxRate * GetSubTotal();
        }

        /// <summary>
        /// Returns the sum of the subtotal and taxes.
        /// </summary>
        /// <returns> The sum of the subtotal and taxes. </returns>
        public decimal GetTotal()
        {
            return GetSubTotal() + GetSalesTax();
        }

        /// <summary>
        /// Returns the difference of the total and trade-in amount.
        /// </summary>
        /// <returns> The difference of the total and trade-in amount. </returns>
        public decimal GetAmountDue()
        {
            return GetTotal() - GetTradeInAmount();
        }

        /// <summary>
        /// Returns the String representation of SalesQuote.
        /// </summary>
        /// <returns> The String representation of SalesQuote. </returns>
        public override string ToString()
        {
            return String.Format("Vehicle Sale Price: {0:C2}\n" +
                                    "Trade-in Amount: {1:C2}\n" +
                                    "Accessories cost: {2}\n" +
                                    "Finish Cost: {3}\n" +
                                    "SubTotal: {4:C2}\n" +
                                    "Total: {5:C2}\n" +
                                    "Amount Due: {6:C2}", this.vehicleSalePrice, this.tradeInAmount, this.accessoriesChosen, this.exteriorFinishChosen, GetSubTotal(), GetTotal(), GetAmountDue());
        }
    }
}
