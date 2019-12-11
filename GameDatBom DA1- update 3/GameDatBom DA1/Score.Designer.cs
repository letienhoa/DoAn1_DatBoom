namespace GameDatBom_DA1
{
    partial class Score
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxtop1 = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnComeBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.tbxtop1);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 651);
            this.panel1.TabIndex = 9;
            // 
            // tbxtop1
            // 
            this.tbxtop1.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbxtop1.Enabled = false;
            this.tbxtop1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtop1.ForeColor = System.Drawing.Color.Red;
            this.tbxtop1.Location = new System.Drawing.Point(266, 147);
            this.tbxtop1.Name = "tbxtop1";
            this.tbxtop1.ReadOnly = true;
            this.tbxtop1.Size = new System.Drawing.Size(100, 29);
            this.tbxtop1.TabIndex = 10;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lb1.Font = new System.Drawing.Font("Snap ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Red;
            this.lb1.Location = new System.Drawing.Point(97, 150);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(154, 25);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "High Scocer";
            // 
            // btnComeBack
            // 
            this.btnComeBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnComeBack.BackgroundImage = global::GameDatBom_DA1.Properties.Resources.icon_tick;
            this.btnComeBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComeBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnComeBack.FlatAppearance.BorderSize = 0;
            this.btnComeBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComeBack.Location = new System.Drawing.Point(368, 592);
            this.btnComeBack.Name = "btnComeBack";
            this.btnComeBack.Size = new System.Drawing.Size(75, 50);
            this.btnComeBack.TabIndex = 10;
            this.btnComeBack.UseVisualStyleBackColor = false;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.btnComeBack;
            this.ClientSize = new System.Drawing.Size(455, 654);
            this.Controls.Add(this.btnComeBack);
            this.Controls.Add(this.panel1);
            this.Name = "Score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxtop1;
        private System.Windows.Forms.Button btnComeBack;
    }
}