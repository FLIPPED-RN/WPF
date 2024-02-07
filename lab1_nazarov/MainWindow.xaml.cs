using System;
using System.Windows;
using lab1_nazarov.Modul;

namespace lab1_nazarov
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {
            int numerator1 = int.Parse(numeratorTextBox.Text);
            int denominator1 = int.Parse(denominatorTextBox.Text);
            Fraction fraction1 = new Fraction(numerator1, denominator1);

            int numerator2 = int.Parse(numerator2TextBox.Text);
            int denominator2 = int.Parse(denominator2TextBox.Text);
            Fraction fraction2 = new Fraction(numerator2, denominator2);

            Fraction resultFraction = fraction1 + fraction2;
            resultTextBlock.Text = resultFraction.ToString();
        }

        private void OnSubtractButtonClick(object sender, RoutedEventArgs e)
        {
            int numerator1 = int.Parse(numeratorTextBox.Text);
            int denominator1 = int.Parse(denominatorTextBox.Text);
            Fraction fraction1 = new Fraction(numerator1, denominator1);

            int numerator2 = int.Parse(numerator2TextBox.Text);
            int denominator2 = int.Parse(denominator2TextBox.Text);
            Fraction fraction2 = new Fraction(numerator2, denominator2);

            Fraction resultFraction = fraction1 - fraction2;
            resultTextBlock.Text = resultFraction.ToString();
        }

        private void OnMultiplyButtonClick(object sender, RoutedEventArgs e)
        {
            int numerator1 = int.Parse(numeratorTextBox.Text);
            int denominator1 = int.Parse(denominatorTextBox.Text);
            Fraction fraction1 = new Fraction(numerator1, denominator1);

            int numerator2 = int.Parse(numerator2TextBox.Text);
            int denominator2 = int.Parse(denominator2TextBox.Text);
            Fraction fraction2 = new Fraction(numerator2, denominator2);

            Fraction resultFraction = fraction1 * fraction2;
            resultTextBlock.Text = resultFraction.ToString();
        }

        private void OnDivideButtonClick(object sender, RoutedEventArgs e)
        {
            int numerator1 = int.Parse(numeratorTextBox.Text);
            int denominator1 = int.Parse(denominatorTextBox.Text);
            Fraction fraction1 = new Fraction(numerator1, denominator1);

            int numerator2 = int.Parse(numerator2TextBox.Text);
            int denominator2 = int.Parse(denominator2TextBox.Text);
            Fraction fraction2 = new Fraction(numerator2, denominator2);

            try
            {
                Fraction resultFraction = fraction1 / fraction2;
                resultTextBlock.Text = resultFraction.ToString();
            }
            catch (DivideByZeroException)
            {
                resultTextBlock.Text = "На ноль делить нельзя!";
            }
        }
    }
}
