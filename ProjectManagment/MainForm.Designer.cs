namespace ProjectManagment
{
    partial class MainForm
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
            this.buttonADDPROJECTS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonADDPROJECTS
            // 
            this.buttonADDPROJECTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonADDPROJECTS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonADDPROJECTS.Location = new System.Drawing.Point(88, 137);
            this.buttonADDPROJECTS.Name = "buttonADDPROJECTS";
            this.buttonADDPROJECTS.Size = new System.Drawing.Size(260, 65);
            this.buttonADDPROJECTS.TabIndex = 1;
            this.buttonADDPROJECTS.Text = "Добавяне на проект";
            this.buttonADDPROJECTS.UseVisualStyleBackColor = true;
            this.buttonADDPROJECTS.Click += new System.EventHandler(this.buttonADDPROJECTS_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(455, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Създаване на задачи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(455, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 71);
            this.button2.TabIndex = 3;
            this.button2.Text = "Регистрация на експерти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMenu.Location = new System.Drawing.Point(332, 51);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(150, 58);
            this.lblMenu.TabIndex = 6;
            this.lblMenu.Text = "Меню";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(455, 351);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(260, 65);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Търсене и редакция на ескперти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(88, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 71);
            this.button3.TabIndex = 21;
            this.button3.Text = "Преглед и редакция на проекти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(88, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 65);
            this.button4.TabIndex = 22;
            this.button4.Text = "Търсене на проект";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonADDPROJECTS);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Управление на проекти";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonADDPROJECTS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}