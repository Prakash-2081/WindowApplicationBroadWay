using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class GenericClassExample<T>
    {
        public T Num;
        
        public T GetNum()
        {
            return Num;
        }
        public void SetNum(T Num)
        {
            this.Num=Num;
        }
    }
}
