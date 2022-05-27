using System;

namespace HelloWorld
{
    public class Lesson4
    {
        public static void MiniMaxi()
        {
            int mintal, maxtal, tal;
            Console.Write("Skriv in ett mintal i en talserie:");
            mintal = int.Parse(Console.ReadLine());
            Console.Write("Skriv in ett maxtal i en talserie:");
            maxtal = int.Parse(Console.ReadLine());
            Console.Write("Ange ett tal:");
            tal = int.Parse(Console.ReadLine());
            if (maxtal < mintal)
            {
                Console.WriteLine("Fel i inmatningen");
                return;
            }
            if (tal >= mintal && tal <= maxtal)
            {
                Console.WriteLine("Talet ingår i intervallet.");
            }
            else
            {
                Console.WriteLine("Talet ingår inte i intervallet.");
            }
            Console.ReadKey();
        }

        public static void Betyg()
        {
            int aBetyg, bBetyg, cBetyg, dBetyg, eBetyg, resultat;
            Console.Write("Mata in gräns för E:");
            eBetyg = int.Parse(Console.ReadLine());
            Console.Write("Mata in gräns för D:");
            dBetyg = int.Parse(Console.ReadLine());
            Console.Write("Mata in gräns för C:");
            cBetyg = int.Parse(Console.ReadLine());
            Console.Write("Mata in gräns för B:");
            bBetyg = int.Parse(Console.ReadLine());
            Console.Write("Mata in gräns för A:");
            aBetyg = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Mata in resultatet:");
            resultat = int.Parse(Console.ReadLine());
            if (resultat >= aBetyg)
            {
                Console.WriteLine("Det blev ett A!");
            }
            else if (resultat >= bBetyg)
            {
                Console.WriteLine("Det blev ett B!");
            }
            else if (resultat >= cBetyg)
            {
                Console.WriteLine("Det blev ett C!");
            }
            else if (resultat >= dBetyg)
            {
                Console.WriteLine("Det blev ett D!");
            }
            else if (resultat >= eBetyg)
            {
                Console.WriteLine("Det blev ett E!");
            }
            else if (resultat < eBetyg)
            {
                Console.WriteLine("Det blev ett F!");
            }
            else
            {
                Console.WriteLine("Det blev ett fel!");
            }
        }

        public static void Calculator()
        {
            int tal1, tal2;
            char räkneSätt;
            Console.Write("Mata in tal1:");
            tal1 = int.Parse(Console.ReadLine());
            Console.Write("Mata in tal2:");
            tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("+ - * /");
            Console.Write("Mata in räknesätt:");
            räkneSätt = Char.Parse(Console.ReadLine());
            Console.WriteLine("Svaret är:" + tal1 + räkneSätt + tal2);
            //switch (true)
            //{
            //    case (räkneSätt == "+"):
            //        Console.WriteLine();
            //        break;
            //}
        }
    }
}