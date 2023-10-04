using System;
using System.Windows.Forms;
using System.Collections;


namespace hafta4_odev1_hesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ArrayList islemKayitAlanı = new ArrayList();

        private void button_clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.op.Text = " ";
            this.sonuc.Text = " ";
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            // string.Join() metodu kullanarak kayıt listemdeki değerleri birleştirdim çünkü MessageBox yapısı sadece bir metin gösterdiğini fark ettim.
            // Böylece tüm liste içindeki değerler tek bir metin haline geldi. Onu da Show metodu ile Box'a bastım. 
            // Environment.NewLine yapısını da satır atlamak için kullandım, hepsini yan yana eklemek istemedim.
            string mesaj = string.Join(Environment.NewLine, islemKayitAlanı.ToArray());
            MessageBox.Show(mesaj, "İşlem Kaydı");
        }

        // Trigonometrik metotlar işlemi radyan cinsinden alır. Kullanıcıdan radyan değer isteyemem.
        // Bu yüzden Radyan Derece dönüşümü yaptım. Matematiksel olarak: D/360 = R/2π 
        
        private void button_sin_Click(object sender, EventArgs e)
        {
            this.op.Text = "sin(x)";
            double derece = Convert.ToDouble(textBox1.Text);
            double radyan = Math.PI * derece / 180;
            this.sonuc.Text = Math.Sin(radyan).ToString();

            object kayit = String.Format("sin({0}) = {1}", derece, Math.Sin(radyan));
            islemKayitAlanı.Add(kayit);
        }
        private void button_cos_Click(object sender, EventArgs e)
        {
            this.op.Text = "cos(x)";
            double derece = Convert.ToDouble(textBox1.Text);
            double radyan = Math.PI * derece / 180;
            this.sonuc.Text = Math.Cos(radyan).ToString();

            object kayit = String.Format("cos({0}) = {1}", derece, Math.Cos(radyan));
            islemKayitAlanı.Add(kayit);
        }
        private void button_tan_Click(object sender, EventArgs e)
        {
            this.op.Text = "tan(x)";
            double derece = Convert.ToDouble(textBox1.Text);
            double radyan = Math.PI * derece / 180;
            this.sonuc.Text = Math.Tan(radyan).ToString();

            object kayit = String.Format("tan({0}) = {1}", derece, Math.Tan(radyan));
            islemKayitAlanı.Add(kayit);
        }
        private void button_cot_Click(object sender, EventArgs e)
        {
            this.op.Text = "cot(x)";
            double derece = Convert.ToDouble(textBox1.Text);
            double radyan = Math.PI * derece / 180;
            this.sonuc.Text = (1 / Math.Tan(radyan)).ToString();

            object kayit = String.Format("cos({0}) = {1}", derece, (1 / Math.Tan(radyan)));
            islemKayitAlanı.Add(kayit);
        }
        private void button_sec_Click(object sender, EventArgs e)
        {
            this.op.Text = "sec(x)";
            double derece = Convert.ToDouble(textBox1.Text);
            double radyan = Math.PI * derece / 180;
            this.sonuc.Text = (1 / Math.Cos(radyan)).ToString();

            object kayit = String.Format("sec({0}) = {1}", derece, (1 / Math.Cos(radyan)));
            islemKayitAlanı.Add(kayit);
        }
        private void button_csc_Click(object sender, EventArgs e)
        {
            this.op.Text = "csc(x)";
            double derece = Convert.ToDouble(textBox1.Text);
            double radyan = Math.PI * derece / 180;
            this.sonuc.Text = (1 / Math.Sin(radyan)).ToString();

            object kayit = String.Format("csc({0}) = {1}", derece, (1 / Math.Sin(radyan)));
            islemKayitAlanı.Add(kayit);
        }
        private void button_toplam_Click(object sender, EventArgs e)
        {
            this.op.Text = "+";
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            this.sonuc.Text = (sayi1 + sayi2).ToString();

            string kayit = String.Format("{0} + {1} = {2}", sayi1, sayi2, (sayi1 + sayi2));
            islemKayitAlanı.Add(kayit);
        }
        private void button_cikartma_Click(object sender, EventArgs e)
        {
            this.op.Text = "-";
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            this.sonuc.Text = (sayi1 - sayi2).ToString();

            object kayit = String.Format("{0} - {1} = {2}", sayi1, sayi2, (sayi1 - sayi2));
            islemKayitAlanı.Add(kayit);
        }
        private void button_carpim_Click(object sender, EventArgs e)
        {
            this.op.Text = "×";
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            this.sonuc.Text = (sayi1 * sayi2).ToString();

            object kayit = String.Format("{0} * {1} = {2}", sayi1, sayi2, (sayi1 * sayi2));
            islemKayitAlanı.Add(kayit);
        }
        private void button_bolme_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;
            op.Text = "÷";
            if (textBox1.Text == "0" && textBox2.Text == "0")
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
                sonuc.Text = "BELİRSİZ";
            }
            else if (textBox2.Text == "0")
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
                sonuc.Text = "TANIMSIZ";
            }
            else
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                 sayi2 = Convert.ToDouble(textBox2.Text);
                this.sonuc.Text = (sayi1 / sayi2).ToString();
            }

            object kayit = String.Format("{0} ÷ {1} = {2}", sayi1, sayi2, this.sonuc.Text);
            islemKayitAlanı.Add(kayit);
        }
        private void button_mod_Click(object sender, EventArgs e)
        {
            this.op.Text = "mod";
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            this.sonuc.Text = (sayi1 % sayi2).ToString();

            object kayit = String.Format("{0} değerinin {1} değerine bölümünden kalan = {2}", sayi1, sayi2, this.sonuc.Text);
            islemKayitAlanı.Add(kayit);
        }
        private void button_uslu_Click(object sender, EventArgs e)
        {
            op.Text = "xʸ";
            sonuc.Text = Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();

            object kayit = String.Format("{0}^{1} = {2}", textBox1.Text, textBox2.Text, this.sonuc.Text);
            islemKayitAlanı.Add(kayit);
        }
        private void button_kok_Click(object sender, EventArgs e)   
        {
            op.Text = "√x";
            sonuc.Text = Math.Sqrt(Convert.ToDouble(textBox1.Text)).ToString();

            object kayit = String.Format("√{0} = {1}", textBox1.Text, sonuc.Text);
            islemKayitAlanı.Add(kayit);
        }
        private void button_kokgenel_Click(object sender, EventArgs e)
        {
            op.Text = "y√x";
            sonuc.Text = Math.Pow(Convert.ToDouble(textBox1.Text), 1 / Convert.ToDouble(textBox2.Text)).ToString();

            object kayit = String.Format("{0}√{1} = {2}", textBox2.Text, textBox1.Text, sonuc.Text);
            islemKayitAlanı.Add(kayit);
        }
        private void button_mutlak_Click(object sender, EventArgs e)
        {
            op.Text = "|x|";
            sonuc.Text = Math.Abs(Convert.ToDouble(textBox1.Text)).ToString();

            object kayit = String.Format("|{0}| = {1}", textBox1.Text, sonuc.Text);
            islemKayitAlanı.Add(kayit);
        }
        private void button_fakt_Click(object sender, EventArgs e)
        {
            op.Text = "x!";
            double fakt = 1;
            for (int i = 1; i <= Convert.ToDouble(textBox1.Text); i++)
                fakt *= i;

            sonuc.Text = fakt.ToString();

            object kayit = String.Format("{0}! = {1}", textBox1.Text, fakt);
            islemKayitAlanı.Add(kayit);
        }
        private void button_log_Click(object sender, EventArgs e)
        {
            op.Text = "logx^y";
            sonuc.Text = Math.Log(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text)).ToString();

            object kayit = String.Format("log{0}^{1} = {2}", textBox1.Text, textBox2.Text, sonuc.Text);
            islemKayitAlanı.Add(kayit);
        }
        private void button_ln_Click(object sender, EventArgs e)
        {
            op.Text = "lnx";
            sonuc.Text = Math.Log(Convert.ToDouble(textBox1.Text)).ToString();

            object kayit = String.Format("ln{0} = {1}", textBox1.Text, sonuc.Text);
            islemKayitAlanı.Add(kayit);
        }



        private void op_Click(object sender, EventArgs e)
        {

        }
        private void deger1_Click(object sender, EventArgs e)
        {

        }
    }
}
