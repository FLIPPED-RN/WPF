using System.Windows;
using lab2_nazarov.Modul;

namespace lab2_nazarov
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
            IPair fraction1 = new Fraction(numerator1, denominator1);

            int numerator2 = int.Parse(numerator2TextBox.Text); // Предположим, что у вас есть TextBox для ввода numerator2
            int denominator2 = int.Parse(denominator2TextBox.Text); // Предположим, что у вас есть TextBox для ввода denominator2
            IPair fraction2 = new Fraction(numerator2, denominator2);

            Fraction resultFraction = (Fraction)fraction1 + (Fraction)fraction2;
            resultTextBlock.Text = resultFraction.ToString();
        }

        private void OnSubtractButtonClick(object sender, RoutedEventArgs e)
        {
            int numerator1 = int.Parse(numeratorTextBox.Text);
            int denominator1 = int.Parse(denominatorTextBox.Text);
            IPair fraction1 = new Fraction(numerator1, denominator1);

            int numerator2 = int.Parse(numerator2TextBox.Text);
            int denominator2 = int.Parse(denominator2TextBox.Text);
            IPair fraction2 = new Fraction(numerator2, denominator2);

            Fraction resultFraction = (Fraction)fraction1 - (Fraction)fraction2;
            resultTextBlock.Text = resultFraction.ToString();
        }

        private void OnMultiplyButtonClick(object sender, RoutedEventArgs e)
        {
            int numerator1 = int.Parse(numeratorTextBox.Text);
            int denominator1 = int.Parse(denominatorTextBox.Text);
            IPair fraction1 = new Fraction(numerator1, denominator1);

            int numerator2 = int.Parse(numerator2TextBox.Text);
            int denominator2 = int.Parse(denominator2TextBox.Text);
            IPair fraction2 = new Fraction(numerator2, denominator2);

            Fraction resultFraction = (Fraction)fraction1 * (Fraction)fraction2;
            resultTextBlock.Text = resultFraction.ToString();
        }

        private void OnDivideButtonClick(object sender, RoutedEventArgs e)
        {
            int numerator1 = int.Parse(numeratorTextBox.Text);
            int denominator1 = int.Parse(denominatorTextBox.Text);
            IPair fraction1 = new Fraction(numerator1, denominator1);

            int numerator2 = int.Parse(numerator2TextBox.Text);
            int denominator2 = int.Parse(denominator2TextBox.Text);
            IPair fraction2 = new Fraction(numerator2, denominator2);

            try
            {
                Fraction resultFraction = (Fraction)fraction1 / (Fraction)fraction2;
                resultTextBlock.Text = resultFraction.ToString();
            }
            catch (DivideByZeroException)
            {
                resultTextBlock.Text = "На ноль делить нельзя!";
            }
        }
    }
}
