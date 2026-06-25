using DataClass;
using SistemasEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ModelsData
{
    public class OfficesDAO : Conexion
    {
        public List<Office> GetListOffices()
        {
            List<Office> listOffices = new();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT o.ID, c.Name AS countryName, o.Title, o.Phone, o.Contact\r\nFROM Oficinas o\r\nJOIN Paises c \r\nON o.CountryID = c.ID;";
                using (SqlCommand command = new(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Office office = new Office
                            {
                                OfficeId = Convert.ToInt32(reader["ID"]),
                                CountryName = reader["countryName"].ToString(),
                                OfficeName = reader["Title"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Contact = reader["Contact"].ToString()
                            };
                            listOffices.Add(office);
                        }
                    }
                }
            }
            return listOffices;
        }
    }
}
