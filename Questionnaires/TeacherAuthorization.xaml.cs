using Questionnaires.DataBase;
using System.Windows;
using System.Windows.Navigation;
using Npgsql;
using NpgsqlTypes;

namespace Questionnaires
{
    public partial class TeacherAuthorization : Window
    {
        public TeacherAuthorization()
        {
            InitializeComponent();
            DataContext = this;
        }
        private void AuthorizationForTeacherButton(object sender, RoutedEventArgs e)
        {
            var Log = textLogin.Text.Trim();
            var Pass = textPass.Text.Trim();
            var Role = "Teacher";

            NpgsqlCommand command = dbConnect.GetCommand("SELECT \"Login\", \"Password\", \"Role\" FROM \"Account\" WHERE \"Login\" = @a AND \"Password\"= @b AND \"Role\"=@c");
            command.Parameters.AddWithValue("@a", NpgsqlDbType.Varchar, Log);
            command.Parameters.AddWithValue("@b", NpgsqlDbType.Varchar, Pass);
            command.Parameters.AddWithValue("@c", NpgsqlDbType.Varchar, Role);
            NpgsqlDataReader result = command.ExecuteReader();

            if (result.HasRows)
            {
                result.Close();
                NavigationService.Navigate(PageControl.creatingeditingQuestionnaires);
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            result.Close();
        }
    }
}
