using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tols_IT.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tols_IT.UIX
{
    public partial class UiEmail : Form
    {
        public UiEmail()
        {
            InitializeComponent();
        }
        private void btnEmail_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            //Validando os inputs
            try
            {
                if ((txtUserEmail.Text) == string.Empty)
                {
                    MessageBox.Show("Favor Prenncer o campo do Usúario");
                    return;
                }
                else
                {
                    email.usuario = txtUserEmail.Text;
                }
                if ((txtCargEma.Text) == string.Empty)
                {
                    MessageBox.Show("Por favor Informe o Cargo");
                    return;
                }
                else
                {
                    email.Cargo = txtCargEma.Text;
                }
                if (txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Favor informe um e-mail valido");
                    return;
                }
                else
                {
                    email.email = txtEmail.Text;
                }
                if (txtSenhaEma.Text == string.Empty)
                {
                    MessageBox.Show("Favor preencher o campo senha!");
                }
                else
                {
                    email.senha = txtSenhaEma.Text;
                }
                if(cbxEmail.Text == string.Empty)
                {
                    MessageBox.Show("Favor selecionar um setor!!");
                }
                else
                {
                    email.setor=cbxEmail.Text;
                }
                ConnectionDB.AddEmail(email);

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro", ex.Message);
            }
            
            MessageBox.Show("Dados Inseridos com sucesso!");
            txtUserEmail.Focus();
            txtEmail.Clear();
            cbxEmail.SelectedIndex = -1;
            txtCargEma.Clear();
            txtSenhaEma.Clear();
            txtUserEmail.Clear();
            
        }

        private void UiEmail_Load(object sender, EventArgs e)
        {
            //Bloqueando o editar do combobox
            cbxEmail.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }

}
