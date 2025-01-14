﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatuzaklik, ikinciatuzaklik, ucuncuatuzaklik;
        int kullaniciTercihi = 0; // Kullanıcının seçtiği at numarası

        Random rastgele = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label8.Text);
            derece++;
            label8.Text = derece.ToString();

            int birinciatgenislik = pictureBox1.Width;
            int ikinciatgenislik = pictureBox2.Width;
            int ucuncuatgenislik = pictureBox3.Width;

            int bitisuzakligi = label5.Left;
            pictureBox1.Left += rastgele.Next(5, 20);
            pictureBox2.Left += rastgele.Next(5, 20);
            pictureBox3.Left += rastgele.Next(5, 20);

            if (birinciatgenislik + pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                if (kullaniciTercihi == 1)
                {
                    MessageBox.Show("Tebrikler! 1 numaralı at yarışı kazandı.");
                }
                else
                {
                    MessageBox.Show("Üzgünüz! 1 numaralı at yarışı kazandı.");
                }
            }
            else if (ikinciatgenislik + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                if (kullaniciTercihi == 2)
                {
                    MessageBox.Show("Tebrikler! 2 numaralı at yarışı kazandı.");
                }
                else
                {
                    MessageBox.Show("Üzgünüz! 2 numaralı at yarışı kazandı.");
                }
            }
            else if (ucuncuatgenislik + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                if (kullaniciTercihi == 3)
                {
                    MessageBox.Show("Tebrikler! 3 numaralı at yarışı kazandı.");
                }
                else
                {
                    MessageBox.Show("Üzgünüz! 3 numaralı at yarışı kazandı.");
                }
            }

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label7.Text = "1 numaralı at önde";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label7.Text = "2 numaralı at önde";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label7.Text = "3 numaralı at önde";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            label7.Text = "";
            label8.Text = "0";


            // TextBox'tan kullanıcının seçtiği at numarasını alın
            if (int.TryParse(textBox1.Text, out int secim) && secim >= 1 && secim <= 3)
            {
                kullaniciTercihi = secim;

                // Oyunu başlat
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Geçersiz at numarası. Lütfen 1 ile 3 arasında bir sayı girin.");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'tan kullanıcının seçtiği at numarasını alın
            if (int.TryParse(textBox1.Text, out int secim) && secim >= 1 && secim <= 3)
            {
                kullaniciTercihi = secim;

                // Oyunu başlat
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Geçersiz at numarası. Lütfen 1 ile 3 arasında bir sayı girin.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatuzaklik = pictureBox1.Left;
            ikinciatuzaklik = pictureBox2.Left;
            ucuncuatuzaklik = pictureBox3.Left;
        }
    }
}
