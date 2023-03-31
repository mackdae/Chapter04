using System;

namespace ConditionalOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 4.7 조건연산자
            // 조건식 ? 참일때의값 : 거짓일때의값
            string result = (10 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);
        }
    }
}
