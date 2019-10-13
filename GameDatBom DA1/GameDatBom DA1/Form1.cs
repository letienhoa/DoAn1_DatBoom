﻿using System;
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
        taogiaodien Program;

       
        
        
        bool sangtrai;
        bool sangphai;
        bool lentren;
        bool xuongduoi;
        
        bool bientrai=false;
        bool bienphai=false;
        bool bientren=false;
        bool bienduoi=false;
        int tocdochoi = 5;


        Point goc1;
        Point goc2;
        Point goc3;
        Point goc4;

        public Form1()
        {
            InitializeComponent();
            Program = new taogiaodien(panel1);
            Program.taomatran();
            
        }

        private void Anxuong(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                sangtrai = true;
                player.Image = Properties.Resources.trai;
                player.BackgroundImageLayout = ImageLayout.Stretch;
                player.BackgroundImage = Properties.Resources.nen1;
            }
            if (e.KeyCode == Keys.Right)
            {
                sangphai = true;
                player.Image = Properties.Resources.phai;
                player.BackgroundImageLayout = ImageLayout.Stretch;
                player.BackgroundImage = Properties.Resources.nen1;
            }
            if (e.KeyCode == Keys.Up)
            {
                lentren = true;
                player.Image = Properties.Resources.sau;
                player.BackgroundImageLayout = ImageLayout.Stretch;
                player.BackgroundImage = Properties.Resources.nen1;
            }
            if (e.KeyCode == Keys.Down)
            {
                xuongduoi = true;
                player.Image = Properties.Resources.truoc2;
                player.BackgroundImageLayout = ImageLayout.Stretch;
                player.BackgroundImage = Properties.Resources.nen1;
            }
        }

        private void Anlen(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                sangtrai = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                sangphai = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                lentren = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                xuongduoi = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (sangtrai)
            {
               
                if (player.Left > 35 &&kiemtrabutton()!=1)
                {
                   
                    player.Left -= tocdochoi;
                    laytoado(ref goc1, ref goc2, ref goc3, ref goc4);
                   
                }
            }
            else if (sangphai)
            {
             
                if (player.Left < 565 - 35 && kiemtrabutton() != 2)
                {
             
                    player.Left += tocdochoi;
                    laytoado(ref goc1, ref goc2, ref goc3, ref goc4);
                }
            }
            else if (lentren)
            {
              
                if (player.Top > 35 && kiemtrabutton() != 3)
                {
                    player.Top -= tocdochoi;
                    laytoado(ref goc1, ref goc2, ref goc3, ref goc4);
                }
            }
            else if (xuongduoi)
            {
               
                if (player.Top < 492-35 && kiemtrabutton() != 4)
                {
                    player.Top += tocdochoi;
                    laytoado(ref goc1, ref goc2, ref goc3, ref goc4);
                }
            }
        }

        private int kiemtrabutton()
        {

            foreach (Control x in panel1.Controls)
            {
                if (x is Button && ((Button )x).Tag.ToString() == "khongphaduoc")
                {                    
                    if((player.Bounds.IntersectsWith(((Button) x).Bounds))&& (goc3.Y-55)<(x.Location.Y))
                    {
                        return 2;
                        
                    }
                }
                //if (x is Button && ((Button)x).Tag.ToString() == "diduoc")
                //{
                //    if ((player.Bounds.IntersectsWith(((Button)x).Bounds)))
                //    {
                //        return false;

                //    }
                //}
            }
            return 0;
        }

        private void laytoado(ref Point goc1, ref Point goc2, ref Point goc3, ref Point goc4)
        {
            goc1.X = player.Location.X;
            goc1.Y = player.Location.Y;
            goc2.X = player.Location.X+player.Width;
            goc2.Y = player.Location.Y;
            goc3.X = player.Location.X+player.Width;
            goc3.Y = player.Location.Y+player.Height;
            goc4.X = player.Location.X;
            goc4.Y = player.Location.Y+player.Height;
        }
    }
}