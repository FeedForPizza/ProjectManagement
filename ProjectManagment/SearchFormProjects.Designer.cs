
namespace ProjectManagment
{
    partial class SearchFormProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchFormProjects));
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.textBoxProjectID = new System.Windows.Forms.TextBox();
            this.btnSearchProject = new System.Windows.Forms.Button();
            this.lblProjectState = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.lblEndDateProject = new System.Windows.Forms.Label();
            this.lblStartDateProject = new System.Windows.Forms.Label();
            this.dtpEndDateProject = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDateProject = new System.Windows.Forms.DateTimePicker();
            this.lbProjectName = new System.Windows.Forms.Label();
            this.lblProjectCode = new System.Windows.Forms.Label();
            this.lbClientName = new System.Windows.Forms.Label();
            this.projectManagmentDataSet = new ProjectManagment.ProjectManagmentDataSet();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTSTableAdapter = new ProjectManagment.ProjectManagmentDataSetTableAdapters.PROJECTSTableAdapter();
            this.tableAdapterManager = new ProjectManagment.ProjectManagmentDataSetTableAdapters.TableAdapterManager();
            this.pROJECTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pROJECTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pROJECTSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbProjectState = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingNavigator)).BeginInit();
            this.pROJECTSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbProjectName
            // 
            this.tbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProjectName.Location = new System.Drawing.Point(323, 80);
            this.tbProjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(483, 28);
            this.tbProjectName.TabIndex = 49;
            // 
            // textBoxProjectID
            // 
            this.textBoxProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProjectID.Location = new System.Drawing.Point(323, 35);
            this.textBoxProjectID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProjectID.Name = "textBoxProjectID";
            this.textBoxProjectID.Size = new System.Drawing.Size(371, 28);
            this.textBoxProjectID.TabIndex = 48;
            // 
            // btnSearchProject
            // 
            this.btnSearchProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchProject.Location = new System.Drawing.Point(590, 178);
            this.btnSearchProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchProject.Name = "btnSearchProject";
            this.btnSearchProject.Size = new System.Drawing.Size(151, 53);
            this.btnSearchProject.TabIndex = 38;
            this.btnSearchProject.Text = "Търси";
            this.btnSearchProject.UseVisualStyleBackColor = true;
            this.btnSearchProject.Click += new System.EventHandler(this.btnSearchProject_Click);
            // 
            // lblProjectState
            // 
            this.lblProjectState.AutoSize = true;
            this.lblProjectState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProjectState.Location = new System.Drawing.Point(864, 127);
            this.lblProjectState.Name = "lblProjectState";
            this.lblProjectState.Size = new System.Drawing.Size(159, 22);
            this.lblProjectState.TabIndex = 47;
            this.lblProjectState.Text = "Статус на проект:";
            // 
            // tbClientName
            // 
            this.tbClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbClientName.Location = new System.Drawing.Point(323, 123);
            this.tbClientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(483, 28);
            this.tbClientName.TabIndex = 45;
            // 
            // lblEndDateProject
            // 
            this.lblEndDateProject.AutoSize = true;
            this.lblEndDateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEndDateProject.Location = new System.Drawing.Point(864, 84);
            this.lblEndDateProject.Name = "lblEndDateProject";
            this.lblEndDateProject.Size = new System.Drawing.Size(144, 22);
            this.lblEndDateProject.TabIndex = 44;
            this.lblEndDateProject.Text = "Край на проект:";
            // 
            // lblStartDateProject
            // 
            this.lblStartDateProject.AutoSize = true;
            this.lblStartDateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartDateProject.Location = new System.Drawing.Point(864, 44);
            this.lblStartDateProject.Name = "lblStartDateProject";
            this.lblStartDateProject.Size = new System.Drawing.Size(165, 22);
            this.lblStartDateProject.TabIndex = 43;
            this.lblStartDateProject.Text = "Начало на проект:";
            // 
            // dtpEndDateProject
            // 
            this.dtpEndDateProject.CustomFormat = "yyyy-mm-dd";
            this.dtpEndDateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpEndDateProject.Location = new System.Drawing.Point(1116, 78);
            this.dtpEndDateProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndDateProject.Name = "dtpEndDateProject";
            this.dtpEndDateProject.Size = new System.Drawing.Size(452, 28);
            this.dtpEndDateProject.TabIndex = 42;
            // 
            // dtpStartDateProject
            // 
            this.dtpStartDateProject.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpStartDateProject.Location = new System.Drawing.Point(1116, 32);
            this.dtpStartDateProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDateProject.Name = "dtpStartDateProject";
            this.dtpStartDateProject.Size = new System.Drawing.Size(452, 28);
            this.dtpStartDateProject.TabIndex = 41;
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProjectName.Location = new System.Drawing.Point(39, 88);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(138, 22);
            this.lbProjectName.TabIndex = 40;
            this.lbProjectName.Text = "Име на проект:";
            // 
            // lblProjectCode
            // 
            this.lblProjectCode.AutoSize = true;
            this.lblProjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProjectCode.Location = new System.Drawing.Point(39, 38);
            this.lblProjectCode.Name = "lblProjectCode";
            this.lblProjectCode.Size = new System.Drawing.Size(135, 22);
            this.lblProjectCode.TabIndex = 39;
            this.lblProjectCode.Text = "Код на проект:";
            // 
            // lbClientName
            // 
            this.lbClientName.AutoSize = true;
            this.lbClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbClientName.Location = new System.Drawing.Point(39, 133);
            this.lbClientName.Name = "lbClientName";
            this.lbClientName.Size = new System.Drawing.Size(162, 22);
            this.lbClientName.TabIndex = 37;
            this.lbClientName.Text = "Клиент на проект:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EXPERTSTableAdapter = null;
            this.tableAdapterManager.PROJECT_STATUSTableAdapter = null;
            this.tableAdapterManager.PROJECT_TASKSTableAdapter = null;
            this.tableAdapterManager.PROJECTSTableAdapter = this.pROJECTSTableAdapter;
            this.tableAdapterManager.TASK_STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectManagment.ProjectManagmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pROJECTSBindingNavigator
            // 
            this.pROJECTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pROJECTSBindingNavigator.BindingSource = this.pROJECTSBindingSource;
            this.pROJECTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pROJECTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pROJECTSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pROJECTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pROJECTSBindingNavigatorSaveItem});
            this.pROJECTSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pROJECTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pROJECTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pROJECTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pROJECTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pROJECTSBindingNavigator.Name = "pROJECTSBindingNavigator";
            this.pROJECTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pROJECTSBindingNavigator.Size = new System.Drawing.Size(1924, 27);
            this.pROJECTSBindingNavigator.TabIndex = 50;
            this.pROJECTSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // pROJECTSBindingNavigatorSaveItem
            // 
            this.pROJECTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pROJECTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pROJECTSBindingNavigatorSaveItem.Image")));
            this.pROJECTSBindingNavigatorSaveItem.Name = "pROJECTSBindingNavigatorSaveItem";
            this.pROJECTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pROJECTSBindingNavigatorSaveItem.Text = "Save Data";
            this.pROJECTSBindingNavigatorSaveItem.Click += new System.EventHandler(this.pROJECTSBindingNavigatorSaveItem_Click_1);
            // 
            // pROJECTSDataGridView
            // 
            this.pROJECTSDataGridView.AutoGenerateColumns = false;
            this.pROJECTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pROJECTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.pROJECTSDataGridView.DataSource = this.pROJECTSBindingSource;
            this.pROJECTSDataGridView.Location = new System.Drawing.Point(131, 278);
            this.pROJECTSDataGridView.Name = "pROJECTSDataGridView";
            this.pROJECTSDataGridView.RowHeadersWidth = 51;
            this.pROJECTSDataGridView.RowTemplate.Height = 24;
            this.pROJECTSDataGridView.Size = new System.Drawing.Size(1657, 367);
            this.pROJECTSDataGridView.TabIndex = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PROJECT_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PROJECT_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PROJECT_DESCRIPTION";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PROJECT_CLIENT";
            this.dataGridViewTextBoxColumn4.HeaderText = "Клиент";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PROJECT_BEGIN";
            this.dataGridViewTextBoxColumn5.HeaderText = "Начало";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PROJECT_END";
            this.dataGridViewTextBoxColumn6.HeaderText = "Край";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PROJECT_STATUS";
            this.dataGridViewTextBoxColumn7.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PROJECT_PAY_PER_HOUR";
            this.dataGridViewTextBoxColumn8.HeaderText = "Часова ставка";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // cbProjectState
            // 
            this.cbProjectState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjectState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbProjectState.FormattingEnabled = true;
            this.cbProjectState.Items.AddRange(new object[] {
            "Нов",
            "В изпълнение",
            "Изпълнен",
            "Прекратен",
            "Замразен"});
            this.cbProjectState.Location = new System.Drawing.Point(1116, 127);
            this.cbProjectState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProjectState.Name = "cbProjectState";
            this.cbProjectState.Size = new System.Drawing.Size(192, 30);
            this.cbProjectState.TabIndex = 51;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(867, 178);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(151, 53);
            this.buttonClear.TabIndex = 52;
            this.buttonClear.Text = "Изчисти";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProjectCode);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.lbClientName);
            this.groupBox1.Controls.Add(this.cbProjectState);
            this.groupBox1.Controls.Add(this.lbProjectName);
            this.groupBox1.Controls.Add(this.pROJECTSDataGridView);
            this.groupBox1.Controls.Add(this.dtpStartDateProject);
            this.groupBox1.Controls.Add(this.dtpEndDateProject);
            this.groupBox1.Controls.Add(this.tbProjectName);
            this.groupBox1.Controls.Add(this.lblStartDateProject);
            this.groupBox1.Controls.Add(this.textBoxProjectID);
            this.groupBox1.Controls.Add(this.lblEndDateProject);
            this.groupBox1.Controls.Add(this.btnSearchProject);
            this.groupBox1.Controls.Add(this.tbClientName);
            this.groupBox1.Controls.Add(this.lblProjectState);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(37, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1851, 775);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Търсене на проект";
            // 
            // SearchFormProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1924, 842);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pROJECTSBindingNavigator);
            this.Name = "SearchFormProjects";
            this.Text = "SearchFormProjects";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SearchFormProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingNavigator)).EndInit();
            this.pROJECTSBindingNavigator.ResumeLayout(false);
            this.pROJECTSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.TextBox textBoxProjectID;
        private System.Windows.Forms.Button btnSearchProject;
        private System.Windows.Forms.Label lblProjectState;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Label lblEndDateProject;
        private System.Windows.Forms.Label lblStartDateProject;
        private System.Windows.Forms.DateTimePicker dtpEndDateProject;
        private System.Windows.Forms.DateTimePicker dtpStartDateProject;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.Label lblProjectCode;
        private System.Windows.Forms.Label lbClientName;
        private ProjectManagmentDataSet projectManagmentDataSet;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private ProjectManagmentDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
        private ProjectManagmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pROJECTSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pROJECTSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pROJECTSDataGridView;
        private System.Windows.Forms.ComboBox cbProjectState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}