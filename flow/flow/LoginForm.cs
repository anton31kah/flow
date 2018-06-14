using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace flow
{
    public partial class LoginForm : Form
    {
        public bool GameStarted { get; set; }
        public User User { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            var files = Directory.GetFiles("../../SaveGames");
            foreach (var file in files)
                if (file.EndsWith(".flw"))
                    loginTextbox.AutoCompleteCustomSource.Add(file.Substring(16, file.Length - 20));
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string fileName = loginTextbox.Text;
            if (String.IsNullOrWhiteSpace(fileName))
                return;
            if (loginButton.Text == "Continue Game")
            {
                if (User == null)
                    OpenFile(fileName);
            }
            else
            {
                User user = new User(fileName);
            }
            var mainGameForm = new MainGameForm(user);
            mainGameForm.Show();
            GameStarted = true;
            Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!GameStarted)
                Application.Exit();
        }

        private void loginTextbox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(loginTextbox.Text)) return;
            var files = Directory.GetFiles("../../SaveGames").Select(f => f.Substring(16, f.Length - 20)).ToArray();
            if (files.Contains(loginTextbox.Text))
            {
                loginButton.Text = "Continue Game";
                OpenFile(loginTextbox.Text);
                completedLevelsLabel.Text = $"Completed Levels: {User.CompletedLevels}/150";
            }
            else
                loginButton.Text = "Create Profile";
        }

        public void OpenFile(string fileName)
        {
            if (fileName != null)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream file = File.OpenRead("../../SaveGames/" + fileName + ".flw"))
                    User = (User)formatter.Deserialize(file);
            }
        }
    }
}
