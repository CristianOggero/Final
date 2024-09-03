namespace Final
{
    partial class Stock
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
            dtg_stock = new DataGridView();
            Numero = new DataGridViewTextBoxColumn();
            Fuente = new DataGridViewTextBoxColumn();
            btn_agregar = new Button();
            btn_borrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_stock).BeginInit();
            SuspendLayout();
            // 
            // dtg_stock
            // 
            dtg_stock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_stock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_stock.Columns.AddRange(new DataGridViewColumn[] { Numero, Fuente });
            dtg_stock.Location = new Point(-1, 47);
            dtg_stock.Name = "dtg_stock";
            dtg_stock.RowHeadersWidth = 51;
            dtg_stock.Size = new Size(803, 406);
            dtg_stock.TabIndex = 0;
            // 
            // Numero
            // 
            Numero.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Numero.HeaderText = "Material";
            Numero.MinimumWidth = 6;
            Numero.Name = "Numero";
            // 
            // Fuente
            // 
            Fuente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fuente.HeaderText = "Cantidad";
            Fuente.MinimumWidth = 6;
            Fuente.Name = "Fuente";
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(227, 12);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(94, 29);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            btn_borrar.Location = new Point(482, 12);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(94, 29);
            btn_borrar.TabIndex = 2;
            btn_borrar.Text = "Borrar";
            btn_borrar.UseVisualStyleBackColor = true;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_borrar);
            Controls.Add(btn_agregar);
            Controls.Add(dtg_stock);
            Name = "Stock";
            Text = "Stock";
            Load += Stock_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_stock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_stock;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Fecha_final;
        private DataGridViewTextBoxColumn Estado;
        private Button btn_agregar;
        private Button btn_borrar;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Fuente;
    }
}