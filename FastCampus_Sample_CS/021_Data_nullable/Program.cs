using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name : _021_Data_nullable
//DESC : nullable 데이터형 활용
namespace _021_Data_nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? a = 3.14; // double 이랑 null 이랑 같이 저장 가능
            char? b = 'a';

            int num = 10;
            int? c = num; // c = null 도 가능하다

            bool? isFlag = null; // 원래 bool 에는 true나 false만 넣을 수 있는데 null도 넣음

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
            Console.WriteLine("c: {0}", c);

            Console.WriteLine("isFlag: {0}", isFlag);
            Console.WriteLine("isFlag HasValue: {0}", isFlag.HasValue);

            if (isFlag.HasValue) // 값을 참조하려면 반드시 null인지 체크..
            {
                Console.WriteLine("isFlag HasValue: {0}", isFlag.Value);
            }
        }
    }
}
