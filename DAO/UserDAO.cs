using DataClass;
using SistemasEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using BCrypt.Net;
using System.Data;

namespace ModelsData
{
    public class UserDAO : Conexion
    {
        public List<User> GetListUsers()
        {
            List<User> listUsers = new();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT u.ID, u.Firstname, u.Lastname ,o.Title AS OfficeName , r.Title AS RolName ,u.Email, u.Password,  u.Birthdate ,u.Active FROM Users AS u JOIN Oficinas AS o on u.OfficesID = o.ID JOIN Rol AS r ON r.ID = u.RoleID";
                using (SqlCommand command = new(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Nombre, Apellido, Edad, Rol, Correo electrónico, Oficina

                            User user = new User
                            {
                                UserId = Convert.ToInt32(reader["ID"]),
                                FirstName = reader["Firstname"].ToString(),
                                LastName = reader["Lastname"].ToString(),
                                OfficeName = reader["OfficeName"].ToString(),
                                RolName = reader["RolName"].ToString(),
                                Email = reader["Email"].ToString(),
                                Password = reader["Password"].ToString(),
                                BirthDay = Convert.ToDateTime(reader["Birthdate"]),
                                Active = Convert.ToBoolean(reader["Active"])
                            };
                            listUsers.Add(user);
                        }
                    }
                }
            }
            
            return listUsers;
        }
        public List<User> FiltrarUsuarios(string busqueda)
        {
            var lista = GetListUsers();
            if (busqueda != "All offices")
            {
                lista = GetListUsers().Where(u => u.OfficeName == busqueda).ToList();
                return lista;
            }
            return lista;


        }

        public bool VerificarEstado(string email)
        {
            foreach (var user in GetListUsers())
            {
                if (user.Email == email)
                {
                    bool estado = user.Active;
                    return estado;
                }
            }
            return false;
        }

        public bool ExistenciaUsuario(string email)
        {
            if (GetListUsers().Any(d => d.Email == email))
            {
                return true;
            }
            return false;
        }

        public string GetRol(string email)
        {
            return GetListUsers().FirstOrDefault(u => u.Email == email)?.RolName ?? "";
        }

        public bool ValidarContraseña(string email, string pass)
        {
            foreach (var user in GetListUsers())
            {
                if (user.Email == email)
                {
                    bool correcta = BCrypt.Net.BCrypt.Verify(pass, user.Password);
                    return correcta;
                }
            }
            return false;
        }

        public bool InsertUser(string email, string password, string firstName, string lastName,
            DateTime birthDay, int officeId, int roleId)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Users (Email, Password, Firstname, Lastname, Birthdate, OfficesID, RoleID, Active) VALUES (@Email, @Password, @Firstname, @Lastname, @Birthdate, @OfficesID, @RoleID, @Active)";
                using (SqlCommand command = new(query, connection))
                {
                    string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", passwordHash);
                    command.Parameters.AddWithValue("@Firstname", firstName);
                    command.Parameters.AddWithValue("@Lastname", lastName);
                    command.Parameters.AddWithValue("@Birthdate", birthDay);
                    command.Parameters.AddWithValue("@OfficesID", officeId);
                    command.Parameters.AddWithValue("@RoleID", roleId);
                    command.Parameters.AddWithValue("@Active", true);
                    int filasAfect = command.ExecuteNonQuery();
                    return filasAfect > 0;
                }
            }
        }

        public void ActualizarDatos(int id, string email, string firstName, string lastName, int officeID, int roleID)
        {
            using (SqlConnection connection = GetConnection())
            {

                connection.Open();
                string query = "UPDATE Users " +
                               "SET Email = @Email, " +
                               "Firstname = @Firstname, " +
                               "Lastname = @Lastname, " +
                               "OfficesID = @OfficesID, " +
                               "RoleID = @RoleID " +
                               "WHERE ID = @ID;";

                using (SqlCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Firstname", firstName);
                    command.Parameters.AddWithValue("@Lastname", lastName);
                    command.Parameters.AddWithValue("@OfficesID", officeID);
                    command.Parameters.AddWithValue("@RoleID", roleID);
                    command.Parameters.AddWithValue("@ID", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void CambiarEstado(int id, bool Active)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "UPDATE Users " +
                    "SET Active = @Active " +
                    "WHERE ID = @ID;";
                using (SqlCommand comando = new(query , connection))
                {
                    comando.Parameters.AddWithValue("@Active", Active);
                    comando.Parameters.AddWithValue("@ID", id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        // PARA ENCRIPTAR LAS CONTRASEÑAS DE LOS USUARIOS SE HACE UNA SOLA VEZ EN EL METODO CONTRUCTOR DEL LOGIN
        public void EncriptarContraseñasExistentes()
        {
            List<(int Id, string PasswordActual)> usuarios = new();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT ID, Password FROM Users";
                using (SqlCommand command = new(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuarios.Add((Convert.ToInt32(reader["ID"]), reader["Password"].ToString()));
                    }
                }
            }
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                foreach (var usuario in usuarios)
                {
                    string hash = BCrypt.Net.BCrypt.HashPassword(usuario.PasswordActual);
                    string queryUpdate = "UPDATE Users SET Password = @Hash WHERE ID = @Id";
                    using (SqlCommand command = new(queryUpdate, connection))
                    {
                        command.Parameters.AddWithValue("@Hash", hash);
                        command.Parameters.AddWithValue("@Id", usuario.Id);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
