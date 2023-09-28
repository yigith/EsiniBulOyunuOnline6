namespace EsiniBulOyunuOnline6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlKartlar = new Panel();
            gboYeniOyun = new GroupBox();
            rb5 = new RadioButton();
            rb4 = new RadioButton();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            btnOyunuBaslat = new Button();
            menuStrip1 = new MenuStrip();
            oyunToolStripMenuItem = new ToolStripMenuItem();
            btnYeniOyun = new ToolStripMenuItem();
            gboYeniOyun.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.Anchor = AnchorStyles.None;
            pnlKartlar.BackColor = Color.Transparent;
            pnlKartlar.Location = new Point(12, 38);
            pnlKartlar.Name = "pnlKartlar";
            pnlKartlar.Size = new Size(600, 600);
            pnlKartlar.TabIndex = 0;
            // 
            // gboYeniOyun
            // 
            gboYeniOyun.Anchor = AnchorStyles.None;
            gboYeniOyun.BackColor = Color.Transparent;
            gboYeniOyun.Controls.Add(rb5);
            gboYeniOyun.Controls.Add(rb4);
            gboYeniOyun.Controls.Add(rb3);
            gboYeniOyun.Controls.Add(rb2);
            gboYeniOyun.Controls.Add(rb1);
            gboYeniOyun.Controls.Add(btnOyunuBaslat);
            gboYeniOyun.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gboYeniOyun.Location = new Point(161, 190);
            gboYeniOyun.Name = "gboYeniOyun";
            gboYeniOyun.Size = new Size(312, 309);
            gboYeniOyun.TabIndex = 0;
            gboYeniOyun.TabStop = false;
            gboYeniOyun.Text = "Yeni Oyun";
            // 
            // rb5
            // 
            rb5.Anchor = AnchorStyles.None;
            rb5.AutoSize = true;
            rb5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            rb5.Location = new Point(85, 197);
            rb5.Name = "rb5";
            rb5.Size = new Size(111, 34);
            rb5.TabIndex = 5;
            rb5.Text = "Çok Zor";
            rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            rb4.Anchor = AnchorStyles.None;
            rb4.AutoSize = true;
            rb4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            rb4.Location = new Point(85, 155);
            rb4.Name = "rb4";
            rb4.Size = new Size(66, 34);
            rb4.TabIndex = 4;
            rb4.Text = "Zor";
            rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.Anchor = AnchorStyles.None;
            rb3.AutoSize = true;
            rb3.Checked = true;
            rb3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            rb3.Location = new Point(85, 113);
            rb3.Name = "rb3";
            rb3.Size = new Size(79, 34);
            rb3.TabIndex = 3;
            rb3.TabStop = true;
            rb3.Text = "Orta";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.Anchor = AnchorStyles.None;
            rb2.AutoSize = true;
            rb2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            rb2.Location = new Point(85, 71);
            rb2.Name = "rb2";
            rb2.Size = new Size(88, 34);
            rb2.TabIndex = 2;
            rb2.Text = "Kolay";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.Anchor = AnchorStyles.None;
            rb1.AutoSize = true;
            rb1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            rb1.Location = new Point(85, 29);
            rb1.Name = "rb1";
            rb1.Size = new Size(133, 34);
            rb1.TabIndex = 1;
            rb1.Text = "Çok Kolay";
            rb1.UseVisualStyleBackColor = true;
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOyunuBaslat.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnOyunuBaslat.Location = new Point(6, 246);
            btnOyunuBaslat.Name = "btnOyunuBaslat";
            btnOyunuBaslat.Size = new Size(300, 57);
            btnOyunuBaslat.TabIndex = 0;
            btnOyunuBaslat.Text = "Oyunu Başlat";
            btnOyunuBaslat.UseVisualStyleBackColor = true;
            btnOyunuBaslat.Click += btnOyunuBaslat_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { oyunToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(624, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // oyunToolStripMenuItem
            // 
            oyunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnYeniOyun });
            oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            oyunToolStripMenuItem.ShortcutKeys = Keys.F2;
            oyunToolStripMenuItem.Size = new Size(48, 20);
            oyunToolStripMenuItem.Text = "Oyun";
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.ShortcutKeys = Keys.F2;
            btnYeniOyun.Size = new Size(147, 22);
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(624, 650);
            Controls.Add(gboYeniOyun);
            Controls.Add(pnlKartlar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eşini Bul Oyunu";
            gboYeniOyun.ResumeLayout(false);
            gboYeniOyun.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlKartlar;
        private GroupBox groupBox1;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private GroupBox gboYeniOyun;
        private RadioButton rb5;
        private RadioButton rb4;
        private RadioButton rb3;
        private RadioButton rb2;
        private RadioButton rb1;
        private Button btnOyunuBaslat;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem oyunToolStripMenuItem;
        private ToolStripMenuItem btnYeniOyun;
    }
}