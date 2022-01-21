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
        string name;
        int name1;
        int total;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetTxtNumber1()
        {
            number1 = Convert.ToInt32(txtNumber1.Text); 
        }

        private void GetTxtNumber3()
        {
            number2 = Convert.ToInt32(txtNumber1.Text);
        }

        private void GetTxtNumber2()
        {
            if (txtNumber2.Enabled != false)
                number2 = Int32.Parse(txtNumber2.Text);
        }
        private void GetTxtName()
        {
            if (txtName.Enabled != false)
                name = txtName.Text;

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
            txtName.Enabled = false;
            txtName.Enabled = false;
            MessageBox.Show("Input must be single value");

        }

        private void btnHomework3_Click(object sender, EventArgs e)
        {
            GetTxtNumber1();
            GetTxtNumber2();

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

        
        private void Form1_Load(object sender, EventArgs e)
        {
            ForLoop forLoop = new ForLoop();

            forLoop.value1 = 50;
            forLoop.returnSumOfEvenNumbers();

            if (forLoop.value2 != null)
            {
                lblResultOfClone.Text = forLoop.value2.ToString();
            }
            
        }
        

        private void btnHomework4_Click(object sender, EventArgs e)
        {
            GetTxtNumber1();
            GetTxtNumber2();

            if (txtNumber1.MaxLength != 4)
            {
                MessageBox.Show("Please, Enter 4 decimal");
               
            }else if(txtNumber1.MaxLength == 4)
            {
                if (number1 % 4 == 0)
                {
                    MessageBox.Show("Entered value is a leap year");
                }
                else
                {
                    MessageBox.Show("Entered value is not a leap year");
                }
                
            }

        }

        private void btnHomework5_Click(object sender, EventArgs e)
        {
            GetTxtNumber1();
            GetTxtNumber2();

            if(number1 < 10)
            {
                MessageBox.Show("Age of the candidate is not suitable");
            }else if (number1 >= 10)
            {
                MessageBox.Show("Age of candidate is suitable");
            }

        }

        private void btnHomework6_Click(object sender, EventArgs e)
        {
            GetTxtNumber1();
            GetTxtNumber2();

            if(number1 > 0)
            {
                MessageBox.Show("Value is bigger than 0");
            }else if(number1 == 0)
            {
                MessageBox.Show("Value is equal zero");
            }else if (number1 < 0)
            {
                MessageBox.Show("Value is less than 0");
            }
        }

        private void btnHomework7_Click(object sender, EventArgs e)
        {
            GetTxtNumber1();
            GetTxtNumber3();
            MessageBox.Show("Question :8 ");

            if (number1 > number2)
            {
                MessageBox.Show("Number1 is bigger than Number2");

            }else if (number1 < number2)
            {
                MessageBox.Show("Number1 is less than Number2");

            }else if (number1 == number2)
                    {
                MessageBox.Show("Number1 is equal Number2");
            }
        }

        private void btnHomework8_Click(object sender, EventArgs e)
        {
            GetTxtNumber1();
            GetTxtNumber3();

           if (number2 < 55 && number2 < 55)
            {
                MessageBox.Show("Bütlere kaldın. Geçmiş olsun");
            }
            else if (number1 >= 85 && number2 >= 85)
            {
                MessageBox.Show("Çok iyi. Ortalam 5.0");
            }
           else if (number1 > 55 && number2 > 55 || number1 < 85 && number2 < 85)
            {
                MessageBox.Show("Sınavdan Geçer. 4.0 ortalama");

            }
        }

        private void btnHomework12_Click(object sender, EventArgs e)
        {
            GetTxtName();
            number1 = Convert.ToInt32(txtNumber1.Text);
            number2 = Convert.ToInt32(txtNumber2.Text);

            MessageBox.Show("Number1 =" +number1 + "\n " + "Number2 =" + number2 + "\n " +" Name = " + name);
        }

        private void btnHomework15_Click(object sender, EventArgs e)
        {
            name1 = Convert.ToInt32(txtName.Text);
            number1 = Convert.ToInt32(txtNumber1.Text);
            number2 = Convert.ToInt32(txtNumber2.Text);

            total = name1 + number2 + number1;
            if(total < 180)
            {
                MessageBox.Show("The triangle is not valid.");
            }
            else
            {
                MessageBox.Show("The triangle is valid.");
            }
            

        }
    }
}
