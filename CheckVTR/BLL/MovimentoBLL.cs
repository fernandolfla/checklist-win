using CheckVTR.Component;
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
    public class MovimentoBLL
    {

        public bool Abre(Caixa_Situacao c)
        {
            if(c.Situacao_Id == 0)
            {
               
                MovimentoDAO DAO = new MovimentoDAO();
                DataTable Result = new DataTable();
                Result = DAO.Abre(c, Autenticacao.GetCodUsuario());
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                        {
                            try { Autenticacao.SetCaixa((int)Result.Rows[0].ItemArray[0]); }
                            catch { Autenticacao.SetCaixa(0); }
                            return true;
                        }
            }
            return false;
        }
        public bool Fecha(Caixa_Situacao c)
        {
            if (c.Situacao_Id == 1)
            {
                MovimentoDAO DAO = new MovimentoDAO();
                DataTable Result = new DataTable();
                Result = DAO.Fecha(c, Autenticacao.GetCodUsuario());
                if (Result != null)
                    if (Result.Rows.Count > 0)
                        if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                        {
                            c = null;
                            c = new Caixa_Situacao();
                            c.Situacao_Id = 0;
                            c.Caixa_Id = 0;
                            Autenticacao.SetCaixa(0);
                            Autenticacao.SetCaixa_Situacao(c);
                            return true;
                        }
            }
            return false;
        }
        public bool Cadastra(Caixa_Movimento c)
        {
            if (string.IsNullOrEmpty(c.Descricao))
                c.Descricao = "S.A.";
            if (string.IsNullOrEmpty(c.Autorizado))
                c.Autorizado = Autenticacao.GetApelido();
            if(c.SaidaEntrada == 1)
                if (string.IsNullOrEmpty(c.Numcupom))
                     return false;
            if(c.Abastecimento == 1)
            {
                if (string.IsNullOrEmpty(c.KM))
                    return false;
                if (string.IsNullOrEmpty(c.Placa))
                    return false;
                if (string.IsNullOrEmpty(c.Tatico))
                    return false;
            }
            else
            {
                c.Tatico = "Operador";
            }

                    if (c.Valor > 0)
                    {
                        MovimentoDAO DAO = new MovimentoDAO();
                        DataTable Result = new DataTable();
                        c.Caixa_Situacao_Id = Autenticacao.GetCaixa_Situacao().Id;
                        Result = DAO.Cadastra(c, Autenticacao.GetCodUsuario());
                        if (Result != null)
                            if (Result.Rows.Count > 0)
                                if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                    return true;
                                else return false;
                    }
                            

            return false;
        }


        public Caixa_Situacao BuscaCaixa_Situacao(int id)
        {
            MovimentoDAO DAO = new MovimentoDAO();
            DataTable Result = new DataTable();
            Caixa_Situacao cx = new Caixa_Situacao();


            Result = DAO.BuscaCaixa_Situacao(id);
            if (Result != null)
                if (Result.Rows.Count > 0)
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        cx.Id = id;                     
                        try { cx.Caixa_Id = (int)Result.Rows[0].ItemArray[1]; }catch{ }
                        try { cx.Situacao_Id = (int)Result.Rows[0].ItemArray[2]; }catch { }
                        try { cx.Situacao_Nome = Result.Rows[0].ItemArray[3].ToString(); }catch { }
                        try { cx.ValorInicial = Convert.ToDouble(Result.Rows[0].ItemArray[4].ToString()); }catch { }
                        try { cx.TotalEntradas = Convert.ToDouble(Result.Rows[0].ItemArray[5].ToString()); }catch { }
                        try { cx.TotalSaidas = Convert.ToDouble(Result.Rows[0].ItemArray[6].ToString()); }catch { }
                        try { cx.DataAbertura = Convert.ToDateTime(Result.Rows[0].ItemArray[7].ToString()); }catch { }
                        try { cx.DataFechamento = Convert.ToDateTime(Result.Rows[0].ItemArray[8].ToString()); } catch { }
                        try { cx.TotalDinheiro = Convert.ToDouble(Result.Rows[0].ItemArray[9].ToString()); }catch { }
                        return cx;
                    }

            return null;
        }


    }
}
