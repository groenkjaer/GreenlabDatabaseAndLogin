using System.Windows;

namespace GreenlabDatabaseAndLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Database database = new Database();

            if (database.IsValidEmail(Email.Text))
            {
                MessageBox.Show("Im not implemented yet :)"); //email@eadania.com
            }
            else
            {
                MessageBox.Show("Email is not registered");
            }
        }
    }
}
