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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + '1';
        }


        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + '3';
        }

        private void btnFour_Click(object sender, RoutedEventArgs e) {
            txtAnswer.Text = txtAnswer.Text + '4';
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + '5';
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + '6';
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + '7';
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + '8';
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + '9';
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            //var1 = Convert.ToDouble(txtAnswer.Text);
            txtAnswer.Text = txtAnswer.Text + '2';
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            var1 = Convert.ToDouble(txtAnswer.Text);
            txtVars.Text = txtAnswer.Text + " + ";
            operand = "+";
            txtAnswer.Text = "";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            var1 = Convert.ToDouble(txtAnswer.Text);
            txtVars.Text = txtAnswer.Text + " - ";
            operand = "-";
            txtAnswer.Text = "";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            var1 = Convert.ToDouble(txtAnswer.Text);
            txtVars.Text = txtAnswer.Text + " / ";
            operand = "/";
            txtAnswer.Text = "";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            var1 = Convert.ToDouble(txtAnswer.Text);
            txtVars.Text = txtAnswer.Text + " * ";
            operand = "*";
            txtAnswer.Text = "";
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
                    answer = var1 / var2;
                    break;
                case "+":
                    answer = var1 + var2;
                    break;
                case "-":
                    answer = var1 - var2;
                    break;
            };

            txtAnswer.Text = Convert.ToString(answer);
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Text = txtAnswer.Text + '0';
        }

        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {
            if(txtAnswer.Text.Contains('.')){
                txtAnswer.Text = txtAnswer.Text;
            }else{
                txtAnswer.Text = txtAnswer.Text + '.';
            }
        }
    }
}
