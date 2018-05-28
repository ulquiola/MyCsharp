using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 逆置
{
    class Program
    {
        static void Main(string[] args)
        {
            string string2;
            string string1 = Console.ReadLine();
            for(int i=string1.Length-1;i>=0;i--)
            {
                string2 = string1;
                Console.Write(string2[i]);
            }
        }
    }
}
