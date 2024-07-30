using SchoolMangementSystem;
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
    public partial class Salary : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Documents\DesktopInformationSystem.mdf;Integrated Security=True;Connect Timeout=30");

        public Salary()
        {
            InitializeComponent();

            displayTeachers();
            disableFields();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            displayTeachers();
            disableFields();
        }

        public void disableFields()
        {
            salary_teacherid.Enabled = false;
            salary_teachername.Enabled = false;
            salary_teacherrole.Enabled = false;
        }

        public void displayTeachers()
        {
            SalaryData sd = new SalaryData();
            List<SalaryData> listData = sd.salaryTeachersListData();

            dataGridView1.DataSource = listData;
        }

        private void salary_updateBtn_Click(object sender, EventArgs e)
        {
            if (salary_teacherid.Text == ""
                || salary_teachername.Text == ""
                || salary_teacherrole.Text == ""
                || salary_teachersalary.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Teacher ID: "
                    + salary_teacherid.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE teachers SET salary = @salary" +
                                ", update_date = @updateData WHERE teacher_id = @teacherID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@salary", salary_teachersalary.Text.Trim());
                                cmd.Parameters.AddWithValue("@updateData", today);
                                cmd.Parameters.AddWithValue("teacherID", salary_teacherid.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayTeachers();

                                MessageBox.Show("Updated successfully!"
                                    , "Information Message", MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void clearFields()
        {
            salary_teacherid.Text = "";
            salary_teachername.Text = "";
            salary_teacherrole.Text = "";
            salary_teachersalary.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salary_teacherid.Text = row.Cells[0].Value.ToString();
                salary_teachername.Text = row.Cells[1].Value.ToString();
                salary_teacherrole.Text = row.Cells[4].Value.ToString();
                salary_teachersalary.Text = row.Cells[5].Value.ToString();
            }
        }

        private void salary_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void salary_connect_Click(object sender, EventArgs e)
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
                    dataGridView1.DataSource = dataTable;
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
