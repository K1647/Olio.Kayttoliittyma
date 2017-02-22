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

namespace ViikkoSeitseman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViikkoSeitseman.ViewModel.StudenViewModel svmo = new ViewModel.StudenViewModel();
        public MainWindow()
        {
            InitializeComponent();
            //kovakoodatut oppilaat
            //svmo.LoadStudents();
            try
            {
                //tietokannasta haetut
                svmo.LoadStudentsFromMysql();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            StudentViewControl.DataContext = svmo;
        }

        private void dgStudents_Loaded(object sender, RoutedEventArgs e)
        {
            dgStudents.DataContext = svmo.Students;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //luodaa uusi student
            ViikkoSeitseman.Model.Student uusi = new Model.Student();
            uusi.FirstName = txtFirstName.Text;
            uusi.LastName = txtLastName.Text;
            svmo.Students.Add(uusi);
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }
    }
}
