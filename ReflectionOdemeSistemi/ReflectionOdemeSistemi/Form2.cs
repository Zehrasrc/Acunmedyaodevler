using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionOdemeSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // Reflection ile IOdemeYontemi'ni implement eden sınıfları bulalım
            var odemeYontemleri = typeof(IOdemeYontemi).Assembly.GetTypes()
                .Where(t => typeof(IOdemeYontemi).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToList();

            // Bu sınıfları ComboBox'a ekleyelim
            comboBox1.DataSource = odemeYontemleri;
            comboBox1.DisplayMember = "Name";  // ComboBox'ta sınıf isimlerini göster
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    labelSonuc.Text = "Lütfen bir ödeme yöntemi seçin.";
                    return;
                }

                if (!decimal.TryParse(textBoxTutar.Text, out decimal tutar))
                {
                    labelSonuc.Text = "Geçerli bir tutar girin.";
                    return;
                }

                // ComboBox'dan seçilen tipi alıyoruz
                Type secilenTip = (Type)comboBox1.SelectedItem;

                // Activator.CreateInstance ile nesne oluşturuyoruz
                IOdemeYontemi odeme = (IOdemeYontemi)Activator.CreateInstance(secilenTip);

                // Ode metodunu çağırıyoruz ve sonucu label'da gösteriyoruz
                string sonuc = odeme.Ode(tutar);

                labelSonuc.Text = sonuc;  // Ödeme sonucunu Label'da gösteriyoruz
            }
            catch (Exception ex)
            {
                labelSonuc.Text = "Hata: " + ex.Message;
            }
        }
    }
}

