namespace Client
{
    partial class Dashboard
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.button_Logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Select_Dashboard = new System.Windows.Forms.Button();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.button1 = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.ForeColor = System.Drawing.Color.Honeydew;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 21;
            this.metroPanel1.Location = new System.Drawing.Point(166, 0);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(523, 26);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 20;
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroButton1.Location = new System.Drawing.Point(498, 0);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(25, 25);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.TabStop = false;
            this.metroButton1.Text = "X";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.metroPanel2.Controls.Add(this.button1);
            this.metroPanel2.Controls.Add(this.button_Logout);
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.Controls.Add(this.button_Select_Dashboard);
            this.metroPanel2.Controls.Add(this.metroButton2);
            this.metroPanel2.ForeColor = System.Drawing.Color.Honeydew;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 21;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(166, 363);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 20;
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(247)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.button_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("Levenim MT", 15F, System.Drawing.FontStyle.Bold);
            this.button_Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.button_Logout.Image = global::Client.Properties.Resources.logout_red;
            this.button_Logout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Logout.Location = new System.Drawing.Point(0, 325);
            this.button_Logout.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(166, 37);
            this.button_Logout.TabIndex = 13;
            this.button_Logout.Text = "Log Out";
            this.button_Logout.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 75);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gyst";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Select_Dashboard
            // 
            this.button_Select_Dashboard.AutoEllipsis = true;
            this.button_Select_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Select_Dashboard.FlatAppearance.BorderSize = 0;
            this.button_Select_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Select_Dashboard.Font = new System.Drawing.Font("Levenim MT", 15F, System.Drawing.FontStyle.Bold);
            this.button_Select_Dashboard.ForeColor = System.Drawing.Color.Honeydew;
            this.button_Select_Dashboard.Image = global::Client.Properties.Resources.monitor;
            this.button_Select_Dashboard.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Select_Dashboard.Location = new System.Drawing.Point(0, 76);
            this.button_Select_Dashboard.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.button_Select_Dashboard.Name = "button_Select_Dashboard";
            this.button_Select_Dashboard.Size = new System.Drawing.Size(166, 37);
            this.button_Select_Dashboard.TabIndex = 10;
            this.button_Select_Dashboard.Text = "Dashboard";
            this.button_Select_Dashboard.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Select_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Select_Dashboard.UseVisualStyleBackColor = true;
            // 
            // metroButton2
            // 
            this.metroButton2.AutoSize = true;
            this.metroButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroButton2.Location = new System.Drawing.Point(406, 0);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(34, 37);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.TabStop = false;
            this.metroButton2.Text = "X";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Levenim MT", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Honeydew;
            this.button1.Image = global::Client.Properties.Resources.monitor;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(0, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Dashboard";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackMaxSize = 700;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(690, 365);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Levenim MT", 15F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(0, 62, 0, 0);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Form1";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button button_Select_Dashboard;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Button button1;
    }
}

