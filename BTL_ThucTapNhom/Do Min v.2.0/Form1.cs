using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Do_Min_v._2._0

{
    public partial  class Form1 : Form
    {
        #region Biến toàn phần
        Image Img_cell = new Bitmap(Properties.Resources.img_cell, 25, 25);
        Image Img_bom = new Bitmap(Properties.Resources.img_bom, 25, 25);
        Image Img_bom_X = new Bitmap(Properties.Resources.img_bom_X, 25, 25);
        Image Img_co = new Bitmap(Properties.Resources.Img_co, 25, 25);
        Image Img_poit1 = new Bitmap(Properties.Resources.img_poit1, 25, 25);
        Image Img_poit2 = new Bitmap(Properties.Resources.img_poit2, 25, 25);
        Image Img_poit3 = new Bitmap(Properties.Resources.img_poit3, 25, 25);
        Image Img_poit4 = new Bitmap(Properties.Resources.img_poit4, 25, 25);
        Image Img_poit5 = new Bitmap(Properties.Resources.img_poit5, 25, 25);
        Image Img_poit6 = new Bitmap(Properties.Resources.img_poit6, 25, 25);
        Image Img_poit7 = new Bitmap(Properties.Resources.img_poit7, 25, 25);
        Image Img_poit8 = new Bitmap(Properties.Resources.img_poit8, 25, 25);
        Image Img_poit9 = new Bitmap(Properties.Resources.img_poit9, 25, 25);
        Stack Hangdoi = new Stack();
        int[,] mainboard ;
        static int time;      
        int[,] co ;
        int[,] kiemtraomo; // đánh dấu các ô đã mở hay chưa
      
        Graphics grs;

        #endregion

        #region load From
        public Form1()
        {
            InitializeComponent();
            restart();
        }
        #endregion
        
        #region khởi tạo gán giá trị
        public void khoitaomangco(int soDong, int soCot)
        {
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    co[i, j] = -2;

                }
            }

            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    kiemtraomo[i, j] = 0;

                }
            }
        }
        public void khoitaomangmoi(int soDong, int soCot, int soBom)
        {
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    mainboard[i, j] = 0;

                }
            }

            Random random = new Random();

            int randDong = 0;
            int randCot;
            for (int i = 0; i < soBom; )
            {
                randDong = random.Next(0,soDong - 1);
                randCot = random.Next(0,soCot - 1);
                if (mainboard[randDong, randCot] != -1)
                {
                    mainboard[randDong, randCot] = -1; i++;
                }
            }
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    if (mainboard[i, j] == -1)
                    {
                        if (j - 1 >= 0 && mainboard[i, j - 1] != -1) mainboard[i, j - 1]++;
                        if (j + 1 < soCot && mainboard[i, j + 1] != -1) mainboard[i, j + 1]++;

                        if (i - 1 >= 0)
                        {
                            if (mainboard[i - 1, j] != -1) mainboard[i - 1, j]++;
                            if (j - 1 >= 0 && mainboard[i - 1, j - 1] != -1) mainboard[i - 1, j - 1]++;
                            if (j + 1 < soCot && mainboard[i - 1, j + 1] != -1) mainboard[i - 1, j + 1]++;
                        }

                        if (i + 1 < soDong)
                        {
                            if (mainboard[i + 1, j] != -1) mainboard[i + 1, j]++;
                            if (j - 1 >= 0 && mainboard[i + 1, j - 1] != -1) mainboard[i + 1, j - 1]++;
                            if (j + 1 < soCot && mainboard[i + 1, j + 1] != -1) mainboard[i + 1, j + 1]++;
                        }
                    }
                }
            }
        }
        #endregion
        
        #region Mở ô tróng
        public void mootrong(int dong, int cot, Graphics g, int x, int y)
        {


            // ô ở trên
            if (cot !=  Convert.ToInt32(nudcol.Text)-1 && co[dong, cot + 1] == -2)
            {
                if (mainboard[dong, cot + 1] == 0 && kiemtraomo[dong, cot + 1] == 0)
                {
                    kiemtraomo[dong, cot + 1] = 1;
                    grs.DrawImage(Img_poit9, (dong) * 25, (cot + 1) * 25);
                    Hangdoi.Push(dong);
                    Hangdoi.Push(cot + 1);
                }
                else
                {
                    moochuaso(dong, cot + 1, (dong) * 25, (cot + 1) * 25);
                }
            }
            // ô ở dưới
            if (cot != 0 && co[dong, cot - 1] == -2)
            {
                if (mainboard[dong, cot - 1] == 0 && kiemtraomo[dong, cot - 1] == 0)
                {
                    grs.DrawImage(Img_poit9, dong * 25, (cot - 1) * 25);
                    Hangdoi.Push(dong);
                    Hangdoi.Push(cot - 1);
                    kiemtraomo[dong, cot - 1] = 1;
                }
                else
                {
                    moochuaso(dong, cot - 1, (dong) * 25, (cot - 1) * 25);
                }
            }
            // ô ở bên phải
            if (dong != Convert.ToInt32(nudrow.Text.ToString())-1 && co[dong + 1, cot] == -2)
            {
                if (mainboard[dong + 1, cot] == 0 && kiemtraomo[dong + 1, cot] == 0)
                {
                    kiemtraomo[dong + 1, cot] = 1;
                    grs.DrawImage(Img_poit9, (dong + 1) * 25, (cot) * 25);
                    Hangdoi.Push(dong + 1);
                    Hangdoi.Push(cot);
                }
                else
                {
                    moochuaso(dong + 1, cot, (dong + 1) * 25, (cot) * 25);
                }
            }
            // ô bên trái
            if (dong != 0 && co[dong - 1, cot] == -2)
            {
                if (mainboard[dong - 1, cot] == 0 && kiemtraomo[dong - 1, cot] == 0)
                {
                    kiemtraomo[dong - 1, cot] = 1;
                    grs.DrawImage(Img_poit9, (dong - 1) * 25, (cot) * 25);
                    Hangdoi.Push(dong - 1);
                    Hangdoi.Push(cot);
                }
                else
                {
                    moochuaso(dong - 1, cot, (dong - 1) * 25, (cot) * 25);
                }
            }

        // loang
        loang();
            
        }

        public void loang()
        {
            if (Hangdoi.Count != 0)
            {
                int cot = Convert.ToInt32(Hangdoi.Pop().ToString());
                int dong = Convert.ToInt32(Hangdoi.Pop().ToString());
                mootrong ( dong,cot,grs,dong*25,cot * 25);
            }
        }
        #endregion
        #region Mở ô số
        public void moochuaso(int dong, int cot, int x, int y)
        {

            if (co[dong, cot] == -2)
            {

                switch (mainboard[dong, cot])
                {
                    case 1: grs.DrawImage(Img_poit1, x, y); break;
                    case 2: grs.DrawImage(Img_poit2, x, y); break;
                    case 3: grs.DrawImage(Img_poit3, x, y); break;
                    case 4: grs.DrawImage(Img_poit4, x, y); break;
                    case 5: grs.DrawImage(Img_poit5, x, y); break;
                    case 6: grs.DrawImage(Img_poit6, x, y); break;
                    case 7: grs.DrawImage(Img_poit7, x, y); break;
                    case 8: grs.DrawImage(Img_poit8, x, y); break;

                }

                kiemtraomo[dong, cot] = 1;
            }
        }
        #endregion
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            vetoado();
        }
        #region Hiện bom khi thua
        public void hienbom()
        {

            for (int i = 0; i < Convert.ToInt32(nudrow.Text); i++)
                for (int i2 = 0; i2 < Convert.ToInt32(nudcol.Text); i2++)
                {
                    if (mainboard[i, i2] == -1)
                    {
                        grs.DrawImage(Img_bom, i * 25, i2 * 25);
                        if (co[i, i2] == -1)
                            grs.DrawImage(Img_bom_X, i * 25, i2 * 25);
                    }
                }
        }
        #endregion
        #region Kiểm tra điều kiện thắng 
        public void kiemtrathang()
        {
            int youwin = 0;
            for (int i = 0; i < Convert.ToInt32(nudrow.Text); i++)
            {
                for (int j = 0; j < Convert.ToInt32(nudcol.Text); j++)
                {
                    if (mainboard[i, j] == co[i, j])
                    {
                        youwin++;

                    }
                    if (youwin == Convert.ToInt32(nudbom.Text) && lblco.Text == "0")
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("Xin chúc mừng bạn đã chiến thắng ^^");                     
                            Form2 f2 = new Form2();
                            f2.Show();
                        j = Convert.ToInt32(nudrow.Text);
                        i = Convert.ToInt32(nudcol.Text);
                    }

                }

            }
        }
        #endregion
        #region Xử lí sự kiện click chuột trái
        public void xulysukien(int dong, int cot, Graphics g, int x, int y)
        {
            if (co[dong, cot] == -2)
            {
                kiemtraomo[dong, cot] = 1;
                switch (mainboard[dong, cot])
                {
                    case -1: grs.DrawImage(Img_bom, x, y);
                        hienbom();
                        timer1.Enabled = false;
                        MessageBox.Show("Game over");
                        lbHienthi.Text = "10";
                        restart();
                        break;
                    case 0: grs.DrawImage(Img_poit9, x, y);
                        mootrong(dong, cot, g, x, y); break;
                    case 1: grs.DrawImage(Img_poit1, x, y); break;
                    case 2: grs.DrawImage(Img_poit2, x, y); break;
                    case 3: grs.DrawImage(Img_poit3, x, y); break;
                    case 4: grs.DrawImage(Img_poit4, x, y); break;
                    case 5: grs.DrawImage(Img_poit5, x, y); break;
                    case 6: grs.DrawImage(Img_poit6, x, y); break;
                    case 7: grs.DrawImage(Img_poit7, x, y); break;
                    case 8: grs.DrawImage(Img_poit8, x, y); break;
                }
            }
            kiemtrathang();
        }
        #endregion
        public void vetoado()
        {
            for (int i = 0; i < Convert.ToInt32(nudrow.Text); i++)
                for (int i2 = 0; i2 < Convert.ToInt32(nudcol.Text); i2++)
                {
                    grs.DrawImage(Img_cell, i * 25, i2 * 25);
                }
        }


        #region Xử lí sự kiện click chuột phải
        public void xulysukienco(int dong, int cot, Graphics g, int x, int y)
        {
            if (kiemtraomo[dong, cot] == 0)
             
                if (co[dong, cot] == -2)
                {

                    grs.DrawImage(Img_co, x, y);
                    co[dong, cot] = -1;
                    lblco.Text = (Convert.ToInt32(lblco.Text) - 1).ToString();
                }
                else
                {
                    grs.DrawImage(Img_cell, x, y);
                    co[dong, cot] = -2;
                    lblco.Text = (Convert.ToInt32(lblco.Text) + 1).ToString();
                }
                kiemtrathang();
            }
        }
        #endregion
        #region Xử lí sự kiện click chuột
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {                       
            timer1.Enabled = true;                          
            if (e.Button == MouseButtons.Right)
            {
                int dong = e.X / 25;
                int cot = e.Y / 25;
                int x = dong * 25;
                int y = cot * 25;
                xulysukienco(dong, cot, grs, x, y);
            }
            else
            {
                int dong = e.X / 25;
                int cot = e.Y / 25;
                int x = dong * 25;
                int y = cot * 25;
                xulysukien(dong, cot, grs, x, y);
            }
        }
        #endregion

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lbHienthi.Text = "00:00";
            restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void butstart_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            timer1.Enabled = false;
            lbHienthi.Text = "00:00";
            restart();
          
        }
        #region Reset màn chơi
        public void restart()
        {            
            lblco.Text = nudbom.Text.ToString();
            mainboard = new int[Convert.ToInt32(nudrow.Text), Convert.ToInt32(nudcol.Text)];
            co = new int[Convert.ToInt32(nudrow.Text), Convert.ToInt32(nudcol.Text)];
            kiemtraomo = new int[Convert.ToInt32(nudrow.Text), Convert.ToInt32(nudcol.Text)];
            khoitaomangmoi(Convert.ToInt32(nudrow.Text), Convert.ToInt32(nudcol.Text), Convert.ToInt32(nudbom.Text.ToString()));
            khoitaomangco(Convert.ToInt32(nudrow.Text), Convert.ToInt32(nudcol.Text));
            panel1.Size = new Size(Convert.ToInt32(nudrow.Text) * 25 + 1, Convert.ToInt32(nudcol.Text) * 25 + 1);
            grs = panel1.CreateGraphics();
            vetoado();
            time = 0;
            
        }
        #endregion
        #region Đồng hồ bấm giờ
        public void timer1_Tick(object sender, EventArgs e)
        {
            time += timer1.Interval;
            
            lbHienthi.Text = string.Format("{0}:{1}",(time/60000),(time/1000)%60);
        }
        #endregion
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Bản quyền thuộc về nhóm 14 ^^ "); 
        }
        #region Xử lí điểm cao
        private void hướngDẫnChơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
- Người chơi khởi đầu với một bảng ô vuông trống thể hiện bãi mìn

- Click chuột vào một ô vuông trong bảng. Nếu không may trúng phải ô có mìn (điều này ít xảy ra hơn) thì người chơi trò chơi kết thúc. Trường hợp thường xảy ra hơn là ô đó không có mìn và một vùng các ô sẽ được mở ra cùng với những con số. Số trên một ô là chỉ số ô có mìn trong cả thảy 8 ô nằm lân cận với ô đó.

- Nếu chắc chắn một ô có mìn, người chơi đánh dấu vào ô đó bằng hình lá cờ (click chuột phải).

- Trò chơi kết thúc với phần thắng dành cho người chơi nếu tìm được tất cả các ô có mìn và mở được tất cả các ô không có mìn.","Hướng dẫn chơi");
        }

        public static string GetThoiGian()
        {
            return string.Format("{0}:{1}", (time / 60000), (time / 1000) % 60);
        }

    #endregion

    private void scoreBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreBoard board = new ScoreBoard();
            board.Show();
        }

        private void lbHienthi_Click(object sender, EventArgs e)
        {

        }
    }

}