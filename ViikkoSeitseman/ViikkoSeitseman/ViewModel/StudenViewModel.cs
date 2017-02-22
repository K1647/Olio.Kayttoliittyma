using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViikkoSeitseman.Model;

namespace ViikkoSeitseman.ViewModel
{
    public class StudenViewModel
    {
        public ObservableCollection<Student> Students { get; set; }
        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            // lisätään muutama opiskelija
            students.Add(new Student { FirstName = "Kalle", LastName = "Jalkanen", AsioId="K4841" });
            students.Add(new Student { FirstName = "Seppo", LastName = "Testaaja", AsioId="H432" });
            students.Add(new Student { FirstName = "Tomi", LastName = "Tötterstöm", AsioId="L321"});
            students.Add(new Student { FirstName = "Anna", LastName = "Puu", AsioId="K2341"});
            Students = students;
        }
        //metodi StudentViewModeliin jolla haetaan oppilastiedot mysql-palvemilta
        public void LoadStudentsFromMysql()
        {
            try
            {
                ObservableCollection<Student> students = new ObservableCollection<Student>();
                //luodaan yhteys labranetin mysql-palvelimelle
                string connStr = GetMysqlConnectionString();
                string sql = "SELECT firstname, lastname, asioid FROM student";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ViikkoSeitseman.Model.Student s = new Model.Student();
                            s.FirstName = reader.GetString(0);
                            s.LastName = reader.GetString(1);
                            s.AsioId = reader.GetString(2);
                            students.Add(s);
                        }
                        Students = students;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        private string GetMysqlConnectionString()
        {
            //haetaan salasana App.Config- tiedostosta
            string pw = ""; //"YPdy7qKh3T7Agu1pgmz9nKpdSalpTSVZ";
            pw = ViikkoSeitseman.Properties.Settings.Default.passu;
            return string.Format("Data source=mysql.labranet.jamk.fi;Initial Catalog=K1647_2;user=K1647;password={0}", pw);
        }
    }
    
}
