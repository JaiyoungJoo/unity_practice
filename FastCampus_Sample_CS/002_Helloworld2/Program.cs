using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*------------------------------
 * Name : _002_HelloWorld2
 * DESC : 메인 함수의 파라미터 보기
 -------------------------------*/
namespace _002_Helloworld2
{
    internal class Program
    {
        static void Main(string[] args) // args에 입력을 받는다.
        {
            if(args.Length > 0)
            {
                Console.WriteLine("HelloWorld:   " + args[0]);
            }
            else
            {
                Console.WriteLine("HelloWorld: args.Length = 0");
            }

            Console.ReadKey(); // 키값을 입력 받는 것
        }
    }
}
