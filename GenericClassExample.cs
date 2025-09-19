using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Desktop
{
    public class GenericClassExample
    {
        private readonly string[] _arr;
        public GenericClassExample(int size)
        {
            _arr = new string[size];
        }
        public string GetNum(int index)
        {
            return _arr[index];
        }
        public void SetNum(int index,string val)
        {
            _arr[index] = val;
        }
    }
}
