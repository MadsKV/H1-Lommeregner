﻿using System;
using System.Collections.Generic;
using Calculator_mehtods;

namespace LommeregnerV2
{
    class Program
    {
       static void Main(string[] args)

        {
            string restart_Calculator = "no";
            List<string> operator_array = new List<string> { "+", "-", "*", "/" };
            double number1;
            double number2;

            do // run the program a first time and then loops it depending of the user input

            {
                Console.WriteLine("What type of calculation do you want to perform? (+, -, *, /)");

                String type_of_calculation = Console.ReadLine();
                // verify if user input is not a valid operator contain in the array

                while (!operator_array.Contains(type_of_calculation))
                {
                    Console.WriteLine("Choose a valid operator!");
                    type_of_calculation = Console.ReadLine();
                }

                Console.WriteLine("Choose the first number");
                string input = Console.ReadLine();
                // verify if user input is an int before parsing
                while (int.TryParse(input, out int n) == false)
                {
                    Console.WriteLine("Try again! this time with an actual number...");
                    input = Console.ReadLine();
                }
                number1 = Int32.Parse(input);
                
                Console.WriteLine("Choose the second number");
                input = Console.ReadLine();
                // verify if user input is an int before parsing
                while (int.TryParse(input, out int n) == false)
                {
                    Console.WriteLine("Try again! this time with an actual number...");
                    input = Console.ReadLine();
                }
                number2 = Int32.Parse(input);

                //could use a switch satement here
                if (type_of_calculation == "+")
                {
                    Console.WriteLine("The answer is " + methodsClass.Add(number1, number2));
                    Console.WriteLine("write 'yes' to restart the calculator");
                    restart_Calculator = Console.ReadLine();
                }

                else if (type_of_calculation == "-")
                {
                    Console.WriteLine("The Answer is " + methodsClass.Substraction(number1, number2));
                    Console.WriteLine("Wrtie 'yes' to restart the calculator");
                    restart_Calculator = Console.ReadLine();
                }

                else if (type_of_calculation == "/")
                {
                    Console.WriteLine("The Answer is " + methodsClass.Divide(number1, number2));
                    Console.WriteLine("Wrtie 'yes' to restart the calculator");
                    restart_Calculator = Console.ReadLine();
                }

                else if (type_of_calculation == "*")
                {
                    Console.WriteLine("The Answer is " + methodsClass.Multiply(number1, number2));
                    Console.WriteLine("Wrtie 'yes' to restart the calculator");
                    restart_Calculator = Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Unknown Error");
                }

            } while (restart_Calculator == "yes");

            System.Environment.Exit(0);

        }
    }
}
