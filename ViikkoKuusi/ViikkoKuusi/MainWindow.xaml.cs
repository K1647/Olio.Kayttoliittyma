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

namespace ViikkoKuusi
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

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string apu;
                if ((bool)checkMilk.IsChecked)
                {
                    apu = "Milk";
                    textBox.Text = textBox.Text + " " + apu;
                }
                if ((bool)checkButter.IsChecked)
                {
                    apu = "Butter";
                    textBox.Text = textBox.Text + " " + apu;
                }
                if ((bool)checkBeer.IsChecked)
                {
                    apu = "Beer";
                    textBox.Text = textBox.Text + " " + apu;
                }
                if ((bool)checkChicken.IsChecked)
                {
                    apu = "Chicken";
                    textBox.Text = textBox.Text + " " + apu;
                }
                if ((bool)checkLemonade.IsChecked)
                {
                    apu = "Lemonade";
                    textBox.Text = textBox.Text + " " + apu;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
