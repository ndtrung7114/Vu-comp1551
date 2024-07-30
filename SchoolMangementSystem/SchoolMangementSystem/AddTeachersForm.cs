using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMangementSystem
{
    public partial class AddTeachersForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Documents\DesktopInformationSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public AddTeachersForm()
        {
            InitializeComponent();

            displayTeacherData();
        }
        public void displayTeacherData()
        {
            AddTeachersData addTD = new AddTeachersData();

            teacher_teacherData.DataSource = addTD.teacherData();
        }

        private void teacher_addBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == ""
                || teacher_name.Text == ""
                || teacher_gender.Text == ""
                || teacher_email.Text == ""
                || teacher_phone.Text == ""
                || teacher_role.Text == ""
                || teacher_status.Text == "")
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

                        // WE DON'T LIKE THE DUPLICATE teacher ID SO, WE NEED TO CHECK IF ON THE DATABASE HAS ALREADY TEACHER ID VALUE THAT SAME TO THE USER THAT WANT TO INSERT 
                        string checkTeacherID = "SELECT COUNT(*) FROM teachers WHERE teacher_id = @teacherID";

                        using (SqlCommand checkTID = new SqlCommand(checkTeacherID, connect))
                        {
                            checkTID.Parameters.AddWithValue("@TeacherID", teacher_id.Text.Trim());
                            int count = (int)checkTID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Teacher ID: " + teacher_id.Text.Trim() + " is already exist"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO teachers (teacher_id, teacher_name" +
                                    ", teacher_gender, teacher_email, teacher_phone, teacher_role" +
                                    ",  teacher_status, date_insert) " +
                                    "VALUES(@teacherID, @teacherName, @teacherGender, @teacherEmail" +
                                    ", @teacherPhone, @teacherRole,  @teacherStatus" +
                                    ", @dateInsert)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherName", teacher_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherGender", teacher_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherEmail", teacher_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherPhone", teacher_phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherRole", teacher_role.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherStatus", teacher_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateInsert", today);

                                    cmd.ExecuteNonQuery();

                                    displayTeacherData();

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
            teacher_id.Text = "";
            teacher_name.Text = "";
            teacher_gender.SelectedIndex = -1;
            teacher_email.Text = "";
            teacher_phone.Text = "";
            teacher_role.SelectedIndex = -1;
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
                || teacher_status.Text == "")
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

                        DialogResult check = MessageBox.Show("Are you sure you want to Update teacher ID: "
                            + teacher_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            String updateData = "UPDATE teachers SET teacher_name = @teacherName, " +
                                "teacher_gender = @teacherGender, teacher_email = @teacherEmail, " +
                                "teacher_phone = @teacherPhone, teacher_role = @teacherRole, " +
                                "teacher_status = @teacherStatus, date_update = @dateUpdate " +
                                "WHERE teacher_id = @teacherID";


                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@teacherName", teacher_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherGender", teacher_gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherEmail", teacher_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherPhone", teacher_phone.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherRole", teacher_role.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherStatus", teacher_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayTeacherData();

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

        private void teacher_teacherData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = teacher_teacherData.Rows[e.RowIndex];
                teacher_id.Text = row.Cells[1].Value.ToString();
                teacher_name.Text = row.Cells[2].Value.ToString();
                teacher_gender.Text = row.Cells[3].Value.ToString();
                teacher_email.Text = row.Cells[4].Value.ToString();
                teacher_phone.Text = row.Cells[5].Value.ToString();
                teacher_role.Text = row.Cells[6].Value.ToString();
                teacher_status.Text = row.Cells[7].Value.ToString();
            }
        }

        private void teacher_deleteBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Delete teacher ID: "
                        + teacher_id.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {

                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string deleteData = "UPDATE teachers SET date_delete = @dateDelete " +
                                "WHERE teacher_id = @teacherID";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayTeacherData();

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

        private void connect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                    string query = "SELECT * FROM teachers";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    teacher_teacherData.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
    }
}
