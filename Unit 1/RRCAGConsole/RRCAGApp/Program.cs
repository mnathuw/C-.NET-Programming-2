using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;

namespace RRCAGApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///
            /// </summary>
            SalesQuote sale1 = new SalesQuote(5000, 2000, 3000, Accessories.All, ExteriorFinish.Pearlized);

            ///<summary>
            /// Testing method GetVehicleSalesPrice().
            /// </summary>
            Console.WriteLine("Testing method GetVehicleSalesPrice()");
            Console.WriteLine();
            Console.WriteLine("Test 1");
            Console.WriteLine("Expected: 5000.00");
            Console.WriteLine("Actual: {0:0.00}", sale1.GetVehicleSalePrice());
            Console.WriteLine();

            ///<summary>
            /// Testing method SetVehicleSalesPrice().
            /// </summary>            
            Console.WriteLine("Testing method SetVehicleSalesPrice(decimal)");
            Console.WriteLine();
            Console.WriteLine("Test 1");
            Console.WriteLine("Expected: 4000.00");
            sale1.SetVehicleSalePrice(4000);
            Console.WriteLine("Actual: {0:0.00}", sale1.GetVehicleSalePrice());
            Console.WriteLine();

            ///<summary>
            /// Testing method GetTradeInAmount().
            /// </summary>
            Console.WriteLine("Testing method GetTradeInAmount()");
            Console.WriteLine();
            Console.WriteLine("Test 1");
            Console.WriteLine("Expected: 2000.00");
            Console.WriteLine("Actual: {0:0.00}", sale1.GetTradeInAmount());
            Console.WriteLine();

            ///<summary>
            /// Testing method SetTradeInAmount().
            /// </summary>
            Console.WriteLine("Testing method SetTradeInAmount(decimal)");
            Console.WriteLine();
            Console.WriteLine("Test 1");
            Console.WriteLine("Expected: 1400.00");
            sale1.SetTradeInAmount(1400);
            Console.WriteLine("Actual: {0:0.00}", sale1.GetTradeInAmount());
            Console.WriteLine();

            ///<summary>
            /// Testing method GetAccessoriesChosen().
            /// </summary>
            Console.WriteLine("Testing method GetAccessoriesChosen()");
            Console.WriteLine();
            Console.WriteLine("Test 1");
            Console.WriteLine("Expected: All");
            Console.WriteLine("Actual: {0}", sale1.GetAccessoriesChosen());
            Console.WriteLine();

            ///<summary>
            /// Testing method SetAccessoriesChosen(Accessories)().
            /// </summary>
            Console.WriteLine("Testing method SetAccessoriesChosen(Accessories)");
            Console.WriteLine();
            Console.WriteLine("Test 1");
            Console.WriteLine("Expected: LeatherInterior");
            sale1.SetAccessoriesChosen(Accessories.LeatherInterior);
            Console.WriteLine("Actual: {0}", sale1.GetAccessoriesChosen());
            Console.WriteLine();

            ///<summary>
            /// Testing method GetExteriorFinishChosen().
            /// </summary>
            Console.WriteLine("Testing method GetExteriorFinishChosen()");
            Console.WriteLine();
            Console.WriteLine("Test 1");
            Console.WriteLine("Expected: Pearlized");
            Console.WriteLine("Actual: {0}", sale1.GetExteriorFinishChosen());
            Console.WriteLine();

            ///<summary>
            /// SetExteriorFinishChosen(ExteriorFinish).
            /// </summary>
            Console.WriteLine("Testing method SetExteriorFinishChosen(ExteriorFinish)");
            Console.WriteLine();
            Console.WriteLine("Test 1");
            Console.WriteLine("Expected: Custom");
            sale1.SetExteriorFinishChosen(ExteriorFinish.Custom);
            Console.WriteLine("Actual: {0}", sale1.GetExteriorFinishChosen());
            Console.WriteLine();

            ///<summary>
            /// Testing all outcomes of GetAccessoryCost().
            /// </summary>
            /// 
            /// Case 1: StereoSystem
            sale1.SetAccessoriesChosen(Accessories.StereoSystem);
            Console.WriteLine("Testing method GetAccessoryCost() of StereoSystem: ");
            Console.WriteLine("Expected: 505.05");
            Console.WriteLine("Actual: {0:0.00}", sale1.GetAccessoryCost());

            ///Case 2: LeatherInterior
            sale1.SetAccessoriesChosen(Accessories.LeatherInterior);
            Console.WriteLine("Testing method GetAccessoryCost() of LeatherInterior: ");
            Console.WriteLine("Expected: 1010.10");
            Console.WriteLine("Actual: {0:0.00}", sale1.GetAccessoryCost());

            ///Case 3: ComputerNavigation
            sale1.SetAccessoriesChosen(Accessories.ComputerNavigation);
            Console.WriteLine("Testing method GetAccessoryCost() of ComputerNavigation: ");
            Console.WriteLine("Expected: 1515.15");
            Console.WriteLine("Actual: {0:0.00}", sale1.GetAccessoryCost());

            ///Case 4: StereoAndNavigation
            sale1.SetAccessoriesChosen(Accessories.StereoAndNavigation);
            Console.WriteLine("Testing method GetAccessoryCost() of StereoAndNavigation: ");
            Console.WriteLine("Expected: 2020.20");
            Console.WriteLine("Actual: {0:0.00}", sale1.GetAccessoryCost());

            ///Case 5: LeatherAndNavigation
            sale1.SetAccessoriesChosen(Accessories.LeatherAndNavigation);
            Console.WriteLine("Testing method GetAccessoryCost() of LeatherAndNavigation: ");
            Console.WriteLine("Expected: 2525.25");
            Console.WriteLine("Actual: {0:0.00}", sale1.GetAccessoryCost());

            ///Case 6: None
            sale1.SetAccessoriesChosen(Accessories.None);
            Console.WriteLine("Testing method GetAccessoryCost() of None: ");
            Console.WriteLine("Expected: 0.00");
            Console.WriteLine("Actual: {0:0.00}", sale1.GetAccessoryCost());
            Console.WriteLine();

            ///Case 7: All
            sale1.SetAccessoriesChosen(Accessories.All);
            Console.WriteLine("Testing method GetAccessoryCost() of All: ");
            Console.WriteLine("Expected: 3030.30");
            Console.WriteLine("Actual: {0:0.00}", sale1.GetAccessoryCost());
            Console.WriteLine();

            ///Case 4: StereoAndLeather
            sale1.SetAccessoriesChosen(Accessories.StereoAndLeather);
            Console.WriteLine("Testing method GetAccessoryCost() of StereoAndLeather: ");
            Console.WriteLine("Expected: 1515.15");
            Console.WriteLine("Actual: {0:0.00}", sale1.GetAccessoryCost());

            ///<summary>
            /// Testing all outcomes of GetExteriorFinishCost().
            /// </summary>
            /// Case 1: Standard
            sale1.SetExteriorFinishChosen(ExteriorFinish.Standard);
            Console.WriteLine("Testing method GetExteriorFinishCost() of Standard: ");
            Console.WriteLine("Expected: 202.02");
            Console.WriteLine("Actual: {0:0.00}", sale1.GetExteriorFinishCost());

            /// Case 2: Pearlized
            sale1.SetExteriorFinishChosen(ExteriorFinish.Pearlized);
            Console.WriteLine("Testing method GetExteriorFinishCost() of Pearlized: ");
            Console.WriteLine("Expected: 404.04");
            Console.WriteLine("Actual: {0:0.00}", sale1.GetExteriorFinishCost());

            ///Case 3: Custom
            sale1.SetExteriorFinishChosen(ExteriorFinish.Custom);
            Console.WriteLine("Testing method GetExteriorFinishCost() of Custom: ");
            Console.WriteLine("Expected: 606.06");
            Console.WriteLine("Actual: {0:0.00}", sale1.GetExteriorFinishCost());

            ///Case 4: None
            sale1.SetExteriorFinishChosen(ExteriorFinish.None);
            Console.WriteLine("Testing method GetExteriorFinishCost() of None: ");
            Console.WriteLine("Expected: 0.00");
            Console.WriteLine("Actual: {0:0.00}", sale1.GetExteriorFinishCost());
            Console.WriteLine();

            ///<summary>
            /// Testing GetSubTotal() method.
            /// </summary>
            Console.WriteLine("Testing method GetSubTotal()");
            Console.WriteLine("Actual {0:0.00}", sale1.GetSubTotal());
            Console.WriteLine();

            ///<summary>
            /// Testing method GetSalesTax() method.
            /// </summary>
            Console.WriteLine("Testing method GetSalesTax()");
            Console.WriteLine("Actual {0:0.00}", sale1.GetSalesTax());
            Console.WriteLine();

            ///<summary>
            /// Testing method GetTotal() method.
            /// </summary>
            Console.WriteLine("Testing method GetTotal()");
            Console.WriteLine("Actual {0:0.00}", sale1.GetTotal());
            Console.WriteLine();

            ///<summary>
            /// Testing method GetAmountDue() method.
            /// </summary>
            Console.WriteLine("Testing method GetAmountDue()");
            Console.WriteLine("Actual {0:0.00}", sale1.GetAmountDue());
            Console.WriteLine();

            ///<summary>
            /// Testing ToString() method.
            /// </summary>
            Console.WriteLine("Testing method ToString(): \n" + sale1);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
