using System.ComponentModel;

namespace Questionnaires
{
    public class Form
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }


        public Form(int id, string Name, string Teacher)
        {
            Id = id;
            Name1 = Name;
            Teacher1 = Teacher;

        }

        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Id"));
            }

        }
        public string Name1
        {
            get => Name;
            set
            {
                Name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Name1"));
            }

        }

        public string Teacher1
        {
            get => Teacher;
            set
            {
                Teacher = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Teacher1"));
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

    }
}
