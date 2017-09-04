using System;

namespace U01091701
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift A 
            Console.WriteLine("Skriv in en mening: ");
            string mening = Console.ReadLine();
            Console.WriteLine("");

            string[] j = mening.Split(' ');
            Console.WriteLine("Din mening består av orden: ");

            foreach (string ord in j)
            {
                int antalTecken = ord.Length;
                Console.WriteLine(ord + " (" + antalTecken + ")");
            }

            Console.WriteLine("");

            //Uppgift B

            Console.WriteLine("Mata in en mening: ");
            string input = Console.ReadLine();
            Console.WriteLine("");

            string[] words = input.Split(' ');

            foreach (string str in words) Console.Write(str + " ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }


            //Uppgift E

            Console.WriteLine("Mata in ord: ");
            string inmatning = Console.ReadLine();

            if (inmatning == "AVSLUTA")
            {
                Console.WriteLine("Du matade in orden: ");

            }

            /*//Uppgift F

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
        }*/
        }
    }
}