using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SchoolMangementSystem
{
    class SalaryData
    {
        public string TeacherID { set; get; } // 0
        public string TeacherName { set; get; } // 1
        public string TeacherGender { set; get; } // 2
        public string TeacherPhone { set; get; } // 3
        public string TeacherRole { set; get; } // 4
        public int Salary { set; get; } // 5

        SqlConnection connect = new SqlConnection(ConnectConfig.connection);

        public List<SalaryData> salaryTeacherListData()
        {
            List<SalaryData> listdata = new List<SalaryData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM Teachers WHERE status = 'Active' " +
                        "AND delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SalaryData sd = new SalaryData();
                            sd.TeacherID = reader["teacher_id"].ToString();
                            sd.TeacherName = reader["teacher_name"].ToString();
                            sd.TeacherGender = reader["teacher_gender"].ToString();
                            sd.TeacherPhone = reader["teacher_phone"].ToString();
                            sd.TeacherRole = reader["teacher_role"].ToString();
                            sd.Salary = (int)reader["salary"];

                            listdata.Add(sd);
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
