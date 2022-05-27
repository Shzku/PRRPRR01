using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, Action> programs = new Dictionary<int, Action>();
            LooparArray loopArr = new LooparArray();
            int number;
            programs.Add(1, Math);
            programs.Add(2, Second);
            programs.Add(3, Lesson2.Cirkel);
            programs.Add(4, Lesson2.Månader);
            programs.Add(5, Lesson2.EvenOdd);
            programs.Add(6, Lesson2.MånaderVer2);
            programs.Add(7, Lesson3.Varor);
            programs.Add(8, Lesson3.VarorRabbatt);
            programs.Add(9, Lesson3.Medel);
            programs.Add(10, Lesson3.Val);
            programs.Add(11, Lesson3.ValRound);
            programs.Add(12, Lesson4.MiniMaxi);
            programs.Add(13, Lesson4.Betyg);
            programs.Add(14, Lesson4.Calculator);
            programs.Add(15, loopArr.ovn1);
            programs.Add(16, loopArr.ovn2);
            programs.Add(17, loopArr.ovn3);
            programs.Add(18, Listor.flyttalslista);
            programs.Add(19, PsuedoKod.upp2);
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Total Seconds");
            Console.WriteLine("==================");
            Console.WriteLine("3: Area of circle");
            Console.WriteLine("4: Months");
            Console.WriteLine("5: Even or Odd");
            Console.WriteLine("6: Months ver2");
            Console.WriteLine("==================");
            Console.WriteLine("7: Total Cost");
            Console.WriteLine("8: Total Cost Sale");
            Console.WriteLine("9: Average Answer");
            Console.WriteLine("10: Election");
            Console.WriteLine("11: Round Election");
            Console.WriteLine("==================");
            Console.WriteLine("12: MiniMaxi");
            Console.WriteLine("13: GradeCalc");
            Console.WriteLine("14: Calulator");
            Console.WriteLine("==================");
            Console.WriteLine("15: Asterisk");
            Console.WriteLine("16: Loop number");
            Console.WriteLine("17: Array Search");
            Console.WriteLine("==================");
            Console.WriteLine("18: Decimal List");
            Console.Write("enter number for program to run: ");
            number = Convert.ToInt32(Console.ReadLine());
            programs[number].Invoke();
            Console.ReadKey();
        }

        static void Math()
        {
            int tal1, tal2, tal3, summa;
            Console.Write("Mata in tal1:");  
            tal1 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Mata in tal2:");  
            tal2 = Convert.ToInt32(Console.ReadLine()); 
            summa = tal1 + tal2; 
            Console.WriteLine("Summan av " + tal1 + " och " + tal2 + " är " + summa);
            Console.Write("Mata in tal3:");
            tal3 = Convert.ToInt32(Console.ReadLine());
            summa = summa + tal3;
            Console.WriteLine("Den slutliga summan av de tre talen blir:"+summa);
            Console.ReadKey();
        }

        static void Second()
        {
            int hour, minute, second, total;
            Console.Write("Mata in antal timmar:");
            hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in antal minuter:");
            minute = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in antal sekunder:");
            second = Convert.ToInt32(Console.ReadLine());

            hour = (hour * 60) * 60;
            minute = minute * 60;
            total = hour + minute + second;
            Console.WriteLine("Totalt antal sekunder blir:"+total);
        }

        
    }
}
