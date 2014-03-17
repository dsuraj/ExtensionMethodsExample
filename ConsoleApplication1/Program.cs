using System;

namespace ExtensionMethodsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            int i = 41;

            Console.WriteLine(str.IsNullOrEmpty());
            Console.WriteLine(i.IsEvenNumber());
            Console.ReadLine();
        }
    }

    public static class MyExtensions
    {
        public static bool IsNullOrEmpty(this string input)
        {
            if (input == null || input == string.Empty)
            {
                return true;
            }
            return false;
        }

        public static bool IsEvenNumber(this int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
