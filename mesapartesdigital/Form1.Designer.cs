namespace mesapartesdigital
{
    partial class frmlogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(110, 48);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(135, 134);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "contraseña";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(110, 83);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseña.TabIndex = 4;
            this.txtcontraseña.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label1);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "sistema de mesa de partes digitales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcontraseña;
    }
}

