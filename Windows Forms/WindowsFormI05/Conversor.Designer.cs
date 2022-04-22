
namespace WindowsFormI05
{
    partial class frmConversorNumerico
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
            this.lbBinADec = new System.Windows.Forms.Label();
            this.lbDecimalABinario = new System.Windows.Forms.Label();
            this.txtIngresoBinADec = new System.Windows.Forms.TextBox();
            this.txtIngresoDecABin = new System.Windows.Forms.TextBox();
            this.txtBinADec = new System.Windows.Forms.TextBox();
            this.txtDecABin = new System.Windows.Forms.TextBox();
            this.btnBinDec = new System.Windows.Forms.Button();
            this.btnDecBin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBinADec
            // 
            this.lbBinADec.AutoSize = true;
            this.lbBinADec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBinADec.Location = new System.Drawing.Point(58, 123);
            this.lbBinADec.Name = "lbBinADec";
            this.lbBinADec.Size = new System.Drawing.Size(131, 21);
            this.lbBinADec.TabIndex = 0;
            this.lbBinADec.Text = "Binario a Decimal";
            // 
            // lbDecimalABinario
            // 
            this.lbDecimalABinario.AutoSize = true;
            this.lbDecimalABinario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDecimalABinario.Location = new System.Drawing.Point(58, 239);
            this.lbDecimalABinario.Name = "lbDecimalABinario";
            this.lbDecimalABinario.Size = new System.Drawing.Size(131, 21);
            this.lbDecimalABinario.TabIndex = 1;
            this.lbDecimalABinario.Text = "Decimal a Binario";
            // 
            // txtIngresoBinADec
            // 
            this.txtIngresoBinADec.Location = new System.Drawing.Point(248, 121);
            this.txtIngresoBinADec.Name = "txtIngresoBinADec";
            this.txtIngresoBinADec.Size = new System.Drawing.Size(152, 23);
            this.txtIngresoBinADec.TabIndex = 2;
            // 
            // txtIngresoDecABin
            // 
            this.txtIngresoDecABin.Location = new System.Drawing.Point(248, 237);
            this.txtIngresoDecABin.Name = "txtIngresoDecABin";
            this.txtIngresoDecABin.Size = new System.Drawing.Size(152, 23);
            this.txtIngresoDecABin.TabIndex = 3;
            // 
            // txtBinADec
            // 
            this.txtBinADec.Location = new System.Drawing.Point(562, 123);
            this.txtBinADec.Name = "txtBinADec";
            this.txtBinADec.Size = new System.Drawing.Size(149, 23);
            this.txtBinADec.TabIndex = 4;
            // 
            // txtDecABin
            // 
            this.txtDecABin.Location = new System.Drawing.Point(562, 237);
            this.txtDecABin.Name = "txtDecABin";
            this.txtDecABin.Size = new System.Drawing.Size(149, 23);
            this.txtDecABin.TabIndex = 5;
            // 
            // btnBinDec
            // 
            this.btnBinDec.Location = new System.Drawing.Point(445, 120);
            this.btnBinDec.Name = "btnBinDec";
            this.btnBinDec.Size = new System.Drawing.Size(75, 26);
            this.btnBinDec.TabIndex = 6;
            this.btnBinDec.Text = "->";
            this.btnBinDec.UseVisualStyleBackColor = true;
            this.btnBinDec.Click += new System.EventHandler(this.btnBinDec_Click);
            // 
            // btnDecBin
            // 
            this.btnDecBin.Location = new System.Drawing.Point(445, 232);
            this.btnDecBin.Name = "btnDecBin";
            this.btnDecBin.Size = new System.Drawing.Size(75, 28);
            this.btnDecBin.TabIndex = 7;
            this.btnDecBin.Text = "->";
            this.btnDecBin.UseVisualStyleBackColor = true;
            this.btnDecBin.Click += new System.EventHandler(this.btnDecBin_Click);
            // 
            // frmConversorNumerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDecBin);
            this.Controls.Add(this.btnBinDec);
            this.Controls.Add(this.txtDecABin);
            this.Controls.Add(this.txtBinADec);
            this.Controls.Add(this.txtIngresoDecABin);
            this.Controls.Add(this.txtIngresoBinADec);
            this.Controls.Add(this.lbDecimalABinario);
            this.Controls.Add(this.lbBinADec);
            this.Name = "frmConversorNumerico";
            this.Text = "Conversor Númerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBinADec;
        private System.Windows.Forms.Label lbDecimalABinario;
        private System.Windows.Forms.TextBox txtIngresoBinADec;
        private System.Windows.Forms.TextBox txtIngresoDecABin;
        private System.Windows.Forms.TextBox txtBinADec;
        private System.Windows.Forms.TextBox txtDecABin;
        private System.Windows.Forms.Button btnBinDec;
        private System.Windows.Forms.Button btnDecBin;
    }
}

