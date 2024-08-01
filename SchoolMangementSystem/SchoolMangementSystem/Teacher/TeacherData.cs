using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    class TeacherData
    {

        public int ID { set; get; }
        public string TeacherID { set; get; }
        public string TeacherName { set; get; }
        public string TeacherGender { set; get; }
        public string TeacherEmail { set; get; }
        public string TeacherPhone { set; get; }
        public string TeacherRole { set; get; }
        public string TeacherSubject1 { set; get; }
        public string TeacherSubject2 { set; get; }
        public int Salary { set; get; }
        public string Status { set; get; }


        SqlConnection connect = new SqlConnection(ConnectConfig.connection);


        public List<TeacherData> TeacherListData()
        {
            List<TeacherData> listdata = new List<TeacherData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM teachers WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            TeacherData ed = new TeacherData();
                            ed.ID = (int)reader["id"];
                            ed.TeacherID = reader["teacher_id"].ToString();
                            ed.TeacherName = reader["teacher_name"].ToString();
                            ed.TeacherGender = reader["teacher_gender"].ToString();
                            ed.TeacherEmail = reader["teacher_email"].ToString();
                            ed.TeacherPhone = reader["teacher_Phone"].ToString();
                            ed.TeacherRole = reader["teacher_role"].ToString();
                            ed.TeacherSubject1 = reader["teacher_subject1"].ToString();
                            ed.TeacherSubject2 = reader["teacher_subject2"].ToString();
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

        public List<TeacherData> salaryTeacherListData()
        {
            List<TeacherData> listdata = new List<TeacherData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM teachers WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            TeacherData ed = new TeacherData();
                            ed.TeacherID = reader["teacher_id"].ToString();
                            ed.TeacherName = reader["teacher_name"].ToString();
                            ed.TeacherRole = reader["teacher_role"].ToString();
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
