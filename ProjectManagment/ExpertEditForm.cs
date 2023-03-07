using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectManagment
{
    public partial class ExpertEditForm : Form
    {
        public ExpertEditForm()
        {
            InitializeComponent();
        }

        public ExpertEditForm(int id, object fname, object surname, object lastname, object expertType)
        {
            InitializeComponent();
            id_expert = id;
            fname_expert = fname.ToString();
            surname_expert = surname.ToString();
            lastname_expert = lastname.ToString();
            expertTypeString = expertType.ToString();

        }
        int id_expert;
        string fname_expert;
        string surname_expert;
        string lastname_expert;
        string expertTypeString;

        private void eXPERTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eXPERTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagmentDataSet);

        }

        private void ExpertEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagmentDataSet.EXPERTS' table. You can move, or remove it, as needed.
            this.eXPERTSTableAdapter.Fill(this.projectManagmentDataSet.EXPERTS);
            if (this.expertTypeString.ToString().Equals("E"))
            {
                comboBoxExpert_Type.SelectedIndex = 1;
            }
            else
            {
                comboBoxExpert_Type.SelectedIndex = 0;
            }
            
            eXPERT_NAMETextBox.Text = fname_expert.ToString();
            eXPERT_SURNAMETextBox.Text = surname_expert.ToString();
            eXPERT_LASTNAMETextBox.Text = lastname_expert.ToString();
            
            // this.eXPERTSTableAdapter.FillByProjectsByExpert(this.projectManagmentDataSet.EXPERTS, id_expert);




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string experttType;

            if(comboBoxExpert_Type.SelectedIndex == 0)
            {
                experttType = "I";
            }
            else
            {
                experttType = "E";
            }

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-C7ALLTO;Initial Catalog=ProjectManagment; Integrated Security=True; ");
            con.Open();
            SqlCommand command = new SqlCommand("UPDATE EXPERTS SET [EXPERT_TYPE] = @EXPERT_TYPE, [EXPERT_NAME] = @EXPERT_NAME,[EXPERT_SURNAME]=@EXPERT_SURNAME, [EXPERT_LASTNAME]= @EXPERT_LASTNAME WHERE [EXPRET_ID]=@EXPERT_ID ", con);
            command.Parameters.AddWithValue("@EXPERT_ID", this.id_expert);
            command.Parameters.AddWithValue("@EXPERT_TYPE", experttType);
            command.Parameters.AddWithValue("@EXPERT_NAME", eXPERT_NAMETextBox.Text);
            command.Parameters.AddWithValue("@EXPERT_SURNAME", eXPERT_SURNAMETextBox.Text);
            command.Parameters.AddWithValue("@EXPERT_LASTNAME", eXPERT_LASTNAMETextBox.Text);
            
            command.ExecuteNonQuery();

            MessageBox.Show("Промените са успешно записани", "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
