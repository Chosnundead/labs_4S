using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1
{
    public class C3
    {
        protected int protectedFieldOne = 1;
        public int publicFieldOne = 1;
        private int privateFieldOne = 1;
        public int PropertyOfMine { get; set; }
        public C3(int a, int b)
        {
            System.Console.WriteLine($"konstr C3{a}:{b}");
        }
        public void MYMETHOD()
        {
            System.Console.WriteLine("ewe odin metod");
        }
    }
}