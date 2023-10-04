using System;

namespace ConsoleApp23
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? Svara j för ja och n för nej");
            string svar = Console.ReadLine();
            

            Console.WriteLine("Hur gammal är du?");
            string svar2 = Console.ReadLine();
            int ålder = int.Parse(svar2);

            if (ålder < 22 && svar == "j") 
            {
                Console.WriteLine("Vi vill gärna anställa dig.");
            }
            else { Console.WriteLine("Vi letar tyvär efter någon annan."); }
            Console.ReadKey();
        }
    }
}