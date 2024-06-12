namespace Tols_IT
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataView1 = new DataGridView();
            btnlistar = new Button();
            btncatraca = new Button();
            btnemail = new Button();
            btnrep = new Button();
            label2 = new Label();
            txtPesquisar = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            desktopToolStripMenuItem = new ToolStripMenuItem();
            impressorasToolStripMenuItem = new ToolStripMenuItem();
            emailToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataView1).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataView1
            // 
            dataView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(6, 140, 109);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(6, 140, 109);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataView1.EnableHeadersVisualStyles = false;
            dataView1.Location = new Point(123, 78);
            dataView1.Name = "dataView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataView1.Size = new Size(672, 323);
            dataView1.TabIndex = 0;
            // 
            // btnlistar
            // 
            btnlistar.Anchor = AnchorStyles.Left;
            btnlistar.BackColor = Color.FromArgb(6, 140, 109);
            btnlistar.BackgroundImageLayout = ImageLayout.Stretch;
            btnlistar.FlatStyle = FlatStyle.Flat;
            btnlistar.Font = new Font("Microsoft Tai Le", 8.25F);
            btnlistar.ForeColor = Color.White;
            btnlistar.Location = new Point(11, 22);
            btnlistar.Name = "btnlistar";
            btnlistar.Size = new Size(83, 45);
            btnlistar.TabIndex = 0;
            btnlistar.Text = "Desktop";
            btnlistar.UseVisualStyleBackColor = false;
            btnlistar.Click += btnlistar_Click;
            // 
            // btncatraca
            // 
            btncatraca.Anchor = AnchorStyles.Left;
            btncatraca.BackColor = Color.FromArgb(6, 140, 109);
            btncatraca.BackgroundImageLayout = ImageLayout.Stretch;
            btncatraca.FlatStyle = FlatStyle.Flat;
            btncatraca.Font = new Font("Microsoft Tai Le", 8.25F);
            btncatraca.ForeColor = Color.White;
            btncatraca.Location = new Point(11, 179);
            btncatraca.Name = "btncatraca";
            btncatraca.Size = new Size(83, 54);
            btncatraca.TabIndex = 2;
            btncatraca.Text = "Catracas";
            btncatraca.UseVisualStyleBackColor = false;
            btncatraca.Click += btncatraca_Click;
            // 
            // btnemail
            // 
            btnemail.Anchor = AnchorStyles.Left;
            btnemail.BackColor = Color.FromArgb(6, 140, 109);
            btnemail.BackgroundImageLayout = ImageLayout.Stretch;
            btnemail.FlatStyle = FlatStyle.Flat;
            btnemail.Font = new Font("Microsoft Tai Le", 8.25F);
            btnemail.ForeColor = Color.White;
            btnemail.Location = new Point(11, 95);
            btnemail.Name = "btnemail";
            btnemail.Size = new Size(83, 53);
            btnemail.TabIndex = 1;
            btnemail.Text = "E-mail";
            btnemail.UseVisualStyleBackColor = false;
            btnemail.Click += btnemail_Click;
            // 
            // btnrep
            // 
            btnrep.Anchor = AnchorStyles.Left;
            btnrep.BackColor = Color.FromArgb(6, 140, 109);
            btnrep.BackgroundImageLayout = ImageLayout.Stretch;
            btnrep.FlatStyle = FlatStyle.Flat;
            btnrep.Font = new Font("Microsoft Tai Le", 8.25F);
            btnrep.ForeColor = Color.White;
            btnrep.Location = new Point(11, 264);
            btnrep.Name = "btnrep";
            btnrep.Size = new Size(83, 57);
            btnrep.TabIndex = 3;
            btnrep.Text = "Rep's";
            btnrep.UseVisualStyleBackColor = false;
            btnrep.Click += btnrep_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(111, 28);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(174, 25);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(107, 23);
            txtPesquisar.TabIndex = 8;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 34, 53);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnlistar);
            panel1.Controls.Add(btnemail);
            panel1.Controls.Add(btncatraca);
            panel1.Controls.Add(btnrep);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(105, 437);
            panel1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(6, 140, 109);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Tai Le", 8.25F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 354);
            button1.Name = "button1";
            button1.Size = new Size(84, 63);
            button1.TabIndex = 4;
            button1.Text = "Impressoras";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip1.BackColor = Color.White;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem });
            menuStrip1.Location = new Point(672, 20);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(112, 28);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { desktopToolStripMenuItem, impressorasToolStripMenuItem, emailToolStripMenuItem });
            cadastrarToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cadastrarToolStripMenuItem.Image = Properties.Resources.tools;
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(104, 24);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // desktopToolStripMenuItem
            // 
            desktopToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            desktopToolStripMenuItem.ForeColor = Color.FromArgb(6, 140, 109);
            desktopToolStripMenuItem.Name = "desktopToolStripMenuItem";
            desktopToolStripMenuItem.Size = new Size(180, 24);
            desktopToolStripMenuItem.Text = "Desktop";
            desktopToolStripMenuItem.Click += desktopToolStripMenuItem_Click;
            // 
            // impressorasToolStripMenuItem
            // 
            impressorasToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            impressorasToolStripMenuItem.ForeColor = Color.FromArgb(6, 140, 109);
            impressorasToolStripMenuItem.Name = "impressorasToolStripMenuItem";
            impressorasToolStripMenuItem.Size = new Size(180, 24);
            impressorasToolStripMenuItem.Text = "Impressoras";
            impressorasToolStripMenuItem.Click += impressorasToolStripMenuItem_Click;
            // 
            // emailToolStripMenuItem
            // 
            emailToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            emailToolStripMenuItem.ForeColor = Color.FromArgb(6, 140, 109);
            emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            emailToolStripMenuItem.Size = new Size(180, 24);
            emailToolStripMenuItem.Text = "Email";
            emailToolStripMenuItem.Click += emailToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(812, 437);
            Controls.Add(menuStrip1);
            Controls.Add(txtPesquisar);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(dataView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Inventário";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataView1).EndInit();
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataView1;
        private Button btnlistar;
        private Button btncatraca;
        private Button btnemail;
        private Button btnrep;
        private Label label2;
        public TextBox txtPesquisar;
        private Panel panel1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem desktopToolStripMenuItem;
        private ToolStripMenuItem impressorasToolStripMenuItem;
        private ToolStripMenuItem emailToolStripMenuItem;
    }
}
