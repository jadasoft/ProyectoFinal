namespace jadaSoft
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
            this.btoOk = new System.Windows.Forms.Button();
            this.btoRegistre = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pBjada = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBjada)).BeginInit();
            this.SuspendLayout();
            // 
            // btoOk
            // 
            this.btoOk.Location = new System.Drawing.Point(112, 248);
            this.btoOk.Name = "btoOk";
            this.btoOk.Size = new System.Drawing.Size(75, 23);
            this.btoOk.TabIndex = 0;
            this.btoOk.Text = "Login";
            this.btoOk.UseVisualStyleBackColor = true;
            // 
            // btoRegistre
            // 
            this.btoRegistre.Location = new System.Drawing.Point(218, 248);
            this.btoRegistre.Name = "btoRegistre";
            this.btoRegistre.Size = new System.Drawing.Size(75, 23);
            this.btoRegistre.TabIndex = 1;
            this.btoRegistre.Text = "Register";
            this.btoRegistre.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(182, 164);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(98, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(98, 170);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // pBjada
            // 
            this.pBjada.Image = global::jadaSoft.Properties.Resources.jada;
            this.pBjada.Location = new System.Drawing.Point(158, 29);
            this.pBjada.Name = "pBjada";
            this.pBjada.Size = new System.Drawing.Size(100, 50);
            this.pBjada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBjada.TabIndex = 6;
            this.pBjada.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 295);
            this.Controls.Add(this.pBjada);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btoRegistre);
            this.Controls.Add(this.btoOk);
            this.Name = "Form1";
            this.Text = "Jada Soft";
            ((System.ComponentModel.ISupportInitialize)(this.pBjada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btoOk;
        private System.Windows.Forms.Button btoRegistre;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pBjada;
    }
}

