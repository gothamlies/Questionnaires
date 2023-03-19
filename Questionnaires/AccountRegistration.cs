using System.ComponentModel;

namespace Questionnaires
{
    public class AccountRegistration
    {
        public string login;
        public string password;
        public string firstname;
        public string lastname;
        public string patronymic;
        public string role;
        public string clas;

        public AccountRegistration(string login, string password, string firstname, string lastname, string patronymic, string role, string clas)
        {
            Login1 = login;

            Password = password;

            FirstName = firstname;
            LastName = lastname;
            Patronymic = patronymic;
            Role = role;
            Class1 = clas;

        }

        public string Login1
        {
            get => login;
            set
            {
                login = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Login1"));
            }

        }
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Password"));
            }

        }

        public string FirstName
        {
            get => firstname;
            set
            {
                firstname = value;
                OnPropertyChanged(new PropertyChangedEventArgs("FirstName"));
            }

        }

        public string LastName
        {
            get => lastname;
            set
            {
                lastname = value;
                OnPropertyChanged(new PropertyChangedEventArgs("LastName"));
            }

        }

        public string Patronymic
        {
            get => patronymic;
            set
            {
                patronymic = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Patronymic"));
            }

        }

        public string Role
        {
            get => role;
            set
            {
                role = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Role"));
            }

        }

        public string Class1
        {
            get => clas;
            set
            {
                clas = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Class1"));
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
