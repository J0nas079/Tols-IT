using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Tols_IT.Models
{
    public class Desktop
    {
        public int id_desktop { get; set; }
        public string usuario { get; set; }
        public string host_name { get; set; }
        public string modelo { get; set; }
        public string processador { get; set; }
        public string memoriaRam { get; set; }
        public string sistemaOperacional { get; set; }
        public string setor { get; set; }

    }

    public class Email
    {
        public int id_email { get; set; }
        public string usuario { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string Cargo { get;set; }
        public string setor { get;set;}

    }
    public class Impressoras
    {
        public int id_impressoras { get; set; }
        public string proprietario { get; set; }
        public string setor { get; set; }
        public string modelo { get; set; }
        public string ip { get; set; }
        public string descricao { get; set; }
        public string fabricante { get; set; }
        public int np { get; set; }
        public string TipoImpr { get; set; }
    }
    public class Reps
    {
        public int id_rps { get; set; }
        public string setor { get; set; }
        public int ip { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public bool situacao { get; set; }

    }
    public class Catracas
    {
        public int id_atracas { get; set; }
        public int np { get; set; }
        public string setor { get; set; }
        public int ip { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public bool situacao { get; set; }
    }
    public class Usuarios
    {
        public int id_usuario { get; set; }
        public string matricula { get; set; }
        public string nome { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
    }
}
