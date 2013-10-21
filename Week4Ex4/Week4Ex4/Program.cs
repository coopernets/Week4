using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double width;
            double height;
            double length;
            double volume;
            Console.WriteLine("Enter Height: ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Length: ");
            length = double.Parse(Console.ReadLine());
            volume = VolumeCalc(length, width, height);
            Console.WriteLine("Volume = "+volume.ToString());
            Console.ReadLine();
        }
        static double VolumeCalc(double width,double height, double length)
        {
            double result;
            result = width * height * length;
            return result;
        }
    }
}
