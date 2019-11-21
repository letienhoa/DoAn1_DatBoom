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
    public partial class StartGame : Form
    {
        public StartGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void StartGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban muon thoat", "Thong Bao", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            { e.Cancel = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Score form = new Score();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

      
    }
}