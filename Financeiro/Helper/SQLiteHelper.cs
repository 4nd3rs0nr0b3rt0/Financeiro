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

                    string sql = "CREATE TABLE rendaDiaria (id INTEGER PRIMARY KEY AUTOINCREMENT, dataMovimento TEXT, valorDinheiro REAL, valorCartao REAL)";
                    SQLiteCommand command = new SQLiteCommand(sql, _connection);
                    command.ExecuteNonQuery();

                    sql = "CREATE TABLE despesaMensal (id INTEGER PRIMARY KEY AUTOINCREMENT, dataVencimento TEXT, descricao TEXT, valor REAL, tipoDespesa INTEGER, tipoPagamento INTEGER)";
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
            string sql = string.Format("SELECT id FROM rendaDiaria WHERE dataMovimento = '{0}'", dataMovimento);
            var command = new SQLiteCommand(sql, _connection);
            var rendaDiariaId = command.ExecuteScalar();

            if (rendaDiariaId == null)
            {
                sql = string.Format("INSERT INTO rendaDiaria (dataMovimento, valorDinheiro, valorCartao) VALUES ('{0}', {1}, {2})", dataMovimento, valorDinheiro.ToString().Replace(",", "."), valorCartao.ToString().Replace(",", "."));
            }
            else
            {
                sql = string.Format("UPDATE rendaDiaria SET valorDinheiro = valorDinheiro + {0}, valorCartao = valorCartao + {1} WHERE id = {2}", valorDinheiro.ToString().Replace(",", "."), valorCartao.ToString().Replace(",", "."), rendaDiariaId);
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
                    RendaDiariaId = reader.GetInt32(0),
                    DataMovimento = DateTime.ParseExact(reader.GetString(1), "yyyyMMdd", CultureInfo.InvariantCulture),
                    ValorDinheiro = reader.GetDecimal(2),
                    ValorCartao = reader.GetDecimal(3)
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
                    DespesaMensalId = reader.GetInt32(0),
                    DataVencimento = DateTime.ParseExact(reader.GetString(1), "yyyyMMdd", CultureInfo.InvariantCulture),
                    Descricao = reader.GetString(2),
                    Valor = reader.GetDecimal(3),
                    TipoDespesa = reader.GetInt32(4) == (int)TipoDespesa.FIXA ? "FIXA" : "GERAL",
                    TipoPagamento = reader.GetInt32(5) == (int)TipoPagamento.BOLETO ? "BOLETO" : reader.GetInt32(5) == (int)TipoPagamento.CHEQUE ? "CHEQUE" : "DINHEIRO"
                };
                retorno.Add(row);
            }
            return retorno;
        }

        public static DespesaMensal SelectDespesaMensalPorId(int id)
        {
            string sql = string.Format("SELECT * FROM despesaMensal WHERE id = {0}", id);
            var command = new SQLiteCommand(sql, _connection);
            var reader = command.ExecuteReader();
            var row = new DespesaMensal();
            while (reader.Read())
            {
                row.DespesaMensalId = reader.GetInt32(0);
                row.DataVencimento = DateTime.ParseExact(reader.GetString(1), "yyyyMMdd", CultureInfo.InvariantCulture);
                row.Descricao = reader.GetString(2);
                row.Valor = reader.GetDecimal(3);
                row.TipoDespesa = reader.GetInt32(4) == (int)TipoDespesa.FIXA ? "FIXA" : "GERAL";
                row.TipoPagamento = reader.GetInt32(5) == (int)TipoPagamento.BOLETO ? "BOLETO" : reader.GetInt32(5) == (int)TipoPagamento.CHEQUE ? "CHEQUE" : "DINHEIRO";
            }
            return row;
        }

        public static void InsertDespesaMensal(string dataVencimento, string descricao, decimal valor, int tipoDespesa, int tipoPagamento)
        {
            string sql = string.Format("INSERT INTO despesaMensal (dataVencimento, descricao, valor, tipoDespesa, tipoPagamento) VALUES ('{0}', '{1}', {2}, {3}, {4})", dataVencimento, descricao, valor.ToString().Replace(",", "."), tipoDespesa, tipoPagamento);
            var command = new SQLiteCommand(sql, _connection);
            command.ExecuteNonQuery();
        }

        public static void DeleteDespesaMensal(int despesaMensalId)
        {
            string sql = string.Format("DELETE FROM despesaMensal WHERE id = {0}", despesaMensalId);
            var command = new SQLiteCommand(sql, _connection);
            command.ExecuteNonQuery();
        }

        public static void UpdateDespesaMensal(string dataVencimento, string descricao, decimal valor, int tipoDespesa, int tipoPagamento, int despesaMensalId)
        {
            string sql = string.Format("UPDATE despesaMensal SET dataVencimento = '{0}', descricao = '{1}', valor = {2}, tipoDespesa = {3}, tipoPagamento = {4} WHERE id = {5}", dataVencimento, descricao, valor.ToString().Replace(",", "."), tipoDespesa, tipoPagamento, despesaMensalId);
            var command = new SQLiteCommand(sql, _connection);
            command.ExecuteNonQuery();
        }

        public static IEnumerable<RelatorioDespesaMensal> SelectRelatorioDespesaMensal(DateTime dataInicio, DateTime dataFim)
        {
            string dataI = dataInicio.ToString("yyyyMMdd");
            string dataF = dataFim.ToString("yyyyMMdd");
            string sql = string.Format("SELECT dataVencimento, SUM(valor) total FROM despesaMensal WHERE dataVencimento >= '{0}' AND dataVencimento <= '{1}' ORDER BY dataVencimento DESC", dataI, dataF);
            var command = new SQLiteCommand(sql, _connection);
            var reader = command.ExecuteReader();
            var retorno = new List<RelatorioDespesaMensal>();
            while (reader.Read())
            {
                var row = new RelatorioDespesaMensal()
                {
                    DataVencimento = DateTime.ParseExact(reader.GetString(0), "yyyyMMdd", CultureInfo.InvariantCulture),
                    DiaSemana = DiaSemana(DateTime.ParseExact(reader.GetString(0), "yyyyMMdd", CultureInfo.InvariantCulture).DayOfWeek.ToString()),
                    Valor = reader.GetDecimal(1)
                };
                retorno.Add(row);
            }
            return retorno;
        }

        private static string DiaSemana(string diaSemanaEN)
        {
            switch (diaSemanaEN)
            {
                case "Sunday":
                    return "DOMINGO";
                case "Monday":
                    return "SEGUNDA-FEIRA";
                case "Tuesday":
                    return "TERÇA-FEIRA";
                case "Wednesday":
                    return "QUARTA-FEIRA";
                case "Thursday":
                    return "QUINTA-FEIRA";
                case "Friday":
                    return "SEXTA-FEIRA";
                case "Saturday":
                    return "SÁBADO";
                default:
                    return "";
            }
        }
    }
}
