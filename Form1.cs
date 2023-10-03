using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_Calculator_
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnOne_Click(object sender, EventArgs e)
        {        
            if (txtBox1.Text == "0" && txtBox1.Text != null)

                txtBox1.Text = "1";

            else
                txtBox1.Text = txtBox1.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1.Text != null)
                txtBox1.Text = "2";
            else
                txtBox1.Text = txtBox1.Text + "2";

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1.Text != null)

                txtBox1.Text = "3";
            else
                txtBox1.Text = txtBox1.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1.Text != null)
                txtBox1.Text = "4";
            else
                txtBox1.Text = txtBox1.Text + "4";

        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1.Text != null)
                txtBox1.Text = "5";
            else
                txtBox1.Text = txtBox1.Text + "5";

        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1.Text != null)
                txtBox1.Text = "6";
            else
                txtBox1.Text = txtBox1.Text + "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1.Text != null)
                txtBox1.Text = "7";
            else
                txtBox1.Text = txtBox1.Text + "7";

        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1.Text != null)
                txtBox1.Text = "8";
            else
                txtBox1.Text = txtBox1.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "0" && txtBox1.Text != null)
                txtBox1.Text = "9";
            else
                txtBox1.Text = txtBox1.Text + "9";

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtBox1.Text = txtBox1.Text + "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox1.Text);
            txtBox1.Text = "0";
            Operation = "+";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox1.Text);
            txtBox1.Text = "0";
            Operation = "/";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox1.Text);
            txtBox1.Text = "0";
            Operation = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBox1.Text);
            txtBox1.Text = "0";
            Operation = "*";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(txtBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                txtBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                txtBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                txtBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txtBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    txtBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }  }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox1.Text = "0";
        }
    }
}
