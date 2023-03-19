using Questionnaires.DataBase;
using System.Windows;
using System.Windows.Navigation;
using Npgsql;
using NpgsqlTypes;

namespace Questionnaires
{

    public partial class StudentAuthorization : Window
    {
        public StudentAuthorization()
        {
            InitializeComponent();
            DataContext = this;
        }
        private void AuthorizationForStudentButton(object sender, RoutedEventArgs e)
        {
            var Log = loginStudent.Text.Trim();
            var Pass = pasStudent.Text.Trim();
            var Role = "Student";

            NpgsqlCommand command = dbConnect.GetCommand("SELECT \"Login\", \"Password\", \"Role\" FROM \"Account\" WHERE \"Login\" = @a AND \"Password\"= @b AND \"Role\"=@c");
            command.Parameters.AddWithValue("@a", NpgsqlDbType.Varchar, Log);
            command.Parameters.AddWithValue("@b", NpgsqlDbType.Varchar, Pass);
            command.Parameters.AddWithValue("@c", NpgsqlDbType.Varchar, Role);
            NpgsqlDataReader result = command.ExecuteReader();

            if (result.HasRows)
            {
                result.Close();
                NavigationService.Navigate(PageControl.questionnairesforStudents);
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            result.Close();
        }
    }
}
