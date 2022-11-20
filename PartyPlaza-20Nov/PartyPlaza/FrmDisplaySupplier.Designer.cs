namespace PartyPlaza
{
    partial class frmDisplaySupplier
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisplayExit = new System.Windows.Forms.Button();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btnDisplayDelete = new System.Windows.Forms.Button();
            this.btnDisplayEdit = new System.Windows.Forms.Button();
            this.btnDisplayAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnDisplayExit);
            this.panel3.Controls.Add(this.dgvSupplier);
            this.panel3.Controls.Add(this.btnDisplayDelete);
            this.panel3.Controls.Add(this.btnDisplayEdit);
            this.panel3.Controls.Add(this.btnDisplayAdd);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1084, 584);
            this.panel3.TabIndex = 16;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 36);
            this.label1.TabIndex = 72;
            this.label1.Text = "Suppliers List";
            // 
            // btnDisplayExit
            // 
            this.btnDisplayExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDisplayExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayExit.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayExit.Location = new System.Drawing.Point(761, 494);
            this.btnDisplayExit.Name = "btnDisplayExit";
            this.btnDisplayExit.Size = new System.Drawing.Size(278, 57);
            this.btnDisplayExit.TabIndex = 8;
            this.btnDisplayExit.Text = "Exit";
            this.btnDisplayExit.UseVisualStyleBackColor = false;
            this.btnDisplayExit.Click += new System.EventHandler(this.btnDisplayExit_Click);
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(16, 52);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersWidth = 62;
            this.dgvSupplier.RowTemplate.Height = 28;
            this.dgvSupplier.Size = new System.Drawing.Size(536, 517);
            this.dgvSupplier.TabIndex = 40;
            // 
            // btnDisplayDelete
            // 
            this.btnDisplayDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDisplayDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayDelete.Location = new System.Drawing.Point(761, 410);
            this.btnDisplayDelete.Name = "btnDisplayDelete";
            this.btnDisplayDelete.Size = new System.Drawing.Size(278, 57);
            this.btnDisplayDelete.TabIndex = 6;
            this.btnDisplayDelete.Text = "Delete";
            this.btnDisplayDelete.UseVisualStyleBackColor = false;
            this.btnDisplayDelete.Click += new System.EventHandler(this.btnDisplayDelete_Click);
            // 
            // btnDisplayEdit
            // 
            this.btnDisplayEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDisplayEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayEdit.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayEdit.Location = new System.Drawing.Point(761, 330);
            this.btnDisplayEdit.Name = "btnDisplayEdit";
            this.btnDisplayEdit.Size = new System.Drawing.Size(278, 57);
            this.btnDisplayEdit.TabIndex = 5;
            this.btnDisplayEdit.Text = "Edit";
            this.btnDisplayEdit.UseVisualStyleBackColor = false;
            this.btnDisplayEdit.Click += new System.EventHandler(this.btnDisplayEdit_Click);
            // 
            // btnDisplayAdd
            // 
            this.btnDisplayAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDisplayAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAdd.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayAdd.Location = new System.Drawing.Point(761, 246);
            this.btnDisplayAdd.Name = "btnDisplayAdd";
            this.btnDisplayAdd.Size = new System.Drawing.Size(278, 57);
            this.btnDisplayAdd.TabIndex = 4;
            this.btnDisplayAdd.Text = "Add";
            this.btnDisplayAdd.UseVisualStyleBackColor = false;
            this.btnDisplayAdd.Click += new System.EventHandler(this.btnDisplayAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDisplaySupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 608);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDisplaySupplier";
            this.Text = "Supplier Form";
            this.Load += new System.EventHandler(this.frmDisplaySupplier_load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDisplayExit;
        private System.Windows.Forms.Button btnDisplayDelete;
        private System.Windows.Forms.Button btnDisplayEdit;
        private System.Windows.Forms.Button btnDisplayAdd;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}