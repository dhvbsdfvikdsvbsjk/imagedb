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

namespace waitingforyou
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-B9NL3QIJ\SQLEXPRESS;Initial Catalog=imagedb;Integrated Security=True");
        string imgLocation = "";
        SqlCommand cmd;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sotoDataSet1.fas". При необходимости она может быть перемещена или удалена.
            this.fasTableAdapter1.Fill(this.sotoDataSet1.fas);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sotoDataSet.fas". При необходимости она может быть перемещена или удалена.
            this.fasTableAdapter.Fill(this.sotoDataSet.fas);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vremenDataSet.Bayebat". При необходимости она может быть перемещена или удалена.
            this.bayebatTableAdapter.Fill(this.vremenDataSet.Bayebat);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog()== DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;
                FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);
                con.Open();
                string sqlQuery = "Insert into gde(name,dop,umage)Values('" + textBox1.Text + "','" + textBox2.Text + "',@images)";
                cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int n = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(n.ToString() + " pamagite ya tak ne mogy mne ploho");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                


            }catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select name,umage from gde where name='" + textBox1.Text + "'";
                if(con.State != ConnectionState.Open)
                {
                    con.Open();
                    cmd = new SqlCommand(sql, con);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if(reader.HasRows)
                    {
                        textBox2.Text = reader[0].ToString();
                        byte[] img = (byte[])(reader[1]);

                        if(img == null)
                        {
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("ytey");
                    }
                }
            }catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
