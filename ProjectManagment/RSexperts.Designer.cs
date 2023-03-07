namespace ProjectManagment
{
    partial class RSexperts
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupboxRegister = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bSavePersonalData = new System.Windows.Forms.Button();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lPhone = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.eXPERTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagmentDataSet = new ProjectManagment.ProjectManagmentDataSet();
            this.eXPERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eXPERTSTableAdapter = new ProjectManagment.ProjectManagmentDataSetTableAdapters.EXPERTSTableAdapter();
            this.tableAdapterManager = new ProjectManagment.ProjectManagmentDataSetTableAdapters.TableAdapterManager();
            this.pROJECTSTableAdapter = new ProjectManagment.ProjectManagmentDataSetTableAdapters.PROJECTSTableAdapter();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupboxRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(619, 144);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(267, 69);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Търсене и редакция на ескперти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupboxRegister
            // 
            this.groupboxRegister.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupboxRegister.Controls.Add(this.cbType);
            this.groupboxRegister.Controls.Add(this.tbLastname);
            this.groupboxRegister.Controls.Add(this.label2);
            this.groupboxRegister.Controls.Add(this.label1);
            this.groupboxRegister.Controls.Add(this.bSavePersonalData);
            this.groupboxRegister.Controls.Add(this.tbSurname);
            this.groupboxRegister.Controls.Add(this.lPhone);
            this.groupboxRegister.Controls.Add(this.tbName);
            this.groupboxRegister.Controls.Add(this.lName);
            this.groupboxRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupboxRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupboxRegister.Location = new System.Drawing.Point(71, 34);
            this.groupboxRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupboxRegister.Name = "groupboxRegister";
            this.groupboxRegister.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupboxRegister.Size = new System.Drawing.Size(468, 336);
            this.groupboxRegister.TabIndex = 21;
            this.groupboxRegister.TabStop = false;
            this.groupboxRegister.Text = "Регистрация на експерт:";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Вътрешен",
            "Външен"});
            this.cbType.Location = new System.Drawing.Point(159, 215);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(265, 30);
            this.cbType.TabIndex = 10;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(159, 166);
            this.tbLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(265, 28);
            this.tbLastname.TabIndex = 9;
            this.tbLastname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Презиме:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия:";
            // 
            // bSavePersonalData
            // 
            this.bSavePersonalData.Location = new System.Drawing.Point(109, 268);
            this.bSavePersonalData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSavePersonalData.Name = "bSavePersonalData";
            this.bSavePersonalData.Size = new System.Drawing.Size(228, 43);
            this.bSavePersonalData.TabIndex = 6;
            this.bSavePersonalData.Text = "Регистрирай ме";
            this.bSavePersonalData.UseVisualStyleBackColor = true;
            this.bSavePersonalData.Click += new System.EventHandler(this.bSavePersonalData_Click);
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(159, 110);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(265, 28);
            this.tbSurname.TabIndex = 5;
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(11, 219);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(118, 22);
            this.lPhone.TabIndex = 2;
            this.lPhone.Text = "Тип експерт:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(159, 58);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(265, 28);
            this.tbName.TabIndex = 1;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(11, 62);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(51, 22);
            this.lName.TabIndex = 0;
            this.lName.Text = "Име:";
            // 
            // eXPERTSBindingSource1
            // 
            this.eXPERTSBindingSource1.DataMember = "EXPERTS";
            this.eXPERTSBindingSource1.DataSource = this.projectManagmentDataSet;
            // 
            // projectManagmentDataSet
            // 
            this.projectManagmentDataSet.DataSetName = "ProjectManagmentDataSet";
            this.projectManagmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eXPERTSBindingSource
            // 
            this.eXPERTSBindingSource.DataMember = "EXPERTS";
            this.eXPERTSBindingSource.DataSource = this.projectManagmentDataSet;
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
            this.tableAdapterManager.PROJECTSTableAdapter = this.pROJECTSTableAdapter;
            this.tableAdapterManager.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectManagment.ProjectManagmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pROJECTSTableAdapter
            // 
            this.pROJECTSTableAdapter.ClearBeforeFill = true;
            // 
            // pROJECTSBindingSource
            // 
            this.pROJECTSBindingSource.DataMember = "PROJECTS";
            this.pROJECTSBindingSource.DataSource = this.projectManagmentDataSet;
            // 
            // pROJECTSBindingSource1
            // 
            this.pROJECTSBindingSource1.DataMember = "PROJECTS";
            this.pROJECTSBindingSource1.DataSource = this.projectManagmentDataSet;
            // 
            // RSexperts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1053, 378);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupboxRegister);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RSexperts";
            this.Text = "Регистър експерти";
            this.Load += new System.EventHandler(this.RSexperts_Load);
            this.groupboxRegister.ResumeLayout(false);
            this.groupboxRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupboxRegister;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSavePersonalData;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lName;
        private ProjectManagmentDataSet projectManagmentDataSet;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource;
        private ProjectManagmentDataSetTableAdapters.EXPERTSTableAdapter eXPERTSTableAdapter;
        private ProjectManagmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource1;
        private ProjectManagmentDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource1;
    }
}