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

namespace Do_Min_v._2._0
{
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();
        }
        private void Load_Sql()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NBO6IVB;Initial Catalog=ScoreData;Integrated Security=True"))
            {
                con.Open();
                string sql = "select * from BangDiem";
                SqlCommand commandsql = new SqlCommand(sql, con);//Thuc thi cac chuc nang cau lenh trong sql
                SqlDataAdapter com = new SqlDataAdapter(commandsql);//Van chuyen du lieu
                DataTable table = new DataTable();//tao bang ao 
                com.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scoreDataDataSet3.BangDiem' table. You can move, or remove it, as needed.
            this.bangDiemTableAdapter1.Fill(this.scoreDataDataSet3.BangDiem);                     
            Load_Sql();
        }
    }
}
