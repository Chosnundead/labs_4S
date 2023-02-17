using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1;

namespace _1
{
    public class C2 : I1
    {
        public const int ONE = 1;
        private const int TWO = 2;
        protected const int THREE = 3;

        public int fieldOne = 1;
        private int fieldTwo = 2;
        protected int fieldThree = 3;

        public int One { get; set; } = 1;
        public int Two { get; set; } = 2;
        public int Three { get; set; } = 3;

        public C2()
        {
            System.Console.WriteLine("Konstruktor rabotaet!");
        }
        public C2(int number)
        {

        }
        public C2(C2 c1)
        {
            One = c1.One;
            System.Console.WriteLine("Kopiryushii konstryktor rabotaet!");
        }
        public void metod()
        {
            System.Console.WriteLine("Metod ot C2");
        }

        public int svoistvo { get; set; }
        public event EventHandler Sobitie;
        public int this[int index]
        {
            get
            {
                System.Console.WriteLine(index);
                return 1;
            }
            set { }
        }
    }
}