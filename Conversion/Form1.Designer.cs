namespace Conversion
{
    partial class frmConversiones
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
            this.lblINTRO = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.cmdSalida = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblINTRO
            // 
            this.lblINTRO.AutoSize = true;
            this.lblINTRO.Location = new System.Drawing.Point(60, 30);
            this.lblINTRO.Name = "lblINTRO";
            this.lblINTRO.Size = new System.Drawing.Size(147, 13);
            this.lblINTRO.TabIndex = 0;
            this.lblINTRO.Text = "&introduce el total de centavos";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(60, 81);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(14, 13);
            this.lblC.TabIndex = 1;
            this.lblC.Text = "C";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(60, 124);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(14, 13);
            this.lblP.TabIndex = 2;
            this.lblP.Text = "P";
            // 
            // txtCaja
            // 
            this.txtCaja.Location = new System.Drawing.Point(256, 30);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(100, 20);
            this.txtCaja.TabIndex = 3;
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(474, 20);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(75, 23);
            this.cmdCalcular.TabIndex = 4;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // cmdSalida
            // 
            this.cmdSalida.Location = new System.Drawing.Point(474, 71);
            this.cmdSalida.Name = "cmdSalida";
            this.cmdSalida.Size = new System.Drawing.Size(75, 23);
            this.cmdSalida.TabIndex = 5;
            this.cmdSalida.Text = "Salida";
            this.cmdSalida.UseVisualStyleBackColor = true;
            this.cmdSalida.Click += new System.EventHandler(this.cmdSalida_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(474, 119);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpiar.TabIndex = 6;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // frmConversiones
            // 
            this.AcceptButton = this.cmdCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdSalida;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdSalida);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.txtCaja);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblINTRO);
            this.Name = "frmConversiones";
            this.Text = "Conversiones";
            this.Load += new System.EventHandler(this.frmConversiones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblINTRO;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.Button cmdSalida;
        private System.Windows.Forms.Button cmdLimpiar;
    }
}

