using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNWE_CourseProject_TsM
{
    public partial class ProjectSearchForm : Form
    {
        public ProjectSearchForm()
        {
            InitializeComponent();
        }

        private void lbClientName_Click(object sender, EventArgs e)
        {

        }

        private void lblStartDateProject_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchProject_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();


            if (txt_projectName.Text != "")
            {
                sb.Clear();
                sb.AppendFormat("project_name like '%{0}%'", txt_projectName.Text);
                if (sb.Length > 0)
                {
                   sb.Append(" AND ");
                }
            }
            else if (tbClientName.Text != "")
            {
                sb.Clear();
                sb.AppendFormat("or project_client like '%{0}%'", tbClientName.Text);
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
            }

            else if (textBoxProjectID.Text != "")
            {
                sb.Clear();
                sb.AppendFormat("or project_id = '%{0}%'", textBoxProjectID.Text);
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
            }
            
         

            
            string state = cbProjectState.Text;
            switch (state)
            {
                case "Нов":
                    sb.AppendFormat("and project_status = 1");
                    break;
                case "В изпълнение":
                    sb.AppendFormat("and project_status = 2");
                    break;
                case "Прекратен":
                    sb.AppendFormat("and project_status = 3");
                    break;
                case "Замразен":
                    sb.AppendFormat("and project_status = 4");
                    break;
                case "Изпълнен":
                    sb.AppendFormat("and project_status = 5");
                    break;

            }

            if(txt_projectName.Text == String.Empty && tbClientName.Text == String.Empty && textBoxProjectID.Text == String.Empty)
            {
                MessageBox.Show("Въведете още един параметър");
                return;
            }
            //int projectId=
            //sb.AppendFormat("or project_id={0}", projectId);
            this.pROJECTSBindingSource1.Filter = sb.ToString();
            this.pROJECTSTableAdapter1.Fill(this.projectManagmentDataSet.PROJECTS);
            for(int i = 0; i < 10; i++)
            {
                
                if (pROJECT_TASKSDataGridView.Columns[i].Name.Equals("TASK_NAME"))
                {
                    this.Close();
                }
            }
          
        }

        private void ProjectSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagmentDataSet.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter1.Fill(this.projectManagmentDataSet.PROJECTS);
            // TODO: This line of code loads data into the 'dataSet1.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter1.Fill(this.projectManagmentDataSet.PROJECTS);
            // TODO: This line of code loads data into the 'projectManagmentDataSet.PROJECT_TASKS' table. You can move, or remove it, as needed.
            this.pROJECT_TASKSTableAdapter.Fill(this.projectManagmentDataSet.PROJECT_TASKS);
            cbProjectState.Items.Add("Нов");
            cbProjectState.Items.Add("В изпълнение");
            cbProjectState.Items.Add("Прекратен");
            cbProjectState.Items.Add("Замразен");
            cbProjectState.Items.Add("Изпълнен");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectEditForm projectEditForm = new ProjectEditForm();
            projectEditForm.Show();
        }

        private void cbProjectState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbProjectList_Enter(object sender, EventArgs e)
        {

        }

        private void pROJECT_TASKSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROJECT_TASKSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagmentDataSet);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT COUNT(*)
            FROM PROJECT_TASKS
            WHERE PROJECT_ID = @PROJECT_ID";
            cmd.Parameters.AddWithValue("@PROJECT_ID", textBoxProjectID.Text);
            textBoxNumTasks.Text = cmd.CommandText;
        }

        private void textBoxAllhours_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT SUM(TASK_HOURS)
            FROM PROJECT_TASKS
            WHERE PROJECT_ID = @PROJECT_ID";
            cmd.Parameters.AddWithValue("@PROJECT_ID", textBoxProjectID.Text);
            textBoxAllhours.Text = cmd.CommandText;
        }

        private void textBoxCosts_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"SELECT TASK_HOURS*PROJECT_PAY_PER_HOUR
            FROM PROJECT_TASKS PT INNER JOIN PROJECTS P ON PT.PROJECT_ID = P.PROJECT_ID
            WHERE TASK_STATUS IN(6,4,3)";
                textBoxCosts.Text = cmd.CommandText;
        }

        private void pROJECT_TASKSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbProjectsReport_Enter(object sender, EventArgs e)
        {

        }
    }
}
