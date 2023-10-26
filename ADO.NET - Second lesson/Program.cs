using Npgsql;

Database.GetAll("fruits","something","id>8");
Database.DeleteData("fruits", "id>=7","something");
Console.ReadLine();

public class Database
{

    public static void GetAll(string TableName, string Database, string Condition)

    {
        using (NpgsqlConnection connection = new NpgsqlConnection($"Server=localhost;Port=5433;Database={Database};User Id=postgres;Password=20081403;"))
        {
            connection.Open();
            string query = $"select * from {TableName} where {Condition}";

            NpgsqlCommand command = new NpgsqlCommand(query, connection);

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]} {reader[3]}");
            }

            reader.Close();
        }

    }

    public static void DeleteData(string TableName,string Condition, string Database)
    {
        using(NpgsqlConnection connection =new NpgsqlConnection($"Server=localhost;Port=5433;Database={Database};User Id=postgres;Password=20081403;"))
        {
            connection.Open();
            string query = $"Delete from {TableName} where {Condition}";

            NpgsqlCommand command = new NpgsqlCommand(query, connection);

            Console.WriteLine("Malumot o'chirildi :)");
            reader.Close();
        }
    }

    //public static void InsertData(string TableName,Fruit fruit)
    //{
    //    using (NpgsqlConnection connection = new NpgsqlConnection($"Server=localhost;Port=5433;Database=something;User Id=postgres;Password=20081403;"))
    //    {
    //        connection.Open();
    //        string query = $"";
    //    }


    //}

}


public class Fruit
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float price { get; set; }
    public int count { get; set; }
}
