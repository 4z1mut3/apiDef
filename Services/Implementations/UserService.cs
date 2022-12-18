using Dapper;
using MinimalJwt.Models;
using MinimalJwt.Repositories;
using MySql.Data.MySqlClient;
using System.Data;

namespace MinimalJwt.Services
{
    public class UserService : IUserService
    {
        //private readonly MySqlConnection _connection;
        private readonly IConfiguration _configuration;

        public UserService(IConfiguration configuration) 
        {
            _configuration = configuration;
        }
        public User Get(UserLogin userLogin)
        {
            User user = listarUsuarios().FirstOrDefault(o => o.Username.Equals(userLogin.Username, StringComparison.OrdinalIgnoreCase) && o.Password.Equals(userLogin.Password));
       
            return user;
        }

        public List<User> listarUsuarios() 
        {
            List<User> Users = new List<User>();
            try
            {
                using (IDbConnection db = new MySqlConnection(_configuration.GetConnectionString("conn")))
                {
                    db.Open();
                    Users = db.Query<User>(@" SELECT * FROM testedapper.`user`; ").ToList();


                }
                return Users;
            }
            catch (MySqlException ex)
            {
                return Users;
            }
        }
    }
}
