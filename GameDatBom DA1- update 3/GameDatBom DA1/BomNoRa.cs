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
    class BomNoRa
    {
        public enum AnhBomNo
        {
            bombbang

        }
        System.Timers.Timer ThoiGianBomNo = new System.Timers.Timer(500);
        public Control btnBomNo { get; set; }
        private AnhBomNo anhBomNo { get; set; }

        private DateTime ThoiGian { get; set; }

        public event EventHandler MatBomNo;

        public BomNoRa(Control F1btnBomb, AnhBomNo F1ImageBomb)
        {
            this.btnBomNo = F1btnBomb;
            ThoiGianBomNo.Elapsed += ThoiGianBomb_Elapsed;
            this.anhBomNo = F1ImageBomb;
            this.ThoiGianBomNo.Enabled = true;
            this.ThoiGian = DateTime.Now.AddSeconds(1);
        }

        private void ThoiGianBomb_Elapsed(object sender, ElapsedEventArgs e)
        {
            switch (anhBomNo)
            {
                case AnhBomNo.bombbang:
                    if (DateTime.Now > ThoiGian)
                    {
                        XoaHinh();
                    }
                    break;
            }

        }

        private void XoaHinh()
        {
            this.ThoiGianBomNo.Enabled = false;
            if (this.MatBomNo != null)
            {
                this.btnBomNo.BackgroundImage = Properties.Resources.nen1;
                LoaiMap.map1[btnBomNo.Location.Y / 35, btnBomNo.Location.X / 35] = 0;
                this.ThoiGianBomNo.Dispose();
                 this.MatBomNo(this, EventArgs.Empty);
            }
        }


        // Form1: Dispose
        internal void Dispose()
        {
            this.ThoiGianBomNo.Dispose();
        }
    }
}
