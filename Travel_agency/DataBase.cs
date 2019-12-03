using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Travel_agency {

    class DataBase {

        public NpgsqlConnection CreateConnection() {
            NpgsqlConnection conn = new NpgsqlConnection {
                ConnectionString = "Username = postgres; Password = Esteban01; Host = 127.0.0.1; Port = 5432; Database = travel_agency"
            };
            conn.Open();
            return conn;
        }

        public void CreateParameter<T>(IDbCommand cmd, string name, T value) {
            IDbDataParameter prm = cmd.CreateParameter();
            prm.ParameterName = name;
            prm.Value = value;
            cmd.Parameters.Add(prm);
        }

    }
}
