using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halıDemoApp
{
    public partial class Form2 : Form
    {
        // Bitmap nesnesini global olarak tanımla
        Bitmap bmp;
        public Form2()
        {
            InitializeComponent();
        }

        private void butonLoad_Click(object sender, EventArgs e)
        {
            // OpenFileDialog oluştur
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP Dosyaları|*.bmp"; // Sadece BMP dosyalarını seçilebilir yap

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen dosyanın yolunu al
                string dosyaYolu = openFileDialog.FileName;

                // Bitmap nesnesi oluştur ve seçilen dosyayı yükle
                bmp = new Bitmap(dosyaYolu);

                // PictureBox'ta göster 
                pictureBoxOrıgınal.Image = bmp;

                // SizeMode özelliğini ayarla
                pictureBoxOrıgınal.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void butonDevam_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                // Halı deseninin en ve boy değerlerini al
                int en = bmp.Width;
                int boy = bmp.Height;

                // Label'lara değerleri atama
                label1.Text = "En: " + en.ToString() + " cm";
                label2.Text = "Boy: " + boy.ToString() + " cm";

                // Form3'te kullanılmak üzere en ve boy değerlerini form3'e aktar
                // Form3 form3 = new Form3();
                //form3.SetBitmap(bmp);
                //form3.Show();
            }
            else
            {
                MessageBox.Show("Lütfen önce bir halı deseni yükleyin.");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Form3'ü oluştur ve göster
            Form3 form3 = new Form3();
            form3.SetBitmap(bmp);
            form3.Show();
        }
    }
}


