﻿namespace VBI
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
            pictureBox1 = new PictureBox();
            cbAlimentacion = new ComboBox();
            cbReproduccion = new ComboBox();
            label9 = new Label();
            cbEcosistema = new ComboBox();
            label8 = new Label();
            panel2 = new Panel();
            txtAgReDescripcion = new TextBox();
            txtAgAlDescripcion = new TextBox();
            btnAgGuardar = new Button();
            txtAgHaDescripcion = new TextBox();
            btnAgImagen2 = new Button();
            pbAgImagen2 = new PictureBox();
            pbAgImagen1 = new PictureBox();
            btnAgImagen1 = new Button();
            label3 = new Label();
            txtAgCaracteristicas = new TextBox();
            txtAgCientifico = new TextBox();
            txtAgNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Croissant One", 30F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(171, 56);
            label1.Name = "label1";
            label1.Size = new Size(903, 71);
            label1.TabIndex = 1;
            label1.Text = "¿Agregamos a un nuevo animal?";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cbAlimentacion);
            panel1.Controls.Add(cbReproduccion);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(cbEcosistema);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtAgReDescripcion);
            panel1.Controls.Add(txtAgAlDescripcion);
            panel1.Controls.Add(btnAgGuardar);
            panel1.Controls.Add(txtAgHaDescripcion);
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
            panel1.Size = new Size(1171, 509);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(295, 1094);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cbAlimentacion
            // 
            cbAlimentacion.Font = new Font("Spectral SemiBold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbAlimentacion.FormattingEnabled = true;
            cbAlimentacion.Location = new Point(769, 420);
            cbAlimentacion.Name = "cbAlimentacion";
            cbAlimentacion.Size = new Size(315, 38);
            cbAlimentacion.TabIndex = 32;
            cbAlimentacion.SelectedIndexChanged += cbAlimentacion_SelectedIndexChanged;
            // 
            // cbReproduccion
            // 
            cbReproduccion.Font = new Font("Spectral SemiBold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbReproduccion.FormattingEnabled = true;
            cbReproduccion.Location = new Point(765, 703);
            cbReproduccion.Name = "cbReproduccion";
            cbReproduccion.Size = new Size(315, 38);
            cbReproduccion.TabIndex = 31;
            cbReproduccion.SelectedIndexChanged += cbReproduccion_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Spectral", 15F);
            label9.Location = new Point(556, 970);
            label9.Name = "label9";
            label9.Size = new Size(148, 38);
            label9.TabIndex = 30;
            label9.Text = "Ecosistema";
            label9.Click += label9_Click;
            // 
            // cbEcosistema
            // 
            cbEcosistema.Font = new Font("Spectral SemiBold", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbEcosistema.FormattingEnabled = true;
            cbEcosistema.Location = new Point(767, 972);
            cbEcosistema.Name = "cbEcosistema";
            cbEcosistema.Size = new Size(315, 38);
            cbEcosistema.TabIndex = 29;
            cbEcosistema.SelectedIndexChanged += cbEcosistema_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Spectral", 15F);
            label8.Location = new Point(512, 1111);
            label8.Name = "label8";
            label8.Size = new Size(148, 38);
            label8.TabIndex = 28;
            label8.Text = "Ecosistema";
            label8.Click += label8_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 1709);
            panel2.Name = "panel2";
            panel2.Size = new Size(1144, 30);
            panel2.TabIndex = 27;
            panel2.Paint += panel2_Paint;
            // 
            // txtAgReDescripcion
            // 
            txtAgReDescripcion.Font = new Font("Spectral", 12F);
            txtAgReDescripcion.Location = new Point(765, 765);
            txtAgReDescripcion.Multiline = true;
            txtAgReDescripcion.Name = "txtAgReDescripcion";
            txtAgReDescripcion.PlaceholderText = "Agrega la descripción ";
            txtAgReDescripcion.Size = new Size(317, 138);
            txtAgReDescripcion.TabIndex = 26;
            // 
            // txtAgAlDescripcion
            // 
            txtAgAlDescripcion.Font = new Font("Spectral", 12F);
            txtAgAlDescripcion.Location = new Point(767, 486);
            txtAgAlDescripcion.Multiline = true;
            txtAgAlDescripcion.Name = "txtAgAlDescripcion";
            txtAgAlDescripcion.PlaceholderText = "Agrega la descripción ";
            txtAgAlDescripcion.Size = new Size(317, 138);
            txtAgAlDescripcion.TabIndex = 25;
            // 
            // btnAgGuardar
            // 
            btnAgGuardar.Font = new Font("Spectral", 13F);
            btnAgGuardar.Location = new Point(498, 1631);
            btnAgGuardar.Name = "btnAgGuardar";
            btnAgGuardar.Size = new Size(163, 50);
            btnAgGuardar.TabIndex = 14;
            btnAgGuardar.Text = "Guardar";
            btnAgGuardar.UseVisualStyleBackColor = true;
            btnAgGuardar.Click += btnAgGuardar_Click;
            // 
            // txtAgHaDescripcion
            // 
            txtAgHaDescripcion.Font = new Font("Spectral", 12F);
            txtAgHaDescripcion.Location = new Point(820, 1181);
            txtAgHaDescripcion.Multiline = true;
            txtAgHaDescripcion.Name = "txtAgHaDescripcion";
            txtAgHaDescripcion.PlaceholderText = "Agrega una descripción";
            txtAgHaDescripcion.Size = new Size(279, 301);
            txtAgHaDescripcion.TabIndex = 13;
            // 
            // btnAgImagen2
            // 
            btnAgImagen2.Font = new Font("Spectral", 10F);
            btnAgImagen2.Location = new Point(498, 1513);
            btnAgImagen2.Name = "btnAgImagen2";
            btnAgImagen2.Size = new Size(162, 33);
            btnAgImagen2.TabIndex = 19;
            btnAgImagen2.Text = "Cargar Imagen";
            btnAgImagen2.UseVisualStyleBackColor = true;
            btnAgImagen2.Click += btnAgImagen2_Click;
            // 
            // pbAgImagen2
            // 
            pbAgImagen2.Location = new Point(421, 1181);
            pbAgImagen2.Name = "pbAgImagen2";
            pbAgImagen2.Size = new Size(330, 301);
            pbAgImagen2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAgImagen2.TabIndex = 18;
            pbAgImagen2.TabStop = false;
            // 
            // pbAgImagen1
            // 
            pbAgImagen1.Location = new Point(127, 115);
            pbAgImagen1.Name = "pbAgImagen1";
            pbAgImagen1.Size = new Size(330, 301);
            pbAgImagen1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            btnAgImagen1.Click += btnAgImagen1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Spectral", 15F);
            label3.Location = new Point(505, 288);
            label3.Name = "label3";
            label3.Size = new Size(233, 38);
            label3.TabIndex = 1;
            label3.Text = "Nombre Científico";
            label3.Click += label3_Click;
            // 
            // txtAgCaracteristicas
            // 
            txtAgCaracteristicas.Font = new Font("Spectral", 12F);
            txtAgCaracteristicas.Location = new Point(82, 1181);
            txtAgCaracteristicas.Multiline = true;
            txtAgCaracteristicas.Name = "txtAgCaracteristicas";
            txtAgCaracteristicas.PlaceholderText = "Agrega las características";
            txtAgCaracteristicas.Size = new Size(269, 301);
            txtAgCaracteristicas.TabIndex = 12;
            txtAgCaracteristicas.TextChanged += textBox5_TextChanged;
            // 
            // txtAgCientifico
            // 
            txtAgCientifico.Font = new Font("Spectral", 12F);
            txtAgCientifico.Location = new Point(769, 278);
            txtAgCientifico.Multiline = true;
            txtAgCientifico.Name = "txtAgCientifico";
            txtAgCientifico.PlaceholderText = "Agrega un nombre";
            txtAgCientifico.Size = new Size(317, 48);
            txtAgCientifico.TabIndex = 9;
            // 
            // txtAgNombre
            // 
            txtAgNombre.Font = new Font("Spectral", 12F);
            txtAgNombre.Location = new Point(769, 164);
            txtAgNombre.Multiline = true;
            txtAgNombre.Name = "txtAgNombre";
            txtAgNombre.PlaceholderText = "Agrega un nombre ";
            txtAgNombre.Size = new Size(317, 45);
            txtAgNombre.TabIndex = 8;
            txtAgNombre.TextChanged += txtAgNombre_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Spectral", 15F);
            label7.Location = new Point(910, 1111);
            label7.Name = "label7";
            label7.Size = new Size(107, 38);
            label7.TabIndex = 5;
            label7.Text = "Hábitat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Spectral", 15F);
            label6.Location = new Point(115, 1111);
            label6.Name = "label6";
            label6.Size = new Size(190, 38);
            label6.TabIndex = 4;
            label6.Text = "Características";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Spectral", 15F);
            label5.Location = new Point(542, 701);
            label5.Name = "label5";
            label5.Size = new Size(178, 38);
            label5.TabIndex = 3;
            label5.Text = "Reproducción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Spectral", 15F);
            label4.Location = new Point(542, 418);
            label4.Name = "label4";
            label4.Size = new Size(174, 38);
            label4.TabIndex = 2;
            label4.Text = "Alimentación";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Spectral", 15F);
            label2.Location = new Point(572, 171);
            label2.Name = "label2";
            label2.Size = new Size(112, 38);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAgImagen2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAgImagen1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Panel panel1;
        private TextBox txtAgHaDescripcion;
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
        private Panel panel2;
        private TextBox txtAgReDescripcion;
        private TextBox txtAgAlDescripcion;
        private Label label8;
        private ComboBox cbEcosistema;
        private Label label9;
        private ComboBox cbAlimentacion;
        private ComboBox cbReproduccion;
        private PictureBox pictureBox1;
    }
}