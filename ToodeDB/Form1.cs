using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToodeDB
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\Source\Repos\OpilaseDB2\ToodeDB\AppData\Opilased.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        int Id = 0;
        
    public Form1()
        {
            InitializeComponent();
            dataGridView1.RowHeaderMouseClick += DataGridView1_RowHeaderMouseClick;
            this.Text = "Õpilased";
            
           
        }

        

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Nimitxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            gmtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Teltxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            box_ruhm.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //picBox.Image = Image.FromFile(@"C:\Users\opilane\source\repos\OpilaseDB2\ToodeDB\images" + dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            
        }

        private void DisplayData()
        {
            connect.Open();
            DataTable tabel = new DataTable();

            adapter = new SqlDataAdapter("SELECT * FROM Opilased", connect);
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;


            connect.Close();
        }
        private void ClearData()
        {
            Id = 0;
            Nimitxt.Text = "";
            gmtxt.Text = "";
            Teltxt.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Toodetable' table. You can move, or remove it, as needed.
            this.toodetableTableAdapter.Fill(this.database1DataSet.Toodetable);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Nimitxt.Text != "" && gmtxt.Text != "" && Teltxt.Text != "" && box_ruhm.SelectedItem != "")
            {
                try
                {
                    command = new SqlCommand("INSERT INTO Opilased(Nimi,Gmail,Tel,Rühm,Pilt) values(@nimi,@Gmail,@Tel,@rühm,@pilt)", connect);
                    connect.Open();
                    command.Parameters.AddWithValue("@nimi", Nimitxt.Text);
                    command.Parameters.AddWithValue("@Gmail", gmtxt.Text);
                    command.Parameters.AddWithValue("@Tel", Teltxt.Text);
                    string file_pilt = Nimitxt.Text + ".jpg";
                    command.Parameters.AddWithValue("@pilt", file_pilt);
                    command.Parameters.AddWithValue("@rühm", (box_ruhm.SelectedIndex + 1));
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Nimitxt.Text != "" && gmtxt.Text != "" && Teltxt.Text != "" && box_ruhm.SelectedItem != "")
            {
                command = new SqlCommand("INSERT INTO Opilased(Nimi,Gmail,Tel,Rühm,Pilt) values(@nimi,@Gmail,@Tel,@rühm,@pilt)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@nimi", Nimitxt.Text);
                command.Parameters.AddWithValue("@Gmail", gmtxt);
                command.Parameters.AddWithValue("@Tel", Teltxt.Text);
                string file_pilt = Nimitxt.Text + ".jpg";
                command.Parameters.AddWithValue("@pilt", file_pilt);
                command.Parameters.AddWithValue("@rühm", (box_ruhm.SelectedIndex + 1));
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                command = new SqlCommand("DELETE Opilased WHERE Id=@id", connect);
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


        private void btnLisapilt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = Nimitxt.Text + "_" + Id;
                save.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                save.InitialDirectory = Path.GetFullPath(@"C:\Users\opilane\source\repos\ToodeDB\ToodeDB\images");
                if (save.ShowDialog() == DialogResult.OK)
                {
					File.Copy(open.FileName, save.FileName);
                    save.RestoreDirectory = true;
                    picBox.Image = Image.FromFile(save.FileName);

                }

            }
        }

		

		private void sonum_Click(object sender, EventArgs e)
		{

            Sendmailform sendmail = new Sendmailform();
            sendmail.Show();
        }

		private void vanemadbtn_Click(object sender, EventArgs e)
		{
            Vanemadform vanemad = new Vanemadform();
            vanemad.Show();
        }
	}
}
