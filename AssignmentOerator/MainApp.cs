using System;

namespace AssignmentOerator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 4.10 할당연산자
            // 오른쪽 피연산자를 왼쪽 피연산자에 할당
            int a;
            a = 100;
            Console.WriteLine($"a = 100 : {a}");
            a += 90; // a = a+90 ;
            Console.WriteLine($"a += 100 : {a}");
            a -= 80; // a = a-80 ;
            Console.WriteLine($"a -= 100 : {a}");
            a *= 70; // a = a*70 ;
            Console.WriteLine($"a *= 100 : {a}");
            a /= 60; // a = a/60 ;
            Console.WriteLine($"a /= 100 : {a}");
            a %= 50; // a = a%50
            Console.WriteLine($"a %= 100 : {a}");
            a &= 40; // & : 논리곱(AND) // 이후 연산결과가 어케 나오는건지 1도 모르겠다
            Console.WriteLine($"a &= 100 : {a}");
            a |= 30; // | : 논리합(OR)
            Console.WriteLine($"a |= 100 : {a}");
            a ^= 20; // ^ : 배타적논리합(XOR)
            Console.WriteLine($"a ^= 100 : {a}");
            a <<= 10; // a = a<<10 ; 시프트 할당 연산자
            Console.WriteLine($"a <<= 100 : {a}");
            a >>= 1;
            Console.WriteLine($"a >>= 100 : {a}");
        }
    }
}
