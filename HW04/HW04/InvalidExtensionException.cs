using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04
{
    public class InvalidExtensionException : Exception
    {
        public InvalidExtensionException(string extension)
        : base(String.Format("Invalid Extension {0}", extension))
        {

        }
    }
}