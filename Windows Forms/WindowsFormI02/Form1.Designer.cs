
namespace WindowsFormI02
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
            this.gB_NomDireEd = new System.Windows.Forms.GroupBox();
            this.num_Edad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.gp_Genero = new System.Windows.Forms.GroupBox();
            this.rb_Masc = new System.Windows.Forms.RadioButton();
            this.rb_Fem = new System.Windows.Forms.RadioButton();
            this.rb_NoBin = new System.Windows.Forms.RadioButton();
            this.gp_Cursos = new System.Windows.Forms.GroupBox();
            this.checkBox_C = new System.Windows.Forms.CheckBox();
            this.checkBox_Cmas = new System.Windows.Forms.CheckBox();
            this.checkBox_Java = new System.Windows.Forms.CheckBox();
            this.listBox_Pais = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Ingreso = new System.Windows.Forms.Button();
            this.gB_NomDireEd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Edad)).BeginInit();
            this.gp_Genero.SuspendLayout();
            this.gp_Cursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_NomDireEd
            // 
            this.gB_NomDireEd.Controls.Add(this.num_Edad);
            this.gB_NomDireEd.Controls.Add(this.label3);
            this.gB_NomDireEd.Controls.Add(this.label2);
            this.gB_NomDireEd.Controls.Add(this.label1);
            this.gB_NomDireEd.Controls.Add(this.txt_Direccion);
            this.gB_NomDireEd.Controls.Add(this.txt_Nombre);
            this.gB_NomDireEd.Location = new System.Drawing.Point(38, 43);
            this.gB_NomDireEd.Name = "gB_NomDireEd";
            this.gB_NomDireEd.Size = new System.Drawing.Size(254, 150);
            this.gB_NomDireEd.TabIndex = 0;
            this.gB_NomDireEd.TabStop = false;
            this.gB_NomDireEd.Text = "Detalles del usuario";
            // 
            // num_Edad
            // 
            this.num_Edad.Location = new System.Drawing.Point(127, 107);
            this.num_Edad.Name = "num_Edad";
            this.num_Edad.Size = new System.Drawing.Size(100, 23);
            this.num_Edad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(127, 69);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(100, 23);
            this.txt_Direccion.TabIndex = 1;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(127, 31);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_Nombre.TabIndex = 0;
            // 
            // gp_Genero
            // 
            this.gp_Genero.Controls.Add(this.rb_NoBin);
            this.gp_Genero.Controls.Add(this.rb_Fem);
            this.gp_Genero.Controls.Add(this.rb_Masc);
            this.gp_Genero.Location = new System.Drawing.Point(516, 73);
            this.gp_Genero.Name = "gp_Genero";
            this.gp_Genero.Size = new System.Drawing.Size(200, 100);
            this.gp_Genero.TabIndex = 7;
            this.gp_Genero.TabStop = false;
            this.gp_Genero.Text = "Género";
            // 
            // rb_Masc
            // 
            this.rb_Masc.AutoSize = true;
            this.rb_Masc.Location = new System.Drawing.Point(7, 23);
            this.rb_Masc.Name = "rb_Masc";
            this.rb_Masc.Size = new System.Drawing.Size(80, 19);
            this.rb_Masc.TabIndex = 0;
            this.rb_Masc.TabStop = true;
            this.rb_Masc.Text = "Masculino";
            this.rb_Masc.UseVisualStyleBackColor = true;
            // 
            // rb_Fem
            // 
            this.rb_Fem.AutoSize = true;
            this.rb_Fem.Location = new System.Drawing.Point(7, 49);
            this.rb_Fem.Name = "rb_Fem";
            this.rb_Fem.Size = new System.Drawing.Size(78, 19);
            this.rb_Fem.TabIndex = 1;
            this.rb_Fem.TabStop = true;
            this.rb_Fem.Text = "Femenino";
            this.rb_Fem.UseVisualStyleBackColor = true;
            // 
            // rb_NoBin
            // 
            this.rb_NoBin.AutoSize = true;
            this.rb_NoBin.Location = new System.Drawing.Point(7, 75);
            this.rb_NoBin.Name = "rb_NoBin";
            this.rb_NoBin.Size = new System.Drawing.Size(81, 19);
            this.rb_NoBin.TabIndex = 2;
            this.rb_NoBin.TabStop = true;
            this.rb_NoBin.Text = "No binario";
            this.rb_NoBin.UseVisualStyleBackColor = true;
            // 
            // gp_Cursos
            // 
            this.gp_Cursos.Controls.Add(this.checkBox_Java);
            this.gp_Cursos.Controls.Add(this.checkBox_Cmas);
            this.gp_Cursos.Controls.Add(this.checkBox_C);
            this.gp_Cursos.Location = new System.Drawing.Point(516, 213);
            this.gp_Cursos.Name = "gp_Cursos";
            this.gp_Cursos.Size = new System.Drawing.Size(200, 100);
            this.gp_Cursos.TabIndex = 8;
            this.gp_Cursos.TabStop = false;
            this.gp_Cursos.Text = "Cursos";
            // 
            // checkBox_C
            // 
            this.checkBox_C.AutoSize = true;
            this.checkBox_C.Location = new System.Drawing.Point(7, 23);
            this.checkBox_C.Name = "checkBox_C";
            this.checkBox_C.Size = new System.Drawing.Size(41, 19);
            this.checkBox_C.TabIndex = 0;
            this.checkBox_C.Text = "C#";
            this.checkBox_C.UseVisualStyleBackColor = true;
            // 
            // checkBox_Cmas
            // 
            this.checkBox_Cmas.AutoSize = true;
            this.checkBox_Cmas.Location = new System.Drawing.Point(7, 49);
            this.checkBox_Cmas.Name = "checkBox_Cmas";
            this.checkBox_Cmas.Size = new System.Drawing.Size(50, 19);
            this.checkBox_Cmas.TabIndex = 1;
            this.checkBox_Cmas.Text = "C++";
            this.checkBox_Cmas.UseVisualStyleBackColor = true;
            // 
            // checkBox_Java
            // 
            this.checkBox_Java.AutoSize = true;
            this.checkBox_Java.Location = new System.Drawing.Point(7, 74);
            this.checkBox_Java.Name = "checkBox_Java";
            this.checkBox_Java.Size = new System.Drawing.Size(78, 19);
            this.checkBox_Java.TabIndex = 2;
            this.checkBox_Java.Text = "JavaScript";
            this.checkBox_Java.UseVisualStyleBackColor = true;
            // 
            // listBox_Pais
            // 
            this.listBox_Pais.FormattingEnabled = true;
            this.listBox_Pais.ItemHeight = 15;
            this.listBox_Pais.Location = new System.Drawing.Point(38, 236);
            this.listBox_Pais.Name = "listBox_Pais";
            this.listBox_Pais.Size = new System.Drawing.Size(120, 94);
            this.listBox_Pais.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "País";
            // 
            // button_Ingreso
            // 
            this.button_Ingreso.Location = new System.Drawing.Point(528, 389);
            this.button_Ingreso.Name = "button_Ingreso";
            this.button_Ingreso.Size = new System.Drawing.Size(75, 23);
            this.button_Ingreso.TabIndex = 11;
            this.button_Ingreso.Text = "Ingresar";
            this.button_Ingreso.UseVisualStyleBackColor = true;
            this.button_Ingreso.Click += new System.EventHandler(this.button_Ingreso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Ingreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_Pais);
            this.Controls.Add(this.gp_Cursos);
            this.Controls.Add(this.gp_Genero);
            this.Controls.Add(this.gB_NomDireEd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gB_NomDireEd.ResumeLayout(false);
            this.gB_NomDireEd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Edad)).EndInit();
            this.gp_Genero.ResumeLayout(false);
            this.gp_Genero.PerformLayout();
            this.gp_Cursos.ResumeLayout(false);
            this.gp_Cursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_NomDireEd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.NumericUpDown num_Edad;
        private System.Windows.Forms.GroupBox gp_Genero;
        private System.Windows.Forms.RadioButton rb_NoBin;
        private System.Windows.Forms.RadioButton rb_Fem;
        private System.Windows.Forms.RadioButton rb_Masc;
        private System.Windows.Forms.GroupBox gp_Cursos;
        private System.Windows.Forms.CheckBox checkBox_Java;
        private System.Windows.Forms.CheckBox checkBox_Cmas;
        private System.Windows.Forms.CheckBox checkBox_C;
        private System.Windows.Forms.ListBox listBox_Pais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Ingreso;
    }
}

