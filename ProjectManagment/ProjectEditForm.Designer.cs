
namespace UNWE_CourseProject_TsM
{
    partial class ProjectEditForm
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
            this.gbEditProjects = new System.Windows.Forms.GroupBox();
            this.expertComboBox = new System.Windows.Forms.ComboBox();
            this.expertLabel = new System.Windows.Forms.Label();
            this.priceТextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectCodeTextBox = new System.Windows.Forms.TextBox();
            this.projectCodeLabel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditProject = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbEditProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEditProjects
            // 
            this.gbEditProjects.Controls.Add(this.expertComboBox);
            this.gbEditProjects.Controls.Add(this.expertLabel);
            this.gbEditProjects.Controls.Add(this.priceТextBox);
            this.gbEditProjects.Controls.Add(this.statusLabel);
            this.gbEditProjects.Controls.Add(this.statusComboBox);
            this.gbEditProjects.Controls.Add(this.priceLabel);
            this.gbEditProjects.Controls.Add(this.endLabel);
            this.gbEditProjects.Controls.Add(this.endDateTimePicker);
            this.gbEditProjects.Controls.Add(this.startLabel);
            this.gbEditProjects.Controls.Add(this.startDateTimePicker);
            this.gbEditProjects.Controls.Add(this.projectNameTextBox);
            this.gbEditProjects.Controls.Add(this.projectNameLabel);
            this.gbEditProjects.Controls.Add(this.projectCodeTextBox);
            this.gbEditProjects.Controls.Add(this.projectCodeLabel);
            this.gbEditProjects.Controls.Add(this.btnCancel);
            this.gbEditProjects.Controls.Add(this.btnEditProject);
            this.gbEditProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbEditProjects.Location = new System.Drawing.Point(29, 30);
            this.gbEditProjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEditProjects.Name = "gbEditProjects";
            this.gbEditProjects.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEditProjects.Size = new System.Drawing.Size(993, 380);
            this.gbEditProjects.TabIndex = 1;
            this.gbEditProjects.TabStop = false;
            this.gbEditProjects.Text = "Редакция на проекти";
            this.gbEditProjects.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // expertComboBox
            // 
            this.expertComboBox.FormattingEnabled = true;
            this.expertComboBox.Location = new System.Drawing.Point(251, 305);
            this.expertComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expertComboBox.Name = "expertComboBox";
            this.expertComboBox.Size = new System.Drawing.Size(200, 30);
            this.expertComboBox.TabIndex = 23;
            // 
            // expertLabel
            // 
            this.expertLabel.AutoSize = true;
            this.expertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expertLabel.Location = new System.Drawing.Point(37, 313);
            this.expertLabel.Name = "expertLabel";
            this.expertLabel.Size = new System.Drawing.Size(208, 22);
            this.expertLabel.TabIndex = 22;
            this.expertLabel.Text = "Изпълнител на проект: ";
            // 
            // priceТextBox
            // 
            this.priceТextBox.Location = new System.Drawing.Point(251, 262);
            this.priceТextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceТextBox.Name = "priceТextBox";
            this.priceТextBox.Size = new System.Drawing.Size(205, 28);
            this.priceТextBox.TabIndex = 21;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(40, 230);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(164, 22);
            this.statusLabel.TabIndex = 19;
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
            this.statusComboBox.Location = new System.Drawing.Point(250, 222);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(201, 30);
            this.statusComboBox.TabIndex = 18;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(40, 268);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(137, 22);
            this.priceLabel.TabIndex = 20;
            this.priceLabel.Text = "Часова ставка:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(40, 191);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(149, 22);
            this.endLabel.TabIndex = 17;
            this.endLabel.Text = "Край на проект: ";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(251, 185);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(302, 28);
            this.endDateTimePicker.TabIndex = 16;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(40, 152);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(156, 22);
            this.startLabel.TabIndex = 15;
            this.startLabel.Text = "Старт на проект: ";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(251, 146);
            this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(302, 28);
            this.startDateTimePicker.TabIndex = 14;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectNameTextBox.Location = new System.Drawing.Point(251, 109);
            this.projectNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(205, 27);
            this.projectNameTextBox.TabIndex = 7;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.Location = new System.Drawing.Point(43, 114);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(143, 22);
            this.projectNameLabel.TabIndex = 6;
            this.projectNameLabel.Text = "Име на проект: ";
            // 
            // projectCodeTextBox
            // 
            this.projectCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectCodeTextBox.Location = new System.Drawing.Point(250, 66);
            this.projectCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectCodeTextBox.Name = "projectCodeTextBox";
            this.projectCodeTextBox.Size = new System.Drawing.Size(205, 27);
            this.projectCodeTextBox.TabIndex = 5;
            // 
            // projectCodeLabel
            // 
            this.projectCodeLabel.AutoSize = true;
            this.projectCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectCodeLabel.Location = new System.Drawing.Point(43, 67);
            this.projectCodeLabel.Name = "projectCodeLabel";
            this.projectCodeLabel.Size = new System.Drawing.Size(140, 22);
            this.projectCodeLabel.TabIndex = 4;
            this.projectCodeLabel.Text = "Код на проект: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(594, 146);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 54);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отхвърли";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditProject
            // 
            this.btnEditProject.Location = new System.Drawing.Point(594, 66);
            this.btnEditProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditProject.Name = "btnEditProject";
            this.btnEditProject.Size = new System.Drawing.Size(164, 54);
            this.btnEditProject.TabIndex = 2;
            this.btnEditProject.Text = "Запиши";
            this.btnEditProject.UseVisualStyleBackColor = true;
            this.btnEditProject.Click += new System.EventHandler(this.btnEditProject_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProjectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1073, 469);
            this.Controls.Add(this.gbEditProjects);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProjectEditForm";
            this.Text = "Форма за преглед и редакция";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProjectEditForm_Load);
            this.gbEditProjects.ResumeLayout(false);
            this.gbEditProjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEditProjects;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditProject;
        private System.Windows.Forms.ComboBox expertComboBox;
        private System.Windows.Forms.Label expertLabel;
        private System.Windows.Forms.TextBox priceТextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.TextBox projectCodeTextBox;
        private System.Windows.Forms.Label projectCodeLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}