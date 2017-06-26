using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyaku_ni_siyou
{
    class Program
    {
        static void Main(string[] args)
        {
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
