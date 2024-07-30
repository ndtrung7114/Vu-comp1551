
namespace SchoolMangementSystem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.employee_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.employee_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.employee_clearBtn = new System.Windows.Forms.Button();
            this.employee_deleteBtn = new System.Windows.Forms.Button();
            this.employee_updateBtn = new System.Windows.Forms.Button();
            this.employee_addBtn = new System.Windows.Forms.Button();
            this.employee_role = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.employee_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.employee_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.employee_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.employee_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(18, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 279);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(22, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(798, 193);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 226);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.employee_email);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.employee_status);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.employee_clearBtn);
            this.panel3.Controls.Add(this.employee_deleteBtn);
            this.panel3.Controls.Add(this.employee_updateBtn);
            this.panel3.Controls.Add(this.employee_addBtn);
            this.panel3.Controls.Add(this.employee_role);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.employee_phone);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.employee_gender);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.employee_name);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.employee_id);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(18, 323);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(839, 215);
            this.panel3.TabIndex = 2;
            // 
            // employee_email
            // 
            this.employee_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_email.Location = new System.Drawing.Point(380, 38);
            this.employee_email.Name = "employee_email";
            this.employee_email.Size = new System.Drawing.Size(170, 21);
            this.employee_email.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(332, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email:";
            // 
            // employee_status
            // 
            this.employee_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_status.FormattingEnabled = true;
            this.employee_status.Items.AddRange(new object[] {
            "Active",
            "Ianctive"});
            this.employee_status.Location = new System.Drawing.Point(625, 36);
            this.employee_status.Name = "employee_status";
            this.employee_status.Size = new System.Drawing.Size(170, 23);
            this.employee_status.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(575, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Status:";
            // 
            // employee_clearBtn
            // 
            this.employee_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.employee_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_clearBtn.FlatAppearance.BorderSize = 0;
            this.employee_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.employee_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.employee_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.employee_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_clearBtn.ForeColor = System.Drawing.Color.White;
            this.employee_clearBtn.Location = new System.Drawing.Point(569, 152);
            this.employee_clearBtn.Name = "employee_clearBtn";
            this.employee_clearBtn.Size = new System.Drawing.Size(113, 37);
            this.employee_clearBtn.TabIndex = 17;
            this.employee_clearBtn.Text = "Clear";
            this.employee_clearBtn.UseVisualStyleBackColor = false;
            this.employee_clearBtn.Click += new System.EventHandler(this.employee_clearBtn_Click);
            // 
            // employee_deleteBtn
            // 
            this.employee_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.employee_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_deleteBtn.FlatAppearance.BorderSize = 0;
            this.employee_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.employee_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.employee_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.employee_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.employee_deleteBtn.Location = new System.Drawing.Point(439, 152);
            this.employee_deleteBtn.Name = "employee_deleteBtn";
            this.employee_deleteBtn.Size = new System.Drawing.Size(113, 37);
            this.employee_deleteBtn.TabIndex = 16;
            this.employee_deleteBtn.Text = "Delete";
            this.employee_deleteBtn.UseVisualStyleBackColor = false;
            this.employee_deleteBtn.Click += new System.EventHandler(this.employee_deleteBtn_Click);
            // 
            // employee_updateBtn
            // 
            this.employee_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.employee_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_updateBtn.FlatAppearance.BorderSize = 0;
            this.employee_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.employee_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.employee_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.employee_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_updateBtn.ForeColor = System.Drawing.Color.White;
            this.employee_updateBtn.Location = new System.Drawing.Point(290, 152);
            this.employee_updateBtn.Name = "employee_updateBtn";
            this.employee_updateBtn.Size = new System.Drawing.Size(113, 37);
            this.employee_updateBtn.TabIndex = 15;
            this.employee_updateBtn.Text = "Update";
            this.employee_updateBtn.UseVisualStyleBackColor = false;
            this.employee_updateBtn.Click += new System.EventHandler(this.employee_updateBtn_Click);
            // 
            // employee_addBtn
            // 
            this.employee_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.employee_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_addBtn.FlatAppearance.BorderSize = 0;
            this.employee_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.employee_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.employee_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.employee_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_addBtn.ForeColor = System.Drawing.Color.White;
            this.employee_addBtn.Location = new System.Drawing.Point(160, 152);
            this.employee_addBtn.Name = "employee_addBtn";
            this.employee_addBtn.Size = new System.Drawing.Size(113, 37);
            this.employee_addBtn.TabIndex = 14;
            this.employee_addBtn.Text = "Add";
            this.employee_addBtn.UseVisualStyleBackColor = false;
            this.employee_addBtn.Click += new System.EventHandler(this.employee_addBtn_Click);
            // 
            // employee_role
            // 
            this.employee_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_role.FormattingEnabled = true;
            this.employee_role.Items.AddRange(new object[] {
            "Business Management",
            "Front-End Developer",
            "Back-End Developer",
            "Data Administrator",
            "UI/UX Design"});
            this.employee_role.Location = new System.Drawing.Point(380, 92);
            this.employee_role.Name = "employee_role";
            this.employee_role.Size = new System.Drawing.Size(170, 23);
            this.employee_role.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Role:";
            // 
            // employee_phone
            // 
            this.employee_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_phone.Location = new System.Drawing.Point(380, 65);
            this.employee_phone.Name = "employee_phone";
            this.employee_phone.Size = new System.Drawing.Size(170, 21);
            this.employee_phone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone:";
            // 
            // employee_gender
            // 
            this.employee_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_gender.FormattingEnabled = true;
            this.employee_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.employee_gender.Location = new System.Drawing.Point(125, 92);
            this.employee_gender.Name = "employee_gender";
            this.employee_gender.Size = new System.Drawing.Size(170, 23);
            this.employee_gender.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender:";
            // 
            // employee_name
            // 
            this.employee_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_name.Location = new System.Drawing.Point(125, 65);
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(170, 21);
            this.employee_name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name:";
            // 
            // employee_id
            // 
            this.employee_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_id.Location = new System.Drawing.Point(125, 38);
            this.employee_id.Name = "employee_id";
            this.employee_id.Size = new System.Drawing.Size(170, 21);
            this.employee_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(0, 299);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(839, 226);
            this.panel4.TabIndex = 1;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employee_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employee_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employee_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox employee_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox employee_role;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button employee_clearBtn;
        private System.Windows.Forms.Button employee_deleteBtn;
        private System.Windows.Forms.Button employee_updateBtn;
        private System.Windows.Forms.Button employee_addBtn;
        private System.Windows.Forms.ComboBox employee_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox employee_email;
        private System.Windows.Forms.Label label8;
    }
}
