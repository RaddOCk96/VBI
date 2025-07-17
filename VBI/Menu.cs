namespace VBI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catalogo ventana1 = new Catalogo();
            ventana1.StartPosition = this.StartPosition;
            ventana1.Size = this.Size;
            ventana1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Creditos ventana2 = new Creditos();
            ventana2.StartPosition = this.StartPosition;
            ventana2.Size = this.Size;
            ventana2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
