using System;

namespace RelationalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int x = 10, y = 20;

            result = (x == y);
            Console.WriteLine($"Equal to Operator: {result}");

            result = (x > y);
            Console.WriteLine($"Greater than Operator: {result}");

            result = (x <= y);
            Console.WriteLine("Less than or equal to Operator: {0}", result);

            result = (x != y);
            Console.WriteLine("Not Equal to Operator: " + result);
        }
    }
}
