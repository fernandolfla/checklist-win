using CheckVTR.DAO;
using CheckVTR.Entity;
using CheckVTR.Seguranca;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVTR.BLL
{
    public class CheckListBLL
    {

        public List<Chave> ListaChaves()
        {
            CheckListDAO DAO = new CheckListDAO();

            DataTable Result = new DataTable();
            Result = DAO.ListaChaves();

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    List<Chave> C = new List<Chave>();
                    try
                    {
                        foreach (DataRow linha in Result.Rows)
                        {
                            Chave c = new Chave();
                            c.Id = linha.ItemArray[0].ToString();
                            c.Nome = linha.ItemArray[1].ToString();
                            c.Area = linha.ItemArray[2].ToString();

                            C.Add(c);
                        }

                    }
                    catch (Exception) { return null; }
                    return C;
                }
            return null;
        }



        public bool Cadastra(Check c)
        {
            int checkID = 0;
            CheckListDAO DAO = new CheckListDAO();
            DataTable Result = new DataTable();
            
            Result = DAO.Cadastra(c, Autenticacao.GetCodUsuario());
            if (Result != null)
                if (Result.Rows.Count > 0)
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        try { checkID = Convert.ToInt32(Result.Rows[0].ItemArray[0]); } catch { }

                        foreach(Chave p in c.Chaves)
                        {
                            DataTable Result2 = new DataTable();
                            Result2 = DAO.Cadastra_Chaves(p, checkID, Autenticacao.GetCodUsuario());
                            if (Result2 != null)
                                if (Result2.Rows[0].ItemArray[0].ToString().Equals("1"))
                                    continue;
                                else
                                    break;
                        }

                        foreach(Item i in c.Itens)
                        {
                            DataTable Result3 = new DataTable();
                            Result3 = DAO.Cadastra_Itens(i, checkID, Autenticacao.GetCodUsuario());
                            if(Result3 != null)
                                if (Result3.Rows[0].ItemArray[0].ToString().Equals("1"))
                                    continue;
                                else
                                    break;
                        }

                        return true;
                    }
                    else return false;
            return false;
        }


        public bool Cadastra_Finaliza(string km, string obs)
        {
            CheckListDAO DAO = new CheckListDAO();
            DataTable Result = new DataTable();
            if(!string.IsNullOrEmpty(km))
            {
                if (string.IsNullOrEmpty(obs))
                    obs = "Plantão S.A.";

                Result = DAO.Cadastra_Finaliza(km, obs, Autenticacao.GetCodUsuario());
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                            return true;
            }          
            return false;
        }





   }
}
