using Questionnaires.DataBase;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Npgsql;
using NpgsqlTypes;
using Newtonsoft.Json;

namespace Questionnaires
{
    public partial class CreatingEditingQuestionnaires : Window
    {
        public ObservableCollection<QuestionContent> Contents { get; set; }
        public ObservableCollection<Form> Forms { get; set; } = new ObservableCollection<Form>();
        public CreatingEditingQuestionnaires()
        {
            InitializeComponent();

            Binding binding = new Binding();
            binding.Source = Forms;
            formList.SetBinding(ListBox.ItemsSourceProperty, binding);



            LoadForm();
            Contents = new ObservableCollection<QuestionContent>
            {
                LoadQuestions()
            };

            DataContext = this;
        }


        private void LoadForm()
        {

            NpgsqlCommand command = dbConnect.GetCommand("SELECT id, \"Name\", \"Teacher\" FROM \"Form\" ORDER BY id");
            NpgsqlDataReader result = command.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Forms.Add(new Form(result.GetInt32(0), result.GetString(1), result.GetString(2)));
                }
            }
            result.Close();

        }
        private QuestionContent LoadQuestions()
        {

            NpgsqlCommand command = dbConnect.GetCommand("SELECT \"Content\" FROM \"Question\" ORDER BY id");
            NpgsqlDataReader result = command.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    var content = JsonConvert.DeserializeObject<QuestionContent>(result.GetString(0));
                    result.Close();
                    return content;
                }
            }
            result.Close();
            return null;
        }
    
    }
}
