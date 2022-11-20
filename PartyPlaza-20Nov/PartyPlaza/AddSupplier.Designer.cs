namespace PartyPlaza
{
    partial class frmAddSupplier
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.lblAddSupplierNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddForename = new System.Windows.Forms.TextBox();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.txtAddStreet = new System.Windows.Forms.TextBox();
            this.txtAddCounty = new System.Windows.Forms.TextBox();
            this.txtAddPostcode = new System.Windows.Forms.TextBox();
            this.txtAddTelNo = new System.Windows.Forms.TextBox();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddTown = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAddBusinessName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 495);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 35);
            this.label10.TabIndex = 106;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 36);
            this.label9.TabIndex = 105;
            this.label9.Text = "Telephone";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 36);
            this.label8.TabIndex = 104;
            this.label8.Text = "Postcode";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 36);
            this.label7.TabIndex = 103;
            this.label7.Text = "County";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 36);
            this.label6.TabIndex = 102;
            this.label6.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 36);
            this.label5.TabIndex = 101;
            this.label5.Text = "Surname";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 36);
            this.label4.TabIndex = 100;
            this.label4.Text = "Forename";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(768, 425);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(279, 49);
            this.btnExit.TabIndex = 97;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAddAdd.Location = new System.Drawing.Point(768, 354);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(279, 49);
            this.btnAddAdd.TabIndex = 96;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = false;
            this.btnAddAdd.Click += new System.EventHandler(this.btnAddAdd_Click);
            // 
            // lblAddSupplierNo
            // 
            this.lblAddSupplierNo.BackColor = System.Drawing.Color.White;
            this.lblAddSupplierNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSupplierNo.Location = new System.Drawing.Point(773, 173);
            this.lblAddSupplierNo.Name = "lblAddSupplierNo";
            this.lblAddSupplierNo.Size = new System.Drawing.Size(274, 44);
            this.lblAddSupplierNo.TabIndex = 90;
            this.lblAddSupplierNo.Text = "-";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(772, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 36);
            this.label1.TabIndex = 89;
            this.label1.Text = "Supplier No";
            // 
            // txtAddForename
            // 
            this.txtAddForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddForename.Location = new System.Drawing.Point(249, 76);
            this.txtAddForename.Name = "txtAddForename";
            this.txtAddForename.Size = new System.Drawing.Size(387, 37);
            this.txtAddForename.TabIndex = 108;
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddSurname.Location = new System.Drawing.Point(249, 130);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(387, 37);
            this.txtAddSurname.TabIndex = 109;
            // 
            // txtAddStreet
            // 
            this.txtAddStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStreet.Location = new System.Drawing.Point(249, 190);
            this.txtAddStreet.Name = "txtAddStreet";
            this.txtAddStreet.Size = new System.Drawing.Size(387, 37);
            this.txtAddStreet.TabIndex = 110;
            // 
            // txtAddCounty
            // 
            this.txtAddCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCounty.Location = new System.Drawing.Point(249, 316);
            this.txtAddCounty.Name = "txtAddCounty";
            this.txtAddCounty.Size = new System.Drawing.Size(387, 37);
            this.txtAddCounty.TabIndex = 111;
            // 
            // txtAddPostcode
            // 
            this.txtAddPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPostcode.Location = new System.Drawing.Point(249, 381);
            this.txtAddPostcode.Name = "txtAddPostcode";
            this.txtAddPostcode.Size = new System.Drawing.Size(387, 37);
            this.txtAddPostcode.TabIndex = 112;
            // 
            // txtAddTelNo
            // 
            this.txtAddTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTelNo.Location = new System.Drawing.Point(249, 437);
            this.txtAddTelNo.Name = "txtAddTelNo";
            this.txtAddTelNo.Size = new System.Drawing.Size(387, 37);
            this.txtAddTelNo.TabIndex = 113;
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddEmail.Location = new System.Drawing.Point(249, 493);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(387, 37);
            this.txtAddEmail.TabIndex = 114;
            // 
            // txtAddTown
            // 
            this.txtAddTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTown.Location = new System.Drawing.Point(249, 252);
            this.txtAddTown.Name = "txtAddTown";
            this.txtAddTown.Size = new System.Drawing.Size(387, 37);
            this.txtAddTown.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 36);
            this.label2.TabIndex = 116;
            this.label2.Text = "Town";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // txtAddBusinessName
            // 
            this.txtAddBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddBusinessName.Location = new System.Drawing.Point(249, 20);
            this.txtAddBusinessName.Name = "txtAddBusinessName";
            this.txtAddBusinessName.Size = new System.Drawing.Size(387, 37);
            this.txtAddBusinessName.TabIndex = 141;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 36);
            this.label3.TabIndex = 140;
            this.label3.Text = "Business";
            // 
            // frmAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1086, 552);
            this.Controls.Add(this.txtAddBusinessName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddTown);
            this.Controls.Add(this.txtAddEmail);
            this.Controls.Add(this.txtAddTelNo);
            this.Controls.Add(this.txtAddPostcode);
            this.Controls.Add(this.txtAddCounty);
            this.Controls.Add(this.txtAddStreet);
            this.Controls.Add(this.txtAddSurname);
            this.Controls.Add(this.txtAddForename);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddAdd);
            this.Controls.Add(this.lblAddSupplierNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddSupplier";
            this.Text = "AddSupplier";
            this.Load += new System.EventHandler(this.AddSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.Label lblAddSupplierNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddForename;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.TextBox txtAddStreet;
        private System.Windows.Forms.TextBox txtAddCounty;
        private System.Windows.Forms.TextBox txtAddPostcode;
        private System.Windows.Forms.TextBox txtAddTelNo;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddTown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.TextBox txtAddBusinessName;
        private System.Windows.Forms.Label label3;
    }
}