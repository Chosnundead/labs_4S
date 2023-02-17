using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1
{
    public class C4 : C3, I1
    {
        public void metod()
        {
            System.Console.WriteLine("Metod");
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
        public C4(int a, int b) : base(a, b)
        {
            System.Console.WriteLine($"{a} and {b}");
        }
        public void c4Method()
        {
            System.Console.WriteLine($"C4 METHOD");
        }
        public void MYMETHOD()
        {
            System.Console.WriteLine("ewe odin metod#2");
        }
        public int a;
        protected int b;
        private int c;
    }
}