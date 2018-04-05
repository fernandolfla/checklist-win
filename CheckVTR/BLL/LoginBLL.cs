using CheckVTR.DAO;
using CheckVTR.Seguranca;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CheckVTR.BLL
{
    class LoginBLL
    {

        public bool VerificaServidor()
        {

                LoginDAO DAO = new LoginDAO();

                DataTable Usuario = DAO.VerificaServidor();
                if (Usuario != null)
                    if (Usuario.Rows.Count > 0)
                    {
                        return true;
                    }          
            return false;
        }


        public string VerificaUsuario(string usuario)
        {
            if (!string.IsNullOrEmpty(usuario) || !usuario.Equals(""))
            {
                int CodUsuario = Convert.ToInt32(usuario);

                LoginDAO DAO = new LoginDAO();

                DataTable Usuario = DAO.VerificaUsuario(CodUsuario);
                if (Usuario != null)
                    if (Usuario.Rows.Count > 0)
                    {
                        return Usuario.Rows[0].ItemArray[1].ToString();

                    }

            }
            return "";
        }

        public int Logar(string usuario, string senha)
        {

            if (!string.IsNullOrEmpty(usuario) || !usuario.Equals("")) //0
            {
                    if (!string.IsNullOrEmpty(senha) || !senha.Equals("")) //2
                    {
                        int CodUsuario = Convert.ToInt32(usuario);

                        LoginDAO DAO = new LoginDAO();

                        DataTable Usuario = DAO.EfetuaLogin(CodUsuario, senha);
                        if (Usuario != null)
                            if (Usuario.Rows.Count > 0) 
                            {
                            try { Autenticacao.Login(Convert.ToInt32(usuario), Usuario.Rows[0].ItemArray[1].ToString(), Usuario.Rows[0].ItemArray[2].ToString(), Convert.ToInt32(Usuario.Rows[0].ItemArray[3]), Convert.ToInt32(Usuario.Rows[0].ItemArray[4])); }
                            catch (Exception) { return 2; }

                            if(Autenticacao.GetTipo() != 3)
                            {
                                MovimentoDAO DAO2 = new MovimentoDAO();
                                DataTable Data = new DataTable();
                                Data = DAO2.Verifica(Autenticacao.GetCodUsuario());
                                Autenticacao.SetCaixa(0);
                                if (Data != null)
                                    if (Data.Rows.Count > 0)
                                    {
                                        try { Autenticacao.SetCaixa((int)Data.Rows[0].ItemArray[0]); } catch { }
                                    }
                                //TERMINAR A INICIALIZAÇÂO DO CAIXA <<<<<<++++++============================
                            }

                            return 1;
                            }
                        return 3;
                    }
                    return 2;
            }
            return 0;
        }



    }
}
