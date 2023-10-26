using Npgsql;

string connectionString = "Server=localhost;Port=5433;Database=something;User Id=postgres;Password=20081403;";
NpgsqlConnection connection = new NpgsqlConnection(connectionString);

//connection.ConnectionString = "Server=localhost;Database=postgres;User Id=postgres;Password=20081403;";
////Server=<server>;Port=<port>;Database=<database>;User Id=<username>;Password=<password>;
connection.Open();
string query = "select * from fruits";

NpgsqlCommand command = new NpgsqlCommand(query, connection);

NpgsqlDataReader reader = command.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine(reader[1]);
}

//using(SqlDataReader reader= command.ExecuteReader())
//{
//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]} {reader[3]}");
//    }
//}

Console.ReadLine();

