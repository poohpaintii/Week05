using System;
using System.IO;

namespace Lab02
{
    public class switchLearning
    {
        static void Main(string[] args)
        {
            string InputDay;
            Console.Write("Input Day Name (sun, mon, tue, wed, thu, fri, sat) : ");
            InputDay = Console.ReadLine();            
            switch (InputDay)
            {
                case "sun":
                    Console.WriteLine("Sun is Sunday , color is Red");
                    break;
                case "mon":
                    Console.WriteLine("Mon is Monday , color is Yellow");
                    break;
                case "tue":
                    Console.WriteLine("Tue is Tuesday , color is Pink");
                    break;
                case "wed":
                    Console.WriteLine("Wed is Wednesday , color is Green");
                    break;
                case "thu":
                    Console.WriteLine("Thu is Thursday , color is Orange");
                    break;
                case "fri":
                    Console.WriteLine("Fri is Friday , color is Blue");
                    break;
                case "sat":
                    Console.WriteLine("Sat is Saturday , color is Purple");
                    break;
            }
            Console.ReadKey();

        }
    }
}