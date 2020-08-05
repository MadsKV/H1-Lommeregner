using System;

namespace Calculator_mehtods
{
    public static class methodsClass
    {
        /// <summary>
        /// Adds the given numbers together
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Add(double x, double y)
        {
            double number1 = x;
            double number2 = y;
            double answer = number1 + number2;
            return answer;
        }
        /// <summary>
        /// Divide the two numbers with each others
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Divide(double x, double y)
        {
            double number1 = x;
            double number2 = y;
            double answer = number1 / number2;
            return answer;
        }
        /// <summary>
        /// Multipls the two numbers with each others
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Multiply(double x, double y)
        {
            double number1 = x;
            double number2 = y;
            double answer = number1 * number2;
            return answer;
        }
        /// <summary>
        /// Subtracts the given numbers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Substraction(double x, double y)
        {
            double number1 = x;
            double number2 = y;
            double answer = number1 - number2;
            return answer;
        }
    }
}
