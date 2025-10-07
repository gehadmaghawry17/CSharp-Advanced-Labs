using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            SqlCommand cmdel = new SqlCommand("delete from department where DeptId = 200", conn);
            conn.Open();
            int rdel = cmdel.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show($"Rows deleted: {rdel}", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=ITI;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("select * from department", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            string result = "";
            while (reader.Read())
            {
                result += $"ID: {reader["DeptId"]}, Name: {reader["DeptName"]} ,Capacity: {reader["Capacity"]} \n";
            }
            conn.Close();
            MessageBox.Show(result == "" ? "No Data Found" : result);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=ITI;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmdins = new SqlCommand("insert into department (DeptId , DeptName, Capacity) values(90,'os',400)", conn);
            conn.Open();
            int rowins = cmdins.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show($"Rows Inserted: {rowins}");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=ITI;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd2 = new SqlCommand("update department set DeptName='ba', Capacity=500 where DeptId=200", conn);

            conn.Open();
            int r = cmd2.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show($"Rows updated: {r}");
        }
    }
}
