using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBI.Clase;

namespace VBI
{
    public partial class Animales_Aereos : Form
    {
        private int ecosistemaActual;
        private DataGridView dataGridViewAereos;

        public Animales_Aereos(int idEcosistemas)
        {
            InitializeComponent();
            AnimalesAereos();
            AgregarAereos(4);
            ecosistemaActual = idEcosistemas;
        }
        private void AnimalesAereos()
        {
            dataGridViewAereos = new DataGridView();
            dataGridViewAereos.Name = "dataGridViewTerrestres";
            dataGridViewAereos.Location = new Point(50, 250); // debajo de los botones visibles
            dataGridViewAereos.Size = new Size(this.ClientSize.Width - 100, this.ClientSize.Height - 300);
            dataGridViewAereos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Apariencia
            dataGridViewAereos.BackgroundColor = Color.White;
            dataGridViewAereos.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewAereos.GridColor = Color.LightGray;

            dataGridViewAereos.AutoGenerateColumns = false;
            dataGridViewAereos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewAereos.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewAereos.ColumnHeadersHeight = 30;

            // Columnas: ID, Nombre y Botón
            dataGridViewAereos.Columns.Clear();

          
            dataGridViewAereos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            });

            DataGridViewButtonColumn columnaBoton = new DataGridViewButtonColumn()
            {
                Name = "VerInfo",
                HeaderText = "Ver más",
                Text = "Detalles",
                UseColumnTextForButtonValue = true,
                Width = 100
            };
            dataGridViewAereos.Columns.Add(columnaBoton);

            // Estilos de fila
            dataGridViewAereos.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridViewAereos.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewAereos.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            // Evento de clic en el botón de cada fila
            dataGridViewAereos.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && dataGridViewAereos.Columns[e.ColumnIndex].Name == "VerInfo")
                {
                    var fila = dataGridViewAereos.Rows[e.RowIndex];
                    int idAnimalActual = 4;
                    InformacionAnimalA ventanaS = new InformacionAnimalA(idAnimalActual, ecosistemaActual);
                    ventanaS.StartPosition = this.StartPosition;
                    ventanaS.Show();
                    this.Hide();

                }
            };

            this.Controls.Add(dataGridViewAereos);
            dataGridViewAereos.BringToFront();
        }

        private void AgregarAereos(int idAnimal)
        {
            try
            {
                Conexion Rconexion = new Conexion();
                using (MySqlConnection conexion = Rconexion.EstablecerConexion())
                {
                    string query = "SELECT ID_animal, Nombre FROM animales WHERE id_ecosistema = 3 AND ID_animal = @idAnimal";
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@idAnimal", idAnimal);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idAnimalObtenido = Convert.ToInt32(reader["ID_animal"]);
                                string nombreDelAnimal = reader["Nombre"].ToString();


                                dataGridViewAereos.Rows.Add(nombreDelAnimal);
                            }


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
        private void Animales_Acuaticos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idAnimalActual = 4;
            InformacionAnimalAE ventanaS = new InformacionAnimalAE(idAnimalActual, ecosistemaActual);
            ventanaS.StartPosition = this.StartPosition;
            ventanaS.Show();
            this.Hide();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Catalogo ventanaA = new Catalogo();
            ventanaA.StartPosition = this.StartPosition;
            ventanaA.Show();
            this.Close();
        }

        private void btnListaAnimalesAe_Click(object sender, EventArgs e)
        {
            Lista_Animales_Terrestres ventanaS = new Lista_Animales_Terrestres(ecosistemaActual);
            ventanaS.StartPosition = this.StartPosition;
            ventanaS.Show();
            this.Hide();
        }

        private void Animales_Aereos_Load(object sender, EventArgs e)
        {

        }
    }
}
