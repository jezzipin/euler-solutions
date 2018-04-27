﻿namespace ProjectEuler.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EvenFibonacciNumbers
    {
        public EvenFibonacciNumbers()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Question 2:");
            Console.WriteLine("Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:");
            Console.WriteLine("[1, 2, 3, 5, 8, 13, 21, 34, 55, 89]");
            Console.WriteLine("By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.");

            var fibonacciNumbers = new List<double>();
            double previousTerm = 0;
            double currentTerm = 1;
            double term = 0;
            do
            {
                term = previousTerm + currentTerm;

                if (term % 2 == 0)
                {
                    fibonacciNumbers.Add(term);
                }

                previousTerm = currentTerm;
                currentTerm = term;

            } while (term <= 4000000);

            var result = fibonacciNumbers.Distinct().Sum();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(result);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
