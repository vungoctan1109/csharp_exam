using System;

namespace Exam1
{
    internal class Program
    {
        class Clynder
        {
            public void Process(double radius, double height)
            {
                var baseArea = radius * radius * Math.PI;
                var lateralArea = 2 * Math.PI * radius * height;
                var totalArea = 2 * Math.PI * radius * (height + radius);
                var volume = Math.PI * radius * radius * height;
                Console.WriteLine("Cylinder characteristics");
                Console.WriteLine($"Radius: {radius}, Height: {height}");
                Console.WriteLine($"Base : {baseArea} | Lateral: {lateralArea} | Total: {totalArea} | Volume {volume}");
            }

            public void Result()
            {
                Console.WriteLine("Radius: ");
                var radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Height: ");
                var height = Convert.ToDouble(Console.ReadLine());
                Process(radius,height);
            }
        }
        public static void Main(string[] args)
        {
            var clynder = new Clynder();
            clynder.Result();

        }
    }
}