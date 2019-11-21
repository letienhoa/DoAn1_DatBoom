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
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
            LoadTable();
        }
        private void LoadTable()
        {
            List<DIEM> listData = DiemDAO.Instance.LoadDiem();
           //
            tbxtop1.Text = listData[0].Diem;
            tbxtop2.Text = listData[1].Diem;
            tbxtop3.Text = listData[2].Diem;
            tbxtop4.Text = listData[3].Diem;
            tbxtop5.Text = listData[4].Diem;
            tbxtop6.Text = listData[5].Diem;
            tbxtop7.Text = listData[6].Diem;
            tbxtop8.Text = listData[7].Diem;
            tbxtop9.Text = listData[8].Diem;
            tbxtop10.Text = listData[9].Diem;
            //
            lbtop1.Text = listData[0].Name;
            lbtop2.Text = listData[1].Name;
            lbtop3.Text = listData[2].Name;
            lbtop4.Text = listData[3].Name;
            lbtop5.Text = listData[4].Name;
            lbtop6.Text = listData[5].Name;
            lbtop7.Text = listData[6].Name;
            lbtop8.Text = listData[7].Name;
            lbtop9.Text = listData[8].Name;
            lbtop10.Text = listData[9].Name;


        }


    }
}
