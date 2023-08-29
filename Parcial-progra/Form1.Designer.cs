
namespace Parcial_progra
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
            this.lblTipoConver = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.cboTipoConver = new System.Windows.Forms.ComboBox();
            this.cboDeConver = new System.Windows.Forms.ComboBox();
            this.lblDeConver = new System.Windows.Forms.Label();
            this.cboAConver = new System.Windows.Forms.ComboBox();
            this.lblAConver = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTipoConver
            // 
            this.lblTipoConver.AutoSize = true;
            this.lblTipoConver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConver.Location = new System.Drawing.Point(263, 33);
            this.lblTipoConver.Name = "lblTipoConver";
            this.lblTipoConver.Size = new System.Drawing.Size(42, 18);
            this.lblTipoConver.TabIndex = 0;
            this.lblTipoConver.Text = "Tipo:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(315, 296);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 1;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // cboTipoConver
            // 
            this.cboTipoConver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConver.FormattingEnabled = true;
            this.cboTipoConver.Items.AddRange(new object[] {
            "Area"});
            this.cboTipoConver.Location = new System.Drawing.Point(315, 33);
            this.cboTipoConver.Name = "cboTipoConver";
            this.cboTipoConver.Size = new System.Drawing.Size(121, 21);
            this.cboTipoConver.TabIndex = 2;
            // 
            // cboDeConver
            // 
            this.cboDeConver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConver.FormattingEnabled = true;
            this.cboDeConver.Items.AddRange(new object[] {
            "Pie Cuadrado.",
            "Vara Cuadrada.",
            "Yarda Cuadrada.",
            "Metro Cuadrado.",
            "Tareas.",
            "Manzana.",
            "Hectarea."});
            this.cboDeConver.Location = new System.Drawing.Point(315, 75);
            this.cboDeConver.Name = "cboDeConver";
            this.cboDeConver.Size = new System.Drawing.Size(121, 21);
            this.cboDeConver.TabIndex = 4;
            // 
            // lblDeConver
            // 
            this.lblDeConver.AutoSize = true;
            this.lblDeConver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeConver.Location = new System.Drawing.Point(263, 75);
            this.lblDeConver.Name = "lblDeConver";
            this.lblDeConver.Size = new System.Drawing.Size(33, 18);
            this.lblDeConver.TabIndex = 3;
            this.lblDeConver.Text = "De:";
            // 
            // cboAConver
            // 
            this.cboAConver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConver.FormattingEnabled = true;
            this.cboAConver.Items.AddRange(new object[] {
            "Pie Cuadrado.",
            "Vara Cuadrada.",
            "Yarda Cuadrada.",
            "Metro Cuadrado.",
            "Tareas.",
            "Manzana.",
            "Hectarea."});
            this.cboAConver.Location = new System.Drawing.Point(315, 121);
            this.cboAConver.Name = "cboAConver";
            this.cboAConver.Size = new System.Drawing.Size(121, 21);
            this.cboAConver.TabIndex = 6;
            // 
            // lblAConver
            // 
            this.lblAConver.AutoSize = true;
            this.lblAConver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConver.Location = new System.Drawing.Point(263, 121);
            this.lblAConver.Name = "lblAConver";
            this.lblAConver.Size = new System.Drawing.Size(23, 18);
            this.lblAConver.TabIndex = 5;
            this.lblAConver.Text = "A:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(254, 165);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(76, 18);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(245, 218);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(100, 18);
            this.lblRespuesta.TabIndex = 8;
            this.lblRespuesta.Text = "Respuesta: ?";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(336, 165);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cboAConver);
            this.Controls.Add(this.lblAConver);
            this.Controls.Add(this.cboDeConver);
            this.Controls.Add(this.lblDeConver);
            this.Controls.Add(this.cboTipoConver);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblTipoConver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoConver;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox cboTipoConver;
        private System.Windows.Forms.ComboBox cboDeConver;
        private System.Windows.Forms.Label lblDeConver;
        private System.Windows.Forms.ComboBox cboAConver;
        private System.Windows.Forms.Label lblAConver;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}

