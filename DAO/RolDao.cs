using DataClass;
using SistemasEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Text;

namespace ModelsData
{
    public class RolDao : Conexion
    {
        public List<Rol> GetListRoles()
        {
            List<Rol> listRoles = new();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Rol;";
                using (SqlCommand command = new(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rol rol = new Rol
                            {
                                RolId = Convert.ToInt32(reader["ID"]),
                                title = reader["Title"].ToString()
                            };
                            listRoles.Add(rol);
                        }
                    }
                }
            }
            return listRoles;
        }
    }
}
