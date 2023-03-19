using System.Collections.ObjectModel;
using System.Windows;
using Npgsql;
using NpgsqlTypes;
using Questionnaires.DataBase;

namespace Questionnaires
{

    public partial class StudentRegistration : Window
    {

        public ObservableCollection<AccountRegistration> Accounts { get; set; } = new ObservableCollection<AccountRegistration>();
        public AccountRegistration NewAccount { get; set; }
        public StudentRegistration()
        {
            InitializeComponent();
            Accounts = new ObservableCollection<AccountRegistration>();
            DataContext = this;
        }
        private void CreateAccountStudent(object sender, RoutedEventArgs e)  //Регистрация студента
        {

            AccountRegistration.Add(NewAccount);


            var Login = loginStudent.Text.Trim();
            var Password = pasStudent.Text.Trim();
            var FirstName = firstNameStudent.Text.Trim();
            var LastName = lastNameStudent.Text.Trim();
            var Patronymic = patronymicStudent.Text.Trim();
            var Role = "Student";
            var Class = classStudent.Text.Trim();



            if (Login.Length == 0 && Password.Length == 0 && FirstName.Length == 0 && LastName.Length == 0 && Patronymic.Length == 0 && Role.Length == 0 && Class.Length == 0) return;



            NpgsqlCommand command = dbConnect.GetCommand("INSERT INTO \"Account\"(\"Login\", \"Password\", \"FirstName\", \"LastName\", \"Patronymic\", \"Role\", \"Class\") VALUES(@a, @b, @c, @d, @e, @f, @g)");

            command.CommandText = "INSERT INTO \"Account\"(\"Login\", \"Password\", \"FirstName\", \"LastName\", \"Patronymic\", \"Role\", \"Class\") VALUES(@a, @b, @c, @d, @e, @f, @g)";
            command.Parameters.AddWithValue("@a", NpgsqlDbType.Varchar, Login);
            command.Parameters.AddWithValue("@b", NpgsqlDbType.Varchar, Password);
            command.Parameters.AddWithValue("@c", NpgsqlDbType.Varchar, FirstName);
            command.Parameters.AddWithValue("@d", NpgsqlDbType.Varchar, LastName);
            command.Parameters.AddWithValue("@e", NpgsqlDbType.Varchar, Patronymic);
            command.Parameters.AddWithValue("@f", NpgsqlDbType.Varchar, Role);
            command.Parameters.AddWithValue("@g", NpgsqlDbType.Varchar, Class);

            int result = command.ExecuteNonQuery();
            if (result == 1)
            {
                MessageBox.Show("Вы успешно зарегистрировались");

            }

        }
    }
}
