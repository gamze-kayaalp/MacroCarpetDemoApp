using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halıDemoApp
{
    public partial class Form3 : Form
    {
        private Bitmap originalBmp;
        private Bitmap resizedBmp;

        public Form3()
        {
            InitializeComponent();
        }

        public void SetBitmap(Bitmap bmp)
        {
            originalBmp = bmp;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                // KullanÄ±cÄ±dan gelen Tarak, AtkÄ±, En ve Boy deÄŸerlerini al
                double tarak = double.Parse(textBoxTarak.Text);
                double atki = double.Parse(textBoxAtkı.Text);
                double en = double.Parse(textBoxEn.Text);
                double boy = double.Parse(textBoxBoy.Text);

                // Piksel deÄŸerlerini hesapla
                double xPiksel = Math.Round((tarak * 0.10) * en, 2) - 1;
                double yPiksel = Math.Round((atki * 0.10) * boy, 2);

                int newWidth = (int)xPiksel;
                int newHeight = (int)yPiksel;

                // GÃ¶rseli yeniden boyutlandÄ±r ve kaliteli ÅŸekilde iÅŸleme yap
                resizedBmp = ResizeImage(originalBmp, new Size(newWidth, newHeight));

                // PictureBox'ta gÃ¶ster
                pictureBoxTransformed.Image = resizedBmp;
                pictureBoxTransformed.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private Bitmap ResizeImage(Image img, Size newSize)
        {
            // Yeni bir bitmap oluÅŸtur
            Bitmap bmp = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Grafik kalitesini ayarla
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                // GÃ¶rseli Ã§iz
                g.DrawImage(img, 0, 0, newSize.Width, newSize.Height);
            }
            return bmp;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (resizedBmp != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "BMP DosyalarÄ±|*.bmp"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;
                    resizedBmp.Save(savePath, System.Drawing.Imaging.ImageFormat.Bmp);
                    MessageBox.Show("GÃ¶rsel baÅŸarÄ±yla kaydedildi.");
                }
            }
            else
            {
                MessageBox.Show("LÃ¼tfen Ã¶nce bir dÃ¶nÃ¼ÅŸÃ¼m yapÄ±n.");
            }
        }
    }
}