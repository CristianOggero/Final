namespace Final
{
    partial class Frm2
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
            btnElementos = new Button();
            btnOrdenanza = new Button();
            btnStock = new Button();
            SuspendLayout();
            // 
            // btnElementos
            // 
            btnElementos.BackColor = SystemColors.ActiveCaption;
            btnElementos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnElementos.Location = new Point(5, 4);
            btnElementos.Margin = new Padding(5);
            btnElementos.Name = "btnElementos";
            btnElementos.Size = new Size(317, 70);
            btnElementos.TabIndex = 0;
            btnElementos.Text = "Materia Prima";
            btnElementos.UseVisualStyleBackColor = false;
            btnElementos.Click += btnMateria_Click;
            // 
            // btnOrdenanza
            // 
            btnOrdenanza.BackColor = SystemColors.ActiveCaption;
            btnOrdenanza.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOrdenanza.Location = new Point(378, 4);
            btnOrdenanza.Margin = new Padding(5);
            btnOrdenanza.Name = "btnOrdenanza";
            btnOrdenanza.Size = new Size(314, 70);
            btnOrdenanza.TabIndex = 1;
            btnOrdenanza.Text = "Ordenanza";
            btnOrdenanza.UseVisualStyleBackColor = false;
            btnOrdenanza.Click += btnOrdenanza_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = SystemColors.ActiveCaption;
            btnStock.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnStock.Location = new Point(758, 7);
            btnStock.Margin = new Padding(5);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(314, 67);
            btnStock.TabIndex = 2;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // Frm2
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Rodri2;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1400, 698);
            Controls.Add(btnStock);
            Controls.Add(btnOrdenanza);
            Controls.Add(btnElementos);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Frm2";
            Text = "Sistema de Gestión";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnElementos;
        private Button btnOrdenanza;
        private Button btnStock;
    }
}