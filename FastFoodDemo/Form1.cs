using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Form1 : Form
    {
        string[] sorular = {
       "Matematik ve fen bilimleri derslerinde başarılı mısınız?",
       "Yeni şeyler öğrenmeye açık ve istekli misiniz?",
       "Detaycı ve dikkatli misiniz?",
       "Sabırlı ve azimli misiniz?",
       "Ekip çalışmasına yatkın mısınız?",
       "İletişim becerileriniz gelişmiş mi?",
       "Zaman yönetimi becerileriniz gelişmiş mi?",
       "Stres altında sakin kalabiliyor musunuz?",
       "Kendinizi geliştirmeye istekli misiniz?",
       "İngilizce dilini en az orta seviyede biliyor musunuz?",
       "Sürekli öğrenmeye açık mısınız?",
       "Bağımsız çalışabiliyor musunuz?",
       "Yüksek sorumluluk gerektiren bir meslek istiyor musun? ",
       "Kendinizi saatlerce masa başında oturmaya uygun görüyor musunuz?",
       "Teknolojik aletlere ilginiz varmı?",
       "Veritabanları ve veri analizi hakkında bilginiz var mı?",      
       //tasarım     
       "Yazılım geliştirmeye veya web tasarlamaya ilginiz var mı?",
       "Görsel detaylara dikkat ediyor musunuz",
       "Yaratıcı ve yenilikçi düşünme becerileriniz gelişmiş mi?",
       "Günlük hayatta ayrıntılara dikkat eder misiniz?",
       "Resim çizmeye veya tasarım yapmaya ilginiz var mı?",
       "Uzamsal(üç boyutlu nesneleri zihinde canlandırma ve yönetme) düşünme beceriniz var mı?",
       "Simetri ile ilgili bir takıntınız var mı?",
        //yazılım
        "Analitik düşünme becerileriniz gelişmiş mi?",
        "Problem çözme becerileriniz gelişmiş mi?",
        "Siber güvenlik ve ağ teknolojileri hakkında bilgi sahibi misiniz?",
        "Sorunları çözmekten keyif alıyor musunuz?",
        "Bilgisayar ve yazılım programlarına karşı ilginiz var mı?",
        "Yazılım geliştirme alanına girmek için temel programlama bilgisine sahip misiniz?",
        "Dikkatinizi toplama konusunda ne kadar başarılı mısınız?",
        };
        int soruIndex = 0;
        int evetSayisi = 0;
        double tasbeceri = 0;
        double yazbeceri = 0;
        double genbeceri= 0;
        string verilencevap = "";
        double yuzde = 0;
        double ybeceri = 0;
        double tbeceri = 0;
        int onay = 0;
        int t = 0;
        int y = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            anaekranbut.BackColor = Color.FromArgb(64, 64, 64);
            testekranbut.BackColor = Color.FromArgb(41, 39, 40);
            istatistikbut.BackColor = Color.FromArgb(41, 39, 40);
            hakkındabut.BackColor = Color.FromArgb(41, 39, 40);
                   
            anaekranbut.ForeColor = Color.White;
            testekranbut.ForeColor= Color.Gray;
            istatistikbut.ForeColor= Color.Gray;
            hakkındabut.ForeColor= Color.Gray;
            
            anaekranbut.Image = Properties.Resources.home__1_;
            testekranbut.Image = Properties.Resources.list_check__1_;
            istatistikbut.Image = Properties.Resources.edit__1_;
            hakkındabut.Image = Properties.Resources.question_square__1_;
            pictureBox1.Visible = true;
            labelbaslık.Text = "Ana Ekran";
            labelbaslık.ForeColor = Color.White; 
            labelbaslık.BackColor = Color.Black; 
            yenidenbaşbut.BackColor = Color.Black;
            yenidenbaşbut.Image = Properties.Resources.refresh;        
            kapatmabut.BackColor = Color.Black;
            kapatmabut.Image = Properties.Resources.on_off_button__1_;
            button1.BackColor = Color.Black;
            button1.Image = Properties.Resources.globe__1_;
            button9.BackColor = Color.Black;
            button9.Image = Properties.Resources.twitter__1_;
            button10.BackColor = Color.Black;
            button10.Image = Properties.Resources.instagram__2_;
            panelhakkinda.Visible = false;
            panelista.Visible = false; 
            paneltest.Visible = false;               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelbaslık.ForeColor = Color.Black;
            labelbaslık.BackColor = Color.White;
            anaekranbut.BackColor = Color.FromArgb(41, 39, 40);
            testekranbut.BackColor = Color.FromArgb(64, 64, 64);
            istatistikbut.BackColor = Color.FromArgb(41, 39, 40);
            hakkındabut.BackColor = Color.FromArgb(41, 39, 40);
            
            anaekranbut.ForeColor = Color.Gray;
            testekranbut.ForeColor = Color.White;
            istatistikbut.ForeColor = Color.Gray;
            hakkındabut.ForeColor = Color.Gray;
          
            anaekranbut.Image = Properties.Resources.home__2_;
            testekranbut.Image = Properties.Resources.list_check;
            istatistikbut.Image = Properties.Resources.edit__1_;
            hakkındabut.Image = Properties.Resources.question_square__1_;
            yenidenbaşbut.BackColor = Color.White;
            yenidenbaşbut.Image = Properties.Resources.refresh__1_;   
            kapatmabut.BackColor = Color.White;
            kapatmabut.Image = Properties.Resources.on_off_button;
            button1.BackColor = Color.White;
            button1.Image = Properties.Resources.globe;
            button9.BackColor = Color.White;
            button9.Image = Properties.Resources.twitter;
            button10.BackColor = Color.White;
            button10.Image = Properties.Resources.instagram__1_;
            labelbaslık.Text = "BÖLÜM YETERLİLİK TESTİ";            
            paneltest.Visible = true;
            panelhakkinda.Visible = false;
            panelista.Visible = false;
            pictureBox1.Visible = false;    
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            labelbaslık.Text = "Ana Ekran";
            labelbaslık.ForeColor = Color.White;
            labelbaslık.BackColor = Color.Black;
            yenidenbaşbut.BackColor = Color.Black;
            yenidenbaşbut.Image = Properties.Resources.refresh;           
            kapatmabut.BackColor = Color.Black;
            kapatmabut.Image = Properties.Resources.on_off_button__1_;
            button1.BackColor = Color.Black;
            button1.Image = Properties.Resources.globe__1_;
            button9.BackColor = Color.Black;
            button9.Image = Properties.Resources.twitter__1_;
            button10.BackColor = Color.Black;
            button10.Image = Properties.Resources.instagram__2_;
            anaekranbut.BackColor = Color.FromArgb(64, 64, 64);
            anaekranbut.ForeColor = Color.White;
            anaekranbut.Image = Properties.Resources.home__1_;
            panelista.Visible = false;
            paneltest.Visible = false;
            panelhakkinda.Visible = false;
            panel7.Visible=false;
            bunifuCustomLabel12.Text = "Bilişim Bölümüne Uygun Olup Olmadığınızı Öğrenmek İçin Testi Tamamlayınız";
            bunifuCustomLabel7.Text = "Uygunluk Yüzdenizi Görmek için Lütfen Testi Tamamlayınız";
            bunifuProgressBar1.Visible = false;
            bunifuCustomLabel6.Visible = false;
            bunifuCustomLabel13.Visible = false;    
            bunifuCustomLabel14.Visible = false;
            bunifuCustomLabel47.Visible = false;
            bunifuCustomLabel48.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();        
            bunifuProgressBar1.Value = 0;
            anaekranbut.BackColor = Color.FromArgb(41, 39, 40);
            testekranbut.BackColor = Color.FromArgb(41, 39, 40);
            istatistikbut.BackColor = Color.FromArgb(64, 64, 64);
            hakkındabut.BackColor = Color.FromArgb(41, 39, 40);      
            labelbaslık.ForeColor = Color.Black;
            labelbaslık.BackColor = Color.White;           
            anaekranbut.ForeColor = Color.Gray;
            testekranbut.ForeColor = Color.Gray;
            istatistikbut.ForeColor = Color.White;
            hakkındabut.ForeColor = Color.Gray;        
            anaekranbut.Image = Properties.Resources.home__2_;
            testekranbut.Image = Properties.Resources.list_check__1_;
            istatistikbut.Image = Properties.Resources.edit;
            hakkındabut.Image = Properties.Resources.question_square__1_;
            yenidenbaşbut.BackColor = Color.White;
            yenidenbaşbut.Image = Properties.Resources.refresh__1_;
            kapatmabut.BackColor = Color.White;
            kapatmabut.Image = Properties.Resources.on_off_button;
            button1.BackColor = Color.White;
            button1.Image = Properties.Resources.globe;
            button9.BackColor = Color.White;
            button9.Image = Properties.Resources.twitter;
            button10.BackColor = Color.White;
            button10.Image = Properties.Resources.instagram__1_;
            labelbaslık.Text = "İSTATİSTİKLER";
            pictureBox1.Visible = false;
            panelista.Visible = true;
            panelhakkinda.Visible = false;
            paneltest.Visible = false;  
            timer1.Start();  
        }
        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamayı Yeniden Başlatmak İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Restart();
            }
        }
        private void baslabutton_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel8.Visible = true;
            bunifuProgressBar4.Visible = true;
            soruLabel.Text = sorular[soruIndex];
            label19.Text = Convert.ToString(soruIndex + 1);
            geribut.Visible = false;
            pictureBox2.Visible = false;
        }
        private void evetbuton_Click(object sender, EventArgs e)
        {
            geribut.Visible = true;
            pictureBox2.Visible = true;

            if (soruIndex < sorular.Length)
            {  
                if (soruIndex <= 15)
                {
                    genbeceri += 3.1;
                }
                else if (soruIndex > 15 && soruIndex <= 22)
                {
                    tasbeceri += 7.14;
                    t++;
                }
                else if (soruIndex > 22 && soruIndex<30)
                { 
                    yazbeceri += 7.14;
                    y++;
                }        
                
                soruIndex++;   
                evetSayisi++;
              
                if (soruIndex < sorular.Length)
                {
                    soruLabel.Text = sorular[soruIndex];
                    label19.Text = Convert.ToString(soruIndex+1);
                    bunifuProgressBar4.Value++;
                }
                else
                {
                    bunifuProgressBar4.Value++;
                    soruLabel.Text = "Testi Tamamladınız";
                    evetbuton.Visible = false;
                    hayirbuton.Visible = false;
                    tekrarbut.Visible = true;
                    bitirbut.Visible = true;
                    label19.Visible = false;
                    geribut.Visible = false;
                    pictureBox2.Visible = false;
                }
            }       
            verilencevap = "evet";
        }
        private void hayirbuton_Click(object sender, EventArgs e)
        {
            geribut.Visible = true;
            pictureBox2.Visible= true;
            if (soruIndex < sorular.Length)
            {              
                soruIndex++;
                     
                if (soruIndex < sorular.Length)
                {  
                    soruLabel.Text = sorular[soruIndex];
                label19.Text = Convert.ToString(soruIndex+1);
                   bunifuProgressBar4.Value++;   
                }
                   
                else
                {
                    bunifuProgressBar4.Value++;
                    soruLabel.Text = "Testi Tamamladınız";
                    evetbuton.Visible = false;
                    hayirbuton.Visible = false;
                    tekrarbut.Visible = true;
                    bitirbut.Visible = true;
                    label19.Visible = false;
                    geribut.Visible = false;
                    pictureBox2.Visible = false;
                }
            }
            verilencevap = "hayir";                   
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
            if (soruIndex > 0)
            {
                
                soruIndex--;

                if (verilencevap == "evet")
                {
                    if (soruIndex <= 15)
                    {
                        genbeceri -= 3.1;
                    }
                    else if (soruIndex > 15 && soruIndex <= 22)
                    {
                        tasbeceri -= 7.14;
                        t--;
                    }
                    else if (soruIndex > 22 && soruIndex < 30)
                    {
                        yazbeceri -= 7.14;
                        y--;
                    }
                    evetSayisi--;
                    bunifuProgressBar4.Value--;

                }
                else
                {
                    evetSayisi++;
                    bunifuProgressBar4.Value--;
                }

                soruLabel.Text = sorular[soruIndex];
                label19.Text = Convert.ToString(soruIndex + 1);
            }
            if (soruIndex==0)
            {
                geribut.Visible = false;
                pictureBox2.Visible = false;
            }
            else
            {
                geribut.Visible = true;
                pictureBox2.Visible = true;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/fatihsultanmehmetmtal/";
            System.Diagnostics.Process.Start(url);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string url = "https://twitter.com/fsmmtal_";
            System.Diagnostics.Process.Start(url);
        }

        private void hakkındabut_Click(object sender, EventArgs e)
        {
            anaekranbut.BackColor = Color.FromArgb(41, 39, 40);
            testekranbut.BackColor = Color.FromArgb(41, 39, 40);
            istatistikbut.BackColor = Color.FromArgb(41, 39, 40);
            hakkındabut.BackColor = Color.FromArgb(64, 64, 64);
         
            labelbaslık.ForeColor = Color.Black;
            labelbaslık.BackColor = Color.White;
            anaekranbut.ForeColor = Color.Gray;
            testekranbut.ForeColor = Color.Gray;
            istatistikbut.ForeColor = Color.Gray;
            hakkındabut.ForeColor = Color.White;
          
            anaekranbut.Image = Properties.Resources.home__2_;
            testekranbut.Image = Properties.Resources.list_check__1_;
            istatistikbut.Image = Properties.Resources.edit__1_;
            hakkındabut.Image = Properties.Resources.question_square;
            yenidenbaşbut.BackColor = Color.White;
            yenidenbaşbut.Image = Properties.Resources.refresh__1_;
            kapatmabut.BackColor = Color.White;
            kapatmabut.Image = Properties.Resources.on_off_button;
            button1.BackColor = Color.White;
            button1.Image = Properties.Resources.globe;
            button9.BackColor = Color.White;
            button9.Image = Properties.Resources.twitter;
            button10.BackColor = Color.White;
            button10.Image = Properties.Resources.instagram__1_;
            labelbaslık.Text = "UYGULAMA HAKKINDA";
            panelhakkinda.Visible = true;
            pictureBox1.Visible = false;      
            panelista.Visible = false;
            paneltest.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string url = "https://maltepetml.meb.k12.tr";
            System.Diagnostics.Process.Start(url);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval > 1)
            {
                timer1.Interval--;
            }
            if (bunifuProgressBar1.Value<Convert.ToInt32(yuzde))
            {
                bunifuProgressBar1.Value++;             
            }       
        }
        

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Testi Bitirmek istediğinize Emin misiniz?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {              
                // Hesaplama ve yazdırma işlemleri
                yuzde = (double)evetSayisi / sorular.Length * 100;
                onay = 1;
                bunifuCustomLabel13.Text = $"Olumlu Cevap Sayısı: {evetSayisi}";
                bunifuCustomLabel14.Text = $"Uygunluk Yüzdeniz: {Convert.ToInt32(yuzde):F2}% ";
                bunifuCustomLabel7.Text = "Bilişim Alanına Uygunluk Yüzdeniz";
                bunifuCustomLabel47.Text = "Olumlu Tasarım Yatkınlık Sorusu: "+"7/"+t;
                bunifuCustomLabel48.Text = "Olumlu Tasarım Yatkınlık Sorusu: " +"7/"+y;
                bunifuProgressBar1.Visible = true;
                bunifuCustomLabel6.Visible = true;
                bunifuCustomLabel13.Visible = true;
                bunifuCustomLabel14.Visible = true;
                bunifuCustomLabel47.Visible = true;
                bunifuCustomLabel48.Visible = true;
                bunifuCustomLabel4.Visible = true;
                panel7.Visible=true;
                bunifuCustomLabel6.Text = "%" + Convert.ToInt32(yuzde);               
                if (yuzde >= 60)
                {
                    bunifuCustomLabel12.Text = "Bilişim Teknolojileri alanına uygunsunuz!" ;
                }
                else
                {
                    bunifuCustomLabel12.Text = "Bilişim Teknolojileri Alanına Uygun Olmayabilirsiniz." ;
                    bunifuCustomLabel4.Text = "Farklı alanları değerlendirmeyi düşünebilirsiniz.";
                } 
                panel8.Visible = false;
                bunifuProgressBar4.Visible = false;
            }
        }
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Testi Tekrarlamak istediğinize Emin misiniz?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                bunifuCustomLabel12.Text = "Bilişim Bölümüne Uygun Olup Olmadığınızı Öğrenmek İçin Testi Tamamlayınız";
                bunifuCustomLabel7.Text = "Uygunluk Yüzdenizi Görmek için Lütfen Testi Tamamlayınız";
                bunifuCustomLabel8.Text = " Düşündüğünüz Alan Nedir?";
                bunifuProgressBar1.Visible = false;
                bunifuCustomLabel6.Visible = false;
                bunifuCustomLabel13.Visible = false;
                bunifuCustomLabel14.Visible = false;
                bunifuCustomLabel47.Visible = false;
                bunifuCustomLabel48.Visible = false;
                bunifuCustomLabel4.Visible = false;
                label19.Visible = true;
                bunifuCircleProgressbar1.Value = 0;
                bunifuProgressBar4.Value = 0;
                bunifuProgressBar1.Value = 0;
                bunifuProgressBar4.Visible = true;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                panel8.Visible = true;
                evetSayisi = 0;
                soruIndex = 0;
                yuzde = 0;
                soruLabel.Text = sorular[soruIndex];
                bitirbut.Visible = false;
                tekrarbut.Visible = false;
                label19.Text = Convert.ToString(soruIndex + 1);
                panel7.Visible = false;
                evetbuton.Visible = true;
                hayirbuton.Visible = true;
                tasbeceri = 0;
                yazbeceri = 0;
                genbeceri = 0;
                ybeceri = 0;
                tbeceri = 0;
                onay = 0;
                t = 0;
                y = 0;
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (onay == 1)
            {
                bunifuCircleProgressbar1.Value = 0;
                ybeceri = yazbeceri + genbeceri;
                timer2.Start();
                timer3.Stop();
                bunifuCustomLabel8.Font = new Font(bunifuCustomLabel8.Font.FontFamily, 16);
                bunifuCustomLabel8.Font = new Font(bunifuCustomLabel8.Font, FontStyle.Bold);
                if (ybeceri < 50)
                {
                    bunifuCustomLabel8.Text = "Muhtemelen Yazılım Alanında Başarılı Olamayacaksınız";

                }
                else if (ybeceri >= 50 && ybeceri <= 75)
                {
                    bunifuCustomLabel8.Text = "Çalışıp Çabaladığınız Taktirde Muhtemelen Yazılım Alanında Başarlılı Olacaksınız";
                }
                else
                {
                    bunifuCustomLabel8.Text = "Çok Büyük İhtimal Yazılım Alanında Başarılı Olacaksınız";
                }
            }
            else
            {
                MessageBox.Show("Sonuçları Görmek İçin Testi Tamamlayınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            if (onay==1)
            {
            bunifuCircleProgressbar1.Value = 0;
            tbeceri =tasbeceri + genbeceri;
            timer2.Stop();
            timer3.Start();
            bunifuCustomLabel8.Font = new Font(bunifuCustomLabel8.Font.FontFamily, 16);
            bunifuCustomLabel8.Font = new Font(bunifuCustomLabel8.Font, FontStyle.Bold);
            if (tbeceri < 50)
            {
                bunifuCustomLabel8.Text = "Muhtemelen Tasarım Alanında Başarılı Olamayacaksınız";

            }
            else if (tbeceri >= 50 && tbeceri <= 75)
            {
                bunifuCustomLabel8.Text = "Çalışıp Çabaladığınız Taktirde Muhtemelen Tasarım Alanında Başarlılı Olacaksınız";
            }
            else
            {
                bunifuCustomLabel8.Text = "Çok Büyük İhtimal Tasarım Alanında Başarılı Olacaksınız";
            }
            }
            else
            {
                MessageBox.Show("Sonuçları Görmek İçin Testi Tamamlayınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval > 1)
            {
                timer1.Interval--;
            }
            if (bunifuCircleProgressbar1.Value < Convert.ToInt32(ybeceri))
            {
                bunifuCircleProgressbar1.Value++;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval >1)
            {
                timer1.Interval--;
            }
            if (bunifuCircleProgressbar1.Value < Convert.ToInt32(tbeceri))
            {
                bunifuCircleProgressbar1.Value++;
            }
        }    
        private void bunifuThinButton23_Click_3(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Testi Tekrarlamak istediğinize Emin misiniz?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                bunifuCustomLabel12.Text = "Bilişim Bölümüne Uygun Olup Olmadığınızı Öğrenmek İçin Testi Tamamlayınız";
                bunifuCustomLabel7.Text = "Uygunluk Yüzdenizi Görmek için Lütfen Testi Tamamlayınız";
                bunifuCustomLabel8.Text =" Düşündüğünüz Alan Nedir?";
                bunifuProgressBar1.Visible = false;
                bunifuCustomLabel6.Visible = false;
                bunifuCustomLabel13.Visible = false;
                bunifuCustomLabel14.Visible = false;
                bunifuCustomLabel47.Visible = false;
                bunifuCustomLabel48.Visible = false;
                bunifuCustomLabel4.Visible = false;
                bunifuCircleProgressbar1.Value = 0;
                bunifuProgressBar4.Value = 0;
                bunifuProgressBar1.Value = 0;
                bunifuProgressBar4.Visible = true;
                label19.Visible = true;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                panel8.Visible = true;
                evetSayisi = 0;
                soruIndex = 0;
                yuzde = 0;
                soruLabel.Text = sorular[soruIndex];
                bitirbut.Visible = false;
                tekrarbut.Visible = false;
                label19.Text = Convert.ToString(soruIndex + 1);
                panel7.Visible = false;
                evetbuton.Visible = true;
                hayirbuton.Visible = true;
                tasbeceri = 0;
                yazbeceri = 0;
                genbeceri = 0;                
                ybeceri = 0;
                tbeceri = 0;
                onay = 0;
                t = 0;
                y = 0;
            }
        }
    }   
}
