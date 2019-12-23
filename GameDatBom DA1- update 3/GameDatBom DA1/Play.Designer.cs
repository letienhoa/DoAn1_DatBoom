namespace GameDatBom_DA1
{
    partial class Play
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bot2 = new System.Windows.Forms.PictureBox();
            this.bot1 = new System.Windows.Forms.PictureBox();
            this.bot3 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Thoát = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bot2);
            this.panel1.Controls.Add(this.bot1);
            this.panel1.Controls.Add(this.bot3);
            this.panel1.Controls.Add(this.player);
            this.panel1.Location = new System.Drawing.Point(15, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 530);
            this.panel1.TabIndex = 1;
            this.panel1.TabIndexChanged += new System.EventHandler(this.Timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 63);
            this.label6.TabIndex = 5;
            this.label6.Text = "YOU WIN";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(388, 63);
            this.label5.TabIndex = 4;
            this.label5.Text = "GAME OVER";
            this.label5.Visible = false;
            // 
            // bot2
            // 
            this.bot2.BackgroundImage = global::GameDatBom_DA1.Properties.Resources.nen1;
            this.bot2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bot2.Image = global::GameDatBom_DA1.Properties.Resources.bottruoc;
            this.bot2.Location = new System.Drawing.Point(175, 315);
            this.bot2.Name = "bot2";
            this.bot2.Size = new System.Drawing.Size(35, 35);
            this.bot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bot2.TabIndex = 3;
            this.bot2.TabStop = false;
            this.bot2.Tag = "bot";
            // 
            // bot1
            // 
            this.bot1.BackgroundImage = global::GameDatBom_DA1.Properties.Resources.nen1;
            this.bot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bot1.Image = global::GameDatBom_DA1.Properties.Resources.bottruoc;
            this.bot1.Location = new System.Drawing.Point(350, 175);
            this.bot1.Name = "bot1";
            this.bot1.Size = new System.Drawing.Size(35, 35);
            this.bot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bot1.TabIndex = 2;
            this.bot1.TabStop = false;
            this.bot1.Tag = "bot";
            // 
            // bot3
            // 
            this.bot3.BackgroundImage = global::GameDatBom_DA1.Properties.Resources.nen1;
            this.bot3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bot3.Image = global::GameDatBom_DA1.Properties.Resources.bottruoc;
            this.bot3.Location = new System.Drawing.Point(491, 455);
            this.bot3.Name = "bot3";
            this.bot3.Size = new System.Drawing.Size(35, 35);
            this.bot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bot3.TabIndex = 1;
            this.bot3.TabStop = false;
            this.bot3.Tag = "bot";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.BackgroundImage = global::GameDatBom_DA1.Properties.Resources.nen1;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Image = global::GameDatBom_DA1.Properties.Resources.truoc2;
            this.player.Location = new System.Drawing.Point(35, 35);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(35, 35);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tag = "thoigian";
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 25;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 25;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 25;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(651, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Live :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(633, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(758, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(758, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 31);
            this.label4.TabIndex = 4;
            // 
            // Thoát
            // 
            this.Thoát.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Thoát.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoát.Location = new System.Drawing.Point(731, 478);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(95, 35);
            this.Thoát.TabIndex = 5;
            this.Thoát.Text = "  Thoát";
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(907, 571);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Anxuong);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Anlen);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox bot2;
        private System.Windows.Forms.PictureBox bot1;
        private System.Windows.Forms.PictureBox bot3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Thoát;
    }
}

