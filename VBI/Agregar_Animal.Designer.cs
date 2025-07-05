namespace VBI
{
    partial class Agregar_Animal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            panel1 = new Panel();
            btnAgImagen2 = new Button();
            pbAgImagen2 = new PictureBox();
            pbAgImagen1 = new PictureBox();
            btnAgImagen1 = new Button();
            btnAgGuardar = new Button();
            txtAgHabitat = new TextBox();
            label3 = new Label();
            txtAgCaracteristicas = new TextBox();
            txtAgCientifico = new TextBox();
            txtAgNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAgImagen2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAgImagen1).BeginInit();
            SuspendLayout();
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SpringGreen;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 51;
            iconPictureBox1.Location = new Point(26, 26);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(54, 51);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Croissant One", 30F);
            label1.Location = new Point(347, 66);
            label1.Name = "label1";
            label1.Size = new Size(511, 71);
            label1.TabIndex = 1;
            label1.Text = "Agrega un Animal";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(btnAgGuardar);
            panel1.Controls.Add(txtAgHabitat);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnAgImagen2);
            panel1.Controls.Add(pbAgImagen2);
            panel1.Controls.Add(pbAgImagen1);
            panel1.Controls.Add(btnAgImagen1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtAgCaracteristicas);
            panel1.Controls.Add(txtAgCientifico);
            panel1.Controls.Add(txtAgNombre);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(44, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 559);
            panel1.TabIndex = 2;
            // 
            // btnAgImagen2
            // 
            btnAgImagen2.Font = new Font("Spectral", 10F);
            btnAgImagen2.Location = new Point(496, 1447);
            btnAgImagen2.Name = "btnAgImagen2";
            btnAgImagen2.Size = new Size(162, 33);
            btnAgImagen2.TabIndex = 19;
            btnAgImagen2.Text = "Cargar Imagen";
            btnAgImagen2.UseVisualStyleBackColor = true;
            btnAgImagen2.Click += btnAgImagen2_Click;
            // 
            // pbAgImagen2
            // 
            pbAgImagen2.Location = new Point(415, 1102);
            pbAgImagen2.Name = "pbAgImagen2";
            pbAgImagen2.Size = new Size(330, 301);
            pbAgImagen2.TabIndex = 18;
            pbAgImagen2.TabStop = false;
            // 
            // pbAgImagen1
            // 
            pbAgImagen1.Location = new Point(127, 115);
            pbAgImagen1.Name = "pbAgImagen1";
            pbAgImagen1.Size = new Size(330, 301);
            pbAgImagen1.TabIndex = 17;
            pbAgImagen1.TabStop = false;
            // 
            // btnAgImagen1
            // 
            btnAgImagen1.Font = new Font("Spectral", 10F);
            btnAgImagen1.Location = new Point(212, 443);
            btnAgImagen1.Name = "btnAgImagen1";
            btnAgImagen1.Size = new Size(162, 33);
            btnAgImagen1.TabIndex = 15;
            btnAgImagen1.Text = "Cargar Imagen";
            btnAgImagen1.UseVisualStyleBackColor = true;
            // 
            // btnAgGuardar
            // 
            btnAgGuardar.Font = new Font("Spectral", 13F);
            btnAgGuardar.Location = new Point(495, 1546);
            btnAgGuardar.Name = "btnAgGuardar";
            btnAgGuardar.Size = new Size(163, 50);
            btnAgGuardar.TabIndex = 14;
            btnAgGuardar.Text = "Guardar";
            btnAgGuardar.UseVisualStyleBackColor = true;
            btnAgGuardar.Click += btnAgGuardar_Click;
            // 
            // txtAgHabitat
            // 
            txtAgHabitat.Font = new Font("Spectral", 12F);
            txtAgHabitat.Location = new Point(814, 1102);
            txtAgHabitat.Multiline = true;
            txtAgHabitat.Name = "txtAgHabitat";
            txtAgHabitat.Size = new Size(279, 301);
            txtAgHabitat.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Spectral", 15F);
            label3.Location = new Point(513, 174);
            label3.Name = "label3";
            label3.Size = new Size(233, 38);
            label3.TabIndex = 1;
            label3.Text = "Nombre Científico";
            label3.Click += label3_Click;
            // 
            // txtAgCaracteristicas
            // 
            txtAgCaracteristicas.Font = new Font("Spectral", 12F);
            txtAgCaracteristicas.Location = new Point(59, 1121);
            txtAgCaracteristicas.Multiline = true;
            txtAgCaracteristicas.Name = "txtAgCaracteristicas";
            txtAgCaracteristicas.Size = new Size(269, 282);
            txtAgCaracteristicas.TabIndex = 12;
            txtAgCaracteristicas.TextChanged += textBox5_TextChanged;
            // 
            // txtAgCientifico
            // 
            txtAgCientifico.Font = new Font("Spectral", 12F);
            txtAgCientifico.Location = new Point(767, 176);
            txtAgCientifico.Multiline = true;
            txtAgCientifico.Name = "txtAgCientifico";
            txtAgCientifico.PlaceholderText = "Agrega un nombre";
            txtAgCientifico.Size = new Size(248, 27);
            txtAgCientifico.TabIndex = 9;
            // 
            // txtAgNombre
            // 
            txtAgNombre.Font = new Font("Spectral", 12F);
            txtAgNombre.Location = new Point(767, 100);
            txtAgNombre.Multiline = true;
            txtAgNombre.Name = "txtAgNombre";
            txtAgNombre.PlaceholderText = "Agrega un nombre ";
            txtAgNombre.Size = new Size(248, 27);
            txtAgNombre.TabIndex = 8;
            txtAgNombre.TextChanged += txtAgNombre_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Spectral", 15F);
            label7.Location = new Point(896, 1030);
            label7.Name = "label7";
            label7.Size = new Size(107, 38);
            label7.TabIndex = 5;
            label7.Text = "Hábitat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Spectral", 15F);
            label6.Location = new Point(88, 1030);
            label6.Name = "label6";
            label6.Size = new Size(190, 38);
            label6.TabIndex = 4;
            label6.Text = "Características";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Spectral", 15F);
            label5.Location = new Point(523, 541);
            label5.Name = "label5";
            label5.Size = new Size(178, 38);
            label5.TabIndex = 3;
            label5.Text = "Reproducción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Spectral", 15F);
            label4.Location = new Point(513, 257);
            label4.Name = "label4";
            label4.Size = new Size(174, 38);
            label4.TabIndex = 2;
            label4.Text = "Alimentación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Spectral", 15F);
            label2.Location = new Point(514, 93);
            label2.Name = "label2";
            label2.Size = new Size(112, 38);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Spectral", 15F);
            label8.Location = new Point(507, 848);
            label8.Name = "label8";
            label8.Size = new Size(154, 38);
            label8.TabIndex = 20;
            label8.Text = "Ecosistema ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(792, 858);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 28);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(767, 257);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(248, 28);
            comboBox2.TabIndex = 23;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(792, 551);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(248, 28);
            comboBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Spectral", 12F);
            textBox2.Location = new Point(737, 322);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Agrega la descripción ";
            textBox2.Size = new Size(345, 138);
            textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Spectral", 12F);
            textBox3.Location = new Point(737, 630);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Agrega la descripción ";
            textBox3.Size = new Size(345, 138);
            textBox3.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.Location = new Point(21, 1635);
            panel2.Name = "panel2";
            panel2.Size = new Size(117, 26);
            panel2.TabIndex = 27;
            // 
            // Agregar_Animal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1250, 713);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(iconPictureBox1);
            Name = "Agregar_Animal";
            Text = "Agregar_Animal";
            Load += Agregar_Animal_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAgImagen2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAgImagen1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Panel panel1;
        private TextBox txtAgHabitat;
        private TextBox txtAgCaracteristicas;
        private Label label7;
        private Label label6;
        private Button btnAgImagen1;
        private Button btnAgGuardar;
        private PictureBox pbAgImagen1;
        private Label label3;
        private TextBox txtAgCientifico;
        private TextBox txtAgNombre;
        private Label label5;
        private Label label4;
        private Label label2;
        private PictureBox pbAgImagen2;
        private Button btnAgImagen2;
        private ComboBox comboBox1;
        private Label label8;
        private Panel panel2;
        private TextBox textBox3;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
    }
}