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
using Calculator;

namespace WPFCalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var x = Convert.ToInt32(Input1.Text);
            var y = Convert.ToInt32(Input2.Text);
            int result = Calculator.Calculator.Add(x, y);

            Output.Text = result.ToString();
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            var x = Convert.ToInt32(Input1.Text);
            var y = Convert.ToInt32(Input2.Text);
            int result = Calculator.Calculator.Sub(x, y);


            Output.Text = result.ToString();
        }

        private void Pro_Click(object sender, RoutedEventArgs e)
        {
            var x = Convert.ToInt32(Input1.Text);
            var y = Convert.ToInt32(Input2.Text);
            int result = Calculator.Calculator.Pro(x, y);

            Output.Text = result.ToString();
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            var x = Convert.ToInt32(Input1.Text);
            var y = Convert.ToInt32(Input2.Text);
            int result = Calculator.Calculator.Div(x, y);

            Output.Text = result.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}
