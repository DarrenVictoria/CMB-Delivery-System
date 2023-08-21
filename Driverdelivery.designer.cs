namespace CMB_Delivery_Management
{
    partial class Driverdelivery
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
            this.label6 = new System.Windows.Forms.Label();
            this.DriverLogout = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ActiveDriver = new System.Windows.Forms.Button();
            this.BusyDriver = new System.Windows.Forms.Button();
            this.InactiveDriver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(438, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 34);
            this.label6.TabIndex = 15;
            this.label6.Text = "All Deliveries";
            // 
            // DriverLogout
            // 
            this.DriverLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.DriverLogout.FlatAppearance.BorderSize = 0;
            this.DriverLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriverLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverLogout.ForeColor = System.Drawing.Color.White;
            this.DriverLogout.Location = new System.Drawing.Point(938, 10);
            this.DriverLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DriverLogout.Name = "DriverLogout";
            this.DriverLogout.Size = new System.Drawing.Size(121, 38);
            this.DriverLogout.TabIndex = 20;
            this.DriverLogout.Text = "Log Out";
            this.DriverLogout.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(164, 467);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Driver Status";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ActiveDriver
            // 
            this.ActiveDriver.BackColor = System.Drawing.Color.RoyalBlue;
            this.ActiveDriver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveDriver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ActiveDriver.Location = new System.Drawing.Point(68, 529);
            this.ActiveDriver.Margin = new System.Windows.Forms.Padding(4);
            this.ActiveDriver.Name = "ActiveDriver";
            this.ActiveDriver.Size = new System.Drawing.Size(100, 40);
            this.ActiveDriver.TabIndex = 22;
            this.ActiveDriver.Text = "Active";
            this.ActiveDriver.UseVisualStyleBackColor = false;
            this.ActiveDriver.Click += new System.EventHandler(this.button2_Click);
            // 
            // BusyDriver
            // 
            this.BusyDriver.BackColor = System.Drawing.Color.RoyalBlue;
            this.BusyDriver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusyDriver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BusyDriver.Location = new System.Drawing.Point(197, 529);
            this.BusyDriver.Margin = new System.Windows.Forms.Padding(4);
            this.BusyDriver.Name = "BusyDriver";
            this.BusyDriver.Size = new System.Drawing.Size(100, 40);
            this.BusyDriver.TabIndex = 23;
            this.BusyDriver.Text = "Busy";
            this.BusyDriver.UseVisualStyleBackColor = false;
            this.BusyDriver.Click += new System.EventHandler(this.button3_Click);
            // 
            // InactiveDriver
            // 
            this.InactiveDriver.BackColor = System.Drawing.Color.RoyalBlue;
            this.InactiveDriver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InactiveDriver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InactiveDriver.Location = new System.Drawing.Point(331, 529);
            this.InactiveDriver.Margin = new System.Windows.Forms.Padding(4);
            this.InactiveDriver.Name = "InactiveDriver";
            this.InactiveDriver.Size = new System.Drawing.Size(100, 40);
            this.InactiveDriver.TabIndex = 24;
            this.InactiveDriver.Text = "Inactive";
            this.InactiveDriver.UseVisualStyleBackColor = false;
            this.InactiveDriver.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6,
            this.Column9,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(68, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(946, 343);
            this.dataGridView1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(780, 477);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 58);
            this.button1.TabIndex = 26;
            this.button1.Text = "View Order Status";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DeliveryID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DriverID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Address";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Contact";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Description";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ConfirmOrder";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "PickupStatus";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "OngoingDelivery";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "DeliveryStatus";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Driverdelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.InactiveDriver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BusyDriver);
            this.Controls.Add(this.ActiveDriver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DriverLogout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Driverdelivery";
            this.Text = "Driverdelivery";
            this.Load += new System.EventHandler(this.Driverdelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DriverLogout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ActiveDriver;
        private System.Windows.Forms.Button BusyDriver;
        private System.Windows.Forms.Button InactiveDriver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}