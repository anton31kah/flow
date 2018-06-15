namespace flow
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.completedLevelsLabel = new System.Windows.Forms.Label();
            this.viewStatsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTextbox
            // 
            this.loginTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.loginTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.loginTextbox.BackColor = System.Drawing.Color.Black;
            this.loginTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTextbox.ForeColor = System.Drawing.SystemColors.Control;
            this.loginTextbox.Location = new System.Drawing.Point(810, 105);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(301, 30);
            this.loginTextbox.TabIndex = 0;
            this.loginTextbox.TextChanged += new System.EventHandler(this.loginTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(806, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Black;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.loginButton.Location = new System.Drawing.Point(810, 197);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(301, 66);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Create Profile";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // completedLevelsLabel
            // 
            this.completedLevelsLabel.AutoSize = true;
            this.completedLevelsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedLevelsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.completedLevelsLabel.Location = new System.Drawing.Point(810, 308);
            this.completedLevelsLabel.Name = "completedLevelsLabel";
            this.completedLevelsLabel.Size = new System.Drawing.Size(194, 20);
            this.completedLevelsLabel.TabIndex = 3;
            this.completedLevelsLabel.Text = "Completed Levels: 0/150";
            // 
            // viewStatsButton
            // 
            this.viewStatsButton.BackColor = System.Drawing.Color.Black;
            this.viewStatsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStatsButton.ForeColor = System.Drawing.Color.White;
            this.viewStatsButton.Location = new System.Drawing.Point(810, 369);
            this.viewStatsButton.Name = "viewStatsButton";
            this.viewStatsButton.Size = new System.Drawing.Size(301, 43);
            this.viewStatsButton.TabIndex = 4;
            this.viewStatsButton.Text = "View Stats";
            this.viewStatsButton.UseVisualStyleBackColor = false;
            this.viewStatsButton.Click += new System.EventHandler(this.viewStatsButton_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::flow.Properties.Resources.FLOW;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1123, 450);
            this.Controls.Add(this.viewStatsButton);
            this.Controls.Add(this.completedLevelsLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Flow - Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label completedLevelsLabel;
        private System.Windows.Forms.Button viewStatsButton;
    }
}