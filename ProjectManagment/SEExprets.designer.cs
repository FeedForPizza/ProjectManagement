namespace ProjectManagment
{
    partial class SEExprets
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EXPERT_SURNAME = new System.Windows.Forms.TextBox();
            this.cbEX_TYPE = new System.Windows.Forms.ComboBox();
            this.EXPERT_LASTNAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EXPERT_NAME = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewExperts = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eXPERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagmentDataSet = new ProjectManagment.ProjectManagmentDataSet();
            this.eXPERTSTableAdapter = new ProjectManagment.ProjectManagmentDataSetTableAdapters.EXPERTSTableAdapter();
            this.eXPERTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter1 = new ProjectManagment.ProjectManagmentDataSetTableAdapters.PROJECTSTableAdapter();
            this.eXPERTSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.eXPERTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPERTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPRETIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExperts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClearSearch);
            this.groupBox1.Controls.Add(this.EXPERT_SURNAME);
            this.groupBox1.Controls.Add(this.cbEX_TYPE);
            this.groupBox1.Controls.Add(this.EXPERT_LASTNAME);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EXPERT_NAME);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1233, 463);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Преглед и редакция на експерти";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // EXPERT_SURNAME
            // 
            this.EXPERT_SURNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EXPERT_SURNAME.Location = new System.Drawing.Point(253, 78);
            this.EXPERT_SURNAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EXPERT_SURNAME.Name = "EXPERT_SURNAME";
            this.EXPERT_SURNAME.Size = new System.Drawing.Size(219, 27);
            this.EXPERT_SURNAME.TabIndex = 28;
            // 
            // cbEX_TYPE
            // 
            this.cbEX_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEX_TYPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbEX_TYPE.FormattingEnabled = true;
            this.cbEX_TYPE.Items.AddRange(new object[] {
            "Вътрешен",
            "Външен"});
            this.cbEX_TYPE.Location = new System.Drawing.Point(679, 78);
            this.cbEX_TYPE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEX_TYPE.Name = "cbEX_TYPE";
            this.cbEX_TYPE.Size = new System.Drawing.Size(219, 28);
            this.cbEX_TYPE.TabIndex = 27;
            this.cbEX_TYPE.SelectedIndexChanged += new System.EventHandler(this.EXPERT_TYPE_SelectedIndexChanged);
            // 
            // EXPERT_LASTNAME
            // 
            this.EXPERT_LASTNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EXPERT_LASTNAME.Location = new System.Drawing.Point(679, 39);
            this.EXPERT_LASTNAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EXPERT_LASTNAME.Name = "EXPERT_LASTNAME";
            this.EXPERT_LASTNAME.Size = new System.Drawing.Size(219, 27);
            this.EXPERT_LASTNAME.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(107, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Презиме:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(533, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Фамилия:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(300, 121);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 43);
            this.button1.TabIndex = 23;
            this.button1.Text = "Търси";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(533, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Тип експерт:";
            // 
            // EXPERT_NAME
            // 
            this.EXPERT_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EXPERT_NAME.Location = new System.Drawing.Point(253, 39);
            this.EXPERT_NAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EXPERT_NAME.Name = "EXPERT_NAME";
            this.EXPERT_NAME.Size = new System.Drawing.Size(219, 27);
            this.EXPERT_NAME.TabIndex = 21;
            this.EXPERT_NAME.TextChanged += new System.EventHandler(this.textBoxExName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(107, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Име:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewExperts);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(5, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1221, 263);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Регистър - експерти:";
            // 
            // dataGridViewExperts
            // 
            this.dataGridViewExperts.AutoGenerateColumns = false;
            this.dataGridViewExperts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExperts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eXPRETIDDataGridViewTextBoxColumn,
            this.eXPERTNAMEDataGridViewTextBoxColumn,
            this.eXPERTSURNAMEDataGridViewTextBoxColumn,
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn,
            this.eXPERTTYPEDataGridViewTextBoxColumn,
            this.Column1,
            this.Edit});
            this.dataGridViewExperts.DataSource = this.eXPERTSBindingSource;
            this.dataGridViewExperts.Location = new System.Drawing.Point(5, 25);
            this.dataGridViewExperts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewExperts.Name = "dataGridViewExperts";
            this.dataGridViewExperts.RowHeadersWidth = 51;
            this.dataGridViewExperts.RowTemplate.Height = 29;
            this.dataGridViewExperts.Size = new System.Drawing.Size(1208, 234);
            this.dataGridViewExperts.TabIndex = 4;
            this.dataGridViewExperts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExperts_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Редакция";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EXPRET_ID";
            this.Column1.HeaderText = "Виж проекти";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
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
            // eXPERTSTableAdapter
            // 
            this.eXPERTSTableAdapter.ClearBeforeFill = true;
            // 
            // eXPERTSBindingSource1
            // 
            this.eXPERTSBindingSource1.DataMember = "EXPERTS";
            this.eXPERTSBindingSource1.DataSource = this.projectManagmentDataSet;
            // 
            // projectsTableAdapter1
            // 
            this.projectsTableAdapter1.ClearBeforeFill = true;
            // 
            // eXPERTSBindingSource2
            // 
            this.eXPERTSBindingSource2.DataMember = "EXPERTS";
            this.eXPERTSBindingSource2.DataSource = this.projectManagmentDataSet;
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.Location = new System.Drawing.Point(597, 121);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(174, 43);
            this.buttonClearSearch.TabIndex = 29;
            this.buttonClearSearch.Text = "Изчисти";
            this.buttonClearSearch.UseVisualStyleBackColor = true;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
            // 
            // eXPERTTYPEDataGridViewTextBoxColumn
            // 
            this.eXPERTTYPEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_TYPE";
            this.eXPERTTYPEDataGridViewTextBoxColumn.HeaderText = "Тип екперт";
            this.eXPERTTYPEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXPERTTYPEDataGridViewTextBoxColumn.Name = "eXPERTTYPEDataGridViewTextBoxColumn";
            this.eXPERTTYPEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eXPERTLASTNAMEDataGridViewTextBoxColumn
            // 
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_LASTNAME";
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.Name = "eXPERTLASTNAMEDataGridViewTextBoxColumn";
            this.eXPERTLASTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eXPERTSURNAMEDataGridViewTextBoxColumn
            // 
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_SURNAME";
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.HeaderText = "Презиме";
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.Name = "eXPERTSURNAMEDataGridViewTextBoxColumn";
            this.eXPERTSURNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eXPERTNAMEDataGridViewTextBoxColumn
            // 
            this.eXPERTNAMEDataGridViewTextBoxColumn.DataPropertyName = "EXPERT_NAME";
            this.eXPERTNAMEDataGridViewTextBoxColumn.HeaderText = "Име";
            this.eXPERTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXPERTNAMEDataGridViewTextBoxColumn.Name = "eXPERTNAMEDataGridViewTextBoxColumn";
            this.eXPERTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eXPRETIDDataGridViewTextBoxColumn
            // 
            this.eXPRETIDDataGridViewTextBoxColumn.DataPropertyName = "EXPRET_ID";
            this.eXPRETIDDataGridViewTextBoxColumn.HeaderText = "Експерт ID";
            this.eXPRETIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eXPRETIDDataGridViewTextBoxColumn.Name = "eXPRETIDDataGridViewTextBoxColumn";
            this.eXPRETIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eXPRETIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // SEExprets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1257, 487);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SEExprets";
            this.Text = "Преглед и редакция на експерти ";
            this.Load += new System.EventHandler(this.SEExprets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExperts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EXPERT_SURNAME;
        private System.Windows.Forms.ComboBox cbEX_TYPE;
        private System.Windows.Forms.TextBox EXPERT_LASTNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EXPERT_NAME;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewExperts;
        private ProjectManagmentDataSet projectManagmentDataSet;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource;
        private ProjectManagmentDataSetTableAdapters.EXPERTSTableAdapter eXPERTSTableAdapter;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource1;
        private ProjectManagmentDataSetTableAdapters.PROJECTSTableAdapter projectsTableAdapter1;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource2;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPRETIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTLASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPERTTYPEDataGridViewTextBoxColumn;
    }
}