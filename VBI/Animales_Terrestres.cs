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
    public partial class Animales_Terrestres : Form
    {
        private int ecosistemaActual;
        private DataGridView dataGridViewTerrestre;

        public Animales_Terrestres(int idEcosistemas)
        {
            InitializeComponent();
            AnimalesTerrestre();
            AgregarTerrestre(1);
            ecosistemaActual = idEcosistemas;
        }
        private void AnimalesTerrestre()
        {
            dataGridViewTerrestre = new DataGridView();
            dataGridViewTerrestre.Name = "dataGridViewTerrestres";
            dataGridViewTerrestre.Location = new Point(50, 250); // debajo de los botones visibles
            dataGridViewTerrestre.Size = new Size(this.ClientSize.Width - 100, this.ClientSize.Height - 300);
            dataGridViewTerrestre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Apariencia
            dataGridViewTerrestre.BackgroundColor = Color.White;
            dataGridViewTerrestre.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewTerrestre.GridColor = Color.LightGray;

            dataGridViewTerrestre.AutoGenerateColumns = false;
            dataGridViewTerrestre.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewTerrestre.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewTerrestre.ColumnHeadersHeight = 30;

            // Columnas: ID, Nombre y Botón
            dataGridViewTerrestre.Columns.Clear();

            dataGridViewTerrestre.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 80
            });

            dataGridViewTerrestre.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            DataGridViewButtonColumn columnaBoton = new DataGridViewButtonColumn()
            {
                Name = "VerInfo",
                HeaderText = "Ver más",
                Text = "Detalles",
                UseColumnTextForButtonValue = true,
                Width = 100
            };
            dataGridViewTerrestre.Columns.Add(columnaBoton);

            // Estilos de fila
            dataGridViewTerrestre.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridViewTerrestre.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewTerrestre.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                
            // Evento de clic en el botón de cada fila
            dataGridViewTerrestre.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && dataGridViewTerrestre.Columns[e.ColumnIndex].Name == "VerInfo")
                {
                    var fila = dataGridViewTerrestre.Rows[e.RowIndex];
                    int id_ecosistema = 1;
                    int idSeleccionado = 1;
                    InformacionAnimalT ventanaIA = new InformacionAnimalT(idSeleccionado, id_ecosistema);
                    ventanaIA.StartPosition = this.StartPosition;
                    ventanaIA.Show();
                    this.Hide();


                }
            };

            this.Controls.Add(dataGridViewTerrestre);
            dataGridViewTerrestre.BringToFront();
        }

        private void AgregarTerrestre(int idAnimal)
        {
            try
            {
                Conexion Rconexion = new Conexion();
                using (MySqlConnection conexion = Rconexion.EstablecerConexion())
                {
                    string query = "SELECT ID_animal, Nombre FROM animales WHERE id_ecosistema = 1 AND ID_animal = @idAnimal";
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@idAnimal", idAnimal);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idAnimalObtenido = Convert.ToInt32(reader["ID_animal"]);
                                string nombreDelAnimal = reader["Nombre"].ToString();


                                dataGridViewTerrestre.Rows.Add(idAnimalObtenido, nombreDelAnimal);
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
            Lista_Animales_Terrestres ventanaS = new Lista_Animales_Terrestres(ecosistemaActual);
            ventanaS.StartPosition = this.StartPosition;
            ventanaS.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id_ecosistema = 1;
            int idSeleccionado = 1;
            InformacionAnimalT ventanaIA = new InformacionAnimalT(idSeleccionado, id_ecosistema);
            ventanaIA.StartPosition = this.StartPosition;
            ventanaIA.Show();
            this.Hide();

        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            int id_ecosistema = 1;
            int idSeleccionado = 2;
            InformacionAnimalT ventanaIA = new InformacionAnimalT(idSeleccionado, id_ecosistema);
            ventanaIA.StartPosition = this.StartPosition;
            ventanaIA.Show();
            this.Hide();
        }

        private void Animales_Terrestres_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Catalogo ventanaA = new Catalogo();
            ventanaA.StartPosition = this.StartPosition;
            ventanaA.Show();
            this.Close();
        }
    }
}
