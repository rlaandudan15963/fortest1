using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class test
    {
        int i;
        int[] j = new int[10];
        public int I
        {
            get
            {
                return (i * 2) + 1;
            }
            set
            {
                i = value;
            }
        }
        public int this[int idx]
        {
            get
            {
                return (j[idx] * 3) - 2;
            }
            set { j[idx] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            test a = new test();
            a.I = 4;
            Console.WriteLine(a.I);
            for (int i = 0; i < a.I; i++)
            {
                a[i] = i * 2 - 3;
                Console.WriteLine(a[i]);
            }
        }
    }
}
