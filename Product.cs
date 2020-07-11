using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Dimitroulias_Assignment_3
{
    class Product : IProduct
    {
        //private IPayment _payment;

        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }

        public virtual decimal GetPrice()
        {
            return (int)this.Fabric * 4 + (int)this.Size * 2 + (int)this.Color * 1;
        }
        //public void PayBy(IPayment payment)
        //{
        //    _payment = payment;
        //}
        //public void DisplayPurchace() 
        //{
        //    string purchase = (_payment is null) ? 
        //        "You need to select a payment method" : 
        //        string.Format("{0} priced {1} euros was {2}",
        //        this.Name, this.GetPrice(), _payment.Pay());

        //    Console.WriteLine(purchase);
        //} 
    }
}
