using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //第三題 使用DateTime，輸入兩個日期的年月日，並計算這兩個日期之間相差幾天。
            Console.Write("請輸入第一個日期(ex: 2022/1/1): ");
            string d1 = Console.ReadLine();
            DateTime start = Convert.ToDateTime(d1);
            Console.Write("請輸入第二個日期(ex: 2022/1/1): ");
            string d2 = Console.ReadLine();
            DateTime end = Convert.ToDateTime(d2);
            Console.WriteLine("相差" + Math.Abs((start - end).Days) + "天");

            Console.Read();
        }
    }
}
