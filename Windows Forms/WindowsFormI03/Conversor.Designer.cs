
namespace WindowsFormI03
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
            this.lbCotizacion = new System.Windows.Forms.Label();
            this.txtCotEuro = new System.Windows.Forms.TextBox();
            this.txtCotDolar = new System.Windows.Forms.TextBox();
            this.txtCotPeso = new System.Windows.Forms.TextBox();
            this.lbEuro = new System.Windows.Forms.Label();
            this.lbDolar = new System.Windows.Forms.Label();
            this.lbPeso = new System.Windows.Forms.Label();
            this.lbEuro2 = new System.Windows.Forms.Label();
            this.lbDolar2 = new System.Windows.Forms.Label();
            this.lbPeso2 = new System.Windows.Forms.Label();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.btnEuro = new System.Windows.Forms.Button();
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnPeso = new System.Windows.Forms.Button();
            this.txtIngresoEuro = new System.Windows.Forms.TextBox();
            this.txtIngresoDolar = new System.Windows.Forms.TextBox();
            this.txtIngresoPeso = new System.Windows.Forms.TextBox();
            this.btLock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCotizacion
            // 
            this.lbCotizacion.AutoSize = true;
            this.lbCotizacion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCotizacion.Location = new System.Drawing.Point(85, 38);
            this.lbCotizacion.Name = "lbCotizacion";
            this.lbCotizacion.Size = new System.Drawing.Size(105, 25);
            this.lbCotizacion.TabIndex = 0;
            this.lbCotizacion.Text = "Cotizacion";
            // 
            // txtCotEuro
            // 
            this.txtCotEuro.Location = new System.Drawing.Point(325, 38);
            this.txtCotEuro.Name = "txtCotEuro";
            this.txtCotEuro.Size = new System.Drawing.Size(114, 23);
            this.txtCotEuro.TabIndex = 1;
            // 
            // txtCotDolar
            // 
            this.txtCotDolar.Location = new System.Drawing.Point(476, 38);
            this.txtCotDolar.Name = "txtCotDolar";
            this.txtCotDolar.Size = new System.Drawing.Size(108, 23);
            this.txtCotDolar.TabIndex = 2;
            this.txtCotDolar.Leave += new System.EventHandler(this.txtCotDolar_Leave);
            // 
            // txtCotPeso
            // 
            this.txtCotPeso.Location = new System.Drawing.Point(634, 38);
            this.txtCotPeso.Name = "txtCotPeso";
            this.txtCotPeso.Size = new System.Drawing.Size(112, 23);
            this.txtCotPeso.TabIndex = 3;
            // 
            // lbEuro
            // 
            this.lbEuro.AutoSize = true;
            this.lbEuro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEuro.Location = new System.Drawing.Point(29, 203);
            this.lbEuro.Name = "lbEuro";
            this.lbEuro.Size = new System.Drawing.Size(54, 25);
            this.lbEuro.TabIndex = 4;
            this.lbEuro.Text = "Euro";
            // 
            // lbDolar
            // 
            this.lbDolar.AutoSize = true;
            this.lbDolar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDolar.Location = new System.Drawing.Point(29, 295);
            this.lbDolar.Name = "lbDolar";
            this.lbDolar.Size = new System.Drawing.Size(61, 25);
            this.lbDolar.TabIndex = 5;
            this.lbDolar.Text = "Dólar";
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPeso.Location = new System.Drawing.Point(30, 373);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(53, 25);
            this.lbPeso.TabIndex = 6;
            this.lbPeso.Text = "Peso";
            // 
            // lbEuro2
            // 
            this.lbEuro2.AutoSize = true;
            this.lbEuro2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEuro2.Location = new System.Drawing.Point(316, 142);
            this.lbEuro2.Name = "lbEuro2";
            this.lbEuro2.Size = new System.Drawing.Size(54, 25);
            this.lbEuro2.TabIndex = 7;
            this.lbEuro2.Text = "Euro";
            // 
            // lbDolar2
            // 
            this.lbDolar2.AutoSize = true;
            this.lbDolar2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDolar2.Location = new System.Drawing.Point(497, 142);
            this.lbDolar2.Name = "lbDolar2";
            this.lbDolar2.Size = new System.Drawing.Size(61, 25);
            this.lbDolar2.TabIndex = 8;
            this.lbDolar2.Text = "Dolár";
            // 
            // lbPeso2
            // 
            this.lbPeso2.AutoSize = true;
            this.lbPeso2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPeso2.Location = new System.Drawing.Point(652, 142);
            this.lbPeso2.Name = "lbPeso2";
            this.lbPeso2.Size = new System.Drawing.Size(53, 25);
            this.lbPeso2.TabIndex = 9;
            this.lbPeso2.Text = "Peso";
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(325, 208);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(114, 23);
            this.txtEuroAEuro.TabIndex = 10;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(476, 208);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(108, 23);
            this.txtEuroADolar.TabIndex = 11;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(325, 295);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(114, 23);
            this.txtDolarAEuro.TabIndex = 13;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Location = new System.Drawing.Point(476, 375);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(108, 23);
            this.txtPesoADolar.TabIndex = 14;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Location = new System.Drawing.Point(634, 208);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(112, 23);
            this.txtEuroAPeso.TabIndex = 15;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Location = new System.Drawing.Point(325, 375);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(114, 23);
            this.txtPesoAEuro.TabIndex = 16;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(476, 295);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(108, 23);
            this.txtDolarADolar.TabIndex = 17;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Location = new System.Drawing.Point(634, 295);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(112, 23);
            this.txtDolarAPeso.TabIndex = 18;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Location = new System.Drawing.Point(634, 375);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(112, 23);
            this.txtPesoAPeso.TabIndex = 19;
            // 
            // btnEuro
            // 
            this.btnEuro.Location = new System.Drawing.Point(203, 203);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(75, 23);
            this.btnEuro.TabIndex = 20;
            this.btnEuro.Text = "->";
            this.btnEuro.UseVisualStyleBackColor = true;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // btnDolar
            // 
            this.btnDolar.Location = new System.Drawing.Point(203, 295);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(75, 23);
            this.btnDolar.TabIndex = 21;
            this.btnDolar.Text = "->";
            this.btnDolar.UseVisualStyleBackColor = true;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnPeso
            // 
            this.btnPeso.Location = new System.Drawing.Point(203, 375);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(75, 23);
            this.btnPeso.TabIndex = 22;
            this.btnPeso.Text = "->";
            this.btnPeso.UseVisualStyleBackColor = true;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // txtIngresoEuro
            // 
            this.txtIngresoEuro.Location = new System.Drawing.Point(97, 203);
            this.txtIngresoEuro.Name = "txtIngresoEuro";
            this.txtIngresoEuro.Size = new System.Drawing.Size(100, 23);
            this.txtIngresoEuro.TabIndex = 23;
            // 
            // txtIngresoDolar
            // 
            this.txtIngresoDolar.Location = new System.Drawing.Point(97, 296);
            this.txtIngresoDolar.Name = "txtIngresoDolar";
            this.txtIngresoDolar.Size = new System.Drawing.Size(100, 23);
            this.txtIngresoDolar.TabIndex = 24;
            // 
            // txtIngresoPeso
            // 
            this.txtIngresoPeso.Location = new System.Drawing.Point(97, 373);
            this.txtIngresoPeso.Name = "txtIngresoPeso";
            this.txtIngresoPeso.Size = new System.Drawing.Size(100, 23);
            this.txtIngresoPeso.TabIndex = 25;
            // 
            // btLock
            // 
            this.btLock.Location = new System.Drawing.Point(216, 37);
            this.btLock.Name = "btLock";
            this.btLock.Size = new System.Drawing.Size(75, 23);
            this.btLock.TabIndex = 26;
            this.btLock.Text = "Lock";
            this.btLock.UseVisualStyleBackColor = true;
            this.btLock.Click += new System.EventHandler(this.btLock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLock);
            this.Controls.Add(this.txtIngresoPeso);
            this.Controls.Add(this.txtIngresoDolar);
            this.Controls.Add(this.txtIngresoEuro);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.lbPeso2);
            this.Controls.Add(this.lbDolar2);
            this.Controls.Add(this.lbEuro2);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this.lbDolar);
            this.Controls.Add(this.lbEuro);
            this.Controls.Add(this.txtCotPeso);
            this.Controls.Add(this.txtCotDolar);
            this.Controls.Add(this.txtCotEuro);
            this.Controls.Add(this.lbCotizacion);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCotizacion;
        private System.Windows.Forms.TextBox txtCotEuro;
        private System.Windows.Forms.TextBox txtCotDolar;
        private System.Windows.Forms.TextBox txtCotPeso;
        private System.Windows.Forms.Label lbEuro;
        private System.Windows.Forms.Label lbDolar;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lbEuro2;
        private System.Windows.Forms.Label lbDolar2;
        private System.Windows.Forms.Label lbPeso2;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtPesoADolar;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtPesoAEuro;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAPeso;
        private System.Windows.Forms.TextBox txtPesoAPeso;
        private System.Windows.Forms.Button btnEuro;
        private System.Windows.Forms.Button btnDolar;
        private System.Windows.Forms.Button btnPeso;
        private System.Windows.Forms.TextBox txtIngresoEuro;
        private System.Windows.Forms.TextBox txtIngresoDolar;
        private System.Windows.Forms.TextBox txtIngresoPeso;
        private System.Windows.Forms.Button btLock;
    }
}

