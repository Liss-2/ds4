/*namespace Laboratorio12
{
    partial class Laboratorio121
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
            this.lblCalcularDistancia = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnDistanciaRecorrida = new System.Windows.Forms.Button();
            this.btnLimpiarPantalla = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCalcularDistancia
            // 
            this.lblCalcularDistancia.AutoSize = true;
            this.lblCalcularDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCalcularDistancia.Location = new System.Drawing.Point(208, 13);
            this.lblCalcularDistancia.Name = "lblCalcularDistancia";
            this.lblCalcularDistancia.Size = new System.Drawing.Size(119, 17);
            this.lblCalcularDistancia.TabIndex = 0;
            this.lblCalcularDistancia.Text = "Calcular distancia";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(43, 51);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(54, 13);
            this.lblVelocidad.TabIndex = 1;
            this.lblVelocidad.Text = "Velocidad";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(43, 91);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(42, 13);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Tiempo";
            // 
            // btnDistanciaRecorrida
            // 
            this.btnDistanciaRecorrida.Location = new System.Drawing.Point(46, 136);
            this.btnDistanciaRecorrida.Name = "btnDistanciaRecorrida";
            this.btnDistanciaRecorrida.Size = new System.Drawing.Size(119, 48);
            this.btnDistanciaRecorrida.TabIndex = 3;
            this.btnDistanciaRecorrida.Text = "Distancia recorrida";
            this.btnDistanciaRecorrida.UseVisualStyleBackColor = true;
            this.btnDistanciaRecorrida.Click += new System.EventHandler(this.btnDistanciaRecorrida_Click);
            // 
            // btnLimpiarPantalla
            // 
            this.btnLimpiarPantalla.Location = new System.Drawing.Point(183, 136);
            this.btnLimpiarPantalla.Name = "btnLimpiarPantalla";
            this.btnLimpiarPantalla.Size = new System.Drawing.Size(102, 48);
            this.btnLimpiarPantalla.TabIndex = 4;
            this.btnLimpiarPantalla.Text = "Limpiar pantalla";
            this.btnLimpiarPantalla.UseVisualStyleBackColor = true;
            this.btnLimpiarPantalla.Click += new System.EventHandler(this.btnLimpiarPantalla_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(306, 136);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 48);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(126, 51);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(39, 20);
            this.txtVelocidad.TabIndex = 6;
            this.txtVelocidad.TextChanged += new System.EventHandler(this.txtVelocidad_TextChanged);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(126, 91);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(39, 20);
            this.txtTiempo.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(43, 215);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(126, 215);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(77, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(171, 54);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(32, 13);
            this.lblRes.TabIndex = 12;
            this.lblRes.Text = "km/h";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "h";
            // 
            // Laboratorio121
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiarPantalla);
            this.Controls.Add(this.btnDistanciaRecorrida);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.lblCalcularDistancia);
            this.Name = "Laboratorio121";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalcularDistancia;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnDistanciaRecorrida;
        private System.Windows.Forms.Button btnLimpiarPantalla;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label label1;
    }
}*/

   