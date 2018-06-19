using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using IOPath = System.IO.Path;

namespace flow
{
    public partial class LoginForm : Form
    {
        public readonly string PATH = @"%USERPROFILE%\Documents\flow";
        public bool GameStarted { get; set; }
        public User User { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            PATH = Environment.ExpandEnvironmentVariables(PATH);
            Directory.CreateDirectory(PATH);
            var files = Directory.GetFiles(PATH);
            foreach (var file in files)
                if (file.EndsWith(".flw"))
                    loginTextbox.AutoCompleteCustomSource.Add(IOPath.GetFileNameWithoutExtension(file));
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
                User = new User(fileName);
            }
            var mainGameForm = new MainGameForm(User);
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
            var files = Directory.GetFiles(PATH).Select(f => IOPath.GetFileNameWithoutExtension(f)).ToArray();
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
                using (FileStream file = File.OpenRead($@"{PATH}\{fileName}.flw"))
                    User = (User)formatter.Deserialize(file);
            }
        }

        private void viewStatsButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> stats = new Dictionary<string, int>();
            var files = Directory.GetFiles(PATH);
            foreach (var file in files)
                if (file.EndsWith(".flw"))
                {
                    User user;
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fileStream = File.OpenRead(file))
                        user = (User)formatter.Deserialize(fileStream);
                    stats[IOPath.GetFileNameWithoutExtension(file)] = user.CompletedLevels;
                }
            StatsForm statsForm = new StatsForm(stats);
            statsForm.ShowDialog();
        }
    }
}
