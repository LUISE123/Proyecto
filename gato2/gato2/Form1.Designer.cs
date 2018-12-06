namespace gato2
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
            this.jugar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtguardar = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtjugador2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jugar
            // 
            this.jugar.Location = new System.Drawing.Point(121, 141);
            this.jugar.Name = "jugar";
            this.jugar.Size = new System.Drawing.Size(75, 23);
            this.jugar.TabIndex = 0;
            this.jugar.Text = "Jugar";
            this.jugar.UseVisualStyleBackColor = true;
            this.jugar.Click += new System.EventHandler(this.jugar_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(24, 141);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 1;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jugador 1";
            // 
            // txtguardar
            // 
            this.txtguardar.Location = new System.Drawing.Point(148, 66);
            this.txtguardar.Name = "txtguardar";
            this.txtguardar.Size = new System.Drawing.Size(100, 20);
            this.txtguardar.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(148, 40);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtjugador2
            // 
            this.txtjugador2.Location = new System.Drawing.Point(148, 92);
            this.txtjugador2.Name = "txtjugador2";
            this.txtjugador2.Size = new System.Drawing.Size(100, 20);
            this.txtjugador2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jugador 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 200);
            this.Controls.Add(this.txtjugador2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtguardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.jugar);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jugar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtguardar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtjugador2;
        private System.Windows.Forms.Label label4;
    }
}

