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

namespace flow
{
    public partial class LoginForm : Form
    {
        public bool GameStarted { get; set; }

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
            if (loginButton.Text == "Continue Game")
            {
                var mainGameForm = new MainGameForm();
                mainGameForm.Show();
                GameStarted = true;
                Close();
            }
            else
            {
                // create user and append to users
            }
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
                loginButton.Text = "Continue Game";
            else
                loginButton.Text = "Create Profile";
        }
    }
}
