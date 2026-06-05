using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace practice17form
{
    public class StudentManager
    {
        private string connectionString = "Server=WIN-PLOQED8CK9Q\\SQLEXPRESS;Database=sqlbase;Trusted_Connection=True;TrustServerCertificate=True";
        private string sqlQuery = "INSERT INTO Students (Name, Age) VALUES (@name,@age)";

        public void AddStudent(string name, int age)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }
            }
        }

        public void DeleteStudent(string name)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string sqlQuery = "DELETE FROM Students WHERE Name = @name";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }
            }
        }

        public List<(string Name, int Age)> GetStudentlist()
        {
            List<(string, int)> students = new List<(string, int)>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string sqlQuery = "SELECT * FROM Students";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader["Name"].ToString();
                                int age = Convert.ToInt32(reader["Age"]);
                                students.Add((name, age));
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }
            }
            return students;
        }

        public void UpdateStudent(string name, int age)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string sqlQuery = "UPDATE Students SET Age = @age WHERE Name = @name";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }
            }
        }
    }
}
