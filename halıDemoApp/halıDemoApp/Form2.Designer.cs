namespace halıDemoApp
{
    partial class Form2
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
            this.pictureBoxOrıgınal = new System.Windows.Forms.PictureBox();
            this.butonLoad = new System.Windows.Forms.Button();
            this.butonDevam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrıgınal)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOrıgınal
            // 
            this.pictureBoxOrıgınal.Location = new System.Drawing.Point(82, 95);
            this.pictureBoxOrıgınal.Name = "pictureBoxOrıgınal";
            this.pictureBoxOrıgınal.Size = new System.Drawing.Size(335, 257);
            this.pictureBoxOrıgınal.TabIndex = 0;
            this.pictureBoxOrıgınal.TabStop = false;
            // 
            // butonLoad
            // 
            this.butonLoad.Location = new System.Drawing.Point(137, 46);
            this.butonLoad.Name = "butonLoad";
            this.butonLoad.Size = new System.Drawing.Size(185, 23);
            this.butonLoad.TabIndex = 1;
            this.butonLoad.Text = "Dosya Yükle";
            this.butonLoad.UseVisualStyleBackColor = true;
            this.butonLoad.Click += new System.EventHandler(this.butonLoad_Click);
            // 
            // butonDevam
            // 
            this.butonDevam.Location = new System.Drawing.Point(442, 192);
            this.butonDevam.Name = "butonDevam";
            this.butonDevam.Size = new System.Drawing.Size(75, 54);
            this.butonDevam.TabIndex = 2;
            this.butonDevam.Text = "Devam Et";
            this.butonDevam.UseVisualStyleBackColor = true;
            this.butonDevam.Click += new System.EventHandler(this.butonDevam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(687, 378);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "İleri";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butonDevam);
            this.Controls.Add(this.butonLoad);
            this.Controls.Add(this.pictureBoxOrıgınal);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrıgınal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOrıgınal;
        private System.Windows.Forms.Button butonLoad;
        private System.Windows.Forms.Button butonDevam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNext;
    }
}