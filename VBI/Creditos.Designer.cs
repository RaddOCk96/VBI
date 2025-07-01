namespace VBI
{
    partial class Creditos
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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Croissant One", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(53, 60);
            label1.Name = "label1";
            label1.Size = new Size(662, 85);
            label1.TabIndex = 0;
            label1.Text = "Acerca de nosotros ";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.MediumAquamarine;
            iconPictureBox1.Cursor = Cursors.Hand;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 51;
            iconPictureBox1.Location = new Point(12, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(73, 51);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Font = new Font("Spectral SemiBold", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1107, 618);
            button1.Name = "button1";
            button1.Size = new Size(116, 43);
            button1.TabIndex = 2;
            button1.Text = "Fuentes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Creditos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(1283, 691);
            Controls.Add(button1);
            Controls.Add(iconPictureBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Creditos";
            Text = "Créditos";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Button button1;
    }
}