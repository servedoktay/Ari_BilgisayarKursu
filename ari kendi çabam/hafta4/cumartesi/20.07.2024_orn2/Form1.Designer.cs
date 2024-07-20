namespace _20._07._2024_orn2
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
            dtpTarih1 = new DateTimePicker();
            lbltarih1 = new Label();
            button1 = new Button();
            label2 = new Label();
            dtpTarih2 = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // dtpTarih1
            // 
            dtpTarih1.Location = new Point(129, 32);
            dtpTarih1.Margin = new Padding(4, 3, 4, 3);
            dtpTarih1.Name = "dtpTarih1";
            dtpTarih1.Size = new Size(256, 25);
            dtpTarih1.TabIndex = 0;
            // 
            // lbltarih1
            // 
            lbltarih1.AutoSize = true;
            lbltarih1.Location = new Point(73, 32);
            lbltarih1.Margin = new Padding(4, 0, 4, 0);
            lbltarih1.Name = "lbltarih1";
            lbltarih1.Size = new Size(50, 17);
            lbltarih1.TabIndex = 1;
            lbltarih1.Text = "Tarih1";
            // 
            // button1
            // 
            button1.Location = new Point(257, 108);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(140, 74);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 4;
            label2.Text = "Tarih2";
            // 
            // dtpTarih2
            // 
            dtpTarih2.Location = new Point(129, 63);
            dtpTarih2.Margin = new Padding(4, 3, 4, 3);
            dtpTarih2.Name = "dtpTarih2";
            dtpTarih2.Size = new Size(256, 25);
            dtpTarih2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(257, 188);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(140, 74);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(53, 108);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(140, 74);
            button3.TabIndex = 6;
            button3.Text = "gün getir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 371);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dtpTarih2);
            Controls.Add(button1);
            Controls.Add(lbltarih1);
            Controls.Add(dtpTarih1);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpTarih1;
        private Label lbltarih1;
        private Button button1;
        private Label label2;
        private DateTimePicker dtpTarih2;
        private Button button2;
        private Button button3;
    }
}
