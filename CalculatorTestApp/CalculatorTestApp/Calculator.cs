namespace CalculatorTestApp
{
    public class Calculator
    {
        public int Add(int addend1, int addend2)
        {
            return addend1 + addend2;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;

        }

        public int Multiply(int muliplier, int multiplicand)
        {
            return muliplier * multiplicand;
        }

        public string Divide(int dividend, int divisor)
        {
            int whole = (dividend / divisor);
            int remainder = dividend - (whole * divisor);

            return $"{whole} R{remainder}";
        }
    }
}
