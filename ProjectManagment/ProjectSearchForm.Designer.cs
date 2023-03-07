
namespace UNWE_CourseProject_TsM
{
    partial class ProjectSearchForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pROJECT_IDLabel;
            System.Windows.Forms.Label pROJECT_NAMELabel;
            System.Windows.Forms.Label pROJECT_DESCRIPTIONLabel;
            System.Windows.Forms.Label pROJECT_CLIENTLabel;
            System.Windows.Forms.Label pROJECT_BEGINLabel;
            System.Windows.Forms.Label pROJECT_ENDLabel;
            System.Windows.Forms.Label pROJECT_STATUSLabel;
            System.Windows.Forms.Label pROJECT_PAY_PER_HOURLabel;
            this.gbProjectList = new System.Windows.Forms.GroupBox();
            this.txt_projectName = new System.Windows.Forms.TextBox();
            this.textBoxProjectID = new System.Windows.Forms.TextBox();
            this.btnSearchProject = new System.Windows.Forms.Button();
            this.lblProjectState = new System.Windows.Forms.Label();
            this.cbProjectState = new System.Windows.Forms.ComboBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.lblEndDateProject = new System.Windows.Forms.Label();
            this.lblStartDateProject = new System.Windows.Forms.Label();
            this.dtpStartDateProject = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDateProject = new System.Windows.Forms.DateTimePicker();
            this.lbProjectName = new System.Windows.Forms.Label();
            this.lblProjectCode = new System.Windows.Forms.Label();
            this.lbClientName = new System.Windows.Forms.Label();
            this.gbProjectsReport = new System.Windows.Forms.GroupBox();
            this.pROJECT_TASKSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAYSLEFT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECT_TASKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagmentDataSet = new ProjectManagment.ProjectManagmentDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCosts = new System.Windows.Forms.TextBox();
            this.textBoxAllhours = new System.Windows.Forms.TextBox();
            this.textBoxNumTasks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pROJECT_TASKSTableAdapter = new ProjectManagment.ProjectManagmentDataSetTableAdapters.PROJECT_TASKSTableAdapter();
            this.tableAdapterManager = new ProjectManagment.ProjectManagmentDataSetTableAdapters.TableAdapterManager();
            this.dataSet1 = new ProjectManagment.DataSet1();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTSTableAdapter = new ProjectManagment.DataSet1TableAdapters.PROJECTSTableAdapter();
            this.tableAdapterManager1 = new ProjectManagment.DataSet1TableAdapters.TableAdapterManager();
            this.pROJECTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTSTableAdapter1 = new ProjectManagment.ProjectManagmentDataSetTableAdapters.PROJECTSTableAdapter();
            this.pROJECT_IDTextBox = new System.Windows.Forms.TextBox();
            this.pROJECT_NAMETextBox = new System.Windows.Forms.TextBox();
            this.pROJECT_DESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.pROJECT_CLIENTTextBox = new System.Windows.Forms.TextBox();
            this.pROJECT_BEGINDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pROJECT_ENDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pROJECT_STATUSTextBox = new System.Windows.Forms.TextBox();
            this.pROJECT_PAY_PER_HOURTextBox = new System.Windows.Forms.TextBox();
            pROJECT_IDLabel = new System.Windows.Forms.Label();
            pROJECT_NAMELabel = new System.Windows.Forms.Label();
            pROJECT_DESCRIPTIONLabel = new System.Windows.Forms.Label();
            pROJECT_CLIENTLabel = new System.Windows.Forms.Label();
            pROJECT_BEGINLabel = new System.Windows.Forms.Label();
            pROJECT_ENDLabel = new System.Windows.Forms.Label();
            pROJECT_STATUSLabel = new System.Windows.Forms.Label();
            pROJECT_PAY_PER_HOURLabel = new System.Windows.Forms.Label();
            this.gbProjectList.SuspendLayout();
            this.gbProjectsReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pROJECT_IDLabel
            // 
            pROJECT_IDLabel.AutoSize = true;
            pROJECT_IDLabel.Location = new System.Drawing.Point(1017, 725);
            pROJECT_IDLabel.Name = "pROJECT_IDLabel";
            pROJECT_IDLabel.Size = new System.Drawing.Size(93, 17);
            pROJECT_IDLabel.TabIndex = 26;
            pROJECT_IDLabel.Text = "PROJECT ID:";
            // 
            // pROJECT_NAMELabel
            // 
            pROJECT_NAMELabel.AutoSize = true;
            pROJECT_NAMELabel.Location = new System.Drawing.Point(1017, 753);
            pROJECT_NAMELabel.Name = "pROJECT_NAMELabel";
            pROJECT_NAMELabel.Size = new System.Drawing.Size(119, 17);
            pROJECT_NAMELabel.TabIndex = 28;
            pROJECT_NAMELabel.Text = "PROJECT NAME:";
            // 
            // pROJECT_DESCRIPTIONLabel
            // 
            pROJECT_DESCRIPTIONLabel.AutoSize = true;
            pROJECT_DESCRIPTIONLabel.Location = new System.Drawing.Point(1017, 781);
            pROJECT_DESCRIPTIONLabel.Name = "pROJECT_DESCRIPTIONLabel";
            pROJECT_DESCRIPTIONLabel.Size = new System.Drawing.Size(172, 17);
            pROJECT_DESCRIPTIONLabel.TabIndex = 30;
            pROJECT_DESCRIPTIONLabel.Text = "PROJECT DESCRIPTION:";
            // 
            // pROJECT_CLIENTLabel
            // 
            pROJECT_CLIENTLabel.AutoSize = true;
            pROJECT_CLIENTLabel.Location = new System.Drawing.Point(1017, 809);
            pROJECT_CLIENTLabel.Name = "pROJECT_CLIENTLabel";
            pROJECT_CLIENTLabel.Size = new System.Drawing.Size(128, 17);
            pROJECT_CLIENTLabel.TabIndex = 32;
            pROJECT_CLIENTLabel.Text = "PROJECT CLIENT:";
            // 
            // pROJECT_BEGINLabel
            // 
            pROJECT_BEGINLabel.AutoSize = true;
            pROJECT_BEGINLabel.Location = new System.Drawing.Point(1017, 838);
            pROJECT_BEGINLabel.Name = "pROJECT_BEGINLabel";
            pROJECT_BEGINLabel.Size = new System.Drawing.Size(122, 17);
            pROJECT_BEGINLabel.TabIndex = 34;
            pROJECT_BEGINLabel.Text = "PROJECT BEGIN:";
            // 
            // pROJECT_ENDLabel
            // 
            pROJECT_ENDLabel.AutoSize = true;
            pROJECT_ENDLabel.Location = new System.Drawing.Point(1017, 866);
            pROJECT_ENDLabel.Name = "pROJECT_ENDLabel";
            pROJECT_ENDLabel.Size = new System.Drawing.Size(109, 17);
            pROJECT_ENDLabel.TabIndex = 36;
            pROJECT_ENDLabel.Text = "PROJECT END:";
            // 
            // pROJECT_STATUSLabel
            // 
            pROJECT_STATUSLabel.AutoSize = true;
            pROJECT_STATUSLabel.Location = new System.Drawing.Point(1017, 893);
            pROJECT_STATUSLabel.Name = "pROJECT_STATUSLabel";
            pROJECT_STATUSLabel.Size = new System.Drawing.Size(135, 17);
            pROJECT_STATUSLabel.TabIndex = 38;
            pROJECT_STATUSLabel.Text = "PROJECT STATUS:";
            // 
            // pROJECT_PAY_PER_HOURLabel
            // 
            pROJECT_PAY_PER_HOURLabel.AutoSize = true;
            pROJECT_PAY_PER_HOURLabel.Location = new System.Drawing.Point(1017, 921);
            pROJECT_PAY_PER_HOURLabel.Name = "pROJECT_PAY_PER_HOURLabel";
            pROJECT_PAY_PER_HOURLabel.Size = new System.Drawing.Size(184, 17);
            pROJECT_PAY_PER_HOURLabel.TabIndex = 40;
            pROJECT_PAY_PER_HOURLabel.Text = "PROJECT PAY PER HOUR:";
            // 
            // gbProjectList
            // 
            this.gbProjectList.Controls.Add(this.txt_projectName);
            this.gbProjectList.Controls.Add(this.textBoxProjectID);
            this.gbProjectList.Controls.Add(this.btnSearchProject);
            this.gbProjectList.Controls.Add(this.lblProjectState);
            this.gbProjectList.Controls.Add(this.cbProjectState);
            this.gbProjectList.Controls.Add(this.tbClientName);
            this.gbProjectList.Controls.Add(this.lblEndDateProject);
            this.gbProjectList.Controls.Add(this.lblStartDateProject);
            this.gbProjectList.Controls.Add(this.dtpStartDateProject);
            this.gbProjectList.Controls.Add(this.dtpEndDateProject);
            this.gbProjectList.Controls.Add(this.lbProjectName);
            this.gbProjectList.Controls.Add(this.lblProjectCode);
            this.gbProjectList.Controls.Add(this.lbClientName);
            this.gbProjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gbProjectList.Location = new System.Drawing.Point(15, 14);
            this.gbProjectList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectList.Name = "gbProjectList";
            this.gbProjectList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectList.Size = new System.Drawing.Size(1789, 271);
            this.gbProjectList.TabIndex = 0;
            this.gbProjectList.TabStop = false;
            this.gbProjectList.Text = "Преглед на списък с проекти";
            this.gbProjectList.Enter += new System.EventHandler(this.gbProjectList_Enter);
            // 
            // txt_projectName
            // 
            this.txt_projectName.Location = new System.Drawing.Point(303, 102);
            this.txt_projectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_projectName.Name = "txt_projectName";
            this.txt_projectName.Size = new System.Drawing.Size(483, 28);
            this.txt_projectName.TabIndex = 13;
            // 
            // textBoxProjectID
            // 
            this.textBoxProjectID.Location = new System.Drawing.Point(303, 57);
            this.textBoxProjectID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProjectID.Name = "textBoxProjectID";
            this.textBoxProjectID.Size = new System.Drawing.Size(371, 28);
            this.textBoxProjectID.TabIndex = 12;
            // 
            // btnSearchProject
            // 
            this.btnSearchProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchProject.Location = new System.Drawing.Point(753, 201);
            this.btnSearchProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchProject.Name = "btnSearchProject";
            this.btnSearchProject.Size = new System.Drawing.Size(151, 53);
            this.btnSearchProject.TabIndex = 1;
            this.btnSearchProject.Text = "Търси";
            this.btnSearchProject.UseVisualStyleBackColor = true;
            this.btnSearchProject.Click += new System.EventHandler(this.btnSearchProject_Click);
            // 
            // lblProjectState
            // 
            this.lblProjectState.AutoSize = true;
            this.lblProjectState.Location = new System.Drawing.Point(844, 149);
            this.lblProjectState.Name = "lblProjectState";
            this.lblProjectState.Size = new System.Drawing.Size(171, 24);
            this.lblProjectState.TabIndex = 11;
            this.lblProjectState.Text = "Статус на проект:";
            // 
            // cbProjectState
            // 
            this.cbProjectState.FormattingEnabled = true;
            this.cbProjectState.Items.AddRange(new object[] {
            "Нов",
            "В изпълнение",
            "Изпълнен",
            "Прекратен",
            "Замразен"});
            this.cbProjectState.Location = new System.Drawing.Point(1096, 148);
            this.cbProjectState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProjectState.Name = "cbProjectState";
            this.cbProjectState.Size = new System.Drawing.Size(192, 30);
            this.cbProjectState.TabIndex = 10;
            this.cbProjectState.SelectedIndexChanged += new System.EventHandler(this.cbProjectState_SelectedIndexChanged);
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(303, 145);
            this.tbClientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(483, 28);
            this.tbClientName.TabIndex = 9;
            // 
            // lblEndDateProject
            // 
            this.lblEndDateProject.AutoSize = true;
            this.lblEndDateProject.Location = new System.Drawing.Point(844, 106);
            this.lblEndDateProject.Name = "lblEndDateProject";
            this.lblEndDateProject.Size = new System.Drawing.Size(153, 24);
            this.lblEndDateProject.TabIndex = 6;
            this.lblEndDateProject.Text = "Край на проект:";
            // 
            // lblStartDateProject
            // 
            this.lblStartDateProject.AutoSize = true;
            this.lblStartDateProject.Location = new System.Drawing.Point(844, 66);
            this.lblStartDateProject.Name = "lblStartDateProject";
            this.lblStartDateProject.Size = new System.Drawing.Size(173, 24);
            this.lblStartDateProject.TabIndex = 5;
            this.lblStartDateProject.Text = "Начало на проект:";
            this.lblStartDateProject.Click += new System.EventHandler(this.lblStartDateProject_Click);
            // 
            // dtpStartDateProject
            // 
            this.dtpStartDateProject.Location = new System.Drawing.Point(1096, 100);
            this.dtpStartDateProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDateProject.Name = "dtpStartDateProject";
            this.dtpStartDateProject.Size = new System.Drawing.Size(452, 28);
            this.dtpStartDateProject.TabIndex = 4;
            // 
            // dtpEndDateProject
            // 
            this.dtpEndDateProject.Location = new System.Drawing.Point(1096, 54);
            this.dtpEndDateProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndDateProject.Name = "dtpEndDateProject";
            this.dtpEndDateProject.Size = new System.Drawing.Size(452, 28);
            this.dtpEndDateProject.TabIndex = 3;
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Location = new System.Drawing.Point(19, 110);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(146, 24);
            this.lbProjectName.TabIndex = 2;
            this.lbProjectName.Text = "Име на проект:";
            // 
            // lblProjectCode
            // 
            this.lblProjectCode.AutoSize = true;
            this.lblProjectCode.Location = new System.Drawing.Point(19, 60);
            this.lblProjectCode.Name = "lblProjectCode";
            this.lblProjectCode.Size = new System.Drawing.Size(144, 24);
            this.lblProjectCode.TabIndex = 1;
            this.lblProjectCode.Text = "Код на проект:";
            // 
            // lbClientName
            // 
            this.lbClientName.AutoSize = true;
            this.lbClientName.Location = new System.Drawing.Point(19, 155);
            this.lbClientName.Name = "lbClientName";
            this.lbClientName.Size = new System.Drawing.Size(174, 24);
            this.lbClientName.TabIndex = 0;
            this.lbClientName.Text = "Клиент на проект:";
            this.lbClientName.Click += new System.EventHandler(this.lbClientName_Click);
            // 
            // gbProjectsReport
            // 
            this.gbProjectsReport.Controls.Add(this.pROJECT_TASKSDataGridView);
            this.gbProjectsReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gbProjectsReport.Location = new System.Drawing.Point(15, 303);
            this.gbProjectsReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectsReport.Name = "gbProjectsReport";
            this.gbProjectsReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbProjectsReport.Size = new System.Drawing.Size(1789, 353);
            this.gbProjectsReport.TabIndex = 3;
            this.gbProjectsReport.TabStop = false;
            this.gbProjectsReport.Text = "Детайлна информация";
            this.gbProjectsReport.Enter += new System.EventHandler(this.gbProjectsReport_Enter);
            // 
            // pROJECT_TASKSDataGridView
            // 
            this.pROJECT_TASKSDataGridView.AutoGenerateColumns = false;
            this.pROJECT_TASKSDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.pROJECT_TASKSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pROJECT_TASKSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.DAYSLEFT,
            this.GenDelay});
            this.pROJECT_TASKSDataGridView.DataSource = this.pROJECT_TASKSBindingSource;
            this.pROJECT_TASKSDataGridView.Location = new System.Drawing.Point(0, 50);
            this.pROJECT_TASKSDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.pROJECT_TASKSDataGridView.Name = "pROJECT_TASKSDataGridView";
            this.pROJECT_TASKSDataGridView.RowHeadersWidth = 51;
            this.pROJECT_TASKSDataGridView.Size = new System.Drawing.Size(1876, 281);
            this.pROJECT_TASKSDataGridView.TabIndex = 0;
            this.pROJECT_TASKSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pROJECT_TASKSDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EXPRET_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "EXPRET_ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TASK_NAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "TASK_NAME";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TASK_DESCRIPTION";
            this.dataGridViewTextBoxColumn5.HeaderText = "TASK_DESCRIPTION";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TASK_BEGIN";
            this.dataGridViewTextBoxColumn7.HeaderText = "TASK_BEGIN";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TASK_END";
            this.dataGridViewTextBoxColumn8.HeaderText = "TASK_END";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TASK_PRIORITY";
            this.dataGridViewTextBoxColumn9.HeaderText = "TASK_PRIORITY";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TASK_STATUS";
            this.dataGridViewTextBoxColumn10.HeaderText = "TASK_STATUS";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TASK_READY";
            this.dataGridViewTextBoxColumn11.HeaderText = "TASK_READY";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "TASK_HOURS";
            this.dataGridViewTextBoxColumn12.HeaderText = "TASK_HOURS";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // DAYSLEFT
            // 
            this.DAYSLEFT.HeaderText = "Дни до краен срок";
            this.DAYSLEFT.MinimumWidth = 6;
            this.DAYSLEFT.Name = "DAYSLEFT";
            this.DAYSLEFT.Width = 125;
            // 
            // GenDelay
            // 
            this.GenDelay.HeaderText = "Генерирано закъснение";
            this.GenDelay.MinimumWidth = 6;
            this.GenDelay.Name = "GenDelay";
            this.GenDelay.Width = 125;
            // 
            // pROJECT_TASKSBindingSource
            // 
            this.pROJECT_TASKSBindingSource.DataMember = "PROJECT_TASKS";
            this.pROJECT_TASKSBindingSource.DataSource = this.projectManagmentDataSet;
            // 
            // projectManagmentDataSet
            // 
            this.projectManagmentDataSet.DataSetName = "ProjectManagmentDataSet";
            this.projectManagmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCosts);
            this.groupBox2.Controls.Add(this.textBoxAllhours);
            this.groupBox2.Controls.Add(this.textBoxNumTasks);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox2.Location = new System.Drawing.Point(15, 702);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(933, 244);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обобщена информация";
            // 
            // textBoxCosts
            // 
            this.textBoxCosts.Location = new System.Drawing.Point(576, 175);
            this.textBoxCosts.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCosts.Name = "textBoxCosts";
            this.textBoxCosts.Size = new System.Drawing.Size(261, 28);
            this.textBoxCosts.TabIndex = 5;
            this.textBoxCosts.TextChanged += new System.EventHandler(this.textBoxCosts_TextChanged);
            // 
            // textBoxAllhours
            // 
            this.textBoxAllhours.Location = new System.Drawing.Point(576, 108);
            this.textBoxAllhours.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAllhours.Name = "textBoxAllhours";
            this.textBoxAllhours.Size = new System.Drawing.Size(261, 28);
            this.textBoxAllhours.TabIndex = 4;
            this.textBoxAllhours.TextChanged += new System.EventHandler(this.textBoxAllhours_TextChanged);
            // 
            // textBoxNumTasks
            // 
            this.textBoxNumTasks.Location = new System.Drawing.Point(576, 53);
            this.textBoxNumTasks.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumTasks.Name = "textBoxNumTasks";
            this.textBoxNumTasks.Size = new System.Drawing.Size(261, 28);
            this.textBoxNumTasks.TabIndex = 3;
            this.textBoxNumTasks.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Общ размер на разхода към момента: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Общ брой отработени часове: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Общ брой задачи:";
            // 
            // pROJECT_TASKSTableAdapter
            // 
            this.pROJECT_TASKSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EXPERTSTableAdapter = null;
            this.tableAdapterManager.PROJECT_STATUSTableAdapter = null;
            this.tableAdapterManager.PROJECT_TASKSTableAdapter = this.pROJECT_TASKSTableAdapter;
            this.tableAdapterManager.PROJECTSTableAdapter = null;
            this.tableAdapterManager.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectManagment.ProjectManagmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJECTSBindingSource
            // 
            this.pROJECTSBindingSource.DataMember = "PROJECTS";
            this.pROJECTSBindingSource.DataSource = this.dataSet1;
            // 
            // pROJECTSTableAdapter
            // 
            this.pROJECTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.EXPERTSTableAdapter = null;
            this.tableAdapterManager1.PROJECT_STATUSTableAdapter = null;
            this.tableAdapterManager1.PROJECT_TASKSTableAdapter = null;
            this.tableAdapterManager1.PROJECTSTableAdapter = this.pROJECTSTableAdapter;
            this.tableAdapterManager1.statesTableAdapter = null;
            this.tableAdapterManager1.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ProjectManagment.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pROJECTSBindingSource1
            // 
            this.pROJECTSBindingSource1.DataMember = "PROJECTS";
            this.pROJECTSBindingSource1.DataSource = this.projectManagmentDataSet;
            // 
            // pROJECTSTableAdapter1
            // 
            this.pROJECTSTableAdapter1.ClearBeforeFill = true;
            // 
            // pROJECT_IDTextBox
            // 
            this.pROJECT_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJECTSBindingSource1, "PROJECT_ID", true));
            this.pROJECT_IDTextBox.Location = new System.Drawing.Point(1207, 722);
            this.pROJECT_IDTextBox.Name = "pROJECT_IDTextBox";
            this.pROJECT_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.pROJECT_IDTextBox.TabIndex = 27;
            // 
            // pROJECT_NAMETextBox
            // 
            this.pROJECT_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJECTSBindingSource1, "PROJECT_NAME", true));
            this.pROJECT_NAMETextBox.Location = new System.Drawing.Point(1207, 750);
            this.pROJECT_NAMETextBox.Name = "pROJECT_NAMETextBox";
            this.pROJECT_NAMETextBox.Size = new System.Drawing.Size(200, 22);
            this.pROJECT_NAMETextBox.TabIndex = 29;
            // 
            // pROJECT_DESCRIPTIONTextBox
            // 
            this.pROJECT_DESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJECTSBindingSource1, "PROJECT_DESCRIPTION", true));
            this.pROJECT_DESCRIPTIONTextBox.Location = new System.Drawing.Point(1207, 778);
            this.pROJECT_DESCRIPTIONTextBox.Name = "pROJECT_DESCRIPTIONTextBox";
            this.pROJECT_DESCRIPTIONTextBox.Size = new System.Drawing.Size(200, 22);
            this.pROJECT_DESCRIPTIONTextBox.TabIndex = 31;
            // 
            // pROJECT_CLIENTTextBox
            // 
            this.pROJECT_CLIENTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJECTSBindingSource1, "PROJECT_CLIENT", true));
            this.pROJECT_CLIENTTextBox.Location = new System.Drawing.Point(1207, 806);
            this.pROJECT_CLIENTTextBox.Name = "pROJECT_CLIENTTextBox";
            this.pROJECT_CLIENTTextBox.Size = new System.Drawing.Size(200, 22);
            this.pROJECT_CLIENTTextBox.TabIndex = 33;
            // 
            // pROJECT_BEGINDateTimePicker
            // 
            this.pROJECT_BEGINDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pROJECTSBindingSource1, "PROJECT_BEGIN", true));
            this.pROJECT_BEGINDateTimePicker.Location = new System.Drawing.Point(1207, 834);
            this.pROJECT_BEGINDateTimePicker.Name = "pROJECT_BEGINDateTimePicker";
            this.pROJECT_BEGINDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.pROJECT_BEGINDateTimePicker.TabIndex = 35;
            // 
            // pROJECT_ENDDateTimePicker
            // 
            this.pROJECT_ENDDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pROJECTSBindingSource1, "PROJECT_END", true));
            this.pROJECT_ENDDateTimePicker.Location = new System.Drawing.Point(1207, 862);
            this.pROJECT_ENDDateTimePicker.Name = "pROJECT_ENDDateTimePicker";
            this.pROJECT_ENDDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.pROJECT_ENDDateTimePicker.TabIndex = 37;
            // 
            // pROJECT_STATUSTextBox
            // 
            this.pROJECT_STATUSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJECTSBindingSource1, "PROJECT_STATUS", true));
            this.pROJECT_STATUSTextBox.Location = new System.Drawing.Point(1207, 890);
            this.pROJECT_STATUSTextBox.Name = "pROJECT_STATUSTextBox";
            this.pROJECT_STATUSTextBox.Size = new System.Drawing.Size(200, 22);
            this.pROJECT_STATUSTextBox.TabIndex = 39;
            // 
            // pROJECT_PAY_PER_HOURTextBox
            // 
            this.pROJECT_PAY_PER_HOURTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pROJECTSBindingSource1, "PROJECT_PAY_PER_HOUR", true));
            this.pROJECT_PAY_PER_HOURTextBox.Location = new System.Drawing.Point(1207, 918);
            this.pROJECT_PAY_PER_HOURTextBox.Name = "pROJECT_PAY_PER_HOURTextBox";
            this.pROJECT_PAY_PER_HOURTextBox.Size = new System.Drawing.Size(200, 22);
            this.pROJECT_PAY_PER_HOURTextBox.TabIndex = 41;
            // 
            // ProjectSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(pROJECT_IDLabel);
            this.Controls.Add(this.pROJECT_IDTextBox);
            this.Controls.Add(pROJECT_NAMELabel);
            this.Controls.Add(this.pROJECT_NAMETextBox);
            this.Controls.Add(pROJECT_DESCRIPTIONLabel);
            this.Controls.Add(this.pROJECT_DESCRIPTIONTextBox);
            this.Controls.Add(pROJECT_CLIENTLabel);
            this.Controls.Add(this.pROJECT_CLIENTTextBox);
            this.Controls.Add(pROJECT_BEGINLabel);
            this.Controls.Add(this.pROJECT_BEGINDateTimePicker);
            this.Controls.Add(pROJECT_ENDLabel);
            this.Controls.Add(this.pROJECT_ENDDateTimePicker);
            this.Controls.Add(pROJECT_STATUSLabel);
            this.Controls.Add(this.pROJECT_STATUSTextBox);
            this.Controls.Add(pROJECT_PAY_PER_HOURLabel);
            this.Controls.Add(this.pROJECT_PAY_PER_HOURTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbProjectsReport);
            this.Controls.Add(this.gbProjectList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProjectSearchForm";
            this.Text = "Форма за търсене на проекти";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProjectSearchForm_Load);
            this.gbProjectList.ResumeLayout(false);
            this.gbProjectList.PerformLayout();
            this.gbProjectsReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECT_TASKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProjectList;
        private System.Windows.Forms.Label lbClientName;
        private System.Windows.Forms.Button btnSearchProject;
        private System.Windows.Forms.Label lblProjectState;
        private System.Windows.Forms.ComboBox cbProjectState;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Label lblEndDateProject;
        private System.Windows.Forms.Label lblStartDateProject;
        private System.Windows.Forms.DateTimePicker dtpStartDateProject;
        private System.Windows.Forms.DateTimePicker dtpEndDateProject;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.Label lblProjectCode;
        private System.Windows.Forms.GroupBox gbProjectsReport;
        private System.Windows.Forms.TextBox txt_projectName;
        private System.Windows.Forms.TextBox textBoxProjectID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCosts;
        private System.Windows.Forms.TextBox textBoxAllhours;
        private System.Windows.Forms.TextBox textBoxNumTasks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ProjectManagment.ProjectManagmentDataSet projectManagmentDataSet;
        private System.Windows.Forms.BindingSource pROJECT_TASKSBindingSource;
        private ProjectManagment.ProjectManagmentDataSetTableAdapters.PROJECT_TASKSTableAdapter pROJECT_TASKSTableAdapter;
        private ProjectManagment.ProjectManagmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ProjectManagment.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private ProjectManagment.DataSet1TableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
        private ProjectManagment.DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource1;
        private ProjectManagment.ProjectManagmentDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter1;
        private System.Windows.Forms.TextBox pROJECT_IDTextBox;
        private System.Windows.Forms.TextBox pROJECT_NAMETextBox;
        private System.Windows.Forms.TextBox pROJECT_DESCRIPTIONTextBox;
        private System.Windows.Forms.TextBox pROJECT_CLIENTTextBox;
        private System.Windows.Forms.DateTimePicker pROJECT_BEGINDateTimePicker;
        private System.Windows.Forms.DateTimePicker pROJECT_ENDDateTimePicker;
        private System.Windows.Forms.TextBox pROJECT_STATUSTextBox;
        private System.Windows.Forms.TextBox pROJECT_PAY_PER_HOURTextBox;
        private System.Windows.Forms.DataGridView pROJECT_TASKSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAYSLEFT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenDelay;
    }
}

