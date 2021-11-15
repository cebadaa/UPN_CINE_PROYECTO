
namespace WINFORM_CINE1
{
    partial class Principal
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
            this.Lateral_M = new System.Windows.Forms.Panel();
            this.SubM = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Btm_Trab = new System.Windows.Forms.Button();
            this.Btm_Clie = new System.Windows.Forms.Button();
            this.Btm_SubM = new System.Windows.Forms.Button();
            this.PrinM = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lateral_M.SuspendLayout();
            this.SubM.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lateral_M
            // 
            this.Lateral_M.AutoScroll = true;
            this.Lateral_M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.Lateral_M.Controls.Add(this.SubM);
            this.Lateral_M.Controls.Add(this.Btm_SubM);
            this.Lateral_M.Controls.Add(this.PrinM);
            this.Lateral_M.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lateral_M.Location = new System.Drawing.Point(0, 0);
            this.Lateral_M.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lateral_M.Name = "Lateral_M";
            this.Lateral_M.Size = new System.Drawing.Size(333, 437);
            this.Lateral_M.TabIndex = 0;
            // 
            // SubM
            // 
            this.SubM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.SubM.Controls.Add(this.button1);
            this.SubM.Controls.Add(this.Btm_Trab);
            this.SubM.Controls.Add(this.Btm_Clie);
            this.SubM.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubM.Location = new System.Drawing.Point(0, 160);
            this.SubM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubM.Name = "SubM";
            this.SubM.Size = new System.Drawing.Size(333, 117);
            this.SubM.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btm_Trab
            // 
            this.Btm_Trab.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btm_Trab.FlatAppearance.BorderSize = 0;
            this.Btm_Trab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Trab.Location = new System.Drawing.Point(0, 37);
            this.Btm_Trab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btm_Trab.Name = "Btm_Trab";
            this.Btm_Trab.Size = new System.Drawing.Size(333, 37);
            this.Btm_Trab.TabIndex = 2;
            this.Btm_Trab.Text = "Empleado";
            this.Btm_Trab.UseVisualStyleBackColor = true;
            this.Btm_Trab.Click += new System.EventHandler(this.Btm_Trab_Click);
            // 
            // Btm_Clie
            // 
            this.Btm_Clie.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btm_Clie.FlatAppearance.BorderSize = 0;
            this.Btm_Clie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Clie.Location = new System.Drawing.Point(0, 0);
            this.Btm_Clie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btm_Clie.Name = "Btm_Clie";
            this.Btm_Clie.Size = new System.Drawing.Size(333, 37);
            this.Btm_Clie.TabIndex = 1;
            this.Btm_Clie.Text = "Cliente";
            this.Btm_Clie.UseVisualStyleBackColor = true;
            this.Btm_Clie.Click += new System.EventHandler(this.Btm_Clie_Click);
            // 
            // Btm_SubM
            // 
            this.Btm_SubM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btm_SubM.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btm_SubM.FlatAppearance.BorderSize = 0;
            this.Btm_SubM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_SubM.ForeColor = System.Drawing.Color.Black;
            this.Btm_SubM.Location = new System.Drawing.Point(0, 123);
            this.Btm_SubM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btm_SubM.Name = "Btm_SubM";
            this.Btm_SubM.Size = new System.Drawing.Size(333, 37);
            this.Btm_SubM.TabIndex = 0;
            this.Btm_SubM.Text = "Ingresar";
            this.Btm_SubM.UseVisualStyleBackColor = false;
            this.Btm_SubM.Click += new System.EventHandler(this.Btm_SubM_Click);
            // 
            // PrinM
            // 
            this.PrinM.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrinM.Location = new System.Drawing.Point(0, 0);
            this.PrinM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrinM.Name = "PrinM";
            this.PrinM.Size = new System.Drawing.Size(333, 123);
            this.PrinM.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(333, 350);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 87);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(333, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 350);
            this.panel2.TabIndex = 2;
            // 
            // Principal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(952, 437);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lateral_M);
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(1, 1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(967, 474);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Lateral_M.ResumeLayout(false);
            this.SubM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Lateral_M;
        private System.Windows.Forms.Panel SubM;
        private System.Windows.Forms.Button Btm_Trab;
        private System.Windows.Forms.Button Btm_Clie;
        private System.Windows.Forms.Button Btm_SubM;
        private System.Windows.Forms.Panel PrinM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

