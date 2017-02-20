using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoSeitseman.Model
{
    public class Student : INotifyPropertyChanged
    {
        //properties
        private string firstname;

        public string FirstName
        {
            get { return firstname; }
            set
            {
                if (firstname != value)
                {
                    firstname = value;
                    RaisePropertyChange("FirstName");
                    RaisePropertyChange("FullName");
                }
            }
        }

        private string lastname;

        public string LastName
        {
            get { return lastname; }
            set
            {
                if (lastname != value)
                {
                    lastname = value;
                    RaisePropertyChange("LastName");
                    RaisePropertyChange("FullName");
                }
            }
            }
        public string FullName
        {
            get
            {
                return firstname + " " + lastname;
            }
        }
        public string AsioId { get; set; }
        //constructors
        //Methods
        //events
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChange(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
