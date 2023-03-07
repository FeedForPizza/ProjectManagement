
namespace ProjectManagment
{
    partial class ExpertEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label eXPERT_TYPELabel;
            System.Windows.Forms.Label eXPERT_NAMELabel;
            System.Windows.Forms.Label eXPERT_SURNAMELabel;
            System.Windows.Forms.Label eXPERT_LASTNAMELabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxExpert_Type = new System.Windows.Forms.ComboBox();
            this.eXPERT_NAMETextBox = new System.Windows.Forms.TextBox();
            this.eXPERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagmentDataSet = new ProjectManagment.ProjectManagmentDataSet();
            this.eXPERT_SURNAMETextBox = new System.Windows.Forms.TextBox();
            this.eXPERT_LASTNAMETextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.eXPERTSTableAdapter = new ProjectManagment.ProjectManagmentDataSetTableAdapters.EXPERTSTableAdapter();
            this.tableAdapterManager = new ProjectManagment.ProjectManagmentDataSetTableAdapters.TableAdapterManager();
            eXPERT_TYPELabel = new System.Windows.Forms.Label();
            eXPERT_NAMELabel = new System.Windows.Forms.Label();
            eXPERT_SURNAMELabel = new System.Windows.Forms.Label();
            eXPERT_LASTNAMELabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // eXPERT_TYPELabel
            // 
            eXPERT_TYPELabel.AutoSize = true;
            eXPERT_TYPELabel.Location = new System.Drawing.Point(13, 52);
            eXPERT_TYPELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            eXPERT_TYPELabel.Name = "eXPERT_TYPELabel";
            eXPERT_TYPELabel.Size = new System.Drawing.Size(118, 22);
            eXPERT_TYPELabel.TabIndex = 21;
            eXPERT_TYPELabel.Text = "Тип експерт:";
            // 
            // eXPERT_NAMELabel
            // 
            eXPERT_NAMELabel.AutoSize = true;
            eXPERT_NAMELabel.Location = new System.Drawing.Point(13, 95);
            eXPERT_NAMELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            eXPERT_NAMELabel.Name = "eXPERT_NAMELabel";
            eXPERT_NAMELabel.Size = new System.Drawing.Size(147, 22);
            eXPERT_NAMELabel.TabIndex = 23;
            eXPERT_NAMELabel.Text = "Име на експерт:";
            // 
            // eXPERT_SURNAMELabel
            // 
            eXPERT_SURNAMELabel.AutoSize = true;
            eXPERT_SURNAMELabel.Location = new System.Drawing.Point(367, 52);
            eXPERT_SURNAMELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            eXPERT_SURNAMELabel.Name = "eXPERT_SURNAMELabel";
            eXPERT_SURNAMELabel.Size = new System.Drawing.Size(95, 22);
            eXPERT_SURNAMELabel.TabIndex = 25;
            eXPERT_SURNAMELabel.Text = "Презиме: ";
            // 
            // eXPERT_LASTNAMELabel
            // 
            eXPERT_LASTNAMELabel.AutoSize = true;
            eXPERT_LASTNAMELabel.Location = new System.Drawing.Point(367, 95);
            eXPERT_LASTNAMELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            eXPERT_LASTNAMELabel.Name = "eXPERT_LASTNAMELabel";
            eXPERT_LASTNAMELabel.Size = new System.Drawing.Size(93, 22);
            eXPERT_LASTNAMELabel.TabIndex = 27;
            eXPERT_LASTNAMELabel.Text = "Фамилия:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxExpert_Type);
            this.groupBox1.Controls.Add(eXPERT_TYPELabel);
            this.groupBox1.Controls.Add(eXPERT_NAMELabel);
            this.groupBox1.Controls.Add(this.eXPERT_NAMETextBox);
            this.groupBox1.Controls.Add(eXPERT_SURNAMELabel);
            this.groupBox1.Controls.Add(this.eXPERT_SURNAMETextBox);
            this.groupBox1.Controls.Add(eXPERT_LASTNAMELabel);
            this.groupBox1.Controls.Add(this.eXPERT_LASTNAMETextBox);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, -1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(735, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Преглед и редакция на експерти";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxExpert_Type
            // 
            this.comboBoxExpert_Type.FormattingEnabled = true;
            this.comboBoxExpert_Type.Items.AddRange(new object[] {
            "Вътрешен",
            "Външен"});
            this.comboBoxExpert_Type.Location = new System.Drawing.Point(166, 44);
            this.comboBoxExpert_Type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxExpert_Type.Name = "comboBoxExpert_Type";
            this.comboBoxExpert_Type.Size = new System.Drawing.Size(160, 30);
            this.comboBoxExpert_Type.TabIndex = 29;
            // 
            // eXPERT_NAMETextBox
            // 
            this.eXPERT_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eXPERTSBindingSource, "EXPERT_NAME", true));
            this.eXPERT_NAMETextBox.Location = new System.Drawing.Point(194, 88);
            this.eXPERT_NAMETextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eXPERT_NAMETextBox.Name = "eXPERT_NAMETextBox";
            this.eXPERT_NAMETextBox.Size = new System.Drawing.Size(132, 28);
            this.eXPERT_NAMETextBox.TabIndex = 24;
            // 
            // eXPERTSBindingSource
            // 
            this.eXPERTSBindingSource.DataMember = "EXPERTS";
            this.eXPERTSBindingSource.DataSource = this.projectManagmentDataSet;
            // 
            // projectManagmentDataSet
            // 
            this.projectManagmentDataSet.DataSetName = "ProjectManagmentDataSet";
            this.projectManagmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXPERT_SURNAMETextBox
            // 
            this.eXPERT_SURNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eXPERTSBindingSource, "EXPERT_SURNAME", true));
            this.eXPERT_SURNAMETextBox.Location = new System.Drawing.Point(524, 44);
            this.eXPERT_SURNAMETextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eXPERT_SURNAMETextBox.Name = "eXPERT_SURNAMETextBox";
            this.eXPERT_SURNAMETextBox.Size = new System.Drawing.Size(132, 28);
            this.eXPERT_SURNAMETextBox.TabIndex = 26;
            // 
            // eXPERT_LASTNAMETextBox
            // 
            this.eXPERT_LASTNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eXPERTSBindingSource, "EXPERT_LASTNAME", true));
            this.eXPERT_LASTNAMETextBox.Location = new System.Drawing.Point(524, 88);
            this.eXPERT_LASTNAMETextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eXPERT_LASTNAMETextBox.Name = "eXPERT_LASTNAMETextBox";
            this.eXPERT_LASTNAMETextBox.Size = new System.Drawing.Size(132, 28);
            this.eXPERT_LASTNAMETextBox.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(262, 143);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 43);
            this.button3.TabIndex = 19;
            this.button3.Text = "Запази промени";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // eXPERTSTableAdapter
            // 
            this.eXPERTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EXPERTSTableAdapter = this.eXPERTSTableAdapter;
            this.tableAdapterManager.PROJECT_STATUSTableAdapter = null;
            this.tableAdapterManager.PROJECT_TASKSTableAdapter = null;
            this.tableAdapterManager.PROJECTSTableAdapter = null;
            this.tableAdapterManager.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectManagment.ProjectManagmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ExpertEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(768, 228);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExpertEditForm";
            this.Text = "ExpertEditForm";
            this.Load += new System.EventHandler(this.ExpertEditForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private ProjectManagmentDataSet projectManagmentDataSet;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource;
        private ProjectManagmentDataSetTableAdapters.EXPERTSTableAdapter eXPERTSTableAdapter;
        private ProjectManagmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox eXPERT_NAMETextBox;
        private System.Windows.Forms.TextBox eXPERT_SURNAMETextBox;
        private System.Windows.Forms.TextBox eXPERT_LASTNAMETextBox;
        private System.Windows.Forms.ComboBox comboBoxExpert_Type;
    }
}