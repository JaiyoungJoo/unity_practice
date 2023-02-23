using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//메인 함수 파라미터를 받은 데이터를 사용하기
//005_Check.exe Fastcampus C# 을 실행함

namespace _005_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 2)
            {
                Console.WriteLine("지금 듣는 강의는 {0}", args[0]);
                //Console.WriteLine("{0} 좋아요!!", args[1]);
                Console.WriteLine(args[1] + " 좋아요!!");

                Console.ReadKey();
            }     
         
        }
    }
}
