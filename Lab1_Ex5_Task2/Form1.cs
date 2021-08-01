using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Ex5_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (GraphicsPath myPath = new GraphicsPath())
            {
                myPath.AddLines(new[]
                {
                    new Point(0, Height / 2),
                    new Point(Width / 2, 0),
                    new Point(Width, Height / 2),
                    new Point(Width / 2, Height)
                }) ;
                Region = new Region(myPath);
            }
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
