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
    }
    
}
