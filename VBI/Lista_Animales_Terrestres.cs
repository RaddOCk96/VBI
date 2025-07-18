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
        private int ecosistemaSeleccionado;
        public Lista_Animales_Terrestres(int idEcosistemas)
        {
            InitializeComponent();

            dgvAnimales.AutoGenerateColumns = false; //Evitar columnas duplicadas
            CrearColumnasPersonalizadas(); // Se agregan las columnas

            ecosistemaSeleccionado = idEcosistemas;

            AplicarEstiloVisual();
            MostrarAnimalesFiltrados();
        }

        private void AplicarEstiloVisual()
        {
            switch (ecosistemaSeleccionado)
            {
                case 1:
                    this.BackColor = Color.ForestGreen;
                    lblTituloAnimal.Text = "🐾 Animales Terrestres";
                    break;
                case 2:
                    this.BackColor = Color.SkyBlue;
                    lblTituloAnimal.Text = "🐟 Animales Acuáticos";
                    break;
                case 3:
                    this.BackColor = Color.Orange;
                    lblTituloAnimal.Text = "🕊️ Animales Aéreos";
                    break;
            }
        }

        private void MostrarAnimalesFiltrados()
        {
            Clase.Mostrar mostrar = new Clase.Mostrar();
            mostrar.MostrarNombresEcosistemas(dgvAnimales, ecosistemaSeleccionado);
        }




        private void CrearColumnasPersonalizadas()
        {
            // Configuración general del DataGridView
            dgvAnimales.Dock = DockStyle.Fill; // Que ocupe todo el contenedor
            dgvAnimales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Repartir columnas proporcionalmente
            dgvAnimales.RowTemplate.Height = 52; // Altura para íconos grandes
            dgvAnimales.AllowUserToAddRows = false;
            dgvAnimales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimales.RowHeadersVisible = false; //  Esto elimina la columna lateral
            dgvAnimales.BackgroundColor = Color.WhiteSmoke;
            dgvAnimales.BorderStyle = BorderStyle.None;
            dgvAnimales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAnimales.ColumnHeadersVisible = false;
            dgvAnimales.DefaultCellStyle.Font = new Font("Spectral", 12);
            dgvAnimales.Columns.Clear(); // Por si se ejecuta más de una vez

            // Columna de Nombre del Animal
            DataGridViewTextBoxColumn columnaNombre = new DataGridViewTextBoxColumn();
            columnaNombre.Name = "Nombre";
            columnaNombre.DataPropertyName = "Nombre";
            columnaNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnaNombre.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnaNombre.DefaultCellStyle.Padding = new Padding(6, 6, 16, 6);
            dgvAnimales.Columns.Add(columnaNombre);

            // Columna Editar
            DataGridViewImageColumn columnaEditar = new DataGridViewImageColumn();
            columnaEditar.Name = "Editar";
            columnaEditar.Image = new Bitmap(Properties.Resources.boligrafo_cuadrado, new Size(40, 40));
            columnaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnaEditar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            columnaEditar.DefaultCellStyle.Padding = new Padding(10, 6, 10, 6);
            dgvAnimales.Columns.Add(columnaEditar);

            // Columna Eliminar
            DataGridViewImageColumn columnaEliminar = new DataGridViewImageColumn();
            columnaEliminar.Name = "Eliminar";
            columnaEliminar.Image = new Bitmap(Properties.Resources.basura_circular, new Size(40, 40));
            columnaEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnaEliminar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            columnaEliminar.DefaultCellStyle.Padding = new Padding(10, 6, 10, 6);
            dgvAnimales.Columns.Add(columnaEliminar);

            //Tabla
            dgvAnimales.ReadOnly = true; //Evita que el usuario  edite directamente

            //Evita que el usuario cambie el tamaño de las columnas o filas
            dgvAnimales.AllowUserToResizeColumns = false;
            dgvAnimales.AllowUserToResizeRows = false;

        }

        private void dgvAnimales_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex >= dgvAnimales.Rows.Count)
                return;

            string col = dgvAnimales.Columns[e.ColumnIndex].Name;

            if (col == "Editar")
            {
                dgvAnimales.Rows[e.RowIndex].Cells["Editar"].Value =
                    new Bitmap(Properties.Resources.boligrafo_hover, new Size(40, 40));
            }
            else if (col == "Eliminar")
            {
                dgvAnimales.Rows[e.RowIndex].Cells["Eliminar"].Value =
                    new Bitmap(Properties.Resources.basura_hover, new Size(40, 40));
            }
        }



        private void dgvAnimales_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAnimales.Rows)
            {
                bool seleccionado = row.Selected;

                if (row.Cells["Editar"] is DataGridViewImageCell editarCell &&
                    row.Cells["Eliminar"] is DataGridViewImageCell eliminarCell)
                {
                    editarCell.Tag = seleccionado ? "blanco" : "verde"; // guardar estado
                    editarCell.Value = seleccionado
                        ? new Bitmap(Properties.Resources.boligrafo_blanco, new Size(40, 40))
                        : new Bitmap(Properties.Resources.boligrafo_cuadrado, new Size(40, 40));

                    eliminarCell.Tag = seleccionado ? "blanco" : "verde";
                    eliminarCell.Value = seleccionado
                        ? new Bitmap(Properties.Resources.basura_blanco, new Size(40, 40))
                        : new Bitmap(Properties.Resources.basura_circular, new Size(40, 40));
                }
            }
        }

        //Al pasar el cursor a los iconos se le cambia el color
        private void dgvAnimales_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex >= dgvAnimales.Rows.Count)
                return;

            DataGridViewRow row = dgvAnimales.Rows[e.RowIndex];
            string col = dgvAnimales.Columns[e.ColumnIndex].Name;

            if (col == "Editar" && row.Cells["Editar"] is DataGridViewImageCell editarCell)
            {
                editarCell.Value = editarCell.Tag?.ToString() == "blanco"
                    ? new Bitmap(Properties.Resources.boligrafo_blanco, new Size(40, 40))
                    : new Bitmap(Properties.Resources.boligrafo_cuadrado, new Size(40, 40));
            }

            else if (col == "Eliminar" && row.Cells["Eliminar"] is DataGridViewImageCell eliminarCell)
            {
                eliminarCell.Value = eliminarCell.Tag?.ToString() == "blanco"
                    ? new Bitmap(Properties.Resources.basura_blanco, new Size(40, 40))
                    : new Bitmap(Properties.Resources.basura_circular, new Size(40, 40));
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
            Form ventanaAnimal;

            switch (ecosistemaSeleccionado)
            {
                case 1: // Terrestres
                   ventanaAnimal = new Animales_Terrestres(ecosistemaSeleccionado);
                    break;
                case 2: // Acuáticos
                    ventanaAnimal = new Animales_Acuaticos(ecosistemaSeleccionado);
                    break;
                case 3: // Aéreos
                    ventanaAnimal = new Animales_Aereos(ecosistemaSeleccionado);
                    break;
                default:
                    MessageBox.Show("Ecosistema no reconocido.");
                    return;
            }

            ventanaAnimal.StartPosition = this.StartPosition;
            ventanaAnimal.Show();
            this.Close();


        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Agregar_Animal ventanaS = new Agregar_Animal(ecosistemaSeleccionado);
            ventanaS.StartPosition = this.StartPosition;
            ventanaS.Show();
            this.Hide();
        }

        //Verifica que el nombre sea único
        private bool NombreEsUnico(string nombre)
        {
            Conexion conexion = new Conexion();
            MySqlConnection conn = conexion.EstablecerConexion();

            string consulNomUnico = "SELECT COUNT(*) FROM animales WHERE Nombre = @nombre";

            using (MySqlCommand cmd = new MySqlCommand(consulNomUnico, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                conexion.CerrarConexion();

                return cantidad == 1; // Solo acepta si hay exactamente uno
            }
        }

        private bool bloqueoEvento = false;
        private void dgvAnimales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bloqueoEvento || e.RowIndex < 0 || e.ColumnIndex < 0) //Verifica que no haya errores al dar clic varias veces
                return;

            bloqueoEvento = true;

            string nombreAnimal = dgvAnimales.Rows[e.RowIndex].Cells["Nombre"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(nombreAnimal))
            {
                MessageBox.Show("No se pudo obtener el nombre del animal.", "Advertencia");
                bloqueoEvento = false;
                return;
            }

            if (dgvAnimales.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult confirmacion = MessageBox.Show("¿Eliminar este animal?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    Eliminar_Animal(nombreAnimal);
                    Clase.Mostrar mostrar = new Clase.Mostrar();
                    mostrar.MostrarNombresEcosistemas(dgvAnimales, ecosistemaSeleccionado); // Actualiza lista después de eliminar
                }
            }
            else if (dgvAnimales.Columns[e.ColumnIndex].Name == "Editar")
            {
                if (NombreEsUnico(nombreAnimal))
                {
                    this.Hide(); // Oculta la ventana actual

                    Editar_Animal formEditar = new Editar_Animal(nombreAnimal, ecosistemaSeleccionado);
                    DialogResult resultado = formEditar.ShowDialog();

                    this.Show(); //Vuelve a mostrar la ventena de lista

                    if (resultado == DialogResult.OK)
                    {
                        
                        Clase.Mostrar mostrar = new Clase.Mostrar();
                        mostrar.MostrarNombresEcosistemas(dgvAnimales, ecosistemaSeleccionado); // Actualiza lista después de editar
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

            string consulEliminar = "DELETE FROM animales WHERE Nombre = @nombre"; //Elimina la información del animal de la base de datos
            using (MySqlCommand cmd = new MySqlCommand(consulEliminar, conn))
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
            dgvAnimales.CellMouseEnter += dgvAnimales_CellMouseEnter;
            dgvAnimales.CellMouseLeave += dgvAnimales_CellMouseLeave;
            dgvAnimales.SelectionChanged += dgvAnimales_SelectionChanged;
        }

        

       
        

        
    }
}
