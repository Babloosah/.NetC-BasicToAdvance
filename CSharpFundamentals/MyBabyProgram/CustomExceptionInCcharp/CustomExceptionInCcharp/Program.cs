using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionInCcharp
{
    public  class CustomException
    {
        static void Main( )
        {
            throw new UserAlreadyLoggedInException("User is logged in - no duplicate login allowed");
        }
    }

    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base()
        { 
        }
        public UserAlreadyLoggedInException(string message) : base(message)
        {
        }

        public UserAlreadyLoggedInException(string message, Exception innerException)
        {
        }
    }
}
