using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dgs_puan_hesaplama_motoru_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float saydog = float.Parse(textBox1.Text);
            float sayyan = float.Parse(textBox2.Text);
            float sozdog = float.Parse(textBox3.Text);
            float sozyan = float.Parse(textBox4.Text);
            if (saydog > 60 || saydog < 0)
            {
                MessageBox.Show("Lütfen Doğru Yanlış Sayılarınızı Düzeltiniz");
            }
            else if (sayyan > 60 || sayyan < 0)
            {
                MessageBox.Show("Lütfen Doğru Yanlış Sayılarınızı Düzeltiniz");


            }
            else if (sozdog > 60|| sozdog < 0)
            {
                MessageBox.Show("Lütfen Doğru Yanlış Sayılarınızı Düzeltiniz");


            }
            else if (sozyan > 60 || sozyan < 0)
            {
                MessageBox.Show("Lütfen Doğru Yanlış Sayılarınızı Düzeltiniz");


            }
            else
            {


                float obp = float.Parse(textBox5.Text);
                float obpreal = (float)(obp * 0.8);
                if (obpreal < 40 || obpreal > 100)
                {
                    MessageBox.Show("Önlisans Başarı Puanınız 50 den Küçük veya 100 den Büyük olamaz!");
                }
                else
                {

                    float sayisalnot, sozelnot, esitagirliknot, sayreal, sozreal;

                    sayisalnot = (float)(saydog - (sayyan * 0.25));
                    sozelnot = (float)(sozdog - (sozyan * 0.25));



                    sayreal = (float)(146.442 + (sozelnot * 0.600) + (sayisalnot * 3.000) + (obpreal * 0.6));

                    if (sayreal < 180)
                    {
                        textBox6.Text = ("Barajı Geçemediniz.").ToString();
                    }
                    else
                    {
                        textBox6.Text = sayreal.ToString();

                    }
                    sozreal = (float)(130.342 + (sozelnot * 2.100) + (sayisalnot * 0.500) + (obpreal * 0.6));
                    if (sozreal < 180)
                    {
                        textBox7.Text = ("Barajı Geçemediniz.").ToString();
                    }
                    else
                    {
                        textBox7.Text = sozreal.ToString();

                    }



                    esitagirliknot = (float)(127.392 + (sayisalnot * 1.700) + (sozelnot * 1.700) + (obpreal * 0.6));
                    if (esitagirliknot < 180)
                    {
                        textBox8.Text = ("Barajı Geçemediniz.").ToString();
                    }
                    else
                    {
                        textBox8.Text = esitagirliknot.ToString();

                    }
                }
            }
                }
            }
}
