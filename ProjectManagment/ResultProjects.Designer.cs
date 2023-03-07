namespace ProjectManagment
{
    partial class ResultProjects
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pROJECTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagmentDataSet = new ProjectManagment.ProjectManagmentDataSet();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTSTableAdapter = new ProjectManagment.ProjectManagmentDataSetTableAdapters.PROJECTSTableAdapter();
            this.pROJECTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTBEGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(27, 26);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1117, 296);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Регистър - проекти:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pROJECTIDDataGridViewTextBoxColumn,
            this.pROJECTNAMEDataGridViewTextBoxColumn,
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn,
            this.pROJECTCLIENTDataGridViewTextBoxColumn,
            this.pROJECTBEGINDataGridViewTextBoxColumn,
            this.pROJECTENDDataGridViewTextBoxColumn,
            this.pROJECTSTATUSDataGridViewTextBoxColumn,
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.pROJECTSBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(25, 26);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1061, 250);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // pROJECTSBindingSource1
            // 
            this.pROJECTSBindingSource1.DataMember = "PROJECTS";
            this.pROJECTSBindingSource1.DataSource = this.projectManagmentDataSet;
            // 
            // projectManagmentDataSet
            // 
            this.projectManagmentDataSet.DataSetName = "ProjectManagmentDataSet";
            this.projectManagmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJECTSBindingSource
            // 
            this.pROJECTSBindingSource.DataMember = "PROJECTS";
            this.pROJECTSBindingSource.DataSource = this.projectManagmentDataSet;
            // 
            // pROJECTSTableAdapter
            // 
            this.pROJECTSTableAdapter.ClearBeforeFill = true;
            // 
            // pROJECTIDDataGridViewTextBoxColumn
            // 
            this.pROJECTIDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_ID";
            this.pROJECTIDDataGridViewTextBoxColumn.HeaderText = "Проект ID";
            this.pROJECTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pROJECTIDDataGridViewTextBoxColumn.Name = "pROJECTIDDataGridViewTextBoxColumn";
            this.pROJECTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROJECTIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pROJECTNAMEDataGridViewTextBoxColumn
            // 
            this.pROJECTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_NAME";
            this.pROJECTNAMEDataGridViewTextBoxColumn.HeaderText = "Име ";
            this.pROJECTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pROJECTNAMEDataGridViewTextBoxColumn.Name = "pROJECTNAMEDataGridViewTextBoxColumn";
            this.pROJECTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pROJECTDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_DESCRIPTION";
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Описанние";
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.Name = "pROJECTDESCRIPTIONDataGridViewTextBoxColumn";
            this.pROJECTDESCRIPTIONDataGridViewTextBoxColumn.Width = 125;
            // 
            // pROJECTCLIENTDataGridViewTextBoxColumn
            // 
            this.pROJECTCLIENTDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_CLIENT";
            this.pROJECTCLIENTDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.pROJECTCLIENTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pROJECTCLIENTDataGridViewTextBoxColumn.Name = "pROJECTCLIENTDataGridViewTextBoxColumn";
            this.pROJECTCLIENTDataGridViewTextBoxColumn.Width = 125;
            // 
            // pROJECTBEGINDataGridViewTextBoxColumn
            // 
            this.pROJECTBEGINDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_BEGIN";
            this.pROJECTBEGINDataGridViewTextBoxColumn.HeaderText = "Дата на започване";
            this.pROJECTBEGINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pROJECTBEGINDataGridViewTextBoxColumn.Name = "pROJECTBEGINDataGridViewTextBoxColumn";
            this.pROJECTBEGINDataGridViewTextBoxColumn.Width = 125;
            // 
            // pROJECTENDDataGridViewTextBoxColumn
            // 
            this.pROJECTENDDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_END";
            this.pROJECTENDDataGridViewTextBoxColumn.HeaderText = "Дата на приключване";
            this.pROJECTENDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pROJECTENDDataGridViewTextBoxColumn.Name = "pROJECTENDDataGridViewTextBoxColumn";
            this.pROJECTENDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pROJECTSTATUSDataGridViewTextBoxColumn
            // 
            this.pROJECTSTATUSDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_STATUS";
            this.pROJECTSTATUSDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.pROJECTSTATUSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pROJECTSTATUSDataGridViewTextBoxColumn.Name = "pROJECTSTATUSDataGridViewTextBoxColumn";
            this.pROJECTSTATUSDataGridViewTextBoxColumn.Width = 125;
            // 
            // pROJECTPAYPERHOURDataGridViewTextBoxColumn
            // 
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_PAY_PER_HOUR";
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.HeaderText = "Заплащане на час";
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.Name = "pROJECTPAYPERHOURDataGridViewTextBoxColumn";
            this.pROJECTPAYPERHOURDataGridViewTextBoxColumn.Width = 125;
            // 
            // ResultProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1170, 347);
            this.Controls.Add(this.groupBox3);
            this.Name = "ResultProjects";
            this.Text = "Проекти";
            this.Load += new System.EventHandler(this.ResultProjects_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ProjectManagmentDataSet projectManagmentDataSet;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private ProjectManagmentDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTBEGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTPAYPERHOURDataGridViewTextBoxColumn;
    }
}