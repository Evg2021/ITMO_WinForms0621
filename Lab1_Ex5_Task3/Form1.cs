﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Ex5_Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                listBox1.Items.Insert(0, textBox1.Text);
                textBox1.Text = "";
        
        }

    }
}
