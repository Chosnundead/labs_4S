using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    enum SexEnum
    {
        Male = 0, Female = 1
    }
    enum AimEnum
    {
        Zero = 0, One = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6
    }
    internal class Calculator
    {
        public int Age { set; get; }
        public double Weight { set; get; }
        public double Height { set; get; }
        public SexEnum Sex { set; get; }
        public AimEnum Aim { set; get; }
        private double[] AimArray = { 1.2, 1.375, 1.475, 1.55, 1.65, 1.725, 1.9};
        public string getResultText()
        {
            string result = "Результат: ";

            double calories = 0;
            if (Sex == SexEnum.Male)
            {
                calories = (10 * Weight + 6.25 * Height - 5 * Age + 5) * AimArray[(int)Aim];
            } else if (Sex == SexEnum.Female)
            {
                calories = (10 * Weight + 6.25 * Height - 5 * Age - 161) * AimArray[(int)Aim];
            }

            result += calories.ToString() + " калорий в день";
            return result;
        }
    }
}
