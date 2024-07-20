namespace _20._07._2024_orn3_hoca
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
            btnSec = new Button();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            button2 = new Button();
            btnGeri = new Button();
            btnIleri = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSec
            // 
            btnSec.Location = new Point(94, 38);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(75, 23);
            btnSec.TabIndex = 0;
            btnSec.Text = "button1";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(94, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 219);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(572, 20);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(182, 334);
            listBox1.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(201, 303);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Baslat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(201, 348);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Dur";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(94, 303);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 26);
            btnGeri.TabIndex = 5;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnIleri
            // 
            btnIleri.Location = new Point(315, 303);
            btnIleri.Name = "btnIleri";
            btnIleri.Size = new Size(75, 26);
            btnIleri.TabIndex = 6;
            btnIleri.Text = "İleri";
            btnIleri.UseVisualStyleBackColor = true;
            btnIleri.Click += btnIleri_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIleri);
            Controls.Add(btnGeri);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnSec);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSec;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
        private Button btnGeri;
        private Button btnIleri;
    }
}
