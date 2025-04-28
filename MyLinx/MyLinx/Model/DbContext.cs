using System;
using System.Data;
using System.Data.SqlClient;

public class DatabaseConnection : IDisposable
{
    private readonly string _connectionString = "Server=localhost port=5432 dbname=AdoLabServer user=postgres password=123 Trusted_Connection=True;";
    private SqlConnection _connection;

    public IDbConnection Connection => _connection ??= new SqlConnection(_connectionString);


    public void Open()
    {
        if (_connection == null)
            _connection = new SqlConnection(_connectionString);

        if (_connection.State != ConnectionState.Open)
            _connection.Open();
    }

    public void Close()
    {
        if (_connection != null && _connection.State != ConnectionState.Closed)
            _connection.Close();
    }

    public void Dispose()
    {
        Close();
        _connection?.Dispose();
    }
}
