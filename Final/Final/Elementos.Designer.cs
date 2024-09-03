namespace Final
{
    partial class Elementos
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
            cb_materiaprima = new ComboBox();
            list_materiaprima = new ListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // cb_materiaprima
            // 
            cb_materiaprima.FormattingEnabled = true;
            cb_materiaprima.Items.AddRange(new object[] { "Cartel 35x35", "Cartel 35x70", "Cartel 60x90", "Cartel 60x60", "Lomas de burro" });
            cb_materiaprima.Location = new Point(60, 192);
            cb_materiaprima.Name = "cb_materiaprima";
            cb_materiaprima.Size = new Size(151, 28);
            cb_materiaprima.TabIndex = 0;
            // 
            // list_materiaprima
            // 
            list_materiaprima.Location = new Point(341, 43);
            list_materiaprima.Name = "list_materiaprima";
            list_materiaprima.Size = new Size(415, 362);
            list_materiaprima.TabIndex = 1;
            list_materiaprima.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(44, 146);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 2;
            label1.Text = "Seleccione el elemento";
            // 
            // Elementos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(list_materiaprima);
            Controls.Add(cb_materiaprima);
            Name = "Elementos";
            Text = "Elementos";
            Load += Elementos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_materiaprima;
        private ListView list_materiaprima;
        private Label label1;
    }
}