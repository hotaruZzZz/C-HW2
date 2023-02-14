using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //第二題 使用Random隨機產生3個1~10之中的數字，並求其總合及平均。
            Random r = new Random();
            int n1 = r.Next(1, 11);
            int n2 = r.Next(1, 11);
            int n3 = r.Next(1, 11);
            double sum = (double)(n1 + n2 + n3);
            double average = sum / 3;
            Console.WriteLine($"{n1}和{n2}和{n3}的總和為{sum}, 平均為{average}\n");

            Console.Read();
        }
    }
}
