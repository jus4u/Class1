using System;

namespace Class1
{
    class Program
    {
        static void Main1(string[] args)
        {

            int[] numbers = new int[5] { -2, 0, -16, 15, 5 };

            int minValue = 0;
            foreach (var n in numbers)
            {
                if (n < minValue)
                    minValue = n;

            }

            int maxValue= minValue;
            foreach (var n in numbers)
            {
                if( n>maxValue)
                maxValue = n;
                
            }
            Console.WriteLine("Minimum Value is:"+minValue);
            Console.WriteLine("Maximum Value is:"+maxValue);
            Console.ReadKey();
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter S1");
        //    var S1= Console.ReadLine();
        //    Console.WriteLine("Enter S2");
        //    var S2 = Console.ReadLine();
        //    var lengthOfhalfStringS1 = S1.Length / 2;
        //    var displayHalfStringS1 = S1.Substring(0, lengthOfhalfStringS1);
        //    int S1length = (S1.Length)-1;
        //    //Console.WriteLine(S1.Substring(2,3));
        //    var secondHalfOfStringS1 = S1.Substring(lengthOfhalfStringS1, lengthOfhalfStringS1);
        //    var lengthOfS2 = S2.Length;
        //    Console.WriteLine(displayHalfStringS1 + lengthOfS2 + secondHalfOfStringS1);
        //    Console.ReadKey();
        //}
    }
}
