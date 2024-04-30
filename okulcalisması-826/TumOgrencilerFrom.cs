using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace okulcalisması_826
{
    public partial class TumOgrencilerFrom : Form
    {
        string baglanti = "Server=localhost;Database=hnk_okul;Uid=root;Pwd=;";
        public TumOgrencilerFrom()
        {
            InitializeComponent();
        }

        private void TumOgrencilerFrom_Load(object sender, EventArgs e)
        {
            DgwDoldur();
            CmbDoldur();
        }
        void DgwDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM ogrenci;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();




                da.Fill(dt);
                dgwOgrenciler.DataSource = dt;

            }
        }

        void CmbDoldur()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("cinsiyet",typeof(string));
            dt.Columns.Add("KisaAd", typeof(string));

            dt.Rows.Add("kız mı","K");
            dt.Rows.Add("Erkek mi", "E");

            cmbCinsiyet.DataSource = dt;

            cmbCinsiyet.DisplayMember = "cinsiyet";   //ekranda kullanıcı görür
            cmbCinsiyet.ValueMember = "KisaAd";     //veritabanına kayıt edilir

        }

        private void dgwOgrenciler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwOgrenciler.SelectedRows.Count > 0)
            {
                txtAd.Text = dgwOgrenciler.SelectedRows[0].Cells["ad"].Value.ToString();
                txtSoyad.Text = dgwOgrenciler.SelectedRows[0].Cells["soyad"].Value.ToString();
                dTarih.Value = Convert.ToDateTime(dgwOgrenciler.SelectedRows[0].Cells["dTarih"].Value);
                cbMezun.Checked = Convert.ToBoolean(dgwOgrenciler.SelectedRows[0].Cells["mezun_durum"].Value);
                cmbCinsiyet.SelectedValue = (dgwOgrenciler.SelectedRows[0].Cells["cinsiyet"].Value);



            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgwOgrenciler.SelectedRows[0];
            int satirId = Convert.ToInt32(dr.Cells["okul_no"].Value);

            DialogResult cevap = MessageBox.Show("öğrenciyi Silmek İstediğinizden Emin Misiniz?",
                                "öğrenci Sil",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error);

            if (cevap == DialogResult.Yes)
            {

                string sorgu = "DELETE FROM ogrenci where okul_no = @satirid;";

                using (MySqlConnection baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    cmd.Parameters.AddWithValue("@satirid", satirId);
                    cmd.ExecuteNonQuery();

                    DgwDoldur(); //tekrar doldurur
                }
            }
        }
    }   
}
