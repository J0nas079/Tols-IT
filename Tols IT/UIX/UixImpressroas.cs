using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Tols_IT.Models;

namespace Tols_IT.UIX
{
    public partial class UixImpressroas : Form
    {
        public UixImpressroas()
        {
            InitializeComponent();
        }
        //Passando os dados do label para a tabela Impressoraas
        public void btnCadastrarImp_Click(object sender, EventArgs e)
        {
            
            Impressoras impressoras = new Impressoras();
            //Colocar toda a validação dentro de um Try catch
            try
            {
                if (txtPropri.Text.Equals(string.Empty))
                {
                    MessageBox.Show("O Campo proprietario precisa ser informado!");
                        return; 
                }
                else
                {
                    impressoras.proprietario = txtPropri.Text;
                }

                if (txtsetorIm.Text.Equals(string.Empty))
                {
                    MessageBox.Show("O Campo setor precisa ser preenchido");
                    return; 
                }
                else
                {
                    impressoras.setor = txtsetorIm.Text;
                }

                if (txtModelImp.Text.Equals(String.Empty))
                {
                    MessageBox.Show("O campo Modelo precisa ser preenchido ");
                    return;
                }
                else
                {
                    impressoras.modelo = txtModelImp.Text;
                }

                if (rdip.Checked)
                {
                    impressoras.ip = txtConex.Text;
                }
                else
                {
                    impressoras.ip = "USB";
                }
                if (txtTipoImp.Text.Equals(String.Empty))
                {
                    MessageBox.Show("Favro preencher com o tipo da Impressora");
                    return;
                }
                else
                {
                    impressoras.TipoImpr=txtTipoImp.Text;
                }
                if (txtFabriIm.Text.Equals(String.Empty))
                {
                    MessageBox.Show("Favor preencher o campo do Fabricante");
                    return ;
                }
                else
                {
                    impressoras.fabricante = txtFabriIm.Text;
                }
                if (txtNpImp.Text.Equals(String.Empty))
                {
                    MessageBox.Show("Favor preencher o campo com a NP do equipamento");
                    return;
                }
                else
                {
                    impressoras.np = Convert.ToInt32(txtNpImp.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO!", ex.Message);
            }
            txtConex.Clear();
            txtPropri.Clear();
            txtFabriIm.Clear();
            txtsetorIm.Clear();
            txtNpImp.Clear();
            txtTipoImp.Clear();
            txtModelImp.Clear();
            rdusb.Checked = false;
            MessageBox.Show("Dados inseridos com sucesso!");
         
            ConnectionDB.AddImpressoras(impressoras);
        }
        
        private void UixImpressroas_Load(object sender, EventArgs e)
        {
            txtConex.Enabled = false;
        }

        private void rdip_CheckedChanged(object sender, EventArgs e)
        {
            txtConex.Enabled = true;
        }
 

        private void rdusb_CheckedChanged(object sender, EventArgs e)
        {
            txtConex.Enabled= false;
        }
    }
}
