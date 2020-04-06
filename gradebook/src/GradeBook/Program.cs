﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        // method
        // when dotnet runs it looks for "Main"
        static void Main(string[] args)
        {
            // var x = 34.1;
            // var y = 10.3;
            // var result = x + y;
            // Console.WriteLine(result);

            var grades = new List<double>() { 12.7, 14.5, 15.8 };
            grades.Add(56.1);

            // how to loop through array and sum all numbers in array
            var result = 0.0;
            foreach(var number in grades) {
               result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}!");

            if (args.Length > 0) {
            // whats executed when method runs
            Console.WriteLine($"Hello, {args[0]}!");
            } else {
                Console.WriteLine("HELLO!");
            }
        }
    }
}
