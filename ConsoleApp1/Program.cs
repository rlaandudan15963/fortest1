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
                return i;
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
                return j[idx];
            }
            set { j[idx] = value; }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            test a = new test();
            

        }
    }
}
