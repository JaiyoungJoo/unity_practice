using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
//Name : _025_Data_ToString
//DESC : ToString 기초
namespace _025_Data_ToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            float b = 3.12345f;
            decimal c = 3.123456789123456789m;

            string strA = a.ToString(); // "100"
            string strB = b.ToString(); // "3.12345"
            string strC = c.ToString(); // "3.123456789123456789"

            Console.WriteLine("a.ToString(): {0}", strA);
            Console.WriteLine("b.ToString(): {0}", strB);
            Console.WriteLine("c.ToString(): {0}", strC);
        }
    }
}
