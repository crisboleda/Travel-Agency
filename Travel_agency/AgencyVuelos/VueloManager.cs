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

                            cmd.CommandText = "INSERT INTO vuelos (date_vuelo, time_vuelo, origen, destino, plazas_totales, plazas_clase_turista)" +
                                "VALUES (@Date, @Time, @Origen, @Destino, @Plazas_totales, @Plazas_clase_turista)";

                            db.CreateParameter(cmd, "Date", dateVuelo);
                            db.CreateParameter(cmd, "Time", timeVuelo);
                            db.CreateParameter(cmd, "Origen", origen);
                            db.CreateParameter(cmd, "Destino", destino);
                            db.CreateParameter(cmd, "Plazas_totales", plazasTotales);
                            db.CreateParameter(cmd, "Plazas_clase_turista", plazasClaseTurista);

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


        public List<Vuelo> GetVuelos() {

            List<Vuelo> vuelos = new List<Vuelo>();

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT id_vuelo, date_vuelo, time_vuelo, origen, destino, plazas_totales, plazas_clase_turista " +
                        "FROM vuelos";
                    
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

                    cmd.CommandText = "DELETE FROM vuelos WHERE id_vuelo = @ID";

                    db.CreateParameter(cmd, "@ID", ID_vuelo);

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
    }
}
