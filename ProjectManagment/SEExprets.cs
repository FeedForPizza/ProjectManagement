using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectManagment
{
    public partial class SEExprets : Form
    {
        public SEExprets()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=INF-2067-19\\SQLEXPRESS;User ID=sa;Password=infdb@dm1n; Initial Catalog=ProjectManagment;");
        private void button2_Click(object sender, EventArgs e)
        {
            

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void eXPERTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void SEExprets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagmentDataSet.EXPERTS' table. You can move, or remove it, as needed.
            this.eXPERTSTableAdapter.Fill(this.projectManagmentDataSet.EXPERTS);
/*            cbEX_TYPE.SelectedIndex = 0;
*/
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //SqlConnection con = new SqlConnection();
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from EXPERTS where EXPERT_NAME = @EXPERT_NAME OR EXPERT_SURNAME = @EXPERT_SURNAME OR EXPERT_LASTNAME = @EXPERT_LASTNAME OR EXPERT_TYPE = @EXPERT_TYPE", con);

            //cmd.Parameters.AddWithValue("@EXPERT_NAME", textBox4.Text);
            //cmd.Parameters.AddWithValue("@EXPERT_SURNAME", textbox5.Text);
            //cmd.Parameters.AddWithValue("@EXPERT_LASTNAME", textBox2.Text);
            //cmd.Parameters.AddWithValue("@EXPERT_TYPE", comboBox1.Text);

            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView2.DataSource = dt;

            //StringBuilder sb = new StringBuilder();
            //if (textBoxExName.Text != " " )
            //{
            //    sb.AppendFormat("EXPERT_NAME = {0}", textBoxExName.Text);
            //}
            //if(textboxExSurname.Text != " ")
            //{
            //    if (sb.Length > 0)
            //    {
            //        sb.Append(" AND ");
            //    }
            //    sb.AppendFormat("EXPERT_SURNAME = {0}", textboxExSurname.Text);
            //}
            //if (textBoxExLastName.Text != " ")
            //{
            //    if (sb.Length > 0)
            //    {
            //        sb.Append(" AND ");
            //    }
            //    sb.AppendFormat("EXPERT_LASTNAME = {0}", textBoxExLastName.Text);
            //}
            //if (comboBoxExType.SelectedIndex>-1)
            //{
            //    if (sb.Length > 0)
            //    {
            //        sb.Append(" AND ");
            //    }
            //    sb.AppendFormat("EXPERT_TYPE = {0}", comboBoxExType.SelectedValue);
            //}

            string expertsType = "";
            if (cbEX_TYPE.SelectedIndex == 0)
            {
                expertsType = "I";
            }
            else if(cbEX_TYPE.SelectedIndex == 1)
            {
                expertsType = "E";
            }

            this.eXPERTSTableAdapter.FillBySearch(this.projectManagmentDataSet.EXPERTS, expertsType, EXPERT_NAME.Text, EXPERT_SURNAME.Text, EXPERT_LASTNAME.Text);

        }

        private void textBoxExName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewExperts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5)
            {
                
                ExpertEditForm ExpertEditForm = new ExpertEditForm(Convert.ToInt32(dataGridViewExperts.Rows[e.RowIndex].Cells[0].Value), dataGridViewExperts.Rows[e.RowIndex].Cells[1].Value, dataGridViewExperts.Rows[e.RowIndex].Cells[2].Value, dataGridViewExperts.Rows[e.RowIndex].Cells[3].Value, dataGridViewExperts.Rows[e.RowIndex].Cells[4].Value);
                ExpertEditForm.Show();



            //{ int rowIndex = e.RowIndex;
            //DataGridViewRow row = dataGridViewExperts.Rows[rowIndex];
            //con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT p.PROJECT_ID,PROJECT_NAME,PROJECT_DESCRIPTION,PROJECT_CLIENT,PROJECT_BEGIN,PROJECT_END,PROJECT_STATUS,PROJECT_PAY_PER_HOUR FROM PROJECTS p inner join PROJECT_TASKS pt on p.PROJECT_ID = pt.PROJECT_ID inner join EXPERTS e on pt.EXPRET_ID = e.EXPRET_ID WHERE e.EXPERT_ID = @EXPERT_ID ");

            //cmd.Parameters.AddWithValue("@EXPERT_ID", dataGridViewExperts.Rows[1].Cells[1].Value.ToString());


        }
            else if (e.ColumnIndex == 6)
            {
                ResultProjects resultProjects = new ResultProjects(Convert.ToInt32(dataGridViewExperts.Rows[e.RowIndex].Cells[0].Value));
                resultProjects.Show();

            }
        }

        private void EXPERT_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            this.eXPERTSBindingSource.Filter = null;
            EXPERT_NAME.Clear();
            EXPERT_SURNAME.Clear();
            EXPERT_LASTNAME.Clear();
            cbEX_TYPE.SelectedIndex = -1;
            
        }
    }
}
