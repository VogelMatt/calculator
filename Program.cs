using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator calculator = new Calculator();
                int answer = calculator.Divide(10, 2);
                Console.WriteLine(answer);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("you cant divide by zero");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            finally
            {
                Console.WriteLine("the 'try catch' is finished");
            }
        }
    }
}
