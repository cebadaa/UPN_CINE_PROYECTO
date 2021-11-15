
namespace WINFORM_CINE1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMostrarMatriz = new System.Windows.Forms.Button();
            this.txtAdyen = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNodoPri = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.txtIni = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnMostrarRutas = new System.Windows.Forms.Button();
            this.btnMostrarRuta = new System.Windows.Forms.Button();
            this.txtRutaCorta = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtDistancia = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ubicaciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Final ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distancia";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 24);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 251);
            this.listBox1.TabIndex = 5;
            // 
            // btnMostrarMatriz
            // 
            this.btnMostrarMatriz.Location = new System.Drawing.Point(296, 9);
            this.btnMostrarMatriz.Name = "btnMostrarMatriz";
            this.btnMostrarMatriz.Size = new System.Drawing.Size(233, 21);
            this.btnMostrarMatriz.TabIndex = 6;
            this.btnMostrarMatriz.Text = "Mostrar ";
            this.btnMostrarMatriz.UseVisualStyleBackColor = true;
            this.btnMostrarMatriz.Click += new System.EventHandler(this.btnMostrarMatriz_Click);
            // 
            // txtAdyen
            // 
            this.txtAdyen.Location = new System.Drawing.Point(223, 35);
            this.txtAdyen.Name = "txtAdyen";
            this.txtAdyen.Size = new System.Drawing.Size(374, 288);
            this.txtAdyen.TabIndex = 7;
            this.txtAdyen.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ruta corta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(637, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Inicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Final";
            // 
            // txtNodoPri
            // 
            this.txtNodoPri.Location = new System.Drawing.Point(73, 54);
            this.txtNodoPri.Name = "txtNodoPri";
            this.txtNodoPri.Size = new System.Drawing.Size(130, 20);
            this.txtNodoPri.TabIndex = 11;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(73, 89);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(130, 20);
            this.txtFin.TabIndex = 12;
            // 
            // txtDist
            // 
            this.txtDist.Location = new System.Drawing.Point(78, 118);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(135, 20);
            this.txtDist.TabIndex = 13;
            // 
            // txtIni
            // 
            this.txtIni.Location = new System.Drawing.Point(679, 44);
            this.txtIni.Name = "txtIni";
            this.txtIni.Size = new System.Drawing.Size(105, 20);
            this.txtIni.TabIndex = 14;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(675, 75);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(108, 20);
            this.txtFinal.TabIndex = 15;
            // 
            // btnMostrarRutas
            // 
            this.btnMostrarRutas.Location = new System.Drawing.Point(633, 117);
            this.btnMostrarRutas.Name = "btnMostrarRutas";
            this.btnMostrarRutas.Size = new System.Drawing.Size(129, 21);
            this.btnMostrarRutas.TabIndex = 16;
            this.btnMostrarRutas.Text = "Ver posibles ruta";
            this.btnMostrarRutas.UseVisualStyleBackColor = true;
            this.btnMostrarRutas.Click += new System.EventHandler(this.btnMostrarRutas_Click);
            // 
            // btnMostrarRuta
            // 
            this.btnMostrarRuta.Location = new System.Drawing.Point(251, 333);
            this.btnMostrarRuta.Name = "btnMostrarRuta";
            this.btnMostrarRuta.Size = new System.Drawing.Size(258, 27);
            this.btnMostrarRuta.TabIndex = 18;
            this.btnMostrarRuta.Text = "Mostrar ruta";
            this.btnMostrarRuta.UseVisualStyleBackColor = true;
            this.btnMostrarRuta.Click += new System.EventHandler(this.btnMostrarRuta_Click);
            // 
            // txtRutaCorta
            // 
            this.txtRutaCorta.Location = new System.Drawing.Point(245, 375);
            this.txtRutaCorta.Name = "txtRutaCorta";
            this.txtRutaCorta.Size = new System.Drawing.Size(325, 20);
            this.txtRutaCorta.TabIndex = 19;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(634, 411);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(128, 27);
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(613, 155);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(175, 240);
            this.txtDistancia.TabIndex = 21;
            this.txtDistancia.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtRutaCorta);
            this.Controls.Add(this.btnMostrarRuta);
            this.Controls.Add(this.btnMostrarRutas);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtIni);
            this.Controls.Add(this.txtDist);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.txtNodoPri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdyen);
            this.Controls.Add(this.btnMostrarMatriz);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMostrarMatriz;
        private System.Windows.Forms.RichTextBox txtAdyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNodoPri;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.TextBox txtIni;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnMostrarRutas;
        private System.Windows.Forms.Button btnMostrarRuta;
        private System.Windows.Forms.TextBox txtRutaCorta;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.RichTextBox txtDistancia;
    }
}