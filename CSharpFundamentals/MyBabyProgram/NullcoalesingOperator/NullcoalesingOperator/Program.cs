using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NullcoalesingOperator
{
    internal class Program
    {
        static void Main( )
        {
            int? TicketOnSale = null;
            int AvailableTicket;
            if (TicketOnSale == null)
            {
                AvailableTicket = 0;
            }
            else
            {

                //AvailableTicket = TicketOnSale
                /*
                  Above line of code will thro an error as we are seting a non nullable int type to nullable int.
                  CS0266 Cannot implicitly convert type 'int?' to 'int'.
                  The same can be fixed by using explict typecasting or by use value prpoerties as shown below.
                */
                //AvailableTicket = TicketOnSale.Value;
                AvailableTicket = (int)TicketOnSale;
            }

            Console.WriteLine("Available Ticket is : {0}", AvailableTicket);


            /*
                We do not need to necessarily write so many lines of code to perform that operations.
                Null coalescing operator simply our coding lines.
            */

            int AvailableTicktes =  TicketOnSale ?? 0;
            Console.WriteLine("Available Ticket is : {0}", AvailableTicktes);
        }
    }
}
