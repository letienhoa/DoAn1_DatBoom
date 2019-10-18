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
            ThoiGianBomb.Elapsed += ThoiGianBomb_Elapsed;
            this.ImageBomb = F1ImageBomb;
            this.ThoiGianBomb.Enabled = true;
            this.ThoiGian = DateTime.Now.AddSeconds(3);
        }

        private void ThoiGianBomb_Elapsed(object sender, ElapsedEventArgs e)
        {
            switch(ImageBomb)
            {
                case BombImage.bomb:
                    if (DateTime.Now > ThoiGian)
                    {
                        BombNo();
                    }
                    break;
                case BombImage.bombbang:
                    Point a = btnBomb.Location;
                    
                    
                    break;
            }
            
        }

        private void BombNo()
        {
            this.ThoiGianBomb.Enabled = false;
            if(this.MatBomb!=null)
            {
                this.btnBomb.BackgroundImage = Properties.Resources.nen1;
                this.ThoiGianBomb.Dispose();
                this.MatBomb(this, EventArgs.Empty);
            }
        }


        // Form1: Dispose
        internal void Dispose()
        {
            
            this.ThoiGianBomb.Dispose();
            this.btnBomb.BackgroundImage = Properties.Resources.nen1;
        }
    }
}
