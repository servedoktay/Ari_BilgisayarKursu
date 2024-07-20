namespace _20._07._2024_orn1
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
            cmbMeyveler = new ComboBox();
            txtEklenecek = new TextBox();
            btnEkle = new Button();
            lblmeyveList = new Label();
            lblEklenecekVeri = new Label();
            SuspendLayout();
            // 
            // cmbMeyveler
            // 
            cmbMeyveler.FormattingEnabled = true;
            cmbMeyveler.Location = new Point(117, 49);
            cmbMeyveler.Name = "cmbMeyveler";
            cmbMeyveler.Size = new Size(121, 23);
            cmbMeyveler.TabIndex = 0;
            // 
            // txtEklenecek
            // 
            txtEklenecek.Location = new Point(138, 90);
            txtEklenecek.Name = "txtEklenecek";
            txtEklenecek.Size = new Size(100, 23);
            txtEklenecek.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(163, 130);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += button1_Click;
            // 
            // lblmeyveList
            // 
            lblmeyveList.AutoSize = true;
            lblmeyveList.Location = new Point(12, 52);
            lblmeyveList.Name = "lblmeyveList";
            lblmeyveList.Size = new Size(77, 15);
            lblmeyveList.TabIndex = 3;
            lblmeyveList.Text = "Meyve Listesi";
            // 
            // lblEklenecekVeri
            // 
            lblEklenecekVeri.AutoSize = true;
            lblEklenecekVeri.Location = new Point(12, 93);
            lblEklenecekVeri.Name = "lblEklenecekVeri";
            lblEklenecekVeri.Size = new Size(66, 15);
            lblEklenecekVeri.TabIndex = 4;
            lblEklenecekVeri.Text = "Meyve Ekle";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEklenecekVeri);
            Controls.Add(lblmeyveList);
            Controls.Add(btnEkle);
            Controls.Add(txtEklenecek);
            Controls.Add(cmbMeyveler);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMeyveler;
        private TextBox txtEklenecek;
        private Button btnEkle;
        private Label lblmeyveList;
        private Label lblEklenecekVeri;
    }
}
