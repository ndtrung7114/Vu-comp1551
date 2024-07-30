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
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Documents\DesktopInformationSystem.mdf;Integrated Security=True;Connect Timeout=30");

        public AddEmployee()
        {
            InitializeComponent();

            displayEmployeeData();
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployeeData();
        }
        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeeListData();

            dataGridView1.DataSource = listData;
        }

        private void employee_addBtn_Click(object sender, EventArgs e)
        {
            if (employee_id.Text == ""
                || employee_name.Text == ""
                || employee_gender.Text == ""
                || employee_email.Text == ""
                || employee_phone.Text == ""
                || employee_role.Text == ""
                || employee_status.Text == "")
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
                        string checkEmID = "SELECT COUNT(*) FROM employees WHERE employee_id = @emID AND delete_date IS NULL";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", employee_id.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(employee_id.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO employees " +
                                    "(employee_id, employee_name, employee_gender, employee_email, employee_phone" +
                                    ", employee_role, salary, insert_date, status) " +
                                    "VALUES(@employeeID, @employeeName, @employeeGender, @employeeEmail, @employeePhone" +
                                    ", @employeeRole, @salary, @insertDate, @status)";


                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", employee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@employeeName", employee_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@employeeGender", employee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@employeeEmail", employee_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@employeePhone", employee_phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@employeeRole", employee_role.Text.Trim());
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insertDate", today);
                                    cmd.Parameters.AddWithValue("@status", employee_status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();

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
                employee_id.Text = row.Cells[1].Value.ToString();
                employee_name.Text = row.Cells[2].Value.ToString();
                employee_gender.Text = row.Cells[3].Value.ToString();
                employee_email.Text = row.Cells[4].Value.ToString();
                employee_phone.Text = row.Cells[5].Value.ToString();
                employee_role.Text = row.Cells[6].Value.ToString();
                employee_status.Text = row.Cells[8].Value.ToString();
            }
        }
        public void clearFields()
        {
            employee_id.Text = "";
            employee_name.Text = "";
            employee_gender.SelectedIndex = -1;
            employee_email.Text = "";
            employee_phone.Text = "";
            employee_role.SelectedIndex = -1;
            employee_status.SelectedIndex = -1;
        }

        private void employee_updateBtn_Click(object sender, EventArgs e)
        {
            if (employee_id.Text == ""
                || employee_name.Text == ""
                || employee_gender.Text == ""
                || employee_email.Text == ""
                || employee_phone.Text == ""
                || employee_role.Text == ""
                || employee_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Employee ID: " + employee_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET employee_name = @employeeName" +
                            ", employee_gender = @employeeGender, employee_phone = @employeePhone" +
                            ", employee_role = @employeeRole, update_date = @updateDate, status = @status " +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@employeeName", employee_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeGender", employee_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeePhone", employee_phone.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeRole", employee_role.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@status", employee_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeID", employee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

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

        private void employee_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void employee_deleteBtn_Click(object sender, EventArgs e)
        {
            if (employee_id.Text == ""
                || employee_name.Text == ""
                || employee_gender.Text == ""
                || employee_email.Text == ""
                || employee_phone.Text == ""
                || employee_role.Text == ""
                || employee_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Employee ID: " + employee_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET delete_date = @deleteDate " +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@employeeID", employee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

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
    