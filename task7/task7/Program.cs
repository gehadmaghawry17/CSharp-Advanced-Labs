using Microsoft.Data.SqlClient;
using System.Data;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("select * from department", conn);
            DataTable dt =new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            Console.WriteLine(adapter.InsertCommand.CommandText);
            Console.WriteLine(adapter.UpdateCommand.CommandText);
            Console.WriteLine(adapter.DeleteCommand.CommandText);
            adapter.Fill(dt);
            DataRow dataRow = dt.NewRow();
            dataRow[0] = 700;
            dataRow[1] = "bio";
            dataRow[2] = 700;
            dt.Rows.Add(dataRow);
            dt.Rows[1][1] = "G";
            dt.Rows[2].Delete();
            adapter.Update(dt);
            dt.Clear();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows) {
                Console.WriteLine($"{row[0]} {row[1]} {row[2]}");
            }

         

        























         //   List<Department> departmentList = [];
            //dt.Rows.Add(dataRow);
            //foreach (DataRow dr in dt.Rows) {
            //    int.TryParse(dr[0]?.ToString(), out int deptid);
            //    int.TryParse(dr[2]?.ToString(), out int deptcapacity);
            //    string deptname=dr[1]?.ToString();
            //    Department de = new Department()
            //    {
            //        Id = deptid,
            //        Name=deptname,
            //        Capacity = deptcapacity

            //    };

            //    departmentList.Add(de);

            //}
            //foreach (Department de in departmentList) { 
            //        Console.WriteLine(de);
            //}


        }
    }
}
