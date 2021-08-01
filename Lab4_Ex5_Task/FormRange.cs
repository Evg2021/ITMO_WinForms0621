using System;
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
    public partial class FormRange : Form
    {
        SinInterval s1 = new SinInterval();
        public FormRange(out SinInterval s)
        {
            InitializeComponent();
            s = s1;
            buttonS.Enabled = false;
        }

        private void buttonС_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            double a, b;
            if(Double.TryParse(textBoxB.Text,out a) && Double.TryParse(textBoxE.Text,out b))
            {
                s1.BeginInterval = a;
                s1.EndInterval = b;
            }
        }

        private void textBoxE_Validating(object sender, CancelEventArgs e)
        {
            double a, b;
            if((textBoxB.Text != "" || textBoxE.Text != "")
                && (Double.TryParse(textBoxB.Text, out a) 
                && Double.TryParse(textBoxE.Text, out b)))
            {
                s1.BeginInterval = a;
                s1.EndInterval = b;
                buttonS.Enabled = true;
            }
            else
            {
                buttonS.Enabled = false;
            }
        }

        private void textBoxB_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
