using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Ex5_Task2
{
    public partial class Form2start : Form
    {
        Form1 formbase;
        public Form2start()
        {
            formbase = new Form1();
            InitializeComponent();
        }

        private void Form2start_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formbase.Show();
            formbase.Activate();
        }
    }
}
