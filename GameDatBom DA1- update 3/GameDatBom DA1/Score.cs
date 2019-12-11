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
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
            LoadTable();
        }
        private void LoadTable()
        {
            Docdulieu();
            int max1 = taogiaodien.listdiem[0];
           
            //
            tbxtop1.Text = max1.ToString();
            


        }
        public void  Docdulieu()
        {
            FileStream fs = new FileStream("input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string val = sr.ReadLine();
            while(val!=null)
            {
                taogiaodien.listdiem.Add(Convert.ToInt32(val));
                val = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
    }
}
