using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotwMenuExample
{
    public class StringHolder
    {
        public string Output { get; private set; }

        public void Change(string newString)
        {
            Output = newString;
        }
    }
}
