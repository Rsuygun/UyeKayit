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

namespace UyeTakip
{

    //Data Source=RSUYGUN\SQLEXPRESS;Initial Catalog=UyeTakip;Integrated Security=True;Pooling=False
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=RSUYGUN\\SQLEXPRESS;Initial Catalog=UyeTakip;Integrated Security=True;Pooling=False");

        public void Form1_Load(object sender, EventArgs e)
        {
            this.uyeTakipTabloTableAdapter.Fill(this.uyeTakipDataSet.UyeTakipTablo);
        }

        public void btnListele_Click(object sender, EventArgs e)
        {
            this.uyeTakipTabloTableAdapter.Fill(this.uyeTakipDataSet.UyeTakipTablo);
        }



        public void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into UyeTakipTablo ([Lid. Nr.], [Naam Deelnemer], [E-mail Adres], Ardes, [Date Lidm.], [2012], [2013], [2014], [2015], [2016], [2017], [2018], [2019], [2020], [2021], [2022], [2023], [2024], [2025], [2026], [2027], [2028], [2029], [2030]) values (@[Lid. Nr.], @[Naam Deelnemer], @[E-mail Adres], @Ardes, @[Date Lidm.], @[2012], @[2013], @[2014], @[2015], @[2016], @[2017], @[2018], @[2019], @[2020], @[2021], @[2022], @[2023], @[2024], @[2025], @[2026], @[2027], @[2028], @[2029], @[2030])", con);
            con.Open();
            komut.Parameters.AddWithValue("@[Lid. Nr.]", txtIdNum);
            komut.Parameters.AddWithValue("@[Naam Deelnemer]", txtAdSoyad);
            komut.Parameters.AddWithValue("@[E-mail Adres]", txtEMail);
            komut.Parameters.AddWithValue("@Ardes", txtAdres);
            komut.Parameters.AddWithValue("@[Date Lidm.]", dateTimePicker1);
            komut.Parameters.AddWithValue("@[2012], @[2013], @[2014], @[2015], @[2016], @[2017], @[2018], @[2019], @[2020], @[2021], @[2022]", txtUcret);
            komut.Parameters.AddWithValue("@[2023], @[2024], @[2025], @[2026], @[2027], @[2028], @[2029], @[2030]", txtUcret);
            komut.Parameters.AddWithValue("@[2012], @[2013], @[2014], @[2015], @[2016], @[2017], @[2018], @[2019], @[2020], @[2021], @[2022]", comboBox1);
            komut.Parameters.AddWithValue("@[2023], @[2024], @[2025], @[2026], @[2027], @[2028], @[2029], @[2030]", comboBox1);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Üye Eklendi");
        }
    }
}
