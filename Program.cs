namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!\nThis application can perform basic operations of +, -, * or /.\nIt only supports two arguments at this time. Please enter your expression (i.e. 11 + 4) followed by Enter:");
            Console.WriteLine("Enter the mathematical expression or write 'exit' if you want to exit the program:");

            Calculator calculator = new Calculator();

            while (true)
            {
                string? input = Console.ReadLine();

                try
                {
                    if (input?.ToLower() == "exit")
                    {
                        break; 
                    }
                    double result = calculator.PerformCalculation(input);
                    Console.WriteLine("Result: " + result);
                    Console.WriteLine("Enter 'exit' to quit or provide the next mathematical expression:");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
