namespace forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.logout = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.sallary = new System.Windows.Forms.Button();
            this.attendence = new System.Windows.Forms.Button();
            this.department = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.empdetailsgrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetailsgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.logout.Font = new System.Drawing.Font("News706 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(48, 441);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(128, 37);
            this.logout.TabIndex = 8;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.about.Font = new System.Drawing.Font("News706 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(48, 400);
            this.about.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(128, 37);
            this.about.TabIndex = 7;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.settings_Click);
            // 
            // reports
            // 
            this.reports.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.reports.Font = new System.Drawing.Font("News706 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports.Location = new System.Drawing.Point(48, 359);
            this.reports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(128, 37);
            this.reports.TabIndex = 6;
            this.reports.Text = "Reports";
            this.reports.UseVisualStyleBackColor = false;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // sallary
            // 
            this.sallary.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sallary.Font = new System.Drawing.Font("News706 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sallary.Location = new System.Drawing.Point(48, 318);
            this.sallary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sallary.Name = "sallary";
            this.sallary.Size = new System.Drawing.Size(128, 37);
            this.sallary.TabIndex = 5;
            this.sallary.Text = "Sallary";
            this.sallary.UseVisualStyleBackColor = false;
            this.sallary.Click += new System.EventHandler(this.sallary_Click);
            // 
            // attendence
            // 
            this.attendence.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.attendence.Font = new System.Drawing.Font("News706 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendence.Location = new System.Drawing.Point(48, 277);
            this.attendence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attendence.Name = "attendence";
            this.attendence.Size = new System.Drawing.Size(128, 37);
            this.attendence.TabIndex = 4;
            this.attendence.Text = "Attendance";
            this.attendence.UseVisualStyleBackColor = false;
            this.attendence.Click += new System.EventHandler(this.attendence_Click);
            // 
            // department
            // 
            this.department.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.department.Font = new System.Drawing.Font("News706 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.Location = new System.Drawing.Point(48, 236);
            this.department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(128, 37);
            this.department.TabIndex = 3;
            this.department.Text = "Department";
            this.department.UseVisualStyleBackColor = false;
            this.department.Click += new System.EventHandler(this.department_Click);
            // 
            // employee
            // 
            this.employee.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.employee.Font = new System.Drawing.Font("News706 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.Location = new System.Drawing.Point(48, 195);
            this.employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(128, 37);
            this.employee.TabIndex = 2;
            this.employee.Text = "Employees";
            this.employee.UseVisualStyleBackColor = false;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dashboard.Font = new System.Drawing.Font("News706 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.Location = new System.Drawing.Point(48, 154);
            this.dashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(128, 37);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = false;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::forms.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-19, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1013, 545);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // empdetailsgrid
            // 
            this.empdetailsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empdetailsgrid.Location = new System.Drawing.Point(347, 145);
            this.empdetailsgrid.Name = "empdetailsgrid";
            this.empdetailsgrid.RowHeadersWidth = 51;
            this.empdetailsgrid.RowTemplate.Height = 24;
            this.empdetailsgrid.Size = new System.Drawing.Size(593, 251);
            this.empdetailsgrid.TabIndex = 3;
            this.empdetailsgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empdetailsgrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("News706 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(513, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee Detais";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.empdetailsgrid);
            this.Controls.Add(this.about);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.sallary);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.attendence);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.department);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetailsgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button sallary;
        private System.Windows.Forms.Button attendence;
        private System.Windows.Forms.Button department;
        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView empdetailsgrid;
        private System.Windows.Forms.Label label1;
    }
}