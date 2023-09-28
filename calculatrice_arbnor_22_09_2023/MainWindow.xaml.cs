using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace calculatrice_arbnor_22_09_2023
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void display(string num)
        {
            if (TB_Dispay.Text == "0")
            {
                TB_Dispay.Text = num;
            }
            else
            {
                TB_Dispay.Text = TB_Dispay.Text + num;

            }
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            display("2");
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            display("3");
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            display("4");
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            display("5");
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            display("6");
        }
        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            display("7");
        }
        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            display("8");
        }
        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            display("9");

        }


    }
}






