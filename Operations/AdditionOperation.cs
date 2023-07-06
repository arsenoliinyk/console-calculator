namespace ConsoleCalculator
{
    public class AdditionOperation : IBasicOperation
    {
        public double Calculate(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
    }
}