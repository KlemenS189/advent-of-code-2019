using System;
using System.IO;
using System.Reflection;

namespace Day1
{
    class Program
    {
        static int fuelSum = 0;
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"input.txt");
            string[] lines = File.ReadAllLines(path);
            // double fuelSum = 0;
            foreach(string mass in lines)
            {
                
                int parsedMass = Int32.Parse(mass);
                calculateFuel(parsedMass);

            }
            Console.WriteLine(fuelSum);
        }

        static void calculateFuel(int mass)
        {
            int fuelNeeded = (int)Math.Floor((double)(mass / 3)) - 2;
            
            if (fuelNeeded > 0)
            {
                fuelSum += fuelNeeded;
                calculateFuel(fuelNeeded);
            }
        }

    }
}
