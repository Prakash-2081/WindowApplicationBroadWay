using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Desktop
{
    public class StudentInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
    public class FuncActionDelegateAndLinq
    {

        public FuncActionDelegateAndLinq()
        {
            Method1();
            Method3();
            //Method2(null);

        }

        List<StudentInfo> studentInfos = new List<StudentInfo>();

        public void Method1()
        {
            studentInfos.Add(new StudentInfo { Id=00,Name = null, Age = 24, Address = "Kathmandu" });
            studentInfos.Add(new StudentInfo { Id=2,Name = "Prakash", Age = 23, Address = "Bhaktapur" });
            studentInfos.Add(new StudentInfo { Id=3,Name = "Suvana", Age = 20, Address = "Okhaldhunga" });
            studentInfos.Add(new StudentInfo { Id=4,Name = "Pradip", Age = 24, Address = "Lalitpur" });

            

        }
        public void Method2(string? search)
        {
            //var result = studentInfos.Where(s => s.Name == "Prakash").FirstOrDefault();
            //Func<string> func = () => "Lalitpur";
            if (String.IsNullOrWhiteSpace(search))
            {
                return;
            }

            var result = studentInfos
                        .Where(s =>s.Name!=null && s.Name.Contains(search))
                        .Select(s => new { s.Address })
                        .FirstOrDefault();

            var result1 = studentInfos
                        .Where(s => s.Name?.ToLower() == search?.ToLower())
                        .ToList();

            var result2 = studentInfos
                        .Where(s => string.Equals(s.Name,search, StringComparison.OrdinalIgnoreCase))
                        .ToList();

            bool result3 = studentInfos
                        .Select(s => s.Name.StartsWith("P"))
                        .FirstOrDefault();

            bool result4 = studentInfos.Select(s => s.Name == "Prakash").FirstOrDefault();


            var result5 = studentInfos
                        .Where(s => s.Name.Equals(search, StringComparison.OrdinalIgnoreCase))
                        .ToList();

            //var listofresult = $"Name: {result.Address}";
            foreach (var listofresult2 in result2)
            {
                Console.WriteLine($"Name: {listofresult2.Name}");
            }
        }

        public void Method3()
        {
            var result=studentInfos
                .Where(s=>s.Name=="Prakash")
                .FirstOrDefault();

            var result1 = studentInfos
                .Select(s=> s.Name?.Length)
                .ToList();

            var result2 = studentInfos
                .Where(s => s.Name != null)
                .Select(s => s.Name.Length)
                .ToList();

            MessageBox.Show($"Length is {result1}");

        }
    }
}
