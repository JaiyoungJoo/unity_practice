using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name : _022_Data_var
//DESC : var 데이터형 활용
namespace _022_Data_var
{
    // 불가 : 반드시 지역변수만 사용
    // var globalVar = 100;{ } 안에 넣어서 사용할 수 있다.
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 100;
            var b = 3.123456789123456789f;
            var c = 3.123456789123456789m;
            var d = 'H';
            var e = 'i';
            var f = "World!";
            var g = false;

            Console.WriteLine("type: {0}, a: {1}", a.GetType(), a);
            Console.WriteLine("type: {0}, b: {1}", b.GetType(), b);
            Console.WriteLine("type: {0}, c: {1}", c.GetType(), c);
            Console.WriteLine("type: {0}, g: {1}", g.GetType(), g);

            Console.WriteLine("{0}{1} {2}", d, e, f);

            // 불가: 반드시 선언과 동시에 초기화
            // var noinitialVar; 이렇게 쓸 수 없다.
            var num = 0;
            num = 100;

            Console.WriteLine("num:" + num);
        }
    }
}
