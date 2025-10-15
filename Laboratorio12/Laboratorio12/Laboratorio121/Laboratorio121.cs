using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12
{
    public partial class Laboratorio121 : Form
    {
        CalculoDistancia obj = new CalculoDistancia();
        public Laboratorio121()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtVelocidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDistanciaRecorrida_Click(object sender, EventArgs e)
        {
            Console.WriteLine("en actionPerformed");
            //d=v*t
            double velocidad = double.Parse(txtVelocidad.Text);
            double tiempo = double.Parse(txtTiempo.Text);
            double distancia = obj.Calcular(velocidad, tiempo);
            txtResultado.Text = $"{distancia} km";
        }

        //método para limpiar los datos
        private void Limpiar()
        {
            txtVelocidad.Text = "";
            txtTiempo.Text = "";
            txtResultado.Text = $"{0} km";
        }

        private void btnLimpiarPantalla_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Label lblCalcularDistancia;
        private Label lblVelocidad;
        private Label lblTiempo;
        private Button btnDistanciaRecorrida;
        private Button btnLimpiarPantalla;
        private Button btnSalir;
        private TextBox txtVelocidad;
        private TextBox txtTiempo;
        private Label lblResultado;
        private TextBox txtResultado;
        private Label lblRes;
        private Label label1;

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
            this.Load += new System.EventHandler(this.Laboratorio121_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Laboratorio121_Load(object sender, EventArgs e)
        {

        }
    }
}
