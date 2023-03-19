using Questionnaires.DataBase;
using System.Collections.ObjectModel;
using System.Windows;
using Npgsql;
using NpgsqlTypes;

namespace Questionnaires
{
    public partial class TeacherRegistration : Window
    {
        public ObservableCollection<AccountRegistration> Accounts { get; set; } = new ObservableCollection<AccountRegistration>();
        public AccountRegistration NewAccount { get; set; }

        public TeacherRegistration()
        {
            InitializeComponent();
            Accounts = new ObservableCollection<AccountRegistration>();
            DataContext = this;
        }
        private void CreateAccountTeacher(object sender, RoutedEventArgs e)  //Регистрация учителя
        {
            AccountRegistration.Add(NewAccount);

            var Login = textNumberGroup.Text.Trim();
            var Password = textPassword.Text.Trim();
            var FirstName = textNameTeacher.Text.Trim();
            var LastName = textLastName.Text.Trim();
            var Patronymic = textPatronymic.Text.Trim();
            var Role = "Teacher";
            var Class = textClass.Text.Trim();



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
