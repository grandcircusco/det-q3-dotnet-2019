using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int x = 15, y = 10;

            result = (x <= y) && (x > 10);
            Console.WriteLine("AND Operator: {0}", result);

            result = (x >= y) || (x < 5);
            Console.WriteLine("OR Operator: " + result);

            result = !result;
            Console.WriteLine($"NOT Operator: {result}");
        }
    }
}
