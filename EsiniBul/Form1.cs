using EsiniBul.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiniBul
{
    public partial class Form1 : Form
    {
        int satirAdet = 4;
        int sutunAdet = 4;
        int kartBoyut = 75;
        int kartArasi = 5;
        int[] bayrakHavuzu;
        int[] bayraklar;
        List<PictureBox> acilanlar;
        List<PictureBox> kartlar;
        readonly ZorlukSeviye _zorlukSeviye;
        

        public int KartAdet { get { return satirAdet * sutunAdet; } }
        public Form1(ZorlukSeviye zorlukSeviye)
        {
            _zorlukSeviye = zorlukSeviye;
            SeviyeAyarla();
            InitializeComponent();
            acilanlar = new List<PictureBox>();
            BayrakHavuzunuDoldur();
            KartlariDiz();
            KartlariKisaSureliGoster();
        }

        private void KartlariKisaSureliGoster()
        {
            pnlKartlar.Enabled = false;
            foreach (PictureBox pictureBox in kartlar)
            {
                KartiAc(pictureBox);
            }
            Thread.Sleep(2000);//todo süre değişecek
            foreach (PictureBox pictureBox in kartlar)
            {
                KartiKapat(pictureBox);
            }
            Application.DoEvents();
            pnlKartlar.Enabled = true;
        }

        private void SeviyeAyarla()
        {
            switch (_zorlukSeviye)
            {
                
                case ZorlukSeviye.Kolay:
                    satirAdet = sutunAdet = 4;
                    break;
                case ZorlukSeviye.Orta:
                    satirAdet = sutunAdet = 6;
                    break;
                case ZorlukSeviye.Zor:
                    satirAdet = sutunAdet = 8;
                    break;
                default:
                    throw new Exception("Olmayan bir seviye seçimi yapıldı.");
                    
            }
        }

        private void BayrakHavuzunuDoldur()
        {
            bayrakHavuzu = Enumerable.Range(1, 243).ToArray();
            Islemler.Karistir(bayrakHavuzu);
        }
        private void KartlariDiz()
        {
            BayralariDoldur();
            kartlar = new List<PictureBox>();
            pnlKartlar.Width = sutunAdet * (kartBoyut + kartArasi)-kartArasi;
            pnlKartlar.Height = satirAdet * (kartBoyut + kartArasi)-kartArasi;
            ClientSize = new Size(pnlKartlar.Width + 20, pnlKartlar.Height + 20);

            for (int i = 0; i < KartAdet; i++)
            {
                PictureBox pb = new PictureBox();
                kartlar.Add(pb);
                pb.Tag = i;
                pb.Click += Pb_Click;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = (Bitmap)Resources.ResourceManager.GetObject("_" + bayraklar[i]);
                pb.Image = Resources.block;
                pb.Width = kartBoyut;
                pb.Height = kartBoyut;
                pb.BackColor = Color.Pink;
                pb.Left = i % sutunAdet * (kartBoyut + kartArasi);
                pb.Top = i / sutunAdet * (kartBoyut + kartArasi);
                pnlKartlar.Controls.Add(pb);
            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (acilanlar.Count==1&& pb == acilanlar[0])
            return;//dikkate almadan oyundan çık
            

            if (acilanlar.Count==2)
                AcikKartlariKapat();

            acilanlar.Add(pb);
            KartiAc(pb);

            if (acilanlar.Count==2&& AcilanlarAyniysa()  )
            {
                Thread.Sleep(500);//aynı olan açık kartları gizlemeden önce görebilirsiniz
                AcikKartlariGizle();
            }
        }
        private void KartiAc(PictureBox pb)
        {
            int index = (int)pb.Tag;
            int bayrakNo = bayraklar[index];
            pb.Image = (Bitmap)Resources.ResourceManager.GetObject("_" + bayrakNo);
            pb.Refresh();
        }
        private void KartiKapat(PictureBox pb)
        {
            pb.Image = Resources.block;
        }
        private bool AcilanlarAyniysa()
        {
            int index1 = (int)acilanlar[0].Tag;
            int index2 = (int)acilanlar[1].Tag;
            return bayraklar[index1] == bayraklar[index2];
        }
        private void AcikKartlariGizle()
        {
            foreach (PictureBox pictureBox in acilanlar)
            {
                pictureBox.Hide();
            }
            acilanlar.Clear();
        }


        private void AcikKartlariKapat()
        {
            foreach (PictureBox pictureBox in acilanlar)
            {
                KartiKapat(pictureBox);
            }
            acilanlar.Clear();
        }

        private void BayralariDoldur()
        {
            bayraklar = new int[KartAdet];
            Array.Copy(bayrakHavuzu, bayraklar, KartAdet / 2);
            Array.Copy(bayrakHavuzu, 0, bayraklar, KartAdet / 2, KartAdet / 2);
            Islemler.Karistir(bayraklar);
            Random rnd = new Random();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            KartlariKisaSureliGoster();
        }
    }
}
