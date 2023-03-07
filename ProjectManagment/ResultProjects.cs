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
    public partial class ResultProjects : Form
    {
        public ResultProjects()
        {
            InitializeComponent();
        }
        public ResultProjects(int id)
        {
            InitializeComponent();
            id_expert = id;
        }
        int id_expert;

        private void ResultProjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagmentDataSet.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter.Fill(this.projectManagmentDataSet.PROJECTS);
            this.pROJECTSTableAdapter.FillByProjectsByExpert(this.projectManagmentDataSet.PROJECTS, id_expert);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
