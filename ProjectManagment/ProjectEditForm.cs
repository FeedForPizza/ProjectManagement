using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UNWE_CourseProject_TsM
{
    public partial class ProjectEditForm : Form
    {
        public ProjectEditForm()
        {
            InitializeComponent();
        }

        private void ProjectEditForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            if (statusComboBox.SelectedItem == null)
            {
                MessageBox.Show($"Моля изберете статус!");
            }
            else if (statusComboBox.SelectedItem == "Нов")
            {
                statusComboBox.Items.Clear();

                statusComboBox.Items.Add("В изпълнение");
                statusComboBox.Items.Add("Прекратен");
                statusComboBox.Items.Add("Замразен");
                statusComboBox.Items.Add("Изпълнен");

                MessageBox.Show($"Проекта е редактиран.");
            }
            else if (statusComboBox.SelectedItem == "В изпълнение")
            {
                statusComboBox.Items.Clear();

                statusComboBox.Items.Add("Прекратен");
                statusComboBox.Items.Add("Замразен");
                statusComboBox.Items.Add("Изпълнен");

                MessageBox.Show($"Проекта е редактиран.");
            }
            else if (statusComboBox.SelectedItem == "Прекратен")
            {
                statusComboBox.Items.Clear();

                statusComboBox.Items.Add("В изпълнение");

                MessageBox.Show($"Проекта е редактиран.");
            }
            else if (statusComboBox.SelectedItem == "Замразен")
            {
                statusComboBox.Items.Clear();

                statusComboBox.Items.Add("В изпълнение");

                MessageBox.Show($"Проекта е редактиран.");
            }
            else if (statusComboBox.SelectedItem == "Изпълнен")
            {
                statusComboBox.Items.Clear();

                MessageBox.Show($"Проекта е редактиран.");
            }
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
