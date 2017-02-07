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

namespace T3
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
            try
            {
                int x, y, z, muunnos1,muunnos2, muunnos3;
                Int32.TryParse(ikkunanleveys.Text, out x);
                Int32.TryParse(ikkunankorkeus.Text, out y);
                Int32.TryParse(karminleveys.Text, out z);
                muunnos1 = (x * y) / 10;
                muunnos2 = ((x - (2 * z)) * (y - (2 * z))) / 10;
                muunnos3 = ((2 * x) + (2 * y)) / 10;
                textKarminpiiri.Text = muunnos3.ToString() + " cm";
                textLasinPA.Text = muunnos2.ToString() + " cm^2";
                textIkkunanPA.Text = muunnos1.ToString() + " cm^2";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
