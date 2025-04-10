namespace ArabaBilgiFormu
{
    public partial class Form1 : Form
    {
        // Deðiþkenin veri türünü belirliyoruz
        string marka;
        string model;
        string renk;
        int KapiSayisi;
        int PencereSayisi;
        double YaktiðiYakit;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanýcýnýn bilgileri yazmasýný saðladým.
            marka = txtMarka.Text;
            model = txtModel.Text;
            renk = txtRenk.Text;
            KapiSayisi = Convert.ToInt16(txtKapiSayisi.Text);
            PencereSayisi = Convert.ToInt16(txtPencereSayisi.Text);
            YaktiðiYakit = Convert.ToDouble(txtYakit.Text);
            listBox1.Items.Add("Marka:" + marka + " / Model:" + model + " / Renk:" + renk  +" / Kapý sayýsý:" +KapiSayisi
                +" / Pencere sayýsý:" + PencereSayisi+ "/ 100 km'de yaktýðý yakýt:" +YaktiðiYakit   );

            // ListBox a elemanlarý manuel olarak ekledim.
            listBox1.Items.Add("Marka:Porche" + " / Model:Macan" + " / Renk:Siyah" + " / Kapý sayýsý:4" + " / Pencere sayýsý:4"
                + " / 100 km'de yaktýðý yakýt:9.5");

        }
    }
}
