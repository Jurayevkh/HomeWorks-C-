using System;
using System.Collections.Generic;
using System.Linq;
using Npgsql;
using Dapper;
using Dapper.Models;
using DapperLesson;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections;


//ExecuteScalar and ExecuteScalarAsync,ExecuteScalar and ExecuteScalar<>,
//QueryFirst and QueryFirstAsync, QuerySingle vs QueryFirst vs Query, 
//Read, ReadAsync, Read<T>, ReadAsync<T>, ReadFirst, ReadFirstAsync, ReadFirst<T>,
//ReadFirstAsync<T>, ReadFirstOrDefault, ReadFirstOrDefaultAsync, ReadFirstOrDefault<T>,
//ReadFirstOrDefaultAsync<T>, ReadSingle, ReadSingleAsync, ReadSingle<T>, ReadSingleAsync<T>

//Non-Query Command

namespace Dapper
{
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private string connectionString = WebApplication.CreateBuilder().Configuration.GetConnectionString("DefaultConnection");

        //Query
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            using(var connection=new NpgsqlConnection(connectionString))
            {
                string query = "select * from \"user\"";

                IEnumerable<User> users = connection.Query<User>(query);
                return Ok(users);
            }
        }

        //QueryFirst
        [HttpGet]
        public IActionResult GetWithQueryFirst()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = "select * from \"user\"";

                var users = connection.QueryFirst<User>(query);
                return Ok(users);
            }
        }

        //QueryFirstAsync
        [HttpGet]
        public async ValueTask<IActionResult> GetAsyncQueryFirstAsync()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = $"select * from \"user\"";

                var users = await connection.QueryFirstAsync<User>(query);
                return Ok(users);
            }
        }

        //QuerySingle
        [HttpGet]
        public IActionResult GetWithQuerySingle()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = $"select * from \"user\" where id=6";

                var users = connection.QuerySingle<User>(query);
                return Ok(users);
            }
        }

        //ExecuteScalar
        [HttpGet]
        public IActionResult GetWithExecuteScalar()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = $"select COUNT(*) from \"user\"";

                var users = connection.ExecuteScalar(query);
                return Ok(users);
            }
        }

        //ExecuteScalarAsync
        [HttpGet]
        public async Task<IActionResult> GetAsyncWithExecuteScalar()
        {
            using(var connection=new NpgsqlConnection(connectionString))
            {
                string query = $"select count(*) from \"user\"";

                var users = await connection.ExecuteScalarAsync(query);
                return Ok(users);
            }
        }

        //ExecuteScalar<T>
        [HttpGet]
        public IActionResult GetWithGenericExecuteScalar()
        {
            using(var connection=new NpgsqlConnection(connectionString))
            {
                string query = $"select count(*) from \"user\"";
                var users = connection.ExecuteScalar<int>(query);
                return Ok(users);
            }
        }

        //ExecuteScalarAsync<T>
        [HttpGet]
        public async Task<IActionResult> GetWithAsyncGenericExecuteScalar()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = $"select count(*) from \"user\"";
                var users = await connection.ExecuteScalarAsync<int>(query);
                return Ok(users);
            }
        }

        //Read<T>
        [HttpGet]
        public IActionResult GetAllWithRead()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = "Select * from \"user\";Select * from InstaDB";

                var users = connection.QueryMultiple(query);

                var firstTable = users.Read<User>();
                var secondTable = users.Read<Registration>();

                return Ok(firstTable);
            }
        }

        //ReadAsync<T>

        [HttpGet]
        public async ValueTask<IActionResult> GetAllWithAsyncReadAsync()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = "Select * from \"user\";Select * from InstaDB";

                var users = await connection.QueryMultipleAsync(query);

                var firstTable = users.ReadAsync<User>().Result;
                var secondTable = users.ReadAsync<Registration>().Result;

                return Ok(secondTable);
            }
        }

        //ReadFirst
        [HttpGet]
        public IActionResult GetFirstWithReadFirst()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = "Select * from \"user\";Select * from InstaDB";

                var users = connection.QueryMultiple(query);

                var firstTable = users.ReadFirst<User>();
                var secondTable = users.ReadFirst<Registration>();
                return Ok(firstTable);
            }
        }

        //ReadFirstAsync
        [HttpGet]
        public async Task<IActionResult> GetFirstWithAsyncReadFirst()
        {
            using(var connection=new NpgsqlConnection(connectionString))
            {
                string query = "Select * from \"user\";Select * from InstaDB";

                var users = await connection.QueryMultipleAsync(query);

                var firstTable = users.ReadFirstAsync<User>().Result;
                var secondTable = users.ReadFirstAsync<Registration>().Result;

                return Ok(secondTable);
            }
        }


        //ReadFirstOrDefault
        [HttpGet]
        public IActionResult GetFirstOrDefault()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = "Select * from \"user\";Select * from InstaDB";

                var users = connection.QueryMultiple(query);

                var firstTable = users.ReadFirstOrDefault<User>();
                var secondTable = users.ReadFirstOrDefault<Registration>();

                return Ok(secondTable);
            }
        }

        //ReadFirstOrDefaultAsync
        [HttpGet]
        public async Task<IActionResult> GetAsyncFirstOrDefaultAsync()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = "Select * from \"user\";Select * from InstaDB";

                var users = await connection.QueryMultipleAsync(query);

                var firstTable = users.ReadFirstOrDefaultAsync<User>().Result;
                var secondTable = users.ReadFirstOrDefaultAsync<Registration>().Result;

                return Ok(firstTable);
            }
        }

        //ReadSingle

        [HttpGet]
        public IActionResult GetReadSingle()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = "Select * from \"user\" where id=4;Select * from InstaDB where id=1";

                var users = connection.QueryMultiple(query);

                var firstTable = users.ReadSingle<User>();
                var secondTable = users.ReadSingle<Registration>();

                return Ok(secondTable);
            }
        }

        //ReadSingleAsync
        [HttpGet]
        public async Task<IActionResult> GetAsyncReadSingleAsync()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = "Select * from \"user\" where id=4;Select * from InstaDB where id=1";

                var users = await connection.QueryMultipleAsync(query);

                var firstTable = users.ReadSingleAsync<User>().Result;
                var secondTable = users.ReadSingleAsync<Registration>().Result;

                return Ok(firstTable);
            }
        }

    }
}

