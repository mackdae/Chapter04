using System;

namespace IncDecOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 4.3 증감 연산자 ++ --
            // [ a = a+1; ] = [ a++; ]
            // ++a 전위 연산자 // a++ 후위 연산자
            int aa = 10;
            Console.WriteLine(aa++);
            Console.WriteLine(++aa);
            Console.WriteLine(aa--);
            Console.WriteLine(--aa);
        }
    }
}
