namespace EsiniBulOyunuOnline6
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int boyut = 4; // sat�r ve s�tun say�s�
        List<string> resimler = new List<string>();
        List<string> kartlar = new List<string>();

        public Form1()
        {
            ResimleriYukle();
            InitializeComponent();
            KartlariSec();
            KartlariDiz();
        }

        private void KartlariDiz()
        {
            int bosluk = 10;
            int gen = (pnlKartlar.Width - ((boyut - 1) * bosluk)) / boyut;
            int yuk = (pnlKartlar.Height - ((boyut - 1) * bosluk)) / boyut;

            int i = 0;
            for (int y = 0; y < boyut; y++)
            {
                for (int x = 0; x < boyut; x++)
                {
                    PictureBox resimKutusu = new PictureBox();
                    resimKutusu.Tag = i;
                    resimKutusu.BackColor = Color.Bisque;
                    resimKutusu.Size = new Size(gen, yuk);
                    resimKutusu.Left = x * (resimKutusu.Width + bosluk);
                    resimKutusu.Top = y * (resimKutusu.Height + bosluk);
                    resimKutusu.ImageLocation = @"img\" + kartlar[i];
                    resimKutusu.SizeMode = PictureBoxSizeMode.Zoom;
                    pnlKartlar.Controls.Add(resimKutusu);
                    i++;
                }
            }
        }

        private void KartlariSec()
        {
            int ciftAdet = boyut * boyut / 2;

            while (kartlar.Count < ciftAdet)
            {
                string resim = resimler[rnd.Next(resimler.Count)];

                if (!kartlar.Contains(resim))
                    kartlar.Add(resim);
            }

            kartlar.AddRange(kartlar);
            KartlariKaristir();
        }

        private void KartlariKaristir()
        {
            string yedek;
            int talihliIndeks;
            for (int i = 0; i < kartlar.Count - 1; i++)
            {
                talihliIndeks = rnd.Next(i, kartlar.Count);
                yedek = kartlar[i];
                kartlar[i] = kartlar[talihliIndeks];
                kartlar[talihliIndeks] = yedek;
            }
        }

        private void ResimleriYukle()
        {
            DirectoryInfo klasor = new DirectoryInfo("img");
            FileInfo[] dosyalar = klasor.GetFiles();

            foreach (FileInfo dosya in dosyalar)
                resimler.Add(dosya.Name);
        }
    }
}