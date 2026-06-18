namespace FormU4
{
    partial class Form1
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
            this.groupBoxCaja = new System.Windows.Forms.GroupBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lstTicket = new System.Windows.Forms.ListBox();
            this.groupBoxCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCaja
            // 
            this.groupBoxCaja.Controls.Add(this.lstTicket);
            this.groupBoxCaja.Controls.Add(this.txtArticulo);
            this.groupBoxCaja.Controls.Add(this.lblPrecioBase);
            this.groupBoxCaja.Controls.Add(this.btnCobrar);
            this.groupBoxCaja.Controls.Add(this.lblProducto);
            this.groupBoxCaja.Controls.Add(this.txtPrecioBase);
            this.groupBoxCaja.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCaja.Name = "groupBoxCaja";
            this.groupBoxCaja.Size = new System.Drawing.Size(776, 426);
            this.groupBoxCaja.TabIndex = 0;
            this.groupBoxCaja.TabStop = false;
            this.groupBoxCaja.Text = "Sistema de cobro - Punto de venta";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(37, 154);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(145, 20);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Artículo a comprar: ";
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(199, 154);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(180, 20);
            this.lblPrecioBase.TabIndex = 2;
            this.lblPrecioBase.Text = "Precio base del artículo: ";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(41, 200);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(128, 26);
            this.txtArticulo.TabIndex = 3;
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(222, 200);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(128, 26);
            this.txtPrecioBase.TabIndex = 4;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(114, 286);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(160, 48);
            this.btnCobrar.TabIndex = 5;
            this.btnCobrar.Text = "Cobrar en caja";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lstTicket
            // 
            this.lstTicket.FormattingEnabled = true;
            this.lstTicket.ItemHeight = 20;
            this.lstTicket.Location = new System.Drawing.Point(403, 25);
            this.lstTicket.Name = "lstTicket";
            this.lstTicket.Size = new System.Drawing.Size(337, 384);
            this.lstTicket.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxCaja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCaja.ResumeLayout(false);
            this.groupBoxCaja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCaja;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.ListBox lstTicket;
    }
}

