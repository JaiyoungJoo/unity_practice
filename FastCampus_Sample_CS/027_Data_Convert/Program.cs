using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name : _027_Data_Convert
//DESC : Convert 기초, ToString, Parse
namespace _027_Data_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            float b = 3.123456789f;
            decimal c = 3.123456789123456789m;

            string strA = a.ToString();
            string strB = b.ToString();
            string strC = c.ToString();

            Console.WriteLine("a.ToString(): {0}", strA);
            Console.WriteLine("b.ToString(): {0}", strB);
            Console.WriteLine("c.ToString(): {0}", strC);
            Console.WriteLine();

            int parseA = int.Parse(strA);
            float parseB = float.Parse(strB);
            decimal parseC = decimal.Parse(strC);

            Console.WriteLine("int.Parse: {0}", parseA);
            Console.WriteLine("float.Parse: {0}", parseB);
            Console.WriteLine("decimal.Parse: {0}", parseC);
            Console.WriteLine();

            int convertA = Convert.ToInt32(strA);
            float convertB = Convert.ToSingle(strB);
            decimal convertC = Convert.ToDecimal(strC);

            Console.WriteLine("Convert.Toint32(strA): {0}", convertA);
            Console.WriteLine("Convert.ToString(strB): {0}", convertB);
            Console.WriteLine("Convert.ToDecimal(strC): {0}", convertC);

        }
    }
}
