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

namespace WpfИтоговое
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int number1;
        int number2;
        char sim; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Numbers(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            result.Text += button.Content.ToString();
            number2 = Int32.Parse(result.Text);
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            result.Clear();
        }

        private void Button_Click_Result(object sender, RoutedEventArgs e)
        {
            number2 = Int32.Parse(result.Text);
            int res = 0;
            if (sim == '+')
            {
                res= number1 + number2;
            }
            else if (sim == '-')
            {
                res = number1 - number2;
            }
            else if (sim == '*')
            {
                res = number1 * number2;
            }
            else if (sim == '/')
            {
                res = number1 / number2;
            }
            if (result.Text == "0")
            {
                result.Clear();
            }
            result.Text = res.ToString();
        }

        private void Button_Click_Division(object sender, RoutedEventArgs e)
        {
            number1 = Int32.Parse(result.Text);
            sim = '/';
            result.Clear();
        }

        private void Button_Click_Multiplication(object sender, RoutedEventArgs e)
        {
            number1 = Int32.Parse(result.Text);
            sim = '*';
            result.Clear();
        }

        private void Button_Click_Subtraction(object sender, RoutedEventArgs e)
        {
            number1 = Int32.Parse(result.Text);
            sim = '-';
            result.Clear();
        }

        private void Button_Click_Addition(object sender, RoutedEventArgs e)
        {
            number1 = Int32.Parse(result.Text);
            sim = '+';
            result.Clear();
        }
    }
}
