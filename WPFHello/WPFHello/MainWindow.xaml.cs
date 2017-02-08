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

namespace WPFHello
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Hello " + textBox.Text;

            //MessageBox.Show("Terve " + textBox.Text, "Joona's Messut");
            int x;
            Int32.TryParse(textBlock1.Text, out x);
            x++;
            textBlock1.Text = Convert.ToString(x);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //kutsutaan näkyviin About ikkuna
            About aboutWin = new About();
            //huom ikkuna voi olla joko modaalinen tai tavallinen
            //aboutWin.ShowDialog(); // modaalinen
            aboutWin.Show();
        }
    }
}
