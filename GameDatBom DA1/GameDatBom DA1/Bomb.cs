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

        public Bomb(Control F1btnBomb,BombImage F1ImageBomb)
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
            switch(ImageBomb)
            {
                case BombImage.bomb:
                    if (DateTime.Now > ThoiGian)
                    {
                        BombNo();
                        //viet ham sau khi no.....
                    }
                    break;
                case BombImage.bombbang:
                    Point a = btnBomb.Location;               
                    break;
            }      
        }
        // xoa hình sau khi hết time của bom
        private void BombNo()
        {
            this.ThoiGianBomb.Enabled = false;
            if(this.MatBomb!=null)
            {
                this.btnBomb.BackgroundImage = Properties.Resources.nen1;
                this.ThoiGianBomb.Dispose();
                this.MatBomb(this, EventArgs.Empty);
                int x = (btnBomb.Location.X) / 35;
                int y = (btnBomb.Location.Y) / 35;
                for (int i = 0; i < 3; i++)
                {
                    if (taogiaodien.mangluu[y][x + i].Tag == "diduoc")
                    {
                        taogiaodien.mangluu[y][x + i].BackgroundImage = Properties.Resources.bombbang;
                        LoaiMap.map1[y,x + i] = 2;
                        BomNoRa btnBomNoRa = new BomNoRa(taogiaodien.mangluu[y][x + i], BomNoRa.AnhBomNo.bombbang);
                        btnBomNoRa.MatBomNo += Mat_BomNo;
                    }
                    else break;
                }
                for (int i = 1; i < 3; i++)
                {
                    if (taogiaodien.mangluu[y][x - i].Tag == "diduoc")
                    {
                        taogiaodien.mangluu[y][x - i].BackgroundImage = Properties.Resources.bombbang;
                        LoaiMap.map1[y, x - i] = 2;
                        BomNoRa btnBomNoRa = new BomNoRa(taogiaodien.mangluu[y][x - i], BomNoRa.AnhBomNo.bombbang);
                        btnBomNoRa.MatBomNo += Mat_BomNo;
                    }
                    else break;
                }
                for (int i = 1; i < 3; i++)
                {
                    if (taogiaodien.mangluu[y-i][x ].Tag == "diduoc")
                    {
                        taogiaodien.mangluu[y-i][x].BackgroundImage = Properties.Resources.bombbang;
                        LoaiMap.map1[y-i, x ] = 2;
                        BomNoRa btnBomNoRa = new BomNoRa(taogiaodien.mangluu[y-i][x], BomNoRa.AnhBomNo.bombbang);
                        btnBomNoRa.MatBomNo += Mat_BomNo;
                    }
                    else break;
                }
                for (int i = 1; i < 3; i++)
                {
                    if (taogiaodien.mangluu[y+i][x].Tag == "diduoc")
                    {
                        taogiaodien.mangluu[y+i][x].BackgroundImage = Properties.Resources.bombbang;
                        LoaiMap.map1[y + i, x] = 2;
                        BomNoRa btnBomNoRa = new BomNoRa(taogiaodien.mangluu[y+i][x], BomNoRa.AnhBomNo.bombbang);
                        btnBomNoRa.MatBomNo += Mat_BomNo;
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
