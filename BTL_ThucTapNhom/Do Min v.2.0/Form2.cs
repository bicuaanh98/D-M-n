using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Do_Min_v._2._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void confirmBut_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NBO6IVB;Initial Catalog=ScoreData;Integrated Security=True");
            TimeSpan time = TimeSpan.Parse(Form1.GetThoiGian());
            con.Open();
            string sqlInsert = "Insert Into BangDiem values (@Ten,@Thoigian) ";
            SqlCommand cmd = new SqlCommand(sqlInsert, con);
            cmd.Parameters.AddWithValue("Ten",nameBox.Text);
            cmd.Parameters.AddWithValue("Thoigian",time);
            cmd.ExecuteNonQuery();
            Close();
            ScoreBoard board = new ScoreBoard();
            board.Show();
        }
        
        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            confirmBut.Enabled = true;
        }
    }
}
