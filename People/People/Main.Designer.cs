namespace Main
{
    partial class Main
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
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.TxtFileSelected = new System.Windows.Forms.TextBox();
            this.BtnProcessFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Location = new System.Drawing.Point(197, 25);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectFile.TabIndex = 0;
            this.BtnSelectFile.Text = "Select File";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // TxtFileSelected
            // 
            this.TxtFileSelected.Enabled = false;
            this.TxtFileSelected.Location = new System.Drawing.Point(12, 25);
            this.TxtFileSelected.Name = "TxtFileSelected";
            this.TxtFileSelected.Size = new System.Drawing.Size(179, 20);
            this.TxtFileSelected.TabIndex = 1;
            // 
            // BtnProcessFile
            // 
            this.BtnProcessFile.Enabled = false;
            this.BtnProcessFile.Location = new System.Drawing.Point(105, 119);
            this.BtnProcessFile.Name = "BtnProcessFile";
            this.BtnProcessFile.Size = new System.Drawing.Size(75, 23);
            this.BtnProcessFile.TabIndex = 2;
            this.BtnProcessFile.Text = "Process File";
            this.BtnProcessFile.UseVisualStyleBackColor = true;
            this.BtnProcessFile.Click += new System.EventHandler(this.BtnProcessFile_Click);
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnProcessFile);
            this.Controls.Add(this.TxtFileSelected);
            this.Controls.Add(this.BtnSelectFile);
            this.Name = "People";
            this.Text = "People";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.TextBox TxtFileSelected;
        private System.Windows.Forms.Button BtnProcessFile;
    }
}

