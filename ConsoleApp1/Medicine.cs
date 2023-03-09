using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Medicine
    {

        public string Category;

        string _name;
        double _salary;


        public string Name
        {
            get => _name; set
            {
                if (value.Length > 3 && char.IsUpper(value[0]))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Ad min 3 Herf olmalidi");
                }
            }
        }
        public double Salary
        {
            get => _salary; set
            {
                if (value > 0)
                {
                    _salary = value;
                }
            }
        }
    }
}
