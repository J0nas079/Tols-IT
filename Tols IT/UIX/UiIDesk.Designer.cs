namespace Tols_IT
{
    partial class UiIDesk
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
            label1 = new Label();
            txtUser = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txthost_name = new TextBox();
            cbx02 = new ComboBox();
            label6 = new Label();
            cbx03 = new ComboBox();
            cbx01 = new ComboBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            rd01 = new RadioButton();
            rd02 = new RadioButton();
            groupBox1 = new GroupBox();
            rd05 = new RadioButton();
            rd04 = new RadioButton();
            rd03 = new RadioButton();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 34);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(58, 65);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(196, 23);
            txtUser.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 102);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 10;
            label2.Text = "Host_name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 271);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 5;
            label4.Text = "Processador";
            // 
            // txthost_name
            // 
            txthost_name.Location = new Point(328, 131);
            txthost_name.Name = "txthost_name";
            txthost_name.Size = new Size(196, 23);
            txthost_name.TabIndex = 11;
            // 
            // cbx02
            // 
            cbx02.FormattingEnabled = true;
            cbx02.Items.AddRange(new object[] { "AMD", "Intel® CORE i5 ", "Intel® Celeron ", " Intel® i3 12100F", "Intel® Core 2 duo", "intel® pentium", "Intel® I5-7200U" });
            cbx02.Location = new Point(58, 299);
            cbx02.Name = "cbx02";
            cbx02.Size = new Size(196, 23);
            cbx02.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(328, 34);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 8;
            label6.Text = "Sistema Operacional";
            // 
            // cbx03
            // 
            cbx03.FormattingEnabled = true;
            cbx03.Items.AddRange(new object[] { "Windows Xp", "Windows 7", "Windows 8.1", "Windows 10", "" });
            cbx03.Location = new Point(328, 65);
            cbx03.Name = "cbx03";
            cbx03.Size = new Size(196, 23);
            cbx03.TabIndex = 9;
            // 
            // cbx01
            // 
            cbx01.FormattingEnabled = true;
            cbx01.Items.AddRange(new object[] { "RH", "PCP", "Controladoria", "Calandra", "Pesponto", "Almoxarifado", "Recebimento", "Personalizado", "Montagem", "Expediçao", "Injetora" });
            cbx01.Location = new Point(58, 131);
            cbx01.Name = "cbx01";
            cbx01.Size = new Size(196, 23);
            cbx01.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 102);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 2;
            label7.Text = "Setor";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._06;
            pictureBox1.Location = new Point(328, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(177, 456);
            button1.Name = "button1";
            button1.Size = new Size(178, 38);
            button1.TabIndex = 12;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(328, 359);
            button2.Name = "button2";
            button2.Size = new Size(196, 35);
            button2.TabIndex = 16;
            button2.Text = "Imagem";
            button2.UseVisualStyleBackColor = true;
            // 
            // rd01
            // 
            rd01.AutoSize = true;
            rd01.Location = new Point(58, 181);
            rd01.Name = "rd01";
            rd01.Size = new Size(68, 19);
            rd01.TabIndex = 3;
            rd01.TabStop = true;
            rd01.Text = "Desktop";
            rd01.UseVisualStyleBackColor = true;
            // 
            // rd02
            // 
            rd02.AutoSize = true;
            rd02.Location = new Point(58, 218);
            rd02.Name = "rd02";
            rd02.Size = new Size(78, 19);
            rd02.TabIndex = 4;
            rd02.TabStop = true;
            rd02.Text = "Notebook";
            rd02.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rd05);
            groupBox1.Controls.Add(rd04);
            groupBox1.Controls.Add(rd03);
            groupBox1.Location = new Point(58, 337);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Memoria Ram";
            // 
            // rd05
            // 
            rd05.AutoSize = true;
            rd05.Location = new Point(6, 72);
            rd05.Name = "rd05";
            rd05.Size = new Size(46, 19);
            rd05.TabIndex = 2;
            rd05.TabStop = true;
            rd05.Text = "8GB";
            rd05.UseVisualStyleBackColor = true;
            // 
            // rd04
            // 
            rd04.AutoSize = true;
            rd04.Location = new Point(6, 47);
            rd04.Name = "rd04";
            rd04.Size = new Size(46, 19);
            rd04.TabIndex = 1;
            rd04.TabStop = true;
            rd04.Text = "4GB";
            rd04.UseVisualStyleBackColor = true;
            // 
            // rd03
            // 
            rd03.AutoSize = true;
            rd03.Location = new Point(6, 22);
            rd03.Name = "rd03";
            rd03.Size = new Size(46, 19);
            rd03.TabIndex = 0;
            rd03.TabStop = true;
            rd03.Text = "2GB";
            rd03.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(54, 160);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modelo";
            // 
            // Form2
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(585, 506);
            Controls.Add(groupBox1);
            Controls.Add(rd02);
            Controls.Add(rd01);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(cbx01);
            Controls.Add(cbx03);
            Controls.Add(label6);
            Controls.Add(cbx02);
            Controls.Add(txthost_name);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUser;
        private Label label2;
        private Label label4;
        private TextBox txthost_name;
        private ComboBox cbx02;
        private Label label6;
        private ComboBox cbx03;
        private ComboBox cbx01;
        private Label label7;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private RadioButton rd01;
        private RadioButton rd02;
        private GroupBox groupBox1;
        private RadioButton rd05;
        private RadioButton rd04;
        private RadioButton rd03;
        private GroupBox groupBox2;
    }
}