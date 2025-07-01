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
    public partial class Fuentes : Form
    {
        public Fuentes()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Creditos ventanaA = new Creditos();
            ventanaA.StartPosition = this.StartPosition;
            ventanaA.Size = this.Size;
            ventanaA.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
