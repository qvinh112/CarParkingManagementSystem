namespace CarParkingManagementSystem
{
    partial class parkingSpace
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbParked = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIDSpace = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbParked)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ptbParked);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 180);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.parkingSpace_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.parkingSpace_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.parkingSpace_MouseLeave);
            // 
            // ptbParked
            // 
            this.ptbParked.BackColor = System.Drawing.Color.Transparent;
            this.ptbParked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbParked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbParked.Location = new System.Drawing.Point(2, 54);
            this.ptbParked.Margin = new System.Windows.Forms.Padding(0);
            this.ptbParked.Name = "ptbParked";
            this.ptbParked.Size = new System.Drawing.Size(132, 126);
            this.ptbParked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbParked.TabIndex = 23;
            this.ptbParked.TabStop = false;
            this.ptbParked.Click += new System.EventHandler(this.parkingSpace_Click);
            this.ptbParked.MouseEnter += new System.EventHandler(this.parkingSpace_MouseEnter);
            this.ptbParked.MouseLeave += new System.EventHandler(this.parkingSpace_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(2, 15);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(132, 39);
            this.panel5.TabIndex = 22;
            this.panel5.Click += new System.EventHandler(this.parkingSpace_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblIDSpace, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(132, 39);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.parkingSpace_Click);
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.parkingSpace_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.parkingSpace_MouseLeave);
            // 
            // lblIDSpace
            // 
            this.lblIDSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDSpace.AutoSize = true;
            this.lblIDSpace.BackColor = System.Drawing.Color.Transparent;
            this.lblIDSpace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIDSpace.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDSpace.ForeColor = System.Drawing.Color.Black;
            this.lblIDSpace.Location = new System.Drawing.Point(0, 0);
            this.lblIDSpace.Margin = new System.Windows.Forms.Padding(0);
            this.lblIDSpace.Name = "lblIDSpace";
            this.lblIDSpace.Size = new System.Drawing.Size(132, 18);
            this.lblIDSpace.TabIndex = 21;
            this.lblIDSpace.Text = "ID Space";
            this.lblIDSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIDSpace.Click += new System.EventHandler(this.parkingSpace_Click);
            this.lblIDSpace.MouseEnter += new System.EventHandler(this.parkingSpace_MouseEnter);
            this.lblIDSpace.MouseLeave += new System.EventHandler(this.parkingSpace_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 15);
            this.panel2.TabIndex = 20;
            this.panel2.Click += new System.EventHandler(this.parkingSpace_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.parkingSpace_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.parkingSpace_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(134, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 180);
            this.panel4.TabIndex = 1;
            this.panel4.Click += new System.EventHandler(this.parkingSpace_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 180);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.parkingSpace_Click);
            // 
            // parkingSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "parkingSpace";
            this.Size = new System.Drawing.Size(136, 180);
            this.Click += new System.EventHandler(this.parkingSpace_Click);
            this.MouseEnter += new System.EventHandler(this.parkingSpace_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.parkingSpace_MouseLeave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbParked)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblIDSpace;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptbParked;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
