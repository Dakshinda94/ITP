namespace ITP
{
    partial class CalculateSalary
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
            this.uuuu = new System.Windows.Forms.Label();
            this.eid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.DateTimePicker();
            this.month = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cal = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // uuuu
            // 
            this.uuuu.AutoSize = true;
            this.uuuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uuuu.Location = new System.Drawing.Point(92, 83);
            this.uuuu.Name = "uuuu";
            this.uuuu.Size = new System.Drawing.Size(42, 17);
            this.uuuu.TabIndex = 1;
            this.uuuu.Text = "EID : ";
            // 
            // eid
            // 
            this.eid.Location = new System.Drawing.Point(150, 83);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(145, 22);
            this.eid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(84, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year : ";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.BackColor = System.Drawing.Color.DarkGray;
            this.amount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.amount.Location = new System.Drawing.Point(528, 147);
            this.amount.MinimumSize = new System.Drawing.Size(150, 30);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(150, 30);
            this.amount.TabIndex = 1;
            this.amount.Text = "Salary Amount";
            this.amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(150, 130);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(200, 22);
            this.year.TabIndex = 3;
            this.year.Value = new System.DateTime(2020, 9, 12, 0, 0, 0, 0);
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(150, 179);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(200, 22);
            this.month.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Month : ";
            // 
            // cal
            // 
            this.cal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cal.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.cal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cal.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.cal.IconColor = System.Drawing.Color.WhiteSmoke;
            this.cal.IconSize = 20;
            this.cal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cal.Location = new System.Drawing.Point(309, 237);
            this.cal.Name = "cal";
            this.cal.Rotation = 0D;
            this.cal.Size = new System.Drawing.Size(126, 28);
            this.cal.TabIndex = 4;
            this.cal.Text = "Calculate";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // CalculateSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.eid);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uuuu);
            this.Name = "CalculateSalary";
            this.Text = "CalculateSalary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uuuu;
        private System.Windows.Forms.TextBox eid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.DateTimePicker year;
        private System.Windows.Forms.DateTimePicker month;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton cal;
    }
}