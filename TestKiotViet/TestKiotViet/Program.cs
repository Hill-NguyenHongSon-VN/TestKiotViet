using System;

namespace TestKiotViet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int numberPic = 0;
            string again;
            var unit = new Helper();
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter number");
                Console.WriteLine("1: CocaCola");
                //Console.WriteLine("2: TotalArrayMin");
                //Console.WriteLine("3: Exit");
                numberPic = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------");

                switch (numberPic)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("You pic 1: Please insert number >0 and number <100000");
                            var number = int.MinValue;

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
                        catch (Exception ex)
                        {

                            Console.WriteLine($"Select 1: {ex.Message}");

                        }

                        break;
                    //case 2:
                    //    try
                    //    {
                    //        Console.WriteLine("You pic 2: Please insert an array of numbers separated by a space.");

                    //        var arrLst = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                    //        if (arrLst.Length>0)
                    //        {
                    //            var total = unit.DynamicProgramingArray(arrLst);
                    //            if (total >= 0)
                    //            {
                    //                Console.WriteLine($"Out Put: {total}");

                    //            }
                    //            else
                    //            {
                    //                Console.WriteLine($"Not found total input > 0 or =0");

                    //            }
                    //        }
                    //        else
                    //        {
                    //            Console.WriteLine("Input Error 400: insert number >0 and number <100000");

                    //        }

                    //    }
                    //    catch (Exception ex)
                    //    {

                    //        Console.WriteLine($"Select 2: {ex.Message}");
                    //    }
                        
                    //    break;
                    default:
                        break;
                }


                Console.WriteLine("Would you like to check again ?(Enter Y for yes /Enter any other key to exit)");
                again = Console.ReadLine();


            } while (again == "Y" || again == "y");


        }









    }
}

