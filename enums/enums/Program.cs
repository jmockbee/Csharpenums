using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    public enum ShippingMethod
    {
        RegularAirMail  = 1,
        RegisteredAirmail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int) method);


            var methodId = 3;
            Console.WriteLine((ShippingMethod) methodId);

            Console.WriteLine(method.ToString());


        }
    }
}

//Best practices set the number of the enum so that values match the values ofthe data base at all times 