using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tols_IT.Models;

namespace Tols_IT
{
    public partial class UiIDesk : Form
    {
        public UiIDesk()
        {
            InitializeComponent();
        }
        //Instânciando os db na segunda tela
        private void Form2_Load(object sender, EventArgs e)
        {
            ConnectionDB.CriarBancoSqlite();
            ConnectionDB.CriarTabelas();
            Cbx();
        }
        private void Cbx()
        {
            cbx01.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx02.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx03.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        //Inserindo dados no banco de dados com as informações sugeridas pelo usuário
        private void button1_Click(object sender, EventArgs e)
        {
            txtUser.Focus();
            Validacao();
        }
        //Validando entrada do radionButton
        public void Validacao()
        {         
            Desktop desktop = new Desktop();
            try
            {
          

                if (txtUser.Text == string.Empty)
                {
                    MessageBox.Show("Informe o usuário");
                }
                else
                {
                    desktop.usuario = txtUser.Text;
                }

                if ((rd01.Checked || rd02.Checked) == Equals(string.Empty))
                {
                    MessageBox.Show("Nenhum campo pode ser enviado Vazio!!");
                    return;
                }
                else
                {
                    if (rd01.Checked)
                    {
                        desktop.modelo = "Computador";
                    }
                    else if (rd02.Checked)
                    {
                        desktop.modelo = "Notebook";
                    }
                }
                if ((rd03.Checked || rd04.Checked || rd05.Checked) == Equals(string.Empty))
                {
                    MessageBox.Show("Favor selecione uma opção!");
                    return;
                }
                else
                {
                    if (rd03.Checked)
                    {
                        desktop.memoriaRam = "2GB";
                    }
                    if (rd04.Checked)
                    {
                        desktop.memoriaRam = "4GB";
                    }
                    if (rd05.Checked)
                    {
                        desktop.memoriaRam = "8GB";     
                    }
                }
                if (cbx01.Text == string.Empty)
                {
                    MessageBox.Show("Voce precisa selecionar um setor");
                    return;
                }
                else
                {
                    desktop.setor = cbx01.Text;
               
                }
                if (cbx02.Text == string.Empty)
                {
                    MessageBox.Show("Voce precisa selecionar o Processador");
                    return;
                }
                else
                {
                    desktop.processador = cbx02.Text;
                }
                if (cbx03.Text == string.Empty)
                {
                    MessageBox.Show("Você Precisa selecioanar o sistema Operacional!");
                    return;
                }
                else
                {
                    desktop.sistemaOperacional = cbx03.Text;
                }
                if (txthost_name.Text == string.Empty)
                {
                    MessageBox.Show("Voce precisa informar o host_name");
                    return;
                }
                else
                {
                    desktop.host_name = txthost_name.Text;
                }
                txthost_name.Clear();
                txtUser.Clear();
                cbx01.SelectedIndex = -1;
                cbx02.SelectedIndex = -1;
                cbx03.SelectedIndex = -1;
                rd01.Checked = false;
                rd02.Checked = false;
                rd03.Checked = false;
                rd04.Checked = false;
                rd05.Checked = false;
                ConnectionDB.Add(desktop);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            // Validando retorno dos Combobox
         
           
            MessageBox.Show("Dados inseridos com sucesso!");
        }

    }
}
