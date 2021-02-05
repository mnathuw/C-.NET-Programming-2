using System;

namespace Mai.Thu.Business
{
    /// <summary>
    /// Contains functionality that includes financial functions.
    /// </summary>
    public static class Financial
    {
        /// <summary>
        /// Returns the payment amount for an annuity based on periodic, fixed payments
        /// and a fixed interest rate.
        /// </summary>
        /// <param name="rate">The interest rate per period.</param>
        /// <param name="numberOfPaymentPeriods">
        /// The total number of payment periods in the annuity.
        /// </param>
        /// <param name="presentValue">
        /// The present value (or lump sum) that a series of payments to be paid
        /// in the future is worth now.
        /// </param>
        /// <returns>
        /// The payment amount for an annuity.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the rate is less than 0.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the rate is greater than 1
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the number of payment periods is less than 0.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the number of payment periods is equal to 0
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the present value is less than 0.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the present value is equal to 0.
        /// </exception>
        public static decimal GetPayment(decimal rate, int numberOfPaymentPeriods,
                                            decimal presentValue)
        {
            if (rate < 0)
            {
                throw new ArgumentOutOfRangeException("rate",
                    "Argument cannot be less than 0.");
            }

            if (rate > 1)
            {
                throw new ArgumentOutOfRangeException("rate",
                    "Argument cannot be greater than 1.");
            }

            if (numberOfPaymentPeriods < 0)
            {
                throw new ArgumentOutOfRangeException("numberOfPaymentPeriods",
                    "Argument cannot be less than 0.");
            }

            if (numberOfPaymentPeriods == 0)
            {
                throw new ArgumentOutOfRangeException("numberOfPaymentPeriods",
                    "Argument cannot be equal to 0.");
            }

            if (presentValue < 0)
            {
                throw new ArgumentOutOfRangeException("presentValue",
                    "Argument cannot be less than 0.");
            }

            if (presentValue == 0)
            {
                throw new ArgumentOutOfRangeException("presentValue",
                    "Argument cannot be equal to 0.");
            }

            decimal futureValue = 0;
            decimal type = 0;
            return (rate == 0) ? presentValue / numberOfPaymentPeriods : rate *
                (futureValue + presentValue * (decimal)Math.Pow((double)(1 + rate),
                (double)numberOfPaymentPeriods)) / (((decimal)Math.Pow((double)(1 + rate),
                (double)numberOfPaymentPeriods) - 1) * (1 + rate * type));
        }
    }
}