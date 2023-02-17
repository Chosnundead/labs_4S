using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MyClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            
            try
            {
                Calculator calculator = new Calculator();
                if (SexBox.SelectedIndex == -1)
                {
                    throw new Exception();
                }
                else
                {
                    calculator.Sex = (SexEnum)SexBox.SelectedIndex;
                }
                if (WeightBox.Text.Contains(",") || HeightBox.Text.Contains(","))
                {
                    throw new Exception();
                }
                calculator.Weight = Convert.ToDouble(WeightBox.Text);
                calculator.Height = Convert.ToDouble(HeightBox.Text);
                calculator.Age = Convert.ToInt32(AgeBox.Text);
                if(calculator.Age < 0 || calculator.Weight < 0 || calculator.Height < 0)
                {
                    throw new Exception();
                }
                if (AimBox.SelectedIndex == -1)
                {
                    throw new Exception();
                }
                else
                {
                    calculator.Aim = (AimEnum)AimBox.SelectedIndex;
                }
                ResultLabel.Text = calculator.getResultText();
            } catch (Exception ex)
            {
                ResultLabel.Text = "Результат: Неверные входные данные";
            }

        }

      
    }
}
