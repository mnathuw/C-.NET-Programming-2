using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mai.Thu.Business
{
    /// <summary>
    /// Represents a SalesQuote object.
    /// </summary>
    public class SalesQuote
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
        /// Initializes an instance of SalesQuote with a vehicle price, trade-in value,
        /// sales tax rate, accessories chosen and exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice">
        /// The selling price of the vehicle being sold.
        /// </param>
        /// <param name="tradeInAmount">
        /// The amount offered to the customer for the trade in of their vehicle.
        /// </param>
        /// <param name="salesTaxRate">The tax rate applied to the sale of a vehicle.</param>
        /// <param name="accessoriesChosen">The value of the chosen accessories.</param>
        /// <param name="exteriorFinishChose">
        /// The value of the chosen exterior finish.
        /// </param>
        ///<exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the vehicle sale price is less than 0
        ///</exception>
        ///<exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the vehicle sale price is equal to 0
        ///</exception>
        ///<exception cref="System.ArgumentOutOfRangeException">
        /// The trade in amount is less than 0
        ///</exception>
        ///<exception cref="System.ArgumentOutOfRangeException">
        /// The sales tax rate is less than 0
        ///</exception>
        ///<exception cref="System.ArgumentOutOfRangeException">
        /// The sales tax rate is greater than 0
        ///</exception>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate,
                            Accessories accessoriesChosen, ExteriorFinish exteriorFinishChosen)
        {

            if (vehicleSalePrice < 0)
            {
                throw new ArgumentOutOfRangeException("vehicleSalePrice",
                    "Argument cannot be less than 0.");
            }

            if (vehicleSalePrice == 0)
            {
                throw new ArgumentOutOfRangeException("vehicleSalePrice",
                    "Argument cannot be equal to 0.");
            }

            if (tradeInAmount < 0)
            {
                throw new ArgumentOutOfRangeException("tradeInAmount",
                    "Argument cannot be less than 0.");
            }

            if ( salesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("salesTaxRate",
                    "Argument cannot be less than 0.");
            }

            if (salesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("salesTaxRate",
                    "Argument cannot be greater than 1.");
            }

            this.vehicleSalePrice = vehicleSalePrice;
            this.tradeInAmount = tradeInAmount;
            this.salesTaxRate = salesTaxRate;
            this.accessoriesChosen = accessoriesChosen;
            this.exteriorFinishChosen = exteriorFinishChosen;
        }

        /// <summary>
        /// Initializes an instance of SalesQuote with a vehicle price, trade-in amount,
        /// sales tax rate, no accessories chosen and no exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice">
        /// The selling price of the vehicle being sold.
        /// </param>
        /// <param name="tradeInAmount">
        /// The amount offered to the customer for the trade in of their vehicle.
        /// </param>
        /// <param name="salesTaxRate">The tax rate applied to the sale of a vehicle.</param>
        /// The value of the chosen exterior finish.
        /// </param>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount,
                          decimal salesTaxRate) : this(vehicleSalePrice, tradeInAmount, salesTaxRate,
                                                        Accessories.None, ExteriorFinish.None)
        {
        }

        /// <summary>
        /// Gets and sets the sale price of the vehicle.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the property is set to less than 0.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the property is set equal to 0.
        /// </exception>
        public decimal VehicleSalePrice
        {
            get
            {
                return this.vehicleSalePrice;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value",
                        "The value cannot be less than.");
                }

                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("value",
                       "The value cannot be equal to 0.");

                }

                this.vehicleSalePrice = value;
            }
        }

        /// <summary>
        /// Gets and sets the trade in amount.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the property is set to less than 0.
        /// </exception>
        public decimal TradeInAmount
        {
            get
            {
                return this.tradeInAmount;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value",
                        "The value cannot be less than 0.");
                }
                this.tradeInAmount = value;
            }
        }

        /// <summary>
        /// Gets and sets the accessories that were chosen.
        /// </summary>
        public Accessories AccessoriesChosen
        {
            get
            {
                return this.accessoriesChosen;
            }

            set
            {
                this.accessoriesChosen = value;
            }
        }  

        /// <summary>
        /// Gets and sets the exterior finish that was chosen.
        /// </summary>
        public ExteriorFinish ExteriorFinishChosen
        {
            get
            {
                return this.exteriorFinishChosen;
            }

            set
            {
                this.exteriorFinishChosen = value;
            }
        }

        /// <summary>
        /// Returns the cost of the accessories chosen.
        /// </summary>
        /// <returns> The cost of the chosen accessories. </returns>
        public decimal AccessoryCost
        {
            get
            {
                decimal result;
                decimal stereoSystem = 505.05M;
                decimal leatherInterior = 1010.10M;
                decimal computerNavigation = 1515.15M;

                switch (this.accessoriesChosen)
                {
                    case Accessories.StereoSystem:
                        result = stereoSystem;
                        break;
                    case Accessories.LeatherInterior:
                        result = leatherInterior;
                        break;
                    case Accessories.ComputerNavigation:
                        result = computerNavigation;
                        break;
                    case Accessories.StereoAndLeather:
                        result = stereoSystem + leatherInterior;
                        break;
                    case Accessories.StereoAndNavigation:
                        result = stereoSystem + computerNavigation;
                        break;
                    case Accessories.LeatherAndNavigation:
                        result = leatherInterior + computerNavigation;
                        break;
                    case Accessories.All:
                        result = stereoSystem + leatherInterior + computerNavigation;
                        break;
                    default:
                        result = 0.00M;
                        break;
                }
                return result;
            }    
        }

        /// <summary>
        /// Gets the cost of the exterior finish chosen.
        /// </summary>
        public decimal FinishCost
        {
            get
            {
                decimal result;
                decimal standard = 202.02M;
                decimal pearl = 404.04M;
                decimal custom = 606.06M;
                switch (exteriorFinishChosen)
                {
                    case ExteriorFinish.Custom:
                        result = custom;
                        break;
                    case ExteriorFinish.Pearlized:
                        result = pearl;
                        break;
                    case ExteriorFinish.Standard:
                        result = standard;
                        break;
                    default:
                        result = 0.00M;
                        break;
                }
                return result;
            }
        }

        /// <summary>
        /// Returns the sum of the vehicle's sale price, accessories and exterior finish costs.
        /// </summary>
        /// <returns> The sum of the vehicle's sale price, accessories and exterior finish costs. </returns>
        public decimal SubTotal
        {
            get
            {
                return this.vehicleSalePrice + AccessoryCost + FinishCost;
            }
        }

        /// <summary>
        /// Returns the amount of tax to charge based on the subtotal.
        /// </summary>
        /// <returns> The amount of tax to charge based on the subtotal. </returns>
        public decimal SalesTax
        {
            get
            {
                return this.salesTaxRate * SubTotal;
            }
        }



        /// <summary>
        /// Returns the difference of the total and trade-in amount.
        /// </summary>
        /// <returns> The difference of the total and trade-in amount. </returns>
        public decimal AmountDue
        {
            get
            {
                return SalesTax + SubTotal - this.tradeInAmount;
            }
        }

        /// <summary>
        /// Returns the String representation of a SalesQuote.
        /// </summary>
        /// <return>The String representation of a SalesQuote.</return>
        public override string ToString()
        {
            return String.Format("Vehicle Sale Price: {0:C2}\n" +
                                    "Trade-in Amount: {1:C2}\n" +
                                    "Accessories Cost: {2:C2}\n" +
                                    "Finish Cost: {3:C2}\n" +
                                    "SubTotal: {4:C2}\n" +
                                    "Total: {5:C2}\n" +
                                    "Amount Due: {6:C2}", this.vehicleSalePrice, this.tradeInAmount, AccessoryCost, FinishCost, SubTotal, SubTotal + SalesTax, AmountDue);                    
        }
    }
}
