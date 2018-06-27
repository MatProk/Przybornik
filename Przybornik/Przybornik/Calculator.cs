using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przybornik
{
    public partial class Calculator : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if((result.Text == "0")|| (operation_pressed)) 
            {
                result.Clear();
            }

            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button_ce_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                        break;
            }//end switch
            
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }
    }
}
