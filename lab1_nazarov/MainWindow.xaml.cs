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
            int numerator = int.Parse(numeratorTextBox.Text);
            int denominator = int.Parse(denominatorTextBox.Text);


            Fraction fraction1 = new Fraction(numerator, denominator);
            Fraction fraction2 = new Fraction(3, 4);
            Fraction resultFraction = fraction1 + fraction2;
            resultTextBlock.Text = resultFraction.ToString();
        }

        private void OnSubtractButtonClick(object sender, RoutedEventArgs e)
        {
            int numerator = int.Parse(numeratorTextBox.Text);
            int denominator = int.Parse(denominatorTextBox.Text);
            
            Fraction fraction1 = new Fraction(numerator, denominator);
            Fraction fraction2 = new Fraction(3, 4);
            Fraction resultFraction = fraction1 - fraction2;
            
            resultTextBlock.Text = resultFraction.ToString();
        }

        private void OnMultiplyButtonClick(object sender, RoutedEventArgs e)
        {
            int numerator = int.Parse(numeratorTextBox.Text);
            int denominator = int.Parse(denominatorTextBox.Text);

 
            Fraction fraction1 = new Fraction(numerator, denominator);
            Fraction fraction2 = new Fraction(3, 4); 
            Fraction resultFraction = fraction1 * fraction2;
            
            resultTextBlock.Text = resultFraction.ToString();
        }

        private void OnDivideButtonClick(object sender, RoutedEventArgs e)
        {
            int numerator = int.Parse(numeratorTextBox.Text);
            int denominator = int.Parse(denominatorTextBox.Text);
            
            Fraction fraction1 = new Fraction(numerator, denominator);
            Fraction fraction2 = new Fraction(3, 4);

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
