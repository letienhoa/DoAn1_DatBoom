using System;
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
    public partial class Form1 : Form
    {
        taogiaodien Giaodien;     
        bool sangtrai;
        bool sangphai;
        bool lentren;
        bool xuongduoi;
        bool datbom;
        List<Bomb> lstBombs = new List<Bomb>();
        int tocdochoi = 35;


        public Form1()
        {
            InitializeComponent();
            Giaodien = new taogiaodien(panel1);
            Giaodien.taomatran();
            
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
                    datbom = true;
                    xulybom(player.Location);
                    break;

            }

        }

        private void Anlen(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
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
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (kiemtradambom() == false)
            {
                player.Location = new Point(35, 35);

            }
            if (sangtrai)
            {
               
                if (player.Left > 35 &&kiemtrabutton()==1)
                {  
                    player.Left -= tocdochoi;
                }
            }
            else if (sangphai)
            {
             
                if (player.Left < 565 - 35 && kiemtrabutton() == 2)
                {
                    player.Left += tocdochoi; 
                }
            }
            else if (lentren)
            {
              
                if (player.Top > 35 && kiemtrabutton() == 3)
                {
                    player.Top -= tocdochoi;
                }
            }
            else if (xuongduoi)
            {
               
                if (player.Top < 492-35 && kiemtrabutton() == 4)
                {
                    player.Top += tocdochoi;
                }
            }
          
        }

        private int kiemtrabutton()
        {
          
            int goc1x = (player.Location.X) / 35;
            int goc1y = (player.Location.Y) / 35;

            if (LoaiMap.map1[goc1y, goc1x + 1] !=1 && sangphai == true )
            {
                return 2;
            }
            else if (LoaiMap.map1[goc1y, goc1x - 1] != 1 && sangtrai == true)
            {
                return 1;
            }
            else if (LoaiMap.map1[goc1y + 1, goc1x] != 1 && xuongduoi == true)
            {
                return 4;
            }
            else if (LoaiMap.map1[goc1y - 1, goc1x] != 1 && lentren == true)
            {
                return 3;
            }
            else return 0;
        }
        private  bool kiemtradambom()
        {
            int x = (player.Location.X) / 35;
            int y = (player.Location.Y) / 35;
            if(LoaiMap.map1[y,x]==2)
            {
                return false;
            }
            return true;
        }
        private void xulybom(Point player)
        {
            
            foreach(Control x in this.panel1.Controls)
            {
                //kiểm tra button x có đủ điều kiện để dặt bom
                if (x is Button && x.Location.X== player.X && x.Location.Y== player.Y)
                {
                    int goc1x = (player.X) / 35;
                    int goc1y = (player.Y) / 35;
                    x.BackgroundImage= Properties.Resources.bomb;
                    x.BackgroundImageLayout = ImageLayout.Stretch;
                    LoaiMap.map1[goc1y,goc1x] = 1;
                    Bomb btnBomb = new Bomb(x, Bomb.BombImage.bomb);
                    btnBomb.MatBomb += Mat_btnBomb;
                    this.lstBombs.Add(btnBomb);                    
                }
            }           
        }
        private void Mat_btnBomb(object sender, EventArgs e)
        {
            Bomb objBomb = sender as Bomb;
            if (objBomb != null)
            {
                lstBombs.Remove(objBomb);
                Point a = objBomb.btnBomb.Location;
             //   LoaiMap.map1[a.Y / 35, a.X / 35] = 0;

                objBomb.Dispose();
                
            }
        }
    }
}
