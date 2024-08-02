namespace Mole_shesh
{
    public partial class Form1 : Form
    {
        private List<PictureBox> holes;
        private int score = 0;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            holes = new() { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
            timer1.Start();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            score++;
            label1.Text = "Score: " + score.ToString();
            pictureBox9.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            score = 0;
            label1.Text = "Score: " + score.ToString();
            pictureBox9.Visible = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            pictureBox9.Location = holes[random.Next(holes.Count)].Location;
            pictureBox9.Visible = true;
        }
    }
}
