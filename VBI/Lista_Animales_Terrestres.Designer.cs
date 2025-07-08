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
            label1 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
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
            panel1.Controls.Add(iconPictureBox4);
            panel1.Controls.Add(iconPictureBox3);
            panel1.Location = new Point(280, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 505);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Croissant One", 30F);
            label1.Location = new Point(237, 36);
            label1.Name = "label1";
            label1.Size = new Size(787, 71);
            label1.TabIndex = 2;
            label1.Text = "Lista de Animales Terrestres";
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
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.SpringGreen;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 40;
            iconPictureBox3.Location = new Point(610, 31);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(44, 40);
            iconPictureBox3.TabIndex = 4;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.SpringGreen;
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 40;
            iconPictureBox4.Location = new Point(687, 31);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(40, 40);
            iconPictureBox4.TabIndex = 5;
            iconPictureBox4.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
    }
}