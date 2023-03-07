using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusImplementation
{
    public partial class StatusImp : Form
    {
        public StatusImp()
        {
            InitializeComponent();
        }
        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //При обвързване с базата.

            /*
            List<Statuses> list = new List<Statuses>();
            list.Add(new Statuses() { ID = "01", Name = "Нов" });
            list.Add(new Statuses() { ID = "02", Name = "В изпълнение" });
            list.Add(new Statuses() { ID = "03", Name = "Прекратен" });
            list.Add(new Statuses() { ID = "04", Name = "Замразен" });
            list.Add(new Statuses() { ID = "05", Name = "Изпълнен" });


            cboStatus.DataSource = list;
            cboStatus.ValueMember = "ID";
            cboStatus.DisplayMember = "Name";
            */
        }

        private void cboStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cboStatus.SelectedItem == null)
            {
                errorProvider1.SetError(cboStatus, "Моля изберете статус!");
            }
            else if (cboStatus.SelectedItem == "Нов")
            {
                cboStatus.Items.Clear();

                cboStatus.Items.Add("В изпълнение");
                cboStatus.Items.Add("Прекратен");
                cboStatus.Items.Add("Замразен");
                cboStatus.Items.Add("Изпълнен");

                MessageBox.Show($"Статуса на проекта е променен.");
            }
            else if (cboStatus.SelectedItem == "В изпълнение")
            {
                cboStatus.Items.Clear();

                cboStatus.Items.Add("Прекратен");
                cboStatus.Items.Add("Замразен");
                cboStatus.Items.Add("Изпълнен");

                MessageBox.Show($"Статуса на проекта е променен.");
            }
            else if(cboStatus.SelectedItem == "Прекратен")
            {
                cboStatus.Items.Clear();

                cboStatus.Items.Add("В изпълнение");

                MessageBox.Show($"Статуса на проекта е променен.");
            }
            else if (cboStatus.SelectedItem == "Замразен")
            {
                cboStatus.Items.Clear();

                cboStatus.Items.Add("В изпълнение");

                MessageBox.Show($"Статуса на проекта е променен.");
            }
            else if (cboStatus.SelectedItem == "Изпълнен")
            {
                cboStatus.Items.Clear();

                MessageBox.Show($"Статуса на проекта е променен.");
            }
        }
    }
}
