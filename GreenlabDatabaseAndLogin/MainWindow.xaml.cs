using System.Windows;

namespace GreenlabDatabaseAndLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool UserIsLoggedIn;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e) //email@eadania.com   hashed password
        {
            Database database = new Database();

            if (database.IsValidEmail(Email.Text))
            {
                if (database.AttemptLogin(Password.Password))
                {
                    UserIsLoggedIn = true;
                    User currentUser = database.CreateUserInstance(Email.Text);

                    MessageBox.Show("Welcome " + currentUser.GetFirstName + " " + currentUser.GetLastName + " from " + currentUser.GetPartner);
                }
                else
                {
                    MessageBox.Show("Password is wrong");
                }
            }
            else
            {
                MessageBox.Show("Email is not registered");
            }
        }
    }
}
