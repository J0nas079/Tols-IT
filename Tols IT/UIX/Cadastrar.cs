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
using static System.Net.Mime.MediaTypeNames;

namespace Tols_IT.UIX
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void impressorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UixImpressroas uixImpressroas = new UixImpressroas();
            uixImpressroas.ShowDialog();

        }

        private void desktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UiIDesk form2 = new UiIDesk();
            form2.ShowDialog();
        }


    }
}
