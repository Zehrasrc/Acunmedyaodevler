namespace ArabaBilgiFormu
{
    public partial class Form1 : Form
    {
        // De�i�kenin veri t�r�n� belirliyoruz
        string marka;
        string model;
        string renk;
        int KapiSayisi;
        int PencereSayisi;
        double Yakti�iYakit;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullan�c�n�n bilgileri yazmas�n� sa�lad�m.
            marka = txtMarka.Text;
            model = txtModel.Text;
            renk = txtRenk.Text;
            KapiSayisi = Convert.ToInt16(txtKapiSayisi.Text);
            PencereSayisi = Convert.ToInt16(txtPencereSayisi.Text);
            Yakti�iYakit = Convert.ToDouble(txtYakit.Text);
            listBox1.Items.Add("Marka:" + marka + " / Model:" + model + " / Renk:" + renk  +" / Kap� say�s�:" +KapiSayisi
                +" / Pencere say�s�:" + PencereSayisi+ "/ 100 km'de yakt��� yak�t:" +Yakti�iYakit   );

            // ListBox a elemanlar� manuel olarak ekledim.
            listBox1.Items.Add("Marka:Porche" + " / Model:Macan" + " / Renk:Siyah" + " / Kap� say�s�:4" + " / Pencere say�s�:4"
                + " / 100 km'de yakt��� yak�t:9.5");

        }
    }
}
