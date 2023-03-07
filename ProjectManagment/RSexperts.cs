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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectManagment
{
    public partial class RSexperts : Form
    {
        public RSexperts()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SEExprets sEExprets = new SEExprets();
            sEExprets.Show();
            this.Close();
        }

        private void eXPERTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eXPERTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagmentDataSet);

        }

        private void RSexperts_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;

            // TODO: This line of code loads data into the 'projectManagmentDataSet.PROJECTS' table. You can move, or remove it, as needed.
            this.pROJECTSTableAdapter.Fill(this.projectManagmentDataSet.PROJECTS);
            // TODO: This line of code loads data into the 'projectManagmentDataSet.EXPERTS' table. You can move, or remove it, as needed.
            this.eXPERTSTableAdapter.Fill(this.projectManagmentDataSet.EXPERTS);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bSavePersonalData_Click(object sender, EventArgs e)
        {

            string expertType = cbType.Text;
            if (cbType.SelectedIndex == 0)
            {
                expertType = "I";
            }
            else if (cbType.SelectedIndex == 1)
            {
                expertType = "E";
            }


            string expertName = tbName.Text;
            if (expertName == String.Empty)
            {
                MessageBox.Show("Име на експерт е задължително поле", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string expertSurname = tbSurname.Text;
            if (expertSurname == String.Empty)
            {
                MessageBox.Show("Презиме на експерт е задължително поле", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string expertLastname = tbLastname.Text;
            if (expertLastname == String.Empty)
            {
                MessageBox.Show("Фамилия на експерт е задължително поле", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (expertType == String.Empty)
            {
                MessageBox.Show("Тип експерт е задължително поле", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            eXPERTSTableAdapter.Insert( expertType, expertName, expertSurname, expertLastname); 
            MessageBox.Show("Експертът е регистриран успешно", "Нов проект", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void eXPERTSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.eXPERTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectManagmentDataSet);

        }
    }
}
