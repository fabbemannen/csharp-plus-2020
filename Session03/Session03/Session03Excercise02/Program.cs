using System;

namespace Session03Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ange ett antal siffror, separerat med mellanslag.");
                var input = Console.ReadLine();
                if (input != "")
                {

                    var inputArray = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var inputTotal = 0;
                    var inputLength = inputArray.Length;

                    foreach (var number in inputArray)
                    {
                        Console.Write("Värdet är " + number);
                        if (Int32.TryParse(number, out var numberParse))
                        {
                            inputTotal += Convert.ToInt32(numberParse);
                        }
                        else
                        {
                            //Error exception, wrong format
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" ERROR: INTEGERS ONLY");
                            Console.ResetColor();
                            //Fix average (without removing the entry)
                            inputLength--;
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Total: " + inputTotal + " Average: " + Math.Round(inputTotal / (double)inputLength, 3));
                    Console.WriteLine();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
