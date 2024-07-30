namespace SchoolMangementSystem
{
    partial class AddTeachersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.teacher_role = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teacher_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.teacher_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.teacher_status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.teacher_deleteBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teacher_teacherData = new System.Windows.Forms.DataGridView();
            this.teacher_clearBtn = new System.Windows.Forms.Button();
            this.teacher_addBtn = new System.Windows.Forms.Button();
            this.teacher_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teacher_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacher_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teacher_updateBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.connect_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_teacherData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher\'s Data";
            // 
            // teacher_role
            // 
            this.teacher_role.FormattingEnabled = true;
            this.teacher_role.Items.AddRange(new object[] {
            "Teacher"});
            this.teacher_role.Location = new System.Drawing.Point(304, 104);
            this.teacher_role.Name = "teacher_role";
            this.teacher_role.Size = new System.Drawing.Size(144, 21);
            this.teacher_role.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Role:";
            // 
            // teacher_phone
            // 
            this.teacher_phone.Location = new System.Drawing.Point(303, 62);
            this.teacher_phone.Multiline = true;
            this.teacher_phone.Name = "teacher_phone";
            this.teacher_phone.Size = new System.Drawing.Size(144, 25);
            this.teacher_phone.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Phone:";
            // 
            // teacher_email
            // 
            this.teacher_email.Location = new System.Drawing.Point(303, 21);
            this.teacher_email.Multiline = true;
            this.teacher_email.Name = "teacher_email";
            this.teacher_email.Size = new System.Drawing.Size(144, 25);
            this.teacher_email.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Email:";
            // 
            // teacher_status
            // 
            this.teacher_status.FormattingEnabled = true;
            this.teacher_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.teacher_status.Location = new System.Drawing.Point(519, 24);
            this.teacher_status.Name = "teacher_status";
            this.teacher_status.Size = new System.Drawing.Size(144, 21);
            this.teacher_status.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Status:";
            // 
            // teacher_deleteBtn
            // 
            this.teacher_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.teacher_deleteBtn.FlatAppearance.BorderSize = 0;
            this.teacher_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_deleteBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_deleteBtn.Location = new System.Drawing.Point(575, 174);
            this.teacher_deleteBtn.Name = "teacher_deleteBtn";
            this.teacher_deleteBtn.Size = new System.Drawing.Size(102, 35);
            this.teacher_deleteBtn.TabIndex = 17;
            this.teacher_deleteBtn.Text = "Delete";
            this.teacher_deleteBtn.UseVisualStyleBackColor = false;
            this.teacher_deleteBtn.Click += new System.EventHandler(this.teacher_deleteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.teacher_teacherData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 290);
            this.panel1.TabIndex = 4;
            // 
            // teacher_teacherData
            // 
            this.teacher_teacherData.AllowUserToAddRows = false;
            this.teacher_teacherData.AllowUserToDeleteRows = false;
            this.teacher_teacherData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacher_teacherData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.teacher_teacherData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacher_teacherData.EnableHeadersVisualStyles = false;
            this.teacher_teacherData.Location = new System.Drawing.Point(20, 47);
            this.teacher_teacherData.Name = "teacher_teacherData";
            this.teacher_teacherData.ReadOnly = true;
            this.teacher_teacherData.RowHeadersVisible = false;
            this.teacher_teacherData.Size = new System.Drawing.Size(810, 224);
            this.teacher_teacherData.TabIndex = 1;
            this.teacher_teacherData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacher_teacherData_CellClick);
            // 
            // teacher_clearBtn
            // 
            this.teacher_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.teacher_clearBtn.FlatAppearance.BorderSize = 0;
            this.teacher_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_clearBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_clearBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_clearBtn.Location = new System.Drawing.Point(449, 174);
            this.teacher_clearBtn.Name = "teacher_clearBtn";
            this.teacher_clearBtn.Size = new System.Drawing.Size(102, 35);
            this.teacher_clearBtn.TabIndex = 16;
            this.teacher_clearBtn.Text = "Clear";
            this.teacher_clearBtn.UseVisualStyleBackColor = false;
            // 
            // teacher_addBtn
            // 
            this.teacher_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.teacher_addBtn.FlatAppearance.BorderSize = 0;
            this.teacher_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_addBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_addBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_addBtn.Location = new System.Drawing.Point(186, 174);
            this.teacher_addBtn.Name = "teacher_addBtn";
            this.teacher_addBtn.Size = new System.Drawing.Size(102, 35);
            this.teacher_addBtn.TabIndex = 14;
            this.teacher_addBtn.Text = "Add";
            this.teacher_addBtn.UseVisualStyleBackColor = false;
            this.teacher_addBtn.Click += new System.EventHandler(this.teacher_addBtn_Click);
            // 
            // teacher_gender
            // 
            this.teacher_gender.FormattingEnabled = true;
            this.teacher_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.teacher_gender.Location = new System.Drawing.Point(81, 104);
            this.teacher_gender.Name = "teacher_gender";
            this.teacher_gender.Size = new System.Drawing.Size(144, 21);
            this.teacher_gender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender:";
            // 
            // teacher_name
            // 
            this.teacher_name.Location = new System.Drawing.Point(80, 62);
            this.teacher_name.Multiline = true;
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.Size = new System.Drawing.Size(144, 25);
            this.teacher_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // teacher_id
            // 
            this.teacher_id.Location = new System.Drawing.Point(80, 21);
            this.teacher_id.Multiline = true;
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.Size = new System.Drawing.Size(144, 25);
            this.teacher_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teacher ID:";
            // 
            // teacher_updateBtn
            // 
            this.teacher_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.teacher_updateBtn.FlatAppearance.BorderSize = 0;
            this.teacher_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.teacher_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_updateBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_updateBtn.ForeColor = System.Drawing.Color.White;
            this.teacher_updateBtn.Location = new System.Drawing.Point(312, 174);
            this.teacher_updateBtn.Name = "teacher_updateBtn";
            this.teacher_updateBtn.Size = new System.Drawing.Size(102, 35);
            this.teacher_updateBtn.TabIndex = 15;
            this.teacher_updateBtn.Text = "Update";
            this.teacher_updateBtn.UseVisualStyleBackColor = false;
            this.teacher_updateBtn.Click += new System.EventHandler(this.teacher_updateBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.connect_btn);
            this.panel2.Controls.Add(this.teacher_role);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.teacher_phone);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.teacher_email);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.teacher_status);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.teacher_deleteBtn);
            this.panel2.Controls.Add(this.teacher_clearBtn);
            this.panel2.Controls.Add(this.teacher_updateBtn);
            this.panel2.Controls.Add(this.teacher_addBtn);
            this.panel2.Controls.Add(this.teacher_gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.teacher_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.teacher_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 229);
            this.panel2.TabIndex = 5;
            // 
            // connect_btn
            // 
            this.connect_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.connect_btn.FlatAppearance.BorderSize = 0;
            this.connect_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.connect_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.connect_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_btn.ForeColor = System.Drawing.Color.White;
            this.connect_btn.Location = new System.Drawing.Point(52, 174);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(102, 35);
            this.connect_btn.TabIndex = 26;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = false;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // AddTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AddTeachersForm";
            this.Size = new System.Drawing.Size(875, 575);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_teacherData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teacher_role;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teacher_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox teacher_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox teacher_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button teacher_deleteBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView teacher_teacherData;
        private System.Windows.Forms.Button teacher_clearBtn;
        private System.Windows.Forms.Button teacher_addBtn;
        private System.Windows.Forms.ComboBox teacher_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacher_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacher_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button teacher_updateBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button connect_btn;
    }
}
