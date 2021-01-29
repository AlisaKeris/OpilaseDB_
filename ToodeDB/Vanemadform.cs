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
	public partial class Vanemadform : Form
	{
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\Source\Repos\OpilaseDB2\ToodeDB\AppData\Opilased.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter, adapter2;
        int Id = 0;
        public Vanemadform()
		{
			InitializeComponent();
		}
        private void DisplayData()
        {
            connect.Open();
            DataTable tabel = new DataTable();

            adapter = new SqlDataAdapter("SELECT * FROM Vanemad", connect);
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;
            /*adapter2 = new SqlDataAdapter("SELECT Id FROM Opilased", connect);
            DataTable kak_tabel = new DataTable();
            adapter2.Fill(kak_tabel);
            foreach (DataRow row in kak_tabel.Rows)
            {
                lapsbox.Items.Add(row["Id"]);
            }

            connect.Close();*/
        }
        private void ClearData()
        {
            Id = 0;
            vannimitxt.Text = "";
            vangmtxt.Text = "";
            vanteltxt.Text = "";
        }
        private void btnvanInsert_Click(object sender, EventArgs e)
		{
            if (vannimitxt.Text != "" && vangmtxt.Text != "" && vanteltxt.Text != "" && lapsbox.SelectedItem != "")
            {
                try
                {
                    command = new SqlCommand("INSERT INTO Vanemad(Nimi,Tel,Gmailv,Opilane) values(@nimi,@tel,@gmailv,@laps)", connect);
                    connect.Open();
                    command.Parameters.AddWithValue("@nimi", vannimitxt.Text);
                    command.Parameters.AddWithValue("@Gmailv", vangmtxt.Text);
                    command.Parameters.AddWithValue("@tel", vanteltxt.Text);
                    
                    command.Parameters.AddWithValue("@rühm", (lapsbox.SelectedIndex + 1));
                    command.ExecuteNonQuery();
                    connect.Close();
                    DisplayData();
                    ClearData();
                    MessageBox.Show("Andmed on lisatud");
                }
                catch (Exception)
                {

                    MessageBox.Show("Viga lisamisega");
                }
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

		private void btnvanUpdate_Click(object sender, EventArgs e)
		{
            if (vannimitxt.Text != "" && vangmtxt.Text != "" && vanteltxt.Text != "" && lapsbox.SelectedItem != "")
            {
                command = new SqlCommand("INSERT INTO Vanemad(Nimi,Tel,Gmailv,Opilane) values(@nimi,@tel,@gmailv,@laps)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@nimi", vannimitxt.Text);
                command.Parameters.AddWithValue("@Gmailv", vangmtxt.Text);
                command.Parameters.AddWithValue("@tel", vanteltxt.Text);

                command.Parameters.AddWithValue("@rühm", (lapsbox.SelectedIndex + 1));
                //command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on lisatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

		private void btnvanDelete_Click(object sender, EventArgs e)
		{
            if (Id != 0)
            {
                command = new SqlCommand("DELETE Vanemad WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);


                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on kustutatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

		private void Opilasedbtn_Click(object sender, EventArgs e)
		{
            Form1 opilased = new Form1();
            opilased.Show();
            
        }
	}
}
