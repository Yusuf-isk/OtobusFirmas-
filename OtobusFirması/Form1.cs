using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtobusFirması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection();
        public static bool uyemi = false;
        public static int uyeNo;
        private void Form1_Load(object sender, EventArgs e)
        {
            bagla = new SqlConnection("Data Source=LENOVO-PC;Initial Catalog=otobusfirma;Integrated Security=True");
            bagla.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBoxKullanici.Text == null && textBoxSifre.Text == null)
            {
                MessageBox.Show("Kullanici sifre girinis...");
            }
            else {
                try
                {
                    string Sqlque1 = "SELECT uyeNo,TCNO,sifre FROM dbo.Uyeler WHERE TCNO=@TCNO AND sifre=@sifre";
                    SqlParameter sqlParameterogr1 = new SqlParameter("TCNO", textBoxKullanici.Text.Trim());
                    SqlParameter sqlParameterogr2 = new SqlParameter("sifre", textBoxSifre.Text.Trim());
                    SqlCommand sqlCommand1 = new SqlCommand(Sqlque1, bagla);
                    sqlCommand1.Parameters.Add(sqlParameterogr1);
                    sqlCommand1.Parameters.Add(sqlParameterogr2);
                    DataTable dataTableOgr1 = new DataTable();
                    SqlDataAdapter ogrenci = new SqlDataAdapter(sqlCommand1);
                    ogrenci.Fill(dataTableOgr1);
                    string Sqlque2 = "SELECT kullaniciAdi,sifre FROM dbo.Admins WHERE kullaniciAdi=@kullaniciAdi AND sifre=@sifre";
                    SqlParameter sqlParameterAdmin = new SqlParameter("kullaniciAdi", textBoxKullanici.Text.Trim());
                    SqlParameter sqlParameterAdmin1 = new SqlParameter("sifre", textBoxSifre.Text.Trim());
                    SqlCommand sqlCommand2 = new SqlCommand(Sqlque2, bagla);
                    sqlCommand2.Parameters.Add(sqlParameterAdmin);
                    sqlCommand2.Parameters.Add(sqlParameterAdmin1);
                    DataTable dataTableOgr2 = new DataTable();
                    SqlDataAdapter Admin = new SqlDataAdapter(sqlCommand2);
                    Admin.Fill(dataTableOgr2);
                    string Sqlque3 = "SELECT kullaniciAdi,sifre FROM dbo.Firma WHERE kullaniciAdi=@kullaniciAdi AND sifre=@sifre";
                    SqlParameter sqlParameterFirma = new SqlParameter("kullaniciAdi", textBoxKullanici.Text.Trim());
                    SqlParameter sqlParameterFirma1 = new SqlParameter("sifre", textBoxSifre.Text.Trim());
                    SqlCommand sqlCommand3 = new SqlCommand(Sqlque3, bagla);
                    sqlCommand3.Parameters.Add(sqlParameterFirma);
                    sqlCommand3.Parameters.Add(sqlParameterFirma1);
                    DataTable dataTableOgr3 = new DataTable();
                    SqlDataAdapter Firma = new SqlDataAdapter(sqlCommand3);
                    Firma.Fill(dataTableOgr3);
                    if (dataTableOgr1.Rows.Count > 0)
                    {
                        uyeNo = Convert.ToInt32(dataTableOgr1.Rows[0][0].ToString());
                        uyemi = true;
                        Form uyeler = new UyeGiris();
                        uyeler.Show();
                        this.Hide();
                        bagla.Close();
                    }
                    else if (dataTableOgr2.Rows.Count > 0)
                    {
                        Form adminler = new AdminGiris();
                        adminler.Show();
                        this.Hide();
                        bagla.Close();
                    }
                    else if (dataTableOgr3.Rows.Count > 0)
                    {
                        Form firmalar = new FirmaGiris();
                        firmalar.Show();
                        this.Hide();
                        bagla.Close();
                    }
                    else
                    {
                        MessageBox.Show("Yanlış Öğrenci Adı ve ya Kimlik Numarası!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bagla.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Beklenmeyen bir hata oluştu...");
                }
                
            }      
        }

        private void fghfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyemi = false;
            Form uyeler = new UyeGiris();
            uyeler.Show();
            this.Hide();
            bagla.Close();
        }
    }
}
