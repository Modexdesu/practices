using Microsoft.Data.SqlClient;




string connectionString = "Server=WIN-PLOQED8CK9Q\\SQLEXPRESS;Database=sqlbase;Trusted_Connection=True;TrustServerCertificate=True";
string sqlQuery = "INSERT INTO Students (Name, Age) VALUES (@name,@age)";


void AddStudent(string name, int age)
{
    using (SqlConnection con = new SqlConnection(connectionString))
    {

        try
        {
            con.Open();
            Console.WriteLine("Connection opened successfully.");
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Student added successfully.");
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Error: {0}", ex.Message);
        }

    }
}

void DeleteStudent(string name)
{
    using (SqlConnection con = new SqlConnection(connectionString))
    {
        try
        {
            con.Open();
            Console.WriteLine("Connection opened successfully.");
            string sqlQuery = "DELETE FROM Students WHERE Name = @name";
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Student deleted successfully.");
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Error: {0}", ex.Message);
        }
    }
}

void GetStudentlist()
{
    using (SqlConnection con = new SqlConnection(connectionString))
    {
        try
        {
            con.Open();
            Console.WriteLine("Connection opened successfully.");
            string sqlQuery = "SELECT * FROM Students";
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(" Name: {1}, Age: {2}", reader["Name"], reader["Age"]);
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Error: {0}", ex.Message);
        }
    }
}

void UpdateStudent(string name, int age)
{
    using (SqlConnection con = new SqlConnection(connectionString))


        try
        {
            con.Open();
            Console.WriteLine("Connection opened successfully.");
            string sqlQuery = "UPDATE Students SET Age = @age WHERE Name = @name";
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Student updated successfully.");
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Error: {0}", ex.Message);



        }

}



