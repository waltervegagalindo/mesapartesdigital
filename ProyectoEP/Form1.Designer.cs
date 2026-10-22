namespace ProyectoEP
{
    partial class MesaDePartesDigital
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
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontra = new System.Windows.Forms.Label();
            this.txtboxusu = new System.Windows.Forms.TextBox();
            this.txtboxcontra = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(126, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesa De Partes Digital";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(156, 189);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(79, 24);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Usuario:";
            this.lblusuario.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontra.Location = new System.Drawing.Point(124, 260);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(111, 24);
            this.lblcontra.TabIndex = 2;
            this.lblcontra.Text = "Contraseña:";
            // 
            // txtboxusu
            // 
            this.txtboxusu.Location = new System.Drawing.Point(252, 190);
            this.txtboxusu.Name = "txtboxusu";
            this.txtboxusu.Size = new System.Drawing.Size(322, 22);
            this.txtboxusu.TabIndex = 3;
            this.txtboxusu.TextChanged += new System.EventHandler(this.txtboxusu_TextChanged);
            // 
            // txtboxcontra
            // 
            this.txtboxcontra.Location = new System.Drawing.Point(252, 260);
            this.txtboxcontra.Name = "txtboxcontra";
            this.txtboxcontra.Size = new System.Drawing.Size(322, 22);
            this.txtboxcontra.TabIndex = 4;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(179, 335);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(181, 63);
            this.btningresar.TabIndex = 5;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(422, 335);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(181, 62);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // MesaDePartesDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtboxcontra);
            this.Controls.Add(this.txtboxusu);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label1);
            this.Name = "MesaDePartesDigital";
            this.Text = "MesaDePartesDigital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblcontra;
        private System.Windows.Forms.TextBox txtboxusu;
        private System.Windows.Forms.TextBox txtboxcontra;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label1;
    }
}

