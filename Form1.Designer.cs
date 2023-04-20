namespace pryLuna_Practica
{
    partial class frmPrincipal
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
            this.txtTextoB = new System.Windows.Forms.TextBox();
            this.txtTextoA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnComparar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.mrcResultado = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mrcResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTextoB
            // 
            this.txtTextoB.Location = new System.Drawing.Point(60, 55);
            this.txtTextoB.Name = "txtTextoB";
            this.txtTextoB.Size = new System.Drawing.Size(100, 20);
            this.txtTextoB.TabIndex = 0;
            this.txtTextoB.TextChanged += new System.EventHandler(this.txtTextoB_TextChanged);
            // 
            // txtTextoA
            // 
            this.txtTextoA.Location = new System.Drawing.Point(60, 17);
            this.txtTextoA.Name = "txtTextoA";
            this.txtTextoA.Size = new System.Drawing.Size(100, 20);
            this.txtTextoA.TabIndex = 1;
            this.txtTextoA.TextChanged += new System.EventHandler(this.txtTextoA_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(85, 135);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 23);
            this.btnComparar.TabIndex = 5;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(60, 94);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 5;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(85, 175);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // mrcResultado
            // 
            this.mrcResultado.Controls.Add(this.label4);
            this.mrcResultado.Location = new System.Drawing.Point(60, 223);
            this.mrcResultado.Name = "mrcResultado";
            this.mrcResultado.Size = new System.Drawing.Size(109, 55);
            this.mrcResultado.TabIndex = 7;
            this.mrcResultado.TabStop = false;
            this.mrcResultado.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 294);
            this.Controls.Add(this.mrcResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtTextoA);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTextoB);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.mrcResultado.ResumeLayout(false);
            this.mrcResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoB;
        private System.Windows.Forms.TextBox txtTextoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.GroupBox mrcResultado;
        private System.Windows.Forms.Label label4;
    }
}

