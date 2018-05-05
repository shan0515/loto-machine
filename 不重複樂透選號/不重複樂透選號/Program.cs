using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            // 背景顏色
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // 清除螢幕、延遲
            Console.Clear();
            System.Threading.Thread.Sleep(1000);

            // 顯示
            Console.WriteLine("╔═══════╗");
            Console.WriteLine("║   大樂透機   ║");
            Console.WriteLine("╚═══════╝");

            // 宣告一個名為number的list
            List<int> numbers = new List<int>();

            // 在number裡放入數字
            for (int i = 1; i <= 42; i++)
            {
                numbers.Add(i);
            }

            // 產生亂數
            Random rand = new Random();

            // 循環六次
            for (int i = 0; i < 6; i++)
            {
                // 用亂數物件產生亂數
                int r = rand.Next(1, numbers.Count);

                // 顯示
                Console.WriteLine(numbers[r] + " ");

                // 從list刪除
                numbers.RemoveAt(r);
            }

            Console.ReadLine();
        }
    }
}