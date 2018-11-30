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
using System.IO;

namespace WindowsForm30
{
	public partial class Form2 : Form
	{
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\source\repos\WindowsForm30\WindowsForm30\Database1.mdf;Integrated Security=True");
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			con.Open();
			SqlCommand cmd = con.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "insert into Register values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +textBox4.Text+"','" +textBox5.Text+"','" + dateTimePicker1.Text + "')";
			cmd.ExecuteNonQuery();

			MessageBox.Show("saved");
		}

		private void button3_Click(object sender, EventArgs e)
		{

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox5.Text = openFileDialog1.FileName;

				textBox5.Text = Path.GetFileName(openFileDialog1.FileName);
				pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

			}

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
