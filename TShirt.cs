using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitroulias_Assignment_3
{
    class TShirt : Product
    {
        public override decimal GetPrice()
        {
            return (int)this.Fabric * 3 + (int)this.Size * 1 + (int)this.Color * 4; ;
        }
    }
}
