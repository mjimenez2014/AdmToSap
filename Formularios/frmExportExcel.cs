using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AdmToSap
{
    public partial class frmExportExcel : Form
    {
        public frmExportExcel()
        {
            InitializeComponent();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.exportaraexcel(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String strConn = @"Data Source=C:/admtosap/DataB.sqlite;Pooling=true;FailIfMissing=false;Version=3";
            SQLiteConnection myConn = new SQLiteConnection(strConn);
            DateTime fechaInicio = dateTimePicker1.Value;
            DateTime fechaFinal = dateTimePicker2.Value;
            myConn.Open();
            string sql = "SELECT * FROM respuestas "
                       + " WHERE fecha between '" + fechaInicio.ToString("yyyy-MM-dd") + " 00:00:00' and '" + fechaFinal.ToString("yyyy-MM-dd") + " 23:59:00' "
                       + " order by fecha;";
            SQLiteCommand command = new SQLiteCommand(sql, myConn);
            SQLiteDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {

                dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(8), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(7), reader.GetValue(6));
            }
            myConn.Close();

        }

        private void frmExportExcel_Load(object sender, EventArgs e)
        {

        }



    }
}
