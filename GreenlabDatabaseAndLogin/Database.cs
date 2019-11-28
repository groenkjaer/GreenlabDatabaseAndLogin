using System.Configuration;
using System.Data.SqlClient;

namespace GreenlabDatabaseAndLogin
{
    public class Database
    {
        private SqlConnection connection;

        public Database()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["post"].ConnectionString);
        }
        public bool IsValidEmail(string email)
        {
            email = email.ToLower();
            string tempEmail;
            SqlCommand command = new SqlCommand(string.Format("SELECT * FROM [user] WHERE email = '{0}'", email), connection);
            connection.Open();
            using (SqlDataReader dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    tempEmail = (string)dataReader["email"];
                    tempEmail = tempEmail.ToLower();
                    if (email == tempEmail) return true;
                }
            }
            return false;
        }

        public bool AttemptLogin(string email, string password)
        {
            //Log the user in if their password is correct and set loggedIn bool to true, else sent false
            SqlCommand command = new SqlCommand(string.Format("SELECT * FROM [user] WHERE email = '{0}' AND password = '{1}'", email, password), connection);
            connection.Open();
            using (SqlDataReader dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    //if (email) return true;

                }
            }
            return false;
        }
    }
}
