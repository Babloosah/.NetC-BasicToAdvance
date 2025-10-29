using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassInCsharp
{
    public partial class PartialCustomer
    {
        public static void Main()
        {
            PartialCustomer partialCustomer = new PartialCustomer();
            partialCustomer.firstName = "Tew";
            partialCustomer.lastName = "Tech";
            Console.WriteLine(partialCustomer.GetFullName());
        }
    }
}
