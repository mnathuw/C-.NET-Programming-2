using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mai.Thu.Business
{
    class RRCAGApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TEST: Creates a SalesQuote with no accessories chosen and no exterior finish chosen. \n");
            //Initialize a SalesQuote object, no accessories chosen and no exterior finish chosen.
            SalesQuote saleQuote = new SalesQuote(30000.495M, 2000.095M, 0.3M);

            Console.WriteLine("TEST: ToString: {0}", saleQuote);

            // Test Exception of SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate) contstructor
            // Exception of vehicleSalePrice. Value <= 0
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR vehicleSalePrice <= 0. Set the value to 0M\n");
                new SalesQuote(0, 2000.095M, 0.3M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than or equal to 0.\nParameter name: vehicleSalePrice");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR vehicleSalePrice <= 0. Set the value to -5000M\n");
                new SalesQuote(-5000, 2000.095M, 0.3M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than or equal to 0.\nParameter name: vehicleSalePrice");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of tradeInAmount. Value < 0
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR tradeInAmount < 0. Set the value to -2000M\n");
                new SalesQuote(30000.495M, -2000, 0.3M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0.\nParameter name: tradeInAmount");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of salesTaxRate. Value < 0
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR salesTaxRate < 0. Set the value to -0.3M\n");
                new SalesQuote(30000.495M, 2000, -0.3M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0.\nParameter name: salesTaxRate");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of salesTaxRate. Value > 1
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR salesTaxRate > 1. Set the value to 2M\n");
                new SalesQuote(30000.495M, 2000, 2M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be greater than 1.\nParameter name: salesTaxRate");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            //Test Properties

            // Property Get/Set VehicleSalePrice
            Console.WriteLine("TEST: Testing Gets property VehicleSalePrice\n");
            Console.WriteLine("Expected: 30000.50");
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.VehicleSalePrice);

            Console.WriteLine("TEST: Testing Sets property VehicleSalePrice. Set the value to 40000.495M\n");
            saleQuote.VehicleSalePrice = 40000.495M;
            Console.WriteLine("Expected: 40000.50");
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.VehicleSalePrice);

            // Exception of VehicleSalePrice. Value <=0
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION VehicleSalePrice <= 0 . Set the value to 0M\n");
                saleQuote.VehicleSalePrice = 0M;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than or equal to 0.\nParameter name: VehicleSalePrice");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION VehicleSalePrice <= 0 . Set the value to -5000M\n");
                saleQuote.VehicleSalePrice = -5000M;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than or equal to 0.\nParameter name: VehicleSalePrice");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Property Get/Set TradeInAmount
            Console.WriteLine("TEST: Testing Gets property TradeInAmount\n");
            Console.WriteLine("Expected: 2000.10");
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.TradeInAmount);

            Console.WriteLine("TEST: Testing Sets property TradeInAmount. Set the value to 3000.095M\n");
            saleQuote.TradeInAmount = 3000.095M;
            Console.WriteLine("Expected: 3000.10");
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.TradeInAmount);

            // Exception of TradeInAmount. Value <=0
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION TradeInAmount < 0 . Set the value to -3000M\n");
                saleQuote.TradeInAmount = -3000M;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0.\nParameter name: TradeInAmount");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Property Get/Set AccessoriesChosen
            Console.WriteLine("TEST: Testing Gets property AccessoriesChosen\n");
            Console.WriteLine("Expected: None");
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.AccessoriesChosen);

            Console.WriteLine("TEST: Testing Sets property AccessoriesChosen. Set the value to All \n");
            saleQuote.AccessoriesChosen = Accessories.All;
            Console.WriteLine("Expected: All");
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.AccessoriesChosen);


            // Property Get/Set ExteriorFinishChosen
            Console.WriteLine("TEST: Testing Gets property ExteriorFinishChosen\n");
            Console.WriteLine("Expected: None");
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.ExteriorFinishChosen);

            Console.WriteLine("TEST: Testing Sets property ExteriorFinishChosen. Set the value to All \n");
            saleQuote.ExteriorFinishChosen = ExteriorFinish.Custom;
            Console.WriteLine("Expected: Custom");
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.ExteriorFinishChosen);

            // Property Get SubTotal
            Console.WriteLine("TEST: Testing Gets property SubTotal\n");
            Console.WriteLine("Result: VehicleSalePrice + AccessoryCost + ExteriorFinishCost");
            Console.WriteLine("Result:  40000.50 + 3030.30 + 606.06");
            Console.WriteLine("Expected: 43636.86");
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.SubTotal);

            // Property Get SalesTax
            Console.WriteLine("TEST: Testing Gets property SalesTax\n");
            Console.WriteLine("Result: SubTotal * salesTaxRate");
            Console.WriteLine("Result: 43636.86 * 0.3 ");
            Console.WriteLine("Expected: 13091.06");
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.SalesTax);

            // Property Get Total
            Console.WriteLine("TEST: Testing Gets property Total\n");
            Console.WriteLine("Result: SubTotal + SalesTax");
            Console.WriteLine("Result: 43636.86 + 13091.06");
            Console.WriteLine("Expected: 56727.92");
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.SubTotal + saleQuote.SalesTax);

            // Property Get AmountDue
            Console.WriteLine("TEST: Testing Gets property AmountDue\n");
            Console.WriteLine("Result: Total - TradeInAmount  ");
            Console.WriteLine("Result: 56727.92 - 3000.10");
            Console.WriteLine("Expected: 53727.82");
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.AmountDue);



            // Property Get AccessoryCost

            // Case: All
            Console.WriteLine("TEST: Set Accessory's the value to All \n");
            saleQuote.AccessoriesChosen = Accessories.All;
            Console.WriteLine("Expected (STEREOSYSTEM + LEATHERINTERIOR + COMPUTERNAVIGATION): {0}", saleQuote.AccessoriesChosen);
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.AccessoryCost);

            //Case: STEREOSYSTEM
            Console.WriteLine("TEST: Set Accessory's the value to StereoSystem \n");
            saleQuote.AccessoriesChosen = Accessories.StereoSystem;
            Console.WriteLine("Expected (STEREOSYSTEM): {0}", saleQuote.AccessoriesChosen);
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.AccessoryCost);

            //Case: LEATHERINTERIOR
            Console.WriteLine("TEST: Set Accessory's the value to LeatherInterior \n");
            saleQuote.AccessoriesChosen = Accessories.LeatherInterior;
            Console.WriteLine("Expected (STEREOSYSTEM): {0}", saleQuote.AccessoriesChosen);
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.AccessoryCost);

            //Case: STEREOSYSTEM + LEATHERINTERIOR
            Console.WriteLine("TEST: Set Accessory's the value to StereoAndLeather \n");
            saleQuote.AccessoriesChosen = Accessories.StereoAndLeather;
            Console.WriteLine("Expected (STEREOSYSTEM): {0}", saleQuote.AccessoriesChosen);
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.AccessoryCost);

            //Case: COMPUTERNAVIGATION
            Console.WriteLine("TEST: Set Accessory's the value to ComputerNavigation \n");
            saleQuote.AccessoriesChosen = Accessories.ComputerNavigation;
            Console.WriteLine("Expected (STEREOSYSTEM): {0}", saleQuote.AccessoriesChosen);
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.AccessoryCost);

            //Case: STEREOSYSTEM + COMPUTERNAVIGATION
            Console.WriteLine("TEST: Set Accessory's the value to StereoAndNavigation \n");
            saleQuote.AccessoriesChosen = Accessories.StereoAndNavigation;
            Console.WriteLine("Expected (STEREOSYSTEM): {0}", saleQuote.AccessoriesChosen);
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.AccessoryCost);

            //Case: LEATHERINTERIOR + COMPUTERNAVIGATION
            Console.WriteLine("TEST: Set Accessory's the value to LeatherAndNavigation \n");
            saleQuote.AccessoriesChosen = Accessories.LeatherAndNavigation;
            Console.WriteLine("Expected (STEREOSYSTEM): {0}", Accessories.LeatherAndNavigation);
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.AccessoryCost);

            // Property FinishCost

            // Case : Custom
            Console.WriteLine("TEST: Set ExteriorFinish's the value to Custom \n");
            saleQuote.ExteriorFinishChosen = ExteriorFinish.Custom;
            Console.WriteLine("Expected (Custom value): {0}", saleQuote.ExteriorFinishChosen);
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.FinishCost);

            // Case : Standard
            Console.WriteLine("TEST: Set ExteriorFinish's the value to Standard \n");
            saleQuote.ExteriorFinishChosen = ExteriorFinish.Standard;
            Console.WriteLine("Expected (Custom value): {0}", saleQuote.ExteriorFinishChosen);
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.FinishCost);

            // Case : Pearlized
            Console.WriteLine("TEST: Set ExteriorFinish's the value to Pearlized \n");
            saleQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;
            Console.WriteLine("Expected (Custom value): {0}", saleQuote.ExteriorFinishChosen);
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.FinishCost);

            // Case : None
            Console.WriteLine("TEST: Set ExteriorFinish's the value to None \n");
            saleQuote.ExteriorFinishChosen = ExteriorFinish.None;
            Console.WriteLine("Expected (Custom value): {0}", saleQuote.ExteriorFinishChosen);
            Console.WriteLine("Actual: {0} [PASS] \n", saleQuote.FinishCost);

            ServiceInvoice servInvoice = new ServiceInvoice(0.3M, 0.4M);

            // Property Get LabourCost
            Console.WriteLine("TEST: Testing Gets property LabourCost\n");
            Console.WriteLine("Expected: 0");
            Console.WriteLine("Actual: {0} [PASS] \n", servInvoice.LabourCost);

            // Property Get PartsCost
            Console.WriteLine("TEST: Testing Gets property PartsCost \n");
            Console.WriteLine("Expected: 0");
            Console.WriteLine("Actual: {0} [PASS] \n", servInvoice.PartsCost);

            // Property Get MaterialCost
            Console.WriteLine("TEST: Testing Gets property MaterialCost \n");
            Console.WriteLine("Expected: 0");
            Console.WriteLine("Actual: {0} [PASS] \n", servInvoice.MaterialCost);

            // Property Get ProvincialSalesTaxCharged  = (this.PartsCost + this.MaterialCost) * this.ProvincialSalesTaxRate
            Console.WriteLine("TEST: Testing Gets property ProvincialSalesTaxCharged\n");
            Console.WriteLine("TEST: CALCULATION: (PartsCost + MaterialCost) * ProvincialSalesTaxRate = (0 + 0) * 0.3");
            Console.WriteLine("Expected: 0");
            Console.WriteLine("Actual: {0} [PASS] \n", servInvoice.ProvincialSalesTaxCharged);

            // Property Get GoodsAndServicesTaxCharged  = (LabourCost + PartsCost + MaterialCost) * GoodsAndServicesTaxRate
            Console.WriteLine("TEST: Testing Gets property GoodsAndServicesTaxCharged\n");
            Console.WriteLine("TEST: CALCULATION: (LabourCost + PartsCost + MaterialCost) * GoodsAndServicesTaxRate = (0 + 0) * 0.4");
            Console.WriteLine("Expected: 0");
            Console.WriteLine("Actual: {0} [PASS] \n", servInvoice.GoodsAndServicesTaxCharged);

            // Property Get SubTotal   = LabourCost + PartsCost + MaterialCost
            Console.WriteLine("TEST: Testing Gets property SubTotal\n");
            Console.WriteLine("TEST: CALCULATION: LabourCost + PartsCost + MaterialCost  =  0 + 0 + 0");
            Console.WriteLine("Expected: 0");
            Console.WriteLine("Actual: {0} [PASS] \n", servInvoice.SubTotal);

            // Property Get Total   = LabourCost + PartsCost + MaterialCost + ProvincialSalesTaxCharged + GoodsAndServicesTaxCharged
            Console.WriteLine("TEST: Testing Gets property Total\n");
            Console.WriteLine("TEST: CALCULATION: LabourCost + PartsCost + MaterialCost + ProvincialSalesTaxCharged + GoodsAndServicesTaxCharged =  0 + 0 + 0 + 0 + 0");
            Console.WriteLine("Expected: 0");
            Console.WriteLine("Actual: {0} [PASS] \n", servInvoice.Total);

            // Exception of provincialSalesTaxRate . Value < 0
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR provincialSalesTaxRate < 0. Set the value to -0.3M\n");
                new ServiceInvoice(-0.3M, 0.4M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0.\nParameter name: provincialSalesTaxRate");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of provincialSalesTaxRate. Value > 1
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR provincialSalesTaxRate > 1. Set the value to 2M\n");
                new ServiceInvoice(2M, 0.4M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be greater than 1.\nParameter name: provincialSalesTaxRate");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of goodsAndServicesTaxRate  . Value < 0
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR goodsAndServicesTaxRate < 0. Set the value to -0.3M\n");
                new ServiceInvoice(0.3M, -0.4M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0.\nParameter name: goodsAndServicesTaxRate ");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of provincialSalesTaxRate. Value > 1
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR goodsAndServicesTaxRate  > 1. Set the value to 2M\n");
                new ServiceInvoice(0.3M, 2M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be greater than 1.\nParameter name: goodsAndServicesTaxRate");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Methods AddCost(CostType, decimal)

            // Case : Labour
            Console.WriteLine("TEST: Set CostType's the value to Labour \n");
            servInvoice.AddCost(CostType.Labour, 2000M);
            Console.WriteLine("Expected (LabourCost): 2000M");
            Console.WriteLine("Actual: {0} [PASS] \n", servInvoice.LabourCost);

            // Case : Part
            Console.WriteLine("TEST: Set CostType's the value to Part \n");
            servInvoice.AddCost(CostType.Part, 3000M);
            Console.WriteLine("Expected (PartCost): 3000M");
            Console.WriteLine("Actual: {0} [PASS] \n", servInvoice.PartsCost);

            // Case : Material
            Console.WriteLine("TEST: Set CostType's the value to Material \n");
            servInvoice.AddCost(CostType.Material, 4000M);
            Console.WriteLine("Expected (MaterialCost): 4000M");
            Console.WriteLine("Actual: {0} [PASS] \n", servInvoice.MaterialCost);

            // Exception of AddCost. Value of amount <= 0
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of AddCost with amount <= 0. Set the value to 0M\n");
                servInvoice.AddCost(CostType.Material, 0);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0 or equal to 0.\nParameter name: amount");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of AddCost. Value of amount < 0
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of  AddCost with amount <= 0. Set the value to -1000M\n");
                servInvoice.AddCost(CostType.Material, -1000M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0 or equal to 0.\nParameter name: amount");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            CarWashInvoice carServInvoice = new CarWashInvoice(0.3M, 0.4M, 3000M, 4000M);

            // Property Get PackageCost
            Console.WriteLine("TEST: Testing Gets property PackageCost \n");
            Console.WriteLine("Expected: 3000");
            Console.WriteLine("Actual: {0} [PASS] \n", carServInvoice.PackageCost);

            // Property Get FragranceCost
            Console.WriteLine("TEST: Testing Gets property FragranceCost  \n");
            Console.WriteLine("Expected: 4000");
            Console.WriteLine("Actual: {0} [PASS] \n", carServInvoice.FragranceCost);

            // Property Get ProvincialSalesTaxCharged  = (this.FragranceCost) * this.ProvincialSalesTaxRate
            Console.WriteLine("TEST: Testing Gets property ProvincialSalesTaxCharged\n");
            Console.WriteLine("TEST: CALCULATION: (4000) * ProvincialSalesTaxRate = (4000) * 0.3");
            Console.WriteLine("Expected: 1200");
            Console.WriteLine("Actual: {0} [PASS] \n", carServInvoice.ProvincialSalesTaxCharged);

            // Property Get (this.PackageCost + this.FragranceCost) * this.GoodsAndServicesTaxRate
            Console.WriteLine("TEST: Testing Gets property GoodsAndServicesTaxCharged\n");
            Console.WriteLine("TEST: CALCULATION: (PackageCost + FragranceCost) * GoodsAndServicesTaxRate = (3000 + 4000) * 0.4");
            Console.WriteLine("Expected: 2800");
            Console.WriteLine("Actual: {0} [PASS] \n", carServInvoice.GoodsAndServicesTaxCharged);

            // Property Get SubTotal   = PackageCost + FragranceCost
            Console.WriteLine("TEST: Testing Gets property SubTotal\n");
            Console.WriteLine("TEST: CALCULATION: PackageCost + FragranceCost  = 3000 + 4000");
            Console.WriteLine("Expected: 7000");
            Console.WriteLine("Actual: {0} [PASS] \n", carServInvoice.SubTotal);

            // Property Get Total   = SubTotal + ProvincialSalesTaxCharged + GoodsAndServicesTaxCharged
            Console.WriteLine("TEST: Testing Gets property Total\n");
            Console.WriteLine("TEST: CALCULATION: SubTotal + ProvincialSalesTaxCharged + GoodsAndServicesTaxCharged =  7000 + 1200 + 2800");
            Console.WriteLine("Expected: 11000");
            Console.WriteLine("Actual: {0} [PASS] \n", carServInvoice.Total);

            // Exception of Constructor CarWashInvoice

            // Exception of provincialSalesTaxRate . Value < 0
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR provincialSalesTaxRate < 0. Set the value to -0.3M\n");
                new CarWashInvoice(-0.3M, 0.4M, 3000M, 4000M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0.\nParameter name: provincialSalesTaxRate");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of provincialSalesTaxRate. Value > 1
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR provincialSalesTaxRate > 1. Set the value to 2M\n");
                new CarWashInvoice(2M, 0.4M, 3000M, 4000M); ;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be greater than 1.\nParameter name: provincialSalesTaxRate");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of goodsAndServicesTaxRate  . Value < 0
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR goodsAndServicesTaxRate < 0. Set the value to -0.4M\n");
                new CarWashInvoice(0.3M, -0.4M, 3000M, 4000M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0.\nParameter name: goodsAndServicesTaxRate ");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of provincialSalesTaxRate. Value > 1
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR goodsAndServicesTaxRate > 1. Set the value to 2M\n");
                new CarWashInvoice(0.3M, 2M, 3000M, 4000M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be greater than 1.\nParameter name: goodsAndServicesTaxRate");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of packageCost. Value < 0
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR packageCost < 0. Set the value to -3000M\n");
                new CarWashInvoice(0.3M, 0.4M, -3000M, 4000M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0.\nParameter name: packageCost ");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of fragranceCost. Value < 0
            try
            {
                Console.WriteLine("TEST: Testing EXCEPTION of CONSTRUCTOR fragranceCost < 0. Set the value to -4000M\n");
                new CarWashInvoice(0.3M, 0.4M, 3000M, -4000M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0.\nParameter name: fragranceCost ");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            Console.WriteLine("Test: GetPayment(0.0083M,48,2000M) is {0}", Financial.GetPayment(0.0083M, 48, 2000M));

            // Exception of rate . Value < 0
            try
            {
                Console.WriteLine("TEST:  Exception of rate . Value < 0. Set the value to -0.3M\n");
                Financial.GetPayment(-0.3M, 48, 2000M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0.\nParameter name: rate");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            try
            {
                Console.WriteLine("TEST:  Exception of rate . Value > 1. Set the value to 2M\n");
                Financial.GetPayment(2M, 48, 2000M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be greater than 1.\nParameter name: rate");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of numberOfPaymentPeriods  . Value < 0
            try
            {
                Console.WriteLine("TEST: Testing  numberOfPaymentPeriods < 0. Set the value to -48M\n");
                Financial.GetPayment(0.3M, -48, 2000M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0.\nParameter name: numberOfPaymentPeriods ");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of numberOfPaymentPeriods  . Value = 0
            try
            {
                Console.WriteLine("TEST: Testing  numberOfPaymentPeriods = 0. Set the value to 0\n");
                Financial.GetPayment(0.3M, 0, 2000M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0.\nParameter name: numberOfPaymentPeriods ");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of presentValue  . Value < 0
            try
            {
                Console.WriteLine("TEST: Testing  presentValue < 0. Set the value to -2000M\n");
                Financial.GetPayment(0.3M, 48, -2000M);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0.\nParameter name: presentValue");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            // Exception of presentValue . Value = 0
            try
            {
                Console.WriteLine("TEST: Testing  presentValue = 0. Set the value to 0\n");
                Financial.GetPayment(0.3M, 48, 0);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Expected: The value cannot be less than 0.\nParameter name: presentValue ");
                Console.WriteLine("Actual: {0} [PASS] \n", ex.Message);
            }

            Console.ReadKey();
        }
    }
}
