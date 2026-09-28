namespace ticketApp
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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            saat = new GroupBox();
            button4 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            yer = new NumericUpDown();
            maskedTextBox2 = new MaskedTextBox();
            tarix = new MaskedTextBox();
            comboBox2 = new ComboBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            email = new TextBox();
            fin = new TextBox();
            namesurname = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            telefon = new MaskedTextBox();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            saat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yer).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 105);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(308, 105);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(708, 39);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 2;
            label1.Text = "BMU TRAVEL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(809, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(91, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // saat
            // 
            saat.BackColor = Color.Black;
            saat.Controls.Add(button4);
            saat.Controls.Add(label7);
            saat.Controls.Add(label6);
            saat.Controls.Add(label5);
            saat.Controls.Add(label4);
            saat.Controls.Add(label3);
            saat.Controls.Add(yer);
            saat.Controls.Add(maskedTextBox2);
            saat.Controls.Add(tarix);
            saat.Controls.Add(comboBox2);
            saat.Controls.Add(comboBox1);
            saat.ForeColor = Color.White;
            saat.Location = new Point(34, 135);
            saat.Name = "saat";
            saat.Size = new Size(315, 301);
            saat.TabIndex = 2;
            saat.TabStop = false;
            saat.Text = "Mashurt";
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.Location = new Point(259, 58);
            button4.Name = "button4";
            button4.Size = new Size(50, 77);
            button4.TabIndex = 12;
            button4.Text = "<\r\n>";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 244);
            label7.Name = "label7";
            label7.Size = new Size(29, 20);
            label7.TabIndex = 11;
            label7.Text = "Yer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 192);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 10;
            label6.Text = "Saat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 148);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 9;
            label5.Text = "Tarix";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 101);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 8;
            label4.Text = "Haraya";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 55);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 7;
            label3.Text = "Hardan";
            // 
            // yer
            // 
            yer.Location = new Point(91, 237);
            yer.Name = "yer";
            yer.Size = new Size(150, 27);
            yer.TabIndex = 6;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(91, 192);
            maskedTextBox2.Mask = "90:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(151, 27);
            maskedTextBox2.TabIndex = 5;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // tarix
            // 
            tarix.Location = new Point(91, 148);
            tarix.Mask = "00/00/0000";
            tarix.Name = "tarix";
            tarix.Size = new Size(151, 27);
            tarix.TabIndex = 4;
            tarix.ValidatingType = typeof(DateTime);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(91, 101);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Black;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(email);
            groupBox2.Controls.Add(fin);
            groupBox2.Controls.Add(namesurname);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(telefon);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(673, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 301);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sernishin melumatlari";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button1.Location = new Point(66, 244);
            button1.Name = "button1";
            button1.Size = new Size(134, 38);
            button1.TabIndex = 5;
            button1.Text = "Bileti Al";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // email
            // 
            email.Location = new Point(128, 132);
            email.Name = "email";
            email.Size = new Size(125, 27);
            email.TabIndex = 13;
            // 
            // fin
            // 
            fin.Location = new Point(128, 86);
            fin.Name = "fin";
            fin.Size = new Size(125, 27);
            fin.TabIndex = 12;
            // 
            // namesurname
            // 
            namesurname.Location = new Point(128, 41);
            namesurname.Name = "namesurname";
            namesurname.Size = new Size(125, 27);
            namesurname.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 179);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 10;
            label9.Text = "Telefon";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 135);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 9;
            label10.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 86);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 8;
            label11.Text = "Fin Code";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 41);
            label12.Name = "label12";
            label12.Size = new Size(73, 20);
            label12.TabIndex = 7;
            label12.Text = "Ad Soyad";
            // 
            // telefon
            // 
            telefon.Location = new Point(128, 179);
            telefon.Mask = "(999) 000-0000";
            telefon.Name = "telefon";
            telefon.Size = new Size(125, 27);
            telefon.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
            button2.Location = new Point(48, 606);
            button2.Name = "button2";
            button2.Size = new Size(163, 38);
            button2.TabIndex = 5;
            button2.Text = "Siyahidan Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.ForeColor = Color.White;
            button3.Location = new Point(786, 608);
            button3.Name = "button3";
            button3.Size = new Size(160, 34);
            button3.TabIndex = 6;
            button3.Text = "Proqramdan Cixis";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(34, 464);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(912, 120);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(986, 664);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(saat);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            saat.ResumeLayout(false);
            saat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yer).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox comboBox1;
        private GroupBox saat;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox tarix;
        private ComboBox comboBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private NumericUpDown yer;
        private GroupBox groupBox2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private MaskedTextBox telefon;
        private TextBox email;
        private TextBox fin;
        private TextBox namesurname;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private RichTextBox richTextBox1;
    }
}
