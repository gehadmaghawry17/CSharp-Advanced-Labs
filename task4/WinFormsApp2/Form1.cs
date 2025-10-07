namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
      
        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<Student> students = [
        new Student() { Id = 1, Name = "aly", Age = 30 },
            new Student() { Id = 2, Name = "mohamed", Age = 30 },
            new Student() { Id = 3, Name = "omar", Age = 30 }
        ];
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbStudent.DataSource = students;
            cmbStudent.ValueMember = "Id";
            cmbStudent.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbStudent.SelectedItem.ToString());
            MessageBox.Show(cmbDempartment.SelectedItem.ToString());
            Student s1 = new Student();
            s1.Id = int.Parse(txtId.Text);
            s1.Name = txtName.Text;
            s1.Age = int.Parse(txtAge.Text);
            if (MessageBox.Show(s1.ToString(), "Name", MessageBoxButtons.OK) == DialogResult.OK)
                Text = s1.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}













//            MessageBox.Show(((Student)cmbStudent.SelectedItem).Name.ToString());
