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
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                tempEmail = (string)dataReader["email"];
                tempEmail = tempEmail.ToLower();
                if (email == tempEmail)
                {
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }

        public bool AttemptLogin(string password)
        {
            SqlCommand command = new SqlCommand(string.Format("SELECT * FROM [user] WHERE password = '{0}'", password), connection);
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (password.Equals((string)dataReader["password"]))
                {
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }

        public User CreateUserInstance(string email)
        {
            SqlCommand command = new SqlCommand(string.Format("SELECT * FROM [user] WHERE email = '{0}'", email), connection);
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {

                string id = dataReader["user_id"].ToString();
                string firstname = dataReader["first_name"].ToString();
                string lastname = dataReader["last_name"].ToString();
                string phone = dataReader["phone"].ToString();
                string role = dataReader["role"].ToString();
                string partner = dataReader["partner"].ToString();

                User userInstance = new User(id, firstname, lastname, phone, email, role, partner);
                connection.Close();
                return userInstance;
            }
            throw new System.Exception();
        }
    }
}
