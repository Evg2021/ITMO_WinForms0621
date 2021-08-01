using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Ex4_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (textBox1.TextA != "" && textBox1.TextB != "")
            {
                string item = textBox1.TextA + " (" + textBox1.TextB + ")";
                listBox1.Items.Add(item);
                textBox1.TextA = "";
                textBox1.TextB = "";
            }
            else
            {
                MessageBox.Show("Данные не в ведены!");
            }
        }
    }
}
