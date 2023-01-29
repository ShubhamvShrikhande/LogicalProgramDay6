using System;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int reverse = 0, reminder;
            Console.WriteLine("Enter the Number");
            int number = int.Parse(Console.ReadLine());
            while(number!=0)
            {
                reminder = number % 10;
                reverse = reverse * 10 + reminder;
                number = number / 10;
            }
            Console.WriteLine("Reverse number:" + reverse);
        }
    }
}
