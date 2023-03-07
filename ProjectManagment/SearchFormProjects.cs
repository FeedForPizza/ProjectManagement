using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagment
{
    public partial class SearchFormProjects : Form
    {
        public SearchFormProjects()
        {
            InitializeComponent();
        }

        private void pROJECTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROJECTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagmentDataSet);

        }

        private void pROJECTSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pROJECTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagmentDataSet);

        }

        private void SearchFormProjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagmentDataSet.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter.Fill(this.projectManagmentDataSet.PROJECTS);

        }

        private void btnSearchProject_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            string projectState = cbProjectState.Text;
            string projectName = tbProjectName.Text;
            string projectClient = tbClientName.Text;
            string projectId = textBoxProjectID.Text;
            //string startProject = dtpStartDateProject.Value.Date.ToString("yyyy-MM-dd");
            //string endProject = dtpEndDateProject.Value.Date.ToString("yyyy-MM-dd");
            //string dateNow = Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd"));
            DateTime now = DateTime.Now;
            if (projectName != String.Empty)
            {
                 sb.AppendFormat("project_name like '%{0}%'", projectName);
                
            }
            else if (projectClient != String.Empty)
            {
                
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
                sb.AppendFormat("project_client like '%{0}%'", projectClient);
            }
            else if (projectId != String.Empty) {
                 
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
                sb.AppendFormat("project_id ={0}", projectId);
            }
            else if (projectState != String.Empty)
            {
                switch (projectState)
                {
                    case "Нов":
                        sb.AppendFormat("project_status = 1");
                        break;
                    case "В изпълнение":
                        sb.AppendFormat("project_status = 2");
                        break;
                    case "Прекратен":
                        sb.AppendFormat("project_status = 3");
                        break;
                    case "Замразен":
                        sb.AppendFormat("project_status = 4");
                        break;
                    case "Изпълнен":
                        sb.AppendFormat("project_status = 5");
                        break;

                }
                
            } 
            else if(dtpStartDateProject.Value != now)
            {
                
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
                sb.AppendFormat("PROJECT_BEGIN ='{0:yyyy-MM-dd}'", dtpStartDateProject.Value);
            }
            else if (dtpEndDateProject.Value != now)
            {
                
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
                sb.AppendFormat("PROJECT_END ='{0:yyyy-MM-dd}'", dtpEndDateProject.Value);
            }
              
            

            this.pROJECTSBindingSource.Filter = sb.ToString();
            this.pROJECTSTableAdapter.Fill(this.projectManagmentDataSet.PROJECTS);
            pROJECTSDataGridView.Refresh();
            sb.Clear();


        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.pROJECTSBindingSource.Filter = null;
            textBoxProjectID.Clear();
            tbClientName.Clear();
            tbProjectName.Clear();
            dtpStartDateProject.Value = DateTime.Now;
            dtpEndDateProject.Value = DateTime.Now;
            cbProjectState.SelectedIndex = -1;
        }
    }
}
