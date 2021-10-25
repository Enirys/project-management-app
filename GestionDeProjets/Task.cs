using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionDeProjets
{
    class Task
    {
        // Database parameters
        //MySqlConnection con;
        //string conString = "server=localhost;database=umlDB;uid=root;pwd=;";
        //MySqlCommand cmd;

        // Class Attributes
        private int task_id;
        private int project_id;
        private string task_title;
        private string task_description;
        private DateTime task_deadline;
        private string task_status;

        public Task(int task_id,int project_id,string task_title,string task_description,DateTime task_deadline,string task_status)
        {
            this.task_id = task_id;
            this.project_id = project_id;
            this.task_description = task_description;
            this.task_title = task_title;
            this.task_deadline = task_deadline;
            this.task_status = task_status;
        }
        public Task(int project_id, string task_title, string task_description, DateTime task_deadline, string task_status)
        {
            this.project_id = project_id;
            this.task_title = task_title;
            this.task_description = task_description;
            this.task_deadline = task_deadline;
            this.task_status = task_status;
        }
        public Task(int project_id)
        {
            this.project_id = project_id;
        }

        public void AddTask()
        {
            //con = new MySqlConnection(conString);
            //string sql = "INSERT INTO task(project_id,task_title,task_description,task_deadline,task_status) VALUES(" + project_id + ",'" + task_title + "','" + task_description + "','" + task_deadline.ToString("yyyy-MM-dd") + "','" + task_status + "');";
            //cmd = new MySqlCommand(sql, con);
            //con.Open();
            //try
            //{
            //    cmd = new MySqlCommand(sql, con);
            //    cmd.ExecuteNonQuery();
            //}
            //finally
            //{
            //    con.Close();
            //}

            MysqlController controller = new MysqlController("INSERT INTO task(project_id,task_title,task_description,task_deadline,task_status) VALUES(" + project_id + ",'" + task_title + "','" + task_description + "','" + task_deadline.ToString("yyyy-MM-dd") + "','" + task_status + "');");
        }
        public void DeleteTask()
        {
            //con = new MySqlConnection(conString);
            //string sql = "DELETE FROM task WHERE task_id='" + task_id + "';";
            //cmd = new MySqlCommand(sql, con);
            //con.Open();
            //try
            //{
            //    cmd = new MySqlCommand(sql, con);
            //    cmd.ExecuteNonQuery();
            //}
            //finally
            //{
            //    con.Close();
            //}

            MysqlController controller = new MysqlController("DELETE FROM task WHERE task_id='" + task_id + "';");
        }
        public void EditTask()
        {
            //con = new MySqlConnection(conString);
            //string sql = "UPDATE task SET task_title = '" + task_title + "', task_description = '" + task_description + "', task_deadline = '" + task_deadline.Date.ToString("yyyy-MM-dd") + "', task_status = '" + task_status + "' WHERE task_id = '" + task_id + "'; ";
            //con.Open();
            //try
            //{
            //    cmd = new MySqlCommand(sql, con);
            //    cmd.ExecuteNonQuery();
            //}
            //finally
            //{
            //    con.Close();
            //}

            MysqlController controller = new MysqlController("UPDATE task SET task_title = '" + task_title + "', task_description = '" + task_description + "', task_deadline = '" + task_deadline.Date.ToString("yyyy-MM-dd") + "', task_status = '" + task_status + "' WHERE task_id = '" + task_id + "'; ");
        }

    }
}
