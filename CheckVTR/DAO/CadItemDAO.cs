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
    class CadItemDAO : Connection
    {

        public DataTable Cadastra(Item c, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_Cadastra_Itens", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = c.Nome;
                Cmd.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar).Value = c.Tipo;

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



        public DataTable BuscaProx(Item c)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaProxItem", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(c.Id))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 0;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = c.Id;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
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

        public DataTable BuscaAnt(Item c)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_BuscaAntItem", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(c.Id))
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = 9999;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
                else
                {
                    Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = c.Id;
                    DataTable data = new DataTable();
                    Cmd.Fill(data);
                    Fechar();
                    return data;
                }
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


        public DataTable Apaga(string cod, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ApagaItem", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = cod;
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
