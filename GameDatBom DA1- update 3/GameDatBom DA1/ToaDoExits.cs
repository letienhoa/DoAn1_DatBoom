using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDatBom_DA1
{
    public class ToaDoExits
    {
        private int x;
        private int y;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public ToaDoExits(int y1,int x1 )
        {
            y = y1;
            x = x1;
        }
        ~ToaDoExits()
        {

        }
    }
}
