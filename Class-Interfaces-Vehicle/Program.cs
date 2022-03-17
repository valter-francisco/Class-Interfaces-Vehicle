using System;

namespace Class_Interfaces_Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isNumber = false;
            int gasoline = 0;

            Car car = new Car(gasoline);
            while (true)
            {
                do
                {
                    Console.WriteLine("Please fuel the car! (Insert a number)");

                    string input = Console.ReadLine();
                    try
                    {
                        input = input.Trim();
                        gasoline = Convert.ToInt32(input);

                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Please insert a valid input");
                    }
                    if (gasoline > 0)
                    {
                        isNumber = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please insert a valid input");
                    }
                }
                while (isNumber == false);

                car.Drive();
                bool refuelVerification = true;

                do
                {
                    Console.WriteLine("Do you want to refuel? (y/n)");

                    string refuel = Console.ReadLine();
                    refuel.Trim();
                    refuel.ToLower();



                    if (refuel == "y")
                    {
                        refuelVerification = false;
                    }
                    else if (refuel == "n")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please insert a valid input");
                    }
                }
                while (refuelVerification == true);
            }
        }
    }
}
