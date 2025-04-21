namespace CarParkingManagementSystem
{
    partial class formParkingSpace
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_SoLuongBaiDo = new System.Windows.Forms.Label();
            this.lb_SoXeDaTra = new System.Windows.Forms.Label();
            this.lb_SoTienDaTra = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgChitietBaidoxe = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnRetrieveCar = new System.Windows.Forms.Button();
            this.btnParkCar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChitietBaidoxe)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_SoLuongBaiDo
            // 
            this.lb_SoLuongBaiDo.AutoSize = true;
            this.lb_SoLuongBaiDo.BackColor = System.Drawing.Color.DarkGray;
            this.lb_SoLuongBaiDo.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLuongBaiDo.ForeColor = System.Drawing.Color.Black;
            this.lb_SoLuongBaiDo.Location = new System.Drawing.Point(281, 59);
            this.lb_SoLuongBaiDo.Margin = new System.Windows.Forms.Padding(0);
            this.lb_SoLuongBaiDo.Name = "lb_SoLuongBaiDo";
            this.lb_SoLuongBaiDo.Size = new System.Drawing.Size(46, 45);
            this.lb_SoLuongBaiDo.TabIndex = 16;
            this.lb_SoLuongBaiDo.Text = "0";
            this.lb_SoLuongBaiDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_SoXeDaTra
            // 
            this.lb_SoXeDaTra.AutoSize = true;
            this.lb_SoXeDaTra.BackColor = System.Drawing.Color.DarkGray;
            this.lb_SoXeDaTra.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoXeDaTra.ForeColor = System.Drawing.Color.Black;
            this.lb_SoXeDaTra.Location = new System.Drawing.Point(613, 59);
            this.lb_SoXeDaTra.Margin = new System.Windows.Forms.Padding(0);
            this.lb_SoXeDaTra.Name = "lb_SoXeDaTra";
            this.lb_SoXeDaTra.Size = new System.Drawing.Size(46, 45);
            this.lb_SoXeDaTra.TabIndex = 16;
            this.lb_SoXeDaTra.Text = "0";
            this.lb_SoXeDaTra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_SoTienDaTra
            // 
            this.lb_SoTienDaTra.AutoSize = true;
            this.lb_SoTienDaTra.BackColor = System.Drawing.Color.DarkGray;
            this.lb_SoTienDaTra.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoTienDaTra.ForeColor = System.Drawing.Color.Black;
            this.lb_SoTienDaTra.Location = new System.Drawing.Point(858, 59);
            this.lb_SoTienDaTra.Margin = new System.Windows.Forms.Padding(0);
            this.lb_SoTienDaTra.Name = "lb_SoTienDaTra";
            this.lb_SoTienDaTra.Size = new System.Drawing.Size(137, 45);
            this.lb_SoTienDaTra.TabIndex = 16;
            this.lb_SoTienDaTra.Text = "0.000";
            this.lb_SoTienDaTra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgChitietBaidoxe);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 561);
            this.panel1.TabIndex = 17;
            // 
            // dtgChitietBaidoxe
            // 
            this.dtgChitietBaidoxe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgChitietBaidoxe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgChitietBaidoxe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgChitietBaidoxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChitietBaidoxe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgChitietBaidoxe.Location = new System.Drawing.Point(0, 42);
            this.dtgChitietBaidoxe.Margin = new System.Windows.Forms.Padding(0);
            this.dtgChitietBaidoxe.Name = "dtgChitietBaidoxe";
            this.dtgChitietBaidoxe.RowHeadersWidth = 51;
            this.dtgChitietBaidoxe.Size = new System.Drawing.Size(983, 519);
            this.dtgChitietBaidoxe.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Controls.Add(this.txtFind);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 42);
            this.panel2.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.Image = global::CarParkingManagementSystem.Properties.Resources.printer;
            this.btnPrint.Location = new System.Drawing.Point(797, 0);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(47, 33);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "+";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(843, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 33);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = " +";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Image = global::CarParkingManagementSystem.Properties.Resources.edit__1_;
            this.btnEdit.Location = new System.Drawing.Point(889, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 33);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Image = global::CarParkingManagementSystem.Properties.Resources.delete__1_;
            this.btnDelete.Location = new System.Drawing.Point(936, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 33);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReload.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReload.Image = global::CarParkingManagementSystem.Properties.Resources.reload;
            this.btnReload.Location = new System.Drawing.Point(460, 0);
            this.btnReload.Margin = new System.Windows.Forms.Padding(0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(47, 33);
            this.btnReload.TabIndex = 19;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFind.Image = global::CarParkingManagementSystem.Properties.Resources.find;
            this.btnFind.Location = new System.Drawing.Point(409, 0);
            this.btnFind.Margin = new System.Windows.Forms.Padding(0);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(47, 33);
            this.btnFind.TabIndex = 19;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtFind
            // 
            this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(67, 0);
            this.txtFind.Margin = new System.Windows.Forms.Padding(0);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(337, 32);
            this.txtFind.TabIndex = 18;
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Find:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.DarkGray;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.Black;
            this.btnPayment.Image = global::CarParkingManagementSystem.Properties.Resources.payment_method;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(676, 23);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(319, 81);
            this.btnPayment.TabIndex = 15;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnRetrieveCar
            // 
            this.btnRetrieveCar.BackColor = System.Drawing.Color.DarkGray;
            this.btnRetrieveCar.FlatAppearance.BorderSize = 0;
            this.btnRetrieveCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieveCar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieveCar.ForeColor = System.Drawing.Color.Black;
            this.btnRetrieveCar.Image = global::CarParkingManagementSystem.Properties.Resources.retrievecar;
            this.btnRetrieveCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetrieveCar.Location = new System.Drawing.Point(344, 23);
            this.btnRetrieveCar.Margin = new System.Windows.Forms.Padding(0);
            this.btnRetrieveCar.Name = "btnRetrieveCar";
            this.btnRetrieveCar.Size = new System.Drawing.Size(319, 81);
            this.btnRetrieveCar.TabIndex = 14;
            this.btnRetrieveCar.Text = "Retrieve Car";
            this.btnRetrieveCar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRetrieveCar.UseVisualStyleBackColor = false;
            // 
            // btnParkCar
            // 
            this.btnParkCar.BackColor = System.Drawing.Color.DarkGray;
            this.btnParkCar.FlatAppearance.BorderSize = 0;
            this.btnParkCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParkCar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParkCar.ForeColor = System.Drawing.Color.Black;
            this.btnParkCar.Image = global::CarParkingManagementSystem.Properties.Resources.parkcar;
            this.btnParkCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParkCar.Location = new System.Drawing.Point(12, 23);
            this.btnParkCar.Margin = new System.Windows.Forms.Padding(0);
            this.btnParkCar.Name = "btnParkCar";
            this.btnParkCar.Size = new System.Drawing.Size(319, 81);
            this.btnParkCar.TabIndex = 13;
            this.btnParkCar.Text = "Park Car";
            this.btnParkCar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnParkCar.UseVisualStyleBackColor = false;
            // 
            // formParkingSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_SoTienDaTra);
            this.Controls.Add(this.lb_SoXeDaTra);
            this.Controls.Add(this.lb_SoLuongBaiDo);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnRetrieveCar);
            this.Controls.Add(this.btnParkCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formParkingSpace";
            this.Text = "formParkingSpace";
            this.Load += new System.EventHandler(this.formParkingSpace_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChitietBaidoxe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParkCar;
        private System.Windows.Forms.Button btnRetrieveCar;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lb_SoLuongBaiDo;
        private System.Windows.Forms.Label lb_SoXeDaTra;
        private System.Windows.Forms.Label lb_SoTienDaTra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgChitietBaidoxe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
    }
}