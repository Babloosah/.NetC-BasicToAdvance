gstem.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(4, 5, new object[] {6, 7, 8, 9, 10 });

        }
        

        public static void AddNumbers(int firstNumber, int secondNumber, params object[] restONumbers)
        {
            int result = firstNumber + secondNumber;
            if (restONumbers != null)
            {
                foreach (int i in restONumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum  = {0}" , result);
        }
    }
}
