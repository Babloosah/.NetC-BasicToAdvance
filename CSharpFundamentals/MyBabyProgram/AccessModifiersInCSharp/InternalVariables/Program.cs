using System;
using System.Security.Policy;

namespace InternalVariables
{
    public class internalClass
    {
        internal int id = 101;
    }

    public class internalClass01
    {
        public void SamplMethod()
        {
            internalClass IC = new internalClass();
            IC.id = 102;
        }

    }


}

