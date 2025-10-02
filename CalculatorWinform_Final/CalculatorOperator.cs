using System;

namespace CalculatorWinform
{
    public class CalculatorOperator
    {
        public static decimal Divide(decimal value1, decimal value2)
        {
            if (string.Format("{0}", value2) == "0")
            {
                throw new DivideByZeroException("0으로 나눌 수 없습니다");
            }
            return value1 / value2;
        }

        public static decimal Multiply(decimal value1, decimal value2)
        {
            return value1 * value2;
        }

        public static decimal Substract(decimal value1, decimal value2)
        {
            return value1 - value2;
        }
        public static decimal Plus(decimal value1, decimal value2)
        {
            return value1 + value2;
        }

        public static decimal ConvertStringDecimal (string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }
            else
            {
                return decimal.Parse(value);
            }
        }
    }
}
