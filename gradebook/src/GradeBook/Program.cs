using System;

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

            var numbers = new[] { 12.7, 14.5, 15.8 };

            // how to loop through array and sum all numbers in array
            var result = 0.0;
            foreach(var number in numbers) {
               result += number;
            }
            Console.WriteLine(result);

            if (args.Length > 0) {
            // whats executed when method runs
            Console.WriteLine($"Hello, {args[0]}!");
            } else {
                Console.WriteLine("HELLO!");
            }
        }
    }
}
