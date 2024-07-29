using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int sayac = 0;
        int sayac2 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            
                int b1, b2, toplam = 0;
                b1 = random.Next(1, 11);
                b2 = random.Next(1, 11);

                label5.Text = b1.ToString();
                label6.Text = b2.ToString();
                toplam = b1 + b2;
                label12.Text = toplam.ToString();
            
            if (toplam <16)
            {
                int b3;
                b3 = random.Next(1, 11);
                label7.Text = b3.ToString();
                toplam=Convert.ToInt32(label5.Text)+Convert.ToInt32(label6.Text)+b3;
                label12.Text=toplam.ToString();
            }
            if (toplam <  16)
            {
                int b4;
                b4 = random.Next(1, 11);
                label8.Text = b4.ToString();
                toplam=Convert.ToInt32(label5.Text)+Convert.ToInt32(label6.Text)+Convert.ToInt32(label7.Text)+b4;
                label12.Text=toplam.ToString();
            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 == 1)
            {

                int a1, a2, toplam;
                a1 = random.Next(1, 11);
                a2 = random.Next(1, 11);
                toplam = a1 + a2;

                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                label10.Text = toplam.ToString();
            }
            
            if(sayac2 == 2)
            {
                int a3,toplam;
                a3=random.Next(1, 11);
                label3.Text= a3.ToString();
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text)+a3;
                label10.Text = toplam.ToString();
            }
            
            if (sayac2 == 3) 
            {
                int a4,toplam;
                a4 = random.Next(1, 11);
                label4.Text= a4.ToString();
                toplam=Convert.ToInt32(label1.Text)+ Convert.ToInt32(label2.Text)+Convert.ToInt32(label3.Text)+a4;
                label10.Text = toplam.ToString();
            }









        }

        private void button3_Click(object sender, EventArgs e)
        {
            int oyuncutoplam, bilgisayartoplam;
            oyuncutoplam =Convert.ToInt32(label10.Text);
            bilgisayartoplam = Convert.ToInt32(label12.Text);

            if (oyuncutoplam > 21 && bilgisayartoplam > 21)
            {
                MessageBox.Show("Hem siz hem bilgisayar 21'i geçti, ikiniz de kaybettiniz.");
            }
            // Sadece oyuncunun 21'i geçme durumu
            else if (oyuncutoplam > 21)
            {
                MessageBox.Show("Siz 21'i geçtiniz, bilgisayar kazandı.");
            }
            // Sadece bilgisayarın 21'i geçme durumu
            else if (bilgisayartoplam > 21)
            {
                MessageBox.Show("Bilgisayar 21'i geçti, siz kazandınız.");
            }
            // Her iki oyuncunun da 21'i geçmediği durumlar
            else if (oyuncutoplam > bilgisayartoplam)
            {
                MessageBox.Show("Kazandınız.");
            }
            else if (bilgisayartoplam > oyuncutoplam)
            {
                MessageBox.Show("Bilgisayar kazandı.");
            }
            else
            {
                MessageBox.Show("Berabere kaldınız.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayac = 0;
            sayac2 = 0;

            // Etiketleri sıfırla
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label10.Text = "0";
            label12.Text = "0";

            MessageBox.Show("Oyun yeniden başladi!");
        }
    }
}
