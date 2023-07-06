namespace ConsoleCalculator
{
    public class MultiplicationOperation : IBasicOperation
    {
        public double Calculate(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
    }
}