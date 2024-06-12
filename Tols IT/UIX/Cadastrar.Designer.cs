namespace Tols_IT.UIX
{
    partial class Cadastrar
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
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            desktopToolStripMenuItem = new ToolStripMenuItem();
            impressorasToolStripMenuItem = new ToolStripMenuItem();
            emailToolStripMenuItem = new ToolStripMenuItem();
            repsToolStripMenuItem = new ToolStripMenuItem();
            catracasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(205, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { desktopToolStripMenuItem, impressorasToolStripMenuItem, emailToolStripMenuItem, repsToolStripMenuItem, catracasToolStripMenuItem });
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
            desktopToolStripMenuItem.Size = new Size(164, 24);
            desktopToolStripMenuItem.Text = "Desktop";
            desktopToolStripMenuItem.Click += desktopToolStripMenuItem_Click;
            // 
            // impressorasToolStripMenuItem
            // 
            impressorasToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            impressorasToolStripMenuItem.ForeColor = Color.FromArgb(6, 140, 109);
            impressorasToolStripMenuItem.Name = "impressorasToolStripMenuItem";
            impressorasToolStripMenuItem.Size = new Size(164, 24);
            impressorasToolStripMenuItem.Text = "Impressoras";
            impressorasToolStripMenuItem.Click += impressorasToolStripMenuItem_Click;
            // 
            // emailToolStripMenuItem
            // 
            emailToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            emailToolStripMenuItem.ForeColor = Color.FromArgb(6, 140, 109);
            emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            emailToolStripMenuItem.Size = new Size(164, 24);
            emailToolStripMenuItem.Text = "Email";
            // 
            // repsToolStripMenuItem
            // 
            repsToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            repsToolStripMenuItem.ForeColor = Color.FromArgb(6, 140, 109);
            repsToolStripMenuItem.Name = "repsToolStripMenuItem";
            repsToolStripMenuItem.Size = new Size(164, 24);
            repsToolStripMenuItem.Text = "Reps";
            // 
            // catracasToolStripMenuItem
            // 
            catracasToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            catracasToolStripMenuItem.ForeColor = Color.FromArgb(6, 140, 109);
            catracasToolStripMenuItem.Name = "catracasToolStripMenuItem";
            catracasToolStripMenuItem.Size = new Size(164, 24);
            catracasToolStripMenuItem.Text = "Catracas";
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(205, 55);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem desktopToolStripMenuItem;
        private ToolStripMenuItem impressorasToolStripMenuItem;
        private ToolStripMenuItem emailToolStripMenuItem;
        private ToolStripMenuItem repsToolStripMenuItem;
        private ToolStripMenuItem catracasToolStripMenuItem;
    }
}