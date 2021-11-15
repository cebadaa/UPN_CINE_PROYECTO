
namespace WINFORM_CINE1
{
    partial class Boleta
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
            this.txtBoleta = new System.Windows.Forms.TextBox();
            this.btmContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoleta
            // 
            this.txtBoleta.Location = new System.Drawing.Point(13, 13);
            this.txtBoleta.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoleta.Multiline = true;
            this.txtBoleta.Name = "txtBoleta";
            this.txtBoleta.Size = new System.Drawing.Size(519, 382);
            this.txtBoleta.TabIndex = 1;
            // 
            // btmContinuar
            // 
            this.btmContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btmContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmContinuar.FlatAppearance.BorderSize = 0;
            this.btmContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmContinuar.ForeColor = System.Drawing.Color.White;
            this.btmContinuar.Location = new System.Drawing.Point(375, 400);
            this.btmContinuar.Margin = new System.Windows.Forms.Padding(4);
            this.btmContinuar.Name = "btmContinuar";
            this.btmContinuar.Size = new System.Drawing.Size(157, 37);
            this.btmContinuar.TabIndex = 11;
            this.btmContinuar.Text = "Finalizar";
            this.btmContinuar.UseVisualStyleBackColor = false;
            this.btmContinuar.Click += new System.EventHandler(this.btmContinuar_Click);
            // 
            // Boleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.btmContinuar);
            this.Controls.Add(this.txtBoleta);
            this.Name = "Boleta";
            this.Text = "Boleta";
            this.Load += new System.EventHandler(this.Boleta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoleta;
        private System.Windows.Forms.Button btmContinuar;
    }
}