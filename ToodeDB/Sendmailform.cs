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

namespace ToodeDB
{
	public partial class Sendmailform : Form
	{
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\Source\Repos\OpilaseDB2\ToodeDB\AppData\Opilased.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        public Sendmailform()
		{
			InitializeComponent();
            this.Text = "Uus sõnum";
        }
        

        private void sonumbtn_Click(object sender, EventArgs e)
		{
            
        }

		

		private void taiskas_CheckedChanged(object sender, EventArgs e)
		{
            if (taiskas.Checked)
            {
                connect.Open();


                adapter = new SqlDataAdapter("SELECT Gmail FROM Opilased", connect);
                DataTable kak_tabel = new DataTable();
                adapter.Fill(kak_tabel);
                foreach (DataRow row in kak_tabel.Rows)
                {
                    boxle.Items.Add(row["Gmail"]);
                }
                connect.Close();
            }
            else
            {
                connect.Open();


                adapter = new SqlDataAdapter("SELECT Gmailv FROM Vanemad", connect);
                DataTable kak_tabel = new DataTable();
                adapter.Fill(kak_tabel);
                foreach (DataRow row in kak_tabel.Rows)
                {
                    boxle.Items.Add(row["Gmailv"]);
                }
                connect.Close();
            }
        }
	}
}
