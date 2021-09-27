using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace First
{
    public partial class BT5 : ContentPage
    {

        int currentState = 1;
        string mathOperator;
        double firstNumber, secondNumber;

        public BT5()
        {
            InitializeComponent();
            Clear_Clicked(this, null);
        }

        void Number_Clicked(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if (this.resultText.Text == "0" || currentState < 0)
            {
                this.resultText.Text = "";
                if (currentState < 0)
                    currentState *= -1;
            }

            this.resultText.Text += pressed;

            double number;
            if (double.TryParse(this.resultText.Text, out number))
            {
                this.resultText.Text = number.ToString("N0");
                if (currentState == 1)
                {
                    firstNumber = number;
                }
                else
                {
                    secondNumber = number;
                }
            }
        }

        void Operation_Clicked(System.Object sender, System.EventArgs e)
        {
            currentState = -2;
            Button button = (Button)sender;
            string pressed = button.Text;
            mathOperator = pressed;
        }

        void Clear_Clicked(System.Object sender, System.EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            currentState = 1;
            this.resultText.Text = "0";
        }

        void Caculate_Clicked(System.Object sender, System.EventArgs e)
        {
            if (currentState == 2)
            {
                var result = this.Calculate(firstNumber, secondNumber, mathOperator);

                this.resultText.Text = result.ToString();
                firstNumber = result;
                currentState = -1;
            }
        }

        double Calculate(double value1, double value2, string mathOperator)
        {
            double result = 0;

            switch (mathOperator)
            {
                case "÷":
                    result = value1 / value2;
                    break;
                case "×":
                    result = value1 * value2;
                    break;
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
            }

            return result;
        }
    }
}
