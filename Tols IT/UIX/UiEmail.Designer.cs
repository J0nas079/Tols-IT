namespace Tols_IT.UIX
{
    partial class UiEmail
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUserEmail = new TextBox();
            txtCargEma = new TextBox();
            txtEmail = new TextBox();
            btnEmail = new Button();
            txtSenhaEma = new TextBox();
            label1 = new Label();
            cbxEmail = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(41, 37);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 0;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(46, 85);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 2;
            label3.Text = "Cargo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(356, 37);
            label4.Name = "label4";
            label4.Size = new Size(47, 19);
            label4.TabIndex = 3;
            label4.Text = "E-mail";
            // 
            // txtUserEmail
            // 
            txtUserEmail.Location = new Point(131, 36);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(202, 23);
            txtUserEmail.TabIndex = 1;
            // 
            // txtCargEma
            // 
            txtCargEma.Location = new Point(131, 84);
            txtCargEma.Name = "txtCargEma";
            txtCargEma.Size = new Size(202, 23);
            txtCargEma.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(440, 33);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 23);
            txtEmail.TabIndex = 4;
            // 
            // btnEmail
            // 
            btnEmail.Font = new Font("Segoe UI", 10F);
            btnEmail.Location = new Point(243, 187);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(90, 31);
            btnEmail.TabIndex = 7;
            btnEmail.Text = "Cadastrar";
            btnEmail.UseVisualStyleBackColor = true;
            btnEmail.Click += btnEmail_Click;
            // 
            // txtSenhaEma
            // 
            txtSenhaEma.Location = new Point(440, 81);
            txtSenhaEma.Name = "txtSenhaEma";
            txtSenhaEma.Size = new Size(202, 23);
            txtSenhaEma.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 82);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 10;
            label1.Text = "Senha";
            // 
            // cbxEmail
            // 
            cbxEmail.FormattingEnabled = true;
            cbxEmail.Items.AddRange(new object[] { "RH", "PCP", "Controladoria", "Calandra", "Pesponto", "Almoxarifado", "Recebimento", "Personalizado", "Montagem", "Expediçao", "Injetora", "Projeto", "SESMT", "Manutenção" });
            cbxEmail.Location = new Point(440, 123);
            cbxEmail.Name = "cbxEmail";
            cbxEmail.Size = new Size(202, 23);
            cbxEmail.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(369, 131);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 12;
            label5.Text = "Setor";
            // 
            // UiEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(654, 247);
            Controls.Add(label5);
            Controls.Add(cbxEmail);
            Controls.Add(label1);
            Controls.Add(txtSenhaEma);
            Controls.Add(btnEmail);
            Controls.Add(txtEmail);
            Controls.Add(txtCargEma);
            Controls.Add(txtUserEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UiEmail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UiEmail";
            Load += UiEmail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUserEmail;
        private TextBox txtCargEma;
        private TextBox txtEmail;
        private Button btnEmail;
        private TextBox txtSenhaEma;
        private Label label1;
        private ComboBox cbxEmail;
        private Label label5;
    }
}