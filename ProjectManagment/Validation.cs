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
    public partial class Validation : Form
    {
        public Validation()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
           
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
            
            
        }

        private void Validation_Load(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBox2.PasswordChar = '*';

        }
    }
}
