namespace VBI
{
    partial class Catalogo
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Croissant One", 40.1999969F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(405, 62);
            label1.Name = "label1";
            label1.Size = new Size(490, 95);
            label1.TabIndex = 0;
            label1.Text = "Ecosistemas ";
            // 
            // button1
            // 
            button1.Font = new Font("Spectral", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(169, 208);
            button1.Name = "button1";
            button1.Size = new Size(387, 205);
            button1.TabIndex = 1;
            button1.Text = "Terrestres ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Spectral SemiBold", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(695, 208);
            button2.Name = "button2";
            button2.Size = new Size(387, 205);
            button2.TabIndex = 2;
            button2.Text = "Acuáticos ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Spectral SemiBold", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(446, 449);
            button3.Name = "button3";
            button3.Size = new Size(387, 205);
            button3.TabIndex = 3;
            button3.Text = "Aéreos ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Spectral", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(33, 604);
            button4.Name = "button4";
            button4.Size = new Size(141, 50);
            button4.TabIndex = 4;
            button4.Text = "Regresar ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Catalogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1283, 691);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Catalogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "catalogo";
            Load += catalogo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}