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
    public partial class AddTask : Form
    {
        int pj_id;
        string req;

        public AddTask(int project_id)
        {
            InitializeComponent();
            pj_id = project_id;
        }

        private void AddTasks_Load(object sender, EventArgs e)
        {
            cmbTaskProgress.SelectedItem = "None";
            TasksDG.DataSource = GetTaskList(pj_id);
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public DataTable GetTaskList(int pj_id)
        {
            DataTable dtTasks = new DataTable();
            req = "SELECT task_title AS Title, task_description AS Description,task_deadline AS Deadline,task_status AS Status FROM task WHERE project_id = " + pj_id + ";";
            MysqlController controller = new MysqlController(req);
            dtTasks.Load(controller.reader);
            return dtTasks;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if ((txtTaskName.Text == string.Empty) || (txtTaskName.Text == "Task Name"))
            {
                MessageBox.Show("You should specify a name for your task.", "Warning");
            }
            else
            {
                Task project = new Task(pj_id, txtTaskName.Text, txtTaskDescription.Text, taskCalendar.Value.Date, cmbTaskProgress.SelectedItem.ToString());
                project.AddTask();
                MessageBox.Show("Successfully submitted", "Add");
                Clear();
                TasksDG.DataSource = GetTaskList(pj_id);
            }
        }
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            Task task = new Task(int.Parse(TasksDG.CurrentRow.Cells[0].Value.ToString()), pj_id, txtTaskName.Text, txtTaskDescription.Text, taskCalendar.Value.Date, cmbTaskProgress.SelectedItem.ToString());
            if (MessageBox.Show("Are you sure you want to delete this task?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                task.DeleteTask();
                MessageBox.Show("Successfully deleted", "Delete");
                TasksDG.DataSource = GetTaskList(pj_id);
            }
        }
        private void btnEditTask_Click(object sender, EventArgs e)
        {
            Task task = new Task(int.Parse(TasksDG.CurrentRow.Cells[0].Value.ToString()),pj_id,txtTaskName.Text, txtTaskDescription.Text, taskCalendar.Value.Date, cmbTaskProgress.SelectedItem.ToString());
            task.EditTask();
            MessageBox.Show("Successfully updated", "Edit");
            Clear();
            TasksDG.DataSource = GetTaskList(pj_id);
        }

        private void TasksDG_DoubleClick(object sender, EventArgs e)
        {
            txtTaskName.Text = TasksDG.CurrentRow.Cells[1].Value.ToString();
            txtTaskDescription.Text = TasksDG.CurrentRow.Cells[2].Value.ToString();
            cmbTaskProgress.SelectedItem = TasksDG.CurrentRow.Cells[4].Value.ToString();
        }

        private void Clear()
        {
            txtTaskName.Text = "Task Name";
            txtTaskDescription.Text = "Add Description";
            taskCalendar.Value = DateTime.Now;
        }
    }
}
