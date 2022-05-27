using System;

namespace HelloWorld
{
    public class LooparArray
    {
        // Övning 1
        public void ovn1()
        {
            // Skapar två variabler
            string ast = "*";   // String för asterisk
            int nLines;         // Håller antalet linjer av asterisker som ska skrivas

            // Tar in ett tal för nLines variabeln
            Console.Write("Hur många rader ska skrivas? ");
            nLines = Convert.ToInt32(Console.ReadLine()); 
            
            // Loopar tills i är lika med talet som användaren gav
            for (int i = 1; i < nLines+1; i++)
            {
                Console.WriteLine(i + ": " + ast); // Skriver ut i plus asterisk strängen
                ast = ast + "*";                   // Lägger till ett asterisk på strängen
            }
        }

        // Övning 2
        public void ovn2()
        {
            for (int i = 1; i < 8; i++)      // Loopar sju gånger
            {                                
                int x = i;                   // x håller i värdet för senare operation. Ställs om varje loop
                for (int j = 0; j < i; j++)  // Loopar så många gånger som värdet i
                {
                    Console.Write(x + " ");  // Skriver ut x
                    x = x + i;               // Lägger till x + i för att öka på talet som skrivs ut
                }
                Console.WriteLine();         // Line break
            }
        }

        // Övning 3
        public void ovn3()
        {
            int[] tal = new int[10];     // Array med plats för tio värden
            int sökTal;                  // Håller värdet som användaren vill söka
            int totalHit = 0;            // Håller hur många träff hittas i arrayn

            // Frågar efter inmatningen av max tio tal
            Console.WriteLine("Mata in max 10 tal");
            Console.WriteLine("Mata in blank för att avsluta inmatningen");
            for (int i = 0; i < tal.Length; i++)   // Loopar igenom arrayn
            {
                Console.Write("tal" + i + " ");    // Skriver ut vart i arrayn datan kommer in
                string input = Console.ReadLine(); // input skrivs till det som det användaren gav
                if (input == "") break;            // Kollar om användaren vill avsluta med blank data och bryter loopen för att fortsätta
                tal[i] = Convert.ToInt32(input);   // Lägger talet in i arrayn
            }

            Console.Write("Vilket tal vill du söka efter: "); // Frågar användaren för talet det vill söka för
            sökTal = Convert.ToInt32(Console.ReadLine());     // Lägger till inmatningen till sökTal
            foreach (int i in tal)  // Loopar igenom arrayn
            {                       
                if (sökTal == i)    // kollar om talet i arrayn är lika med den som användaren angav
                {                   
                    totalHit++;     // Ökar det totala träffen med 1
                }
            }

            if (totalHit > 0) // Om åtminstonde en tal hittades så skriver den ut totalen
            {
                Console.WriteLine("Talet " + sökTal + " finns i listan och förekommer " + totalHit + " gånger");
            }
            else              // Om inga tal hittades så svara programmet så här
            {
                Console.WriteLine("Talet hittades inte");
            }
        }
    }
}