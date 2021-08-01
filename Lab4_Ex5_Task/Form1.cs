﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Ex5_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinInterval s = new SinInterval();
            FormRange formRange = new FormRange(out s);
            //formRange.Show(this);
            if (formRange.ShowDialog() == DialogResult.OK)
            {
                label2.Text = $"Левая граница: {s.BeginInterval} - Провая граница{s.EndInterval}";
                SinText(s);
            }
        }
        private void SinText(SinInterval s)
        {
            string str = "";

            for (double i = s.BeginInterval; i < s.EndInterval; i += 0.1)
            {
                str += $"x = {i}  y = {Math.Round(Math.Sin(i), 2)};\n";
            }
            richTextBox1.Text = str;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
