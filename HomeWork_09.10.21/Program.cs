using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_09._10._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2. Введите речь Гордона");
            string input = Console.ReadLine().ToUpper();
            input = input.Replace('А', '@');
            input = input.Replace('A', '@');
            string vovels = "EYUOЕЫОЭЯИЮЁУI";
            for (int i = 0; i < input.Length; i++)
            {
                if (vovels.Contains(input[i]))
                {
                    input = input.Replace(input[i], '*');
                }
            }
            Console.WriteLine(input + "!!!");
            Console.ReadKey();
        }
    }
}
