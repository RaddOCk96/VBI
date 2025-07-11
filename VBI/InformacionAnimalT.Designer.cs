namespace VBI
{
    partial class InformacionAnimalT
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
            label1 = new Label();
            label2 = new Label();
            pbImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Croissant One", 40F);
            label1.Location = new Point(281, 35);
            label1.Name = "label1";
            label1.Size = new Size(674, 95);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Spectral SemiBold", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(403, 130);
            label2.Name = "label2";
            label2.Size = new Size(417, 50);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(403, 207);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(443, 326);
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.TabIndex = 2;
            pbImagen.TabStop = false;
            pbImagen.Click += pbImagen_Click;
            // 
            // InformacionAnimalT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1250, 713);
            Controls.Add(pbImagen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InformacionAnimalT";
            Text = "InformacionAnimalT";
            Load += InformacionAnimalT_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pbImagen;
    }
}