namespace Sasageyo
{
    partial class Account
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPseudo = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RightArrow = new System.Windows.Forms.PictureBox();
            this.LeftArrow = new System.Windows.Forms.PictureBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPseudo);
            this.groupBox1.Controls.Add(this.tbMail);
            this.groupBox1.Controls.Add(this.tbPrenom);
            this.groupBox1.Controls.Add(this.tbNom);
            this.groupBox1.Location = new System.Drawing.Point(38, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données personnelles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pseudo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prénom :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom :";
            // 
            // tbPseudo
            // 
            this.tbPseudo.Location = new System.Drawing.Point(165, 198);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(149, 20);
            this.tbPseudo.TabIndex = 3;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(165, 149);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(149, 20);
            this.tbMail.TabIndex = 2;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(165, 99);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(149, 20);
            this.tbPrenom.TabIndex = 1;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(165, 57);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(149, 20);
            this.tbNom.TabIndex = 0;
            // 
            // btValider
            // 
            this.btValider.Cursor = System.Windows.Forms.Cursors.Default;
            this.btValider.Location = new System.Drawing.Point(178, 696);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(119, 54);
            this.btValider.TabIndex = 4;
            this.btValider.Text = "Enregistrer";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Choisissez un avatar";
            // 
            // RightArrow
            // 
            this.RightArrow.Location = new System.Drawing.Point(375, 498);
            this.RightArrow.Name = "RightArrow";
            this.RightArrow.Size = new System.Drawing.Size(73, 71);
            this.RightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightArrow.TabIndex = 3;
            this.RightArrow.TabStop = false;
            this.RightArrow.Click += new System.EventHandler(this.Right_Click);
            // 
            // LeftArrow
            // 
            this.LeftArrow.Location = new System.Drawing.Point(38, 498);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(73, 71);
            this.LeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftArrow.TabIndex = 2;
            this.LeftArrow.TabStop = false;
            this.LeftArrow.Click += new System.EventHandler(this.Left_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(136, 423);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(216, 202);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 1;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 861);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.RightArrow);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 900);
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Account_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPseudo;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.PictureBox LeftArrow;
        private System.Windows.Forms.PictureBox RightArrow;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label label5;
    }
}