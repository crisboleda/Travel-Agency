using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Travel_agency.AgencyVuelos {

    class VueloManager {

        private DataBase db = new DataBase();

        public void CreateVuelo(string dateVuelo, string timeVuelo, string origen, string destino, int plazasTotales, int plazasClaseTurista, int cod_admin) {

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbTransaction trx = conn.BeginTransaction()) {

                    try {

                        using (IDbCommand cmd = conn.CreateCommand()) {

                            cmd.Transaction = trx;

                            cmd.CommandText = "INSERT INTO vuelos (date_vuelo, time_vuelo, origen, destino, plazas_totales, plazas_clase_turista, estado_vuelo)" +
                                "VALUES (@Date, @Time, @Origen, @Destino, @Plazas_totales, @Plazas_clase_turista, @Estado)";

                            db.CreateParameter(cmd, "Date", dateVuelo);
                            db.CreateParameter(cmd, "Time", timeVuelo);
                            db.CreateParameter(cmd, "Origen", origen);
                            db.CreateParameter(cmd, "Destino", destino);
                            db.CreateParameter(cmd, "Plazas_totales", plazasTotales);
                            db.CreateParameter(cmd, "Plazas_clase_turista", plazasClaseTurista);
                            db.CreateParameter(cmd, "Estado", "Activo");

                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "INSERT INTO logs_created (cod_usuario, action, created) VALUES (" +
                                "               @Cod_Admin, @Action, @Created)";

                            db.CreateParameter(cmd, "@Cod_Admin", cod_admin);
                            db.CreateParameter(cmd, "@Action", "Creación de un nuevo vuelo");
                            db.CreateParameter(cmd, "@Created", DateTime.Now);

                            cmd.ExecuteNonQuery();

                        }

                        trx.Commit();

                    }
                    catch {
                        trx.Rollback();
                    }
                }
            }
        }


        public List<Vuelo> GetVuelos(string estado) {

            List<Vuelo> vuelos = new List<Vuelo>();

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT id_vuelo, date_vuelo, time_vuelo, origen, destino, plazas_totales, plazas_clase_turista " +
                        "FROM vuelos WHERE estado_vuelo = @Estado";

                    db.CreateParameter(cmd, "Estado", estado);
                    
                    using (IDataReader cursor = cmd.ExecuteReader()) {

                        while (cursor.Read()) {

                            Vuelo newVuelo = new Vuelo(
                                Convert.ToInt32(cursor["id_vuelo"]),
                                cursor["date_vuelo"].ToString(),
                                cursor["time_vuelo"].ToString(),
                                cursor["origen"].ToString(),
                                cursor["destino"].ToString(),
                                Convert.ToInt32(cursor["plazas_totales"]),
                                Convert.ToInt32(cursor["plazas_clase_turista"])
                            );

                            vuelos.Add(newVuelo);
                        }
                    }
                }
            }
            return vuelos;
        }


        public void DeleteVuelo(int ID_vuelo) {

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "UPDATE vuelos SET estado_vuelo = @Estado WHERE id_vuelo = @ID";

                    db.CreateParameter(cmd, "ID", ID_vuelo);
                    db.CreateParameter(cmd, "Estado", "Inactivo");

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateVuelo(int ID_vuelo, string dateVuelo, string timeVuelo, string origen, string destino, int plazasTotales, int plazasClaseTurista) {

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "UPDATE vuelos SET date_vuelo = @Date, time_vuelo = @Time, origen = @Origen, " +
                        "destino = @Destino, plazas_totales = @PlazasTotales, plazas_clase_turista = @PlazasTurismo WHERE id_vuelo = @ID";

                    db.CreateParameter(cmd, "@Date", dateVuelo);
                    db.CreateParameter(cmd, "@Time", timeVuelo);
                    db.CreateParameter(cmd, "@Origen", origen);
                    db.CreateParameter(cmd, "@Destino", destino);
                    db.CreateParameter(cmd, "@PlazasTotales", plazasTotales);
                    db.CreateParameter(cmd, "@PlazasTurismo", plazasClaseTurista);
                    db.CreateParameter(cmd, "@ID", ID_vuelo);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void GenerateReserva(int codVuelo, int codTurista, int codSucursal, string clase) {

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "INSERT INTO reserva_vuelos (cod_vuelo, cod_turista, cod_sucursal, clase_vuelo) " +
                        "VALUES (@CodVuelo, @CodTurista, @CodSucursal, @ClaseVuelo)";

                    db.CreateParameter(cmd, "@CodVuelo", codVuelo);
                    db.CreateParameter(cmd, "@CodTurista", codTurista);
                    db.CreateParameter(cmd, "@CodSucursal", codSucursal);
                    db.CreateParameter(cmd, "@ClaseVuelo", clase);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ReservaVuelo> GetReservasVuelo() {

            List<ReservaVuelo> reservasVuelos = new List<ReservaVuelo>();

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT id_reserva_vuelo, cod_vuelo, cod_turista, cod_sucursal, clase_vuelo, asientos " +
                        "FROM reserva_vuelos";

                    using (IDataReader cursor = cmd.ExecuteReader()) {

                        while (cursor.Read()) {
                            ReservaVuelo newReserva = new ReservaVuelo(
                                Convert.ToInt32(cursor["id_reserva_vuelo"]),
                                Convert.ToInt32(cursor["cod_vuelo"]),
                                Convert.ToInt32(cursor["cod_turista"]),
                                Convert.ToInt32(cursor["cod_sucursal"]),
                                cursor["clase_vuelo"].ToString(),
                                Convert.ToInt32(cursor["asientos"])
                            );

                            reservasVuelos.Add(newReserva);
                        }
                    }
                }
            }
            return reservasVuelos;
        }


        public Vuelo GetVueloReservado(int idVuelo) {

            Vuelo vuelo = null;

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {


                    cmd.CommandText = "SELECT id_vuelo, date_vuelo, time_vuelo, origen, destino, plazas_totales, plazas_clase_turista " +
                        "FROM vuelos WHERE id_vuelo = @ID";

                    db.CreateParameter(cmd, "ID", idVuelo);

                    using (IDataReader cursor = cmd.ExecuteReader()) {

                        while (cursor.Read()) {
                            Vuelo foundVuelo = new Vuelo(
                                Convert.ToInt32(cursor["id_vuelo"]),
                                cursor["date_vuelo"].ToString(),
                                cursor["time_vuelo"].ToString(),
                                cursor["origen"].ToString(),
                                cursor["destino"].ToString(),
                                Convert.ToInt32(cursor["plazas_totales"].ToString()),
                                Convert.ToInt32(cursor["plazas_clase_turista"].ToString())
                            );

                            vuelo = foundVuelo;
                        }
                    }
                }
            }
            return vuelo;
        }


        public void UpdateAsientos(string clase, int newPlazas, Vuelo vuelo) {

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    if (clase == "Turista") {
                        cmd.CommandText = "UPDATE vuelos SET plazas_clase_turista = @Plazas WHERE id_vuelo = @ID";

                    }
                    else {
                        cmd.CommandText = "UPDATE vuelos SET plazas_totales = @Plazas WHERE id_vuelo = @ID";
                    }

                    db.CreateParameter(cmd, "Plazas", newPlazas);
                    db.CreateParameter(cmd, "ID", vuelo.GetIDVuelo());

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
