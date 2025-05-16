using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneKayitFormu
{
    public partial class Form1 : Form
    {
        // Veritabanı bağlantı dizesi
        string connectionString = @"Data Source=LAPTOP-7FOARPM6;Initial Catalog=RandevuSistemi;Integrated Security=SSPI;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                BranslariListele();
                SaatleriYukle();
                RandevulariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yükleme Hatası: " + ex.Message);
            }
        }

        // Branşları ComboBox'a yükleme
        void BranslariListele()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Branslar", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbBrans.DataSource = dt;
                    cmbBrans.DisplayMember = "BransAdi";
                    cmbBrans.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Branş Yükleme Hatası: " + ex.Message);
            }
        }

        // Doktorları ComboBox'a yükleme
        void DoktorlariListele(int bransId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM Doktorlar WHERE BransID={bransId}", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbDoktor.DataSource = dt;
                    cmbDoktor.DisplayMember = "DoktorAdi";
                    cmbDoktor.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktor Yükleme Hatası: " + ex.Message);
            }
        }

        // Branş seçildiğinde doktorları listeleme
        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrans.SelectedValue is int bransId)
            {
                DoktorlariListele(bransId);
            }
        }

        // Randevu saatlerini yükleme
        void SaatleriYukle()
        {
            string[] saatler = { "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00" };
            cmbSaat.Items.AddRange(saatler);
            cmbSaat.SelectedIndex = 0;
        }

        // Randevuları DataGridView üzerinde listeleme
        void RandevulariListele()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT r.HastaAdi, r.HastaSoyadi, b.BransAdi, d.DoktorAdi, r.Tarih " +
                        "FROM Randevular r " +
                        "JOIN Branslar b ON r.BransID = b.Id " +
                        "JOIN Doktorlar d ON r.DoktorID = d.Id", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu Listeleme Hatası: " + ex.Message);
            }
        }

        // Randevu oluşturma
        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHastaAdi.Text) || string.IsNullOrWhiteSpace(txtHastaSoyadi.Text))
            {
                MessageBox.Show("Hasta adı ve soyadı boş bırakılamaz!");
                return;
            }

            int bransId = Convert.ToInt32(cmbBrans.SelectedValue);
            int doktorId = Convert.ToInt32(cmbDoktor.SelectedValue);
            DateTime tarih = dtpTarih.Value.Date.Add(TimeSpan.Parse(cmbSaat.Text));

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Randevu çakışma kontrolü
                    SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Randevular WHERE DoktorID=@doktorId AND Tarih=@tarih", con);
                    checkCmd.Parameters.AddWithValue("@doktorId", doktorId);
                    checkCmd.Parameters.AddWithValue("@tarih", tarih);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Bu doktor için bu tarihte randevu zaten var!");
                        return;
                    }

                    // Randevu kaydı
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih) " +
                        "VALUES (@adi, @soyadi, @bransId, @doktorId, @tarih)", con);
                    cmd.Parameters.AddWithValue("@adi", txtHastaAdi.Text);
                    cmd.Parameters.AddWithValue("@soyadi", txtHastaSoyadi.Text);
                    cmd.Parameters.AddWithValue("@bransId", bransId);
                    cmd.Parameters.AddWithValue("@doktorId", doktorId);
                    cmd.Parameters.AddWithValue("@tarih", tarih);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Randevu başarıyla oluşturuldu!");
                    RandevulariListele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu Oluşturma Hatası: " + ex.Message);
            }
        }
    }
}
