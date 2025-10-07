namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grx = e.Graphics;
            grx.FillEllipse(Brushes.Red, x, 80, 50, 50);
        }
        int x = 0;
       
        private void btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
                btn.Text = "Stop";
            else
                btn.Text = "Start";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 5;
            if (x + 50 > this.ClientSize.Width)
                x = 0;
            this.Invalidate();
            Text = x.ToString();
        }
    }
}
