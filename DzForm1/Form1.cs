namespace DzForm1
{
    public partial class Form1 : Form
    {
        int hours;
        int minutes;
        int seconds;
        DateTime date;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seconds = Int32.Parse(textBox1.Text);
            minutes = Int32.Parse(textBox2.Text);
            hours = Int32.Parse(textBox3.Text);
            date = dateTimePicker1.Value;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string info = textBox4.Text;
            DateTime now = DateTime.Now;
            if (date.ToShortDateString() != now.ToShortDateString())
                return;
            if (now.Hour == hours && now.Minute == minutes && now.Second == seconds)
            {
                MessageBox.Show(info, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}