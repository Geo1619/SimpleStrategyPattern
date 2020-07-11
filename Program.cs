using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitroulias_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product NikeTShirt1 = new TShirt
            {
                Name = "Nike 1",
                Color = Color.INDIGO,
                Fabric = Fabric.POLYESTER,
                Size = Size.L
            };
            //NikeTShirt1.PayBy(new CreditCard());
            //NikeTShirt1.DisplayPurchace();
            //NikeTShirt1.PayBy(new BankTranfer());
            //NikeTShirt1.DisplayPurchace();

            Product AdidasTShirt1 = new TShirt
            {
                Name= "Adidas 1",
                Color = Color.INDIGO,
                Fabric = Fabric.LINEN,
                Size = Size.L
            };
            //AdidasTShirt1.PayBy(new CreditCard());
            //AdidasTShirt1.DisplayPurchace();
            //AdidasTShirt1.PayBy(new Cash());
            //AdidasTShirt1.Fabric = Fabric.SILK;
            //AdidasTShirt1.DisplayPurchace();
            Product tshirt1 = new TShirt { Name = "Adidas 1", Color = Color.RED, Fabric = Fabric.POLYESTER, Size = Size.XL };
            Product tshirt2 = new TShirt { Name = "Adidas 2", Color = Color.BLUE, Fabric = Fabric.WOOL, Size = Size.L };
            Product tshirt3 = new TShirt { Name = "Adidas 3", Color = Color.GREEN, Fabric = Fabric.CASHMERE, Size = Size.S };
            Product tshirt4 = new TShirt { Name = "Adidas 4", Color = Color.VIOLET, Fabric = Fabric.SILK, Size = Size.M };
            Product tshirt5 = new TShirt { Name = "Adidas 5", Color = Color.VIOLET, Fabric = Fabric.LINEN, Size = Size.XXXL };
            Product tshirt6 = new TShirt { Name = "Adidas 6", Color = Color.YELLOW, Fabric = Fabric.RAYON, Size = Size.XS };

            Cashier cashier = new Cashier(new CreditCard());
            cashier.Order = new List<IProduct> { tshirt2, tshirt4, tshirt6, tshirt3 };
            cashier.Receipt();
        }
    }
}
