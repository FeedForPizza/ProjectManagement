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
    public partial class Create_Task : Form
    {
        public Create_Task()
        {
            InitializeComponent();
        }

        

        private void addTaskGroupBox_Enter(object sender, EventArgs e)
        {
            
            
        }

        private void Create_Task_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagmentDataSet.TASK_STATUS' table. You can move, or remove it, as needed.
            this.tASK_STATUSTableAdapter.Fill(this.projectManagmentDataSet.TASK_STATUS);
            // TODO: This line of code loads data into the 'projectManagmentDataSet.PROJECT_TASKS' table. You can move, or remove it, as needed.
            this.pROJECT_TASKSTableAdapter2.Fill(this.projectManagmentDataSet.PROJECT_TASKS);
            // TODO: This line of code loads data into the 'projectManagmentDataSet.EXPERTS' table. You can move, or remove it, as needed.
            this.eXPERTSTableAdapter.Fill(this.projectManagmentDataSet.EXPERTS);
            // TODO: This line of code loads data into the 'projectManagmentDataSet.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter.Fill(this.projectManagmentDataSet.PROJECTS);
            statusComboBox.SelectedIndex = 5;
            statusComboBox.Enabled = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void progressTextBox_TextChanged(object sender, EventArgs e)
        { 
            if(progressTextBox.Text == "")
            {
                progressBar1.Value = 0;
            }
            else
            {
                progressBar1.Value = Convert.ToInt32(progressTextBox.Text);
            }
            
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string taskName = taskNameTextBox.Text;

            if (taskName == String.Empty)
            {
                MessageBox.Show("Име на задачата е задължително поле", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string taskDesc = taskDescTextBox.Text;
            string taskResult = taskResultTextBox.Text;

            DateTime startDate = startDateTimePicker.Value;
            DateTime endDate = endDateTimePicker.Value;

            decimal status = 1;
            int priority = priorityComboBox.SelectedIndex;
            string priorityLvl = "";

            switch (priority)
            {
                case 0:
                    priorityLvl = "H";
                    break;
                case 1:
                    priorityLvl = "M";
                    break;
                case 2:
                    priorityLvl = "L";
                    break;
            }

            decimal progress = Decimal.Parse(progressTextBox.Text);
            decimal hours = Decimal.Parse(hoursTextBox.Text);
            

            decimal forProject = (decimal)projectComboBox.SelectedValue;
            int expert = (int)expertsComboBox.SelectedValue;

            this.pROJECT_TASKSTableAdapter2.Insert(forProject, expert, taskName, taskDesc, taskResult, new DateTime(startDate.Year, startDate.Month, startDate.Day), new DateTime(endDate.Year, endDate.Month, endDate.Day), priorityLvl, status, progress, hours);
            MessageBox.Show("Задачата е създадена успешно", "Нова задача", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }
    }
}
    