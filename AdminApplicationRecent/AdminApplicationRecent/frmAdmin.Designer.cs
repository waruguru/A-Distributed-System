namespace AdminApplicationRecent
{
    partial class frmAdmin
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
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.Usernamelabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.WelcomeTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectsTabPage = new System.Windows.Forms.TabPage();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.NewTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.ExpectedEndtextBox = new System.Windows.Forms.TextBox();
            this.ExpectedStartTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CustomeLabel = new System.Windows.Forms.Label();
            this.ExpectedEndLabel = new System.Windows.Forms.Label();
            this.ExpectedStartlabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.TasksTabPage = new System.Windows.Forms.TabPage();
            this.ExistingProjectsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IbTasks = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.TeamComboBox = new System.Windows.Forms.ComboBox();
            this.ExpectedEnd = new System.Windows.Forms.TextBox();
            this.ExpectedStart = new System.Windows.Forms.TextBox();
            this.Teamlabel7 = new System.Windows.Forms.Label();
            this.ExpectedEndlabel6 = new System.Windows.Forms.Label();
            this.ExpectedStartLabel5 = new System.Windows.Forms.Label();
            this.NameLabel4 = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.SelectedProjectComboBox2 = new System.Windows.Forms.ComboBox();
            this.SelectProjectlabel12 = new System.Windows.Forms.Label();
            this.ExpectedStartDate = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.ExpectedEndLabel10 = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.Customerlabel13 = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.WelcomeTabPage.SuspendLayout();
            this.ProjectsTabPage.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.NewTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TasksTabPage.SuspendLayout();
            this.ExistingProjectsGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(81, 27);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(122, 20);
            this.textUsername.TabIndex = 0;
            this.textUsername.TextChanged += new System.EventHandler(this.txtUsername);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(299, 32);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(120, 20);
            this.textPassword.TabIndex = 1;
            // 
            // Usernamelabel
            // 
            this.Usernamelabel.AutoSize = true;
            this.Usernamelabel.Location = new System.Drawing.Point(12, 35);
            this.Usernamelabel.Name = "Usernamelabel";
            this.Usernamelabel.Size = new System.Drawing.Size(55, 13);
            this.Usernamelabel.TabIndex = 2;
            this.Usernamelabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(240, 35);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(474, 32);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.WelcomeTabPage);
            this.TabControl1.Controls.Add(this.ProjectsTabPage);
            this.TabControl1.Enabled = false;
            this.TabControl1.Location = new System.Drawing.Point(12, 85);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(918, 376);
            this.TabControl1.TabIndex = 5;
            this.TabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // WelcomeTabPage
            // 
            this.WelcomeTabPage.Controls.Add(this.label2);
            this.WelcomeTabPage.Controls.Add(this.label1);
            this.WelcomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.WelcomeTabPage.Name = "WelcomeTabPage";
            this.WelcomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.WelcomeTabPage.Size = new System.Drawing.Size(910, 350);
            this.WelcomeTabPage.TabIndex = 0;
            this.WelcomeTabPage.Tag = "Welcome";
            this.WelcomeTabPage.Text = "Welcome";
            this.WelcomeTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "In order to start using the tool, you must log in  using the fields above";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = " Welcome to the Administrator Tool";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProjectsTabPage
            // 
            this.ProjectsTabPage.Controls.Add(this.TabControl2);
            this.ProjectsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ProjectsTabPage.Name = "ProjectsTabPage";
            this.ProjectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProjectsTabPage.Size = new System.Drawing.Size(910, 350);
            this.ProjectsTabPage.TabIndex = 1;
            this.ProjectsTabPage.Text = "Projects";
            this.ProjectsTabPage.UseVisualStyleBackColor = true;
            this.ProjectsTabPage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.NewTabPage);
            this.TabControl2.Controls.Add(this.TasksTabPage);
            this.TabControl2.Location = new System.Drawing.Point(19, 16);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(885, 338);
            this.TabControl2.TabIndex = 0;
            this.TabControl2.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl2_Selected);
            // 
            // NewTabPage
            // 
            this.NewTabPage.Controls.Add(this.groupBox1);
            this.NewTabPage.Location = new System.Drawing.Point(4, 22);
            this.NewTabPage.Name = "NewTabPage";
            this.NewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NewTabPage.Size = new System.Drawing.Size(877, 312);
            this.NewTabPage.TabIndex = 0;
            this.NewTabPage.Text = "New";
            this.NewTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.CustomerComboBox);
            this.groupBox1.Controls.Add(this.ExpectedEndtextBox);
            this.groupBox1.Controls.Add(this.ExpectedStartTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.CustomeLabel);
            this.groupBox1.Controls.Add(this.ExpectedEndLabel);
            this.groupBox1.Controls.Add(this.ExpectedStartlabel);
            this.groupBox1.Controls.Add(this.Namelabel);
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Project";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(35, 136);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(90, 109);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(104, 21);
            this.CustomerComboBox.TabIndex = 7;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // ExpectedEndtextBox
            // 
            this.ExpectedEndtextBox.Location = new System.Drawing.Point(94, 82);
            this.ExpectedEndtextBox.Name = "ExpectedEndtextBox";
            this.ExpectedEndtextBox.Size = new System.Drawing.Size(100, 20);
            this.ExpectedEndtextBox.TabIndex = 6;
            // 
            // ExpectedStartTextBox
            // 
            this.ExpectedStartTextBox.Location = new System.Drawing.Point(94, 56);
            this.ExpectedStartTextBox.Name = "ExpectedStartTextBox";
            this.ExpectedStartTextBox.Size = new System.Drawing.Size(100, 20);
            this.ExpectedStartTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(94, 26);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // CustomeLabel
            // 
            this.CustomeLabel.AutoSize = true;
            this.CustomeLabel.Location = new System.Drawing.Point(11, 109);
            this.CustomeLabel.Name = "CustomeLabel";
            this.CustomeLabel.Size = new System.Drawing.Size(51, 13);
            this.CustomeLabel.TabIndex = 3;
            this.CustomeLabel.Text = "Customer";
            // 
            // ExpectedEndLabel
            // 
            this.ExpectedEndLabel.AutoSize = true;
            this.ExpectedEndLabel.Location = new System.Drawing.Point(11, 82);
            this.ExpectedEndLabel.Name = "ExpectedEndLabel";
            this.ExpectedEndLabel.Size = new System.Drawing.Size(74, 13);
            this.ExpectedEndLabel.TabIndex = 2;
            this.ExpectedEndLabel.Text = "Expected End";
            // 
            // ExpectedStartlabel
            // 
            this.ExpectedStartlabel.AutoSize = true;
            this.ExpectedStartlabel.Location = new System.Drawing.Point(11, 56);
            this.ExpectedStartlabel.Name = "ExpectedStartlabel";
            this.ExpectedStartlabel.Size = new System.Drawing.Size(77, 13);
            this.ExpectedStartlabel.TabIndex = 1;
            this.ExpectedStartlabel.Text = "Expected Start";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(9, 29);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(35, 13);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Name";
            // 
            // TasksTabPage
            // 
            this.TasksTabPage.Controls.Add(this.ExistingProjectsGroupBox);
            this.TasksTabPage.Location = new System.Drawing.Point(4, 22);
            this.TasksTabPage.Name = "TasksTabPage";
            this.TasksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TasksTabPage.Size = new System.Drawing.Size(877, 312);
            this.TasksTabPage.TabIndex = 1;
            this.TasksTabPage.Text = "Tasks";
            this.TasksTabPage.UseVisualStyleBackColor = true;
            this.TasksTabPage.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // ExistingProjectsGroupBox
            // 
            this.ExistingProjectsGroupBox.Controls.Add(this.groupBox2);
            this.ExistingProjectsGroupBox.Controls.Add(this.groupBox3);
            this.ExistingProjectsGroupBox.Controls.Add(this.SelectedProjectComboBox2);
            this.ExistingProjectsGroupBox.Controls.Add(this.SelectProjectlabel12);
            this.ExistingProjectsGroupBox.Controls.Add(this.ExpectedStartDate);
            this.ExistingProjectsGroupBox.Controls.Add(this.EndDateLabel);
            this.ExistingProjectsGroupBox.Controls.Add(this.CustomerLabel);
            this.ExistingProjectsGroupBox.Controls.Add(this.ExpectedEndLabel10);
            this.ExistingProjectsGroupBox.Controls.Add(this.StartDateLabel);
            this.ExistingProjectsGroupBox.Controls.Add(this.Customerlabel13);
            this.ExistingProjectsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.ExistingProjectsGroupBox.Name = "ExistingProjectsGroupBox";
            this.ExistingProjectsGroupBox.Size = new System.Drawing.Size(841, 290);
            this.ExistingProjectsGroupBox.TabIndex = 0;
            this.ExistingProjectsGroupBox.TabStop = false;
            this.ExistingProjectsGroupBox.Text = "Existing Projects";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IbTasks);
            this.groupBox2.Location = new System.Drawing.Point(296, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 129);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tasks";
            // 
            // IbTasks
            // 
            this.IbTasks.FormattingEnabled = true;
            this.IbTasks.Location = new System.Drawing.Point(15, 19);
            this.IbTasks.Name = "IbTasks";
            this.IbTasks.Size = new System.Drawing.Size(508, 95);
            this.IbTasks.TabIndex = 17;
            this.IbTasks.SelectedIndexChanged += new System.EventHandler(this.IbTasks_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddTaskBtn);
            this.groupBox3.Controls.Add(this.TeamComboBox);
            this.groupBox3.Controls.Add(this.ExpectedEnd);
            this.groupBox3.Controls.Add(this.ExpectedStart);
            this.groupBox3.Controls.Add(this.Teamlabel7);
            this.groupBox3.Controls.Add(this.ExpectedEndlabel6);
            this.groupBox3.Controls.Add(this.ExpectedStartLabel5);
            this.groupBox3.Controls.Add(this.NameLabel4);
            this.groupBox3.Controls.Add(this.TaskName);
            this.groupBox3.Location = new System.Drawing.Point(6, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 161);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Task";
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.Location = new System.Drawing.Point(89, 129);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(75, 23);
            this.AddTaskBtn.TabIndex = 16;
            this.AddTaskBtn.Text = "Add";
            this.AddTaskBtn.UseVisualStyleBackColor = true;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTaskBtn_Click);
            // 
            // TeamComboBox
            // 
            this.TeamComboBox.FormattingEnabled = true;
            this.TeamComboBox.Location = new System.Drawing.Point(133, 101);
            this.TeamComboBox.Name = "TeamComboBox";
            this.TeamComboBox.Size = new System.Drawing.Size(121, 21);
            this.TeamComboBox.TabIndex = 14;
            this.TeamComboBox.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox1_SelectedIndexChanged);
            // 
            // ExpectedEnd
            // 
            this.ExpectedEnd.Location = new System.Drawing.Point(133, 69);
            this.ExpectedEnd.Name = "ExpectedEnd";
            this.ExpectedEnd.Size = new System.Drawing.Size(121, 20);
            this.ExpectedEnd.TabIndex = 11;
            // 
            // ExpectedStart
            // 
            this.ExpectedStart.Location = new System.Drawing.Point(133, 37);
            this.ExpectedStart.Name = "ExpectedStart";
            this.ExpectedStart.Size = new System.Drawing.Size(121, 20);
            this.ExpectedStart.TabIndex = 13;
            this.ExpectedStart.TextChanged += new System.EventHandler(this.ExpectedStartTextBox4_TextChanged);
            // 
            // Teamlabel7
            // 
            this.Teamlabel7.AutoSize = true;
            this.Teamlabel7.Location = new System.Drawing.Point(19, 104);
            this.Teamlabel7.Name = "Teamlabel7";
            this.Teamlabel7.Size = new System.Drawing.Size(34, 13);
            this.Teamlabel7.TabIndex = 4;
            this.Teamlabel7.Text = "Team";
            // 
            // ExpectedEndlabel6
            // 
            this.ExpectedEndlabel6.AutoSize = true;
            this.ExpectedEndlabel6.Location = new System.Drawing.Point(19, 69);
            this.ExpectedEndlabel6.Name = "ExpectedEndlabel6";
            this.ExpectedEndlabel6.Size = new System.Drawing.Size(74, 13);
            this.ExpectedEndlabel6.TabIndex = 3;
            this.ExpectedEndlabel6.Text = "Expected End";
            // 
            // ExpectedStartLabel5
            // 
            this.ExpectedStartLabel5.AutoSize = true;
            this.ExpectedStartLabel5.Location = new System.Drawing.Point(19, 37);
            this.ExpectedStartLabel5.Name = "ExpectedStartLabel5";
            this.ExpectedStartLabel5.Size = new System.Drawing.Size(77, 13);
            this.ExpectedStartLabel5.TabIndex = 2;
            this.ExpectedStartLabel5.Text = "Expected Start";
            // 
            // NameLabel4
            // 
            this.NameLabel4.AutoSize = true;
            this.NameLabel4.Location = new System.Drawing.Point(19, 16);
            this.NameLabel4.Name = "NameLabel4";
            this.NameLabel4.Size = new System.Drawing.Size(35, 13);
            this.NameLabel4.TabIndex = 1;
            this.NameLabel4.Text = "Name";
            // 
            // TaskName
            // 
            this.TaskName.Location = new System.Drawing.Point(133, 9);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(121, 20);
            this.TaskName.TabIndex = 12;
            // 
            // SelectedProjectComboBox2
            // 
            this.SelectedProjectComboBox2.FormattingEnabled = true;
            this.SelectedProjectComboBox2.Location = new System.Drawing.Point(139, 18);
            this.SelectedProjectComboBox2.Name = "SelectedProjectComboBox2";
            this.SelectedProjectComboBox2.Size = new System.Drawing.Size(93, 21);
            this.SelectedProjectComboBox2.TabIndex = 15;
            this.SelectedProjectComboBox2.SelectedIndexChanged += new System.EventHandler(this.SelectedProjectComboBox2_SelectedIndexChanged);
            // 
            // SelectProjectlabel12
            // 
            this.SelectProjectlabel12.AutoSize = true;
            this.SelectProjectlabel12.Location = new System.Drawing.Point(9, 26);
            this.SelectProjectlabel12.Name = "SelectProjectlabel12";
            this.SelectProjectlabel12.Size = new System.Drawing.Size(73, 13);
            this.SelectProjectlabel12.TabIndex = 9;
            this.SelectProjectlabel12.Text = "Select Project";
            // 
            // ExpectedStartDate
            // 
            this.ExpectedStartDate.AutoSize = true;
            this.ExpectedStartDate.Location = new System.Drawing.Point(267, 26);
            this.ExpectedStartDate.Name = "ExpectedStartDate";
            this.ExpectedStartDate.Size = new System.Drawing.Size(77, 13);
            this.ExpectedStartDate.TabIndex = 0;
            this.ExpectedStartDate.Text = "ExpectedStart:";
            this.ExpectedStartDate.Click += new System.EventHandler(this.ExpectedStartDate_Click);
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.Location = new System.Drawing.Point(691, 28);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(87, 18);
            this.EndDateLabel.TabIndex = 5;
            this.EndDateLabel.Text = "|bEndDate";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(393, 63);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(90, 16);
            this.CustomerLabel.TabIndex = 6;
            this.CustomerLabel.Text = "|b|Customer";
            // 
            // ExpectedEndLabel10
            // 
            this.ExpectedEndLabel10.AutoSize = true;
            this.ExpectedEndLabel10.Location = new System.Drawing.Point(559, 28);
            this.ExpectedEndLabel10.Name = "ExpectedEndLabel10";
            this.ExpectedEndLabel10.Size = new System.Drawing.Size(77, 13);
            this.ExpectedEndLabel10.TabIndex = 7;
            this.ExpectedEndLabel10.Text = "Expected End:";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(393, 26);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(83, 15);
            this.StartDateLabel.TabIndex = 8;
            this.StartDateLabel.Text = "|b|StartDate";
            this.StartDateLabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // Customerlabel13
            // 
            this.Customerlabel13.AutoSize = true;
            this.Customerlabel13.Location = new System.Drawing.Point(261, 63);
            this.Customerlabel13.Name = "Customerlabel13";
            this.Customerlabel13.Size = new System.Drawing.Size(54, 13);
            this.Customerlabel13.TabIndex = 10;
            this.Customerlabel13.Text = "Customer:";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 495);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.Usernamelabel);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Name = "frmAdmin";
            this.Text = "Administrator Tool";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.TabControl1.ResumeLayout(false);
            this.WelcomeTabPage.ResumeLayout(false);
            this.WelcomeTabPage.PerformLayout();
            this.ProjectsTabPage.ResumeLayout(false);
            this.TabControl2.ResumeLayout(false);
            this.NewTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TasksTabPage.ResumeLayout(false);
            this.ExistingProjectsGroupBox.ResumeLayout(false);
            this.ExistingProjectsGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label Usernamelabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage WelcomeTabPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage ProjectsTabPage;
        private System.Windows.Forms.TabControl TabControl2;
        private System.Windows.Forms.TabPage NewTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.TextBox ExpectedEndtextBox;
        private System.Windows.Forms.TextBox ExpectedStartTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label CustomeLabel;
        private System.Windows.Forms.Label ExpectedEndLabel;
        private System.Windows.Forms.Label ExpectedStartlabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TabPage TasksTabPage;
        private System.Windows.Forms.GroupBox ExistingProjectsGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox IbTasks;
        private System.Windows.Forms.Button AddTaskBtn;
        private System.Windows.Forms.ComboBox SelectedProjectComboBox2;
        private System.Windows.Forms.ComboBox TeamComboBox;
        private System.Windows.Forms.TextBox ExpectedStart;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.TextBox ExpectedEnd;
        private System.Windows.Forms.Label Customerlabel13;
        private System.Windows.Forms.Label SelectProjectlabel12;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label ExpectedEndLabel10;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label Teamlabel7;
        private System.Windows.Forms.Label ExpectedEndlabel6;
        private System.Windows.Forms.Label ExpectedStartLabel5;
        private System.Windows.Forms.Label NameLabel4;
        private System.Windows.Forms.Label ExpectedStartDate;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

