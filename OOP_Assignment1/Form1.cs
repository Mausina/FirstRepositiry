using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float userInputNumber;
        float num1; // First operand
        float num2; // Second operand
        string option; // (+, -, *, /, x^2)
        float result; // Result of the operation

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Event handler for numeric buttons (0-9, point)
        private void NumberZero_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + NumberZero.Text;
        }
        private void NumberOne_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + NumberOne.Text;
        }
        private void NumberTwo_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + NumberTwo.Text;
        }

        private void NumberThree_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + NumberThree.Text;
        }

        private void NumberFour_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + NumberFour.Text;
        }

        private void NumberFive_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + NumberFive.Text;
        }

        private void NumberSix_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + NumberSix.Text;
        }

        private void NumberSeven_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + NumberSeven.Text;
        }
        private void NumberEight_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + NumberEight.Text;
        }

        private void NumberNine_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + NumberNine.Text;
        }
        // checking if Input is a symbol
        private void VerifyInput()
        {
            if (!float.TryParse(textBoxResult.Text, out num1))
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
                return;
            }
        }

        // Event handler for point
        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + buttonPoint.Text;
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
            // Try to parse the text in the textBoxResult as a float
            if (float.TryParse(textBoxResult.Text, out userInputNumber))
            {
                
            }
            else
            {
                userInputNumber = 0; 
            }
        }
        // Event handler for operator buttons (+, -, *, /, x^2)
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            VerifyInput();
            textBoxResult.Clear();
        }


        private void buttonMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            VerifyInput();
            textBoxResult.Clear();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            option = "/";
            VerifyInput();
            textBoxResult.Clear();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            option = "*";
            VerifyInput();
            textBoxResult.Clear();
        }

        private void buttonDegree_Click(object sender, EventArgs e)
        {
            VerifyInput();
            result = num1 * num1;
            textBoxResult.Text = result.ToString();
        }

         // Clear the input and reset variables
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            num1 = 0;
            num2 = 0;
            result = 0;
        }
        // Close application
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Event handler for the equals button
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(textBoxResult.Text, out num2))
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
                return;
            }
            switch (option) 
            {
                case "+":
                    result = num1 + num2;
                    break; 
                case "-":
                    result = num1 - num2;
                    break;
                case "/":
                    if (num2 != 0) 
                        result = num1 / num2;
                    else
                        MessageBox.Show("Invalid input. Please enter valid numbers.");
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                default:
                    break;

            }
            textBoxResult.Text = result.ToString();
        }

    }
}

