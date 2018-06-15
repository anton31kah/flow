namespace flow
{
    partial class StatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsForm));
            this.statsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // statsListView
            // 
            this.statsListView.BackColor = System.Drawing.Color.Black;
            this.statsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.statsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsListView.ForeColor = System.Drawing.Color.White;
            this.statsListView.GridLines = true;
            this.statsListView.Location = new System.Drawing.Point(0, 0);
            this.statsListView.Name = "statsListView";
            this.statsListView.Size = new System.Drawing.Size(386, 441);
            this.statsListView.TabIndex = 0;
            this.statsListView.UseCompatibleStateImageBehavior = false;
            this.statsListView.View = System.Windows.Forms.View.Details;
            this.statsListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.statsListView_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            this.columnHeader1.Width = 219;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Completed Levels /150";
            this.columnHeader2.Width = 154;
            // 
            // StatsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(386, 441);
            this.Controls.Add(this.statsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StatsForm";
            this.Text = "Stats";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView statsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}