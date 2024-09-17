using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PRG282_Project.Data_Layer
{
    class DataHandler
    {
        public DataHandler() { }

        string conn = "Server=(local); Initial Catalog=StudentDB; Integrated Security=SSPI";

        public DataTable showAllStudents()
        {
            SqlConnection connect = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spShowAllStudnets", connect);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable showAllModules()
        {
            SqlConnection connect = new SqlConnection(conn);
            SqlDataAdapter adapter = new SqlDataAdapter("spShowAllModules", connect);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable searchStudents(int id)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchStudents", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                connect.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }         
        }

        public DataTable searchModules(int id)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchModules", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                connect.Open();
                DataTable dt = new DataTable();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public void deleteStudent(int id)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudents", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void deleteModule(int id)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spDeleteModule", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void updateStudent(int id, string name, string img, string dob, string gender,string phone, string address, string modulecode)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spUpdatestudent", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentID", id);
                cmd.Parameters.AddWithValue("@StudentName", name);
                cmd.Parameters.AddWithValue("@StudentImg", img);
                cmd.Parameters.AddWithValue("@StudentDob", dob);
                cmd.Parameters.AddWithValue("@StudentGender", gender);
                cmd.Parameters.AddWithValue("@StudentPhone", phone);
                cmd.Parameters.AddWithValue("@StudentAddress", address);
                cmd.Parameters.AddWithValue("@ModuleCode", modulecode);
                
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void updateModule(int code, string modulename, string moduledesc, string modulelink)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spUpdateModules", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ModuleCode", code);
                cmd.Parameters.AddWithValue("@ModuleName", modulename);
                cmd.Parameters.AddWithValue("@ModuleDesc", moduledesc);
                cmd.Parameters.AddWithValue("@ModuleLink", modulelink);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
