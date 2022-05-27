using System;

namespace HelloWorld
{
    public class PsuedoKod
    {
        public static void upp2()
        {
            int sid1, sid2;
            Console.WriteLine("Mata in sida 1: ");
            sid1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mata in sida 2: ");
            sid2 = Convert.ToInt32(Console.ReadLine());
            if (sid1 > 0 && sid2 > 0)
            {
                Console.WriteLine("Totala arean:" + sid1*sid2);
            }
            else
            {
                Console.WriteLine("Något Gick fel");
            }
        }
    }
}