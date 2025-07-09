using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBI
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fuentes ventanaS = new Fuentes();
            ventanaS.StartPosition = this.StartPosition;
            ventanaS.Size = this.Size;
            ventanaS.Show();
            this.Hide();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Menu ventanaS = new Menu();
            ventanaS.StartPosition = this.StartPosition;
            ventanaS.Size = this.Size;
            ventanaS.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
