using System.Windows;
using Questionnaires.DataBase;
using Npgsql;
using NpgsqlTypes;

namespace Questionnaires
{
    public partial class MainWindow : Window
    {
        private NpgsqlConnection connection;


        public MainWindow()
        {
            InitializeComponent();
            DataBase.dbConnect.Connect("host=10.14.206.28;port=5432;user ID=student;password=1234;database=EtoBaseo4ka");
            DataLoader.Fetch();


            DataContext = this;

            MainFrame.Navigate(PageControl.creatingeditingQuestionnaires);
        }
        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                DragMove();

        }

        private void MinimizeWindow_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }


        private void StateWindow_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            else
                Application.Current.MainWindow.WindowState = WindowState.Normal;
        }


        private void ShutDownWindow_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
