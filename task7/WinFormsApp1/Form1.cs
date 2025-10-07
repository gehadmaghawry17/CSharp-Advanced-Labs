using Microsoft.Data.SqlClient;
using System.Data;

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
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("select * from department", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
           adapter.Fill(dt);
            DataRow dataRow = dt.NewRow();
            dataRow[0] = 800;
            dataRow[1] = "hy";
            dataRow[2] = 300;
            dt.Rows.Add(dataRow);
            dt.Rows[1][1] = "j";
            dt.Rows[2].Delete();
            adapter.Update(dt);
            dt.Clear();
            adapter.Fill(dt);
            dataView.DataSource = dt;
        }
    }
}
