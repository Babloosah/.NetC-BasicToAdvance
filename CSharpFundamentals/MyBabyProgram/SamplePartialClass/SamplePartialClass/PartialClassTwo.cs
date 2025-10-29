using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePartialClass
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialethod()
        {
            Console.WriteLine("Partial Method invoked");
        }
    }
}
