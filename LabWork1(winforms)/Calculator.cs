using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LabWork1_winforms_
{
    public partial class Calculator : Form, DefaultCalculatorFunctions
    {
        private delegate float Operation(float x, float y);
        private Operation operation;
        private StringBuilder memory = new StringBuilder();

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        bool Check_Args_Operation()
        {
            Regex regex = new Regex(@"[^\d]");
            if(textBox2.Text == null || textBox1.Text == null || textBox1.Text == "" || textBox2.Text == "" ||
                regex.IsMatch(textBox1.Text) || regex.IsMatch(textBox2.Text) || operation == null)
            {
                textBox3.Text = "wrong args or operation";
                throw new Exception();
            }

            return true;
        }

        private void CleanArgInputs()
        {
            textBox1.Text = textBox2.Text = "";
        }

        private void CleanInputs()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }

        private void IntPart(object sender, EventArgs e)
        {
            operation = (float x, float y) => (int)(x / y);
        }

        private void DivisionWithRemainder(object sender, EventArgs e)
        {
            operation = (float x, float y) => x % y;
        }

        public void Multiplication(object sender, EventArgs e)
        {
            operation = (float x, float y) => x * y;
        }

        public void Division(object sender, EventArgs e)
        {
            operation = (float x, float y) => x / y;
        }

        public void Plus(object sender, EventArgs e)
        {
            operation = (float x, float y) => x + y;
        }

        public void Minus(object sender, EventArgs e)
        {
            operation = (float x, float y) => x - y;
        }

        private void Clean(object sender, EventArgs e)
        {
            CleanInputs();
            operation = null;
        }

        private void Remember(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[^\d]");
            if (regex.IsMatch(textBox3.Text))
            {
                CleanInputs();
                textBox3.Text = "wrong value";

                throw new Exception();
            }

            memory.Clear().Append(textBox3.Text);
        }

        private void ShowMemory(object sender, EventArgs e)
        {
            textBox3.Text = memory.ToString();
            CleanArgInputs();
        }

        public void Equal(object sender, EventArgs e)
        {
            if (Check_Args_Operation())
            {
                textBox3.Text = operation(float.Parse(textBox1.Text), float.Parse(textBox2.Text)).ToString();
            }

            CleanArgInputs();
        }

        private void InputArg1(object sender, EventArgs e)
        {
            
        }

        private void InputArg2(object sender, EventArgs e)
        {
            
        }

        private void Input3(object sender, EventArgs e)
        {

        }
    }
}
