using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10802013_陳家甄
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //第一題 輸入一個英文句子，將所有的字全部變成大寫以及全部變成小寫。
            Console.Write("請輸入一個英文句子: ");
            string s = Console.ReadLine();
            Console.WriteLine("全部大寫: " + s.ToUpper() + "\n全部小寫: " + s.ToLower() + "\n");
            Console.Read();
        }
    }
}
