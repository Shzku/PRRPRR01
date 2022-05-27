using System;

namespace HelloWorld
{
    public class Lesson2
    {
        // Uppgift 1
        public static void Cirkel()
        {
            double radie;
            Console.Write("Mata in cirkelns radie (cm):");
            radie = double.Parse(Console.ReadLine());
            if (radie <= 0)
            {
                Console.WriteLine("Cirkeln exsisterar inte?");
                return;
            }
            Console.Write("Cirkelns area är:"+ System.Math.Pow(radie, 2)*System.Math.PI+"cm"+'\u00b2');
        }
        
        // Uppgift 2
        public static void Månader()
        {
            int månad;
            Console.Write("Mata in månad:");
            månad = Convert.ToInt32(Console.ReadLine());
            switch (månad)
            {
                case 1:
                    Console.WriteLine("Januari");
                    break;
                case 2:
                    Console.WriteLine("Febuari");
                    break;
                case 3:
                    Console.WriteLine("Mars");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("Maj");
                    break;
                case 6:
                    Console.WriteLine("Juni");
                    break;
                case 7:
                    Console.WriteLine("Juli");
                    break;
                case 8:
                    Console.WriteLine("Augusti");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("Oktober");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Det är en felaktig månads nummer");
                    break;
            }
        }

        // Uppgift 3
        static public void EvenOdd()
        {
            int tal;
            Console.Write("Mata in tal:");
            tal = Convert.ToInt32(Console.ReadLine());
            if (tal % 2 == 0)
            {
                Console.WriteLine("Talet är jämnt");
            }
            else
            {
                Console.WriteLine("Talet är udda");
            }
        }
        
        // Extra Uppgift
        static public void MånaderVer2()
        {
            int månad, år;
            Console.Write("Mata in år:");
            år = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in månad:");
            månad = Convert.ToInt32(Console.ReadLine());
            switch (månad)
            {
                case 1:
                    Console.WriteLine("Januari har 31 dagar");
                    break;
                case 2:
                    if (DateTime.IsLeapYear(år))
                    {
                        Console.WriteLine("Febuari har 29 dagar");
                    }
                    else
                    {
                        Console.WriteLine("Febuari har 28 dagar");
                    }

                    break;
                case 3:
                    Console.WriteLine("Mars har 31 dagar");
                    break;
                case 4:
                    Console.WriteLine("April har 30 dagar");
                    break;
                case 5:
                    Console.WriteLine("Maj har 31 dagar");
                    break;
                case 6:
                    Console.WriteLine("Juni har 30 dagar");
                    break;
                case 7:
                    Console.WriteLine("Juli har 31 dagar");
                    break;
                case 8:
                    Console.WriteLine("Augusti har 30 dagar");
                    break;
                case 9:
                    Console.WriteLine("September har 31 dagar");
                    break;
                case 10:
                    Console.WriteLine("Oktober har 30 dagar");
                    break;
                case 11:
                    Console.WriteLine("November har 31 dagar");
                    break;
                case 12:
                    Console.WriteLine("December har 30 dagar");
                    break;
                default:
                    Console.WriteLine("Det är en felaktig månads nummer");
                    break;
            }
        }
    }
}