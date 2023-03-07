using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProjectManagment
{
    public partial class ViewAndEditProjectsForm : Form
    {
        public ViewAndEditProjectsForm()
        {
            InitializeComponent();
        }

        private void pROJECTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROJECTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagmentDataSet);

        }

        private void ViewAndEditProjectsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagmentDataSet.PROJECT_TASKS' table. You can move, or remove it, as needed.
            this.pROJECT_TASKSTableAdapter.Fill(this.projectManagmentDataSet.PROJECT_TASKS);
            // TODO: This line of code loads data into the 'projectManagmentDataSet.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter.Fill(this.projectManagmentDataSet.PROJECTS);
            int rows = pROJECT_TASKSDataGridView.Rows.Count - 1;
            textBoxNumTasks.Text = rows.ToString();
            int costs = 0;

            for (int i = 0; i <= rows; i++)
            {
                DateTime startDate = Convert.ToDateTime(pROJECT_TASKSDataGridView.Rows[i].Cells[6].Value); //Gets the value in Column 1
                DateTime endDate = Convert.ToDateTime(pROJECT_TASKSDataGridView.Rows[i].Cells[7].Value); //Gets the value in Column 2
                int status = Convert.ToInt32(pROJECT_TASKSDataGridView.Rows[i].Cells[9].Value);
                DateTime now = DateTime.Now;
                int days;
                switch (status)
                {
                    case 1:
                        pROJECT_TASKSDataGridView.Rows[i].Cells[12].Value = 0;
                        pROJECT_TASKSDataGridView.Rows[i].Cells[13].Value = 0;
                        break;
                        case 2:
                        pROJECT_TASKSDataGridView.Rows[i].Cells[12].Value = 0;
                        pROJECT_TASKSDataGridView.Rows[i].Cells[13].Value = 0;
                        break;
                    case 3:
                        pROJECT_TASKSDataGridView.Rows[i].Cells[12].Value = (endDate - startDate).Days;
                        pROJECT_TASKSDataGridView.Rows[i].Cells[13].Value = 0;
                        break;
                    case 4:
                        pROJECT_TASKSDataGridView.Rows[i].Cells[12].Value = (now - endDate).Days;
                        pROJECT_TASKSDataGridView.Rows[i].Cells[13].Value = 0;
                        break;
                    case 5:
                        pROJECT_TASKSDataGridView.Rows[i].Cells[12].Value = 0;
                        pROJECT_TASKSDataGridView.Rows[i].Cells[13].Value = (now - endDate).Days;
                        break;
                    case 6:
                        pROJECT_TASKSDataGridView.Rows[i].Cells[12].Value = 0;
                        pROJECT_TASKSDataGridView.Rows[i].Cells[13].Value = 0;
                        break;

                }
               
            }
                for (int i = 0; i < rows; i++)
            {

                costs += Int32.Parse(pROJECT_TASKSDataGridView.Rows[i].Cells[11].Value.ToString());
                DateTime now = DateTime.Now.Date;
                DateTime start = Convert.ToDateTime(pROJECT_TASKSDataGridView.Rows[i].Cells[6].Value).Date;
                DateTime end = Convert.ToDateTime(pROJECT_TASKSDataGridView.Rows[i].Cells[7].Value).Date;
                //double remaing = (now - start).TotalDays;
               // pROJECT_TASKSDataGridView.Rows[i].Cells[12].Value = remaing;



            }
            decimal hours = Decimal.Parse(pROJECT_PAY_PER_HOURTextBox.Text.ToString());
            textBoxCosts.Text = (hours * costs).ToString();
            textBoxAllhours.Text = costs.ToString();

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
        //TODO: This line of code loads data into the 'projectManagmentDataSet.PROJECT_TASKS' table.You can move, or remove it, as needed.
        //    this.pROJECT_TASKSTableAdapter.Fill(this.projectManagmentDataSet.PROJECT_TASKS);
        //TODO: This line of code loads data into the 'projectManagmentDataSet.PROJECTS' table.You can move, or remove it, as needed.
        //    this.pROJECTSTableAdapter.Fill(this.projectManagmentDataSet.PROJECTS);

            int rows = pROJECT_TASKSDataGridView.Rows.Count - 1;
            textBoxNumTasks.Text = rows.ToString();
            

            for (int i = 0; i <= pROJECT_TASKSDataGridView.Rows.Count - 1; i++)
            {
                DateTime startDate = Convert.ToDateTime(pROJECT_TASKSDataGridView.Rows[i].Cells[6].Value); //Gets the value in Column 1
                DateTime endDate = Convert.ToDateTime(pROJECT_TASKSDataGridView.Rows[i].Cells[7].Value); //Gets the value in Column 2
                int status = Convert.ToInt32(pROJECT_TASKSDataGridView.Rows[i].Cells[9].Value);
                DateTime now = DateTime.Now;
                
                switch (status)
                {
                    case 1:
                        pROJECT_TASKSDataGridView.Rows[i].Cells[12].Value = 0;
                        pROJECT_TASKSDataGridView.Rows[i].Cells[13].Value = 0;
                        break;
                    case 2:
                        pROJECT_TASKSDataGridView.Rows[i].Cells[12].Value = 0;
                        pROJECT_TASKSDataGridView.Rows[i].Cells[13].Value = 0;
                        break;
                    case 3:
                        pROJECT_TASKSDataGridView.Rows[i].Cells[12].Value = (endDate - startDate).Days;
                        pROJECT_TASKSDataGridView.Rows[i].Cells[13].Value = 0;
                        break;
                    case 4:
                        pROJECT_TASKSDataGridView.Rows[i].Cells[12].Value = 0;
                        pROJECT_TASKSDataGridView.Rows[i].Cells[13].Value = (now - endDate).Days;
                        break;
                    case 5:
                        pROJECT_TASKSDataGridView.Rows[i].Cells[12].Value = 0;
                        pROJECT_TASKSDataGridView.Rows[i].Cells[13].Value = (now - endDate).Days;
                        break;
                    case 6:
                        pROJECT_TASKSDataGridView.Rows[i].Cells[12].Value = 0;
                        pROJECT_TASKSDataGridView.Rows[i].Cells[13].Value = 0;
                        break;

                }

            }
            int costs = 0;
            for (int i = 0; i < pROJECT_TASKSDataGridView.Rows.Count - 2; i++)
            {

                costs += Int32.Parse(pROJECT_TASKSDataGridView.Rows[i].Cells[11].Value.ToString());
                //DateTime now = DateTime.Now.Date;
                //DateTime start = Convert.ToDateTime(pROJECT_TASKSDataGridView.Rows[i].Cells[6].Value).Date;
                //DateTime end = Convert.ToDateTime(pROJECT_TASKSDataGridView.Rows[i].Cells[7].Value).Date;
                //double remaing = (now - start).TotalDays;
                //pROJECT_TASKSDataGridView.Rows[i].Cells[12].Value = remaing;
                for (int j = 0; j <= rows; j++)
                {
                    DateTime startDate = Convert.ToDateTime(pROJECT_TASKSDataGridView.Rows[j].Cells[6].Value); //Gets the value in Column 1
                    DateTime endDate = Convert.ToDateTime(pROJECT_TASKSDataGridView.Rows[j].Cells[7].Value); //Gets the value in Column 2
                    int status = Convert.ToInt32(pROJECT_TASKSDataGridView.Rows[j].Cells[9].Value);
                    DateTime now = DateTime.Now;
                    int days;
                    switch (status)
                    {
                        case 1:
                            pROJECT_TASKSDataGridView.Rows[j].Cells[12].Value = 0;
                            pROJECT_TASKSDataGridView.Rows[j].Cells[13].Value = 0;
                            break;
                        case 2:
                            pROJECT_TASKSDataGridView.Rows[j].Cells[12].Value = 0;
                            pROJECT_TASKSDataGridView.Rows[j].Cells[13].Value = 0;
                            break;
                        case 3:
                            pROJECT_TASKSDataGridView.Rows[j].Cells[12].Value = (endDate - startDate).Days;
                            pROJECT_TASKSDataGridView.Rows[j].Cells[13].Value = 0;
                            break;
                        case 4:
                            pROJECT_TASKSDataGridView.Rows[j].Cells[12].Value = (now - endDate).Days;
                            pROJECT_TASKSDataGridView.Rows[j].Cells[13].Value = 0;
                            break;
                        case 5:
                            pROJECT_TASKSDataGridView.Rows[j].Cells[12].Value = 0;
                            pROJECT_TASKSDataGridView.Rows[j].Cells[13].Value = (now - endDate).Days;
                            break;
                        case 6:
                            pROJECT_TASKSDataGridView.Rows[j].Cells[12].Value = 0;
                            pROJECT_TASKSDataGridView.Rows[j].Cells[13].Value = 0;
                            break;

                    }

                }

            }
            decimal hours = Decimal.Parse(pROJECT_PAY_PER_HOURTextBox.Text.ToString());
            textBoxCosts.Text = (hours * costs).ToString();
            textBoxAllhours.Text = costs.ToString();

        }

      
    }
}
