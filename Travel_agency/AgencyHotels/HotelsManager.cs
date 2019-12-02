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

                    cmd.CommandText = "SELECT id_hotel, address, cellphone FROM hotels";
                    using (IDataReader cursor = cmd.ExecuteReader()) { 
                    
                        while (cursor.Read()) {

                            Hotels new_hotels = new Hotels(

                                Convert.ToInt32(cursor["id_hotel,"]),
                                cursor["address"].ToString(),
                                cursor["cellphone"].ToString()
                                );

                            hotels.Add(new_hotels);
                        }
                    }
                }
            }

            return hotels;
        }

        public void CreateHotel(string address, string cellphone) { 
        
            using (NpgsqlConnection conn = db.CreateConnection()) { 
            
                using (IDbTransaction trx = conn.BeginTransaction()){

                    try {

                        using (IDbCommand cmd = conn.CreateCommand()){

                            cmd.Transaction = trx;

                            cmd.CommandText = "INSERT INTO hotels (address, cellphone) VALUES (@Address, @Cellphone)";

                            db.CreateParameter(cmd, "Address", address);
                            db.CreateParameter(cmd, "Cellphone", cellphone);

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

        public void UpdateHotel(int id_hotel, string address, string cellphone, string price){

            using (NpgsqlConnection conn = db.CreateConnection()) { 
            
                using (IDbCommand cmd = conn.CreateCommand()){

                    cmd.CommandText = "UPDATE hotels SET address = @Address, cellphone = @Cellphone" +
                                      "WHERE id_hotel = @ID";

                    db.CreateParameter(cmd, "Address", address);
                    db.CreateParameter(cmd, "Cellphone", cellphone);
                    db.CreateParameter(cmd, "ID", id_hotel);

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
