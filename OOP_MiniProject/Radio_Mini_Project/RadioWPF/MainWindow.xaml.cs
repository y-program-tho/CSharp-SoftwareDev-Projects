using RadioApp;
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

namespace RadioWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Radio radiopj = new Radio();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Channel_1_Click(object sender, RoutedEventArgs e)
        {
            radiopj.Channel = 1;
            OutputBox.Text = radiopj.Play();
        }

        private void Channel_2_Click(object sender, RoutedEventArgs e)
        {
            radiopj.Channel = 2;
            OutputBox.Text = radiopj.Play();
        }

        private void Channel_3_Click(object sender, RoutedEventArgs e)
        {
            radiopj.Channel = 3;
            OutputBox.Text = radiopj.Play();
        }

        private void Channel_4_Click(object sender, RoutedEventArgs e)
        {
            radiopj.Channel = 4;
            OutputBox.Text = radiopj.Play();
        }

        private void On_Click(object sender, RoutedEventArgs e)
        {
            radiopj.TurnOn();
            OutputBox.Text = "Radio is on";
        }

        private void Off_Click(object sender, RoutedEventArgs e)
        {
            radiopj.TurnOff();
            OutputBox.Text = "Radio is off";
        }
    }
}
