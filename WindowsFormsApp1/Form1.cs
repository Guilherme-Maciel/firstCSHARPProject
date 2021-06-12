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
        bool state = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state == true)
            {
                label1.Text = "Hello World!!";
                state = false;
            }
            else
            {
                label1.Text = "Clica de novo pfvr :(";
                state = true;
            }

        }
    }
}
