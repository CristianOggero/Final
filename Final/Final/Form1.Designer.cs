namespace Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUsuario = new Button();
            btnContrasena = new Button();
            btnLogin = new Button();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = SystemColors.ActiveCaption;
            btnUsuario.Location = new Point(12, 360);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(131, 35);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnContrasena
            // 
            btnContrasena.BackColor = SystemColors.ActiveCaption;
            btnContrasena.Location = new Point(12, 415);
            btnContrasena.Name = "btnContrasena";
            btnContrasena.Size = new Size(131, 37);
            btnContrasena.TabIndex = 1;
            btnContrasena.Text = "Contraseña";
            btnContrasena.UseVisualStyleBackColor = false;
            btnContrasena.Click += button2_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Location = new Point(143, 454);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(131, 44);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ActiveCaption;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(149, 364);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 31);
            txtUsuario.TabIndex = 5;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = SystemColors.ActiveCaption;
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.Location = new Point(149, 421);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(125, 27);
            txtContrasena.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Rodri2;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(968, 498);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(btnLogin);
            Controls.Add(btnContrasena);
            Controls.Add(btnUsuario);
            DoubleBuffered = true;
            ImeMode = ImeMode.Disable;
            Name = "Form1";
            Text = "Sistema de Gestión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUsuario;
        private Button btnContrasena;
        private Button btnLogin;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
    }
}
