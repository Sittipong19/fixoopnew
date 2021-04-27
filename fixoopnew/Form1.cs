using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fixoopnew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            mainMenu1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenu1.BringToFront();
            mainMenu1.Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            page11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            page21.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            page31.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
