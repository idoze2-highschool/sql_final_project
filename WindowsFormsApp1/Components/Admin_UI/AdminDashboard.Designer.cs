namespace Client.Components.Admin_UI
{
    partial class AdminDashboard
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
            this.label_Logo = new System.Windows.Forms.Label();
            this.button_Logout = new System.Windows.Forms.Button();
            this.panel_MenuButtons = new MetroFramework.Controls.MetroPanel();
            this.button_Select_Subjects = new System.Windows.Forms.Button();
            this.button_Select_Dashboard = new System.Windows.Forms.Button();
            this.button_Select_Groups = new System.Windows.Forms.Button();
            this.button_Select_Users = new System.Windows.Forms.Button();
            this.button_Select_Courses = new System.Windows.Forms.Button();
            this.panel_Menu = new MetroFramework.Controls.MetroPanel();
            this.panel_ViewArea = new MetroFramework.Controls.MetroPanel();
            this.panel_MenuButtons.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Logo
            // 
            this.label_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.label_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Logo.Font = new System.Drawing.Font("Levenim MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Logo.Location = new System.Drawing.Point(0, 0);
            this.label_Logo.Margin = new System.Windows.Forms.Padding(0);
            this.label_Logo.Name = "label_Logo";
            this.label_Logo.Size = new System.Drawing.Size(166, 60);
            this.label_Logo.TabIndex = 11;
            this.label_Logo.Text = "Gyst";
            this.label_Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(247)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.button_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("Levenim MT", 15F, System.Drawing.FontStyle.Bold);
            this.button_Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.button_Logout.Image = global::Client.Properties.Resources.logout_red;
            this.button_Logout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Logout.Location = new System.Drawing.Point(0, 283);
            this.button_Logout.Margin = new System.Windows.Forms.Padding(0);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(166, 37);
            this.button_Logout.TabIndex = 13;
            this.button_Logout.Text = "Log Out";
            this.button_Logout.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // panel_MenuButtons
            // 
            this.panel_MenuButtons.AutoSize = true;
            this.panel_MenuButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_MenuButtons.BackColor = System.Drawing.Color.Transparent;
            this.panel_MenuButtons.Controls.Add(this.button_Select_Subjects);
            this.panel_MenuButtons.Controls.Add(this.button_Select_Dashboard);
            this.panel_MenuButtons.Controls.Add(this.button_Select_Groups);
            this.panel_MenuButtons.Controls.Add(this.button_Select_Users);
            this.panel_MenuButtons.Controls.Add(this.button_Select_Courses);
            this.panel_MenuButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MenuButtons.HorizontalScrollbarBarColor = true;
            this.panel_MenuButtons.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_MenuButtons.HorizontalScrollbarSize = 10;
            this.panel_MenuButtons.Location = new System.Drawing.Point(0, 60);
            this.panel_MenuButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panel_MenuButtons.Name = "panel_MenuButtons";
            this.panel_MenuButtons.Size = new System.Drawing.Size(166, 223);
            this.panel_MenuButtons.TabIndex = 2;
            this.panel_MenuButtons.UseCustomBackColor = true;
            this.panel_MenuButtons.UseCustomForeColor = true;
            this.panel_MenuButtons.VerticalScrollbarBarColor = true;
            this.panel_MenuButtons.VerticalScrollbarHighlightOnWheel = false;
            this.panel_MenuButtons.VerticalScrollbarSize = 10;
            // 
            // button_Select_Subjects
            // 
            this.button_Select_Subjects.AutoEllipsis = true;
            this.button_Select_Subjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Subjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Select_Subjects.FlatAppearance.BorderSize = 0;
            this.button_Select_Subjects.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Subjects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Subjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Subjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Select_Subjects.Font = new System.Drawing.Font("Levenim MT", 15F, System.Drawing.FontStyle.Bold);
            this.button_Select_Subjects.ForeColor = System.Drawing.Color.Honeydew;
            this.button_Select_Subjects.Image = global::Client.Properties.Resources.monitor;
            this.button_Select_Subjects.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Select_Subjects.Location = new System.Drawing.Point(0, 157);
            this.button_Select_Subjects.Margin = new System.Windows.Forms.Padding(0);
            this.button_Select_Subjects.Name = "button_Select_Subjects";
            this.button_Select_Subjects.Size = new System.Drawing.Size(166, 37);
            this.button_Select_Subjects.TabIndex = 4;
            this.button_Select_Subjects.Text = "Subjects";
            this.button_Select_Subjects.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Select_Subjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Select_Subjects.UseVisualStyleBackColor = false;
            this.button_Select_Subjects.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // button_Select_Dashboard
            // 
            this.button_Select_Dashboard.AutoEllipsis = true;
            this.button_Select_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Select_Dashboard.FlatAppearance.BorderSize = 0;
            this.button_Select_Dashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Select_Dashboard.Font = new System.Drawing.Font("Levenim MT", 15F, System.Drawing.FontStyle.Bold);
            this.button_Select_Dashboard.ForeColor = System.Drawing.Color.Honeydew;
            this.button_Select_Dashboard.Image = global::Client.Properties.Resources.monitor;
            this.button_Select_Dashboard.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Select_Dashboard.Location = new System.Drawing.Point(0, 1);
            this.button_Select_Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.button_Select_Dashboard.Name = "button_Select_Dashboard";
            this.button_Select_Dashboard.Size = new System.Drawing.Size(166, 37);
            this.button_Select_Dashboard.TabIndex = 0;
            this.button_Select_Dashboard.Text = "Dashboard";
            this.button_Select_Dashboard.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Select_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Select_Dashboard.UseVisualStyleBackColor = false;
            this.button_Select_Dashboard.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // button_Select_Groups
            // 
            this.button_Select_Groups.AutoEllipsis = true;
            this.button_Select_Groups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Groups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Select_Groups.FlatAppearance.BorderSize = 0;
            this.button_Select_Groups.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Groups.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Groups.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Groups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Select_Groups.Font = new System.Drawing.Font("Levenim MT", 15F, System.Drawing.FontStyle.Bold);
            this.button_Select_Groups.ForeColor = System.Drawing.Color.Honeydew;
            this.button_Select_Groups.Image = global::Client.Properties.Resources.monitor;
            this.button_Select_Groups.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Select_Groups.Location = new System.Drawing.Point(0, 118);
            this.button_Select_Groups.Margin = new System.Windows.Forms.Padding(0);
            this.button_Select_Groups.Name = "button_Select_Groups";
            this.button_Select_Groups.Size = new System.Drawing.Size(166, 37);
            this.button_Select_Groups.TabIndex = 3;
            this.button_Select_Groups.Text = "Groups";
            this.button_Select_Groups.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Select_Groups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Select_Groups.UseVisualStyleBackColor = false;
            this.button_Select_Groups.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // button_Select_Users
            // 
            this.button_Select_Users.AutoEllipsis = true;
            this.button_Select_Users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Select_Users.FlatAppearance.BorderSize = 0;
            this.button_Select_Users.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Users.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Users.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Select_Users.Font = new System.Drawing.Font("Levenim MT", 15F, System.Drawing.FontStyle.Bold);
            this.button_Select_Users.ForeColor = System.Drawing.Color.Honeydew;
            this.button_Select_Users.Image = global::Client.Properties.Resources.monitor;
            this.button_Select_Users.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Select_Users.Location = new System.Drawing.Point(0, 40);
            this.button_Select_Users.Margin = new System.Windows.Forms.Padding(0);
            this.button_Select_Users.Name = "button_Select_Users";
            this.button_Select_Users.Size = new System.Drawing.Size(166, 37);
            this.button_Select_Users.TabIndex = 1;
            this.button_Select_Users.Text = "Users";
            this.button_Select_Users.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Select_Users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Select_Users.UseVisualStyleBackColor = false;
            this.button_Select_Users.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // button_Select_Courses
            // 
            this.button_Select_Courses.AutoEllipsis = true;
            this.button_Select_Courses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Courses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Select_Courses.FlatAppearance.BorderSize = 0;
            this.button_Select_Courses.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Courses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Courses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            this.button_Select_Courses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Select_Courses.Font = new System.Drawing.Font("Levenim MT", 15F, System.Drawing.FontStyle.Bold);
            this.button_Select_Courses.ForeColor = System.Drawing.Color.Honeydew;
            this.button_Select_Courses.Image = global::Client.Properties.Resources.monitor;
            this.button_Select_Courses.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Select_Courses.Location = new System.Drawing.Point(0, 79);
            this.button_Select_Courses.Margin = new System.Windows.Forms.Padding(0);
            this.button_Select_Courses.Name = "button_Select_Courses";
            this.button_Select_Courses.Size = new System.Drawing.Size(166, 37);
            this.button_Select_Courses.TabIndex = 2;
            this.button_Select_Courses.Text = "Courses";
            this.button_Select_Courses.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Select_Courses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Select_Courses.UseVisualStyleBackColor = false;
            this.button_Select_Courses.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.AutoSize = true;
            this.panel_Menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel_Menu.Controls.Add(this.panel_MenuButtons);
            this.panel_Menu.Controls.Add(this.button_Logout);
            this.panel_Menu.Controls.Add(this.label_Logo);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.ForeColor = System.Drawing.Color.Honeydew;
            this.panel_Menu.HorizontalScrollbarBarColor = true;
            this.panel_Menu.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_Menu.HorizontalScrollbarSize = 21;
            this.panel_Menu.Location = new System.Drawing.Point(0, 30);
            this.panel_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Menu.MinimumSize = new System.Drawing.Size(166, 320);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(166, 320);
            this.panel_Menu.Style = MetroFramework.MetroColorStyle.Blue;
            this.panel_Menu.TabIndex = 3;
            this.panel_Menu.UseCustomBackColor = true;
            this.panel_Menu.UseCustomForeColor = true;
            this.panel_Menu.VerticalScrollbarBarColor = true;
            this.panel_Menu.VerticalScrollbarHighlightOnWheel = false;
            this.panel_Menu.VerticalScrollbarSize = 20;
            // 
            // panel_ViewArea
            // 
            this.panel_ViewArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_ViewArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_ViewArea.HorizontalScrollbarBarColor = true;
            this.panel_ViewArea.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_ViewArea.HorizontalScrollbarSize = 10;
            this.panel_ViewArea.Location = new System.Drawing.Point(166, 30);
            this.panel_ViewArea.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ViewArea.MinimumSize = new System.Drawing.Size(100, 100);
            this.panel_ViewArea.Name = "panel_ViewArea";
            this.panel_ViewArea.Size = new System.Drawing.Size(434, 320);
            this.panel_ViewArea.TabIndex = 4;
            this.panel_ViewArea.UseCustomBackColor = true;
            this.panel_ViewArea.VerticalScrollbarBarColor = true;
            this.panel_ViewArea.VerticalScrollbarHighlightOnWheel = false;
            this.panel_ViewArea.VerticalScrollbarSize = 10;
            // 
            // AdminDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.panel_ViewArea);
            this.Controls.Add(this.panel_Menu);
            this.DisplayHeader = false;
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Levenim MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDashboard";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "a";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.panel_MenuButtons.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Logo;
        private System.Windows.Forms.Button button_Logout;
        private MetroFramework.Controls.MetroPanel panel_MenuButtons;
        private System.Windows.Forms.Button button_Select_Subjects;
        private System.Windows.Forms.Button button_Select_Dashboard;
        private System.Windows.Forms.Button button_Select_Groups;
        private System.Windows.Forms.Button button_Select_Users;
        private System.Windows.Forms.Button button_Select_Courses;
        private MetroFramework.Controls.MetroPanel panel_Menu;
        private MetroFramework.Controls.MetroPanel panel_ViewArea;
    }
}

