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
    public partial class Animales_Acuaticos : Form
    {
        private int ecosistemaActual;
        private DataGridView dataGridViewAcuaticos;

        public Animales_Acuaticos(int idEcosistemas)
            {
                InitializeComponent();
                AnimalesAcuaticos();
                AgregarAcuatico(3);
             ecosistemaActual = idEcosistemas;
        }
            private void AnimalesAcuaticos()
            {
                dataGridViewAcuaticos = new DataGridView();
                dataGridViewAcuaticos.Name = "dataGridViewTerrestres";
                dataGridViewAcuaticos.Location = new Point(50, 250); // debajo de los botones visibles
                dataGridViewAcuaticos.Size = new Size(this.ClientSize.Width - 100, this.ClientSize.Height - 300);
                dataGridViewAcuaticos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                // Apariencia
                dataGridViewAcuaticos.BackgroundColor = Color.White;
                dataGridViewAcuaticos.BorderStyle = BorderStyle.FixedSingle;
                dataGridViewAcuaticos.GridColor = Color.LightGray;

                dataGridViewAcuaticos.AutoGenerateColumns = false;
                dataGridViewAcuaticos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dataGridViewAcuaticos.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                dataGridViewAcuaticos.ColumnHeadersHeight = 30;

                // Columnas: ID, Nombre y Botón
                dataGridViewAcuaticos.Columns.Clear();

                dataGridViewAcuaticos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Id",
                    HeaderText = "ID",
                    DataPropertyName = "Id",
                    Width = 80
                });

                dataGridViewAcuaticos.Columns.Add(new DataGridViewTextBoxColumn()
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
                dataGridViewAcuaticos.Columns.Add(columnaBoton);

                // Estilos de fila
                dataGridViewAcuaticos.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dataGridViewAcuaticos.RowsDefaultCellStyle.BackColor = Color.White;
                dataGridViewAcuaticos.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

                // Evento de clic en el botón de cada fila
                dataGridViewAcuaticos.CellClick += (s, e) =>
                {
                    if (e.RowIndex >= 0 && dataGridViewAcuaticos.Columns[e.ColumnIndex].Name == "VerInfo")
                    {
                        var fila = dataGridViewAcuaticos.Rows[e.RowIndex];
                        int idAnimalActual = 3;
                        InformacionAnimalA ventanaS = new InformacionAnimalA(idAnimalActual, ecosistemaActual);
                        ventanaS.StartPosition = this.StartPosition;
                        ventanaS.Show();
                        this.Hide();

                    }
                };

                this.Controls.Add(dataGridViewAcuaticos);
                dataGridViewAcuaticos.BringToFront();
            }

            private void AgregarAcuatico(int idAnimal)
            {
                try
                {
                    Conexion Rconexion = new Conexion();
                    using (MySqlConnection conexion = Rconexion.EstablecerConexion())
                    {
                        string query = "SELECT ID_animal, Nombre FROM animales WHERE id_ecosistema = 2 AND ID_animal = @idAnimal";
                        using (MySqlCommand comando = new MySqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@idAnimal", idAnimal);
                            using (MySqlDataReader reader = comando.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int idAnimalObtenido = Convert.ToInt32(reader["ID_animal"]);
                                    string nombreDelAnimal = reader["Nombre"].ToString();


                                    dataGridViewAcuaticos.Rows.Add(idAnimalObtenido, nombreDelAnimal);
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
            int idAnimalActual = 3;
            InformacionAnimalA ventanaS = new InformacionAnimalA(idAnimalActual, ecosistemaActual);
            ventanaS.StartPosition = this.StartPosition;
            ventanaS.Show();
            this.Hide();


        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Catalogo ventanaA = new Catalogo();
            ventanaA.StartPosition = this.StartPosition;
            ventanaA.Show();
            this.Close();
        }

        private void btnAnimalesAcua_Click(object sender, EventArgs e)
        {
            Lista_Animales_Terrestres ventanS = new Lista_Animales_Terrestres(ecosistemaActual);
            ventanS.StartPosition = this.StartPosition;
            ventanS.Show();
            this.Hide();
        }
    }
}

