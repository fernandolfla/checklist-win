using CheckVTR.Component;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVTR.DAO
{
    class Connection
    {
        public SqlConnection con = null;

        private string _conexao;
        private string _conexao2;
        public Connection()
        {
            //ConfiTxt confi = new ConfiTxt();
            //confi = LerArquivo.Ler();

            _conexao = "Data Source=" + LerArquivo.confi.Server + "\\" + LerArquivo.confi.Instancia + ";Initial Catalog=VTR;Integrated Security=FALSE;User ID=" + LerArquivo.confi.User + ";Password=" + LerArquivo.confi.Password + ";Connect Timeout=30";
            _conexao2 = "Data Source=" + LerArquivo.confi.Server + ";Initial Catalog=VTR;Integrated Security=FALSE;User ID=" + LerArquivo.confi.User + ";Password=" + LerArquivo.confi.Password + ";Connect Timeout=30";
        }





        public void CriarConexao()
        {
            if(LerArquivo.confi.Server.ToUpper().Equals("LOCALHOST"))
                con = new SqlConnection(_conexao);
            else
                con = new SqlConnection(_conexao2);

        }

        //public void CriarConexaoCep()
        //{
        //    con = new SqlConnection(_conexao2);
        //}

        public void Abrir()
        {

            if (con != null)
            {
                con.Close();
                con.Open();
            }
            else
                con.Open();
        }

        public void Fechar()
        {
            con.Close();
        }


    }
}
