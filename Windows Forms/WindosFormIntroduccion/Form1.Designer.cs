
namespace WindosFormIntroduccion
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
            this.txtBox_IngresoPass = new System.Windows.Forms.TextBox();
            this.txtBox_IngresoDatos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_IngresoPass
            // 
            this.txtBox_IngresoPass.Location = new System.Drawing.Point(283, 144);
            this.txtBox_IngresoPass.Name = "txtBox_IngresoPass";
            this.txtBox_IngresoPass.PasswordChar = '*';
            this.txtBox_IngresoPass.PlaceholderText = "Password";
            this.txtBox_IngresoPass.Size = new System.Drawing.Size(184, 23);
            this.txtBox_IngresoPass.TabIndex = 0;
            // 
            // txtBox_IngresoDatos
            // 
            this.txtBox_IngresoDatos.Location = new System.Drawing.Point(283, 92);
            this.txtBox_IngresoDatos.Name = "txtBox_IngresoDatos";
            this.txtBox_IngresoDatos.PlaceholderText = "User";
            this.txtBox_IngresoDatos.Size = new System.Drawing.Size(184, 23);
            this.txtBox_IngresoDatos.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(313, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_IngresoDatos);
            this.Controls.Add(this.txtBox_IngresoPass);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_IngresoPass;
        private System.Windows.Forms.TextBox txtBox_IngresoDatos;
        private System.Windows.Forms.Button button1;
    }
}

