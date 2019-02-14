using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorTut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double var1, var2, answer;
        string operand;
        bool answered;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClick(string number) {
            if (!answered)
            {
                txtAnswer.Text = txtAnswer.Text + number;
            }
            else {
                txtAnswer.Text = number;
                answered = false;
            }
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            btnClick("1");
        }


        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            btnClick("3");
        }

        private void btnFour_Click(object sender, RoutedEventArgs e) {
            btnClick("4");
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            btnClick("5");
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            btnClick("6");
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            btnClick("7");
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            btnClick("8");
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            btnClick("9");
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            //var1 = Convert.ToDouble(txtAnswer.Text);
            btnClick("2");
        }

        private void Operand(string operate) {
            var1 = Convert.ToDouble(txtAnswer.Text);
            txtVars.Text = txtAnswer.Text + operate;
            operand = operate;
            txtAnswer.Text = "";
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            Operand("+");
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            Operand("-");
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            Operand("/");
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            Operand("*");
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            var2 = Convert.ToDouble(txtAnswer.Text);
            txtVars.Text = txtVars.Text + txtAnswer.Text;
            switch (operand) {
                case "*":
                    answer = var1 * var2;
                    break;
                case "/":
                    if(var2 == 0){
                        txtAnswer.Text = "Error 1 : Can't Divide By Zero";
                    }else{
                        answer = var1 / var2;
                    }
                    break;
                case "+":
                    answer = var1 + var2;
                    break;
                case "-":
                    answer = var1 - var2;
                    break;
            };

            txtAnswer.Text = Convert.ToString(answer);
            answered = true;
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            btnClick("0");
        }

        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {
            if(txtAnswer.Text.Contains('.')){
                txtAnswer.Text = txtAnswer.Text;
            }else{
                txtAnswer.Text = txtAnswer.Text + '.';
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtVars.Text = "";
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = "";
        }
    }
}
