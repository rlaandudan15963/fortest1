﻿using System;
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
                a[i] = 2 ^ i - 2 ^ (i - 1);
            }
            for(int i = 0; i < 8; i++)
            {

            }
            Console.Write("enter value : ");
            string enterV = Console.ReadLine();
            if (enterV.Equals("."))
            {
                b.I = double.Parse(enterV);

            }
            else
            {
                a.I = int.Parse(enterV);
            }
        }
    }
}
