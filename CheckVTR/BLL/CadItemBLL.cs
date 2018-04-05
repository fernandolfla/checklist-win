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
    class CadItemBLL
    {
        public bool Cadastra(Item c)
        {
                    if (!string.IsNullOrEmpty(c.Nome))
                        if (c.Nome.Length > 2)
                            {
                                CadItemDAO DAO = new CadItemDAO();
                                DataTable Result = new DataTable();

                                Result = DAO.Cadastra(c, Autenticacao.GetCodUsuario());
                                if (Result != null)
                                    if (Result.Rows.Count > 0)
                                        if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                            return true;
                                        else return false;
                            }


            return false;
        }




        public Item BuscaProx(Item c)
        {

            CadItemDAO DAO = new CadItemDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaProx(c);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        c = DataToItem(Result, c);
                        return c;
                    }
                    else return null;
                }
                else
                {
                    c.Id = null;
                    Result = DAO.BuscaProx(c);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                c = DataToItem(Result, c);
                                return c;
                            }
                        }
                }
            return null;
        }


        public Item BuscaAnt(Item c)
        {
            CadItemDAO DAO = new CadItemDAO();
            DataTable Result = new DataTable();

            Result = DAO.BuscaAnt(c);

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        c = DataToItem(Result, c);
                        return c;
                    }
                    else return null;
                }
                else
                {
                    c.Id = null;
                    Result = DAO.BuscaAnt(c);
                    if (Result != null)
                        if (Result.Rows.Count > 0)
                        {
                            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                            {
                                c = DataToItem(Result, c);
                                return c;
                            }
                        }
                }
            return null;
        }

        public bool Apaga(string cod)
        {

            CadItemDAO DAO = new CadItemDAO();
            if (!string.IsNullOrEmpty(cod))
            {

                DataTable Result = new DataTable();

                Result = DAO.Apaga(cod, Autenticacao.GetCodUsuario());
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                            return true;
            }
            return false;
        }


        private Item DataToItem(DataTable data, Item c)
        {

            c.Id = data.Rows[0].ItemArray[0].ToString();
            c.Nome = data.Rows[0].ItemArray[1].ToString();

            return c;
        }

        public List<Item> ListaItem()
        {
            CadItemDAO DAO = new CadItemDAO();

            DataTable Result = new DataTable();
            Result = DAO.ListaItem();

            if (Result != null)
                if (Result.Rows.Count > 0)
                {
                    List<Item> C = new List<Item>();
                    try
                    {
                        foreach (DataRow linha in Result.Rows)
                        {
                            Item c = new Item();
                            c.Nome = linha.ItemArray[0].ToString();
                            try { c.Tipo = Convert.ToInt32(linha.ItemArray[1]); } catch { c.Tipo = 0; }

                            C.Add(c);
                        }

                    }
                    catch (Exception) { return null; }
                    return C;
                }
            return null;
        }

    }
}
