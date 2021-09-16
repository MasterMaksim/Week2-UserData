using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta, palun, oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;
            
            if(userAge >= 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada");
            }
            else
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
