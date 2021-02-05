using System;

namespace Mai.Thu.Business
{
    /// <summary>
    /// Contains functionality that supports the business process of creating an invoice
    /// for the service department.
    /// </summary>
    public class ServiceInvoice : Invoice
    {
        /// <summary>
        /// Gets the amount charged for labour.
        /// </summary>
        public decimal LabourCost
        {
            get; private set;
        }

        /// <summary>
        /// Gets the amount charged for parts.
        /// </summary>
        public decimal PartsCost
        {
            get; private set;
        }

        /// <summary>
        /// Gets the amount charged for shop materials.
        /// </summary>
        public decimal MaterialCost
        {
            get; private set;
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer.
        /// </summary>
        public override decimal ProvincialSalesTaxCharged
        {
            get
            {
                return SubTotal * base.ProvincialSalesTaxRate;
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
                return LabourCost + PartsCost + MaterialCost;
            }
        }


        /// <summary>
        /// Initializes an instance of ServiceInvoice with a provincial and goods and services tax rates.
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
        /// Thrown when the provincial sales tax rate is greater than 1
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the goods and services tax rate is less than 0 
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the goods and services tax rate is greater than 1.
        /// </exception>
        public ServiceInvoice(decimal provincialSalesTaxRate,
            decimal goodsAndServicesTaxRate) : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
        }

        /// <summary>
        /// Increments a specified cosst by the specified amount.
        /// </summary>
        /// <param name="costType">
        /// The type of cost being incremented.
        /// </param>
        /// <param name="amount">
        /// The amount the cost is bein incremented by.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the amount is less than 0.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the amount is equal to 0.
        /// </exception>
        public void AddCost(CostType costType, decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount",
                        "Argument cannot be less than 0.");
            }

            if (amount == 0)
            {
                throw new ArgumentOutOfRangeException("amount",
                        "Argument cannot be equal to 0.");
            }

            switch (costType)
            {
                case CostType.Labour:
                    LabourCost += amount;
                    break;
                case CostType.Material:
                    MaterialCost += amount;
                    break;
                case CostType.Part:
                    PartsCost += amount;
                    break;
            }
        }
    }
}