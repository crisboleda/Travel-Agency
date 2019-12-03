using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Travel_agency.AgencyHotels {

    class HotelManager {

        DataBase db = new DataBase();


        public void CreateHotel(string name, string address, string city, int cellphone, int habitacionesDisponibles, int idAdmin) {


            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (NpgsqlTransaction trx = conn.BeginTransaction()) {


                    try {

                        using (IDbCommand cmd = conn.CreateCommand()) {

                            cmd.Transaction = trx;

                            cmd.CommandText = "INSERT INTO hoteles (name, address, city, cellphone, number_plazas_disponibles, estado_hotel) " +
                                " VALUES (@Name, @Address, @City, @Cellphone, @Habitaciones, @Estado)";

                            db.CreateParameter(cmd, "Name", name);
                            db.CreateParameter(cmd, "Address", address);
                            db.CreateParameter(cmd, "City", city);
                            db.CreateParameter(cmd, "Cellphone", cellphone);
                            db.CreateParameter(cmd, "Habitaciones", habitacionesDisponibles);
                            db.CreateParameter(cmd, "Estado", "Activo");

                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "INSERT INTO logs_created (cod_usuario, action, created)" +
                                "VALUES (@Cod_Admin, @Action, @Date_Created)";

                            db.CreateParameter(cmd, "Cod_Admin", idAdmin);
                            db.CreateParameter(cmd, "Action", "Creación de un hotel nuevo");
                            db.CreateParameter(cmd, "Date_Created", DateTime.Now);

                            cmd.ExecuteNonQuery();
                        }

                        trx.Commit();
                    }catch {
                        trx.Rollback();
                    }
                }
            }
        }


        public List<Hotel> GetHoteles(string estado) {

            List<Hotel> hoteles = new List<Hotel>();

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT id_hotel, name, address, city, cellphone, number_plazas_disponibles " +
                        "FROM hoteles WHERE estado_hotel = @Estado";

                    db.CreateParameter(cmd, "Estado", estado);

                    using (IDataReader cursor = cmd.ExecuteReader()) {

                        while (cursor.Read()) {

                            Hotel newHotel = new Hotel(
                                Convert.ToInt32(cursor["id_hotel"].ToString()),
                                cursor["name"].ToString(),
                                cursor["address"].ToString(),
                                cursor["city"].ToString(),
                                Convert.ToInt32(cursor["cellphone"].ToString()),
                                Convert.ToInt32(cursor["number_plazas_disponibles"].ToString())
                             );

                            hoteles.Add(newHotel);
                        }
                    }
                }
            }
            return hoteles;
        }


        public void UpdateHotel(int idHotel, string name, string address, string city, int cellphone, int habitacionesDisponibles) {

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "UPDATE hoteles SET name = @Name, address = @Address, city = @City, " +
                        "cellphone = @Cellphone, number_plazas_disponibles = @Habitaciones WHERE id_hotel = @ID";

                    db.CreateParameter(cmd, "ID", idHotel);
                    db.CreateParameter(cmd, "Name", name);
                    db.CreateParameter(cmd, "Address", address);
                    db.CreateParameter(cmd, "City", city);
                    db.CreateParameter(cmd, "Cellphone", cellphone);
                    db.CreateParameter(cmd, "Habitaciones", habitacionesDisponibles);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void DeleteHotel(int idHotel) {

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "UPDATE hoteles SET estado_hotel = @Estado WHERE id_hotel = @ID";

                    db.CreateParameter(cmd, "ID", idHotel);
                    db.CreateParameter(cmd, "Estado", "Inactivo");

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
