using Microsoft.Data.SqlClient;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=ITI;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("select * from department",conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                Console.WriteLine($"{reader["DeptId"]}-{reader["DeptName"]}-{reader["Capacity"]}");
            }
            conn.Close();

            //======================================
            SqlCommand cmd2 = new SqlCommand("update department set DeptName='ba', Capacity=500 where DeptId=200",conn);

            conn.Open();
            int r= cmd2.ExecuteNonQuery(); 
            conn.Close();

            Console.WriteLine($"Rows updated: {r}");

            //====================================================

            SqlCommand cmd3 = new SqlCommand("delete from department where DeptId = 200",conn);

            conn.Open();
            int r1 = cmd3.ExecuteNonQuery(); 
            conn.Close();

            Console.WriteLine($"Rows deleted: {r1}");

            //==================================

            SqlCommand cmd1 = new SqlCommand("insert into department (DeptId,DeptName, Capacity) values(200,'os',400)", conn);
            conn.Open();
            object z = cmd1.ExecuteScalar();
            conn.Close();
            Console.WriteLine(z);

            //=============================

            
            SqlCommand cmd5 = new SqlCommand("insert into department (DeptId,DeptName, Capacity) values(@n1,@n2)", conn);
            string name = "test";
            int capacity = 50;
            SqlParameter p1 = new SqlParameter("name", name);
            SqlParameter p2 = new SqlParameter("capacity", capacity);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            conn.Open();
            object K = cmd5.ExecuteScalar();
            conn.Close();
            Console.WriteLine(K);


        }
    }
}
