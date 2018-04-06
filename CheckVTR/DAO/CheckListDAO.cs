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
    class CheckListDAO : Connection
    {

        public DataTable ListaChaves()
        {
            try
            {
                CriarConexao();
                Abrir();

                SqlDataAdapter Cmd = new SqlDataAdapter("SP_ListaChaves", con);

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



        public DataTable Cadastra(Check c, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_CadastraCheckList", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@TATICO", SqlDbType.VarChar).Value = c.Tatico;
                Cmd.SelectCommand.Parameters.Add("@AREA", SqlDbType.VarChar).Value = c.Area;
                Cmd.SelectCommand.Parameters.Add("@PLACA", SqlDbType.VarChar).Value = c.Placa;
                Cmd.SelectCommand.Parameters.Add("@KMINICIAL", SqlDbType.VarChar).Value = c.KmInicial;
                Cmd.SelectCommand.Parameters.Add("@OBS", SqlDbType.NText).Value = c.Obs;
                Cmd.SelectCommand.Parameters.Add("@COMBUSTIVEL", SqlDbType.VarChar).Value = c.Combustivel;

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



        public DataTable Cadastra_Chaves(Chave c, int checkID, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_CadastraCheckList_Chaves", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@CHECKID", SqlDbType.VarChar).Value = checkID;
                Cmd.SelectCommand.Parameters.Add("@CHAVEID", SqlDbType.VarChar).Value = c.Id;
                Cmd.SelectCommand.Parameters.Add("@CHAVENOME", SqlDbType.VarChar).Value = c.Nome;
                Cmd.SelectCommand.Parameters.Add("@CHECK", SqlDbType.VarChar).Value = c.Check;
                


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

        public DataTable Cadastra_Itens(Item c, int check , int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_CadastraCheckList_Itens", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@CHECK", SqlDbType.VarChar).Value = check;
                Cmd.SelectCommand.Parameters.Add("@ITEM", SqlDbType.VarChar).Value = c.Id;
                Cmd.SelectCommand.Parameters.Add("@CHECADO", SqlDbType.VarChar).Value = c.Check;



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

        public DataTable Cadastra_Finaliza(string km, string obs, int usuario)
        {
            try
            {
                CriarConexao();
                Abrir();
                SqlDataAdapter Cmd;

                Cmd = new SqlDataAdapter("SP_CadastraCheckList_Finaliza", con);

                Cmd.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = usuario;
                Cmd.SelectCommand.Parameters.Add("@KM", SqlDbType.VarChar).Value = km;
                Cmd.SelectCommand.Parameters.Add("@OBS", SqlDbType.NText).Value = obs;
                //Cmd.SelectCommand.Parameters.Add("@CHECK", SqlDbType.VarChar).Value = check;

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
