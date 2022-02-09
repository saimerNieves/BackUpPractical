using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidtermPractical;

namespace BookStoreConsoleApp
{
    class Program
    {
        //Initialized Private Variable
        private static string method;
        private static string outputType;

       

        static void Main()
        {

            string[] args = Environment.GetCommandLineArgs(); //return all command line arguments




            Console.WriteLine("What is the method? Choose  bytitle  -    getall     -   getallbyauthorlastname");
            method = Console.ReadLine();

            // method = args[1].ToLower();

            Console.WriteLine("What is the ouput Type? Choose  csv  -    console     -   ");
            outputType = Console.ReadLine();
            // outputType = args[2].ToLower();

            //Printing this out


                switch (method)
                {
                    case "bytitle":

                        Console.WriteLine("What is the title?   ");
                        string title = Console.ReadLine();

                    //string combinedString = string.Join(",", BookStoreBasicFunctions.GetAllBooksByBookTitle(title));

                    if (outputType.ToLower().Equals("csv"))
                    {
                        OutputHelper.writeToCSV(BookStoreBasicFunctions.GetAllBooksByBookTitle(title));
                        Console.WriteLine($"Books searched by title have been saved to your Computer - Press enter to continue");
                        Console.ReadLine();
                    }
                    else if (outputType.ToLower().Equals("console"))
                    {
                        Console.WriteLine($"Books Being Searched By title: ");
                        OutputHelper.writeToConsole(BookStoreBasicFunctions.GetAllBooksByBookTitle(title));
                    }

                    break; //get out of switch statement

                    case "getall":

                        if (outputType.ToLower().Equals("csv"))
                        {
                            OutputHelper.writeToCSV(BookStoreBasicFunctions.GetAllBooks());
                            Console.WriteLine($"ALL books have been saved to your Computer - Press enter to continue");
                            Console.ReadLine();
                        }
                        else if (outputType.ToLower().Equals("console"))
                        {
                            Console.WriteLine($"Getting All Books: ");
                            OutputHelper.writeToConsole(BookStoreBasicFunctions.GetAllBooks());
                        }

                    
                       break;

                    case "getallbyauthorlastname":

                        Console.WriteLine("What is the author Last Name?   ");
                        string lastName = Console.ReadLine();

                        if (outputType.ToLower().Equals("csv"))
                        {
                            OutputHelper.writeToCSV(BookStoreBasicFunctions.GetAllBooksByAuthorLastName(lastName));
                            Console.WriteLine($"Books Searched by Author Last Name have been saved to your Computer - Press enter to continue");
                            Console.ReadLine();
                        }
                        else if (outputType.ToLower().Equals("console"))
                        {
                            Console.WriteLine($"Books Being Searched By Author Last Name: ");
                            OutputHelper.writeToConsole(BookStoreBasicFunctions.GetAllBooksByAuthorLastName(lastName));
                            

                        }
                    break;

                default: //go to this statement if is none of these
                        Console.WriteLine($"{method} is not a valid method option. ");
                        break;
                }

            }
           

           // Console.ReadLine(); // added this so terminal wouldn't close
        




    }
}
