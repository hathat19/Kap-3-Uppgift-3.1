using System;
namespace Uppgift3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frågar efter ålder
            Console.WriteLine("Hur gammal är du? Svara med ett heltal.");
            int age = int.Parse(Console.ReadLine());

            //Jämför ålder
            if (age < 16)
            {
                Console.WriteLine("Du är för ung för att vara med i tävlingen!");
            }
            else if (age > 19)
            {
                Console.WriteLine("Du är för gammal för att vara med i tävlingen!");
            }
            else
            {
                Console.WriteLine("Du får vara med i tävlingen!");
            }
            Console.ReadKey();

        }
    }
}