using CheckVTR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVTR.Seguranca
{
    static class Autenticacao
    {
        static int CodUsuario;
        static string NomeUsuario;
        static string Apelido;
        static int UltimoCheckList;

        static string Serial;
        static string Versao;
        static string Atualizacao;

        static string Servidor;

        static int Situacao;

        //static int Caixa;
        static int Tipo;
        static Caixa_Situacao Caixa = new Caixa_Situacao();


        public static void Login(int codUsuario, string nomeUsuario, string apelido, int situacao, int tipo)
        {

            CodUsuario = codUsuario;
            NomeUsuario = nomeUsuario;
            Apelido = apelido;
            Situacao = situacao;
            Tipo = tipo;

            Serial = "Juriseg v.0.1";
            Versao = "Check-List VTR";
            Atualizacao = "Beta.v.0.01";

        }

        public static void SetCaixa(int id)
        {
            //Caixa.Caixa_Id = caixa_id;
            Caixa.Id = id;
            //Caixa.Situacao_Id = situacao_id;
        }
        public static void SetCaixa_Situacao(Caixa_Situacao cx)
        {
            //Caixa.Caixa_Id = caixa_id;
            Caixa = cx;
            //Caixa.Situacao_Id = situacao_id;
        }
        public static void SetTipo(int tp)
        {
            Tipo = tp;
        }
        public static void SetUsuario(int codUsuario)
        {
            CodUsuario = codUsuario;
        }
        public static int GetUltimoCheckList()
        {
            return UltimoCheckList;
        }
        public static int GetSituacaoUsuario()
        {
            return Situacao;
        }
        public static string GetNomeUsuario()
        {
            return NomeUsuario;
        }

        public static int GetCodUsuario()
        {
            return CodUsuario;
        }
        public static string GetApelido()
        {
            return Apelido;
        }
        public static Caixa_Situacao GetCaixa_Situacao()
        {
            return Caixa;
        }
        public static int GetTipo()
        {
            return Tipo;
        }

        public static string GetVersao()
        {
            return Versao;
        }
        public static string GetAtualizacao()
        {
            return Atualizacao;
        }
        public static string GetSerial()
        {
            return Serial;
        }

        public static void SetServidor(string servidor)
        {
            Servidor = servidor;
        }
        public static string GetServidor()
        {
            return Servidor;
        }
    }
}
