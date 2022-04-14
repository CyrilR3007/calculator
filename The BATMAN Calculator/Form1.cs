namespace The_BATMAN_Calculator
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
        }


        float num1, num2, result;
        char operation;
        bool dec = false;


        private void changeLabel(int numbPressed)
        {
            if (dec == true)
            {
                int decimalCount = 0;
                foreach (char c in displayLabel.Text)
                {
                    if (c == ',')
                    {
                        decimalCount++;
                    }
                }
                if (decimalCount < 1)
                {
                    displayLabel.Text = displayLabel.Text + ",";
                }
                dec = false;
            }
            else
            {
                if (displayLabel.Text.Equals("0") == true && displayLabel.Text != null)
                {
                    displayLabel.Text = numbPressed.ToString();
                }
                else if (displayLabel.Text.Equals("-0") == true)
                {
                    displayLabel.Text = "-" + numbPressed.ToString();
                }
                else
                {
                    displayLabel.Text = displayLabel.Text + numbPressed.ToString();
                }
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            changeLabel(0);
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            dec = true;
            changeLabel(0);
        }

        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "-" + displayLabel.Text;
        }

        private void squareRootBbutton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            if (num1 > 0)
            {
                double sqrt = Math.Sqrt(num1);
                displayLabel.Text = sqrt.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "0";
        }

        private void dividButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '/';
            result = result / num1;
            displayLabel.Text = "";

        }

        private void multiplierButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '*';
            result = result * num1;
            displayLabel.Text = "";

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '-';
            result = result - num1;
            displayLabel.Text = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '+';
            result = result + num1;
            displayLabel.Text = "";
        }




        private void equalButton_Click(object sender, EventArgs e)
        {
            result = 0;
            if (displayLabel.Text.Equals("0") == false)
            {
                switch (operation)
                {
                    case '+':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 + num2;
                        break;
                    case '-':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 - num2;
                        break;
                    case '*':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 * num2;
                        break;
                    case '/':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 / num2;
                        break;
                    default:
                        break;
                }
            }
            displayLabel.Text = result.ToString();
        }

        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            int stringLength = displayLabel.Text.Length;
            if (stringLength > 1)
            {
                displayLabel.Text = displayLabel.Text.Substring(0, stringLength - 1);
            }
            else
            {
                displayLabel.Text = "0";
            }
        }
    }
}