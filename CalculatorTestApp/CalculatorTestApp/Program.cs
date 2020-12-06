using System;

namespace CalculatorTestApp
{
    class Program
    {
        static void PrintDivider() { Console.WriteLine("--------------------------------"); }

		static void GetNumberPair(ref int number1, ref int number2, string label1 = "first number", string label2 = "second number")
        {
			Console.Write($"Enter the {label1}: ");
			number1 = GetValidNumber(label1);

			Console.Write($"Enter the {label2}: ");
			number2 = GetValidNumber(label2);
		} 

		static int GetValidNumber(string label)
        {
			string str;
			bool validNumber;
			int result = 0;

			do
			{
				str = Console.ReadLine();
				validNumber = Int32.TryParse(str, out int newResult);

				if (validNumber)
					result = newResult;
				else
					Console.Write($"Invalid input, Enter the {label}: ");
			} while (!validNumber);

			return result;
		}

        static void Main(string[] args)
        {
            const char ADD_OPERATOR = '+';
            const char SUB_OPERATOR = '-';
            const char MULT_OPERATOR = '*';
            const char DIV_OPERATOR = '/';

            Calculator calculator = new Calculator();
            char operationKey;
            int number1 = 0, number2 = 0;

            PrintDivider();
            Console.WriteLine("CALCULATOR TEST APP");
            PrintDivider();

            do
            {
                Console.WriteLine("+ :      Add");
                Console.WriteLine("- : Subtract");
                Console.WriteLine("* : Multiply");
                Console.WriteLine("/ :   Divide");
                Console.WriteLine("Enter any other key to stop execution");

                Console.Write("Enter Operator Here: ");
                operationKey = Console.ReadKey().KeyChar;
				Console.WriteLine();

				switch (operationKey)
				{
					case ADD_OPERATOR:
						PrintDivider();
						GetNumberPair(ref number1, ref number2, "first addend", "second addend");

						Console.WriteLine($"The Result is: {calculator.Add(number1, number2)}!");
						PrintDivider();
						Console.WriteLine();
						break;
					case SUB_OPERATOR:
						PrintDivider();
						GetNumberPair(ref number1, ref number2, "the minuend", "the subtrahend");

						Console.WriteLine($"The Result is: {calculator.Subtract(number1, number2)}!");
						PrintDivider();
						Console.WriteLine();
						break;
					case MULT_OPERATOR:
						PrintDivider();
						GetNumberPair(ref number1, ref number2, "multiplier", "multiplicand");

						Console.WriteLine($"The Result is: {calculator.Multiply(number1, number2)}!");
						PrintDivider();
						Console.WriteLine();
						break;
					case DIV_OPERATOR:
						PrintDivider();
						GetNumberPair(ref number1, ref number2, "dividend", "divisor");

						Console.WriteLine($"The Result is: {calculator.Divide(number1, number2)}!");
						PrintDivider();
						Console.WriteLine();
						break;
					default:
						Console.WriteLine("Exiting Execution Now...");
						break;
				}
			} while (operationKey == MULT_OPERATOR || operationKey == SUB_OPERATOR || operationKey == ADD_OPERATOR || operationKey == DIV_OPERATOR);
        }
    }
}
