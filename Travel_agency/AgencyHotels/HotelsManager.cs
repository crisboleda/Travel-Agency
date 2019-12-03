using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Travel_agency.AgencyHotels
{
    class HotelsManager
    {
        private DataBase db = new DataBase();

        public List<Hotels> GetHotels() {

            List<Hotels> hotels = new List<Hotels>();

            // Se instancia una conexion a la base de datos
            using (NpgsqlConnection conn = db.CreateConnection()){

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT id_hotel,name, address, city, cellphone,number_plazas_disponibles FROM hotels";
                    using (IDataReader cursor = cmd.ExecuteReader()) { 
                    
                        while (cursor.Read()) {

                            Hotels new_hotels = new Hotels(

                                Convert.ToInt32(cursor["id_hotel,"]),
                                cursor["name"].ToString(),
                                cursor["address"].ToString(),
                                cursor["city"].ToString(),
                                cursor["cellphone"].ToString(),
                                Convert.ToInt32(cursor["number_plazas_disponibles"])
                                );

                            hotels.Add(new_hotels);
                        }
                    }
                }
            }

            return hotels;
        }

        public void CreateHotel(string name, string address,string city, string cellphone, int number_plazas_disponibles) { 
        
            using (NpgsqlConnection conn = db.CreateConnection()) { 
            
                using (IDbTransaction trx = conn.BeginTransaction()){

                    try {

                        using (IDbCommand cmd = conn.CreateCommand()){

                            cmd.Transaction = trx;

                            cmd.CommandText = "INSERT INTO hotels (name, address, city, cellphone, number_plazas_disponibles) VALUES (@Name, @Address, @City, @Cellphone, @number_plazas_disponibles)";

                            db.CreateParameter(cmd, "name", name);
                            db.CreateParameter(cmd, "Address", address);
                            db.CreateParameter(cmd, "city", city);
                            db.CreateParameter(cmd, "Cellphone", cellphone);
                            db.CreateParameter(cmd, "number_plazas_disponibles", number_plazas_disponibles);

                            cmd.ExecuteNonQuery();
                        }
                        trx.Commit();
                    }
                    catch{
                        trx.Rollback();
                    }
                }
            }
        }

        public void UpdateHotel(int id_hotel, string name, string address, string city, string cellphone, int number_plazas_disponibles) {

            using (NpgsqlConnection conn = db.CreateConnection()) { 
            
                using (IDbCommand cmd = conn.CreateCommand()){

                    cmd.CommandText = "UPDATE hotels SET name = @Name, address = @Address, city = @City, cellphone = @Cellphone, number_plazas_disponibles = @number_plazas_disponibles" +
                                      "WHERE id_hotel = @ID";

                    db.CreateParameter(cmd, "Name", name);
                    db.CreateParameter(cmd, "Address", address);
                    db.CreateParameter(cmd, "Cellphone", cellphone);
                    db.CreateParameter(cmd, "ID", id_hotel);
                    db.CreateParameter(cmd, "City", city);
                    db.CreateParameter(cmd, "nummber_plazas_disponibles", number_plazas_disponibles);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteHotel(int id_hotel) { 
        
            using (NpgsqlConnection conn = db.CreateConnection()){

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "DELETE FROM hotels WHERE id_hotel = @ID";

                    db.CreateParameter(cmd, "ID", id_hotel);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
