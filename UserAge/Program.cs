using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta oma vanus:");

            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2021 - userAge;

            Console.WriteLine("Sinu sünniaasta on " + yearOfBirth);
        }
    }
}
