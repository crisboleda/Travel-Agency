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

        public List<Sucursal> GetSucursales() {

            List<Sucursal> sucursales = new List<Sucursal>();

            // Se instancia una conexion a la base de datos
            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT id_sucursal, address, cellphone FROM sucursales";
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

                            cmd.CommandText = "INSERT INTO sucursales (address, cellphone) VALUES (@Address, @Cellphone)";

                            db.CreateParameter(cmd, "Address", address);
                            db.CreateParameter(cmd, "Cellphone", cellphone);

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

                    cmd.CommandText = "DELETE FROM sucursales WHERE id_sucursal = @ID";

                    db.CreateParameter(cmd, "ID", id_sucursal);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
