using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Desktop
{
    internal class Parent
    {
        public virtual void Method()
        {
         Console.WriteLine("Parent Method");
            MessageBox.Show("Parent Method","Method",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
    internal class Child:Parent
    {
        public override void Method()
        {
            Console.WriteLine("Child Method");
            MessageBox.Show("Child Method", "Method", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    internal class OverridingExample : Parent
    {
        public override void Method()
        {
            Console.WriteLine("Child 2 Method");
            MessageBox.Show("Child 2 Method", "Method", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
