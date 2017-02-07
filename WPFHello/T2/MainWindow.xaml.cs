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

namespace T2
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

        private void buttonLaske_Click(object sender, RoutedEventArgs e)
        {
            double luku_uusi1, muunnos = 0; 
            try
            {
                luku_uusi1 = Double.Parse(annettu.Text); 

                if ((bool)eumar.IsChecked) muunnos = luku_uusi1 * 5.94573;
                if ((bool)mareu.IsChecked) muunnos = luku_uusi1 / 5.94573;
            }
            catch { }

            muunnettu.Text = muunnos.ToString("0.00"); 
        }
    }
}
