namespace ConsoleCalculator
{
    public class CalculateOperation
    {
        public static IBasicOperation Calculate(string input)
        {

            IBasicOperation operation;

            if (input.Contains("+"))
            {
                operation = new AdditionOperation();
            }
            else if (input.Contains("-"))
            {
                operation = new SubtractionOperation();
            }
            else if (input.Contains("*"))
            {
                operation = new MultiplicationOperation();
            }
            else if (input.Contains("/"))
            {
                operation = new DivisionOperation();
            }
            else
            {
                throw new ArgumentException("Incorrect operation. Valid operations: +, -, *, /");
            }

            return operation;

        }
    }
}