using Financeiro.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;

namespace Financeiro.Helper
{
    public static class SQLiteHelper
    {
        private static SQLiteConnection _connection;

        public static void OpenConnection()
        {
            CloseConnection();
            try
            {
                _connection = new SQLiteConnection("Data Source=financeiro.db;Version=3;FailIfMissing=True;");
                _connection.Open();
            }
            catch (Exception ex)
            {
                if (ex.Message == "unable to open database file")
                {
                    SQLiteConnection.CreateFile("financeiro.db");
                    _connection = new SQLiteConnection("Data Source=financeiro.db;Version=3;");
                    _connection.Open();

                    string sql = "CREATE TABLE rendaDiaria (dataMovimento TEXT, valorDinheiro REAL, valorCartao REAL)";
                    SQLiteCommand command = new SQLiteCommand(sql, _connection);
                    command.ExecuteNonQuery();

                    sql = "CREATE TABLE despesaMensal (dataVencimento TEXT, descricao TEXT, valor REAL, tipoDespesa INTEGER, tipoPagamento INTEGER)";
                    command = new SQLiteCommand(sql, _connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    throw;
                }
            }
        }

        public static void CloseConnection()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public static void InsertRendaDiaria(string dataMovimento, decimal valorDinheiro, decimal valorCartao)
        {
            string sql = string.Format("SELECT COUNT(1) FROM rendaDiaria WHERE dataMovimento = '{0}'", dataMovimento);
            var command = new SQLiteCommand(sql, _connection);
            var rows = command.ExecuteScalar();

            if (int.Parse(rows.ToString()) == 0)
            {
                sql = string.Format("INSERT INTO rendaDiaria (dataMovimento, valorDinheiro, valorCartao) VALUES ('{0}', {1}, {2})", dataMovimento, valorDinheiro.ToString().Replace(",", "."), valorCartao.ToString().Replace(",", "."));
            }
            else
            {
                sql = string.Format("UPDATE rendaDiaria SET valorDinheiro = valorDinheiro + {0}, valorCartao = valorCartao + {1} WHERE dataMovimento = '{2}'", valorDinheiro.ToString().Replace(",", "."), valorCartao.ToString().Replace(",", "."), dataMovimento);
            }

            command = new SQLiteCommand(sql, _connection);
            command.ExecuteNonQuery();
        }

        public static IEnumerable<RendaDiaria> SelectRendaDiaria()
        {
            string sql = string.Format("SELECT * FROM rendaDiaria WHERE dataMovimento >= '{0}' AND dataMovimento < '{1}' ORDER BY dataMovimento DESC", new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToString("yyyyMMdd"), new DateTime(DateTime.Now.AddMonths(1).Year, DateTime.Now.AddMonths(1).Month, 1).ToString("yyyyMMdd"));
            var command = new SQLiteCommand(sql, _connection);
            var reader = command.ExecuteReader();
            var retorno = new List<RendaDiaria>();
            while (reader.Read())
            {
                var row = new RendaDiaria()
                {
                    DataMovimento = DateTime.ParseExact(reader.GetString(0), "yyyyMMdd", CultureInfo.InvariantCulture),
                    ValorDinheiro = reader.GetDecimal(1),
                    ValorCartao = reader.GetDecimal(2)
                };
                retorno.Add(row);
            }
            return retorno;
        }

        public static IEnumerable<DespesaMensal> SelectDespesaMensal()
        {
            string sql = string.Format("SELECT * FROM despesaMensal WHERE dataVencimento >= '{0}' AND dataVencimento < '{1}' ORDER BY dataVencimento DESC", new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToString("yyyyMMdd"), new DateTime(DateTime.Now.AddMonths(1).Year, DateTime.Now.AddMonths(1).Month, 1).ToString("yyyyMMdd"));
            var command = new SQLiteCommand(sql, _connection);
            var reader = command.ExecuteReader();
            var retorno = new List<DespesaMensal>();
            while (reader.Read())
            {
                var row = new DespesaMensal()
                {
                    DataVencimento = DateTime.ParseExact(reader.GetString(0), "yyyyMMdd", CultureInfo.InvariantCulture),
                    Descricao = reader.GetString(1),
                    Valor = reader.GetDecimal(2),
                    TipoDespesa = reader.GetInt32(3) == (int)TipoDespesa.FIXA ? "FIXA" : "GERAL",
                    TipoPagamento = reader.GetInt32(4) == (int)TipoPagamento.BOLETO ? "BOLETO" : reader.GetInt32(4) == (int)TipoPagamento.CHEQUE ? "CHEQUE" : "DINHEIRO"
                };
                retorno.Add(row);
            }
            return retorno;
        }

        public static void InsertDespesaMensal(string dataVencimento, string descricao, decimal valor, int tipoDespesa, int tipoPagamento)
        {
            string sql = string.Format("INSERT INTO despesaMensal (dataVencimento, descricao, valor, tipoDespesa, tipoPagamento) VALUES ('{0}', '{1}', {2}, {3}, {4})", dataVencimento, descricao, valor.ToString().Replace(",", "."), tipoDespesa, tipoPagamento);
            var command = new SQLiteCommand(sql, _connection);
            command.ExecuteNonQuery();
        }

        public static void DeleteDespesaMensal(string dataVencimento, string descricao, decimal valor, int tipoDespesa, int tipoPagamento)
        {
            string sql = string.Format("DELETE FROM despesaMensal WHERE dataVencimento = '{0}' AND descricao = '{1}' AND valor = {2} AND tipoDespesa = {3} AND tipoPagamento = {4}", dataVencimento, descricao, valor.ToString().Replace(",", "."), tipoDespesa, tipoPagamento);
            var command = new SQLiteCommand(sql, _connection);
            command.ExecuteNonQuery();
        }
    }
}
