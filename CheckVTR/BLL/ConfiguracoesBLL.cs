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
    class ConfiguracoesBLL
    {

        public DataTable ListaAtivos()
        {
            ConfiguracoesDAO DAO = new ConfiguracoesDAO();
            DataTable Result = new DataTable();

            Result = DAO.ListaAtivos();
            if (Result != null)
                if (Result.Rows.Count > 0)
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                        return Result;

            return null;
        }


        public bool Atualiza(Configuracao c)
        {
            int veiculos = 1;
            int area = 1;
            if (!string.IsNullOrEmpty(c.Razao))
                if (!string.IsNullOrEmpty(c.Fantasia))
                    if (!string.IsNullOrEmpty(c.CNPJ))
                        if (!string.IsNullOrEmpty(c.Endereco))
                            if (!string.IsNullOrEmpty(c.Numero))
                                if (!string.IsNullOrEmpty(c.Telefone))
                                    if (!string.IsNullOrEmpty(c.Responsavel))
                                        if (!string.IsNullOrEmpty(c.QtdVeiculos))
                                            if (!string.IsNullOrEmpty(c.QtdAreas))                                              
                                            {
                                                try { veiculos = Convert.ToInt32(c.QtdVeiculos); }
                                                catch { veiculos = 1; }
                                                try { area = Convert.ToInt32(c.QtdAreas); }
                                                catch { area = 1; }

                                                c.QtdVeiculos = veiculos.ToString();
                                                c.QtdAreas = area.ToString();

                                                ConfiguracoesDAO DAO = new ConfiguracoesDAO();
                                                DataTable Result = new DataTable();

                                                Result = DAO.Atualiza(c, Autenticacao.GetCodUsuario());
                                                if (Result != null)
                                                    if (Result.Rows.Count > 0)
                                                        if (Result.Rows[0].ItemArray[0].ToString().Equals("1"))
                                                            return true;
                                                        else return false;
                }


            return false;
        }

        public Entity.Configuracao Busca()
        {
            ConfiguracoesDAO DAO = new ConfiguracoesDAO();
            DataTable Result = new DataTable();
            Entity.Configuracao c = new Configuracao();

            Result = DAO.Busca();
            if (Result != null)
                if (Result.Rows.Count > 0)
                    if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
                    {
                        c = DataToConfiguracao(Result);
                        return c;
                    }

               return null;
        }

        //public Caixa_Situacao BuscaCaixa_Situacao(int id)
        //{
        //    MovimentoDAO DAO = new MovimentoDAO();
        //    DataTable Result = new DataTable();
        //    Caixa_Situacao cx = new Caixa_Situacao();


        //    Result = DAO.BuscaCaixa_Situacao(id);
        //    if (Result != null)
        //        if (Result.Rows.Count > 0)
        //            if (!Result.Rows[0].ItemArray[0].ToString().Equals("-1"))
        //            {
        //                cx.Id = id;                     
        //                try { cx.Caixa_Id = (int)Result.Rows[0].ItemArray[1]; }catch{ }
        //                try { cx.Situacao_Id = (int)Result.Rows[0].ItemArray[2]; }catch { }
        //                try { cx.Situacao_Nome = Result.Rows[0].ItemArray[3].ToString(); }catch { }
        //                try { cx.ValorInicial = Convert.ToDouble(Result.Rows[0].ItemArray[4].ToString()); }catch { }
        //                try { cx.TotalEntradas = Convert.ToDouble(Result.Rows[0].ItemArray[5].ToString()); }catch { }
        //                try { cx.TotalSaidas = Convert.ToDouble(Result.Rows[0].ItemArray[6].ToString()); }catch { }
        //                try { cx.DataAbertura = Convert.ToDateTime(Result.Rows[0].ItemArray[7].ToString()); }catch { }
        //                try { cx.DataFechamento = Convert.ToDateTime(Result.Rows[0].ItemArray[8].ToString()); } catch { }
        //                try { cx.TotalDinheiro = Convert.ToDouble(Result.Rows[0].ItemArray[9].ToString()); }catch { }
        //                return cx;
        //            }

        //    return null;
        //}


        private Entity.Configuracao DataToConfiguracao(DataTable data)
        {
            Entity.Configuracao c = new Configuracao();
            c.Razao = data.Rows[0].ItemArray[0].ToString();
            c.Fantasia = data.Rows[0].ItemArray[1].ToString();
            c.CNPJ = data.Rows[0].ItemArray[2].ToString();
            c.Endereco = data.Rows[0].ItemArray[3].ToString();
            c.Numero = data.Rows[0].ItemArray[4].ToString();
            c.Telefone = data.Rows[0].ItemArray[5].ToString();
            c.Responsavel = data.Rows[0].ItemArray[6].ToString();
            c.QtdVeiculos = data.Rows[0].ItemArray[7].ToString();
            c.QtdAreas = data.Rows[0].ItemArray[8].ToString();

            return c;
        }

    }
}
