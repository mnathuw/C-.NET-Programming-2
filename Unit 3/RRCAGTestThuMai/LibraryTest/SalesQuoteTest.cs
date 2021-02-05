using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mai.Thu.Business;
namespace LibraryTest
{
    [TestClass]
    public class SalesQuoteTest
    {
        /// <summary>
        /// Summary description for SalesQuoteTest
        /// </summary>
        [TestMethod]
        public void SalesQuote_WithNoAccessoriesAndFinishChosen_Test()
        {
            decimal vehicleSalePrice = 0.1M;
            decimal tradeInAmount = 0.2M;
            decimal salesTaxRate = 0.1M;
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            decimal expectedVehicleSalePrice = 0.1M;
            decimal expectedTradeInAmount = 0.2M;
            decimal expectedSalesTaxRate = 0.1M;
            PrivateObject target = new PrivateObject(salesQuote);
            decimal actualVehicleSalePrice = (decimal)target.GetField("vehicleSalePrice");
            decimal actualTradeInAmount = (decimal)target.GetField("tradeInAmount");
            decimal actualSalesTaxRate = (decimal)target.GetField("salesTaxRate");
            Assert.AreEqual(expectedSalesTaxRate, actualSalesTaxRate);
            Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);
            Assert.AreEqual(expectedVehicleSalePrice, actualVehicleSalePrice);
        }

        [TestMethod]
        public void SalesQuote_Test()
        {
            decimal vehicleSalePrice = 0.1M;
            decimal tradeInAmount = 0.2M;
            decimal salesTaxRate = 0.1M;
            Accessories accessoriesChosen = new Accessories();
            ExteriorFinish exteriorFinishChosen = new ExteriorFinish();
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
            decimal expectedVehicleSalePrice = 0.1M;
            decimal expectedTradeInAmount = 0.2M;
            decimal expectedSalesTaxRate = 0.1M;
            Accessories expectedAccessoriesChosen = new Accessories();
            ExteriorFinish expectedExteriorFinishChosen = new ExteriorFinish();
            PrivateObject target = new PrivateObject(salesQuote);
            decimal actualVehicleSalePrice = (decimal)target.GetField("vehicleSalePrice");
            decimal actualTradeInAmount = (decimal)target.GetField("tradeInAmount");
            decimal actualSalesTaxRate = (decimal)target.GetField("salesTaxRate");
            Accessories actualAccessoriesChosen = (Accessories)target.GetField("accessoriesChosen");
            ExteriorFinish actualExteriorFinishChosen = (ExteriorFinish)target.GetField("exteriorFinishChosen");
            Assert.AreEqual(expectedSalesTaxRate, actualSalesTaxRate);
            Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);
            Assert.AreEqual(expectedVehicleSalePrice, actualVehicleSalePrice);
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
            Assert.AreEqual(expectedExteriorFinishChosen, actualExteriorFinishChosen);
        }
        [TestMethod]
        public void VehicleSalePrice_Get_Test()
        {
            decimal vehicleSalePrice = 0.3M;
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, 0.2M, 0.3M, Accessories.None, ExteriorFinish.None);
            decimal expectedVehicleSalePrice = 0.3M;
            decimal actualVehicleSalePrice = salesQuote.VehicleSalePrice;
            Assert.AreEqual(expectedVehicleSalePrice, actualVehicleSalePrice);
        }

        [TestMethod]
        public void VehicleSalePrice_Set_Test()
        {
            decimal vehicleSalePrice = 0.1M;
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, 0.2M, 0.3M, Accessories.None, ExteriorFinish.None);
            decimal expectedVehicleSalePrice = 0.3M;
            salesQuote.VehicleSalePrice = 0.3M;
            PrivateObject target = new PrivateObject(salesQuote);
            decimal actualVehicleSalePrice = (decimal)target.GetField("vehicleSalePrice");
            Assert.AreEqual(expectedVehicleSalePrice, actualVehicleSalePrice);
        }

        [TestMethod]
        public void TradeInAmount_Get_Test()
        {
            decimal tradeInAmount = 0.4M;
            SalesQuote salesQuote = new SalesQuote(0.3M, tradeInAmount, 0.3M, Accessories.None, ExteriorFinish.None);
            decimal expectedTradeInAmount = 0.4M;
            decimal actualTradeInAmount = salesQuote.TradeInAmount;
            Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);
        }

        [TestMethod]
        public void TradeInAmount_Set_Test()
        {
            decimal tradeInAmount = 0.1M;
            SalesQuote salesQuote = new SalesQuote(0.3M, tradeInAmount, 0.3M, Accessories.None, ExteriorFinish.None);
            decimal expectedTradeInAmount = 0.4M;
            salesQuote.TradeInAmount = 0.4M;
            PrivateObject target = new PrivateObject(salesQuote);
            decimal actualTradeInAmount = (decimal)target.GetField("tradeInAmount");
            Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);
        }

        [TestMethod]
        public void AccessoriesChosen_Get_None_Test()
        {
            Accessories accessoriesChosen = new Accessories();
            accessoriesChosen = Accessories.None;
            SalesQuote salesQuote = new SalesQuote(0.3M, 0.3M, 0.3M, accessoriesChosen, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = new Accessories();
            expectedAccessoriesChosen = Accessories.None;
            Accessories actualAccessoriesChosen = salesQuote.AccessoriesChosen;
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void AccessoriesChosen_Set_None_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.All, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.None;
            salesQuote.AccessoriesChosen = Accessories.None;
            PrivateObject target = new PrivateObject(salesQuote);
            Accessories actualAccessoriesChosen = (Accessories)target.GetField("accessoriesChosen");
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void AccessoriesChosen_Get_StereoSystem_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.StereoSystem, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.StereoSystem;
            Accessories actualAccessoriesChosen = salesQuote.AccessoriesChosen;
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void AccessoriesChosen_Set_StereoSystem_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.None, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.StereoSystem;
            salesQuote.AccessoriesChosen = Accessories.StereoSystem;
            PrivateObject target = new PrivateObject(salesQuote);
            Accessories actualAccessoriesChosen = (Accessories)target.GetField("accessoriesChosen");
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void AccessoriesChosen__Get_LeatherInterior_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.LeatherInterior, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.LeatherInterior;
            Accessories actualAccessoriesChosen = salesQuote.AccessoriesChosen;
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void SetAccessoriesChosen_LeatherInterior_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.LeatherInterior, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.LeatherInterior;
            salesQuote.AccessoriesChosen = Accessories.LeatherInterior;
            PrivateObject target = new PrivateObject(salesQuote);
            Accessories actualAccessoriesChosen = (Accessories)target.GetField("accessoriesChosen");
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void GetAccessoriesChosen_StereoAndLeather_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.StereoAndLeather, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.StereoAndLeather;
            Accessories actualAccessoriesChosen = salesQuote.AccessoriesChosen;
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void SetAccessoriesChosen_StereAndLeather_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.StereoAndLeather, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.StereoAndLeather;
            salesQuote.AccessoriesChosen = Accessories.StereoAndLeather;
            PrivateObject target = new PrivateObject(salesQuote);
            Accessories actualAccessoriesChosen = (Accessories)target.GetField("accessoriesChosen");
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void GetAccessoriesChosen_ComputerNavigation_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.ComputerNavigation, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.ComputerNavigation;
            Accessories actualAccessoriesChosen = salesQuote.AccessoriesChosen;
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void SetAccessoriesChosen_ComputerNavigation_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.ComputerNavigation, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.ComputerNavigation;
            salesQuote.AccessoriesChosen = Accessories.ComputerNavigation;
            PrivateObject target = new PrivateObject(salesQuote);
            Accessories actualAccessoriesChosen = (Accessories)target.GetField("accessoriesChosen");
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void GetAccessoriesChosen_StereoAndNavigation_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.StereoAndNavigation, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.StereoAndNavigation;
            Accessories actualAccessoriesChosen = salesQuote.AccessoriesChosen;
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void SetAccessoriesChosen_StereoAndNavigation_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.StereoAndNavigation, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.StereoAndNavigation;
            salesQuote.AccessoriesChosen = Accessories.StereoAndNavigation;
            PrivateObject target = new PrivateObject(salesQuote);
            Accessories actualAccessoriesChosen = (Accessories)target.GetField("accessoriesChosen");
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void GetAccessoriesChosen_LeatherAndNavigation_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.LeatherAndNavigation, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.LeatherAndNavigation;
            Accessories actualAccessoriesChosen = salesQuote.AccessoriesChosen;
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void SetAccessoriesChosen_LeatherAndNavigation_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.LeatherAndNavigation, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.LeatherAndNavigation;
            salesQuote.AccessoriesChosen = Accessories.LeatherAndNavigation;
            PrivateObject target = new PrivateObject(salesQuote);
            Accessories actualAccessoriesChosen = (Accessories)target.GetField("accessoriesChosen");
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void GetAccessoriesChosen_All_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.All, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.All;
            Accessories actualAccessoriesChosen = salesQuote.AccessoriesChosen;
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void SetAccessoriesChosen_All_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.All, ExteriorFinish.None);
            Accessories expectedAccessoriesChosen = Accessories.All;
            salesQuote.AccessoriesChosen = Accessories.All;
            PrivateObject target = new PrivateObject(salesQuote);
            Accessories actualAccessoriesChosen = (Accessories)target.GetField("accessoriesChosen");
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void GetExteriorChosen_None_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.None, ExteriorFinish.None);
            ExteriorFinish expectedExteriorChosen = ExteriorFinish.None;
            ExteriorFinish actualExteriorChosen = salesQuote.ExteriorFinishChosen;
            Assert.AreEqual(expectedExteriorChosen, actualExteriorChosen);
        }

        [TestMethod]
        public void SetExteriorChosen_None_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.All, ExteriorFinish.None);
            ExteriorFinish expectedExteriorChosen = ExteriorFinish.None;
            salesQuote.ExteriorFinishChosen = ExteriorFinish.None;
            PrivateObject target = new PrivateObject(salesQuote);
            ExteriorFinish actualExteriorChosen = (ExteriorFinish)target.GetField("exteriorFinishChosen");
            Assert.AreEqual(expectedExteriorChosen, actualExteriorChosen);
        }

        [TestMethod]
        public void GetExteriorChosen_Custom_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.None, ExteriorFinish.Custom);
            ExteriorFinish expectedExteriorChosen = ExteriorFinish.Custom;
            ExteriorFinish actualExteriorChosen = salesQuote.ExteriorFinishChosen;
            Assert.AreEqual(expectedExteriorChosen, actualExteriorChosen);
        }

        [TestMethod]
        public void SetExteriorChosen_Custom_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.All, ExteriorFinish.Custom);
            ExteriorFinish expectedExteriorChosen = ExteriorFinish.Custom;
            salesQuote.ExteriorFinishChosen = ExteriorFinish.Custom;
            PrivateObject target = new PrivateObject(salesQuote);
            ExteriorFinish actualExteriorChosen = (ExteriorFinish)target.GetField("exteriorFinishChosen");
            Assert.AreEqual(expectedExteriorChosen, actualExteriorChosen);
        }

        [TestMethod]
        public void GetExteriorChosen_Pearlized_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.None, ExteriorFinish.Pearlized);
            ExteriorFinish expectedExteriorChosen = ExteriorFinish.Pearlized;
            ExteriorFinish actualExteriorChosen = salesQuote.ExteriorFinishChosen;
            Assert.AreEqual(expectedExteriorChosen, actualExteriorChosen);
        }

        [TestMethod]
        public void SetExteriorChosen_Pearlized_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.All, ExteriorFinish.Pearlized);
            ExteriorFinish expectedExteriorChosen = ExteriorFinish.Pearlized;
            salesQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;
            PrivateObject target = new PrivateObject(salesQuote);
            ExteriorFinish actualExteriorChosen = (ExteriorFinish)target.GetField("exteriorFinishChosen");
            Assert.AreEqual(expectedExteriorChosen, actualExteriorChosen);
        }

        [TestMethod]
        public void GetExteriorChosen_Standard_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.None, ExteriorFinish.Standard);
            ExteriorFinish expectedExteriorChosen = ExteriorFinish.Standard;
            ExteriorFinish actualExteriorChosen = salesQuote.ExteriorFinishChosen;
            Assert.AreEqual(expectedExteriorChosen, actualExteriorChosen);
        }

        [TestMethod]
        public void SetExteriorChosen_Standard_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.All, ExteriorFinish.Standard);
            ExteriorFinish expectedExteriorChosen = ExteriorFinish.Standard;
            salesQuote.ExteriorFinishChosen = ExteriorFinish.Standard;
            PrivateObject target = new PrivateObject(salesQuote);
            ExteriorFinish actualExteriorChosen = (ExteriorFinish)target.GetField("exteriorFinishChosen");
            Assert.AreEqual(expectedExteriorChosen, actualExteriorChosen);
        }

        [TestMethod]
        public void GetAccessoryCost_Test()
        {
            Accessories accessoriesChosen = new Accessories();
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, accessoriesChosen, ExteriorFinish.Standard);
            decimal expectedAccessoryCost;
            decimal stereoSystem = 505.05M;
            decimal leatherInterior = 1010.10M;
            decimal computerNavigation = 1515.15M;
            switch (accessoriesChosen)
            {
                case Accessories.StereoSystem:
                    expectedAccessoryCost = stereoSystem;
                    break;
                case Accessories.LeatherInterior:
                    expectedAccessoryCost = leatherInterior;
                    break;
                case Accessories.ComputerNavigation:
                    expectedAccessoryCost = computerNavigation;
                    break;
                case Accessories.StereoAndLeather:
                    expectedAccessoryCost = stereoSystem + leatherInterior;
                    break;
                case Accessories.StereoAndNavigation:
                    expectedAccessoryCost = stereoSystem + computerNavigation;
                    break;
                case Accessories.LeatherAndNavigation:
                    expectedAccessoryCost = leatherInterior + computerNavigation;
                    break;
                case Accessories.All:
                    expectedAccessoryCost = stereoSystem + leatherInterior + computerNavigation;
                    break;
                default:
                    expectedAccessoryCost = 0.00M;
                    break;
            }
            decimal actualAccessoryCost = salesQuote.AccessoryCost;
            Assert.AreEqual(expectedAccessoryCost, actualAccessoryCost);
        }

        [TestMethod]
        public void GetFinishCost__Test()
        {
            ExteriorFinish exteriorFinishChosen = new ExteriorFinish();
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.None, exteriorFinishChosen);
            decimal expectedFinishCost;
            decimal standard = 202.02M;
            decimal pearlized = 404.04M;
            decimal custom = 606.06M;
            switch (exteriorFinishChosen)
            {
                case ExteriorFinish.Custom:
                    expectedFinishCost = custom;
                    break;
                case ExteriorFinish.Pearlized:
                    expectedFinishCost = pearlized;
                    break;
                case ExteriorFinish.Standard:
                    expectedFinishCost = standard;
                    break;
                default:
                    expectedFinishCost = 0.00M;
                    break;
            }
            decimal actualFinishCost = salesQuote.FinishCost;
            Assert.AreEqual(expectedFinishCost, actualFinishCost);
        }

        [TestMethod]
        public void GetSubTotal_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.None, ExteriorFinish.Standard);
            decimal expectedSubTotal = 202.12M;
            decimal actualSubTotal = salesQuote.SubTotal;
            Assert.AreEqual(expectedSubTotal, actualSubTotal);
        }

        [TestMethod]
        public void GetSalesTax_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.None, ExteriorFinish.Standard);
            decimal expectedSalesTax = 60.636M;
            decimal actualSalesTax = salesQuote.SalesTax;
            Assert.AreEqual(expectedSalesTax, actualSalesTax);
        }

        [TestMethod]
        public void GetAmountDue_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.None, ExteriorFinish.Standard);
            decimal expectedAmountDue = 262.556M;
            decimal actualAmountDue = salesQuote.AmountDue;
            Assert.AreEqual(expectedAmountDue, actualAmountDue);
        }

        [TestMethod]
        public void SetVehicleSalePrice_Less_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.None, ExteriorFinish.Standard);
            decimal expectedVehicleSalePrice = 0.1M;
            try
            {
                salesQuote.VehicleSalePrice = -0.1M;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(salesQuote);
                decimal actualVehicleSalePrice = (decimal)target.GetField("vehicleSalePrice");
                Assert.AreEqual(expectedVehicleSalePrice, actualVehicleSalePrice);
            }
        }

        [TestMethod]
        public void SetVehicleSalePrice_Equal_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.None, ExteriorFinish.Standard);
            decimal expectedVehicleSalePrice = 0.1M;
            try
            {
                salesQuote.VehicleSalePrice = 0M;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(salesQuote);
                decimal actualVehicleSalePrice = (decimal)target.GetField("vehicleSalePrice");
                Assert.AreEqual(expectedVehicleSalePrice, actualVehicleSalePrice);
            }
        }

        [TestMethod]
        public void SetTradeInAmount_Less_Test()
        {
            SalesQuote salesQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.None, ExteriorFinish.Standard);
            decimal expectedTradeInAmount = 0.2M;
            try
            {
                salesQuote.TradeInAmount = -0.1M;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(salesQuote);
                decimal actualTradeInAmount = (decimal)target.GetField("tradeInAmount");
                Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SalesQuote_VehicleSalesPrice_Less_Exception_Test()
        {
            decimal vehicleSalesPrice = -0.1M;
            decimal tradeInAmount = 0.3M;
            decimal salesTaxRate = 0.4M;
            Accessories accessories = Accessories.All;
            ExteriorFinish exteriorFinish = ExteriorFinish.Custom;
            SalesQuote actualSalesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, exteriorFinish);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SalesQuote_VehicleSalesPrice_Equal_Exception_Test()
        {
            decimal vehicleSalesPrice = 0M;
            decimal tradeInAmount = 0.3M;
            decimal salesTaxRate = 0.4M;
            Accessories accessories = Accessories.All;
            ExteriorFinish exteriorFinish = ExteriorFinish.Custom;
            SalesQuote actualSalesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, exteriorFinish);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SalesQuote_TradeInAmount_Less_Exception_Test()
        {
            decimal vehicleSalesPrice = 0.1M;
            decimal tradeInAmount = -0.3M;
            decimal salesTaxRate = 0.4M;
            Accessories accessories = Accessories.All;
            ExteriorFinish exteriorFinish = ExteriorFinish.Custom;
            SalesQuote actualSalesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, exteriorFinish);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SalesQuote_SalesTaxRate_Less_Exception_Test()
        {
            decimal vehicleSalesPrice = 0.1M;
            decimal tradeInAmount = 0.3M;
            decimal salesTaxRate = -0.4M;
            Accessories accessories = Accessories.All;
            ExteriorFinish exteriorFinish = ExteriorFinish.Custom;
            SalesQuote actualSalesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, exteriorFinish);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SalesQuote_VehicleSalesPrice_Greater_Exception_Test()
        {
            decimal vehicleSalesPrice = 0.1M;
            decimal tradeInAmount = 0.3M;
            decimal salesTaxRate = 4M;
            Accessories accessories = Accessories.All;
            ExteriorFinish exteriorFinish = ExteriorFinish.Custom;
            SalesQuote actualSalesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, exteriorFinish);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SalesQuote_WithNoAccessoriesAndFinishChosen_VehicleSalesPrice_Less_Exception_Test()
        {
            decimal vehicleSalesPrice = -0.1M;
            decimal tradeInAmount = 0.3M;
            decimal salesTaxRate = 0.4M;
            SalesQuote actualSalesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SalesQuote_WithNoAccessoriesAndFinishChosen_VehicleSalesPrice_Equal_Exception_Test()
        {
            decimal vehicleSalesPrice = 0M;
            decimal tradeInAmount = 0.3M;
            decimal salesTaxRate = 0.4M;
            SalesQuote actualSalesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SalesQuote_WithNoAccessoriesAndFinishChosen_TradeInAmount_Less_Exception_Test()
        {
            decimal vehicleSalesPrice = 0.1M;
            decimal tradeInAmount = -0.3M;
            decimal salesTaxRate = 0.4M;
            SalesQuote actualSalesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SalesQuote_WithNoAccessoriesAndFinishChosen_SalesTaxRate_Less_Exception_Test()
        {
            decimal vehicleSalesPrice = 0.1M;
            decimal tradeInAmount = 0.3M;
            decimal salesTaxRate = -0.4M;
            SalesQuote actualSalesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SalesQuote_WithNoAccessoriesAndFinishChosen_VehicleSalesPrice_Greater_Exception_Test()
        {
            decimal vehicleSalesPrice = 0.1M;
            decimal tradeInAmount = 0.3M;
            decimal salesTaxRate = 4M;
            SalesQuote actualSalesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate);
        }
    }
}
 