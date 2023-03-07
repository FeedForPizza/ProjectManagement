namespace ProjectManagment
{
    partial class AddProjects
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
            this.apGroupBox = new System.Windows.Forms.GroupBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.pROJECTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagmentDataSet1 = new ProjectManagment.ProjectManagmentDataSet();
            this.clientLabel = new System.Windows.Forms.Label();
            this.priceТextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projectDescTextBox = new System.Windows.Forms.TextBox();
            this.projectDescLabel = new System.Windows.Forms.Label();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.eXPERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagmentDataSet = new ProjectManagment.ProjectManagmentDataSet();
            this.eXPERTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eXPERTSTableAdapter = new ProjectManagment.ProjectManagmentDataSetTableAdapters.EXPERTSTableAdapter();
            this.fKPROJECTREFERENCEEXPERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECT_TASKSTableAdapter = new ProjectManagment.ProjectManagmentDataSetTableAdapters.PROJECT_TASKSTableAdapter();
            this.fKPROJECTREFERENCEEXPERTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pROJECTSTableAdapter = new ProjectManagment.ProjectManagmentDataSetTableAdapters.PROJECTSTableAdapter();
            this.apGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPROJECTREFERENCEEXPERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPROJECTREFERENCEEXPERTSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // apGroupBox
            // 
            this.apGroupBox.AutoSize = true;
            this.apGroupBox.Controls.Add(this.createBtn);
            this.apGroupBox.Controls.Add(this.clientComboBox);
            this.apGroupBox.Controls.Add(this.clientLabel);
            this.apGroupBox.Controls.Add(this.priceТextBox);
            this.apGroupBox.Controls.Add(this.statusLabel);
            this.apGroupBox.Controls.Add(this.statusComboBox);
            this.apGroupBox.Controls.Add(this.priceLabel);
            this.apGroupBox.Controls.Add(this.endLabel);
            this.apGroupBox.Controls.Add(this.endDateTimePicker);
            this.apGroupBox.Controls.Add(this.startLabel);
            this.apGroupBox.Controls.Add(this.startDateTimePicker);
            this.apGroupBox.Controls.Add(this.projectDescTextBox);
            this.apGroupBox.Controls.Add(this.projectDescLabel);
            this.apGroupBox.Controls.Add(this.projectNameTextBox);
            this.apGroupBox.Controls.Add(this.projectNameLabel);
            this.apGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.apGroupBox.Location = new System.Drawing.Point(37, 11);
            this.apGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apGroupBox.Name = "apGroupBox";
            this.apGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apGroupBox.Size = new System.Drawing.Size(665, 590);
            this.apGroupBox.TabIndex = 1;
            this.apGroupBox.TabStop = false;
            this.apGroupBox.Text = "Добави проект";
            this.apGroupBox.Enter += new System.EventHandler(this.apGroupBox_Enter);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(63, 435);
            this.createBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(492, 64);
            this.createBtn.TabIndex = 27;
            this.createBtn.Text = "Добави проект";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataSource = this.pROJECTSBindingSource;
            this.clientComboBox.DisplayMember = "PROJECT_CLIENT";
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(283, 219);
            this.clientComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(272, 30);
            this.clientComboBox.TabIndex = 15;
            this.clientComboBox.ValueMember = "PROJECT_CLIENT";
            // 
            // pROJECTSBindingSource
            // 
            this.pROJECTSBindingSource.DataMember = "PROJECTS";
            this.pROJECTSBindingSource.DataSource = this.projectManagmentDataSet1;
            // 
            // projectManagmentDataSet1
            // 
            this.projectManagmentDataSet1.DataSetName = "ProjectManagmentDataSet";
            this.projectManagmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.Location = new System.Drawing.Point(59, 222);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(167, 22);
            this.clientLabel.TabIndex = 14;
            this.clientLabel.Text = "Клиент на проект: ";
            // 
            // priceТextBox
            // 
            this.priceТextBox.Location = new System.Drawing.Point(283, 380);
            this.priceТextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceТextBox.Name = "priceТextBox";
            this.priceТextBox.Size = new System.Drawing.Size(277, 28);
            this.priceТextBox.TabIndex = 13;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(59, 337);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(164, 22);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.Text = "Статус на проект: ";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Нов",
            "В изпълнение",
            "Прекратен",
            "Замразен",
            "Приключил"});
            this.statusComboBox.Location = new System.Drawing.Point(283, 338);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(275, 30);
            this.statusComboBox.TabIndex = 10;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(59, 380);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(169, 22);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Часова ставка (лв)";
            this.priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(59, 300);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(149, 22);
            this.endLabel.TabIndex = 9;
            this.endLabel.Text = "Край на проект: ";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "dd-MMMM-yyyy";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(283, 300);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(272, 28);
            this.endDateTimePicker.TabIndex = 8;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(59, 261);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(156, 22);
            this.startLabel.TabIndex = 7;
            this.startLabel.Text = "Старт на проект: ";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "dd-MMMM-yyyy";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(283, 261);
            this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(272, 28);
            this.startDateTimePicker.TabIndex = 6;
            this.startDateTimePicker.Value = new System.DateTime(2022, 12, 18, 9, 30, 58, 0);
            // 
            // projectDescTextBox
            // 
            this.projectDescTextBox.Location = new System.Drawing.Point(283, 133);
            this.projectDescTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectDescTextBox.Multiline = true;
            this.projectDescTextBox.Name = "projectDescTextBox";
            this.projectDescTextBox.Size = new System.Drawing.Size(272, 75);
            this.projectDescTextBox.TabIndex = 5;
            // 
            // projectDescLabel
            // 
            this.projectDescLabel.AutoSize = true;
            this.projectDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectDescLabel.Location = new System.Drawing.Point(59, 133);
            this.projectDescLabel.Name = "projectDescLabel";
            this.projectDescLabel.Size = new System.Drawing.Size(190, 22);
            this.projectDescLabel.TabIndex = 4;
            this.projectDescLabel.Text = "Описание на проект: ";
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(283, 89);
            this.projectNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(272, 28);
            this.projectNameTextBox.TabIndex = 3;
            this.projectNameTextBox.TextChanged += new System.EventHandler(this.projectNameTextBox_TextChanged);
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.Location = new System.Drawing.Point(59, 89);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(143, 22);
            this.projectNameLabel.TabIndex = 2;
            this.projectNameLabel.Text = "Име на проект: ";
            this.projectNameLabel.Click += new System.EventHandler(this.projectNameLabel_Click);
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
            // eXPERTSBindingSource1
            // 
            this.eXPERTSBindingSource1.DataMember = "EXPERTS";
            this.eXPERTSBindingSource1.DataSource = this.projectManagmentDataSet1;
            // 
            // eXPERTSTableAdapter
            // 
            this.eXPERTSTableAdapter.ClearBeforeFill = true;
            // 
            // fKPROJECTREFERENCEEXPERTSBindingSource
            // 
            this.fKPROJECTREFERENCEEXPERTSBindingSource.DataMember = "FK_PROJECT__REFERENCE_EXPERTS";
            this.fKPROJECTREFERENCEEXPERTSBindingSource.DataSource = this.eXPERTSBindingSource;
            // 
            // pROJECT_TASKSTableAdapter
            // 
            this.pROJECT_TASKSTableAdapter.ClearBeforeFill = true;
            // 
            // fKPROJECTREFERENCEEXPERTSBindingSource1
            // 
            this.fKPROJECTREFERENCEEXPERTSBindingSource1.DataMember = "FK_PROJECT__REFERENCE_EXPERTS";
            this.fKPROJECTREFERENCEEXPERTSBindingSource1.DataSource = this.eXPERTSBindingSource;
            // 
            // pROJECTSTableAdapter
            // 
            this.pROJECTSTableAdapter.ClearBeforeFill = true;
            // 
            // AddProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(743, 610);
            this.Controls.Add(this.apGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProjects";
            this.Text = "Добавяне на проект";
            this.Load += new System.EventHandler(this.AddProjects_Load);
            this.apGroupBox.ResumeLayout(false);
            this.apGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROJECTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXPERTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPROJECTREFERENCEEXPERTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPROJECTREFERENCEEXPERTSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox apGroupBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.TextBox priceТextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.TextBox projectDescTextBox;
        private System.Windows.Forms.Label projectDescLabel;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Label projectNameLabel;
        private ProjectManagmentDataSet projectManagmentDataSet;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource;
        private ProjectManagmentDataSetTableAdapters.EXPERTSTableAdapter eXPERTSTableAdapter;
        private System.Windows.Forms.BindingSource fKPROJECTREFERENCEEXPERTSBindingSource;
        private ProjectManagmentDataSetTableAdapters.PROJECT_TASKSTableAdapter pROJECT_TASKSTableAdapter;
        private System.Windows.Forms.BindingSource fKPROJECTREFERENCEEXPERTSBindingSource1;
        private ProjectManagmentDataSet projectManagmentDataSet1;
        private System.Windows.Forms.BindingSource eXPERTSBindingSource1;
        private System.Windows.Forms.BindingSource pROJECTSBindingSource;
        private ProjectManagmentDataSetTableAdapters.PROJECTSTableAdapter pROJECTSTableAdapter;
    }
}