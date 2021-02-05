﻿using System;

namespace Mai.Thu.Business
{
    /// <summary>
    /// Represents an Invoice object.
    /// </summary>
    public abstract class Invoice
    {
        /// <summary>
        /// The provincial sales tax rate applied to the invoice.
        /// </summary>
        private decimal provincialSalesTaxRate;

        /// <summary>
        /// The goods and services tax rate applied to the invoice.
        /// </summary>
        private decimal goodsAndServicesTaxRate;

        /// <summary>
        /// Gets and sets the provincial sales tax rate.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the property is set to less than 0.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the property is set to greater than 1.
        /// </exception>
        public decimal ProvincialSalesTaxRate
        {
            get
            {
                return this.provincialSalesTaxRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value",
                        "The value cannot be less than 0.");
                }

                if (value > 1)
                {
                    throw new ArgumentOutOfRangeException("value",
                        "The value cannot be greater than 1.");
                }
                this.provincialSalesTaxRate = value;
            }
        }

        /// <summary>
        /// Gets and sets the goods and services tax rate.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the property is set to less than 0.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the property is set to greater than 1.
        /// </exception>
        public decimal GoodsAndServicesTaxRate
        {
            get
            {
                return this.goodsAndServicesTaxRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value",
                        "The value cannot be less than 0.");
                }

                if (value > 1)
                {
                    throw new ArgumentOutOfRangeException("value",
                        "The value cannot be greater than 1.");
                }
                this.goodsAndServicesTaxRate = value;
            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer.
        /// </summary>
        public abstract decimal ProvincialSalesTaxCharged
        {
            get;
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer.
        /// </summary>
        public abstract decimal GoodsAndServicesTaxCharged
        {
            get;
        }

        /// <summary>
        /// Gets the subtotal of the Invoice.
        /// </summary>
        public abstract decimal SubTotal
        {
            get;
        }

        /// <summary>
        /// Gets the total of the Invoice.
        /// </summary>
        public virtual decimal Total
        {
            get
            {
                return SubTotal + ProvincialSalesTaxCharged + GoodsAndServicesTaxCharged;
            }
        }

        /// <summary>
        /// Initializes an instance of Invoice with a provincial and goods and services tax rate.
        /// </summary>
        /// <param name="provincialSalesTaxRate">
        /// The rate of provincial tax charged to a customer.
        /// </param>
        /// <param name="goodsAndServicesTaxRate">
        /// The rate of goods and services tax charged to a customer.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the provincial sales tax rate is less than 0
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
        public Invoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
        {
            if (provincialSalesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate",
                    "Argument cannot be less than 0.");
            }

            if (provincialSalesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate",
                    "Argument cannot be greater than 1.");
            }

            if (goodsAndServicesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate",
                    "Argument cannot be less than 0.");
            }

            if (goodsAndServicesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate",
                    "Argument cannot be greater than 1.");
            }

            this.provincialSalesTaxRate = provincialSalesTaxRate;
            this.goodsAndServicesTaxRate = goodsAndServicesTaxRate;
        }
    }
}
