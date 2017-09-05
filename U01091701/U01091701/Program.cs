using System;
using System.Linq;

namespace U01091701
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift A 
            Console.WriteLine("Uppgift A");
            Console.WriteLine("Skriv in en mening: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("");

            string[] j = sentence.Split(' ');
            Console.WriteLine("Din mening består av orden: ");

            foreach (string word in j)
            {
                int antalTecken = word.Length;
                Console.WriteLine(word + " (" + antalTecken + ")");
            }

            Console.WriteLine("");

            //Uppgift B

            Console.WriteLine("Uppgift B");
            Console.WriteLine("Mata in en mening: ");
            string input = Console.ReadLine();
            Console.WriteLine("");

            string[] words = input.Split(' ');

            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");

            Array.Sort(words, (x, y) => y.Length.CompareTo(x.Length));
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            //Uppgift C

            Console.WriteLine("Uppgift C");
            Console.WriteLine("Skriv in en mening: ");
            string c = Console.ReadLine();

            string[] z = c.Split(' ');
            var distz = z.Distinct();

            foreach (string s in distz)
            {
                Console.WriteLine(s);
               //Console.WriteLine(s.DuplicateCount); //Borde funka kolla också group by c#
            }


            //Uppgift E

            Console.WriteLine("Mata in ord: ");
            string inmatning = Console.ReadLine();

            if (inmatning == "AVSLUTA")
            {
                Console.WriteLine("Du matade in orden: ");

            }

            //Uppgift F

            Random random = new Random();

            int returnValue = random.Next(1, 21);

            Console.WriteLine("Gissa på ett nummer mellan 1-21: ");
            Start:
            int guess = int.Parse(Console.ReadLine());

            if (guess != returnValue)
            {
                Console.WriteLine(guess + " var fel, gissa igen!!");
                goto Start;
            }

            else
            {
                Console.WriteLine("Du gissade rätt!! Det rätta talet var " + returnValue);
            }
        }
    }
}