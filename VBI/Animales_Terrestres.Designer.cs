namespace VBI
{
    partial class Animales_Terrestres
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(775, 434);
            button1.Name = "button1";
            button1.Size = new Size(393, 152);
            button1.TabIndex = 0;
            button1.Text = "Agregar un animal (prueba)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Animales_Terrestres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1283, 691);
            Controls.Add(button1);
            Name = "Animales_Terrestres";
            Text = "Animales_Terrestres";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}