using System.Linq.Expressions;

namespace ConsoleCalculator
{
    class Calculator
    {
        public double PerformCalculation(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("Invalid syntax.");
            }


            return EvaluateExpression(input);

        }

        private double EvaluateExpression(string input)
        {
            input = input.Replace(" ", ""); // Remove any spaces

            string[] operands = input.Split('+', '-', '*', '/');
            if (operands.Length != 2)
            {
                throw new ArgumentException("Incorrect operation. You must specify two operands and operation between them.");
            }

            if (!double.TryParse(operands[0], out double operand1) || !double.TryParse(operands[1], out double operand2))
            {
                throw new ArgumentException("Invalid operands. Operands must be valid integers.");
            }


            IBasicOperation? operation;

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

            return operation.Calculate(operand1, operand2);
        }

    }
}