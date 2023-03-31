using System;

namespace LogicalOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 4.6 논리 연산자  &&논리곱AND  ||논리합OR  !부정NOT
            Console.WriteLine("Testing && ..."); // ~이고 ~이다
            Console.WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}"); // 둘 다 맞을 때만 true
            // $: 중괄호 내용은 데이터처리
            Console.WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");
            Console.WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");
            Console.WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");

            Console.WriteLine("\nTesting || ..."); // ~이거나 ~이다
            // \n: 개행문자(줄바꿈)
            Console.WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");
            Console.WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");
            Console.WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}"); // 둘 다 틀릴 때만 false
            Console.WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");

            Console.WriteLine("\nTesting || ...");
            Console.WriteLine($"!True : {!true}"); // 트루의 부정은 false
            Console.WriteLine($"!False : {!false}"); // 폴스의 부정은 true
        }
    }
}
