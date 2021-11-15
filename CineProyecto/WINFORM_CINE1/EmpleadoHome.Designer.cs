
namespace WINFORM_CINE1
{
    partial class EmpleadoHome
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btmContinuar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtClientes = new System.Windows.Forms.TextBox();
            this.btmRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(129, 153);
            this.txtCod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(165, 22);
            this.txtCod.TabIndex = 2;
            // 
            // btmContinuar
            // 
            this.btmContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btmContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmContinuar.FlatAppearance.BorderSize = 0;
            this.btmContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmContinuar.ForeColor = System.Drawing.Color.White;
            this.btmContinuar.Location = new System.Drawing.Point(91, 214);
            this.btmContinuar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btmContinuar.Name = "btmContinuar";
            this.btmContinuar.Size = new System.Drawing.Size(157, 37);
            this.btmContinuar.TabIndex = 11;
            this.btmContinuar.Text = "Buscar";
            this.btmContinuar.UseVisualStyleBackColor = false;
            this.btmContinuar.Click += new System.EventHandler(this.btmContinuar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(91, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtClientes
            // 
            this.txtClientes.Location = new System.Drawing.Point(336, 91);
            this.txtClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientes.Multiline = true;
            this.txtClientes.Name = "txtClientes";
            this.txtClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtClientes.Size = new System.Drawing.Size(377, 418);
            this.txtClientes.TabIndex = 13;
            // 
            // btmRegresar
            // 
            this.btmRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btmRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmRegresar.FlatAppearance.BorderSize = 0;
            this.btmRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmRegresar.ForeColor = System.Drawing.Color.White;
            this.btmRegresar.Location = new System.Drawing.Point(24, 13);
            this.btmRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btmRegresar.Name = "btmRegresar";
            this.btmRegresar.Size = new System.Drawing.Size(116, 28);
            this.btmRegresar.TabIndex = 14;
            this.btmRegresar.Text = "Regresar";
            this.btmRegresar.UseVisualStyleBackColor = false;
            this.btmRegresar.Click += new System.EventHandler(this.btmRegresar_Click);
            // 
            // EmpleadoHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 544);
            this.Controls.Add(this.btmRegresar);
            this.Controls.Add(this.txtClientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btmContinuar);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmpleadoHome";
            this.Text = "EmpleadoHome";
            this.Load += new System.EventHandler(this.EmpleadoHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btmContinuar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtClientes;
        private System.Windows.Forms.Button btmRegresar;
    }
}