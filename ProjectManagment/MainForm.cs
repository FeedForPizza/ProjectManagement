using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNWE_CourseProject_TsM;

namespace ProjectManagment
{
    public partial class MainForm : Form
    {
        Font SmallFont = new Font("Arial", 8);
        Font MediumFont = new Font("Arial", 10);
        Font LargeFont = new Font("Arial", 12);
        public MainForm()
        {
            InitializeComponent();
            lblMenu.Font = LargeFont;
        }

        private void buttonPrjInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonADDPROJECTS_Click(object sender, EventArgs e)
        {
            AddProjects addProjects = new AddProjects();
            addProjects.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Task create_Task = new Create_Task();
            create_Task.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RSexperts rSexperts = new RSexperts();
            rSexperts.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchProjects_Click(object sender, EventArgs e)
        {
            ProjectSearchForm projectSearchForm = new ProjectSearchForm();
            projectSearchForm.Show();
        }

        private void btnViewAndEditProjects_Click(object sender, EventArgs e)
        {
            ProjectEditForm projectEditForm = new ProjectEditForm();
            projectEditForm.Show();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SEExprets sEExprets = new SEExprets();
            sEExprets.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchFormProjects searchFormProjects = new SearchFormProjects();
            searchFormProjects.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewAndEditProjectsForm viewAndEditProjectsForm = new ViewAndEditProjectsForm();
            viewAndEditProjectsForm.Show();
        }
    }
}
