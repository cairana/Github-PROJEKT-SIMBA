using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data.SqlClient;
//using SimbaTvaerfagligt.Properties;



namespace SimbaTvaerfagligt
{
    public class Database
    {
        private SqlConnection connection;
        private SqlCommand command = new SqlCommand();
        private int gameId = -1;

        private string GetConnectionString()
        {
            //Brug denne database - GearHost (...langsom)
            return global.Default.connectionstring_online;

            ////Lokal database
            //return global.Default.connectionstring_local;
        }

      
        private void PrepareSql(string sqlString, List<SqlParameter> paramList = null)
        {
            connection = new SqlConnection(GetConnectionString());
            connection.Open();
            command.Connection = connection;
            command.CommandText = sqlString;

            if (paramList != null)
            {
                command.Parameters.Clear();
                command.Parameters.AddRange(paramList.ToArray());
            }

        }

        // Metoden bruges for ExecuteNonQuery() commands, som Create, Update, Delete.
        // Lagrer det ticketId som er blevet genereret under create, så vi kan bruge det under oprettelse af korrespondancen
        public int ExecuteNonQuerySql(string sqlString, List<SqlParameter> paramList = null, bool isUpdateOrDelete = false)
        {
            PrepareSql(sqlString, paramList);
            int affectedRows = command.ExecuteNonQuery(); //Tjekker hvor mange rækker der er blevet påvirket 



            if (affectedRows == 1)
            {
                //Sæt ny sql men bibehold commandobjectet så vi ikke får en ny connection og derved mister id.
                command.CommandText = "SELECT @@IDENTITY as ID";
                SqlDataReader reader = command.ExecuteReader(); //Henter id af den seneste record.
                reader.Read();

                if (isUpdateOrDelete)
                {
                    return -1;
                }
                return ((int)reader.GetDecimal(0)); // hent som decimal og cast/konverter som int og returer int'en
            }
            connection.Close();
            return -1;
        }


        public void Close()
        {
            this.connection.Close();
        }

        public SqlDataReader ExecuteQuery(string sqlString)
        {
            PrepareSql(sqlString);
            return command.ExecuteReader();
        }

        public void EndCurrentGame()
        {
            string sqlString = "UPDATE [game] SET game_ended = @game_ended WHERE game_id =" + this.gameId;

            List<SqlParameter> myParams = new List<SqlParameter>();
            myParams.Add(new SqlParameter("@game_ended", DateTime.Now));
            ExecuteNonQuerySql(sqlString, myParams, true);

            myParams.Clear();
        }

        public void SaveInitialGameConditions()
        {
            this.gameId = ExecuteNonQuerySql("INSERT INTO [game] DEFAULT VALUES;");
        }

        public int SaveGameRounds(string rounds_boardxml)
        {
            if (this.gameId == -1) throw new Exception("HALLO geni... du har ikke startet spillet!");
            string sqlString = "INSERT INTO [rounds] (rounds_game_id, rounds_boardxml) VALUES (@rounds_game_id, @rounds_boardxml)";
            
            List<SqlParameter> myParams = new List<SqlParameter>();
            myParams.Add(new SqlParameter("@rounds_game_id", this.gameId));
            myParams.Add(new SqlParameter("@rounds_boardxml", rounds_boardxml));
            ExecuteNonQuerySql(sqlString, myParams);

            myParams.Clear();

            return gameId;
        }
    }
}

