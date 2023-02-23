using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name : _010_Data3
//DESC : 데이터 형태 오류
namespace _010_Data3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 데이터 형식의 오류
            byte sbyteData = 255;
            sbyte sbyteData2 = (sbyte)sbyteData; // 캐스트 연산 오류
            // byte로 되어 있는 데이터를 sbyte로 변환
            int num = sbyteData; // 큰 형식에 넣을 때는 캐스트를 안해도 됨
            // 작은 형식에 넣을 때는 무조건 캐스트 해야함. 안하면 오류남
            int num2 = (int)sbyteData2; // 원래 이렇게 캐스트 해야 한다.

            Console.WriteLine("sbyteData: "+sbyteData);
            Console.WriteLine("sbyteData2: " + sbyteData2);
            Console.WriteLine("sbyte.MaxValue: " + sbyte.MaxValue);
            // 최대 127인데 255를 넣으니까 오류나서 -1로 나온다.
            Console.WriteLine("num: " + num);
            Console.WriteLine("num2: " + num2);


        }
    }
}
