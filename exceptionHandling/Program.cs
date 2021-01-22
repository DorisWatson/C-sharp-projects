using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try // put here any code you think might cause a program breaking error
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            //catch (Exception e) // what you want to do if program breaking error happened
            //{
            //    Console.WriteLine(e.Message);
            //} should really be ding
            
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Thanks for playing!"); // code that will always get executed no matter what
            }
            

            Console.ReadLine();
        }
    }
}
