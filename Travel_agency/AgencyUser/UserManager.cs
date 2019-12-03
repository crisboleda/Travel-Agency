using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Travel_agency.AgencyUser {

    class UserManager {

        // Instancia de la DataBase donde están los métodos de conexión y Creación de Parametros
        private DataBase db = new DataBase();

        // Metodo para crear un usuario en la base de datos
        public void CreateUser(User new_user) {
           
            // Creo una conexion a la base de datos
            using (NpgsqlConnection conn = db.CreateConnection()) {

                using(IDbTransaction trx = conn.BeginTransaction()) {

                    try {

                        using (IDbCommand cmd = conn.CreateCommand()) {
                            cmd.Transaction = trx;

                            cmd.CommandText = "INSERT INTO users VALUES " +
                                "(@Cedula, @Rol, @Name, @LastName, @Address, @Cellphone, @Email, @Password)";

                            db.CreateParameter(cmd, "Cedula", new_user.GetCedula());
                            db.CreateParameter(cmd, "Rol", new_user.GetRol());
                            db.CreateParameter(cmd, "Name", new_user.GetName());
                            db.CreateParameter(cmd, "LastName", new_user.GetLastName());
                            db.CreateParameter(cmd, "Address", new_user.GetAddress());
                            db.CreateParameter(cmd, "Cellphone", new_user.GetCellphone());
                            db.CreateParameter(cmd, "Email", new_user.GetEmail());
                            db.CreateParameter(cmd, "Password", new_user.GetPassword());

                            cmd.ExecuteNonQuery();
                        }

                        trx.Commit();
                    }catch {
                        trx.Rollback();
                    }
                }
            }
        }

        // Con esta sesion logramos que un usuario se pueda loguear
        public User SignIn(string email, string password) {

            User user_found = null;

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT * FROM users WHERE email = @Email AND password = @Password";

                    db.CreateParameter(cmd, "Email", email);
                    db.CreateParameter(cmd, "Password", password);

                    using (IDataReader cursor = cmd.ExecuteReader()) {

                        try {

                            while (cursor.Read()) {
                                user_found = new User(
                                    Convert.ToInt32(cursor["id_user"]),
                                    cursor["rol"].ToString(),
                                    cursor["name"].ToString(),
                                    cursor["lastname"].ToString(),
                                    cursor["address"].ToString(),
                                    cursor["telefono"].ToString(),
                                    cursor["email"].ToString(),
                                    ""
                                );
                            }
                        }
                        catch {
                            cursor.Close();
                        }
                    }
                }
            }
            return user_found;
        }


        public void UpdateUser(User user_update) {

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "UPDATE users SET name = @Name, lastname = @LastName, address = @Address," +
                        "telefono = @Telefono, email = @Email, password = @Password WHERE id_user = @ID";

                    db.CreateParameter(cmd, "Name", user_update.GetName());
                    db.CreateParameter(cmd, "LastName", user_update.GetLastName());
                    db.CreateParameter(cmd, "Address", user_update.GetAddress());
                    db.CreateParameter(cmd, "Telefono", user_update.GetCellphone());
                    db.CreateParameter(cmd, "Email", user_update.GetEmail());
                    db.CreateParameter(cmd, "Password", user_update.GetPassword());
                    db.CreateParameter(cmd, "ID", user_update.GetCedula().ToString());

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public User GetUserReservaVuelo(int IDTurista) {

            User user_found = null;

            using (NpgsqlConnection conn = db.CreateConnection()) {

                using (IDbCommand cmd = conn.CreateCommand()) {

                    cmd.CommandText = "SELECT * FROM users WHERE id_user = @ID";

                    db.CreateParameter(cmd, "ID", (IDTurista).ToString());

                    using (IDataReader cursor = cmd.ExecuteReader()) {

                        try {

                            while (cursor.Read()) {
                                user_found = new User(
                                    Convert.ToInt32(cursor["id_user"]),
                                    cursor["rol"].ToString(),
                                    cursor["name"].ToString(),
                                    cursor["lastname"].ToString(),
                                    cursor["address"].ToString(),
                                    cursor["telefono"].ToString(),
                                    cursor["email"].ToString(),
                                    ""
                                );
                            }
                        }
                        catch {
                            cursor.Close();
                        }
                    }
                }
            }
            return user_found;
        }
    }
}
