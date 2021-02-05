using System;
using System.Collections.Generic;
using System.Text;

namespace Mai.Thu.Business
{
    /// <summary>
    /// Contains functionality that supports the business process of creating an invoice
    /// for the car wash department.
    /// </summary>
    public class CarWashInvoice : Invoice
    {
        /// <summary>
        /// The cost of the chosen package
        /// </summary>
        private decimal packageCost;

        /// <summary>
        /// The cost of the chosen fragrance
        /// </summary>
        private decimal fragranceCost;

        /// <summary>
        /// Gets and sets the amount charged for the chosen package.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the property is set to less than 0.
        /// </exception>
        public decimal PackageCost
        {
            get
            {
                return this.packageCost;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value",
                        "The value cannot be less than 0.");
                }
                this.packageCost = value;
            }
        }

        /// <summary>
        /// Gets and sets the amount charged for the chosen fragrance.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the property is set to less than 0.
        /// </exception>
        public decimal FragranceCost
        {
            get
            {
                return this.fragranceCost;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value",
                        "The value cannot be less than 0.");
                }
                this.fragranceCost = value;
            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer.
        /// </summary>
        public override decimal ProvincialSalesTaxCharged
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer.
        /// </summary>
        public override decimal GoodsAndServicesTaxCharged
        {
            get
            {
                return SubTotal * base.GoodsAndServicesTaxRate;
            }
        }

        /// <summary>
        /// Gets the subtotal of the Invoice.
        /// </summary>
        public override decimal SubTotal
        {
            get
            {
                return PackageCost + FragranceCost;
            }
        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a provincial and goods and services tax rates.
        /// </summary>
        /// <param name="provincialSalesTaxRate">
        /// The rate of provincial tax charged to a customer.
        /// </param>
        /// <param name="goodsAndServicesTaxRate">
        /// The rate goods and services tax charged to a customer.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the provincial sales tax rate is less than 0.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the provincial sales tax rate is greater than 1.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the goods and services tax rate is less than 0.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the goods and services tax rate is greater than 1.
        /// </exception>
        public CarWashInvoice(decimal provincialSalesTaxRate,
                              decimal goodsAndServicesTaxRate) : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            this.packageCost = 0;
            this.fragranceCost = 0;
        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a provincial and goods, services tax rate,
        /// package cost and fragrance cost.
        /// </summary>
        /// <param name="provincialSalesTaxRate">
        /// The rate of provincial tax charged to a customer.
        /// </param>
        /// <param name="goodsAndServicesTaxRate">
        /// The rate goods and services tax charged to a customer.
        /// </param>
        /// <param name="packageCost">The cost of the chosen package.</param>
        /// <param name="fragranceCost">The cost of the chosen fragrance.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the provincial sales tax rate is less than 0 
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the provincial sales tax rate is greater than 1
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the goods and services tax rate is less than 0 
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the goods and services tax rate is greater than 1
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the goods and services tax rate is greater than 1
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the package cost is less than 0.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the fragrance cost is less than 0.
        /// </exception>
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate,
                              decimal packageCost, decimal fragranceCost) : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            if (packageCost < 0)
            {
                throw new ArgumentOutOfRangeException("packageCost",
                    "The argument cannot be less than 0.");
            }

            if (fragranceCost < 0)
            {
                throw new ArgumentOutOfRangeException("fragranceCost",
                    "The argument cannot be less than 0.");
            }

            this.packageCost = packageCost;
            this.fragranceCost = fragranceCost;
        }
    }
}
