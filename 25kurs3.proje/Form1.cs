using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25kurs3.proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlıs = 0;
        public void temizle()
        {
            textBox1.Text = " ";
        }
        public void sabitle()
        {
            textBox1.Focus();
        }

        //liinklabela basınca ne olsun işlemleri
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            switch (soruno)
            {
                case 1:
                    if (textBox1.Text == "Ankara")
                    {
                        button17.BackColor = Color.Green;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                        temizle();
                        sabitle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; }
                    temizle();
                    sabitle();
                    break;
                    
                case 2:
                    if (textBox1.Text == "Basketbol")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle();
                        sabitle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                case 3:
                    if (textBox1.Text == "Ceviz")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle(); sabitle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                case 4:
                    if (textBox1.Text == "Diyarbakır")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle(); sabitle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                case 5:
                    if (textBox1.Text == "Edirne")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                case 6:
                    if (textBox1.Text == "Fransız")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle(); sabitle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                case 7:
                    if (textBox1.Text == "Giresun")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle(); sabitle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                case 8:
                    if (textBox1.Text == "Hatay")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                case 9:
                    if (textBox1.Text == "Ilgaz")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle(); sabitle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                case 10:
                    if (textBox1.Text == "İlkadım")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle(); sabitle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                case 11:
                    if (textBox1.Text == "Jale")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle(); sabitle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                case 12:
                    if (textBox1.Text == "Kumru")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle(); sabitle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                case 13:
                    if (textBox1.Text == "Lale")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle(); sabitle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                case 14:
                    if (textBox1.Text == "Malatya")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle(); sabitle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                case 15:
                    if (textBox1.Text == "Nevşehir")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle(); sabitle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                case 16:
                    if (textBox1.Text == "Ozon")
                    {
                        button17.BackColor = Color.Green;
                        dogru++; temizle(); sabitle();
                    }
                    else { button17.BackColor = Color.Red; yanlıs++; temizle(); sabitle(); }
                    break;
                    
            }
            lbldogru.Text = dogru.ToString();
            lblyanlış.Text = yanlıs.ToString();
        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki Soru ";
            soruno++;
            this.Text = soruno.ToString();
            switch (soruno)
            {
                case 1: richTextBox1.Text = "Türkiyenin Başkeni ?"; btn1.BackColor = Color.Yellow; break;
                case 2: richTextBox1.Text = "Bir spor türüdür ?"; btn2.BackColor = Color.Yellow; break;
                case 3: richTextBox1.Text = "Beyini güçlendiren bir yemiş ?"; btn3.BackColor = Color.Yellow; break;
                case 4: richTextBox1.Text = "Karpuzu ile bilinen ilimiz ?"; btn4.BackColor = Color.Yellow; break;
                case 5: richTextBox1.Text = "Türkiyenin en batı şehri ?"; btn5.BackColor = Color.Yellow; break;
                case 6: richTextBox1.Text = "...İhtilali olarak bilinir yenilik getirmişlerdir ?"; btn6.BackColor = Color.Yellow; break;
                case 7: richTextBox1.Text = "Fındığı ile bilinen şehrimiz ?"; btn7.BackColor = Color.Yellow; break;
                case 8: richTextBox1.Text = "İlk cumhurbaşkanı Tayfur sökmen olan şuanki şehrimiz ?"; btn8.BackColor = Color.Yellow; break;
                case 9: richTextBox1.Text = "Batı karadenizin en yüksek dağ kütlesidir ?"; btn9.BackColor = Color.Yellow; break;
                case 10: richTextBox1.Text = "Samsun da bir bölge ismidir ?"; btn10.BackColor = Color.Yellow; break;
                case 11: richTextBox1.Text = "Aklınıza gelen ilk isim ?"; btn11.BackColor = Color.Yellow; break;
                case 12: richTextBox1.Text = "İzmirde çok tüketilir ?"; btn12.BackColor = Color.Yellow; break;
                case 13: richTextBox1.Text = "Osmanlının en güzel döneminin ismidir ?"; btn13.BackColor = Color.Yellow; break;
                case 14: richTextBox1.Text = "Kaysısı ile ünlü sehrimiz ?"; btn14.BackColor = Color.Yellow; break;
                case 15: richTextBox1.Text = "Peribacaları bu şehirde bulunur ?"; btn15.BackColor = Color.Yellow; break;
                case 16: richTextBox1.Text = "Dünyanın bir tabaka ismidir ?"; btn16.BackColor = Color.Yellow; break;
               

            }
        }
    }
}
