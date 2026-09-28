namespace ticketApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sehife baglansinmi?", "Melumat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            string b = comboBox2.Text;
            comboBox1.Text = b;
            comboBox2.Text = a;
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            richTextBox1.Text = comboBox1.Text + " " + comboBox2.Text + " " + tarix.Text + " " + saat.Text + " " + " " + yer.Text + " " + namesurname.Text +
             " " + fin.Text + " " + telefon.Text + " " + email.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
