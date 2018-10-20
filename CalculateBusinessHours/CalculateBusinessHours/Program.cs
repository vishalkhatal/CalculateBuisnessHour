using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace CalculateBusinessHours
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculation(new List<DateTime>(), new OpenHours("08:00;16:00"));
            Console.WriteLine("Next deadline after an hour is");
            Console.WriteLine(calc.add(DateTime.Now, 60));
            Console.Read();
        }
    }
}
