using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Desktop
{
    public class CollectionExample
    {
        public IEnumerable<string> GetIEnumerable()
        {
            var list = new List<string> { "Prakash"};
            list.Add("Pradip");
            list.Add("Suvana");
            list.Add("Sijan");
            return list;
        }
        public ICollection<string> GetICollection()
        {
            var list = new List<string> { "Prakash" };
            list.Add("Suvana");
            list.Add("Sijan");
            return list;
        }
        public List<string> GetList()
        {
            var list = new List<string> { "Prakash" };
            list.Add("Suvana");
            list.Add("sijan");
            return list;
        }
        public Dictionary<int, string> GetDictionary()
        {
            var dictionary = new Dictionary<int, string>();
            dictionary.Add(1,"Comic Book");
            dictionary.Add(2,"Horror");
            dictionary.Add(3,"Science Fiction");
            dictionary.Add(4,"Noble");
            return dictionary;
        }

    }
        
    }
