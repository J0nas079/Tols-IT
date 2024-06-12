using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Diagnostics;

namespace Tols_IT.Models
{
    public class ConnectionDB
    {
        //Salvando o banco no diretorio local
        public static string path = Directory.GetCurrentDirectory() + "banco.sqlite";
        private static SQLiteConnection sqliteConnetion;
        private static SQLiteConnection Dbconnetion()
        {
            sqliteConnetion = new SQLiteConnection("Data Source=" + path);
            sqliteConnetion.Open();
            return sqliteConnetion;
        }
        public static void CriarBancoSqlite()
        {
            try
            {
                if (File.Exists(path) == false)
                {
                    SQLiteConnection.CreateFile(path);
                }
            }
            catch
            {
                throw;
            }
        }
        public static void CriarTabelas()
        {
            //Criando toda as tabelas
            try
            {
                //Banco de dados Desktop
                using (var cmd = Dbconnetion().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS T_desktop(id_desktop INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL" +
                        ",usuario TEXT NOT NULL," +
                        "host_name TEXT NOT NULL," +
                        "modelo TEXT," +
                        "processador TEXT," +
                        "memoria_ram TEXT," +
                        "sistema_operacional TEXT,"  +
                        "setor TEXT NOT NULL)";
                    cmd.ExecuteNonQuery();
                }
                //Banco de dados E-mail
                using(var cmd= Dbconnetion().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS T_email(id_email INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "nome TEXT NOT NULL," +
                        "email TEXT NOT NULL," +
                        "senha TEXT NOT NULL," +
                        "cargo TEXT NOT NULL," +
                        "setor TEXT)";
                    cmd.ExecuteNonQuery();
                }

                using(var cmd = Dbconnetion().CreateCommand())
                {
                    //Banco de dados Impressoras
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS T_impressoras(id_impressoras INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "proprietario TEXT," +
                        "setor TEXT," +
                        "modelo TEXT," +
                        "ip TEXT NOT NULL," +
                        "tipo_impressora TEXT," +
                        "fabricante TEXT," +
                        "np INTEGER NOT NULL)";
                    cmd.ExecuteNonQuery();
                }
                //Banco de dados REP'S
                using(var cmd = Dbconnetion().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS T_reps(id_rep INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "setor TEXT NOT NULL," +
                        "ip TEXT NOT NULL," +
                        "usuario_adm TEXT NOT NULL," +
                        "senha_adm TEXT NOT NULL," +
                        "situacao TEXT)";
                    cmd.ExecuteNonQuery();
                }
                //Banco de dados Catracas
                using (var cmd=Dbconnetion().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS T_catracas(id_catracas INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "np INTEGER NOT NULL," +
                        "local TEXT NOT NULL," +
                        "ip TEXT NOT NULL," +
                        "usuario_adm TEXT NOT NULL," +
                        "senha TEXT NOT NULL," +
                        "situacao TEXT)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }
        public static DataTable GetDesktop()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Dbconnetion().CreateCommand())
                {
                    cmd.CommandText = "SELECT usuario," +
                        "host_name," +
                        "modelo" +
                        ",processador," +
                        "memoria_ram," +
                        "sistema_operacional," +
                        "setor FROM T_desktop ORDER BY setor";
                    da = new SQLiteDataAdapter(cmd.CommandText, Dbconnetion());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable GetEmail()
        {
            SQLiteDataAdapter da= null;
            DataTable dt = new DataTable();
            using (var cmd= Dbconnetion().CreateCommand())
            {
                cmd.CommandText = "SELECT nome,email,senha,cargo,setor FROM T_email";
                cmd.ExecuteReader();
                da = new SQLiteDataAdapter(cmd.CommandText, Dbconnetion());
                da.Fill(dt);
                return dt;
            }          
        }
        public static DataTable GetCatracas()
        {
           SQLiteDataAdapter da= null;
           DataTable dt = new DataTable();
            using(var cmd = Dbconnetion().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM  T_catracas";
                cmd.ExecuteReader();
                da = new SQLiteDataAdapter(cmd.CommandText, Dbconnetion());
                da.Fill(dt);
                return dt;
            }

        }
        public static DataTable GetRep()
        { 
            SQLiteDataAdapter da= null;
            DataTable dt = new DataTable();
            using(var cmd= Dbconnetion().CreateCommand())
            {
                cmd.CommandText = ("SELECT * FROM T_reps");
                cmd.ExecuteReader();
                da=new SQLiteDataAdapter(cmd.CommandText,Dbconnetion());
                da.Fill(dt);
                return dt ;
            }
        }
        public static DataTable GetImpressoras()
        {
            SQLiteDataAdapter da= null;
            DataTable dt = new DataTable();
            using(var cmd = Dbconnetion().CreateCommand())
            {
                cmd.CommandText = ("SELECT proprietario" +
                                   ",setor," +
                                   "modelo," +
                                   "ip," +
                                   "tipo_impressora," +
                                   "fabricante," +
                                   "np" +
                                   " FROM T_impressoras");
                cmd.ExecuteReader();
                da=new SQLiteDataAdapter(cmd.CommandText,Dbconnetion());
                da.Fill(dt);
                return dt ;
            }
        }

        public static DataTable GetPesquisa(string usuario)
        {
            SQLiteDataAdapter da= null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Dbconnetion().CreateCommand())
                {
                    cmd.CommandText = "SELECT usuario,host_name,modelo," +
                        "processador," +
                        "memoria_ram," +
                        "sistema_operacional," +
                        "setor" +
                        " FROM T_desktop WHERE usuario LIKE '%" + usuario + "%'" +
                        "ORDER BY usuario ";
                    da = new SQLiteDataAdapter(cmd.CommandText, Dbconnetion());
                    da.Fill(dt);
                    return dt;

                }
            }catch (Exception ex)
            {
                throw ex;
            }
        }
        //Pesquisando por e-mail
        public static DataTable GetEmail(string nome)
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;
            using(var cmd= Dbconnetion().CreateCommand())
            {
                cmd.CommandText = "SELECT nome,email,senha,cargo FROM T_email WHERE nome LIKE '%" + nome + "%'";
                da=new SQLiteDataAdapter(cmd.CommandText,Dbconnetion());
                da.Fill(dt);
                return dt;
            }
        }
        public static void Add(Desktop desktop)
        {
            try
            {
                using(var cmd = Dbconnetion().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO T_desktop(usuario," +
                        "host_name," +
                        "modelo," +
                        "processador," +
                        "memoria_ram," +
                        "sistema_operacional," +
                        "setor) " +
                        "VALUES(@usuario," +
                        "@host_name," +
                        "@modelo," +
                        "@processador," +
                        "@memoria_ram," +
                        "@sistema_operacional," +
                        "@setor)";

                    cmd.Parameters.AddWithValue("@usuario", desktop.usuario);
                    cmd.Parameters.AddWithValue("@host_name", desktop.host_name);
                    cmd.Parameters.AddWithValue("@modelo", desktop.modelo);
                    cmd.Parameters.AddWithValue("@processador", desktop.processador);
                    cmd.Parameters.AddWithValue("@memoria_ram", desktop.memoriaRam);
                    cmd.Parameters.AddWithValue("@sistema_operacional", desktop.sistemaOperacional);
                    cmd.Parameters.AddWithValue("@setor", desktop.setor);
                    cmd.ExecuteNonQuery();

                }
            }catch (Exception ex)
            {
                MessageBox.Show("ERRO",ex.Message);
            }
        }
        public static void AddEmail(Email email)
        {
            try
            {
                using (var cmd = Dbconnetion().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO T_email(nome," +
                        "email," +
                        "senha," +
                        "cargo," +
                        "setor)" +
                        "VALUES(" +
                        "@nome," +
                        "@email," +
                        "@senha," +
                        "@cargo," +
                        "@setor)";

                    cmd.Parameters.AddWithValue("@nome", email.usuario);
                    cmd.Parameters.AddWithValue("@email", email.email);
                    cmd.Parameters.AddWithValue("@senha", email.senha);
                    cmd.Parameters.AddWithValue("@cargo", email.Cargo);
                    cmd.Parameters.AddWithValue("setor", email.setor);
                    cmd.ExecuteNonQuery();
                }
            }catch(Exception EX)
            {
                MessageBox.Show("Erro!!",EX.Message);
            }
            
        }
        public static void AddImpressoras(Impressoras impressoras)
        {
            using(var cmd=Dbconnetion().CreateCommand())
            {
                try
                {
                    cmd.CommandText = "INSERT INTO T_impressoras(" +
                                      "proprietario," +
                                      "setor," +
                                      "modelo," +
                                      "ip," +
                                      "tipo_impressora," +
                                      "fabricante," +
                                      "np) VALUES (" +
                                      "@proprietario," +
                                      "@setor," +
                                      "@modelo," +
                                      "@ip," +
                                      "@tipo_impressora," +
                                      "@fabricante," +
                                      "@np)";

                    cmd.Parameters.AddWithValue("@proprietario", impressoras.proprietario);
                    cmd.Parameters.AddWithValue("@setor", impressoras.setor);
                    cmd.Parameters.AddWithValue("@modelo", impressoras.modelo);
                    cmd.Parameters.AddWithValue("@ip", impressoras.ip);
                    cmd.Parameters.AddWithValue("@tipo_impressora", impressoras.TipoImpr);
                    cmd.Parameters.AddWithValue("@fabricante", impressoras.fabricante);
                    cmd.Parameters.AddWithValue("@np", impressoras.np);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                
            }
        }
    }

  
}
