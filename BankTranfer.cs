using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitroulias_Assignment_3
{
    class BankTranfer : IPayment
    {
        public string Pay()
        {
            return "Paid by Bank Transfer";
        }
    }
}
