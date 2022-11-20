namespace PartyPlaza
{
    partial class FrmSupplier
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
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisplayAdd = new System.Windows.Forms.Button();
            this.btnDisplayEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExitSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(38, 70);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersWidth = 62;
            this.dgvSupplier.RowTemplate.Height = 28;
            this.dgvSupplier.Size = new System.Drawing.Size(541, 517);
            this.dgvSupplier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supplier lists";
            // 
            // btnDisplayAdd
            // 
            this.btnDisplayAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDisplayAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAdd.Location = new System.Drawing.Point(643, 298);
            this.btnDisplayAdd.Name = "btnDisplayAdd";
            this.btnDisplayAdd.Size = new System.Drawing.Size(319, 51);
            this.btnDisplayAdd.TabIndex = 2;
            this.btnDisplayAdd.Text = "Add";
            this.btnDisplayAdd.UseVisualStyleBackColor = false;
            this.btnDisplayAdd.Click += new System.EventHandler(this.btnDisplayAdd_Click);
            // 
            // btnDisplayEdit
            // 
            this.btnDisplayEdit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDisplayEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayEdit.Location = new System.Drawing.Point(643, 374);
            this.btnDisplayEdit.Name = "btnDisplayEdit";
            this.btnDisplayEdit.Size = new System.Drawing.Size(319, 51);
            this.btnDisplayEdit.TabIndex = 3;
            this.btnDisplayEdit.Text = "Edit";
            this.btnDisplayEdit.UseVisualStyleBackColor = false;
            this.btnDisplayEdit.Click += new System.EventHandler(this.btnDisplayEdit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(643, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnExitSupplier
            // 
            this.btnExitSupplier.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnExitSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSupplier.Location = new System.Drawing.Point(643, 526);
            this.btnExitSupplier.Name = "btnExitSupplier";
            this.btnExitSupplier.Size = new System.Drawing.Size(319, 51);
            this.btnExitSupplier.TabIndex = 5;
            this.btnExitSupplier.Text = "Exit";
            this.btnExitSupplier.UseVisualStyleBackColor = false;
            this.btnExitSupplier.Click += new System.EventHandler(this.btnExitSupplier_Click);
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 599);
            this.Controls.Add(this.btnExitSupplier);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDisplayEdit);
            this.Controls.Add(this.btnDisplayAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSupplier";
            this.Text = "FrmSupplier";
            this.Load += new System.EventHandler(this.FrmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisplayAdd;
        private System.Windows.Forms.Button btnDisplayEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExitSupplier;
    }
}