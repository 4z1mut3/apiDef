using Dapper;
using MinimalJwt.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace MinimalJwt.Repositories
{
    public class UserRepository
    {
        private static IConfiguration _configuration;
        public readonly List<User> _listaDeUsuarios;

        public UserRepository(IConfiguration configuration, List<User> listaDeUsuarios)
        {
            _configuration = configuration;
            _listaDeUsuarios = listaDeUsuarios;
        }

        public static List<User> Users = ListarUsuarios();
        
        public static List<User> ListarUsuarios()
        {
            var usuarios = new List<User>();
            
            try
            {                                            
                using (IDbConnection db = new MySqlConnection(_configuration.GetConnectionString("ConnectionStringMysql")))
                {
                    db.Open();
                    Users = db.Query<User>(@" SELECT IdUser, 
                                                    Username, 
                                                    Password, 
                                                    EmailAddress, GivenName, `Role`
                                                    FROM testedapper.`user`; ").ToList();
                    
                    return Users;
                }
                
            }
            catch (MySqlException ex)
            {
                return Users;
            }
            
            
        }
    }
}
