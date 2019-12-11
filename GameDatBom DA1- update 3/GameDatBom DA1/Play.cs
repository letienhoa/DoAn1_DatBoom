using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDatBom_DA1
{
    public partial class Play : Form
    {
        taogiaodien Giaodien;
        bool sangtrai;
        bool sangphai;
        bool lentren;
        bool xuongduoi;
        bool bot1sangtrai;
        bool bot1sangphai;
        bool bot2sangtrai;
        bool bot2sangphai;
        bool bot3sangtrai;
        bool bot3sangphai;
        bool datbom;
        int tocdobot = 35;
        int tocdochoi = 3;
        int tran1 = 0;
        int tran2 = 0;
        int tran3 = 0;
        DateTime timebot1;
        DateTime timebot2;
        DateTime timebot3;
        int diem = 0;  
        int live = 3;
        bool win = false;
       public static int boom = 0;

        public Play()
        {
            InitializeComponent();
            Giaodien = new taogiaodien(panel1);
            Giaodien.taomatran();
            label3.ForeColor = Color.Red;
        }

        private void Anxuong(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    sangtrai = true;
                    player.Image = Properties.Resources.trai;
                    player.BackgroundImageLayout = ImageLayout.Stretch;
                    break;

                case Keys.Right:
                    sangphai = true;
                    player.Image = Properties.Resources.phai;
                    player.BackgroundImageLayout = ImageLayout.Stretch;
                    break;

                case Keys.Up:
                    lentren = true;
                    player.Image = Properties.Resources.sau;
                    player.BackgroundImageLayout = ImageLayout.Stretch;
                    break;

                case Keys.Down:
                    xuongduoi = true;
                    player.Image = Properties.Resources.truoc2;
                    player.BackgroundImageLayout = ImageLayout.Stretch;
                    break;

                case Keys.Space:
                    if (boom < 2)
                    {
                        datbom = true;
                        boom++;
                        xulybom(player.Location);
                    }  
                    break;
                    

            }

        }

        private void Anlen(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    sangtrai = false;
                    break;
                case Keys.Right:
                    sangphai = false;
                    break;
                case Keys.Up:
                    lentren = false;
                    break;
                case Keys.Down:
                    xuongduoi = false;
                    break;
                case Keys.Space:
                    datbom = false;
                    break;

            }

        }


        //ham nguoi choi di chuyển và xử lý
        private void Timer1_Tick(object sender, EventArgs e)
        {           
            label4.Text = diem.ToString();
            label3.Text = live.ToString();
            if (kiemtradambom(player)==true)
            {
                live--;
                player.Location = new Point(35, 35);
            }
            if (kiemtradungquai() == true)
            {
                live--;
                player.Location = new Point(35, 35);
            }
            kiemtraluomdo(player);
            if (sangtrai && kiemtrabutton(player) == 1)
            {
                    player.Left -= tocdobot;
            }
            else if (sangphai && kiemtrabutton(player) == 2)
            {
                    player.Left += tocdobot;
            }
            else if (lentren && kiemtrabutton(player) == 3)
            {
                    player.Top -= tocdobot;
            }
            else if (xuongduoi && kiemtrabutton(player) == 4)
            {
                    player.Top += tocdobot;
            }
            label4.Text = diem.ToString();
            label3.Text = live.ToString();
        }


        // kiểm tra đụng quái ,nếu đụng sẽ bị mất 1 mạng và về vị trí gốc
        private bool kiemtradungquai()
        {
            foreach (Control x in panel1.Controls)
            {
                if (x is PictureBox && x.Tag == "bot"&&x.Visible==true)
                {
                   if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // hàm kiểm tra xem có lút  đc đồ hay không
        private int kiemtraluomdo(PictureBox player)
        {
            int x = (player.Location.X) / 35;
            int y = (player.Location.Y) / 35;
            //lượm đc mạng sống thì trả về 1
            if (taogiaodien.mangluu[y][x].Tag=="live")
            {
                if (live < 5)
                {
                    live++;
                }
                taogiaodien.mangluu[y][x].BackgroundImage = Properties.Resources.nen1;
                taogiaodien.mangluu[y][x].Tag = "diduoc";
                return 1;
            }
            //lượm được vàng thì trả về 2
            else if (taogiaodien.mangluu[y][x].Tag=="vang")
            {
                diem = diem + 30;
                taogiaodien.mangluu[y][x].BackgroundImage = Properties.Resources.nen1;
                taogiaodien.mangluu[y][x].Tag = "diduoc";
                return 2;
            }
            // trung loi thoat thi win
            else if (taogiaodien.mangluu[y][x].Tag == "loithoat")
            {
                win = true;
                return 3;
            }
            //ko có gì thì trả về 0
            else return 0;
        }

        
        //kiểm  tra đường đi cho người chơi
        private int kiemtrabutton(PictureBox player)
        {

            int goc1x = (player.Location.X) / 35;
            int goc1y = (player.Location.Y) / 35;

            if (LoaiMap.map1[goc1y, goc1x + 1] != 1 && 
                LoaiMap.map1[goc1y, goc1x + 1] != 3 && sangphai == true)
            {
                return 2;
            }
            else if (LoaiMap.map1[goc1y, goc1x - 1] != 1 &&
                LoaiMap.map1[goc1y, goc1x - 1] != 3 && sangtrai == true)
            {
                return 1;
            }
            else if (LoaiMap.map1[goc1y + 1, goc1x] != 1 &&
                LoaiMap.map1[goc1y + 1, goc1x] != 3 && xuongduoi == true)
            {
                return 4;
            }
            else if (LoaiMap.map1[goc1y - 1, goc1x] != 1 &&
                LoaiMap.map1[goc1y - 1, goc1x] != 3 && lentren == true)
            {
                return 3;
            }
            else return 0;
        }

        
        //kiểm tra dẫm boom và đụng bot là quay về vị trí cũ 
        // mất thêm một mạng
        private bool kiemtradambom(PictureBox player)
        {
            int x = (player.Location.X) / 35;
            int y = (player.Location.Y) / 35;
            if (LoaiMap.map1[y, x] == 2)
            {
                    return true; 
            }
            return false;
        }

       
        //xử lý boom sau khi đặt xong bao gồm cả 2 hàm này
        private void xulybom(Point player) 
        {

            foreach (Control x in this.panel1.Controls)
            {
                //kiểm tra button x có đủ điều kiện để dặt bom
                if (x is Button && x.Location.X == player.X && x.Location.Y == player.Y)
                {
                    int goc1x = (player.X) / 35;
                    int goc1y = (player.Y) / 35;
                    x.BackgroundImage = Properties.Resources.bomb;
                    x.BackgroundImageLayout = ImageLayout.Stretch;
                    LoaiMap.map1[goc1y, goc1x] = 1;
                    Bomb btnBomb = new Bomb(x, Bomb.BombImage.bomb);
                    btnBomb.MatBomb += Mat_btnBomb;
                   
                }
            }
        }
        private void Mat_btnBomb(object sender, EventArgs e)
        {
            Bomb objBomb = sender as Bomb;
            if (objBomb != null)
            {
                objBomb.Dispose();
            }
        }


        //hàm timer2,3,4 la của 3 con bot cho nó chạy qua lại
       //trong đó có luôn kiểm tra dẫm boom ,nếu dẫm bom thì điểm tăng 10
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now > timebot1)
            {
                bot1.Visible = true;
            }
            if (bot1.Visible==true && kiemtradambom(bot1) == true)
            {
                diem += 10;
                xulyanbot(bot1);

            }
            kiemtraduongdibot(bot1);
            if (bot1sangtrai && tran1 == 0)
            {
                bot1.Image = Properties.Resources.bottrai;
                bot1.Left -= tocdochoi;
            }
            else if(bot1sangtrai==false)
            {
                tran1 = 1;
            }
            if (bot1sangphai && tran1==1)
            {
                bot1.Image = Properties.Resources.botphai;
                bot1.Left += tocdochoi;     
            }
            else if (bot1sangphai == false)
            {
                tran1 = 0;
            }
            
            
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now > timebot2)
            {
                bot2.Visible = true;
            }
            if (bot2.Visible == true && kiemtradambom(bot2) == true)
            {
                diem += 10;
                xulyanbot(bot2);

            }
            kiemtraduongdibot(bot2);
            if (bot2sangtrai && tran2 ==1)
            {
                bot2.Image = Properties.Resources.bottrai;
                bot2.Left -= tocdochoi;
            }
            else if (bot2sangtrai == false)
            {
                tran2 = 0;
            }
            if (bot2sangphai && tran2 == 0)
            {
                bot2.Image = Properties.Resources.botphai;
                bot2.Left += tocdochoi;
            }
            else if (bot2sangphai == false)
            {
                tran2 = 1;
            }

        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now > timebot3)
            {
                bot3.Visible = true;
            }
            if (bot3.Visible == true && kiemtradambom(bot3) == true)
            {
                diem += 10;
                xulyanbot(bot3);

            }
            kiemtraduongdibot(bot3);
            if (bot3sangtrai && tran3 == 0)
            {
                bot3.Image = Properties.Resources.bottrai;
                bot3.Left -= tocdochoi;
            }
            else if (bot3sangtrai == false)
            {
                tran3 = 1;
            }
            if (bot3sangphai && tran3 == 1)
            {
                bot3.Image = Properties.Resources.botphai;
                bot3.Left += tocdochoi;
            }
            else if (bot3sangphai == false)
            {
                tran3 = 0;
            }

        }

        //hàm 5 với formclose là đóng lại
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (live == 0)
            {
                timer1.Stop();
                label5.Visible = true;
            }
            else if (win == true)
            {
                timer1.Stop();
                label6.Visible = true;
                FileStream fs = new FileStream("input.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string val = sr.ReadLine();
                while (val != null)
                {
                    taogiaodien.listdiem.Add(Convert.ToInt32(val));
                    val = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                if (taogiaodien.listdiem[0] < diem)
                {
                    FileStream luu = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(luu);
                    sw.WriteLine(label4.Text);
                    sw.Close();
                    luu.Close();
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Mọi dữ liệu sẽ mất khi bạn thoát, bạn chắc chứ", "Thong Bao", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            { e.Cancel = true; }

        }

        //kiểm tra đường đi của bot có bị cản trở hay ko để 
        //phục vụ cho di chuyển
        private void kiemtraduongdibot(PictureBox player)
        {

            int goc1x = (player.Location.X) / 35;
            int goc1y = (player.Location.Y) / 35;
            if (player.Name == "bot1")
            {
                if (LoaiMap.map1[goc1y, goc1x+1] != 1&& LoaiMap.map1[goc1y, goc1x + 1] != 3)
                {
                    bot1sangphai = true;

                }
                else { bot1sangphai = false; }

                if (LoaiMap.map1[goc1y, goc1x] != 1 && LoaiMap.map1[goc1y, goc1x] != 3)
                {
                    bot1sangtrai = true;
                }
                else { bot1sangtrai = false; }
            }
            else if (player.Name == "bot2")
            {
                if (LoaiMap.map1[goc1y, goc1x+1] != 1 && LoaiMap.map1[goc1y, goc1x + 1] != 3)
                {
                    bot2sangphai = true;

                }
                else { bot2sangphai = false; }

                if (LoaiMap.map1[goc1y, goc1x] != 1 && LoaiMap.map1[goc1y, goc1x] != 3)
                {
                    bot2sangtrai = true;
                }
                else { bot2sangtrai = false; }
            }
            //bot3
            else if (player.Name == "bot3")
            {
                if (LoaiMap.map1[goc1y, goc1x+1] != 1 && LoaiMap.map1[goc1y, goc1x + 1] != 3)
                {
                    bot3sangphai = true;

                }
                else { bot3sangphai = false; }

                if (LoaiMap.map1[goc1y, goc1x] != 1 && LoaiMap.map1[goc1y, goc1x] != 3)
                {
                    bot3sangtrai = true;
                }
                else { bot3sangtrai = false; }
            }
        }


        //nếu bot dẫm boom thì vào đây cho mất 5s sau đó sẽ hồi sinh lại 
        // mất là ẩn đi 5s ,sau đó hiện lên lại 
        private void xulyanbot(PictureBox bot)
        {
            bot.Visible = false;
            if (bot.Name == "bot1")
            {
                timebot1 = DateTime.Now.AddSeconds(5);
            }
            if (bot.Name == "bot2")
            {
                timebot2 = DateTime.Now.AddSeconds(5);
            }
            if (bot.Name == "bot3")
            {
                timebot3 = DateTime.Now.AddSeconds(5);
            }
        }

       

      

    }
}
