using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number: ");
                string input1 = Console.ReadLine();
                double number1 = int.Parse(input1); // Может вызвать FormatException

                Console.Write("Enter the second number: ");
                string input2 = Console.ReadLine();
                double number2 = int.Parse(input2); // Может вызвать FormatException

                // Проверяем деление на ноль
                if (number2 == 0)
                {
                    throw new DivideByZeroException("Division by zero is not possible.");
                }

                double result = number1 / number2;
                Console.WriteLine($"Result of division {number1} on {number2} equal to {result}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter integers.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error has occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thanks for using the program!");
            }
        }
    }
}
