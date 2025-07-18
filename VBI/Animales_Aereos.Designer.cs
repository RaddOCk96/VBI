namespace VBI
{
    partial class Animales_Aereos
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
            button1 = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnListaAnimalesAe = new Button();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1117, 50);
            button1.Name = "button1";
            button1.Size = new Size(103, 43);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(255, 189, 89);
            iconPictureBox1.Cursor = Cursors.Hand;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 39;
            iconPictureBox1.Location = new Point(22, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(41, 39);
            iconPictureBox1.TabIndex = 7;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // btnListaAnimalesAe
            // 
            btnListaAnimalesAe.Location = new Point(1133, 178);
            btnListaAnimalesAe.Name = "btnListaAnimalesAe";
            btnListaAnimalesAe.Size = new Size(94, 29);
            btnListaAnimalesAe.TabIndex = 8;
            btnListaAnimalesAe.Text = "Ir a la Lista";
            btnListaAnimalesAe.UseVisualStyleBackColor = true;
            btnListaAnimalesAe.Click += btnListaAnimalesAe_Click;
            // 
            // Animales_Aereos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 189, 89);
            ClientSize = new Size(1283, 691);
            Controls.Add(btnListaAnimalesAe);
            Controls.Add(iconPictureBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Animales_Aereos";
            Text = "Animales_Aereos";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Button btnListaAnimalesAe;
    }
}