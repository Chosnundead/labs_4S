using _1;
using System;
class Program
{
    static void Main(string[] args)
    {
        C1 c1 = new C1(2121);
        c1 = new C1();
        System.Console.WriteLine($"{c1.One} {c1.Two} {c1.Three} {c1.fieldOne} {C1.ONE}");

        C2 c2 = new C2();
        c2.metod();
        int test = c2[21];

        C4 c4 = new C4(1, 2);
        try { c4 = new C4(1, 2); }
        catch (Exception ex)
        {

        }
        c4.MYMETHOD();
        ((C3)c4).MYMETHOD();
    }
}
