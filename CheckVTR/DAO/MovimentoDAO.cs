using CheckVTR.Component;
using CheckVTR.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVTR.DAO
{
     class MovimentoDAO : Connection
    {
        public DataTable Cadastra(Caixa_Movimento c, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_Mov_Cadastra_Caixa_Movimento", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.Int).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@CAIXA_SITUACAO", SqlDbType.Int).Value = c.Caixa_Situacao_Id;
                Cmd.SelectCommand.Parameters.Add("@TIPO_MOVIMENTO", SqlDbType.VarChar).Value = c.TipoMovimento;
                Cmd.SelectCommand.Parameters.Add("@ENTRADA_SAIDA", SqlDbType.Int).Value = c.SaidaEntrada;
                Cmd.SelectCommand.Parameters.Add("@VALOR", SqlDbType.Money).Value = c.Valor;
                Cmd.SelectCommand.Parameters.Add("@NUMCUPOM", SqlDbType.NText).Value = c.Numcupom;
                Cmd.SelectCommand.Parameters.Add("@DESCRICAO", SqlDbType.NText).Value = c.Descricao;
                Cmd.SelectCommand.Parameters.Add("@TATICO", SqlDbType.VarChar).Value = c.Tatico;
                Cmd.SelectCommand.Parameters.Add("@PLACA", SqlDbType.VarChar).Value = c.Placa;
                Cmd.SelectCommand.Parameters.Add("@KM", SqlDbType.VarChar).Value = c.KM;
                Cmd.SelectCommand.Parameters.Add("@AUTORIZADO", SqlDbType.VarChar).Value = c.Autorizado;
                Cmd.SelectCommand.Parameters.Add("@ABASTECIMENTO", SqlDbType.Int).Value = c.Abastecimento;
                Cmd.SelectCommand.Parameters.Add("@IMAGEM", SqlDbType.Image).Value = c.Imagem;
                Cmd.SelectCommand.Parameters.Add("@SANGRIANF", SqlDbType.Int).Value = c.SangriaNF;


                DataTable data = new DataTable();

                Cmd.Fill(data);
                Fechar();
                return data;

            }
            catch (Exception e)
            {
                Erros.SetErroBanco(e);
                Erros.SetHaErro(true);
            }
            finally
            {
                Fechar();
            }
            return null;
        }


        public DataTable Abre(Caixa_Situacao c, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_Mov_AbreCaixa", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.Int).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@VALORINICIAL", SqlDbType.Money).Value = c.ValorInicial;

                DataTable data = new DataTable();

                Cmd.Fill(data);
                Fechar();
                return data;

            }
            catch (Exception e)
            {
                Erros.SetErroBanco(e);
                Erros.SetHaErro(true);
            }
            finally
            {
                Fechar();
            }
            return null;
        }

        public DataTable Fecha(Caixa_Situacao c, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_Mov_FechaCaixa", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = c.Id;
                DataTable data = new DataTable();

                Cmd.Fill(data);
                Fechar();
                return data;

            }
            catch (Exception e)
            {
                Erros.SetErroBanco(e);
                Erros.SetHaErro(true);
            }
            finally
            {
                Fechar();
            }
            return null;
        }

        public DataTable Verifica(int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_Mov_Verifica_Caixa_Aberto_POR_USUARIO", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
               

                DataTable data = new DataTable();

                Cmd.Fill(data);
                Fechar();
                return data;

            }
            catch (Exception e)
            {
                Erros.SetErroBanco(e);
                Erros.SetHaErro(true);
            }
            finally
            {
                Fechar();
            }
            return null;
        }
        public DataTable BuscaCaixa_Situacao(int id)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_Mov_Busca_Caixa_Corrente", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("ID", SqlDbType.Int).Value = id;


                DataTable data = new DataTable();

                Cmd.Fill(data);
                Fechar();
                return data;

            }
            catch (Exception e)
            {
                Erros.SetErroBanco(e);
                Erros.SetHaErro(true);
            }
            finally
            {
                Fechar();
            }
            return null;
        }


       



    }
}
