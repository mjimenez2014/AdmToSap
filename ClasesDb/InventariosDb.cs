using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data.SQLite;

namespace AdmToSap
{
    class InventariosDb
    {
        String strConn = @"Data Source=C:/admtosap/DataB.sqlite;Pooling=true;FailIfMissing=false;Version=3";
        public String getBodegaSap()
        {
            String codBodegaSap = String.Empty;
            SQLiteConnection myConn = new SQLiteConnection(strConn);
            myConn.Open();
            string sql = "SELECT * FROM bodegas where cod_suc_adm = " + getbodegaLocal();
            SQLiteCommand command = new SQLiteCommand(sql, myConn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                codBodegaSap = reader.GetString(reader.GetOrdinal("codigosap"));
            }

            myConn.Close();
            
            return codBodegaSap;

        }

        public String getbodegaLocal()
        {
            String codBodegaLocal = String.Empty;
            SQLiteConnection myConn = new SQLiteConnection(strConn);
            myConn.Open();
            string sql = "SELECT * FROM empresas";
            SQLiteCommand command = new SQLiteCommand(sql, myConn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                codBodegaLocal = reader.GetInt32(reader.GetOrdinal("cod_sucursal")).ToString();
            }

            myConn.Close();

            return codBodegaLocal;

        }
    }
}
