using System;

namespace uppgift31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?? (svara ändst i antal år)");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder>=16 && ålder<=19)
                Console.WriteLine("du får vara med i tävlingen");
            
            else if (ålder < 16)
            {
                Console.WriteLine("du är inte tillräckligt gammal för att vara med");
            }
            else if (ålder > 19)
            {
                Console.WriteLine("du är för gammal :(");
            }
        }
    }
}
