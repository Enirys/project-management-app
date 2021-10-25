using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeProjets
{
    class Project
    {
        // Class attributes

        private int project_id;
        private string projectTitle;
        private string projectDescription;
        private string projectStatus;
        private DateTime projectDeadline;
        private string projectClient;

        public Project(int project_id,string projectTitle,string projectDescription,string projectStatus,DateTime projectDeadline,string projectClient)
        {
            this.project_id = project_id;
            this.projectTitle = projectTitle;
            this.projectDescription = projectDescription;
            this.projectStatus = projectStatus;
            this.projectDeadline = projectDeadline;
            this.projectClient = projectClient;
        }

        public Project(string projectTitle, string projectDescription, string projectStatus, DateTime projectDeadline, string projectClient)
        {
            this.projectTitle = projectTitle;
            this.projectDescription = projectDescription;
            this.projectStatus = projectStatus;
            this.projectDeadline = projectDeadline;
            this.projectClient = projectClient;
        }

        public void AddProject()
        {
            MysqlController controller = new MysqlController("INSERT INTO project(project_title,project_description,project_status,project_deadline,project_client) VALUES('" + projectTitle + "','" + projectDescription + "','" + projectStatus + "','" + projectDeadline.ToString("yyyy-MM-dd") + "','" + projectClient + "');");
        }

        public string DeleteProject()
        {
            MysqlController controller = new MysqlController("DELETE FROM project WHERE project_id='" + project_id + "';");
            return "Successfully deleted";
        }

        public void EditProject()
        {
            MysqlController controller = new MysqlController("UPDATE project SET project_title ='" + projectTitle + "',project_description ='" + projectDescription + "',project_status ='" + projectStatus + "',project_deadline = '" + projectDeadline.ToString("yyyy-MM-dd") + "',project_client ='" + projectClient + "' WHERE project_id = '" + project_id + "';");
        }
    }
}
