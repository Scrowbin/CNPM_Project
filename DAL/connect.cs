using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QuanLyBillards.Models
{
    public static class Connection
    {
        private static readonly string _connectionString = "Data Source=SQL_Server;Initial Catalog=Database;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public static async Task<DataTable> GetDataTableAsync(string query)
        {
            using var conn = GetConnection();
            using var cmd = new SqlCommand(query, conn);
            using var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();

            await conn.OpenAsync();
            adapter.Fill(dt);
            return dt;
        }

        public static async Task<int> ExecuteNonQueryAsync(string query, SqlParameter[]? parameters = null)
        {
            using var conn = GetConnection();
            using var cmd = new SqlCommand(query, conn);

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            await conn.OpenAsync();
            return await cmd.ExecuteNonQueryAsync();
        }

        public static async Task<object?> ExecuteScalarAsync(string query, SqlParameter[]? parameters = null)
        {
            using var conn = GetConnection();
            using var cmd = new SqlCommand(query, conn);

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            await conn.OpenAsync();
            return await cmd.ExecuteScalarAsync();
        }

        public static async Task<DataSet> GetDataSetAsync(string query, SqlParameter[]? parameters = null)
        {
            using var conn = GetConnection();
            using var cmd = new SqlCommand(query, conn);

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            using var adapter = new SqlDataAdapter(cmd);
            var ds = new DataSet();

            await conn.OpenAsync();
            adapter.Fill(ds);
            return ds;
        }
    }
}
