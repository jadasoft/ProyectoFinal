namespace jadaSoft
{
    partial class FWorking
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
            this.dgvContactes = new System.Windows.Forms.DataGridView();
            this._IsTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._IsEdited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btoComplete = new System.Windows.Forms.Button();
            this.btoIncidence = new System.Windows.Forms.Button();
            this.btoSave = new System.Windows.Forms.Button();
            this.btoExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContactes
            // 
            this.dgvContactes.AllowUserToAddRows = false;
            this.dgvContactes.AllowUserToDeleteRows = false;
            this.dgvContactes.AllowUserToOrderColumns = true;
            this.dgvContactes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._IsTemp,
            this._IsEdited});
            this.dgvContactes.Location = new System.Drawing.Point(56, 120);
            this.dgvContactes.MultiSelect = false;
            this.dgvContactes.Name = "dgvContactes";
            this.dgvContactes.ReadOnly = true;
            this.dgvContactes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactes.Size = new System.Drawing.Size(493, 150);
            this.dgvContactes.TabIndex = 1;
            // 
            // _IsTemp
            // 
            this._IsTemp.HeaderText = "_IsTemp";
            this._IsTemp.Name = "_IsTemp";
            this._IsTemp.ReadOnly = true;
            // 
            // _IsEdited
            // 
            this._IsEdited.HeaderText = "_IsEdited";
            this._IsEdited.Name = "_IsEdited";
            this._IsEdited.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jadaSoft.Properties.Resources.jada;
            this.pictureBox1.Location = new System.Drawing.Point(244, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(247, 78);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(97, 16);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "List deliveries ";
            // 
            // btoComplete
            // 
            this.btoComplete.Location = new System.Drawing.Point(86, 317);
            this.btoComplete.Name = "btoComplete";
            this.btoComplete.Size = new System.Drawing.Size(75, 23);
            this.btoComplete.TabIndex = 17;
            this.btoComplete.Text = "Complete";
            this.btoComplete.UseVisualStyleBackColor = true;
            // 
            // btoIncidence
            // 
            this.btoIncidence.Location = new System.Drawing.Point(216, 317);
            this.btoIncidence.Name = "btoIncidence";
            this.btoIncidence.Size = new System.Drawing.Size(75, 23);
            this.btoIncidence.TabIndex = 18;
            this.btoIncidence.Text = "Incidence";
            this.btoIncidence.UseVisualStyleBackColor = true;
            // 
            // btoSave
            // 
            this.btoSave.Location = new System.Drawing.Point(347, 317);
            this.btoSave.Name = "btoSave";
            this.btoSave.Size = new System.Drawing.Size(75, 23);
            this.btoSave.TabIndex = 19;
            this.btoSave.Text = "Save";
            this.btoSave.UseVisualStyleBackColor = true;
            // 
            // btoExit
            // 
            this.btoExit.Location = new System.Drawing.Point(474, 317);
            this.btoExit.Name = "btoExit";
            this.btoExit.Size = new System.Drawing.Size(75, 23);
            this.btoExit.TabIndex = 20;
            this.btoExit.Text = "Exit";
            this.btoExit.UseVisualStyleBackColor = true;
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 365);
            this.Controls.Add(this.btoExit);
            this.Controls.Add(this.btoSave);
            this.Controls.Add(this.btoIncidence);
            this.Controls.Add(this.btoComplete);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvContactes);
            this.Name = "TreeView";
            this.Text = "WORKING...";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactes;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IsTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IsEdited;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btoComplete;
        private System.Windows.Forms.Button btoIncidence;
        private System.Windows.Forms.Button btoSave;
        private System.Windows.Forms.Button btoExit;
    }
}