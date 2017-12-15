using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_number_divided_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Double number = random.Next(0, 100);
            Console.WriteLine("The half of " +  number +  " is " + number / 2);
        }
    }
}
