using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            string s = Console.ReadLine();
            Console.Write("Введите двузначное число: ");
            string a = Console.ReadLine();
            int i = 0, j = 1;
            while (i < s.Length && j < s.Length)
            {
                bool v = s[j] == a;
                bool v1 = s[i] == a;
                if (v1 || v)
                {
                    Console.WriteLine("Число содержит цифру", a);
                }
                else
                {
                    Console.WriteLine("Число не содержит цифру", a);
                }
                break;
            }
            Console.ReadKey();

        }
    }
}
