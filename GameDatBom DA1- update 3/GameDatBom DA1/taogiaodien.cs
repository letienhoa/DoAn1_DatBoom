using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GameDatBom_DA1
{
    class taogiaodien
    {
        private Panel khungbando
        {
            get; set;
        }
        public taogiaodien(Panel pnl1)
        {
            this.khungbando = pnl1;
        }
        public static List<List<Button>> mangluu = new List<List<Button>>();
        public static List<int> listdiem = new List<int>();
        ToaDoExits d1 = new ToaDoExits(11, 1);
        ToaDoExits d2 = new ToaDoExits(13, 15);
        ToaDoExits d3 = new ToaDoExits(9, 1);
        public static List<ToaDoExits> DSExits = new List<ToaDoExits>();
       
        public void taomatran()
        {
            DSExits.Add(d1);
            DSExits.Add(d3);
            DSExits.Add(d2);
            Button kc = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(0, 0)
            };
            for (int i = 0; i < Map.Chieurong; i++)
            {
                mangluu.Add(new List<Button>());
                for (int j = 0; j < Map.Chieudai; j++)
                {
                    Button h = new Button()
                    {
                        Tag = i.ToString(),
                        Width = Map.KichthuocX,
                        Height = Map.KichthuocY,
                        Location = new Point(kc.Location.X + kc.Width, kc.Location.Y),

                    };
                    h.TabStop = false;
                    h.FlatStyle = FlatStyle.Flat;
                    h.FlatAppearance.BorderSize = 0;
                    if (LoaiMap.map1[i, j] == 1)
                    {

                        h.BackgroundImage = Properties.Resources.da;
                        h.Tag = "khongphaduoc";
                    }
                    if (LoaiMap.map1[i, j] == 0)
                    {
                        h.BackgroundImage = Properties.Resources.nen1;
                        h.BackgroundImageLayout = ImageLayout.Stretch;
                        h.Tag = "diduoc";

                    }
                    if (LoaiMap.map1[i, j] == 3)
                    {
                        h.BackgroundImage = Properties.Resources.thunghang_;
                        h.BackgroundImageLayout = ImageLayout.Stretch;
                        h.Tag = "diduoc";

                    }
                    khungbando.Controls.Add(h);
                    mangluu[i].Add(h);
                    kc = h;
                }
                kc.Location = new Point(0, kc.Location.Y + Map.KichthuocY);
                kc.Width = 0;
                kc.Height = 0;
            }
        }
    }
}
