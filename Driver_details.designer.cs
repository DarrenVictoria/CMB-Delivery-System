namespace CMB_Delivery_Management
{
    partial class Driver_details
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
            this.DriverDelete = new System.Windows.Forms.Button();
            this.DriverEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DriverLname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DriverFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DriverDelete
            // 
            this.DriverDelete.AllowDrop = true;
            this.DriverDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.DriverDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriverDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DriverDelete.Location = new System.Drawing.Point(878, 23);
            this.DriverDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DriverDelete.Name = "DriverDelete";
            this.DriverDelete.Size = new System.Drawing.Size(101, 38);
            this.DriverDelete.TabIndex = 18;
            this.DriverDelete.Text = "Delete";
            this.DriverDelete.UseVisualStyleBackColor = false;
            this.DriverDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // DriverEdit
            // 
            this.DriverEdit.AllowDrop = true;
            this.DriverEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.DriverEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriverEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DriverEdit.Location = new System.Drawing.Point(764, 23);
            this.DriverEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DriverEdit.Name = "DriverEdit";
            this.DriverEdit.Size = new System.Drawing.Size(101, 38);
            this.DriverEdit.TabIndex = 17;
            this.DriverEdit.Text = "Edit";
            this.DriverEdit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.DriverDelete);
            this.panel1.Controls.Add(this.DriverEdit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-13, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 83);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(34, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 34);
            this.label6.TabIndex = 16;
            this.label6.Text = "Detail Form";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel2.Controls.Add(this.DriverLname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.DriverFname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.Chocolate;
            this.panel2.Location = new System.Drawing.Point(40, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 460);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DriverLname
            // 
            this.DriverLname.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverLname.Location = new System.Drawing.Point(503, 120);
            this.DriverLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DriverLname.Name = "DriverLname";
            this.DriverLname.Size = new System.Drawing.Size(383, 31);
            this.DriverLname.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(498, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "Last Name :";
            // 
            // DriverFname
            // 
            this.DriverFname.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverFname.Location = new System.Drawing.Point(21, 120);
            this.DriverFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DriverFname.Name = "DriverFname";
            this.DriverFname.Size = new System.Drawing.Size(383, 31);
            this.DriverFname.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "First Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(295, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Driver Information";
            // 
            // Driver_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Driver_details";
            this.Text = "Driver_details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DriverDelete;
        private System.Windows.Forms.Button DriverEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox DriverLname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DriverFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}