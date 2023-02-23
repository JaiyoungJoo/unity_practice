using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name : _026_Data_Parse
//DESC : Parse 기초(스트링 -> 정수, 실수 자료형 변환)
namespace _026_Data_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strA = "100"; 
            string strB = "3.12345"; 
            string strC = "3.123456789123456789"; 

            int parseA = int.Parse(strA); // int parseA = 100;
            float parseB = float.Parse(strB); // float parseB = 12345f;
            decimal parseC = decimal.Parse(strC); // decimal parseC = 123456789123456789m;

            Console.WriteLine("int.Parse: {0}", parseA);
            Console.WriteLine("float.Parse: {0}", parseB);
            Console.WriteLine("decimal.Parse: {0}", parseC);
        }
    }
}
