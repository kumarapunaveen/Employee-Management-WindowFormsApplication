namespace EmployeeManagementSystem
{
    partial class AddEmployee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addemp_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addemp_clr = new System.Windows.Forms.Button();
            this.addemp_dlt = new System.Windows.Forms.Button();
            this.addemp_updt = new System.Windows.Forms.Button();
            this.addemp_addd = new System.Windows.Forms.Button();
            this.addemp_import = new System.Windows.Forms.Button();
            this.addemp_picture = new System.Windows.Forms.PictureBox();
            this.addemp_position = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addemp_phnumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addemp_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addemp_fullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEmp_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addemp_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 313);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(823, 192);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addemp_status);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addemp_clr);
            this.panel2.Controls.Add(this.addemp_dlt);
            this.panel2.Controls.Add(this.addemp_updt);
            this.panel2.Controls.Add(this.addemp_addd);
            this.panel2.Controls.Add(this.addemp_import);
            this.panel2.Controls.Add(this.addemp_picture);
            this.panel2.Controls.Add(this.addemp_position);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addemp_phnumber);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addemp_gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addemp_fullname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addEmp_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(21, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 223);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addemp_status
            // 
            this.addemp_status.FormattingEnabled = true;
            this.addemp_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addemp_status.Location = new System.Drawing.Point(472, 111);
            this.addemp_status.Name = "addemp_status";
            this.addemp_status.Size = new System.Drawing.Size(168, 26);
            this.addemp_status.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(406, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Status";
            // 
            // addemp_clr
            // 
            this.addemp_clr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_clr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addemp_clr.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_clr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_clr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addemp_clr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemp_clr.ForeColor = System.Drawing.Color.White;
            this.addemp_clr.Location = new System.Drawing.Point(579, 167);
            this.addemp_clr.Name = "addemp_clr";
            this.addemp_clr.Size = new System.Drawing.Size(98, 38);
            this.addemp_clr.TabIndex = 18;
            this.addemp_clr.Text = "Clear";
            this.addemp_clr.UseVisualStyleBackColor = false;
            this.addemp_clr.Click += new System.EventHandler(this.addemp_clr_Click);
            // 
            // addemp_dlt
            // 
            this.addemp_dlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_dlt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addemp_dlt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_dlt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_dlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_dlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addemp_dlt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemp_dlt.ForeColor = System.Drawing.Color.White;
            this.addemp_dlt.Location = new System.Drawing.Point(463, 167);
            this.addemp_dlt.Name = "addemp_dlt";
            this.addemp_dlt.Size = new System.Drawing.Size(98, 38);
            this.addemp_dlt.TabIndex = 17;
            this.addemp_dlt.Text = "Delete";
            this.addemp_dlt.UseVisualStyleBackColor = false;
            this.addemp_dlt.Click += new System.EventHandler(this.addemp_dlt_Click);
            // 
            // addemp_updt
            // 
            this.addemp_updt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_updt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addemp_updt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_updt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_updt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_updt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addemp_updt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemp_updt.ForeColor = System.Drawing.Color.White;
            this.addemp_updt.Location = new System.Drawing.Point(324, 167);
            this.addemp_updt.Name = "addemp_updt";
            this.addemp_updt.Size = new System.Drawing.Size(98, 38);
            this.addemp_updt.TabIndex = 16;
            this.addemp_updt.Text = "Update";
            this.addemp_updt.UseVisualStyleBackColor = false;
            this.addemp_updt.Click += new System.EventHandler(this.addemp_updt_Click);
            // 
            // addemp_addd
            // 
            this.addemp_addd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_addd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addemp_addd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_addd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_addd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemp_addd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addemp_addd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemp_addd.ForeColor = System.Drawing.Color.White;
            this.addemp_addd.Location = new System.Drawing.Point(208, 167);
            this.addemp_addd.Name = "addemp_addd";
            this.addemp_addd.Size = new System.Drawing.Size(98, 38);
            this.addemp_addd.TabIndex = 15;
            this.addemp_addd.Text = "Add";
            this.addemp_addd.UseVisualStyleBackColor = false;
            this.addemp_addd.Click += new System.EventHandler(this.addemp_addd_Click);
            // 
            // addemp_import
            // 
            this.addemp_import.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addemp_import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addemp_import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addemp_import.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemp_import.Location = new System.Drawing.Point(745, 149);
            this.addemp_import.Name = "addemp_import";
            this.addemp_import.Size = new System.Drawing.Size(96, 31);
            this.addemp_import.TabIndex = 14;
            this.addemp_import.Text = "Import";
            this.addemp_import.UseVisualStyleBackColor = false;
            this.addemp_import.Click += new System.EventHandler(this.addemp_import_Click);
            // 
            // addemp_picture
            // 
            this.addemp_picture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addemp_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addemp_picture.Location = new System.Drawing.Point(745, 39);
            this.addemp_picture.Name = "addemp_picture";
            this.addemp_picture.Size = new System.Drawing.Size(96, 104);
            this.addemp_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addemp_picture.TabIndex = 13;
            this.addemp_picture.TabStop = false;
            this.addemp_picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addemp_position
            // 
            this.addemp_position.FormattingEnabled = true;
            this.addemp_position.Items.AddRange(new object[] {
            "Front End Developer",
            "Back End Developer",
            "Data Analyst",
            "Ui/Ux Designer",
            "Business Managament"});
            this.addemp_position.Location = new System.Drawing.Point(472, 66);
            this.addemp_position.Name = "addemp_position";
            this.addemp_position.Size = new System.Drawing.Size(168, 26);
            this.addemp_position.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Position";
            // 
            // addemp_phnumber
            // 
            this.addemp_phnumber.Location = new System.Drawing.Point(472, 28);
            this.addemp_phnumber.Name = "addemp_phnumber";
            this.addemp_phnumber.Size = new System.Drawing.Size(152, 26);
            this.addemp_phnumber.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number";
            // 
            // addemp_gender
            // 
            this.addemp_gender.FormattingEnabled = true;
            this.addemp_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.addemp_gender.Location = new System.Drawing.Point(138, 119);
            this.addemp_gender.Name = "addemp_gender";
            this.addemp_gender.Size = new System.Drawing.Size(168, 26);
            this.addemp_gender.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // addemp_fullname
            // 
            this.addemp_fullname.Location = new System.Drawing.Point(138, 74);
            this.addemp_fullname.Name = "addemp_fullname";
            this.addemp_fullname.Size = new System.Drawing.Size(168, 26);
            this.addemp_fullname.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Full Name";
            // 
            // addEmp_id
            // 
            this.addEmp_id.Location = new System.Drawing.Point(138, 30);
            this.addEmp_id.Name = "addEmp_id";
            this.addEmp_id.Size = new System.Drawing.Size(133, 26);
            this.addEmp_id.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee\'s ID";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(905, 618);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addemp_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addemp_fullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEmp_id;
        private System.Windows.Forms.ComboBox addemp_gender;
        private System.Windows.Forms.TextBox addemp_phnumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox addemp_picture;
        private System.Windows.Forms.ComboBox addemp_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addemp_import;
        private System.Windows.Forms.Button addemp_clr;
        private System.Windows.Forms.Button addemp_dlt;
        private System.Windows.Forms.Button addemp_updt;
        private System.Windows.Forms.Button addemp_addd;
        private System.Windows.Forms.ComboBox addemp_status;
        private System.Windows.Forms.Label label7;
    }
}
