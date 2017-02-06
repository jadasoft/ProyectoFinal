namespace View
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.contactsDataGrid = new System.Windows.Forms.DataGridView();
            this.detailsDatagrid = new System.Windows.Forms.DataGridView();
            this.contactName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.detailPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.detailDesc = new System.Windows.Forms.TextBox();
            this.phoneSave = new System.Windows.Forms.Button();
            this.phoneDel = new System.Windows.Forms.Button();
            this.phoneAdd = new System.Windows.Forms.Button();
            this.userSave = new System.Windows.Forms.Button();
            this.userDel = new System.Windows.Forms.Button();
            this.userAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contactsDataGrid
            // 
            this.contactsDataGrid.AllowUserToAddRows = false;
            this.contactsDataGrid.AllowUserToDeleteRows = false;
            this.contactsDataGrid.AllowUserToResizeRows = false;
            this.contactsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contactsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.contactsDataGrid.Location = new System.Drawing.Point(12, 12);
            this.contactsDataGrid.MultiSelect = false;
            this.contactsDataGrid.Name = "contactsDataGrid";
            this.contactsDataGrid.ReadOnly = true;
            this.contactsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contactsDataGrid.Size = new System.Drawing.Size(319, 321);
            this.contactsDataGrid.TabIndex = 0;
            // 
            // detailsDatagrid
            // 
            this.detailsDatagrid.AllowUserToAddRows = false;
            this.detailsDatagrid.AllowUserToDeleteRows = false;
            this.detailsDatagrid.AllowUserToResizeRows = false;
            this.detailsDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailsDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsDatagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.detailsDatagrid.Location = new System.Drawing.Point(359, 12);
            this.detailsDatagrid.MultiSelect = false;
            this.detailsDatagrid.Name = "detailsDatagrid";
            this.detailsDatagrid.ReadOnly = true;
            this.detailsDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detailsDatagrid.Size = new System.Drawing.Size(354, 305);
            this.detailsDatagrid.TabIndex = 1;
            // 
            // contactName
            // 
            this.contactName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.contactName.Location = new System.Drawing.Point(12, 339);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(319, 20);
            this.contactName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Telèfon";
            // 
            // detailPhone
            // 
            this.detailPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.detailPhone.Location = new System.Drawing.Point(359, 339);
            this.detailPhone.Name = "detailPhone";
            this.detailPhone.Size = new System.Drawing.Size(175, 20);
            this.detailPhone.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripció";
            // 
            // detailDesc
            // 
            this.detailDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.detailDesc.Location = new System.Drawing.Point(540, 339);
            this.detailDesc.Name = "detailDesc";
            this.detailDesc.Size = new System.Drawing.Size(173, 20);
            this.detailDesc.TabIndex = 11;
            // 
            // phoneSave
            // 
            this.phoneSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.phoneSave.Image = global::View.Images.telephone_edit;
            this.phoneSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phoneSave.Location = new System.Drawing.Point(556, 365);
            this.phoneSave.Name = "phoneSave";
            this.phoneSave.Size = new System.Drawing.Size(157, 23);
            this.phoneSave.TabIndex = 14;
            this.phoneSave.Text = "Save Changes";
            this.phoneSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.phoneSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.phoneSave.UseVisualStyleBackColor = true;
            // 
            // phoneDel
            // 
            this.phoneDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.phoneDel.Image = global::View.Images.telephone_delete;
            this.phoneDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phoneDel.Location = new System.Drawing.Point(453, 365);
            this.phoneDel.Name = "phoneDel";
            this.phoneDel.Size = new System.Drawing.Size(97, 23);
            this.phoneDel.TabIndex = 13;
            this.phoneDel.Text = "Delete Phone";
            this.phoneDel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.phoneDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.phoneDel.UseVisualStyleBackColor = true;
            // 
            // phoneAdd
            // 
            this.phoneAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.phoneAdd.Image = global::View.Images.telephone_add;
            this.phoneAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phoneAdd.Location = new System.Drawing.Point(360, 365);
            this.phoneAdd.Name = "phoneAdd";
            this.phoneAdd.Size = new System.Drawing.Size(87, 23);
            this.phoneAdd.TabIndex = 12;
            this.phoneAdd.Text = "Add Phone";
            this.phoneAdd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.phoneAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.phoneAdd.UseVisualStyleBackColor = true;
            // 
            // userSave
            // 
            this.userSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userSave.Image = global::View.Images.user_edit;
            this.userSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userSave.Location = new System.Drawing.Point(192, 365);
            this.userSave.Name = "userSave";
            this.userSave.Size = new System.Drawing.Size(139, 23);
            this.userSave.TabIndex = 7;
            this.userSave.Text = "Save Changes";
            this.userSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.userSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userSave.UseVisualStyleBackColor = true;
            // 
            // userDel
            // 
            this.userDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userDel.Image = global::View.Images.user_delete;
            this.userDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userDel.Location = new System.Drawing.Point(93, 365);
            this.userDel.Name = "userDel";
            this.userDel.Size = new System.Drawing.Size(93, 23);
            this.userDel.TabIndex = 6;
            this.userDel.Text = "Delete User";
            this.userDel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.userDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userDel.UseVisualStyleBackColor = true;
            // 
            // userAdd
            // 
            this.userAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userAdd.Image = global::View.Images.user_add;
            this.userAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userAdd.Location = new System.Drawing.Point(12, 365);
            this.userAdd.Name = "userAdd";
            this.userAdd.Size = new System.Drawing.Size(75, 23);
            this.userAdd.TabIndex = 5;
            this.userAdd.Text = "Add User";
            this.userAdd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.userAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userAdd.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Images.arrow_right;
            this.pictureBox1.Location = new System.Drawing.Point(337, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 400);
            this.Controls.Add(this.phoneSave);
            this.Controls.Add(this.phoneDel);
            this.Controls.Add(this.phoneAdd);
            this.Controls.Add(this.detailDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.detailPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userSave);
            this.Controls.Add(this.userDel);
            this.Controls.Add(this.userAdd);
            this.Controls.Add(this.contactName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.detailsDatagrid);
            this.Controls.Add(this.contactsDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Exam 16/12/2016 - Pablo Blanco Celdrán";
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView contactsDataGrid;
        public System.Windows.Forms.DataGridView detailsDatagrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox contactName;
        public System.Windows.Forms.Button userAdd;
        public System.Windows.Forms.Button userDel;
        public System.Windows.Forms.Button userSave;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox detailPhone;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox detailDesc;
        public System.Windows.Forms.Button phoneSave;
        public System.Windows.Forms.Button phoneDel;
        public System.Windows.Forms.Button phoneAdd;
    }
}

