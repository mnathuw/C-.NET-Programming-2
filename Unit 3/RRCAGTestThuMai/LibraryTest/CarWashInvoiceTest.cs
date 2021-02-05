using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mai.Thu.Business;
namespace LibraryTest
{
    /// <summary>
    /// Summary description for CarWashInvoiceTest
    /// </summary>
    [TestClass]
    public class CarWashInvoiceTest
    {
        [TestMethod]
        public void CarWashInvoice_WithNoPackageAndFragranceCost_Test()
        {
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.1M, 0.3M);
            PrivateObject privateCarWashInvoice = new PrivateObject(carWashInvoice);
            PrivateObject privateInvoice = new PrivateObject(carWashInvoice, new PrivateType(typeof(Invoice)));
            Assert.AreEqual(0.1M, (decimal)privateInvoice.GetField("provincialSalesTaxRate"));
            Assert.AreEqual(0.3M, (decimal)privateInvoice.GetField("goodsAndServicesTaxRate"));
        }

        [TestMethod]
        public void CarWashInvoice_Test()
        {
            decimal packageCost = 0.1M;
            decimal fragranceCost = 0.4M;
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.1M, 0.3M, packageCost, fragranceCost);
            decimal expectedPackageCost = 0.1M;
            decimal expectedFragranceCost = 0.4M;
            PrivateObject privateCarWashInvoice = new PrivateObject(carWashInvoice);
            decimal actualPackageCost = (decimal)privateCarWashInvoice.GetField("packageCost");
            decimal actualFragranceCost = (decimal)privateCarWashInvoice.GetField("fragranceCost");
            PrivateObject privateInvoice = new PrivateObject(carWashInvoice, new PrivateType(typeof(Invoice)));
            Assert.AreEqual(0.1M, (decimal)privateInvoice.GetField("provincialSalesTaxRate"));
            Assert.AreEqual(0.3M, (decimal)privateInvoice.GetField("goodsAndServicesTaxRate"));
            Assert.AreEqual(expectedPackageCost, actualPackageCost);
            Assert.AreEqual(expectedFragranceCost, actualFragranceCost);
        }

        [TestMethod]
        public void GetPackageCost_Test()
        {
            decimal packageCost = 0.3M;
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2M, 0.1M, packageCost, 0.8M);
            decimal expectedPackageCost = 0.3M;
            decimal actualPackageCost = carWashInvoice.PackageCost;
            Assert.AreEqual(expectedPackageCost, actualPackageCost);
        }

        [TestMethod]
        public void SetPackageCost_Test()
        {
            decimal packageCost = 0.1M;
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.1M, 0.2M, packageCost, 0.4M);
            decimal expectedPackageCost = 0.1M;
            carWashInvoice.PackageCost = 0.1M;
            PrivateObject target = new PrivateObject(carWashInvoice);
            decimal actualPackageCost = (decimal)target.GetField("packageCost");
            Assert.AreEqual(expectedPackageCost, actualPackageCost);
        }

        [TestMethod]
        public void GetFragranceCost_Test()
        {
            decimal fragranceCost = 0.3M;
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2M, 0.1M, 0.3M, fragranceCost);
            decimal expectedFragranceCost = 0.3M;
            decimal actualFragranceCost = carWashInvoice.FragranceCost;
            Assert.AreEqual(expectedFragranceCost, actualFragranceCost);
        }

        [TestMethod]
        public void SetFragranceCost_Test()
        {
            decimal fragranceCost = 0.1M;
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.1M, 0.2M, 0.3M, fragranceCost);
            decimal expectedFragranceCost = 0.1M;
            carWashInvoice.FragranceCost = 0.1M;
            PrivateObject target = new PrivateObject(carWashInvoice);
            decimal actualFragranceCost = (decimal)target.GetField("fragranceCost");
            Assert.AreEqual(expectedFragranceCost, actualFragranceCost);
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
        public void SetPackageCost_Less_Test()
        {
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.1M, 0.2M, 0.3M, 0.4M);
            decimal expectedPackageCost = 0.3M;
            try
            {
                carWashInvoice.PackageCost = -3M;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(carWashInvoice);
                decimal actualPackageCost = (decimal)target.GetField("packageCost");
                Assert.AreEqual(expectedPackageCost, actualPackageCost);
            }
        }

        [TestMethod]
        public void SetFragranceCost_Less_Test()
        {
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.1M, 0.2M, 0.3M, 0.4M);
            decimal expectedFragranceCost = 0.4M;
            try
            {
                carWashInvoice.FragranceCost = -3M;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(carWashInvoice);
                decimal actualFragranceCost = (decimal)target.GetField("fragranceCost");
                Assert.AreEqual(expectedFragranceCost, actualFragranceCost);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_WithNoPackageAndFragranceCost_ProvincialSalesTaxRate_Less_Exception_Test()
        {
            decimal provincialSalesTaxRate = -0.1M;
            decimal goodsAndServicesTaxRate = 0.3M;
            CarWashInvoice actualCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_WithNoPackageAndFragranceCost_ProvincialSalesTaxRate_Greater_Exception_Test()
        {
            decimal provincialSalesTaxRate = 3M;
            decimal goodsAndServicesTaxRate = 0.3M;
            CarWashInvoice actualCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_WithNoPackageAndFragranceCost_GoodsAndServicesTaxRate_Less_Exception_Test()
        {
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = -0.3M;
            CarWashInvoice actualCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_WithNoPackageAndFragranceCost_GoodsAndServicesTaxRate_Greater_Exception_Test()
        {
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 3M;
            CarWashInvoice actualCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_ProvincialSalesTaxRate_Less_Exception_Test()
        {
            decimal provincialSalesTaxRate = -0.1M;
            decimal goodsAndServicesTaxRate = 0.3M;
            decimal packageCost = 0.4M;
            decimal fragranceCost = 0.5M;
            CarWashInvoice actualCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_ProvincialSalesTaxRate_Greater_Exception_Test()
        {
            decimal provincialSalesTaxRate = 3M;
            decimal goodsAndServicesTaxRate = 0.3M;
            decimal packageCost = 0.4M;
            decimal fragranceCost = 0.5M;
            CarWashInvoice actualCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_GoodsAndServicesTaxRate_Less_Exception_Test()
        {
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = -0.3M;
            decimal packageCost = 0.4M;
            decimal fragranceCost = 0.5M;
            CarWashInvoice actualCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_GoodsAndServicesTaxRate_Greater_Exception_Test()
        {
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 3M;
            decimal packageCost = 0.4M;
            decimal fragranceCost = 0.5M;
            CarWashInvoice actualCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_PackageCost_Less_Exception_Test()
        {
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.3M;
            decimal packageCost = -0.4M;
            decimal fragranceCost = 0.5M;
            CarWashInvoice actualCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarWashInvoice_Fragrance_Less_Exception_Test()
        {
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.3M;
            decimal packageCost = 0.4M;
            decimal fragranceCost = -0.5M;
            CarWashInvoice actualCarWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
        }
    }
}

