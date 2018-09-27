namespace FrmMenu
{
    partial class Central_Telefonica
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
            this.Btn_Generar_Llamada = new System.Windows.Forms.Button();
            this.Btn_Facturacion_Total = new System.Windows.Forms.Button();
            this.Btn_Facturacion_Local = new System.Windows.Forms.Button();
            this.Btn_Facturacion_Provincial = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Generar_Llamada
            // 
            this.Btn_Generar_Llamada.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Generar_Llamada.Location = new System.Drawing.Point(22, 18);
            this.Btn_Generar_Llamada.Name = "Btn_Generar_Llamada";
            this.Btn_Generar_Llamada.Size = new System.Drawing.Size(217, 44);
            this.Btn_Generar_Llamada.TabIndex = 0;
            this.Btn_Generar_Llamada.Text = "Generar Llamada";
            this.Btn_Generar_Llamada.UseVisualStyleBackColor = false;
            this.Btn_Generar_Llamada.Click += new System.EventHandler(this.Btn_Generar_Llamada_Click);
            // 
            // Btn_Facturacion_Total
            // 
            this.Btn_Facturacion_Total.Location = new System.Drawing.Point(22, 78);
            this.Btn_Facturacion_Total.Name = "Btn_Facturacion_Total";
            this.Btn_Facturacion_Total.Size = new System.Drawing.Size(217, 44);
            this.Btn_Facturacion_Total.TabIndex = 1;
            this.Btn_Facturacion_Total.Text = "Facturacion Total";
            this.Btn_Facturacion_Total.UseVisualStyleBackColor = true;
            this.Btn_Facturacion_Total.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Facturacion_Local
            // 
            this.Btn_Facturacion_Local.Location = new System.Drawing.Point(22, 138);
            this.Btn_Facturacion_Local.Name = "Btn_Facturacion_Local";
            this.Btn_Facturacion_Local.Size = new System.Drawing.Size(217, 44);
            this.Btn_Facturacion_Local.TabIndex = 2;
            this.Btn_Facturacion_Local.Text = "Facturacion Local";
            this.Btn_Facturacion_Local.UseVisualStyleBackColor = true;
            // 
            // Btn_Facturacion_Provincial
            // 
            this.Btn_Facturacion_Provincial.Location = new System.Drawing.Point(22, 198);
            this.Btn_Facturacion_Provincial.Name = "Btn_Facturacion_Provincial";
            this.Btn_Facturacion_Provincial.Size = new System.Drawing.Size(217, 44);
            this.Btn_Facturacion_Provincial.TabIndex = 3;
            this.Btn_Facturacion_Provincial.Text = "Facturacion Provincial";
            this.Btn_Facturacion_Provincial.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(22, 258);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(217, 44);
            this.Btn_Salir.TabIndex = 4;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Central_Telefonica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 321);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Facturacion_Provincial);
            this.Controls.Add(this.Btn_Facturacion_Local);
            this.Controls.Add(this.Btn_Facturacion_Total);
            this.Controls.Add(this.Btn_Generar_Llamada);
            this.Name = "Central_Telefonica";
            this.Text = "Central Telefonica";
            this.Load += new System.EventHandler(this.Central_Telefonica_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Generar_Llamada;
        private System.Windows.Forms.Button Btn_Facturacion_Total;
        private System.Windows.Forms.Button Btn_Facturacion_Local;
        private System.Windows.Forms.Button Btn_Facturacion_Provincial;
        private System.Windows.Forms.Button Btn_Salir;
    }
}

