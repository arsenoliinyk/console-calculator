namespace ConsoleCalculator
{
    public class DivisionOperation : IBasicOperation
    {
        public double Calculate(double operand1, double operand2)
        {
            if (operand2 == 0)
            {
                throw new ArgumentException("Division by zero is not allowed.");
            }

            return operand1 / operand2;
        }
    }
}