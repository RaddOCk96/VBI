﻿namespace VBI
{
    partial class Editar_Animal
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
            label8 = new Label();
            cbEcosistema = new ComboBox();
            cbEdReproduccion = new ComboBox();
            cbEdAlimentacion = new ComboBox();
            btnEdImagen2 = new Button();
            pbEdImagen2 = new PictureBox();
            pbEdImagen1 = new PictureBox();
            panel2 = new Panel();
            btnEdImagen = new Button();
            btnEdGuardar = new Button();
            txtEdHabitat = new TextBox();
            label3 = new Label();
            txtEdCaracteristicas = new TextBox();
            txtEdReDescripcion = new TextBox();
            txtEdAlDescripcion = new TextBox();
            txtEdCientifico = new TextBox();
            txtEdNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEdImagen2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEdImagen1).BeginInit();
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
            label1.Location = new Point(347, 66);
            label1.Name = "label1";
            label1.Size = new Size(495, 71);
            label1.TabIndex = 2;
            label1.Text = "Editar un Animal";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cbEcosistema);
            panel1.Controls.Add(cbEdReproduccion);
            panel1.Controls.Add(cbEdAlimentacion);
            panel1.Controls.Add(btnEdImagen2);
            panel1.Controls.Add(pbEdImagen2);
            panel1.Controls.Add(pbEdImagen1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnEdImagen);
            panel1.Controls.Add(btnEdGuardar);
            panel1.Controls.Add(txtEdHabitat);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtEdCaracteristicas);
            panel1.Controls.Add(txtEdReDescripcion);
            panel1.Controls.Add(txtEdAlDescripcion);
            panel1.Controls.Add(txtEdCientifico);
            panel1.Controls.Add(txtEdNombre);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(44, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 559);
            panel1.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Spectral", 15F);
            label8.Location = new Point(556, 970);
            label8.Name = "label8";
            label8.Size = new Size(148, 38);
            label8.TabIndex = 23;
            label8.Text = "Ecosistema";
            // 
            // cbEcosistema
            // 
            cbEcosistema.Font = new Font("Spectral SemiBold", 11.999999F, FontStyle.Bold);
            cbEcosistema.FormattingEnabled = true;
            cbEcosistema.Location = new Point(767, 972);
            cbEcosistema.Name = "cbEcosistema";
            cbEcosistema.Size = new Size(315, 38);
            cbEcosistema.TabIndex = 22;
            cbEcosistema.SelectedIndexChanged += cbEcosistema_SelectedIndexChanged_1;
            // 
            // cbEdReproduccion
            // 
            cbEdReproduccion.Font = new Font("Spectral SemiBold", 11.999999F, FontStyle.Bold);
            cbEdReproduccion.FormattingEnabled = true;
            cbEdReproduccion.Location = new Point(765, 703);
            cbEdReproduccion.Name = "cbEdReproduccion";
            cbEdReproduccion.Size = new Size(315, 38);
            cbEdReproduccion.TabIndex = 21;
            cbEdReproduccion.SelectedIndexChanged += cbEdReproduccion_SelectedIndexChanged;
            // 
            // cbEdAlimentacion
            // 
            cbEdAlimentacion.Font = new Font("Spectral SemiBold", 11.999999F, FontStyle.Bold);
            cbEdAlimentacion.FormattingEnabled = true;
            cbEdAlimentacion.Location = new Point(769, 420);
            cbEdAlimentacion.Name = "cbEdAlimentacion";
            cbEdAlimentacion.Size = new Size(315, 38);
            cbEdAlimentacion.TabIndex = 20;
            cbEdAlimentacion.SelectedIndexChanged += cbEdAlimentacion_SelectedIndexChanged;
            // 
            // btnEdImagen2
            // 
            btnEdImagen2.Font = new Font("Spectral", 10F);
            btnEdImagen2.Location = new Point(498, 1513);
            btnEdImagen2.Name = "btnEdImagen2";
            btnEdImagen2.Size = new Size(162, 33);
            btnEdImagen2.TabIndex = 19;
            btnEdImagen2.Text = "Cargar Imagen";
            btnEdImagen2.UseVisualStyleBackColor = true;
            btnEdImagen2.Click += btnEdImagen2_Click;
            // 
            // pbEdImagen2
            // 
            pbEdImagen2.Location = new Point(421, 1181);
            pbEdImagen2.Name = "pbEdImagen2";
            pbEdImagen2.Size = new Size(330, 301);
            pbEdImagen2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEdImagen2.TabIndex = 18;
            pbEdImagen2.TabStop = false;
            // 
            // pbEdImagen1
            // 
            pbEdImagen1.Location = new Point(127, 115);
            pbEdImagen1.Name = "pbEdImagen1";
            pbEdImagen1.Size = new Size(330, 301);
            pbEdImagen1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEdImagen1.TabIndex = 17;
            pbEdImagen1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 1709);
            panel2.Name = "panel2";
            panel2.Size = new Size(1144, 30);
            panel2.TabIndex = 16;
            // 
            // btnEdImagen
            // 
            btnEdImagen.Font = new Font("Spectral", 10F);
            btnEdImagen.Location = new Point(212, 443);
            btnEdImagen.Name = "btnEdImagen";
            btnEdImagen.Size = new Size(162, 33);
            btnEdImagen.TabIndex = 15;
            btnEdImagen.Text = "Cargar Imagen";
            btnEdImagen.UseVisualStyleBackColor = true;
            btnEdImagen.Click += btnEdImagen_Click;
            // 
            // btnEdGuardar
            // 
            btnEdGuardar.Font = new Font("Spectral", 13F);
            btnEdGuardar.Location = new Point(498, 1631);
            btnEdGuardar.Name = "btnEdGuardar";
            btnEdGuardar.Size = new Size(163, 50);
            btnEdGuardar.TabIndex = 14;
            btnEdGuardar.Text = "Guardar";
            btnEdGuardar.UseVisualStyleBackColor = true;
            btnEdGuardar.Click += btnEdGuardar_Click;
            // 
            // txtEdHabitat
            // 
            txtEdHabitat.Font = new Font("Spectral", 12F);
            txtEdHabitat.Location = new Point(820, 1181);
            txtEdHabitat.Multiline = true;
            txtEdHabitat.Name = "txtEdHabitat";
            txtEdHabitat.Size = new Size(279, 301);
            txtEdHabitat.TabIndex = 13;
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
            // 
            // txtEdCaracteristicas
            // 
            txtEdCaracteristicas.Font = new Font("Spectral", 12F);
            txtEdCaracteristicas.Location = new Point(82, 1181);
            txtEdCaracteristicas.Multiline = true;
            txtEdCaracteristicas.Name = "txtEdCaracteristicas";
            txtEdCaracteristicas.Size = new Size(269, 282);
            txtEdCaracteristicas.TabIndex = 12;
            // 
            // txtEdReDescripcion
            // 
            txtEdReDescripcion.Font = new Font("Spectral", 12F);
            txtEdReDescripcion.Location = new Point(765, 765);
            txtEdReDescripcion.Multiline = true;
            txtEdReDescripcion.Name = "txtEdReDescripcion";
            txtEdReDescripcion.Size = new Size(317, 138);
            txtEdReDescripcion.TabIndex = 11;
            // 
            // txtEdAlDescripcion
            // 
            txtEdAlDescripcion.Font = new Font("Spectral", 12F);
            txtEdAlDescripcion.Location = new Point(767, 486);
            txtEdAlDescripcion.Multiline = true;
            txtEdAlDescripcion.Name = "txtEdAlDescripcion";
            txtEdAlDescripcion.Size = new Size(317, 138);
            txtEdAlDescripcion.TabIndex = 10;
            // 
            // txtEdCientifico
            // 
            txtEdCientifico.Font = new Font("Spectral", 12F);
            txtEdCientifico.Location = new Point(769, 278);
            txtEdCientifico.Name = "txtEdCientifico";
            txtEdCientifico.Size = new Size(317, 38);
            txtEdCientifico.TabIndex = 9;
            // 
            // txtEdNombre
            // 
            txtEdNombre.Font = new Font("Spectral", 12F);
            txtEdNombre.Location = new Point(769, 164);
            txtEdNombre.Name = "txtEdNombre";
            txtEdNombre.Size = new Size(317, 38);
            txtEdNombre.TabIndex = 8;
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
            // Editar_Animal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1250, 713);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(iconPictureBox1);
            Name = "Editar_Animal";
            Text = " ";
            Load += Editar_Animal_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEdImagen2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEdImagen1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Panel panel1;
        private Button btnEdImagen2;
        private PictureBox pbEdImagen2;
        private PictureBox pbEdImagen1;
        private Panel panel2;
        private Button btnEdImagen;
        private Button btnEdGuardar;
        private TextBox txtEdHabitat;
        private Label label3;
        private TextBox txtEdCaracteristicas;
        private TextBox txtEdReDescripcion;
        private TextBox txtEdAlDescripcion;
        private TextBox txtEdCientifico;
        private TextBox txtEdNombre;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label8;
        private ComboBox cbEcosistema;
        private ComboBox cbEdReproduccion;
        private ComboBox cbEdAlimentacion;
    }
}