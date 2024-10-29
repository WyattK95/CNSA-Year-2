namespace HelloWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.nameBox.Text))
            {
                this.greetingBox.Text = "Hello mysterious no named person.";
            }

            else
            {
                this.greetingBox.Text = "Hello " + this.nameBox.Text + ", hopefully your day does not suck.";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
