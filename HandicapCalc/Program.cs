using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandicapCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your current handicap index");
            double index = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter course slope rating");
            double slope = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter course stroke rating");
            double strokeRating = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter course par");
            double coursePar = Convert.ToDouble(Console.ReadLine());

            double courseHandicap = ((index * slope) / 113) - (strokeRating - coursePar);

            Console.WriteLine($"Your course handicap is {courseHandicap}");
            Console.ReadLine();
        }
    }
}
