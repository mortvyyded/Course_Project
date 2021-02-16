using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Maltsev_Dmitry_group_881
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        double num1, num2, Memory;
        string operation;

        Operations.sin ObjSin = new Operations.sin();
        Operations.cos ObjCos = new Operations.cos();

        // "1" Button
        private void Button_1_Click(object sender, EventArgs e)
        {
            Principal.Text += "1";
        }

        // "2" Button
        private void Button_2_Click(object sender, EventArgs e)
        {
            Principal.Text += "2";
        }

        // "3" Button
        private void Button_3_Click(object sender, EventArgs e)
        {
            Principal.Text += "3";
        }

        // "4" Button
        private void Button_4_Click(object sender, EventArgs e)
        {
            Principal.Text += "4";
        }

        // "5" Button
        private void Button_5_Click(object sender, EventArgs e)
        {
            Principal.Text += "5";
        }

        // "6" Button
        private void Button_6_Click(object sender, EventArgs e)
        {
            Principal.Text += "6";
        }

        // "7" Button
        private void Button_7_Click(object sender, EventArgs e)
        {
            Principal.Text += "7";
        }

        // "8" Button
        private void Button_8_Click(object sender, EventArgs e)
        {
            Principal.Text += "8";
        }

        // "9" Button
        private void Button_9_Click(object sender, EventArgs e)
        {
            Principal.Text += "9";
        }

        // "dot" Button
        private void dot_Button_Click(object sender, EventArgs e)
        {
            Principal.Text += ".";
        }

        // "+" Button
        private void Sum_Button_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = Convert.ToDouble(Principal.Text);
            Principal.Clear();
        }

        // "-" Button
        private void Sust_Button_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = Convert.ToDouble(Principal.Text);
            Principal.Clear();
        }

        // "x" Button
        private void Mult_Button_Click(object sender, EventArgs e)
        {
            operation = "x";
            num1 = Convert.ToDouble(Principal.Text);
            Principal.Clear();
        }

        // "÷" Button
        private void Div_Button_Click(object sender, EventArgs e)
        {
            operation = "÷";
            num1 = Convert.ToDouble(Principal.Text);
            Principal.Clear();
        }

        // "√" Button
        private void SqurRoot_Button_Click(object sender, EventArgs e)
        {
            operation = "√";
            num1 = Convert.ToDouble(Principal.Text);

            if (num1 >= 0)
            {
                Operations.SquR ObjSqu = new Operations.SquR();
                double SquR = ObjSqu.Square(num1);
                Principal.Text = SquR.ToString();
            }

            else
            {
                Principal.Text = "Ошибка введения";
            }
        }

        // "=" Button
        private void Equals_Button_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(Principal.Text);

            switch(operation)
            {

                case "+":
                    Operations.SumOp Objsum = new Operations.SumOp();
                    double Sum = Objsum.Sum(num1, num2);
                    Principal.Text = Sum.ToString();
                    break;

                case "-":
                    Operations.SustOp Objsust = new Operations.SustOp();
                    double Sustraction = Objsust.Sust(num1, num2);
                    Principal.Text = Sustraction.ToString();
                    break;

                case "x":
                    Operations.MultOp Objmult = new Operations.MultOp();
                    double Multiplication = Objmult.Mult(num1, num2);
                    Principal.Text = Multiplication.ToString();
                    break;

                case "÷":

                    if (num2 == 0)
                    {
                        Principal.Text = "Математическая ошибка";
                    }

                    else
                    {
                        Operations.DivOp ObjDiv = new Operations.DivOp();
                        double Division = ObjDiv.Div(num1, num2);
                        Principal.Text = Division.ToString();
                    }
                    break;
            }
        }

        // "-/+" Button
        private void NegPos_Button_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Principal.Text);
            num1 *= -1;
            Principal.Text = num1.ToString();
        }

        // "CE" Button
        private void CE_Button_Click(object sender, EventArgs e)
        {
            Principal.Text = string.Empty;
        }

        // "M-" Button
        private void MSust_Button_Click(object sender, EventArgs e)
        {
            Memory = Memory - Convert.ToDouble(Principal.Text);
        }

        // "M+" Button
        private void MPlus_Button_Click(object sender, EventArgs e)
        {
            Memory = Memory + Convert.ToDouble(Principal.Text);
        }

        // "MS" Button
        private void MS_Button_Click(object sender, EventArgs e)
        {
            Memory = Convert.ToDouble(Principal.Text);
        }

        // "MR" Button
        private void MR_Button_Click(object sender, EventArgs e)
        {
            Principal.Text = Memory.ToString();
        }

        // "MC" Button
        private void MC_Button_Click(object sender, EventArgs e)
        {
            Memory = 0;
        }

        // "%" Button
        private void Percentage_Button_Click(object sender, EventArgs e)
        {
            operation = "%";
            num1 = Convert.ToDouble(Principal.Text);

            Operations.Percentage ObjPerct = new Operations.Percentage();
            double Percentage = ObjPerct.Percent(num1);
            Principal.Text = Percentage.ToString();
        }

        // "π" Button
        private void pi_Button_Click(object sender, EventArgs e)
        {
            operation = "π";
            Principal.Text = Principal.Text + "3.141592654";
        }

        // "x³" Button
        private void xCubed_Button_Click(object sender, EventArgs e)
        {
            operation = "x³";
            num1 = Convert.ToDouble(Principal.Text);

            Operations.xCubed ObjCubed = new Operations.xCubed();
            double xCub = ObjCubed.xCub(num1);
            Principal.Text = xCub.ToString();
        }

        // "x²" Button
        private void xSquared_Button_Click(object sender, EventArgs e)
        {
            operation = "x²";
            num1 = Convert.ToDouble(Principal.Text);

            Operations.xSqurd ObjSqurd = new Operations.xSqurd();
            double xSqur = ObjSqurd.xSqr(num1);
            Principal.Text = xSqur.ToString();
        }

        // "x⁻¹" Button
        private void xRaisedNeg1_Button_Click(object sender, EventArgs e)
        {
            operation = "x⁻¹";
            num1 = Convert.ToDouble(Principal.Text);

            Operations.xRNeg1 ObjxRNeg1 = new Operations.xRNeg1();
            double xRNeg1 = ObjxRNeg1.xNeg1(num1);
            Principal.Text = xRNeg1.ToString();
        }

        // "tan" Button
        private void tan_Button_Click(object sender, EventArgs e)
        {
            operation = "tan";
            num1 = Convert.ToDouble(Principal.Text);

            double Tan = ObjSin.Sin(num1) / ObjCos.Cos(num1);
            Principal.Text = Tan.ToString();
        }

        // "sin" Button
        private void sin_Button_Click(object sender, EventArgs e)
        {
            operation = "sin";
            num1 = Convert.ToDouble(Principal.Text);

            double Sin = ObjSin.Sin(num1);
            Principal.Text = Sin.ToString();
        }

        // "cos" Button
        private void cos_Button_Click(object sender, EventArgs e)
        {
            operation = "cos";
            num1 = Convert.ToDouble(Principal.Text);

            double Cos = ObjCos.Cos(num1);
            Principal.Text = Cos.ToString();
        }

        // "cot" Button
        private void cot_Button_Click(object sender, EventArgs e)
        {
            operation = "sec";
            num1 = Convert.ToDouble(Principal.Text);

            double Cot = ObjCos.Cos(num1) / ObjSin.Sin(num1);
            Principal.Text = Cot.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        // "DEL" Button
        private void C_Button_Click(object sender, EventArgs e)
        {

            if (Principal.Text.Length > 1)
            {
                Principal.Text = Principal.Text.Remove(Principal.Text.Length - 1, 1);
            }

            else
            {
                Principal.Clear();
            }
        }

        // "0" Button
        private void Button_0_Click(object sender, EventArgs e)
        {
            Principal.Text = Principal.Text + "0";
        }
    }
}