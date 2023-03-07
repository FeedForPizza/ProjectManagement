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
    public partial class AddProjects : Form
    {
        public AddProjects()
        {
            InitializeComponent();
        }

        private void apGroupBox_Enter(object sender, EventArgs e)
        {
            statusComboBox.SelectedIndex = 0;
            statusComboBox.Enabled = false;
        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddProjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagmentDataSet1.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter.Fill(this.projectManagmentDataSet1.PROJECTS);
            // TODO: This line of code loads data into the 'projectManagmentDataSet1.EXPERTS' table. You can move, or remove it, as needed.
            this.eXPERTSTableAdapter.Fill(this.projectManagmentDataSet1.EXPERTS);
            // TODO: This line of code loads data into the 'projectManagmentDataSet.PROJECT_TASKS' table. You can move, or remove it, as needed.
            this.pROJECT_TASKSTableAdapter.Fill(this.projectManagmentDataSet.PROJECT_TASKS);
            // TODO: This line of code loads data into the 'projectManagmentDataSet.PROJECT_TASKS' table. You can move, or remove it, as needed.
            this.pROJECT_TASKSTableAdapter.Fill(this.projectManagmentDataSet.PROJECT_TASKS);
            // TODO: This line of code loads data into the 'projectManagmentDataSet.EXPERTS' table. You can move, or remove it, as needed.
            this.eXPERTSTableAdapter.Fill(this.projectManagmentDataSet.EXPERTS);
            statusComboBox.Items.Add("Нов");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Task create_Task = new Create_Task();
            create_Task.Show();
        }

        private void tasksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void expertComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
    

            string projectName = projectNameTextBox.Text;
            if (projectName == String.Empty)
            {
                MessageBox.Show("Име на проекта е задължително поле", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string projectDesc = projectDescTextBox.Text;

            string projectClient = clientComboBox.Text;
            if (projectClient == String.Empty)
            {
                MessageBox.Show("Клиент на проекта е задължително поле", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime startProject = startDateTimePicker.Value;
            DateTime endProject = endDateTimePicker.Value;

            int projectStatus = 1;

            string price = priceТextBox.Text;
            decimal convertPrice = Decimal.Parse(price);

            if(convertPrice <= 0)
            {
                MessageBox.Show("Часова ставка трябва да бъде по-голяма от нула", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // add check if the project exists
            pROJECTSTableAdapter.Insert(projectName, projectDesc, projectClient, new DateTime(startProject.Year, startProject.Month, startProject.Day), new DateTime(endProject.Year, endProject.Month, endProject.Day), projectStatus, convertPrice); ;
            MessageBox.Show("Проектът е създаден успешно", "Нов проект", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void projectCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void projectNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void projectNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
