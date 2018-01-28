using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_read_and_find
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\User\source\repos\Task2-read_and_find\Task2-read_and_find\nums.txt ");
            
            string[] arr = sr.ReadLine().Split(' ');
            List<int> all = new List<int>();
            int x;

            /*foreach(string s in arr)
            {
                Console.Write(s + " ");
            }*/

           foreach (string s in arr)
            {
                x = int.Parse(s);
                all.Add(x);
            }

            Console.WriteLine(all.Max() +" " + all.Min());


            sr.Close();

            Console.ReadKey();
        }
    }
}