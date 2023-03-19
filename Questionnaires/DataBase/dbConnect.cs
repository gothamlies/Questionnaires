using System.Collections.ObjectModel;
using Npgsql;
using NpgsqlTypes;

namespace Questionnaires.DataBase
{
    public class dbConnect
    {
        private static NpgsqlConnection Connection { get; set; }

        public static void Connect(string config)
        {
            Connection = new NpgsqlConnection(config);
            Connection.Open();
        }

        public static NpgsqlCommand GetCommand(string sql)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = Connection;
            command.CommandText = sql;
            return command;
        }
    }
    public class QuestionContent
    {
        public string Text { get; set; }

        public int Position { get; set; }

        public ObservableCollection<string> PossibleAnswers { get; set; }

    }
}
