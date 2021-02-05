using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mai.Thu.Business;
namespace LibraryTest
{
    /// <summary>
    /// Summary description for SalesQuoteTest
    /// </summary>
    [TestClass]
    public class ServiceInvoiceTest
    {
        [TestMethod]
        public void ServiceInvoice_Test()
        {
            ServiceInvoice serviceInvoice = new ServiceInvoice(0.1M, 0.3M);
            PrivateObject privateServiceInvoice = new PrivateObject(serviceInvoice);
            PrivateObject privateInvoice = new PrivateObject(serviceInvoice, new PrivateType(typeof(Invoice)));
            Assert.AreEqual(0.1M, (decimal)privateInvoice.GetField("provincialSalesTaxRate"));
            Assert.AreEqual(0.3M, (decimal)privateInvoice.GetField("goodsAndServicesTaxRate"));
        }

        [TestMethod]
        public void LabourCost_Test()
        {
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.3M;
            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
            decimal expectedLabourCost = 0.3M;
            serviceInvoice.AddCost(CostType.Labour, expectedLabourCost);
            decimal actualLabourCost = serviceInvoice.LabourCost;
            Assert.AreEqual(expectedLabourCost, actualLabourCost);
        }

        [TestMethod]
        public void PartsCost_Test()
        {
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.3M;
            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
            decimal expectedPartsCost = 0.3M;
            serviceInvoice.AddCost(CostType.Part, expectedPartsCost);
            decimal actualPartsCost = serviceInvoice.PartsCost;
            Assert.AreEqual(expectedPartsCost, actualPartsCost);
        }

        [TestMethod]
        public void MaterialCost_Test()
        {
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.3M;
            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
            decimal expectedMaterialCost = 0.3M;
            serviceInvoice.AddCost(CostType.Material, expectedMaterialCost);
            decimal actualMaterialCost = serviceInvoice.MaterialCost;
            Assert.AreEqual(expectedMaterialCost, actualMaterialCost);
        }

        [TestMethod]
        public void ProvincialSalesTaxCharged_Test()
        {
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.3M;
            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
            serviceInvoice.AddCost(CostType.Material, 0.2M);
            decimal expectedProvincialSalesTaxCharged = 0.02M;
            decimal actualProvincialSalesTaxCharged = serviceInvoice.ProvincialSalesTaxCharged;
            Assert.AreEqual(expectedProvincialSalesTaxCharged, actualProvincialSalesTaxCharged);
        }

        [TestMethod]
        public void GoodsAndServicesTaxCharged_Test()
        {
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.3M;
            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
            serviceInvoice.AddCost(CostType.Material, 0.2M);
            decimal expectedGoodsAndServicesTaxCharged = 0.06M;
            decimal actualGoodsAndServicesTaxCharged = serviceInvoice.GoodsAndServicesTaxCharged;
            Assert.AreEqual(expectedGoodsAndServicesTaxCharged, actualGoodsAndServicesTaxCharged);
        }

        [TestMethod]
        public void SubTotal_Test()
        {
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.3M;
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, 0.1M, 0.3M);
            decimal expectedSubTotal = 0.4M;
            decimal actualSubTotal = carWashInvoice.SubTotal;
            Assert.AreEqual(expectedSubTotal, actualSubTotal);
        }

        [TestMethod]
        public void Total_Test()
        {
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.3M;
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, 0.3M, 0.4M);
            decimal expectedTotal = 0.91M;
            decimal actualTotal = carWashInvoice.Total;
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ServiceInvoice_ProvincialSalesTaxRate_Less_Exception_Test()
        {
            decimal provincialSalesTaxRate = -0.1M;
            decimal goodsAndServicesTaxRate = 0.3M;
            ServiceInvoice actualServiceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ServiceInvoice_ProvincialSalesTaxRate_Greater_Exception_Test()
        {
            decimal provincialSalesTaxRate = 3M;
            decimal goodsAndServicesTaxRate = 0.3M;
            ServiceInvoice actualServiceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ServiceInvoice_GoodsAndServicesTaxRate_Less_Exception_Test()
        {
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = -0.3M;
            ServiceInvoice actualServiceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ServiceInvoice_GoodsAndServicesTaxRate_Greater_Exception_Test()
        {
            decimal provincialSalesTaxRate = -0.1M;
            decimal goodsAndServicesTaxRate = 3M;
            ServiceInvoice actualServiceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddCost_Less_Exception_Test()
        {
            decimal amount = -0.3M;
            CostType costType = CostType.Labour;
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.3M;
            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
            serviceInvoice.AddCost(costType, amount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddCost_Equal_Exception_Test()
        {
            decimal amount = 0M;
            CostType costType = CostType.Labour;
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.3M;
            ServiceInvoice serviceInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
            serviceInvoice.AddCost(costType, amount);
        }
    }
}