namespace Client
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.button_Close = new System.Windows.Forms.Button();
            this.label_Title_Sub = new System.Windows.Forms.Label();
            this.label_Title_Main = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_InvalidLogin = new System.Windows.Forms.Label();
            this.checkBox_Remember = new System.Windows.Forms.CheckBox();
            this.textBox_Password = new MetroFramework.Controls.MetroTextBox();
            this.textBox_Username = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.metroPanel1.Controls.Add(this.button_Close);
            this.metroPanel1.Controls.Add(this.label_Title_Sub);
            this.metroPanel1.Controls.Add(this.label_Title_Main);
            this.metroPanel1.ForeColor = System.Drawing.Color.Honeydew;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 21;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(440, 116);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 20;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(410, 0);
            this.button_Close.Margin = new System.Windows.Forms.Padding(0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 3;
            this.button_Close.TabStop = false;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_Title_Sub
            // 
            this.label_Title_Sub.AutoSize = true;
            this.label_Title_Sub.BackColor = System.Drawing.Color.Transparent;
            this.label_Title_Sub.Font = new System.Drawing.Font("Levenim MT", 15F);
            this.label_Title_Sub.Location = new System.Drawing.Point(142, 78);
            this.label_Title_Sub.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label_Title_Sub.Name = "label_Title_Sub";
            this.label_Title_Sub.Size = new System.Drawing.Size(146, 27);
            this.label_Title_Sub.TabIndex = 1;
            this.label_Title_Sub.Text = "Please Log In.\r\n";
            this.label_Title_Sub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Title_Main
            // 
            this.label_Title_Main.AutoSize = true;
            this.label_Title_Main.BackColor = System.Drawing.Color.Transparent;
            this.label_Title_Main.Font = new System.Drawing.Font("Levenim MT", 25.75F, System.Drawing.FontStyle.Bold);
            this.label_Title_Main.Location = new System.Drawing.Point(168, 15);
            this.label_Title_Main.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label_Title_Main.Name = "label_Title_Main";
            this.label_Title_Main.Size = new System.Drawing.Size(95, 47);
            this.label_Title_Main.TabIndex = 0;
            this.label_Title_Main.Text = "Gyst";
            this.label_Title_Main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.button_Login.FlatAppearance.BorderSize = 0;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Levenim MT", 20F, System.Drawing.FontStyle.Bold);
            this.button_Login.ForeColor = System.Drawing.Color.Honeydew;
            this.button_Login.Location = new System.Drawing.Point(104, 315);
            this.button_Login.Margin = new System.Windows.Forms.Padding(6);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(233, 48);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_InvalidLogin
            // 
            this.label_InvalidLogin.AutoSize = true;
            this.label_InvalidLogin.BackColor = System.Drawing.Color.Transparent;
            this.label_InvalidLogin.Font = new System.Drawing.Font("Levenim MT", 15F, System.Drawing.FontStyle.Bold);
            this.label_InvalidLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.label_InvalidLogin.Image = global::Client.Properties.Resources.warning_red;
            this.label_InvalidLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_InvalidLogin.Location = new System.Drawing.Point(99, 116);
            this.label_InvalidLogin.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label_InvalidLogin.Name = "label_InvalidLogin";
            this.label_InvalidLogin.Size = new System.Drawing.Size(228, 27);
            this.label_InvalidLogin.TabIndex = 3;
            this.label_InvalidLogin.Text = "    Invalid Credentials.";
            this.label_InvalidLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_InvalidLogin.Visible = false;
            // 
            // checkBox_Remember
            // 
            this.checkBox_Remember.AutoSize = true;
            this.checkBox_Remember.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Remember.Checked = true;
            this.checkBox_Remember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Remember.FlatAppearance.BorderSize = 0;
            this.checkBox_Remember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Remember.Image = global::Client.Properties.Resources.monitor;
            this.checkBox_Remember.Location = new System.Drawing.Point(116, 261);
            this.checkBox_Remember.Name = "checkBox_Remember";
            this.checkBox_Remember.Size = new System.Drawing.Size(200, 31);
            this.checkBox_Remember.TabIndex = 2;
            this.checkBox_Remember.Text = "Remember Me";
            this.checkBox_Remember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox_Remember.UseVisualStyleBackColor = false;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            // 
            // 
            // 
            this.textBox_Password.CustomButton.Image = null;
            this.textBox_Password.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.textBox_Password.CustomButton.Name = "";
            this.textBox_Password.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.textBox_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_Password.CustomButton.TabIndex = 1;
            this.textBox_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_Password.CustomButton.UseSelectable = true;
            this.textBox_Password.CustomButton.Visible = false;
            this.textBox_Password.DisplayIcon = true;
            this.textBox_Password.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textBox_Password.Icon = global::Client.Properties.Resources._lock;
            this.textBox_Password.Lines = new string[0];
            this.textBox_Password.Location = new System.Drawing.Point(119, 207);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Password.MaxLength = 32767;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.PromptText = "Password";
            this.textBox_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Password.SelectedText = "";
            this.textBox_Password.SelectionLength = 0;
            this.textBox_Password.SelectionStart = 0;
            this.textBox_Password.ShortcutsEnabled = true;
            this.textBox_Password.Size = new System.Drawing.Size(197, 40);
            this.textBox_Password.TabIndex = 1;
            this.textBox_Password.UseCustomBackColor = true;
            this.textBox_Password.UseCustomForeColor = true;
            this.textBox_Password.UseSelectable = true;
            this.textBox_Password.WaterMark = "Password";
            this.textBox_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.textBox_Password.WaterMarkFont = new System.Drawing.Font("Levenim MT", 15F);
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(79)))));
            // 
            // 
            // 
            this.textBox_Username.CustomButton.Image = null;
            this.textBox_Username.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.textBox_Username.CustomButton.Name = "";
            this.textBox_Username.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.textBox_Username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_Username.CustomButton.TabIndex = 1;
            this.textBox_Username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_Username.CustomButton.UseSelectable = true;
            this.textBox_Username.CustomButton.Visible = false;
            this.textBox_Username.DisplayIcon = true;
            this.textBox_Username.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textBox_Username.Icon = global::Client.Properties.Resources.user_circle;
            this.textBox_Username.Lines = new string[0];
            this.textBox_Username.Location = new System.Drawing.Point(119, 146);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Username.MaxLength = 32767;
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.PasswordChar = '\0';
            this.textBox_Username.PromptText = "Username";
            this.textBox_Username.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Username.SelectedText = "";
            this.textBox_Username.SelectionLength = 0;
            this.textBox_Username.SelectionStart = 0;
            this.textBox_Username.ShortcutsEnabled = true;
            this.textBox_Username.Size = new System.Drawing.Size(197, 40);
            this.textBox_Username.TabIndex = 0;
            this.textBox_Username.UseCustomBackColor = true;
            this.textBox_Username.UseCustomForeColor = true;
            this.textBox_Username.UseSelectable = true;
            this.textBox_Username.WaterMark = "Username";
            this.textBox_Username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.textBox_Username.WaterMarkFont = new System.Drawing.Font("Levenim MT", 15F);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackMaxSize = 700;
            this.ClientSize = new System.Drawing.Size(440, 388);
            this.ControlBox = false;
            this.Controls.Add(this.label_InvalidLogin);
            this.Controls.Add(this.checkBox_Remember);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.metroPanel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Levenim MT", 15F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(0, 62, 0, 0);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Form1";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label_Title_Sub;
        private System.Windows.Forms.Label label_Title_Main;
        private System.Windows.Forms.Button button_Login;
        private MetroFramework.Controls.MetroTextBox textBox_Username;
        private MetroFramework.Controls.MetroTextBox textBox_Password;
        private System.Windows.Forms.CheckBox checkBox_Remember;
        private System.Windows.Forms.Label label_InvalidLogin;
        private System.Windows.Forms.Button button_Close;
    }
}

