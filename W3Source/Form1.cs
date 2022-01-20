using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3Source
{
    public partial class Form1 : Form
    {

        int number1;
        int number2;
        double sonuc;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetTxtNumber1()
        {
            number1 = Convert.ToInt32(txtNumber1.Text); 
        }

        private void GetTxtNumber2()
        {
            if (txtNumber2.Enabled != false)
                number2 = Int32.Parse(txtNumber2.Text);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(txtNumber1.Text);
            number2 = Convert.ToInt32(txtNumber2.Text);

            if (number1 == number2)
            {
                MessageBox.Show("Values are equal");
            }
            else
            {
                MessageBox.Show("Values aren't equal");
            }
        }

        private void btnHomework2_Click(object sender, EventArgs e)
        {
            GetTxtNumber1();
            GetTxtNumber2();

            sonuc = number1 % 2;
            if(sonuc == 0)
            {
                MessageBox.Show("The even value");
            }
            else
            {
                MessageBox.Show("The odd value");
            }
            

        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            txtNumber2.Enabled = false;
            MessageBox.Show("Input must be single value");
        }

        private void btnHomework3_Click(object sender, EventArgs e)
        {
            

            if (number1 > 0)
            {
                MessageBox.Show("The Value is positive.");
            }else if (number1 < 0)
            {
                MessageBox.Show("The Value is negetive.");
            }
            else if(number1 == 0)
            {
                MessageBox.Show("'0' is neither a positive nor a negative value.  ");
            }else
            {
                MessageBox.Show("Please, Enter a value ");
            }
        }
    }
}
