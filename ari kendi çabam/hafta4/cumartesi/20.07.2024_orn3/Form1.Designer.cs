namespace _20._07._2024_orn3
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnGeri = new Button();
            btnBaslat = new Button();
            btnIleri = new Button();
            btnFotosec = new Button();
            btnDurdur = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(247, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 183);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(247, 332);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 23);
            btnGeri.TabIndex = 1;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(328, 332);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(75, 23);
            btnBaslat.TabIndex = 2;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // btnIleri
            // 
            btnIleri.Location = new Point(413, 332);
            btnIleri.Name = "btnIleri";
            btnIleri.Size = new Size(75, 23);
            btnIleri.TabIndex = 3;
            btnIleri.Text = "İleri";
            btnIleri.UseVisualStyleBackColor = true;
            btnIleri.Click += btnIleri_Click;
            // 
            // btnFotosec
            // 
            btnFotosec.Location = new Point(247, 67);
            btnFotosec.Name = "btnFotosec";
            btnFotosec.Size = new Size(75, 23);
            btnFotosec.TabIndex = 4;
            btnFotosec.Text = "Resim Sec";
            btnFotosec.UseVisualStyleBackColor = true;
            btnFotosec.Click += btnFotosec_Click;
            // 
            // btnDurdur
            // 
            btnDurdur.Location = new Point(328, 361);
            btnDurdur.Name = "btnDurdur";
            btnDurdur.Size = new Size(75, 23);
            btnDurdur.TabIndex = 5;
            btnDurdur.Text = "Durdur";
            btnDurdur.UseVisualStyleBackColor = true;
            btnDurdur.Click += btnDurdur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDurdur);
            Controls.Add(btnFotosec);
            Controls.Add(btnIleri);
            Controls.Add(btnBaslat);
            Controls.Add(btnGeri);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button btnGeri;
        private Button btnBaslat;
        private Button btnIleri;
        private Button btnFotosec;
        private Button btnDurdur;
    }
}
