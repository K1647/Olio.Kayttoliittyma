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

namespace Tehtavat
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

        private void button_truck_Click(object sender, RoutedEventArgs e)
        {
            int x;
            Int32.TryParse(textTruck.Text, out x);
            x++;
            textTruck.Text = Convert.ToString(x);
        }

        private void button_car_Click(object sender, RoutedEventArgs e)
        {
            int x;
            Int32.TryParse(textCar.Text, out x);
            x++;
            textCar.Text = Convert.ToString(x);
        }
    }
}
