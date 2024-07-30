using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SchoolMangementSystem
{
    class AddTeachersData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Documents\DesktopInformationSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public int ID { set; get; }
        public string TeacherID { set; get; }
        public string TeacherName { set; get; }
        public string TeacherGender { set; get; }
        public string TeacherEmail { set; get; }
        public string TeacherPhone { set; get; }
        public string TeacherRole { set; get; }
        public int TeacherSalary { set; get; }
        public string Status { set; get; }
        public DateTime DateInsert { set; get; }

        public List<AddTeachersData> teacherData()
        {
            List<AddTeachersData> listData = new List<AddTeachersData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM teachers WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddTeachersData addTD = new AddTeachersData();
                            addTD.ID = (int)reader["id"];
                            addTD.TeacherID = reader["teacher_id"].ToString();
                            addTD.TeacherName = reader["teacher_name"].ToString();
                            addTD.TeacherGender = reader["teacher_gender"].ToString();
                            addTD.TeacherEmail = reader["teacher_email"].ToString();
                            addTD.TeacherPhone = reader["teacher_phone"].ToString();
                            addTD.TeacherRole = reader["teacher_role"].ToString();
                            addTD.TeacherSalary = (int)reader["salary"];
                            addTD.Status = reader["teacher_status"].ToString();
                            addTD.DateInsert = (DateTime)reader["date_insert"];

                            listData.Add(addTD);
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
        public List<AddTeachersData> salaryTeachersListData()
        {
            List<AddTeachersData> listdata = new List<AddTeachersData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM teachers WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddTeachersData addTD = new AddTeachersData();
                            addTD.TeacherID = reader["teacher_id"].ToString();
                            addTD.TeacherName = reader["teacher_name"].ToString();
                            addTD.TeacherRole = reader["teacher_role"].ToString();
                            addTD.TeacherSalary = (int)reader["salary"];

                            listdata.Add(addTD);
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