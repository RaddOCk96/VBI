using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using VBI.Clase;

namespace VBI
{
    public partial class Lista_Animales_Terrestres : Form
    {
        public Lista_Animales_Terrestres()
        {
            InitializeComponent();

            dgvAt.AutoGenerateColumns = false; //Evitar columnas duplicadas
            CrearColumnasPersonalizadas(); // Se agregan las columnas

            Clase.Mostrar mostrar = new Clase.Mostrar();
            mostrar.MostrarAnimales(dgvAt); //Llena la tabla

        }

        private void CrearColumnasPersonalizadas()
        {
            // Configuración general del DataGridView
            dgvAt.Dock = DockStyle.Fill; // Que ocupe todo el contenedor
            dgvAt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Repartir columnas proporcionalmente
            dgvAt.RowTemplate.Height = 52; // Altura para íconos grandes
            dgvAt.AllowUserToAddRows = false;
            dgvAt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAt.RowHeadersVisible = false; //  Esto elimina la columna lateral
            dgvAt.BackgroundColor = Color.WhiteSmoke;
            dgvAt.BorderStyle = BorderStyle.None;
            dgvAt.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAt.ColumnHeadersVisible = false;
            dgvAt.DefaultCellStyle.Font = new Font("Spectral", 12);
            dgvAt.Columns.Clear(); // Por si se ejecuta más de una vez

            // Columna de Nombre del Animal
            DataGridViewTextBoxColumn columnaNombre = new DataGridViewTextBoxColumn();
            columnaNombre.Name = "Nombre";
            columnaNombre.DataPropertyName = "Nombre";
            columnaNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnaNombre.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnaNombre.DefaultCellStyle.Padding = new Padding(6, 6, 16, 6);
            dgvAt.Columns.Add(columnaNombre);

            // Columna Editar
            DataGridViewImageColumn columnaEditar = new DataGridViewImageColumn();
            columnaEditar.Name = "Editar";
            columnaEditar.Image = new Bitmap(Properties.Resources.boligrafo_cuadrado, new Size(40, 40));
            columnaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnaEditar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            columnaEditar.DefaultCellStyle.Padding = new Padding(10, 6, 10, 6);
            dgvAt.Columns.Add(columnaEditar);

            // Columna Eliminar
            DataGridViewImageColumn columnaEliminar = new DataGridViewImageColumn();
            columnaEliminar.Name = "Eliminar";
            columnaEliminar.Image = new Bitmap(Properties.Resources.basura_circular, new Size(40, 40));
            columnaEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnaEliminar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            columnaEliminar.DefaultCellStyle.Padding = new Padding(10, 6, 10, 6);
            dgvAt.Columns.Add(columnaEliminar);
        }

        private void dgvAt_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex >= dgvAt.Rows.Count)
                return;

            if (dgvAt.Columns[e.ColumnIndex].Name == "Editar")
            {
                dgvAt.Rows[e.RowIndex].Cells["Editar"].Value =
                    new Bitmap(Properties.Resources.boligrafo_hover, new Size(40, 40));
            }
            else if (dgvAt.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                dgvAt.Rows[e.RowIndex].Cells["Eliminar"].Value =
                    new Bitmap(Properties.Resources.basura_hover, new Size(40, 40));
            }

        }

        //Al pasar el cursor a los iconos se le cambia el color
        private void dgvAt_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex >= dgvAt.Rows.Count)
                return;

            if (dgvAt.Columns[e.ColumnIndex].Name == "Editar")
            {
                dgvAt.Rows[e.RowIndex].Cells["Editar"].Value =
                    new Bitmap(Properties.Resources.boligrafo_cuadrado, new Size(40, 40));
            }
            else if (dgvAt.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                dgvAt.Rows[e.RowIndex].Cells["Eliminar"].Value =
                    new Bitmap(Properties.Resources.basura_circular, new Size(40, 40));
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Animales_Terrestres ventanaA = new Animales_Terrestres();
            ventanaA.StartPosition = this.StartPosition;
            ventanaA.Show();
            this.Close();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Agregar_Animal ventanaS = new Agregar_Animal();
            ventanaS.StartPosition = this.StartPosition;
            ventanaS.Show();
            this.Hide();
        }

        //Verifica que el nombre sea único
        private bool NombreEsUnico(string nombre)
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.EstablecerConexion();

            string query = "SELECT COUNT(*) FROM animales WHERE Nombre = @nombre";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                conexion.CerrarConexion();

                return cantidad == 1; // Solo acepta si hay exactamente uno
            }
        }

        private bool bloqueoEvento = false;
        private void dgvAt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bloqueoEvento || e.RowIndex < 0 || e.ColumnIndex < 0) //Verifica que no haya errores al dar clic varias veces
                return;

            bloqueoEvento = true;

            string nombreAnimal = dgvAt.Rows[e.RowIndex].Cells["Nombre"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(nombreAnimal))
            {
                MessageBox.Show("No se pudo obtener el nombre del animal.", "Advertencia");
                bloqueoEvento = false;
                return;
            }

            if (dgvAt.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult confirmacion = MessageBox.Show("¿Eliminar este animal?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    Eliminar_Animal(nombreAnimal);
                    Clase.Mostrar mostrar = new Clase.Mostrar();
                    mostrar.MostrarAnimales(dgvAt); // Actualiza lista después de eliminar
                }
            }
            else if (dgvAt.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (NombreEsUnico(nombreAnimal))
                {
                    Editar_Animal formEditar = new Editar_Animal(nombreAnimal);
                    DialogResult resultado = formEditar.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        Clase.Mostrar mostrar = new Clase.Mostrar();
                        mostrar.MostrarAnimales(dgvAt); // Actualiza lista después de editar
                    }
                }
                else
                {
                    MessageBox.Show("Este nombre está duplicado o no existe. No se puede editar de forma segura.", "Advertencia");
                }
            }

            bloqueoEvento = false;
        }

        public void Eliminar_Animal(string nombre)
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.EstablecerConexion();

            string query = "DELETE FROM animales WHERE Nombre = @nombre"; //Elimina la información del animal de la base de datos
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.ExecuteNonQuery();
            }

            string reiniciarContador = "ALTER TABLE animales AUTO_INCREMENT = 1"; //Reinicia el contador despues de eliminarlo de la base de datos

            using (MySqlCommand cmdReinicio = new MySqlCommand(reiniciarContador, conn))
            {
                cmdReinicio.ExecuteNonQuery();
            }

            conexion.CerrarConexion();
        }

        private void Lista_Animales_Terrestres_Load(object sender, EventArgs e)
        {
            dgvAt.CellMouseEnter += dgvAt_CellMouseEnter;
            dgvAt.CellMouseLeave += dgvAt_CellMouseLeave;
        }
    }
}
