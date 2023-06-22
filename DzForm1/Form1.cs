namespace DzForm1
{
    public partial class Form1 : Form
    {
        private int hours;
        private int minutes;
        private int seconds;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox1.Text, out seconds))
            {
                MessageBox.Show($"Невірні або порожні дані:{label3.Text}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBox2.Text, out minutes))
            {
                MessageBox.Show($"Невірні або порожні дані:{label2.Text}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBox3.Text, out hours))
            {
                MessageBox.Show($"Невірні або порожні дані:{label1.Text}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string info = textBox4.Text;
            DateTime now = DateTime.Now;

            if (now.Hour == hours && now.Minute == minutes && now.Second == seconds)
            {
                MessageBox.Show(info, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}