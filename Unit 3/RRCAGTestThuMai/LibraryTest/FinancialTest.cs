using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mai.Thu.Business;
namespace LibraryTest
{
    /// <summary>
    /// Summary description for FinancialTest
    /// </summary>
    [TestClass]
    public class FinancialTest
    {
        [TestMethod]
        public void GetPayment_Test()
        {
            decimal expected = 0.17M;
            decimal actual = (decimal)Math.Round(Financial.GetPayment(0.1M, 2, 0.3M), 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_Rate_Less_Exception_Test()
        {
            decimal rate = -0.3m;
            int numberOfPaymentPeriods = 10;
            decimal presentValue = 600m;
            decimal actualPayment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_Rate_Greater_Exception_Test()
        {
            decimal rate = 3m;
            int numberOfPaymentPeriods = 10;
            decimal presentValue = 600m;
            decimal actualPayment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_NumberOfPaymentPeriods_Less_Exception_Test()
        {
            decimal rate = 0.3m;
            int numberOfPaymentPeriods = -10;
            decimal presentValue = 600m;
            decimal actualPayment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_NumberOfPaymentPeriods_Equal_Exception_Test()
        {
            decimal rate = 0.3m;
            int numberOfPaymentPeriods = 0;
            decimal presentValue = 600m;
            decimal actualPayment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_PresentValue_Less_Exception_Test()
        {
            decimal rate = 0.3m;
            int numberOfPaymentPeriods = 3;
            decimal presentValue = -600m;
            decimal actualPayment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_PresentValue_Equal_Exception_Test()
        {
            decimal rate = 0.3m;
            int numberOfPaymentPeriods = 3;
            decimal presentValue = 0m;
            decimal actualPayment = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
        }
    }
}
