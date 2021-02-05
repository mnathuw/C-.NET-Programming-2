using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mai.Thu.Business;

namespace EventTest
{
    class Program
    {
        static void SalesQuote_VehiclePriceChanged(object sender, EventArgs e)
        {
            Console.WriteLine("My vehicle price changed.");
        }

        static void SalesQuote_TradeInAmount(object sender, EventArgs e)
        {
            Console.WriteLine("My trade in amount changed.");
        }

        static void SalesQuote_AccessoriesChosenChanged(object sender, EventArgs e)
        {
            Console.WriteLine("My Accessories Chosen changed.");
        }

        static void SalesQuote_ExteriorFinishChosenChanged(object sender, EventArgs e)
        {
            Console.WriteLine("My ExteriorFinish Chosen changed.");
        }

        static void SalesQuote_ProvincialSalesTaxChanged(object sender, EventArgs e)
        {
            Console.WriteLine("My Provincial Sales Tax changed.");
        }
        
        static void SalesQuote_GoodsAndServicesTaxChanged(object sender, EventArgs e)
        {
            Console.WriteLine("My Goods and Services Tax changed.");
        }

        static void SalesQuote_PackageCostChanged(object sender, EventArgs e)
        {
            Console.WriteLine("My Package Cost changed.");
        }

        static void SalesQuote_FragranceCostChanged(object sender, EventArgs e)
        {
            Console.WriteLine("My Fragrance Cost changed.");
        }

        static void SalesQuote_CostAdded(object sender, EventArgs e)
        {
            Console.WriteLine("My amount of cost changed.");
        }

        static void Main(string[] args)
        {
            ///Initialize a SalesQuote object
            Console.WriteLine();
            SalesQuote saleQuote = new SalesQuote(0.1M, 0.2M, 0.3M, Accessories.All, ExteriorFinish.Custom);
            saleQuote.VehiclePriceChanged += new EventHandler(SalesQuote_VehiclePriceChanged);
            Console.WriteLine("Old value is {0}", saleQuote.VehicleSalePrice);
            saleQuote.VehicleSalePrice = 0.3M;
            Console.WriteLine("Change from 0.1 to {0} [VehicleSalePrice]", saleQuote.VehicleSalePrice);

            Console.WriteLine();
            saleQuote.TradeInAmountChanged += new EventHandler(SalesQuote_TradeInAmount);
            Console.WriteLine("Old value is {0}", saleQuote.TradeInAmount);
            saleQuote.TradeInAmount = 0.15M;
            Console.WriteLine("Change from 0.2 to {0} [TradeInAmount]", saleQuote.TradeInAmount);

            Console.WriteLine();
            saleQuote.AccessoriesChosenChanged += new EventHandler(SalesQuote_AccessoriesChosenChanged);
            Console.WriteLine("Old value is {0}", saleQuote.AccessoriesChosen);
            saleQuote.AccessoriesChosen = Accessories.ComputerNavigation;
            Console.WriteLine("Change from All to {0} [Accessories]", saleQuote.AccessoriesChosen);

            Console.WriteLine();
            saleQuote.ExteriorFinishChosenChanged += new EventHandler(SalesQuote_ExteriorFinishChosenChanged);
            Console.WriteLine("Old value is {0}", saleQuote.ExteriorFinishChosen);
            saleQuote.ExteriorFinishChosen = ExteriorFinish.None;
            Console.WriteLine("Change from Custom to {0} [ExteriorFinishChosen]", saleQuote.ExteriorFinishChosen);

            ServiceInvoice invoice = new ServiceInvoice(0.1M, 0.3M);
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.1M, 0.2M, 3000M, 4000M);

            Console.WriteLine();
            invoice.AddCost(CostType.Labour, 0.1M);
            Console.WriteLine("Old value is {0} [ProvincialSalesTaxCharged]", invoice.ProvincialSalesTaxCharged);
            Console.WriteLine("Old value is {0} [GoodsAndServicesTaxCharged]", invoice.GoodsAndServicesTaxCharged);
            invoice.CostAdded += new EventHandler(SalesQuote_ProvincialSalesTaxChanged);
            invoice.CostAdded += new EventHandler(SalesQuote_GoodsAndServicesTaxChanged);
            invoice.AddCost(CostType.Labour, 0.4M);
            Console.WriteLine("Change from 0.01 to {0} [ProvincialSalesTaxCharged]", invoice.ProvincialSalesTaxCharged);
            Console.WriteLine("Change from 0.03 to {0} [GoodsAndServicesTaxCharged]", invoice.GoodsAndServicesTaxCharged);


            Console.WriteLine();
            carWashInvoice.PackageCost = 0.3M;
            Console.WriteLine("Old value is {0}", carWashInvoice.PackageCost);
            carWashInvoice.PackageCostChanged += new EventHandler(SalesQuote_PackageCostChanged);
            carWashInvoice.PackageCost = 0.2M;
            Console.WriteLine("Change from 0.3 to {0} [PackageCost]", carWashInvoice.PackageCost);

            Console.WriteLine();
            carWashInvoice.FragranceCost = 0.1M;
            Console.WriteLine("Old value is {0}", carWashInvoice.FragranceCost);
            carWashInvoice.FragranceCostChanged += new EventHandler(SalesQuote_FragranceCostChanged);
            carWashInvoice.FragranceCost = 0.4M;
            Console.WriteLine("Change from 0.1 to {0} [FragranceCost]", carWashInvoice.FragranceCost);

            Console.WriteLine();
            invoice.CostAdded += new EventHandler(SalesQuote_CostAdded);
            Console.WriteLine("Old value is {0}", invoice.LabourCost);
            invoice.AddCost(CostType.Labour, 1.1M);
            /// It's 0.5 because I invoke it above for testing PST and GST
            Console.WriteLine("Change from 0.5 to {0} [Labour]", invoice.LabourCost);

            Console.WriteLine();
            Console.WriteLine("Old value is {0}", invoice.MaterialCost);
            invoice.AddCost(CostType.Material, 1.1M);
            Console.WriteLine("Change from 0 to {0} [Material]", invoice.MaterialCost);

            Console.WriteLine();
            Console.WriteLine("Old value is {0}", invoice.PartCost);
            invoice.AddCost(CostType.Part, 1.1M);
            Console.WriteLine("Change from 0 to {0} [Part]", invoice.PartCost);

            Console.ReadKey();
        }
    }
}
