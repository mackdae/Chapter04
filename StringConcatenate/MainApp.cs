using System;

namespace StringConcatenate
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 4.4 문자열 결합 연산자
            int result1 = 123 + 456; // = 579
            Console.WriteLine(result1);
            string result2 = "123" + "456"; // = "123456"
            Console.WriteLine(result2);
            result2 = "Hello" + " " + "World!";
            Console.WriteLine(result2);
        }
    }
}
