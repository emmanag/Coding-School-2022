namespace Session_6
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        //private bool operandPerformed;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button12_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.textBox1.Text = "";
            this.input = String.Empty;
            this.operand1 = String.Empty;
            this.operand2 = String.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }

            }
            else if (operation == '√')
            {
                result = Math.Sqrt(num1);
                textBox1.Text = result.ToString();
            }
            else if (operation == 'ⁿ')
            {
                result = Math.Pow(num1, 2);
                textBox1.Text = result.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = 'ⁿ';
            input = string.Empty;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '√';
            input = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "";
            input += ".";
            this.textBox1.Text += input;
            
        }
        private void button15_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }
    }
}