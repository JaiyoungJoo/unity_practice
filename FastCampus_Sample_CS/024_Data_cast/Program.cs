using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name : _024_Data_cast
//DESC : cast 연산자 ( ) 기초
namespace _024_Data_cast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            double dNum = (double)num;
            // 작은 거를 큰 거에 넣을 때는 그냥 안써도 됨
            // double dNum = num;
            Console.WriteLine("num: {0}, dNum: {1}", num, dNum);

            double dNum2 = 12345678912;
            int num2 = (int)dNum2; // 큰 데이터형을 작은 데이터형으로 변경 시 주의!
            // 큰 거를 작은 거에 넣을 때는 반드시 cast형으로 써야 함.
            // int num2 = dNum2 이러면 에러 난다.
            Console.WriteLine("dNum2: {0}, num2: {1}", dNum2, num2);
            // 데이터 넘어가면 이상한 숫자가 나온다. 
            // 오류라고는 안나오는데 숫자가 제대로 안나옴
        }
    }
}
