﻿
namespace SchoolMangementSystem
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddEmployees_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.AddTeacher_btn = new System.Windows.Forms.Button();
            this.AddStudent_btn = new System.Windows.Forms.Button();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.salary1 = new SchoolMangementSystem.Salary();
            this.addStudentForm1 = new SchoolMangementSystem.AddStudentForm();
            this.addTeachersForm1 = new SchoolMangementSystem.AddTeachersForm();
            this.addEmployee1 = new SchoolMangementSystem.AddEmployee();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 25);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1080, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "School Management System | Main Form";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.AddEmployees_btn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.AddTeacher_btn);
            this.panel2.Controls.Add(this.AddStudent_btn);
            this.panel2.Controls.Add(this.Dashboard_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 575);
            this.panel2.TabIndex = 1;
            // 
            // AddEmployees_btn
            // 
            this.AddEmployees_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployees_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddEmployees_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddEmployees_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployees_btn.ForeColor = System.Drawing.Color.White;
            this.AddEmployees_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddEmployees_btn.Location = new System.Drawing.Point(12, 358);
            this.AddEmployees_btn.Name = "AddEmployees_btn";
            this.AddEmployees_btn.Size = new System.Drawing.Size(200, 40);
            this.AddEmployees_btn.TabIndex = 8;
            this.AddEmployees_btn.Text = "Add Employees";
            this.AddEmployees_btn.UseVisualStyleBackColor = true;
            this.AddEmployees_btn.Click += new System.EventHandler(this.AddEmployees_btn_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Salary_btn);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Logout";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(6, 523);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // AddTeacher_btn
            // 
            this.AddTeacher_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTeacher_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddTeacher_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddTeacher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeacher_btn.ForeColor = System.Drawing.Color.White;
            this.AddTeacher_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTeacher_btn.Location = new System.Drawing.Point(12, 266);
            this.AddTeacher_btn.Name = "AddTeacher_btn";
            this.AddTeacher_btn.Size = new System.Drawing.Size(200, 40);
            this.AddTeacher_btn.TabIndex = 4;
            this.AddTeacher_btn.Text = "Add Teachers";
            this.AddTeacher_btn.UseVisualStyleBackColor = true;
            this.AddTeacher_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // AddStudent_btn
            // 
            this.AddStudent_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudent_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddStudent_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddStudent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudent_btn.ForeColor = System.Drawing.Color.White;
            this.AddStudent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStudent_btn.Location = new System.Drawing.Point(12, 220);
            this.AddStudent_btn.Name = "AddStudent_btn";
            this.AddStudent_btn.Size = new System.Drawing.Size(200, 40);
            this.AddStudent_btn.TabIndex = 3;
            this.AddStudent_btn.Text = "Add Students";
            this.AddStudent_btn.UseVisualStyleBackColor = true;
            this.AddStudent_btn.Click += new System.EventHandler(this.AddStudent_btn_Click);
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.Dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard_btn.Location = new System.Drawing.Point(12, 174);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(200, 40);
            this.Dashboard_btn.TabIndex = 2;
            this.Dashboard_btn.Text = "Dashboard";
            this.Dashboard_btn.UseVisualStyleBackColor = true;
            this.Dashboard_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, Admin";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addEmployee1);
            this.panel3.Controls.Add(this.salary1);
            this.panel3.Controls.Add(this.addStudentForm1);
            this.panel3.Controls.Add(this.addTeachersForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 575);
            this.panel3.TabIndex = 2;
            // 
            // salary1
            // 
            this.salary1.Location = new System.Drawing.Point(0, 0);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(875, 575);
            this.salary1.TabIndex = 2;
            // 
            // addStudentForm1
            // 
            this.addStudentForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStudentForm1.Location = new System.Drawing.Point(0, 0);
            this.addStudentForm1.Name = "addStudentForm1";
            this.addStudentForm1.Size = new System.Drawing.Size(875, 575);
            this.addStudentForm1.TabIndex = 1;
            // 
            // addTeachersForm1
            // 
            this.addTeachersForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTeachersForm1.Location = new System.Drawing.Point(0, 0);
            this.addTeachersForm1.Name = "addTeachersForm1";
            this.addTeachersForm1.Size = new System.Drawing.Size(875, 575);
            this.addTeachersForm1.TabIndex = 0;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(0, -2);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(875, 577);
            this.addEmployee1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddTeacher_btn;
        private System.Windows.Forms.Button AddStudent_btn;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private AddTeachersForm addTeachersForm1;
        private AddStudentForm addStudentForm1;
        private System.Windows.Forms.Button button1;
        private Salary salary1;
        private System.Windows.Forms.Button AddEmployees_btn;
        private AddEmployee addEmployee1;
    }
}