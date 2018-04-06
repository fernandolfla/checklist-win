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
    class ConfiguracoesDAO : Connection
    {

        public DataTable ListaAtivos()
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_Configuracao", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

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

        public DataTable Atualiza(Configuracao c, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_AtualizaConfiguracao", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@RAZAO", SqlDbType.VarChar).Value = c.Razao;
                Cmd.SelectCommand.Parameters.Add("@FANTASIA", SqlDbType.VarChar).Value = c.Fantasia;
                Cmd.SelectCommand.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = c.CNPJ;
                Cmd.SelectCommand.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = c.Endereco;
                Cmd.SelectCommand.Parameters.Add("@NUMERO", SqlDbType.VarChar).Value = c.Numero;
                Cmd.SelectCommand.Parameters.Add("@TELEFONE", SqlDbType.VarChar).Value = c.Telefone;
                Cmd.SelectCommand.Parameters.Add("@RESPONSAVEL", SqlDbType.VarChar).Value = c.Responsavel;
                Cmd.SelectCommand.Parameters.Add("@QTDVEICULOS", SqlDbType.VarChar).Value = c.QtdVeiculos;
                Cmd.SelectCommand.Parameters.Add("@QTDAREAS", SqlDbType.VarChar).Value = c.QtdAreas;


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

        public DataTable Busca()
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaConfiguracao", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

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
