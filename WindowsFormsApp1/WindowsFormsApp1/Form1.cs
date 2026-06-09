using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double _value1 = 0;
        private double _value2 = 0;
        private Action _current_Action;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            
            _value1 = Convert.ToDouble(textBox1.Text);
            _current_Action = Action.add;
            textBox1.Text = "";
        }

        private void button_Equals_Click(object sender, EventArgs e)
        {
            if (_value1 == 0) return;
            if(_current_Action == Action.add)
            {
                _value2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text =  Convert.ToString(_value1 + _value2);
                _current_Action = Action.none;
            }
            if (_current_Action == Action.substract)
            {
                _value2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(_value1 - _value2);
                _current_Action = Action.none;
            }
            if (_current_Action == Action.divide)
            {
                _value2 = Convert.ToDouble(textBox1.Text);
                _current_Action = Action.none;
                if (_value2 == 0)
                {
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = Convert.ToString(_value1 / _value2);
                }
            }
            if (_current_Action == Action.multiply)
            {
                _value2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(_value1 * _value2);
                _current_Action = Action.none;
            }

        }

        private void button_Sub_Click(object sender, EventArgs e)
        {
            _value1 = Convert.ToDouble(textBox1.Text);
            _current_Action = Action.substract;
            textBox1.Text = "";
        }

        private void button_Div_Click(object sender, EventArgs e)
        {
            _value1 = Convert.ToDouble(textBox1.Text);
            _current_Action = Action.divide;
            textBox1.Text = "";
        }

        private void button_Multi_Click(object sender, EventArgs e)
        {
            _value1 = Convert.ToDouble(textBox1.Text);
            _current_Action = Action.multiply;
            textBox1.Text = "";
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            _value1 = 0;
        }
    }
    
}
public enum Action
{
   none,
   add,
   substract,
   divide,
   multiply
}