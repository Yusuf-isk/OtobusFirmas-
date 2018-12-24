using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace OtobusFirması
{
    public partial class UyeGiris : Form
    {
        public UyeGiris()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source=LENOVO-PC;Initial Catalog=otobusfirma;Integrated Security=True");
        private void AdminGiris_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            if (Form1.uyemi == false)
            {
                if (groupBoxUye.Visible == false||groupBoxUye.Visible==true) groupBoxUye.Visible = true;
            }
            if (Form1.uyemi == true)
            {
                if (groupBoxUye.Visible == false || groupBoxUye.Visible == true) groupBoxUye.Visible = false;
            }
            bagla.Open();
            string sorgu1 = "select nerden from Seferler group by nerden";
            //string sorgu1 = "select distinct nerden from Seferler";
            SqlCommand cmd = new SqlCommand(sorgu1, bagla);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboNereden.Items.Add(dr["nerden"]);
            }
            dr.Close();
            bagla.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bagla.Open();
            comboNereye.Items.Clear();
            string sorgu1 = "select distinct nereye from Seferler where nerden='"+comboNereden.Text.ToString()+"'";
            SqlCommand cmd = new SqlCommand(sorgu1,bagla);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboNereye.Items.Add(dr["nereye"]);
            }
            dr.Close();
            bagla.Close();
        }
        private void comboNereye_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string seferNo ="";
        DataTable dataTableSefer = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            bagla.Open();
           
            string sorgu = "select * from Seferler where nerden=@nerden and nereye=@nereye and tarih=@tarih";
            SqlParameter sqlParametersefer1 = new SqlParameter("nerden", comboNereden.Text);
            SqlParameter sqlParametersefer2 = new SqlParameter("nereye", comboNereye.Text);
            SqlParameter sqlParametersefer3 = new SqlParameter("tarih", dateTimePicker1.Text);
            SqlCommand sqlCommand1 = new SqlCommand(sorgu, bagla);
            sqlCommand1.Parameters.Add(sqlParametersefer1);
            sqlCommand1.Parameters.Add(sqlParametersefer2);
            sqlCommand1.Parameters.Add(sqlParametersefer3);
            SqlDataAdapter seferler = new SqlDataAdapter(sqlCommand1);
            seferler.Fill(dataTableSefer);
            int konum_x = 800, konum_y = 100;
            Label[] label= new Label[100];
            for (int i = 0; i < 100; i++)
            {
                label[i] = new Label();
                label[i].Text = "";
            }
            Button[] button = new Button[100];
            for (int i = 1; i <=dataTableSefer.Rows.Count; i++)
            {
                for (int j = 1; j <=7; j++)
                {
                    label[j] = new Label();
                    this.Controls.Add(label[j]);
                    label[j].Name = "label" + j;
                    label[j].Text = dataTableSefer.Rows[i-1][j-1].ToString();
                    label[j].Size = new Size(70, 20);
                    label[j].Location = new Point(konum_x, konum_y);
                    konum_x = konum_x + 70;
                    if (j % 7 == 0 && j > 1)
                    {
                        button[i] = new Button();
                        this.Controls.Add(button[i]);
                        button[i].Name = "button" + i;
                        button[i].Text = "Seç";
                        button[i].Size = new Size(70, 20);
                        button[i].Location = new Point(konum_x, konum_y);
                        button[i].Click += new EventHandler(tiklama);
                        seferNo=dataTableSefer.Rows[i-1][0].ToString();
                        konum_x = 800;
                        konum_y = 100;
                        konum_y = konum_y + 50;
                    }
                }
            }
            bagla.Close();
        }
        public void tiklama(object sender,EventArgs e)
        {
            bagla.Open();
            groupKoltuk.Visible = true;
            string bos = ((Button)sender).Name;
            bos = bos.Substring(6);
            int bosi = Convert.ToInt32(bos);
            seferNo = dataTableSefer.Rows[bosi - 1][0].ToString();
            string sorgu1 = "select koltuk,cins,s.seferNo from biletSatis as bs inner join Seferler as s on bs.seferNo=s.seferNo inner join Uyeler as u on u.uyeNo = bs.uyeNo where s.seferNo = @seferNo";
            SqlParameter sqlparametre1 = new SqlParameter("seferNo", seferNo);
            SqlCommand cmd = new SqlCommand(sorgu1,bagla);
            cmd.Parameters.Add(sqlparametre1);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(sorgu1);
            da.Fill(dt);
            PictureBox[] picture = new PictureBox[43];
            int x = 20;int y = 30;
            for (int i = 1; i <picture.Length; i++)
            {
                picture[i] = new PictureBox();
                Controls.Add(picture[i]);
                groupKoltuk.Controls.Add(picture[i]);
                picture[i].Name = "pictureBox" + i.ToString();picture[i].Size = new Size(35,35);
                picture[i].SizeMode =PictureBoxSizeMode.Zoom;
                picture[i].Image = Image.FromFile("C:\\Users\\furkan\\Desktop\\Üniversite\\OtobusFirması\\OtobusFirması\\Resources\\koltuk.png");
                picture[i].Location = new Point(x, y);
                picture[i].Visible =true;
                x = x + 50;
                if(i%3==0 && i>1)
                {
                    x = 20;y = 30;
                    y = y + 50;
                }
            }        
            bagla.Close();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {  
            //bilet alma fonksiyonu
            if (Form1.uyemi == false)
             {
                bagla.Open();
                if ((textBoxAd.Text!=""&& (textBoxTC.Text!="" && textBoxTC.Text.Trim().Length==11))&&(radioButtonE.Checked||radioButtonK.Checked))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = bagla;
                    cmd.CommandText = "UyeEkle";
                    cmd.Parameters.Add("@ad",SqlDbType.VarChar,50);
                    cmd.Parameters["@ad"].Value = textBoxAd.Text;
                    cmd.Parameters.Add("@TCNO",SqlDbType.VarChar,11);
                    cmd.Parameters["@TCNO"].Value = textBoxTC.Text;
                    cmd.Parameters.Add("@cins",SqlDbType.Char,1);
                    if (radioButtonE.Checked){
                    cmd.Parameters["@cins"].Value = 'E';}
                    if (radioButtonK.Checked)
                    {
                         cmd.Parameters["@cins"].Value = 'K';  }
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    Form1.uyeNo = Convert.ToInt32(dt.Rows[0][0].ToString());
                    bagla.Close();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {}
        private void pictureBox1_Click(object sender, EventArgs e)
        {}
        private void groupBox2_Enter(object sender, EventArgs e)
        {}
        private void groupBox1_Enter(object sender, EventArgs e)
        { }
        private void button3_Click(object sender, EventArgs e)
        {}
        private void button4_Click(object sender, EventArgs e)
        { }

        private void v(object sender, EventArgs e)
        { }

        private void pictureBox43_Click(object sender, EventArgs e)
        { MessageBox.Show("Erkek Resim"); }

        private void pictureBox44_Click(object sender, EventArgs e)
        { MessageBox.Show("Kadın Resim"); }

        private void pictureBox45_Click(object sender, EventArgs e)
        { MessageBox.Show("Rezervesyon Resim"); }
    }
}
