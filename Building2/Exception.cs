using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class BuildingException : Exception
    {
        string myCustomMessage;

        public BuildingException(string message)
        {
            this.myCustomMessage += message;
        }



        public override string ToString()
        {
            return myCustomMessage + base.ToString();
        }
    }
}