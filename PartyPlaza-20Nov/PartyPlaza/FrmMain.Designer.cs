namespace PartyPlaza
{
    partial class frmMain
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(187, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 608);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PartyPlaza.Properties.Resources.tmp_d00d865d_d84a_4cd9_adec_523c32f8b5b0;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnSupplier);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 608);
            this.panel1.TabIndex = 13;
            // 
            // btnSupplier
            // 
            this.btnSupplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupplier.BackColor = System.Drawing.Color.White;
            this.btnSupplier.BackgroundImage = global::PartyPlaza.Properties.Resources.tmp_3f1e9247_f243_47dd_addb_e48da70521fd;
            this.btnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Location = new System.Drawing.Point(20, 437);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(135, 95);
            this.btnSupplier.TabIndex = 7;
            this.btnSupplier.Text = "Add";
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click_1);
            // 
            // btnOrder
            // 
            this.btnOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOrder.BackColor = System.Drawing.Color.White;
            this.btnOrder.BackgroundImage = global::PartyPlaza.Properties.Resources.tmp_7e4bcf75_d245_4be9_a0a1_8412eb29939b;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(20, 308);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(135, 95);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Add";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::PartyPlaza.Properties.Resources.tmp_0d71c072_c59a_491b_b163_16bb55840aa8;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(20, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 95);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = global::PartyPlaza.Properties.Resources.tmp_71c2a221_4f13_4a3f_a17b_e2fa154b9dfe;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 95);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PartyPlaza.Properties.Resources.tmp_d6389661_6018_4b45_9bcf_be2b5d96c78a;
            this.pictureBox1.Location = new System.Drawing.Point(1, 616);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1294, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1302, 738);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

