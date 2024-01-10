using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionPracticeV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isSingle = false;
        public bool isDouble = false;
        public bool isTriple = false;


        DateTime now = DateTime.Now;

        
        private void noBtn_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            noBtn.Text = "lol nice try";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            noBtn.Visible = false;
            
        }

        void singleDigitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            isSingle = true;
            Math math = new Math(this);
             math.ShowDialog();
             
        }

        private void doubleDigitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            isDouble = true;
            Math math = new Math(this);
            math.ShowDialog();
            
        }

        private void tripleDigitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            isTriple = true;
            Math math = new Math(this);
            math.ShowDialog();
            
        }

        private void dontWantMathBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
