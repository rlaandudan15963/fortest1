using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class test<T>
    {
        int i;
        T[] j = new T[10];
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
        public T this[int idx]
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
            test<int> a = new test<int>();
            test<double> b = new test<double>();


        }
    }
}
