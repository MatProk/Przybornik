﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.ActiveControl = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Paint paint = new Paint();
            paint.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notepad notepad = new Notepad();
            notepad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }
    }
}
