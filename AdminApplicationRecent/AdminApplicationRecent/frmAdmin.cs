using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using PTSLibraryRecent;

namespace AdminApplicationRecent
{
    public partial class frmAdmin : Form

    {
        private PTSAdminFacade facade;
        private int adminId;
        private Customer[] customers;
        private Project[] projects;
        private Team[] teams;
        private Project selectProject;
        private PTSLibraryRecent.Task[] tasks;
        private Project selectedProject;

        
        public frmAdmin()
        {
            InitializeComponent();
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            facade = (PTSAdminFacade)RemotingServices.Connect(typeof(PTSAdminFacade), "http://localhost:50000/PTSAdminFacade");
            adminId=0;
        }

        private void txtUsername(object sender, EventArgs e)
        {

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                adminId = facade.Authenticate(this.textUsername.Text, this.textPassword.Text);
                if (adminId !=0)
                {
                    this.textUsername.Text = "";
                    this.textPassword.Text = "";
                    MessageBox.Show("Successfully  Logged In ");
                    TabControl1.SelectTab(1);
                    TabControl1.Enabled = true;
                    
                }
                else
                {
                    TabControl1.SelectTab(0);
                    TabControl1.Enabled = false;
                    MessageBox.Show("Wrong Login Details!!! ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;
            if(NameTextBox.Text=="")
            {
                MessageBox.Show("You need to fill in the name field! ");
                return;
            }
            try
            {
                startDate = DateTime.Parse(ExpectedStartTextBox.Text);
                endDate = DateTime.Parse(ExpectedEndtextBox.Text);

            }
            catch(Exception)
            {
                MessageBox.Show("The data(s) are in the wrong format");
                return;
            }
            facade.CreateProject(NameTextBox.Text, startDate, endDate, (int)CustomerComboBox.SelectedValue, adminId);
            NameTextBox.Text = "";
            ExpectedStartTextBox.Text = "";
            ExpectedEndtextBox.Text = "";
            CustomerComboBox.SelectedIndex = 0;
            MessageBox.Show("Project successfully created");
            TabControl2.SelectTab(1);
           


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
           
            customers = facade.GetListOfCustomers();
            CustomerComboBox.DataSource = customers;
            CustomerComboBox.DisplayMember = "Name";
            CustomerComboBox.ValueMember = "id";

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TeamComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void SelectedProjectComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            setProjectDetails();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExpectedStartTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TabControl2_Selected(object sender, TabControlEventArgs e)
        {
            if(TabControl2.SelectedIndex==1)
            {
                projects = facade.GetListOfProjects(adminId);
                SelectedProjectComboBox2.DataSource = projects;
                SelectedProjectComboBox2.DisplayMember = "Name";
                SelectedProjectComboBox2.ValueMember = "ProjectId";
                setProjectDetails();

                teams = facade.GetListOfTeams();
                TeamComboBox.DataSource = teams;
                TeamComboBox.DisplayMember = "Name";
                TeamComboBox.ValueMember = "TeamId";
            }
        }

        private void setProjectDetails()
        {
            selectedProject = projects[SelectedProjectComboBox2.SelectedIndex];

            StartDateLabel.Text = selectedProject.ExpectedStartDate.ToShortDateString();
            EndDateLabel.Text = selectedProject.ExpectedEndDate.ToShortDateString();
            CustomerLabel.Text = ((Customer)selectedProject.TheCustomer).Name;
            UpdatedTasks();
        }

        private void UpdatedTasks()
        {
            tasks = facade.GetListOfTasks(selectedProject.ProjectId);
            IbTasks.DataSource = tasks;
            IbTasks.DisplayMember = "NameAndStatus";
            IbTasks.ValueMember="TaskId";
            //throw new NotImplementedException();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ExpectedStartDate_Click(object sender, EventArgs e)
        {

        }

        private void IbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;
            if (TaskName.Text == "")
            {
                MessageBox.Show("You need to fill in the name field! ");
                return;
            }
            try
            {
                startDate = DateTime.Parse(ExpectedStart.Text);
                endDate = DateTime.Parse(ExpectedEnd.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("The data(s) are in the wrong format");
                return;
            }
            facade.CreateTask(TaskName.Text, startDate, endDate, (int)TeamComboBox.SelectedValue, selectedProject.ProjectId);
            TaskName.Text = "";
            ExpectedStart.Text = "";
            ExpectedEnd.Text = "";
            TeamComboBox.SelectedIndex = 0;
            MessageBox.Show("Task successfully created");
            UpdatedTasks();

        }
    }
}
