using System.Data;
using System.Data.Common;
using Tols_IT.Models;
using Tols_IT.UIX;

namespace Tols_IT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionDB.CriarBancoSqlite();
            ConnectionDB.CriarTabelas();
        }
        //Criando o data gradeView e passando os dados dos DB_Desktop
        private void ExibirDadosDesktop()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ConnectionDB.GetDesktop();
                dataView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
        private void Exibir_email()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ConnectionDB.GetEmail();
                dataView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO" + ex.Message);
            }
        }
        //Passando dadados do banco catracadas para o datagradeview
        private void GetCatracas()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ConnectionDB.GetCatracas();
                dataView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO", ex.Message);
            }
        }
        //Passando dadados do banco rep's para o datagradeview
        private void GetReps()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ConnectionDB.GetRep();
                dataView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO", ex.Message);
            }
        }
        //Passando dadados do banco Impressoras para o datagradeview
        private void GetImpressora()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ConnectionDB.GetImpressoras();
                dataView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO", ex.Message);
            }
        }
        //Chamando as tabelas com os inputs
        private void btnlistar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Enabled = true;
            txtPesquisar.Focus();
            this.ExibirDadosDesktop();
        }
        private void btnemail_Click(object sender, EventArgs e)
        {
            txtPesquisar.Enabled = Enabled;
            this.Exibir_email();

        }
        private void btncatraca_Click(object sender, EventArgs e)
        {
            txtPesquisar.Enabled = false;
            GetCatracas();
        }
        private void btnrep_Click(object sender, EventArgs e)
        {
            txtPesquisar.Enabled = false;
            this.GetReps();

        }
        private void btnimpressora_Click(object sender, EventArgs e)
        {
            txtPesquisar.Enabled = false;
            this.GetImpressora();
        }

        //Input pesquisa para os desktop
        public void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (txtPesquisar.Text != string.Empty)
            {
                string usuario = txtPesquisar.Text;
                dt = ConnectionDB.GetPesquisa(usuario);
            }
            else
            {
                dt = ConnectionDB.GetDesktop();
            }

            dataView1.DataSource = dt;
            txtPesquisar.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UiIDesk frm = new UiIDesk();
            frm.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.GetImpressora();
        }
        //Chamando primeira tela de cadastro
        private void button2_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.ShowDialog();
        }
        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UiEmail uiEmail = new UiEmail();
            uiEmail.Show();
        }
        private void desktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UiIDesk form = new UiIDesk();
            form.ShowDialog();
        }
        private void impressorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UixImpressroas uixImpressroas = new UixImpressroas();
            uixImpressroas.ShowDialog();
        }

        private void dataView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            string test = e.Button.ToString();
            if (test == "Right")
            {
                MessageBox.Show(test);
            }
        }
    }
}
