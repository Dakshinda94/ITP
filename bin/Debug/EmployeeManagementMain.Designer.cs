namespace ITP
{
    partial class EmployeeManagementMain
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.position = new FontAwesome.Sharp.IconButton();
            this.btnCalculateSalary = new FontAwesome.Sharp.IconButton();
            this.btnAttendance = new FontAwesome.Sharp.IconButton();
            this.btnSalaryPayment = new FontAwesome.Sharp.IconButton();
            this.btnEmployee = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.position);
            this.panelMenu.Controls.Add(this.btnCalculateSalary);
            this.panelMenu.Controls.Add(this.btnAttendance);
            this.panelMenu.Controls.Add(this.btnSalaryPayment);
            this.panelMenu.Controls.Add(this.btnEmployee);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 603);
            this.panelMenu.TabIndex = 0;
            // 
            // position
            // 
            this.position.FlatAppearance.BorderSize = 0;
            this.position.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.position.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.position.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.position.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.position.IconColor = System.Drawing.Color.White;
            this.position.IconSize = 32;
            this.position.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.position.Location = new System.Drawing.Point(0, 386);
            this.position.Name = "position";
            this.position.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.position.Rotation = 0D;
            this.position.Size = new System.Drawing.Size(220, 60);
            this.position.TabIndex = 6;
            this.position.Text = "Position";
            this.position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.position.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.position.UseVisualStyleBackColor = true;
            this.position.Click += new System.EventHandler(this.position_Click);
            // 
            // btnCalculateSalary
            // 
            this.btnCalculateSalary.FlatAppearance.BorderSize = 0;
            this.btnCalculateSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateSalary.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCalculateSalary.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCalculateSalary.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnCalculateSalary.IconColor = System.Drawing.Color.White;
            this.btnCalculateSalary.IconSize = 32;
            this.btnCalculateSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculateSalary.Location = new System.Drawing.Point(0, 320);
            this.btnCalculateSalary.Name = "btnCalculateSalary";
            this.btnCalculateSalary.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCalculateSalary.Rotation = 0D;
            this.btnCalculateSalary.Size = new System.Drawing.Size(220, 60);
            this.btnCalculateSalary.TabIndex = 5;
            this.btnCalculateSalary.Text = "Calculate Salary";
            this.btnCalculateSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculateSalary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculateSalary.UseVisualStyleBackColor = true;
            this.btnCalculateSalary.Click += new System.EventHandler(this.btnCalculateSalary_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAttendance.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAttendance.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnAttendance.IconColor = System.Drawing.Color.White;
            this.btnAttendance.IconSize = 32;
            this.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.Location = new System.Drawing.Point(0, 260);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAttendance.Rotation = 0D;
            this.btnAttendance.Size = new System.Drawing.Size(220, 60);
            this.btnAttendance.TabIndex = 4;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnSalaryPayment
            // 
            this.btnSalaryPayment.FlatAppearance.BorderSize = 0;
            this.btnSalaryPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaryPayment.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSalaryPayment.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSalaryPayment.IconChar = FontAwesome.Sharp.IconChar.CommentsDollar;
            this.btnSalaryPayment.IconColor = System.Drawing.Color.White;
            this.btnSalaryPayment.IconSize = 32;
            this.btnSalaryPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaryPayment.Location = new System.Drawing.Point(0, 200);
            this.btnSalaryPayment.Name = "btnSalaryPayment";
            this.btnSalaryPayment.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSalaryPayment.Rotation = 0D;
            this.btnSalaryPayment.Size = new System.Drawing.Size(220, 60);
            this.btnSalaryPayment.TabIndex = 3;
            this.btnSalaryPayment.Text = "Salary Payment";
            this.btnSalaryPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaryPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalaryPayment.UseVisualStyleBackColor = true;
            this.btnSalaryPayment.Click += new System.EventHandler(this.btnSalaryPayment_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEmployee.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnEmployee.IconColor = System.Drawing.Color.White;
            this.btnEmployee.IconSize = 32;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(0, 140);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEmployee.Rotation = 0D;
            this.btnEmployee.Size = new System.Drawing.Size(220, 60);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::ITP.Properties.Resources.logo_white;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(194, 113);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(845, 75);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTitleChildForm.Location = new System.Drawing.Point(74, 30);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(156, 17);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Employee Management";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconSize = 49;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(15, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(53, 49);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(845, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(845, 519);
            this.panelDesktop.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weligama Resort";
            // 
            // EmployeeManagementMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 603);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "EmployeeManagementMain";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnEmployee;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnAttendance;
        private FontAwesome.Sharp.IconButton btnSalaryPayment;
        private FontAwesome.Sharp.IconButton btnCalculateSalary;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton position;
    }
}