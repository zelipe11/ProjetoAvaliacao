﻿using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAvaliacao.DAO
{
    public class PesquisaDAO
    {
        public static void InserirPesquisa(int codPesquisa, string descricaoPesq, string tipoPesq, int tipoAvaliacao, string formato, string dtInicio, string dtFim, int codSetor, int idPergunta)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"INSERT INTO fstpesquisarh (CODPESQ, DESCRICAOPESQ, TIPOPESQ, TIPOAVALIA, FORMATO, DTINICIO, DTFIM, CODSETOR, IDPERGUNTA)
                            VALUES(:codpesquisa, :descricaopesq, :tipopesq, :tipoavalia, :formato, 
                            CASE WHEN :dtinicio IS NULL THEN NULL ELSE TO_DATE(:dtinicio, 'DD/MM/YYYY') END, 
                            CASE WHEN :dtfim IS NULL THEN NULL ELSE TO_DATE(:dtfim, 'DD/MM/YYYY') END, 
                            :codsetor, :idpergunta)";


                cmdPagar.Parameters.AddWithValue(":codpesquisa", codPesquisa);
                cmdPagar.Parameters.AddWithValue(":descricaopesq", descricaoPesq);

                if (tipoPesq != null)
                    cmdPagar.Parameters.AddWithValue(":tipopesq", tipoPesq);
                else
                    cmdPagar.Parameters.AddWithValue(":tipopesq", DBNull.Value);

                cmdPagar.Parameters.AddWithValue(":tipoavalia", tipoAvaliacao);
                cmdPagar.Parameters.AddWithValue(":formato", formato);

                if (dtInicio != null) 
                    cmdPagar.Parameters.AddWithValue(":dtinicio", dtInicio);
                else
                    cmdPagar.Parameters.AddWithValue(":dtinicio", DBNull.Value);

                if (dtFim != null)
                    cmdPagar.Parameters.AddWithValue(":dtfim", dtFim);
                else
                    cmdPagar.Parameters.AddWithValue(":dtfim", DBNull.Value);

                if (codSetor != 0)
                    cmdPagar.Parameters.AddWithValue(":codsetor", codSetor);
                else
                    cmdPagar.Parameters.AddWithValue(":codsetor", DBNull.Value);

                cmdPagar.Parameters.AddWithValue(":idpergunta", idPergunta);
                


                cmdPagar.ExecuteNonQuery();

                transacao.Commit();
            }
            catch (Exception erro)
            {
                transacao.Rollback();
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        
        public static void InserirAvaliacao(int idavaliacao, int codfunc, DateTime dtInicio, DateTime dtFim, int idPergunta)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"INSERT INTO fstavaliacaorh (IDAVALIACAO, CODFUNC, DTINICIO, DTFIM, IDPERGUNTA)
                                        VALUES(:idavaliacao, :codfunc, TO_DATE(:dtinicio, 'DD/MM/YYYY'), TO_DATE(:dtfim, 'DD/MM/YYYY'), :idpergunta)";


                cmdPagar.Parameters.AddWithValue(":idavaliacao", idavaliacao);
                cmdPagar.Parameters.AddWithValue(":codfunc", codfunc);
                cmdPagar.Parameters.AddWithValue(":dtinicio", dtInicio);
                cmdPagar.Parameters.AddWithValue(":dtfim", dtFim);
                cmdPagar.Parameters.AddWithValue(":idpergunta", idPergunta);
                


                cmdPagar.ExecuteNonQuery();

                transacao.Commit();
            }
            catch (Exception erro)
            {
                transacao.Rollback();
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void AtualizarPesquisa(DateTime dtInicio, DateTime dtFim, int idPesq)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand comando = conexao.CreateCommand();
                comando.Transaction = transacao;

                comando.CommandText = @"UPDATE fstpesquisarh SET
                                        dtinicio = TO_DATE(:dtinicio, 'dd/MM/yyyy'),
                                        dtfim = TO_DATE(:dtfim, 'dd/MM/yyyy')
                                        WHERE codpesq = :idpesq";

                comando.Parameters.AddWithValue(":dtinicio", dtInicio);
                comando.Parameters.AddWithValue(":dtfim", dtFim);
                comando.Parameters.AddWithValue(":idpesq", idPesq);

                comando.ExecuteNonQuery();

                transacao.Commit();
            }
            catch (Exception erro)
            {
                transacao.Rollback();
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static DataTable TabelaPesquisa()
        {
            string sql = @"select p.codpesq, p.descricaopesq, p.tipopesq, (select descricao from fstavaliadoresrh where p.tipoavalia = codavali) avaliacao, 
                            CASE WHEN p.formato = 'I' then 'IDENTIFICADA' WHEN p.formato = 'A' then 'ANONIMA' END AS formatopesq, p.dtinicio, p.dtfim,
                            (select descricao from fstsetorrh where p.codsetor = codsetor) setor, idpergunta from fstpesquisarh p where dtexclusao is null ";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

    }
}
