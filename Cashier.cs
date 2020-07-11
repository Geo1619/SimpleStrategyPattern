using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitroulias_Assignment_3
{
    class Cashier
    {
        public List<IProduct> Order;
        private IPayment payment;
        public Cashier(IPayment payment)
        {
            this.payment = payment;
        }
        public Cashier() { }
        public void ChangePayMethod(IPayment payment)
        {
            this.payment = payment;
        }
        //business logic
        public void Receipt()
        {
            if(this.Order is null)
                Console.WriteLine("There are no Products in this order");
            else
            {
                string orderStatus = (payment is null) ? "Payment pending" : payment.Pay();
                decimal orderTotal = 0;
                foreach (var product in this.Order)
                {
                    Console.WriteLine("{0,-15} {1,-15}", product.Name, product.GetPrice());
                    orderTotal += product.GetPrice();
                }
                Console.WriteLine("-------------");
                Console.WriteLine("{0,-15} {1,-15}", "Total Pay:", orderTotal);
                Console.WriteLine("-------------");
                Console.WriteLine(orderStatus);
            }
        }

    }
}
