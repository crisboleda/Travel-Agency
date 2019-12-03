using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Travel_agency.AgencySucursal {

    class SucursalManager {

        private DataBase db = new DataBase();

        public List<Sucursal> GetSucusales(string estado) {

            List<Sucursal> sucursales = new List<Sucursal>();

            // Se instancia una conexion a la base de datos
            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT id_sucursal, address, cellphone FROM sucursales WHERE estado_sucursal = @Estado";
                    db.CreateParameter(cmd, "Estado", estado);

                    using (IDataReader cursor = cmd.ExecuteReader()) {

                        while (cursor.Read()) {

                            Sucursal new_sucursal = new Sucursal(
                                                    Convert.ToInt32(cursor["id_sucursal"]),
                                                    cursor["address"].ToString(),
                                                    cursor["cellphone"].ToString()
                                                  );

                            sucursales.Add(new_sucursal);
                        }
                    }
                }
            }
            return sucursales;
        }

        public void CreateSucursal(string address, string cellphone) {

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbTransaction trx = conn.BeginTransaction()) {

                    try {

                        using (IDbCommand cmd = conn.CreateCommand()) {

                            cmd.Transaction = trx;

                            cmd.CommandText = "INSERT INTO sucursales (address, cellphone, estado_sucursal) " +
                                "VALUES (@Address, @Cellphone, @Estado)";

                            db.CreateParameter(cmd, "Address", address);
                            db.CreateParameter(cmd, "Cellphone", cellphone);
                            db.CreateParameter(cmd, "Estado", "Activo");

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


        public void UpdateSucursal(int id_sucursal, string address, string cellphone) {

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "UPDATE sucursales SET address = @Address, cellphone = @Cellphone " +
                                      "WHERE id_sucursal = @ID";

                    db.CreateParameter(cmd, "Address", address);
                    db.CreateParameter(cmd, "Cellphone", cellphone);
                    db.CreateParameter(cmd, "ID", id_sucursal);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSucursal(int id_sucursal) {

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "UPDATE sucursales SET estado_sucursal = @Estado WHERE id_sucursal = @ID";

                    db.CreateParameter(cmd, "ID", id_sucursal);
                    db.CreateParameter(cmd, "Estado", "Inactivo");

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public Sucursal GetSurcusalReservaVuelo(int IDSucursal) {

            Sucursal foundSucursal = null;

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT id_sucursal, address, cellphone FROM sucursales WHERE id_sucursal = @ID";

                    db.CreateParameter(cmd, "ID", IDSucursal);

                    using (IDataReader cursor = cmd.ExecuteReader()) {

                        while (cursor.Read()) {

                            Sucursal sucursal = new Sucursal(
                                Convert.ToInt32(cursor["id_sucursal"].ToString()),
                                cursor["address"].ToString(),
                                cursor["cellphone"].ToString()
                            );

                            foundSucursal = sucursal;
                        }
                    }
                }
            }
            return foundSucursal;
        }
    }
}
