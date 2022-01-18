using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Learning_Paths.AddingLogic
{
    internal class BranchFlow
    {

        //Branch the flow of code using the switch-case construct in C#

        // SKU = Stock Keeping Unit
        string sku = "01-MN-L";

        string type = "";
        string color = "";
        string size = "";

        public void IdentifyProduct()
        {
        string[] product = sku.Split('-');

            switch (product[0])
            {
                case ("01"):
                    type = "Sweat shirt";
                    break; ;
                case ("02"):
                    type = "T-Shirt";
                    break; ;
                case ("03"):
                    type = "Sweat pants";
                    break; ;
                default:
                    type = "Other";
                    break; ;
            }

            switch (product[1])
            {
                case ("BL"):
                    color = "Black";
                    break; ;
                case ("MN"):
                    color = "Maroon";
                    break; ;
                default:
                    color = "White";
                    break; ;
            }

            switch (product[2])
            {
                case ("S"):
                    size = "Small";
                    break; ;
                case ("M"):
                    size = "Medium";
                    break; ;
                case ("L"):
                    size = "Large";
                    break; ;
                default:
                    size = "One Size Fits All";
                    break; ;
            }

            Console.WriteLine($"Product: {size} {color} {type}");
        }
    }
}
