using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1
{
    public class C1
    {
        public const int ONE = 1;
        private const int TWO = 2;
        protected const int THREE = 3;

        public int fieldOne;
        private int fieldTwo;
        protected int fieldThree;

        public int One { get; set; } = 1;
        public int Two { get; set; } = 2;
        public int Three { get; set; } = 3;

        public C1()
        {
            System.Console.WriteLine("Konstruktor rabotaet!");
        }
        public C1(int number)
        {

        }
        public C1(C1 c1)
        {
            One = c1.One;
            System.Console.WriteLine("Kopiryushii konstryktor rabotaet!");
        }
        public void _One()
        {
            System.Console.WriteLine("One");
        }
        protected void _Two()
        {
            System.Console.WriteLine("Two");
        }
        private void _Three()
        {
            System.Console.WriteLine("Three");
        }
    }
}