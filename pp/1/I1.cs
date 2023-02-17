using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1
{
    public interface I1
    {
        int svoistvo { get; set; }
        void metod();
        event EventHandler Sobitie;
        int this[int index] { get; set; }

    }
}