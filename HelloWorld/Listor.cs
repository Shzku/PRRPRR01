using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Listor
    {
        public static void flyttalslista()
        {
            List<float> decimalLista = new List<float>();
            float deciTal;
            Console.WriteLine("Skriv decimal tal (,):");
            while (true)
            {
                try
                {
                    deciTal = Convert.ToSingle(Console.ReadLine());
                    if (deciTal == 0)
                    {
                        skrivLista(decimalLista);
                        break;
                    }
                    decimalLista.Add(deciTal);
                }
                catch
                {
                    Console.WriteLine("Fel i inmatning");
                }
            }
        }

        static void skrivLista(List<float> Lista)
        {
            Console.WriteLine("Tal i Listan:");
            for (int i = 0; i < Lista.Count; i++)
            {
                Console.WriteLine(Lista[i]);
            }
        }
    }
}