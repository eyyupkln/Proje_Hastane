namespace Proje_Hastane
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnhastagirişi = new System.Windows.Forms.Button();
            this.btndoktorgirişi = new System.Windows.Forms.Button();
            this.btnsekretergirişi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhastagirişi
            // 
            this.btnhastagirişi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnhastagirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhastagirişi.BackgroundImage")));
            this.btnhastagirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhastagirişi.Location = new System.Drawing.Point(50, 141);
            this.btnhastagirişi.Name = "btnhastagirişi";
            this.btnhastagirişi.Size = new System.Drawing.Size(203, 158);
            this.btnhastagirişi.TabIndex = 0;
            this.btnhastagirişi.UseVisualStyleBackColor = false;
            this.btnhastagirişi.Click += new System.EventHandler(this.btnhastagirişi_Click);
            // 
            // btndoktorgirişi
            // 
            this.btndoktorgirişi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btndoktorgirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndoktorgirişi.BackgroundImage")));
            this.btndoktorgirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoktorgirişi.Location = new System.Drawing.Point(299, 141);
            this.btndoktorgirişi.Name = "btndoktorgirişi";
            this.btndoktorgirişi.Size = new System.Drawing.Size(203, 158);
            this.btndoktorgirişi.TabIndex = 1;
            this.btndoktorgirişi.UseVisualStyleBackColor = false;
            this.btndoktorgirişi.Click += new System.EventHandler(this.btndoktorgirişi_Click);
            // 
            // btnsekretergirişi
            // 
            this.btnsekretergirişi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnsekretergirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsekretergirişi.BackgroundImage")));
            this.btnsekretergirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsekretergirişi.Location = new System.Drawing.Point(550, 141);
            this.btnsekretergirişi.Name = "btnsekretergirişi";
            this.btnsekretergirişi.Size = new System.Drawing.Size(203, 158);
            this.btnsekretergirişi.TabIndex = 2;
            this.btnsekretergirişi.UseVisualStyleBackColor = false;
            this.btnsekretergirişi.Click += new System.EventHandler(this.btnsekretergirişi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(451, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sea Green Hospital ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(813, 358);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsekretergirişi);
            this.Controls.Add(this.btndoktorgirişi);
            this.Controls.Add(this.btnhastagirişi);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sea Green Hospital  Giriş ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhastagirişi;
        private System.Windows.Forms.Button btndoktorgirişi;
        private System.Windows.Forms.Button btnsekretergirişi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

