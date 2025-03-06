namespace halıDemoApp
{
    partial class Form3
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
            this.pictureBoxTransformed = new System.Windows.Forms.PictureBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEn = new System.Windows.Forms.TextBox();
            this.textBoxBoy = new System.Windows.Forms.TextBox();
            this.textBoxTarak = new System.Windows.Forms.TextBox();
            this.textBoxAtkı = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransformed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTransformed
            // 
            this.pictureBoxTransformed.Location = new System.Drawing.Point(419, 78);
            this.pictureBoxTransformed.Name = "pictureBoxTransformed";
            this.pictureBoxTransformed.Size = new System.Drawing.Size(329, 240);
            this.pictureBoxTransformed.TabIndex = 0;
            this.pictureBoxTransformed.TabStop = false;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(303, 149);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(73, 46);
            this.buttonConvert.TabIndex = 1;
            this.buttonConvert.Text = "Dönüştür";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(633, 357);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 36);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Kaydet";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "En:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Boy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarak:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Atkı:";
            // 
            // textBoxEn
            // 
            this.textBoxEn.Location = new System.Drawing.Point(112, 60);
            this.textBoxEn.Name = "textBoxEn";
            this.textBoxEn.Size = new System.Drawing.Size(100, 22);
            this.textBoxEn.TabIndex = 7;
            // 
            // textBoxBoy
            // 
            this.textBoxBoy.Location = new System.Drawing.Point(112, 97);
            this.textBoxBoy.Name = "textBoxBoy";
            this.textBoxBoy.Size = new System.Drawing.Size(100, 22);
            this.textBoxBoy.TabIndex = 8;
            // 
            // textBoxTarak
            // 
            this.textBoxTarak.Location = new System.Drawing.Point(112, 143);
            this.textBoxTarak.Name = "textBoxTarak";
            this.textBoxTarak.Size = new System.Drawing.Size(100, 22);
            this.textBoxTarak.TabIndex = 9;
            // 
            // textBoxAtkı
            // 
            this.textBoxAtkı.Location = new System.Drawing.Point(112, 194);
            this.textBoxAtkı.Name = "textBoxAtkı";
            this.textBoxAtkı.Size = new System.Drawing.Size(100, 22);
            this.textBoxAtkı.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAtkı);
            this.Controls.Add(this.textBoxTarak);
            this.Controls.Add(this.textBoxBoy);
            this.Controls.Add(this.textBoxEn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.pictureBoxTransformed);
            this.Name = "Form3";
            this.Text = "AA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransformed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTransformed;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEn;
        private System.Windows.Forms.TextBox textBoxBoy;
        private System.Windows.Forms.TextBox textBoxTarak;
        private System.Windows.Forms.TextBox textBoxAtkı;
    }
}