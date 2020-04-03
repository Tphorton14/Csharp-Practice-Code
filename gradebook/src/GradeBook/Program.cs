using System;

namespace GradeBook
{
    class Program
    {
        // method
        // when dotnet runs it looks for "Main"
        static void Main(string[] args)
        {
            if (args.Length > 0) {
            // whats executed when method runs
            Console.WriteLine($"Hello, {args[0]}!");
            } else {
                Console.WriteLine("HELLO!");
            }
        }
    }
}
