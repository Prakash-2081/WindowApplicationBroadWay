using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Desktop
{
    internal class OverloadingExample
    {
        public string Name, Address;
        
        
        public void Method()
        { 
            
        }
        public void Method(string Name)
        {
        }
        public void Method(string Name,string Address)
        {
        }

    }
}
