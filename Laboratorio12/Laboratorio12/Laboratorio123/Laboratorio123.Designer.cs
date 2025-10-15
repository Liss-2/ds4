namespace Laboratorio12.Laboratorio123
{
    partial class Laboratorio123
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
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.lblSemiperimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.txtSemiperimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnSemiperimetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Location = new System.Drawing.Point(12, 9);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(143, 13);
            this.lblLadoA.TabIndex = 0;
            this.lblLadoA.Text = "Ingresa la longitud del lado A";
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Location = new System.Drawing.Point(12, 51);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(143, 13);
            this.lblLadoB.TabIndex = 1;
            this.lblLadoB.Text = "Ingresa la longitud del lado B";
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Location = new System.Drawing.Point(12, 92);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(143, 13);
            this.lblLadoC.TabIndex = 2;
            this.lblLadoC.Text = "Ingresa la longitud del lado C";
            // 
            // lblSemiperimetro
            // 
            this.lblSemiperimetro.AutoSize = true;
            this.lblSemiperimetro.Location = new System.Drawing.Point(16, 178);
            this.lblSemiperimetro.Name = "lblSemiperimetro";
            this.lblSemiperimetro.Size = new System.Drawing.Size(114, 13);
            this.lblSemiperimetro.TabIndex = 3;
            this.lblSemiperimetro.Text = "Calcular semiperímetro";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(25, 222);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(89, 13);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Área del triángulo";
            // 
            // txtLadoA
            // 
            this.txtLadoA.Location = new System.Drawing.Point(161, 6);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(67, 20);
            this.txtLadoA.TabIndex = 5;
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(161, 48);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(67, 20);
            this.txtLadoB.TabIndex = 6;
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(161, 89);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(67, 20);
            this.txtLadoC.TabIndex = 7;
            // 
            // txtSemiperimetro
            // 
            this.txtSemiperimetro.Location = new System.Drawing.Point(161, 175);
            this.txtSemiperimetro.Name = "txtSemiperimetro";
            this.txtSemiperimetro.Size = new System.Drawing.Size(67, 20);
            this.txtSemiperimetro.TabIndex = 8;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(161, 222);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(67, 20);
            this.txtArea.TabIndex = 9;
            // 
            // btnSemiperimetro
            // 
            this.btnSemiperimetro.Location = new System.Drawing.Point(19, 123);
            this.btnSemiperimetro.Name = "btnSemiperimetro";
            this.btnSemiperimetro.Size = new System.Drawing.Size(95, 33);
            this.btnSemiperimetro.TabIndex = 10;
            this.btnSemiperimetro.Text = "Semiperímetro";
            this.btnSemiperimetro.UseVisualStyleBackColor = true;
            this.btnSemiperimetro.Click += new System.EventHandler(this.btnSemiperimetro_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(136, 123);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(59, 33);
            this.btnArea.TabIndex = 11;
            this.btnArea.Text = "Área";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(217, 123);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 33);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(312, 123);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(75, 33);
            this.btnSalida.TabIndex = 13;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // Laboratorio123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 314);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnSemiperimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtSemiperimetro);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblSemiperimetro);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Name = "Laboratorio123";
            this.Text = "Laboratorio123";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.Label lblSemiperimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.TextBox txtSemiperimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnSemiperimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSalida;
    }
}