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

namespace antifriendzone
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

        Random n = new Random();
        bool presionosi;
        public void moverboton(object sender, RoutedEventArgs e)
        {
            {
                int m1 = n.Next(200);
                int m2 = n.Next(200);
                int m3 = n.Next(200);
                int m4 = n.Next(200);
                BNO.Margin = new Thickness(m1, m2, m3, m4);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sabia que dirias que si  ❤");
           presionosi  = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (presionosi == true) this.Close();
            else
            MessageBox.Show("A donde vas 🥵😈");
           
        }
    }
}
