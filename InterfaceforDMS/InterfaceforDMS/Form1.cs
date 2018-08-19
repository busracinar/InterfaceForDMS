using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace InterfaceforDMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\musteriarama.accdb");
        DataTable tablo = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from musteriarama",baglanti);
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)       {

        }
    }
}
