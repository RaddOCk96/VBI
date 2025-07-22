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

namespace VBI
{
    public partial class Fuentes : Form
    {
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;


        public Fuentes()
        {
            InitializeComponent();
            FuentesAnimal();
            FuentesAcuaticos();
            FuentesAereos();
        }

        private void FuentesAnimal()
        {
            dataGridView1 = new DataGridView();
            dataGridView1.Name = "DataGridView1Animales";
            dataGridView1.Location = new Point(20, 100);
            dataGridView1.Size = new Size(tabControl1.ClientSize.Width - 40, tabControl1.ClientSize.Height - 150);
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // Apareiencia del DataGridView
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.GridColor = Color.LightGray;
            //encabezado del DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeight = 30;
            // Columnas del DataGridView    
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Titulo", HeaderText = "Título", DataPropertyName = "Titulo" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "NombrePagina", HeaderText = "Página", DataPropertyName = "NombrePagina" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "FechadePublicacion", HeaderText = "Publicado", DataPropertyName = "FechadePublicacion" });
            dataGridView1.Columns.Add(new DataGridViewLinkColumn() { Name = "Url", HeaderText = "Enlace", DataPropertyName = "Url", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "FechaConsulta", HeaderText = "Consulta", DataPropertyName = "FechaConsulta" });

            tabPage1.Controls.Add(dataGridView1);
            dataGridView1.BringToFront();

            int idEcosistema = 1;
            dataGridView1.DataSource = ObtenerFuentes(idEcosistema);
            dataGridView1.CellContentClick += AbrirEnlaceDesdeCelda;
        }


        private void FuentesAcuaticos()
        {
            dataGridView2 = new DataGridView();
            dataGridView2.Name = "DataGridView2Acuaticos";
            dataGridView2.Location = new Point(20, 100);
            dataGridView2.Size = new Size(tabControl1.ClientSize.Width - 40, tabControl1.ClientSize.Height - 150);
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // Apareiencia del DataGridView
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.FixedSingle;
            dataGridView2.GridColor = Color.LightGray;
            //encabezado del DataGridView
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView2.ColumnHeadersHeight = 30;
            // Columnas del DataGridView    
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Titulo", HeaderText = "Título", DataPropertyName = "Titulo" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn() { Name = "NombrePagina", HeaderText = "Página", DataPropertyName = "NombrePagina" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn() { Name = "FechadePublicacion", HeaderText = "Publicado", DataPropertyName = "FechadePublicacion" });
            dataGridView2.Columns.Add(new DataGridViewLinkColumn() { Name = "Url", HeaderText = "Enlace", DataPropertyName = "Url", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn() { Name = "FechaConsulta", HeaderText = "Consulta", DataPropertyName = "FechaConsulta" });

            tabPage2.Controls.Add(dataGridView2);
            dataGridView2.BringToFront();

            int idEcosistema = 2;
            dataGridView2.DataSource = ObtenerFuentes(idEcosistema);
            dataGridView2.CellContentClick += AbrirEnlaceDesdeCelda;


        }
        private void FuentesAereos()
        {
            dataGridView3 = new DataGridView();
            dataGridView3.Name = "DataGridView3Aereos";
            dataGridView3.Location = new Point(20, 100);
            dataGridView3.Size = new Size(tabControl1.ClientSize.Width - 40, tabControl1.ClientSize.Height - 150);
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // Apareiencia del DataGridView
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.BorderStyle = BorderStyle.FixedSingle;
            dataGridView3.GridColor = Color.LightGray;
            //encabezado del DataGridView
            dataGridView3.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView3.ColumnHeadersHeight = 30;
            // Columnas del DataGridView    
            dataGridView3.Columns.Clear();
            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Titulo", HeaderText = "Título", DataPropertyName = "Titulo" });
            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn() { Name = "NombrePagina", HeaderText = "Página", DataPropertyName = "NombrePagina" });
            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn() { Name = "FechadePublicacion", HeaderText = "Publicado", DataPropertyName = "FechadePublicacion" });
            dataGridView3.Columns.Add(new DataGridViewLinkColumn() { Name = "Url", HeaderText = "Enlace", DataPropertyName = "Url", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn() { Name = "FechaConsulta", HeaderText = "Consulta", DataPropertyName = "FechaConsulta" });

            tabPage3.Controls.Add(dataGridView3);
            dataGridView3.BringToFront();

            int idEcosistema = 3;
            dataGridView3.DataSource = ObtenerFuentes(idEcosistema);
            dataGridView3.CellContentClick += AbrirEnlaceDesdeCelda;


        }
        private void AbrirEnlaceDesdeCelda(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                string link = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!string.IsNullOrEmpty(link))
                {
                    // Aquí puedes abrir el enlace si lo deseas
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = link,
                        UseShellExecute = true
                    });
                    // Aquí puedes abrir el enlace si lo deseas
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = link,
                        UseShellExecute = true
                    });
                    // Aquí puedes abrir el enlace si lo deseas
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = link,
                        UseShellExecute = true
                    });
                }
            }
        }
        private List<FuenteIEEE> ObtenerFuentes(int idEcosistema)
        {
            var lista = new List<FuenteIEEE>();
            string connectionString = "server=127.0.0.1;user=root;password=FRDKCU96;database=vbi";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT ID, Titulo, NombrePagina, FechaPublicacion, URL, FechaConsulta FROM referencias WHERE Id_ecosistema = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEcosistema);
                    try
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new FuenteIEEE
                                {
                                    Titulo = reader.IsDBNull(reader.GetOrdinal("Titulo")) ? "" : reader.GetString("Titulo"),
                                    NombrePagina = reader.IsDBNull(reader.GetOrdinal("NombrePagina")) ? "" : reader.GetString("NombrePagina"),
                                    FechadePublicacion = reader.IsDBNull(reader.GetOrdinal("FechaPublicacion")) ? "" : reader.GetDateTime(reader.GetOrdinal("FechaPublicacion")).ToString("yyyy-MM-dd"),
                                    Url = reader.IsDBNull(reader.GetOrdinal("URL")) ? "" : reader.GetString("URL"),
                                    FechaConsulta = reader.IsDBNull(reader.GetOrdinal("FechaConsulta")) ? "" : reader.GetDateTime(reader.GetOrdinal("FechaConsulta")).ToString("yyyy-MM-dd"),
                                    Id = reader.IsDBNull(reader.GetOrdinal("ID")) ? 0 : reader.GetInt32(reader.GetOrdinal("ID"))
                                });

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                    }
                }
            }

            return lista;
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Fuentes_Load(object sender, EventArgs e)
        {

        }
    }

    public class FuenteIEEE
    {
        public string Titulo { get; set; }
        public string NombrePagina { get; set; }
        public string FechadePublicacion { get; set; }
        public string Url { get; set; }
        public string FechaConsulta { get; set; }
        public int Id { get; set; }
    }
}
