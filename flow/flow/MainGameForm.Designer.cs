namespace flow
{
	partial class MainGameForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Panel();
            this.showMenu = new System.Windows.Forms.Button();
            this.connPipes = new System.Windows.Forms.Label();
            this.solvTime = new System.Windows.Forms.Label();
            this.pipeFinishedLabel = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(878, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // menu
            // 
            this.menu.Controls.Add(this.button1);
            this.menu.Controls.Add(this.textBox1);
            this.menu.Controls.Add(this.label1);
            this.menu.Controls.Add(this.button2);
            this.menu.Location = new System.Drawing.Point(494, 220);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(254, 268);
            this.menu.TabIndex = 5;
            this.menu.Visible = false;
            // 
            // showMenu
            // 
            this.showMenu.Location = new System.Drawing.Point(520, 176);
            this.showMenu.Name = "showMenu";
            this.showMenu.Size = new System.Drawing.Size(122, 32);
            this.showMenu.TabIndex = 6;
            this.showMenu.Text = "Show Menu";
            this.showMenu.UseVisualStyleBackColor = true;
            this.showMenu.Click += new System.EventHandler(this.button3_Click);
            // 
            // connPipes
            // 
            this.connPipes.AutoSize = true;
            this.connPipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connPipes.ForeColor = System.Drawing.SystemColors.Control;
            this.connPipes.Location = new System.Drawing.Point(520, 9);
            this.connPipes.Name = "connPipes";
            this.connPipes.Size = new System.Drawing.Size(102, 25);
            this.connPipes.TabIndex = 7;
            this.connPipes.Text = "Flows: 0/5";
            // 
            // solvTime
            // 
            this.solvTime.AutoSize = true;
            this.solvTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solvTime.ForeColor = System.Drawing.SystemColors.Control;
            this.solvTime.Location = new System.Drawing.Point(520, 57);
            this.solvTime.Name = "solvTime";
            this.solvTime.Size = new System.Drawing.Size(117, 25);
            this.solvTime.TabIndex = 8;
            this.solvTime.Text = "Time: 00:00";
            // 
            // pipeFinishedLabel
            // 
            this.pipeFinishedLabel.AutoSize = true;
            this.pipeFinishedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pipeFinishedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.pipeFinishedLabel.Location = new System.Drawing.Point(520, 108);
            this.pipeFinishedLabel.Name = "pipeFinishedLabel";
            this.pipeFinishedLabel.Size = new System.Drawing.Size(91, 25);
            this.pipeFinishedLabel.TabIndex = 9;
            this.pipeFinishedLabel.Text = "Pipe: 0%";
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1040, 500);
            this.Controls.Add(this.pipeFinishedLabel);
            this.Controls.Add(this.solvTime);
            this.Controls.Add(this.connPipes);
            this.Controls.Add(this.showMenu);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainGameForm";
            this.Text = "Flow - UserName";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainGameForm_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseUp);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button showMenu;
        private System.Windows.Forms.Label connPipes;
        private System.Windows.Forms.Label solvTime;
        private System.Windows.Forms.Label pipeFinishedLabel;
    }
}