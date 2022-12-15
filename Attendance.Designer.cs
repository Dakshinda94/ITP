namespace ITP
{
    partial class Attendance
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
            this.eidwww = new System.Windows.Forms.Label();
            this.eid = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.datewww = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aid = new System.Windows.Forms.TextBox();
            this.dataGridViewA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).BeginInit();
            this.SuspendLayout();
            // 
            // eidwww
            // 
            this.eidwww.AutoSize = true;
            this.eidwww.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eidwww.Location = new System.Drawing.Point(37, 103);
            this.eidwww.Name = "eidwww";
            this.eidwww.Size = new System.Drawing.Size(42, 17);
            this.eidwww.TabIndex = 0;
            this.eidwww.Text = "EID : ";
            // 
            // eid
            // 
            this.eid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eid.Location = new System.Drawing.Point(98, 103);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(200, 22);
            this.eid.TabIndex = 1;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(98, 151);
            this.date.MaxDate = new System.DateTime(2020, 9, 14, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(2000, 9, 14, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(227, 22);
            this.date.TabIndex = 2;
            this.date.Value = new System.DateTime(2020, 9, 14, 0, 0, 0, 0);
            // 
            // save
            // 
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.Location = new System.Drawing.Point(147, 210);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(83, 29);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // datewww
            // 
            this.datewww.AutoSize = true;
            this.datewww.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datewww.Location = new System.Drawing.Point(29, 156);
            this.datewww.Name = "datewww";
            this.datewww.Size = new System.Drawing.Size(50, 17);
            this.datewww.TabIndex = 0;
            this.datewww.Text = "Date : ";
            // 
            // delete
            // 
            this.delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete.Location = new System.Drawing.Point(262, 420);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(85, 29);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update.Location = new System.Drawing.Point(147, 420);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(85, 29);
            this.update.TabIndex = 3;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "AttendanceID : ";
            // 
            // aid
            // 
            this.aid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aid.Location = new System.Drawing.Point(147, 362);
            this.aid.Name = "aid";
            this.aid.Size = new System.Drawing.Size(200, 22);
            this.aid.TabIndex = 1;
            // 
            // dataGridViewA
            // 
            this.dataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA.Location = new System.Drawing.Point(353, 85);
            this.dataGridViewA.Name = "dataGridViewA";
            this.dataGridViewA.RowHeadersWidth = 51;
            this.dataGridViewA.RowTemplate.Height = 24;
            this.dataGridViewA.Size = new System.Drawing.Size(451, 299);
            this.dataGridViewA.TabIndex = 4;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(944, 512);
            this.Controls.Add(this.dataGridViewA);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.date);
            this.Controls.Add(this.aid);
            this.Controls.Add(this.eid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datewww);
            this.Controls.Add(this.eidwww);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eidwww;
        private System.Windows.Forms.TextBox eid;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label datewww;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aid;
        private System.Windows.Forms.DataGridView dataGridViewA;
    }
}