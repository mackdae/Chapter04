﻿using System;

namespace ArithmaticOperators
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 4.2 산술연산자 + - * / %
            int a = 111 + 222;
            Console.WriteLine($"a : {a}");
            int b = a - 100;
            Console.WriteLine($"b : {b}");
            int c = b * 10;
            Console.WriteLine($"c : {c}");
            double d = c / 6.3;
            Console.WriteLine($"d : {d}");
            Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7})");
        }
    }
}
