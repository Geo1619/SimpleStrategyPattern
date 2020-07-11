using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitroulias_Assignment_3
{
    public interface IProduct
    {
        string Name { get; set; }
        Color Color { get; set; }
        Size Size { get; set; }
        Fabric Fabric { get; set; }
        decimal GetPrice();
    }
}
