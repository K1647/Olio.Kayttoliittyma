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
                string lista = "";
                foreach (CheckBox item in checklist.Children)
                {
                    if (item.GetType() == typeof(CheckBox))
                    {
                        if ((bool)item.IsChecked)
                        {
                            lista = lista + " " + item.Name;
                        }
                        else
                        {
                            lista = lista;
                        }
                    }
                    else
                    {
                        lista = lista;
                    }
                }
                textBox.Text = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
