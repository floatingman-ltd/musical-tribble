// See https://aka.ms/new-console-template for more information
using MySql.Data.MySqlClient;
using Dapper;

var builder = new MySqlConnectionStringBuilder
{
    Server = "db",
    UserID = "root",
    Password = "WOOFERS",
    Database = "sample",
};

// open a connection asynchronously
await using var connection = new MySqlConnection(builder.ConnectionString);
var insert = "insert into records (name) values (@name)";
// var name = Guid.NewGuid();//.ToString("N") ;
// var record = new { name = "Mic" };

await connection.ExecuteAsync(insert, new { name = "Pete" });

