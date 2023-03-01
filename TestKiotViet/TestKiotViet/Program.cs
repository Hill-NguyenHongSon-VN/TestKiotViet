using System;

namespace TestKiotViet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int number = 0;
            string again;
            var unit = new Helper();
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter number");
                Console.WriteLine("1: CocaCola");
                Console.WriteLine("2: TotalArrayMin");
                //Console.WriteLine("3: Exit");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------");

                if (number == 1)
                {
                    Console.WriteLine("You pic 1: Please insert number >0 and number <100000");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number > 0 && number < Math.Pow(10, 5))
                    {
                        var total = unit.CheckCocaCola(number);
                        Console.WriteLine($"Out Put: {total}");
                    }
                    else
                    {
                        Console.WriteLine("Input Error 400: insert number >0 and number <100000");

                    }


                }

                Console.WriteLine("Would you like to check again ?(Enter Y for yes /Enter any other key to exit)");
                again = Console.ReadLine();


            } while (again == "Y"|| again == "y");


        }









    }
}

