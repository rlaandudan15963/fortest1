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
        T i;
        T[] j = new T[8];
        public T I
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
            for(int i = 0; i < 8; i++)
            {
                a[i] = 2 ^ i - 3 ^ (i - 4);
            }
            
            for(int i = 0; i < 8; i++)
            {
                b[i] = 10 * i;
            }
            Console.WriteLine("show int or double methi    ");
            Console.Write("enter value : ");
            string enterV = Console.ReadLine();
            if (enterV.IndexOf(".") > -1)
            {
                b.I = double.Parse(enterV);
                for(int i = 0; i < 8; i++)
                {
                    Console.WriteLine(b.I * b[i]);
                }
            } 
            else
            {
                a.I = int.Parse(enterV);
                for(int i =0; i < 8; i++)
                {
                    Console.Write(a.I + 1 + a[i] + "\t");
                }
                Console.WriteLine();
                for(int i = 0; i < 8; i++)
                {
                    Console.Write(a[i] + "\t");
                }
                Console.WriteLine();
                for(int i = 0; i < 8; i++)
                {
                    Console.Write((2 ^ i).ToString() + "\t");
                }
            }
        }
    }
}
