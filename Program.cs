using System;
using System.Collections.Generic;

namespace 進制轉換
{
    class Program
    {
        static void Main(string[] args)
        {
            int question = 87;

            Console.Write("對照組：");
            Console.WriteLine("\t" + question + " 的二進制為 " + Convert.ToString(question, 2));

            List<int> list = new List<int>();
            Console.Write("實驗組：");
            Console.WriteLine("\t" + question + " 的二進制為 " + change(question, list));

            Console.ReadKey();
        }
        static string change(int question, List<int> list)
        {
            binary(question, list);

            int[] array = list.ToArray();
            Array.Reverse(array);

            string printstr = "";
            foreach (int x in array)
            {
                printstr += x;
            }

            return printstr;
        }
        static void binary(int question, List<int> list)
        {
            if (question / 2 != 0)
            {
                list.Add(question % 2);
                question /= 2;

                binary(question, list);
            }
            else
            {
                list.Add(1);
            }
        }
    }
}
