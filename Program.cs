using System;
using System.Collections.Generic;

namespace 進制轉換
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0987;

            Console.Write("對照組：");
            Console.WriteLine("\t" + answer + " 的二進制為 " + Convert.ToString(answer,2));

            List<int> list = new List<int>();
            Console.Write("實驗組：");
            Console.WriteLine("\t" + answer + " 的二進制為 " + change(answer,list));

            Console.ReadKey();
        }

        static string change(int answer, List<int> list)
        {
            binary(answer, list);

            int[] array = list.ToArray();
            Array.Reverse(array);

            string printstr = "";
            foreach (int x in array)
            {
                printstr += x;
            }

            return printstr;
        }
        static void binary(int answer, List<int> list)
        {
            if (answer / 2 != 0)
            {
                list.Add(answer % 2);
                answer /= 2;

                binary(answer, list);
            }
            else
            {
                list.Add(1);
            }
        }
    }
}
