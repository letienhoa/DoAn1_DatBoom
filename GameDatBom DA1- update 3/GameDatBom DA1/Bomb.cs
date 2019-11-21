using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GameDatBom_DA1
{
    public class Bomb
    {
        public enum BombImage
        {
            bomb,
            bombbang
        }
        System.Timers.Timer ThoiGianBomb = new System.Timers.Timer(500);
        public Control btnBomb { get; set; }
        private BombImage ImageBomb { get; set; }
        private DateTime ThoiGian { get; set; }
        public event EventHandler MatBomb;

        public Bomb(Control F1btnBomb, BombImage F1ImageBomb)
        {
            this.btnBomb = F1btnBomb;
            this.ImageBomb = F1ImageBomb;
            this.ThoiGianBomb.Enabled = true;
            this.ThoiGian = DateTime.Now.AddSeconds(2);
            ThoiGianBomb.Elapsed += ThoiGianBomb_Elapsed;
        }


        // kiểm tra xem đủ time để xóa hình 
        private void ThoiGianBomb_Elapsed(object sender, ElapsedEventArgs e)
        {
            switch (ImageBomb)
            {
                case BombImage.bomb:
                    if (DateTime.Now > ThoiGian)
                    {
                        BombNo();
                        //viet ham sau khi no.....
                    }
                    break;
                case BombImage.bombbang:
                    break;
            }
        }
        // xoa hình sau khi hết time của bom
        private void BombNo()
        {
            Form1.boom--;
            this.ThoiGianBomb.Enabled = false;
            if (this.MatBomb != null)
            {
               // this.btnBomb.BackgroundImage = Properties.Resources.nen1;
                this.ThoiGianBomb.Dispose();
                this.MatBomb(this, EventArgs.Empty);
                int x = (btnBomb.Location.X) / 35;
                int y = (btnBomb.Location.Y) / 35;
                int dem = 0;
                for (int i = 0; i < 3; i++)
                {

                    if (taogiaodien.mangluu[y][x + i].Tag != "khongphaduoc" && dem < 1)
                    {
                        if (LoaiMap.map1[y, x + i] == 3)
                        {
                            Random rd = new Random();
                            int a = rd.Next(1, 7);
                            if ( a == 4)
                            {
                                taogiaodien.mangluu[y][x + i].BackgroundImage = Properties.Resources.live;
                                taogiaodien.mangluu[y][x + i].Tag = "live";
                                LoaiMap.map1[y, x + i] = 0;
                               
                            }
                            else if (a == 1|| a == 2)
                            {
                                taogiaodien.mangluu[y][x + i].BackgroundImage = Properties.Resources.vang;
                                taogiaodien.mangluu[y][x + i].Tag = "vang";
                                LoaiMap.map1[y, x + i] = 0;
                                
                            }
                            else
                            {
                                taogiaodien.mangluu[y][x + i].BackgroundImage = Properties.Resources.nen1;
                                LoaiMap.map1[y, x + i] = 0;
                               
                            }
                            if(y==13&&x+i==15)
                            {
                                taogiaodien.mangluu[y][x + i].BackgroundImage = Properties.Resources.loithoat;
                                taogiaodien.mangluu[y ][x+i].Tag = "loithoat";
                                LoaiMap.map1[y, x + i] = 0;
                            }
                            dem++;
                        }
                        else
                        {
                            taogiaodien.mangluu[y][x + i].BackgroundImage = Properties.Resources.bombbang;
                            LoaiMap.map1[y, x + i] = 2;
                            BomNoRa btnBomNoRa = new BomNoRa(taogiaodien.mangluu[y][x + i], BomNoRa.AnhBomNo.bombbang);
                            btnBomNoRa.MatBomNo += Mat_BomNo;
                        }
                    }
                    else break;
                }
                dem = 0;
                for (int i = 1; i < 3; i++)
                {

                    if (taogiaodien.mangluu[y][x - i].Tag != "khongphaduoc" && dem < 1)
                    {
                        if (LoaiMap.map1[y, x - i] == 3)
                        {
                            Random rd = new Random();
                            int a = rd.Next(1, 7);
                            if (  a == 4)
                            {
                                taogiaodien.mangluu[y][x - i].BackgroundImage = Properties.Resources.live;
                                taogiaodien.mangluu[y][x - i].Tag = "live";
                                LoaiMap.map1[y, x - i] = 0;
                            }
                            else if (a == 2||a==3)
                            {
                                taogiaodien.mangluu[y][x - i].BackgroundImage = Properties.Resources.vang;
                                taogiaodien.mangluu[y][x - i].Tag = "vang";
                                LoaiMap.map1[y, x - i] = 0;
                            }
                            else
                            {
                                taogiaodien.mangluu[y][x - i].BackgroundImage = Properties.Resources.nen1;
                                LoaiMap.map1[y, x - i] = 0;
                            }
                            if (y == 13 && x - i == 15)
                            {
                                taogiaodien.mangluu[y][x -i].BackgroundImage = Properties.Resources.loithoat;
                                taogiaodien.mangluu[y ][x-i].Tag = "loithoat";
                                LoaiMap.map1[y, x - i] = 0;
                            }
                            dem++;
                        }
                        else
                        {
                            taogiaodien.mangluu[y][x - i].BackgroundImage = Properties.Resources.bombbang;
                            LoaiMap.map1[y, x - i] = 2;
                            BomNoRa btnBomNoRa = new BomNoRa(taogiaodien.mangluu[y][x - i], BomNoRa.AnhBomNo.bombbang);
                            btnBomNoRa.MatBomNo += Mat_BomNo;
                        }
                    }
                    else break;
                }
                dem = 0;
                for (int i = 1; i < 3; i++)
                {

                    if (taogiaodien.mangluu[y - i][x].Tag != "khongphaduoc" && dem < 1)
                    {
                        if (LoaiMap.map1[y - i, x] == 3)
                        {
                            Random rd = new Random();
                            int a = rd.Next(1, 7);
                            if (a == 4)
                            {
                                taogiaodien.mangluu[y - i][x].BackgroundImage = Properties.Resources.live;
                                taogiaodien.mangluu[y - i][x].Tag = "live";
                                LoaiMap.map1[y - i, x] = 0;
                            }
                            else  if (a== 2||a==3)
                            {
                                taogiaodien.mangluu[y - i][x].BackgroundImage = Properties.Resources.vang;
                                taogiaodien.mangluu[y - i][x].Tag = "vang";
                                LoaiMap.map1[y - i, x] = 0;
                            }
                            else
                            {
                                taogiaodien.mangluu[y - i][x].BackgroundImage = Properties.Resources.nen1;
                                LoaiMap.map1[y - i, x] = 0;
                            }
                            if (y-i == 13 && x == 15)
                            {
                                taogiaodien.mangluu[y-i][x].BackgroundImage = Properties.Resources.loithoat;
                                taogiaodien.mangluu[y - i][x].Tag = "loithoat";
                                LoaiMap.map1[y-i, x ] = 0;
                            }
                            dem++;
                        }
                        else
                        {
                            taogiaodien.mangluu[y - i][x].BackgroundImage = Properties.Resources.bombbang;
                            LoaiMap.map1[y - i, x] = 2;
                            BomNoRa btnBomNoRa = new BomNoRa(taogiaodien.mangluu[y - i][x], BomNoRa.AnhBomNo.bombbang);
                            btnBomNoRa.MatBomNo += Mat_BomNo;
                        }
                    }
                    else break;
                }
                dem = 0;
                for (int i = 1; i < 3; i++)
                {

                    if (taogiaodien.mangluu[y + i][x].Tag != "khongphaduoc" && dem < 1)
                    {
                        if (LoaiMap.map1[y + i, x] == 3)
                        {
                            Random rd = new Random();
                            int a = rd.Next(1, 7);
                            if ( a == 4)
                            {
                                taogiaodien.mangluu[y + i][x].BackgroundImage = Properties.Resources.live;
                                taogiaodien.mangluu[y + i][x].Tag = "live";
                                LoaiMap.map1[y + i, x] = 0;
                            }
                            else if(a==2||a==3)
                            {
                                taogiaodien.mangluu[y + i][x].BackgroundImage = Properties.Resources.vang;
                                taogiaodien.mangluu[y + i][x].Tag = "vang";
                                LoaiMap.map1[y + i, x] = 0;
                            }
                            else
                            {
                                taogiaodien.mangluu[y + i][x].BackgroundImage = Properties.Resources.nen1;
                                LoaiMap.map1[y + i, x] = 0;
                            }
                            if (y+i == 13 && x  == 15)
                            {
                                taogiaodien.mangluu[y+i][x].BackgroundImage = Properties.Resources.loithoat;
                                taogiaodien.mangluu[y + i][x].Tag = "loithoat";
                                LoaiMap.map1[y+i, x] = 0;
                            }
                            dem++;
                        }
                        else
                        {
                            taogiaodien.mangluu[y + i][x].BackgroundImage = Properties.Resources.bombbang;
                            LoaiMap.map1[y + i, x] = 2;
                            BomNoRa btnBomNoRa = new BomNoRa(taogiaodien.mangluu[y + i][x], BomNoRa.AnhBomNo.bombbang);
                            btnBomNoRa.MatBomNo += Mat_BomNo;
                        }
                    }
                    else break;
                }
            }
        }

        private void Mat_BomNo(object sender, EventArgs e)
        {
            Bomb objBomNo = sender as Bomb;
            if (objBomNo != null)
            {
                objBomNo.Dispose();
            }
        }
        //xóa đi sau khi xài tránh tốn bộ nhớ
        internal void Dispose()
        {
            this.ThoiGianBomb.Dispose();
        }
    }
}
