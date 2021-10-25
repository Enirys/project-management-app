using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeProjets
{
    public partial class main : Form
    {
        string req;

        int project_id = 0;

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
                projectsDG.DataSource = GetProjectList();
                InProgressDG.DataSource = GetInProgressTasks();
                PausedDG.DataSource = GetPausedTasks();
                NoneDG.DataSource = GetNoneTasks();
                cmbProject.SelectedItem = "None";
                if (projectsDG.RowCount > 0)
                {
                    project_id = int.Parse(projectsDG.Rows[0].Cells[0].Value.ToString());
                }
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnHomeMenu_Click_1(object sender, EventArgs e)
        {
            HomeActive(true);
            ProjectsActive(false);
            DashboardActive(false);
        }
        private void btnMenuProjects_Click(object sender, EventArgs e)
        {
            HomeActive(false);
            ProjectsActive(true);
            DashboardActive(false);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HomeActive(false);
            ProjectsActive(false);
            DashboardActive(true);

            InProgressDG.DataSource = GetInProgressTasks();
            PausedDG.DataSource = GetPausedTasks();
            NoneDG.DataSource = GetNoneTasks();
        }

        private void HomeActive(bool active)
        {
            panHomeSelect.Visible = active;
            panHomeTitle.Visible = active;
            panHome.Visible = active;
        }
        private void ProjectsActive(bool active)
        {
            panProjects.Visible = active;
            panProjectsSelect.Visible = active;
            panProjectsTitle.Visible = active;
        }
        private void DashboardActive(bool active)
        {
            panDashboard.Visible = active;
            panDashBoardSelect.Visible = active;
            panDashboardTitle.Visible = active;
        }
        
        private DataTable GetProjectList()
        {
                DataTable dtProjects = new DataTable();
                req = "SELECT project_id AS ID,project_title AS Title,project_description AS Description,project_status AS Status,project_deadline AS Deadline,project_client AS Client FROM project";
                MysqlController controller = new MysqlController(req);
                dtProjects.Load(controller.reader);
                return dtProjects;
        }
        private DataTable GetInProgressTasks()
        {

                DataTable dtTasks = new DataTable();
                req = "SELECT T.task_title AS Task,T.task_deadline AS Deadline,P.project_title AS Project FROM task T, project P WHERE T.task_status ='In Progress' AND T.project_id = P.project_id;";
                MysqlController controller = new MysqlController(req);

                dtTasks.Load(controller.reader);
                return dtTasks;
        }
        private DataTable GetPausedTasks()
        {

                DataTable dtTasks = new DataTable();
                req = "SELECT T.task_title AS Task,T.task_deadline AS Deadline,P.project_title AS Project FROM task T, project P WHERE T.task_status ='Paused' AND T.project_id = P.project_id;";
                MysqlController controller = new MysqlController(req);

                dtTasks.Load(controller.reader);

                return dtTasks;
        }
        private DataTable GetNoneTasks()
        {
                DataTable dtTasks = new DataTable();
                req = "SELECT T.task_title AS Task,T.task_deadline AS Deadline,P.project_title AS Project FROM task T, project P WHERE T.task_status ='None' AND T.project_id = P.project_id;";
                MysqlController controller = new MysqlController(req);
                dtTasks.Load(controller.reader);
                return dtTasks;
        }

        private void btnAddProject_Click_1(object sender, EventArgs e)
        {
            if ((txtProjectName.Text == string.Empty) || (txtProjectName.Text == "Project Name"))
            {
                txtProjectName.Select();
                MessageBox.Show("You should specify a name for your project.", "Warning");
            }
            else
            {
                Project project = new Project(txtProjectName.Text, txtDescription.Text, cmbProject.SelectedItem.ToString(), calendar.Value.Date, txtClient.Text);
                project.AddProject();
                MessageBox.Show("Successfully submitted", "Add");
                Clear();
                projectsDG.DataSource = GetProjectList();
            }
        }
        private void btnDeleteProject_Click_1(object sender, EventArgs e)
        {
            Project project = new Project(int.Parse(projectsDG.CurrentRow.Cells[0].Value.ToString()), txtProjectName.Text, txtDescription.Text, cmbProject.SelectedItem.ToString(), calendar.Value.Date, txtClient.Text);
            if (MessageBox.Show("Are you sure you want to delete this project?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                MessageBox.Show(project.DeleteProject(), "Delete");
                projectsDG.DataSource = GetProjectList();
            }
        }
        private void btnEditProject_Click_1(object sender, EventArgs e)
        {
            Project project = new Project(int.Parse(projectsDG.CurrentRow.Cells[0].Value.ToString()), txtProjectName.Text, txtDescription.Text, cmbProject.SelectedItem.ToString(), calendar.Value.Date, txtClient.Text);
            project.EditProject();
            MessageBox.Show("Successfully updated", "Edit");
            Clear();
            projectsDG.DataSource = GetProjectList();
        }

        private void btnTasks_Click_1(object sender, EventArgs e)
        {
            AddTask tasksForm = new AddTask(project_id);
            tasksForm.ShowDialog();
        }
        private void projectsDG_DoubleClick_1(object sender, EventArgs e)
        {
            txtProjectName.Text = projectsDG.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = projectsDG.CurrentRow.Cells[2].Value.ToString();
            cmbProject.SelectedItem = projectsDG.CurrentRow.Cells[3].Value.ToString();
            txtClient.Text = projectsDG.CurrentRow.Cells[5].Value.ToString();

            txtProjectName.Select();

            //edit = new EditTask();
            //edit.ShowDialog();
        }
        private void projectsDG_Click_1(object sender, EventArgs e)
        {
            if (projectsDG.RowCount > 0)
            {
                project_id = int.Parse(projectsDG.CurrentRow.Cells[0].Value.ToString());
            }
        }
        private void calendarPic_Click_1(object sender, EventArgs e)
        {
            calendar.Visible = true;
            txtClient.Visible = false;
            txtDescription.Visible = false;
            clientSeparator.Visible = false;
        }
        private void clientPic_Click_1(object sender, EventArgs e)
        {
            calendar.Visible = false;
            txtClient.Visible = true;
            clientSeparator.Visible = true;
            txtDescription.Visible = false;
        }
        private void descriptionPic_Click_1(object sender, EventArgs e)
        {
            calendar.Visible = false;
            txtClient.Visible = false;
            txtDescription.Visible = true;
            clientSeparator.Visible = false;
        }

        private void Clear()
        {
            txtProjectName.Text = "Project Name";
            txtDescription.Text = "Add Description";
            txtClient.Text = "Add Client";
            calendar.Value = DateTime.Now;
        }
    }
}
