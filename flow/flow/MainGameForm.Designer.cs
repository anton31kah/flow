﻿namespace flow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameForm));
			this.resetButton = new System.Windows.Forms.Button();
			this.connectedPipesLabel = new System.Windows.Forms.Label();
			this.elapsedTimeLabel = new System.Windows.Forms.Label();
			this.pipeFinishedLabel = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.logOutButton = new System.Windows.Forms.Button();
			this.continueLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// resetButton
			// 
			this.resetButton.BackColor = System.Drawing.Color.Black;
			this.resetButton.Font = new System.Drawing.Font("Tahoma", 10F);
			this.resetButton.ForeColor = System.Drawing.Color.White;
			this.resetButton.Location = new System.Drawing.Point(525, 168);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(112, 39);
			this.resetButton.TabIndex = 2;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = false;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// connectedPipesLabel
			// 
			this.connectedPipesLabel.AutoSize = true;
			this.connectedPipesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.connectedPipesLabel.ForeColor = System.Drawing.SystemColors.Control;
			this.connectedPipesLabel.Location = new System.Drawing.Point(520, 9);
			this.connectedPipesLabel.Name = "connectedPipesLabel";
			this.connectedPipesLabel.Size = new System.Drawing.Size(102, 25);
			this.connectedPipesLabel.TabIndex = 7;
			this.connectedPipesLabel.Text = "Flows: 0/5";
			// 
			// elapsedTimeLabel
			// 
			this.elapsedTimeLabel.AutoSize = true;
			this.elapsedTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.elapsedTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
			this.elapsedTimeLabel.Location = new System.Drawing.Point(520, 57);
			this.elapsedTimeLabel.Name = "elapsedTimeLabel";
			this.elapsedTimeLabel.Size = new System.Drawing.Size(117, 25);
			this.elapsedTimeLabel.TabIndex = 8;
			this.elapsedTimeLabel.Text = "Time: 00:00";
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
			// saveButton
			// 
			this.saveButton.BackColor = System.Drawing.Color.Black;
			this.saveButton.Font = new System.Drawing.Font("Tahoma", 10F);
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.Location = new System.Drawing.Point(525, 231);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(112, 39);
			this.saveButton.TabIndex = 10;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// logOutButton
			// 
			this.logOutButton.BackColor = System.Drawing.Color.Black;
			this.logOutButton.Font = new System.Drawing.Font("Tahoma", 10F);
			this.logOutButton.ForeColor = System.Drawing.Color.White;
			this.logOutButton.Location = new System.Drawing.Point(525, 293);
			this.logOutButton.Name = "logOutButton";
			this.logOutButton.Size = new System.Drawing.Size(112, 39);
			this.logOutButton.TabIndex = 11;
			this.logOutButton.Text = "Log Out";
			this.logOutButton.UseVisualStyleBackColor = false;
			this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
			// 
			// continueLabel
			// 
			this.continueLabel.AutoSize = true;
			this.continueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.continueLabel.ForeColor = System.Drawing.Color.White;
			this.continueLabel.Location = new System.Drawing.Point(12, 94);
			this.continueLabel.Name = "continueLabel";
			this.continueLabel.Size = new System.Drawing.Size(444, 39);
			this.continueLabel.TabIndex = 12;
			this.continueLabel.Text = "Choose level to start playing";
			// 
			// MainGameForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1040, 500);
			this.Controls.Add(this.continueLabel);
			this.Controls.Add(this.logOutButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.pipeFinishedLabel);
			this.Controls.Add(this.elapsedTimeLabel);
			this.Controls.Add(this.connectedPipesLabel);
			this.Controls.Add(this.resetButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainGameForm";
			this.Text = "Flow - UserName";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGameForm_FormClosing);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainGameForm_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainGameForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainGameForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainGameForm_MouseUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label connectedPipesLabel;
        private System.Windows.Forms.Label elapsedTimeLabel;
        private System.Windows.Forms.Label pipeFinishedLabel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label continueLabel;
    }
}