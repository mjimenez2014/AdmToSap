using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;

namespace AdmToSap
{
    public partial class frmProductosToExcel : Form
    {
        public frmProductosToExcel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String strConn = @"Data Source=C:/admtosap/DataB.sqlite;Pooling=true;FailIfMissing=false;Version=3";
            SQLiteConnection myConn = new SQLiteConnection(strConn);
            DateTime fechaInicio = dateTimePickerFechaInicio.Value;
            DateTime fechaFinal = dateTimePickerFechaFinal.Value;
            myConn.Open();
            string sql = "SELECT grupo,codint,codprov,codbarra,nombre,rutprov,estadoresponce,fecha_update FROM resp_productos "
                       + " WHERE fecha_update between '" + fechaInicio.ToString("yyyy-MM-dd") + " 00:00:00' and '" + fechaFinal.ToString("yyyy-MM-dd") + " 23:59:00'"
                       + " and nombre <> \"\""
                       + " order by fecha_update;";

            SQLiteCommand command = new SQLiteCommand(sql, myConn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                dataGridView1.Rows.Add(reader.GetValue(0),reader.GetValue(1),reader.GetValue(2),reader.GetValue(3),reader.GetValue(4),reader.GetValue(5),reader.GetValue(6),reader.GetValue(7));
            }
            myConn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.exportaraexcel(dataGridView1);
        }

        private void frmStockToExcel_Load(object sender, EventArgs e)
        {

        }
    }
}
