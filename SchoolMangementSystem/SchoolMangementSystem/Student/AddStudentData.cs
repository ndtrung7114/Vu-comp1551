using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SchoolMangementSystem
{
    class AddStudentData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Documents\DesktopInformationSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public int ID { set; get; }
        public string StudentID { set; get; }
        public string StudentName { set; get; }
        public string StudentGender { set; get; }
        public string StudentEmail { set; get; }
        public string StudentPhone { set; get; }
        public string StudentRole { set; get; }
        public string StudentCurrentSubject1 { set; get; }
        public string StudentCurrentSubject2 { set; get; }
        public string StudentStudiedSubject1 { set; get; }
        public string StudentStudiedSubject2 { set; get; }
        public string Status { set; get; }
        public DateTime DateInsert { set; get; }

        public List<AddStudentData> studentData()
        {
            List<AddStudentData> listData = new List<AddStudentData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM students WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddStudentData addSD = new AddStudentData();
                            addSD.ID = (int)reader["id"];
                            addSD.StudentID = reader["student_id"].ToString();
                            addSD.StudentName = reader["student_name"].ToString();
                            addSD.StudentGender = reader["student_gender"].ToString();
                            addSD.StudentEmail = reader["student_email"].ToString();
                            addSD.StudentPhone = reader["student_phone"].ToString();
                            addSD.StudentRole = reader["student_role"].ToString();
                            addSD.StudentCurrentSubject1 = reader["student_currentsubject1"].ToString();
                            addSD.StudentCurrentSubject2 = reader["student_currentsubject2"].ToString();
                            addSD.StudentStudiedSubject1 = reader["student_studiedsubject1"].ToString();
                            addSD.StudentStudiedSubject2 = reader["student_studiedsubject2"].ToString();
                            addSD.Status = reader["student_status"].ToString();
                            addSD.DateInsert = (DateTime)reader["date_insert"];

                            listData.Add(addSD);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting Database: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;

        }

        public List<AddStudentData> dashboardStudentData()
        {
            List<AddStudentData> listData = new List<AddStudentData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    DateTime today = DateTime.Today;
                    string sql = "SELECT * FROM students WHERE date_insert = @dateInsert " +
                        "AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.AddWithValue("@dateInsert", today.ToString());
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddStudentData addSD = new AddStudentData();
                            addSD.ID = (int)reader["id"];
                            addSD.StudentID = reader["student_id"].ToString();
                            addSD.StudentName = reader["student_name"].ToString();
                            addSD.StudentGender = reader["student_gender"].ToString();
                            addSD.StudentEmail = reader["student_Email"].ToString();
                            addSD.StudentPhone = reader["student_Phone"].ToString();
                            addSD.StudentRole = reader["student_Role"].ToString();
                            addSD.Status = reader["student_status"].ToString();
                            addSD.DateInsert = (DateTime)reader["date_insert"];

                            listData.Add(addSD);
                        }
                        reader.Close();
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
