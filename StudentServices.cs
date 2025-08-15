using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class StudentServices
    {
        public string[] arr= {};

        public string[] GetAllArr()
        {
            if (arr==null || arr.Length == 0)
            {
                return new string[] { "No data found prakash" };
                
            }
            return arr;
        }

    }
}
