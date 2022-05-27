using System;

namespace HelloWorld
{
    public class Lesson3
    {
        public static void Varor()
        {
            int antalVaror;
            float pris;
            Console.Write("Mata in antalet av en vara:");
            antalVaror = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in varans pris per styck:");
            pris = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Totalt pris=" + pris * antalVaror);
        }

        public static void VarorRabbatt()
        {
            int antalVaror;
            float pris, rabatt;
            Console.Write("Mata in antalet av en vara:");
            antalVaror = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in varans pris per styck:");
            pris = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Totalt pris=" + pris * antalVaror);
            Console.Write("Ange rabattsats:");
            rabatt = Convert.ToSingle("0,"+Console.ReadLine());
            Console.WriteLine("Totalt pris efter rabatt="+ (pris * antalVaror)*(1-rabatt));
        }

        public static void Medel()
        {
            float svar, res1, res2, res3;
            Console.Write("Mata in resultat1:");
            res1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in resultat2:");
            res2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in resultat3:");
            res3 = Convert.ToInt32(Console.ReadLine());
            svar = (res1 + res2 + res3) / 3;
            Console.WriteLine("Medel resultatet blev=" + svar);
        }

        public static void Val()
        {
            double ja, nej, vetej, total;
            Console.Write("Mata antal ja-röster:");
            ja = Convert.ToSingle(Console.ReadLine());
            Console.Write("Mata antal nej-röster:");
            nej = Convert.ToSingle(Console.ReadLine());
            Console.Write("Mata antal vetej-röster:");
            vetej = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();
            total = ja + nej + vetej;
            Console.WriteLine("Antal röster i procent");
            Console.WriteLine("======================");
            Console.WriteLine("Ja: " + (ja/total)*100 + "%");
            Console.WriteLine("Nej: " + (nej/total)*100 + "%");
            Console.WriteLine("Vet ej: " + (vetej/total)*100 + "%");
        }
        
        public static void ValRound()
        {
            double ja, nej, vetej, total;
            Console.Write("Mata antal ja-röster:");
            ja = Convert.ToSingle(Console.ReadLine());
            Console.Write("Mata antal nej-röster:");
            nej = Convert.ToSingle(Console.ReadLine());
            Console.Write("Mata antal vetej-röster:");
            vetej = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();
            total = ja + nej + vetej;
            Console.WriteLine("Antal röster i procent");
            Console.WriteLine("======================");
            Console.WriteLine("Ja: " + Math.Round((ja/total)*100, 2) + "%");
            Console.WriteLine("Nej: " + Math.Round((nej/total)*100, 2) + "%");
            Console.WriteLine("Vet ej: " + Math.Round((vetej/total)*100, 2) + "%");
        }
    }
}