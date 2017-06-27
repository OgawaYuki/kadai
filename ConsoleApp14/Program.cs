using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyaku_ni_siyou//打った文を逆にして吐き出してくれる、無意味なプログラムです。
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("打ち込まれた文を逆さまにします。");
            Console.WriteLine("終了したい場合は、「end」と打ち込んでください。");
            Console.ResetColor();
            while (true)
            {
                string uttayatu = Console.ReadLine();
                int mozikazu = 0;
                string dasuyatu = "";
                int u_kazu = uttayatu.Length;

                while (mozikazu != u_kazu)
                {
                    char gyaku = uttayatu[mozikazu];
                    dasuyatu = gyaku + dasuyatu;
                    mozikazu = mozikazu + 1;
                }
                Console.WriteLine(dasuyatu);
                
                if (uttayatu == "end") 
                {
                    break;//aaaaaa
                }
            }

        }
    }
}
