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
            // Получите значения из TextBox
            int numerator = int.Parse(numeratorTextBox.Text);
            int denominator = int.Parse(denominatorTextBox.Text);

            // Создайте объект Fraction и выполните операцию сложения
            Fraction fraction1 = new Fraction(numerator, denominator);
            Fraction fraction2 = new Fraction(3, 4); // Замените на нужные значения
            Fraction resultFraction = fraction1 + fraction2;

            // Выведите результат
            resultTextBlock.Text = resultFraction.ToString();
        }

        private void OnSubtractButtonClick(object sender, RoutedEventArgs e)
        {
            // Получите значения из TextBox
            int numerator = int.Parse(numeratorTextBox.Text);
            int denominator = int.Parse(denominatorTextBox.Text);

            // Создайте объект Fraction и выполните операцию вычитания
            Fraction fraction1 = new Fraction(numerator, denominator);
            Fraction fraction2 = new Fraction(3, 4); // Замените на нужные значения
            Fraction resultFraction = fraction1 - fraction2;

            // Выведите результат
            resultTextBlock.Text = resultFraction.ToString();
        }

        private void OnMultiplyButtonClick(object sender, RoutedEventArgs e)
        {
            // Получите значения из TextBox
            int numerator = int.Parse(numeratorTextBox.Text);
            int denominator = int.Parse(denominatorTextBox.Text);

            // Создайте объект Fraction и выполните операцию умножения
            Fraction fraction1 = new Fraction(numerator, denominator);
            Fraction fraction2 = new Fraction(3, 4); // Замените на нужные значения
            Fraction resultFraction = fraction1 * fraction2;

            // Выведите результат
            resultTextBlock.Text = resultFraction.ToString();
        }

        private void OnDivideButtonClick(object sender, RoutedEventArgs e)
        {
            // Получите значения из TextBox
            int numerator = int.Parse(numeratorTextBox.Text);
            int denominator = int.Parse(denominatorTextBox.Text);

            // Создайте объект Fraction и выполните операцию деления
            Fraction fraction1 = new Fraction(numerator, denominator);
            Fraction fraction2 = new Fraction(3, 4); // Замените на нужные значения

            try
            {
                Fraction resultFraction = fraction1 / fraction2;
                // Выведите результат
                resultTextBlock.Text = resultFraction.ToString();
            }
            catch (DivideByZeroException)
            {
                resultTextBlock.Text = "Cannot divide by zero!";
            }
        }
    }
}
