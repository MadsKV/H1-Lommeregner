﻿using System;

namespace Calculator_mehtods
{
    public static class methodsClass
    {
        public static double Add(double x, double y)
        {
            double number1 = x;
            double number2 = y;
            double answer = number1 + number2;
            return answer;
        }

        public static double Divide(double x, double y)
        {
            double number1 = x;
            double number2 = y;
            double answer = number1 / number2;
            return answer;
        }
        
        public static double Multiply(double x, double y)
        {
            double number1 = x;
            double number2 = y;
            double answer = number1 * number2;
            return answer;
        }

        public static double Minus(double x, double y)
        {
            double number1 = x;
            double number2 = y;
            double answer = number1 - number2;
            return answer;
        }
    }
}
