using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SchoolMangementSystem
{
    public partial class AddTeacher : UserControl
    {
        SqlConnection connect = new SqlConnection(ConnectConfig.connection);

        public AddTeacher()
        {
            InitializeComponent();

            displayTeacherData();
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayTeacherData();
        }
        public void displayTeacherData()
        {
            TeacherData ed = new TeacherData();
            List<TeacherData> listData = ed.TeacherListData();

            dataGridView1.DataSource = listData;
        }

        private void teacher_addBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == ""
                || teacher_name.Text == ""
                || teacher_gender.Text == ""
                || teacher_email.Text == ""
                || teacher_phone.Text == ""
                || teacher_role.Text == ""
                || teacher_subject1.Text == ""
                || teacher_subject2.Text == ""
                || teacher_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM teachers WHERE teacher_id = @teID AND delete_date IS NULL";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@teID", teacher_id.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(teacher_id.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO teachers " +
                                    "(teacher_id, teacher_name, teacher_gender, teacher_email, teacher_phone, teacher_subject1, teacher_subject2" +
                                    ", teacher_role, salary, insert_date, status) " +
                                    "VALUES(@teacherID, @teacherName, @teacherGender, @teacherEmail, @teacherPhone, @teacherSubject1, @teacherSubject2" +
                                    ", @teacherRole, @salary, @insertDate, @status)";


                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherName", teacher_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherGender", teacher_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherEmail", teacher_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherPhone", teacher_phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherRole", teacher_role.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherSubject1", teacher_subject1.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherSubject2", teacher_subject2.Text.Trim());
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insertDate", today);
                                    cmd.Parameters.AddWithValue("@status", teacher_status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayTeacherData();

                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                   
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                teacher_id.Text = row.Cells[1].Value.ToString();
                teacher_name.Text = row.Cells[2].Value.ToString();
                teacher_gender.Text = row.Cells[3].Value.ToString();
                teacher_email.Text = row.Cells[4].Value.ToString();
                teacher_phone.Text = row.Cells[5].Value.ToString();
                teacher_role.Text = row.Cells[6].Value.ToString();
                teacher_subject1.Text = row.Cells[7].Value.ToString();
                teacher_subject2.Text = row.Cells[8].Value.ToString();
                teacher_status.Text = row.Cells[10].Value.ToString();
            }
        }
        public void clearFields()
        {
            teacher_id.Text = "";
            teacher_name.Text = "";
            teacher_gender.SelectedIndex = -1;
            teacher_email.Text = "";
            teacher_phone.Text = "";
            teacher_role.SelectedIndex = -1;
            teacher_subject1.SelectedIndex = -1;
            teacher_subject2.SelectedIndex = -1;
            teacher_status.SelectedIndex = -1;
        }

        private void teacher_updateBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == ""
                || teacher_name.Text == ""
                || teacher_gender.Text == ""
                || teacher_email.Text == ""
                || teacher_phone.Text == ""
                || teacher_role.Text == ""
                || teacher_subject1.Text == ""
                || teacher_subject2.Text == ""
                || teacher_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "teacher ID: " + teacher_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE teachers SET teacher_name = @teacherName" +
                            ", teacher_gender = @teacherGender, teacher_phone = @teacherPhone" +
                            ", teacher_role = @teacherRole, teacher_subject1 = @teacherSubject1, teacher_subject2 = @teacherSubject2, update_date = @updateDate, status = @status " +
                            "WHERE teacher_id = @teacherID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@teacherName", teacher_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@teacherGender", teacher_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@teacherPhone", teacher_phone.Text.Trim());
                            cmd.Parameters.AddWithValue("@teacherRole", teacher_role.Text.Trim());
                            cmd.Parameters.AddWithValue("@teacherSubject1", teacher_subject1.Text.Trim());
                            cmd.Parameters.AddWithValue("@teacherSubject2", teacher_subject2.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@status", teacher_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayTeacherData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void teacher_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void teacher_deleteBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == ""
                || teacher_name.Text == ""
                || teacher_gender.Text == ""
                || teacher_email.Text == ""
                || teacher_phone.Text == ""
                || teacher_role.Text == ""
                || teacher_subject1.Text == ""
                || teacher_subject2.Text == ""
                || teacher_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "teacher ID: " + teacher_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE teachers SET delete_date = @deleteDate " +
                            "WHERE teacher_id = @teacherID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayTeacherData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}