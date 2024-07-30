using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    class EmployeeData
    {

        public int ID { set; get; }
        public string EmployeeID { set; get; }
        public string EmployeeName { set; get; }
        public string EmployeeGender { set; get; }
        public string EmployeeEmail { set; get; }
        public string EmployeePhone { set; get; }
        public string EmployeeRole { set; get; }
        public int Salary { set; get; }
        public string Status { set; get; }


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Documents\DesktopInformationSystem.mdf;Integrated Security=True;Connect Timeout=30");


        public List<EmployeeData> employeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeData ed = new EmployeeData();
                            ed.ID = (int)reader["id"];
                            ed.EmployeeID = reader["employee_id"].ToString();
                            ed.EmployeeName = reader["employee_name"].ToString();
                            ed.EmployeeGender = reader["employee_gender"].ToString();
                            ed.EmployeeEmail = reader["employee_email"].ToString();
                            ed.EmployeePhone = reader["employee_Phone"].ToString();
                            ed.EmployeeRole = reader["employee_role"].ToString();
                            ed.Salary = (int)reader["salary"];
                            ed.Status = reader["status"].ToString();

                            listdata.Add(ed);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }

        public List<EmployeeData> salaryEmployeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeData ed = new EmployeeData();
                            ed.EmployeeID = reader["employee_id"].ToString();
                            ed.EmployeeName = reader["employee_name"].ToString();
                            ed.EmployeeRole = reader["employee_role"].ToString();
                            ed.Salary = (int)reader["salary"];

                            listdata.Add(ed);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }
    }
}
