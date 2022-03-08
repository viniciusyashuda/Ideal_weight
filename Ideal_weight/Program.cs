using System;

namespace Ideal_weight
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double height, weight;
            int gender;

            Console.WriteLine("Enter your height:");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number correspondent to your gender: 1 for Male and 2 for Female");
            gender = int.Parse(Console.ReadLine());

            if ((height < 0) & (gender != 1) & (gender != 2))
            {

                Console.WriteLine("The height can not be a negative number and you have to select a valid gender!");

            }
            else
            {

                if (gender == 1)
                {

                    weight = (height * 72.7) - 58;
                    Console.WriteLine("The ideal weight for you is {0}", weight);

                }
                else
                {

                    weight = (height * 62.1) - 44.7;
                    Console.WriteLine("The ideal weight for you is {0}", weight);

                }
            }

            Console.ReadKey();
        }
    }
}
