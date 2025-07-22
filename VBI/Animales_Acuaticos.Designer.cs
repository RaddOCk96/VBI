namespace VBI
{
    partial class Animales_Acuaticos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animales_Acuaticos));
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnAnimalesAcua = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.DodgerBlue;
            iconPictureBox1.Cursor = Cursors.Hand;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 39;
            iconPictureBox1.Location = new Point(26, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(41, 39);
            iconPictureBox1.TabIndex = 6;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // btnAnimalesAcua
            // 
            btnAnimalesAcua.Image = (Image)resources.GetObject("btnAnimalesAcua.Image");
            btnAnimalesAcua.ImageAlign = ContentAlignment.TopRight;
            btnAnimalesAcua.Location = new Point(1095, 231);
            btnAnimalesAcua.Name = "btnAnimalesAcua";
            btnAnimalesAcua.Size = new Size(94, 29);
            btnAnimalesAcua.TabIndex = 7;
            btnAnimalesAcua.Text = "Ir a la lista";
            btnAnimalesAcua.UseVisualStyleBackColor = true;
            btnAnimalesAcua.Click += btnAnimalesAcua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 36F);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.Location = new Point(479, 0);
            label1.Name = "label1";
            label1.Size = new Size(576, 71);
            label1.TabIndex = 8;
            label1.Text = "Animales Acuaticos";
            // 
            // Animales_Acuaticos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1283, 691);
            Controls.Add(label1);
            Controls.Add(btnAnimalesAcua);
            Controls.Add(iconPictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Animales_Acuaticos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Animales_Acuaticos";
            Load += Animales_Acuaticos_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Button btnAnimalesAcua;
        private Label label1;
    }
}