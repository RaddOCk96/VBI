namespace VBI
{
    partial class Lista_Animales_Terrestres
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
            panel1 = new Panel();
            dgvAt = new DataGridView();
            label1 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
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
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.SpringGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvAt);
            panel1.Location = new Point(300, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 505);
            panel1.TabIndex = 1;
            // 
            // dgvAt
            // 
            dgvAt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAt.Location = new Point(-1, -1);
            dgvAt.Name = "dgvAt";
            dgvAt.RowHeadersWidth = 51;
            dgvAt.Size = new Size(719, 618);
            dgvAt.TabIndex = 0;
            dgvAt.CellContentClick += dgvAt_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Croissant One", 30F);
            label1.Location = new Point(376, 26);
            label1.Name = "label1";
            label1.Size = new Size(503, 71);
            label1.TabIndex = 2;
            label1.Text = "Lista de Animales";
            label1.Click += label1_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.SpringGreen;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 55;
            iconPictureBox2.Location = new Point(177, 135);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(59, 55);
            iconPictureBox2.TabIndex = 3;
            iconPictureBox2.TabStop = false;
            iconPictureBox2.Click += iconPictureBox2_Click;
            // 
            // Lista_Animales_Terrestres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1283, 691);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Name = "Lista_Animales_Terrestres";
            Text = "Lista_Animales_Terrestres";
            Load += Lista_Animales_Terrestres_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAt).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private DataGridView dgvAt;
    }
}