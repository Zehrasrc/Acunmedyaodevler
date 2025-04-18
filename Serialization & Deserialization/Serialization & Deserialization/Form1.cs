using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization___Deserialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            try
            {
                // JSON dosyasını oku
                string jsonText = File.ReadAllText("urunler.json");

                List<Urun> urunler = JsonConvert.DeserializeObject<List<Urun>>(jsonText);

                listViewUrunler.Items.Clear();

                double toplamFiyat = 0;

                foreach (var urun in urunler)
                {
                    ListViewItem item = new ListViewItem(urun.UrunAdi);

                    string fiyatMetin = urun.Fiyat.ToString("N0") + " TL";

                    item.SubItems.Add(fiyatMetin);
                    item.SubItems.Add(urun.Kategori); 
                    item.SubItems.Add(urun.Aciklama);

                    listViewUrunler.Items.Add(item);

                    toplamFiyat += urun.Fiyat;
                }

                lblToplamFiyat.Text = toplamFiyat.ToString("N0") + " TL";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            try
            {
                string aramaTerimi = txtArama.Text.ToLower();

                if (!string.IsNullOrEmpty(aramaTerimi))
                {
                    string jsonText = File.ReadAllText(@"urunler.json");

                    List<Urun> urunler = JsonConvert.DeserializeObject<List<Urun>>(jsonText);

                    listViewUrunler.Items.Clear();

                    double toplamFiyat = 0;
                    bool urunBulundu = false;

                    foreach (var urun in urunler)
                    {
                        if (urun.UrunAdi.ToLower().Contains(aramaTerimi))
                        {
                            urunBulundu = true;

                            ListViewItem item = new ListViewItem(urun.UrunAdi);

                            string fiyatMetin = urun.Fiyat.ToString("N0") + " TL";

                            item.SubItems.Add(fiyatMetin);
                            item.SubItems.Add(urun.Kategori);
                            item.SubItems.Add(urun.Aciklama);

                            listViewUrunler.Items.Add(item);

                            toplamFiyat += urun.Fiyat;
                        }
                    }

                    if (!urunBulundu)
                    {
                        MessageBox.Show("Aradığınız ürüne ait herhangi bir sonuç bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        lblToplamFiyat.Text = "Toplam: " + toplamFiyat.ToString("N0") + " TL";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir ürün adı girin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);

            }
        }

       
    }
}
