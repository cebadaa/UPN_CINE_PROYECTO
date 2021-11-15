
namespace WINFORM_CINE1
{
    partial class conexion_del_empleado
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
            this.txtVerCod = new System.Windows.Forms.Button();
            this.txtverRuta = new System.Windows.Forms.Button();
            this.btmRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVerCod
            // 
            this.txtVerCod.Location = new System.Drawing.Point(112, 79);
            this.txtVerCod.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerCod.Name = "txtVerCod";
            this.txtVerCod.Size = new System.Drawing.Size(220, 46);
            this.txtVerCod.TabIndex = 0;
            this.txtVerCod.Text = "ver código de clientes";
            this.txtVerCod.UseVisualStyleBackColor = true;
            this.txtVerCod.Click += new System.EventHandler(this.txtVerCod_Click);
            // 
            // txtverRuta
            // 
            this.txtverRuta.Location = new System.Drawing.Point(112, 188);
            this.txtverRuta.Margin = new System.Windows.Forms.Padding(4);
            this.txtverRuta.Name = "txtverRuta";
            this.txtverRuta.Size = new System.Drawing.Size(215, 52);
            this.txtverRuta.TabIndex = 1;
            this.txtverRuta.Text = "Ruta de asiento";
            this.txtverRuta.UseVisualStyleBackColor = true;
            this.txtverRuta.Click += new System.EventHandler(this.txtverRuta_Click);
            // 
            // btmRegresar
            // 
            this.btmRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btmRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmRegresar.FlatAppearance.BorderSize = 0;
            this.btmRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmRegresar.ForeColor = System.Drawing.Color.White;
            this.btmRegresar.Location = new System.Drawing.Point(24, 24);
            this.btmRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btmRegresar.Name = "btmRegresar";
            this.btmRegresar.Size = new System.Drawing.Size(116, 28);
            this.btmRegresar.TabIndex = 15;
            this.btmRegresar.Text = "Regresar";
            this.btmRegresar.UseVisualStyleBackColor = false;
            this.btmRegresar.Click += new System.EventHandler(this.btmRegresar_Click);
            // 
            // conexion_del_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 306);
            this.Controls.Add(this.btmRegresar);
            this.Controls.Add(this.txtverRuta);
            this.Controls.Add(this.txtVerCod);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "conexion_del_empleado";
            this.Text = "conexion_del_empleado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtVerCod;
        private System.Windows.Forms.Button txtverRuta;
        private System.Windows.Forms.Button btmRegresar;
    }
}