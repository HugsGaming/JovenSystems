using MetroFramework.Forms;
using System.Windows;
using System;

namespace JovenSystems
{
    public partial class LogIn : MetroForm
    {
        public LogIn()
        {
            InitializeComponent();
            pWord.PasswordChar = '*';
        }

        private void LoggingIn(object sender, EventArgs e)
        {
            string username = uNameTxt.Text;
            string password = pWord.Text;
            if(username == "HugsGaming" && password == "markjoven08")
            {
                MainApp main = new MainApp(username, password);
                Hide();
                main.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Try Again", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            ActiveControl = uNameTxt;
        }
    }
}
