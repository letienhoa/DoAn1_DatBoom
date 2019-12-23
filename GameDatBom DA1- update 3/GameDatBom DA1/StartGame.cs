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
    public partial class StartGame : Form
    {
        public StartGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  LoaiMap.map1 = LoaiMap.map2;
            Play form = new Play();
            this.Visible = false;
            form.ShowDialog();
            this.Close();
          
     
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            Score form = new Score();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Huongdan form = new Huongdan();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thongtin form = new Thongtin();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
