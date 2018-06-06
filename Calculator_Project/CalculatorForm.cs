using System;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class superCalculator : Form
    {
        //Variables used throughout the application
        //input and answer define the input from the user and what has already been entered
        //operation is used to determine which arithmetic operation to use
        //decCount is used to make sure that only one decimal is placed in a number
        float input, answer;
        int operation;
        int decCount = 1;

        public superCalculator()
        {
            InitializeComponent();
        }

        private void decimalButton_Click(object sender, EventArgs e) //makes the value a decimal
        {
            if (decCount == 1) //makes sure the decimal is only pressed once
            {
                calcBox.Text = calcBox.Text + ".";
                decCount++;
            }
        }

        private void clearButton_Click(object sender, EventArgs e) //clears the textbox and label
        {
            calcBox.Text = "";
            displayLabel.Text = "";
        }

        private void percentButton_Click(object sender, EventArgs e) //finds the percent value of a number
        {
            input = float.Parse(calcBox.Text) / 100;
            calcBox.Text = input.ToString();
        }

        private void zeroButton_Click(object sender, EventArgs e) //adds a 0 to the textbox
        {
            calcBox.Text = calcBox.Text + 0;
        }

        private void oneButton_Click(object sender, EventArgs e) //adds a 1 to the textbox
        {
            decCount = 1;
            calcBox.Text = calcBox.Text + 1;
        }

        private void twoButton_Click(object sender, EventArgs e) //adds a 2 to the textbox
        {
            decCount = 1;
            calcBox.Text = calcBox.Text + 2;
        }

        private void threeButton_Click(object sender, EventArgs e) //adds a 3 to the textbox
        {
            decCount = 1;
            calcBox.Text = calcBox.Text + 3;
        }

        private void fourButton_Click(object sender, EventArgs e) //adds a 4 to the textbox
        {
            decCount = 1;
            calcBox.Text = calcBox.Text + 4;
        }

        private void fiveButton_Click(object sender, EventArgs e) //adds a 5 to the textbox
        {
            decCount = 1;
            calcBox.Text = calcBox.Text + 5;
        }

        private void sixButton_Click(object sender, EventArgs e) //adds a 6 to the textbox
        {
            decCount = 1;
            calcBox.Text = calcBox.Text + 6;
        }

        private void sevenButton_Click(object sender, EventArgs e) //adds a 7 to the textbox
        {
            decCount = 1;
            calcBox.Text = calcBox.Text + 7;
        }

        private void eightButton_Click(object sender, EventArgs e) //adds a 8 to the textbox
        {
            decCount = 1;
            calcBox.Text = calcBox.Text + 8;
        }

        private void nineButton_Click(object sender, EventArgs e) //adds a 9 to the textbox
        {
            decCount = 1;
            calcBox.Text = calcBox.Text + 9;
        }

        private void equalsButton_Click(object sender, EventArgs e) //finds the total based on which operation was selected
        {
            calculate(); //runs the arithmetic operation
            displayLabel.Text = "";
        }

        private void calculate() //determines and runs the arithmetic operation
        {
            switch (operation)
            {
                case 1:
                    answer = input + float.Parse(calcBox.Text); //converts string, computes and  assigns the numerical value to the variable
                    calcBox.Text = answer.ToString(); //The answer is put into the calcBox TextBox
                    break;
                case 2:
                    answer = input - float.Parse(calcBox.Text); //converts string, computes and  assigns the numerical value to the variable
                    calcBox.Text = answer.ToString(); //The answer is put into the calcBox TextBox
                    break;
                case 3:
                    answer = input * float.Parse(calcBox.Text); //converts string, computes and assigns the numerical value to the variable
                    calcBox.Text = answer.ToString(); //The answer is put into the calcBox TextBox
                    break;
                case 4:
                    answer = input / float.Parse(calcBox.Text); //converts string, computes and assigns the numerical value to the variable
                    calcBox.Text = answer.ToString(); //The answer is put into the calcBox TextBox
                    break;
            }
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            input = float.Parse(calcBox.Text); //converts string and assigns the numerical value to the variable
            calcBox.Text = calcBox.Text + "+";
            operation = 1; //used to determine which operation will be used in calculate method
            displayLabel.Text = input.ToString() + "+";
            calcBox.Text = "";
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            input = float.Parse(calcBox.Text); //converts string and assigns the numerical value to the variable
            calcBox.Text = calcBox + "-";
            operation = 2; //used to determine which operation will be used in calculate method
            displayLabel.Text = input.ToString() + "-";
            calcBox.Text = "";
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            input = float.Parse(calcBox.Text); //converts string and assigns the numerical value to the variable
            calcBox.Text = calcBox + "*";
            operation = 3; //used to determine which operation will be used in calculate method
            displayLabel.Text = input.ToString() + "*";
            calcBox.Text = "";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            input = float.Parse(calcBox.Text); //converts string and assigns the numerical value to the variable
            calcBox.Text = calcBox + "/";
            operation = 4; //used to determine which operation will be used in calculate method
            displayLabel.Text = input.ToString() + "/";
            calcBox.Text = "";
        }

    } // end class SuperCalculator
} // end namespace