using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace SchoolMangementSystem
{
    public partial class AddStudentForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Documents\DesktopInformationSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public AddStudentForm()
        {
            InitializeComponent();

            displayStudentData();
        }

        public void displayStudentData()
        {
            AddStudentData adData = new AddStudentData();

            student_studentData.DataSource = adData.studentData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (student_id.Text == ""
                || student_name.Text == ""
                || student_gender.Text == ""
                || student_email.Text == ""
                || student_phone.Text == ""
                || student_role.Text == ""
                || student_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        // WE DON'T LIKE THE DUPLICATE STUDENT ID SO, WE NEED TO CHECK IF ON THE DATABASE HAS ALREADY TEACHER ID VALUE THAT SAME TO THE USER THAT WANT TO INSERT 
                        string checkStudentID = "SELECT COUNT(*) FROM students WHERE student_id = @studentID";

                        using (SqlCommand checkSID = new SqlCommand(checkStudentID, connect))
                        {
                            checkSID.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                            int count = (int)checkSID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Student ID: " + student_id.Text.Trim() + " is already exist"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO students (student_id, student_name" +
                                    ", student_gender, student_email, student_phone, student_role" +
                                    ",  student_status, date_insert) " +
                                    "VALUES(@studentID, @studentName, @studentGender, @studentEmail" +
                                    ", @studentPhone, @studentRole,  @studentStatus" +
                                    ", @dateInsert)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentName", student_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentGender", student_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentEmail", student_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentPhone", student_phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentRole", student_role.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentStatus", student_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateInsert", today);

                                    cmd.ExecuteNonQuery();

                                    displayStudentData();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public void clearFields()
        {
            student_id.Text = "";
            student_name.Text = "";
            student_gender.SelectedIndex = -1;
            student_email.Text = "";
            student_phone.Text = "";
            student_role.SelectedIndex = -1;
            student_status.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void student_updateBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == ""
                || student_name.Text == ""
                || student_gender.Text == ""
                || student_email.Text == ""
                || student_phone.Text == ""
                || student_role.Text == ""
                || student_status.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        DialogResult check = MessageBox.Show("Are you sure you want to Update Student ID: "
                            + student_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            String updateData = "UPDATE students SET student_name = @studentName, " +
                                "student_gender = @studentGender, student_email = @studentEmail, " +
                                "student_phone = @studentPhone, student_role = @studentRole, " +
                                "student_status = @studentStatus, date_update = @dateUpdate " +
                                "WHERE student_id = @studentID";


                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@studentName", student_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentGender", student_gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentEmail", student_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentPhone", student_phone.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentRole", student_role.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentStatus", student_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayStudentData();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void student_studentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = student_studentData.Rows[e.RowIndex];
                student_id.Text = row.Cells[1].Value.ToString();
                student_name.Text = row.Cells[2].Value.ToString();
                student_gender.Text = row.Cells[3].Value.ToString();
                student_email.Text = row.Cells[4].Value.ToString();
                student_phone.Text = row.Cells[5].Value.ToString();
                student_role.Text = row.Cells[6].Value.ToString();
                student_status.Text = row.Cells[7].Value.ToString();
            }
        }

        private void student_deleteBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Delete Student ID: "
                        + student_id.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {

                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string deleteData = "UPDATE students SET date_delete = @dateDelete " +
                                "WHERE student_id = @studentID";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayStudentData();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error connecting Database: " + ex, "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
