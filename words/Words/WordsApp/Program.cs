using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv en konsolapp som tar emot en skriven text.

            //Vi vill ha ut följande
            //Antal ord
            //Antal vokaler 
            //Vilket det längsta ordet är

            //Word count.
            //Vowels count.
            //Longest word.


            Console.WriteLine("Skriv en fin och lång mening tack: ");

            char[] vowels = new char[] { 'a', 'i', 'o', 'e', 'u', 'y', 'å', 'ä', 'ö' };


            string myTestString = Console.ReadLine();
            string myLowercaseString = myTestString.ToLower();
            string[] words = myTestString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            




            foreach (var charatcher in myTestString)
            {    
                var normalizedCharachter = char.ToLower(charatcher);

                if (vowels.Contains(normalizedCharachter))
                {

                }
            }
            for (var i = 0; i < myTestString.Length; i++)
            {
                var character = myTestString[i];
            }





        }
    }
}
