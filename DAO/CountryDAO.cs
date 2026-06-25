using DataClass;
using SistemasEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ModelsData
{
    public class CountryDAO : Conexion
    {
        public List<Country> GetListCountries()
        {
            List<Country> listCountries =  new List<Country>();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Countries;";
                using (SqlCommand command = new(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Country country = new Country
                            {
                                CountryId = Convert.ToInt32(reader["ID"]),
                                CountryName = reader["Name"].ToString()
                            };
                            listCountries.Add(country);
                        }
                    }
                }
            }
            return listCountries;
        }
    }
}
