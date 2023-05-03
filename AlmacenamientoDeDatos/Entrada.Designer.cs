namespace AlmacenamientoDeDatos
{
    partial class frmEntrada
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.rdbArchivoTXT = new System.Windows.Forms.RadioButton();
            this.rdbArchivoXML = new System.Windows.Forms.RadioButton();
            this.rdbArchivoCSV = new System.Windows.Forms.RadioButton();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.rdbArchivoRTF = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(64, 46);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(234, 18);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Seleccione el archivo que desea";
            // 
            // rdbArchivoTXT
            // 
            this.rdbArchivoTXT.AutoSize = true;
            this.rdbArchivoTXT.Location = new System.Drawing.Point(110, 92);
            this.rdbArchivoTXT.Name = "rdbArchivoTXT";
            this.rdbArchivoTXT.Size = new System.Drawing.Size(111, 22);
            this.rdbArchivoTXT.TabIndex = 1;
            this.rdbArchivoTXT.Text = "Archivo TXT";
            this.rdbArchivoTXT.UseVisualStyleBackColor = true;
            // 
            // rdbArchivoXML
            // 
            this.rdbArchivoXML.AutoSize = true;
            this.rdbArchivoXML.Location = new System.Drawing.Point(110, 132);
            this.rdbArchivoXML.Name = "rdbArchivoXML";
            this.rdbArchivoXML.Size = new System.Drawing.Size(115, 22);
            this.rdbArchivoXML.TabIndex = 2;
            this.rdbArchivoXML.Text = "Archivo XML";
            this.rdbArchivoXML.UseVisualStyleBackColor = true;
            // 
            // rdbArchivoCSV
            // 
            this.rdbArchivoCSV.AutoSize = true;
            this.rdbArchivoCSV.Location = new System.Drawing.Point(110, 172);
            this.rdbArchivoCSV.Name = "rdbArchivoCSV";
            this.rdbArchivoCSV.Size = new System.Drawing.Size(116, 22);
            this.rdbArchivoCSV.TabIndex = 3;
            this.rdbArchivoCSV.Text = "Archivo CSV";
            this.rdbArchivoCSV.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(110, 252);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(111, 40);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // rdbArchivoRTF
            // 
            this.rdbArchivoRTF.AutoSize = true;
            this.rdbArchivoRTF.Location = new System.Drawing.Point(110, 213);
            this.rdbArchivoRTF.Name = "rdbArchivoRTF";
            this.rdbArchivoRTF.Size = new System.Drawing.Size(112, 22);
            this.rdbArchivoRTF.TabIndex = 5;
            this.rdbArchivoRTF.TabStop = true;
            this.rdbArchivoRTF.Text = "Archivo RTF";
            this.rdbArchivoRTF.UseVisualStyleBackColor = true;
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 353);
            this.Controls.Add(this.rdbArchivoRTF);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.rdbArchivoCSV);
            this.Controls.Add(this.rdbArchivoXML);
            this.Controls.Add(this.rdbArchivoTXT);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEntrada";
            this.Text = "Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RadioButton rdbArchivoTXT;
        private System.Windows.Forms.RadioButton rdbArchivoXML;
        private System.Windows.Forms.RadioButton rdbArchivoCSV;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.RadioButton rdbArchivoRTF;
    }
}

