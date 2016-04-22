using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Globalization;

namespace AdmToSap
{
    class PreciosDb
    {
        public ListaPrecio upPrecAdm(String json)
        {
                // TODO verificar JSON vacio
                ListaPrecio listprecio = new ListaPrecio();
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(ListaPrecio));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
                frmProductosDgw frmdgv = new frmProductosDgw();
                try
                {
                    listprecio = (ListaPrecio)js.ReadObject(ms);
                    foreach (var pro in listprecio.Items)
                    { 
                      //  frmdgv.dataGridView1.Rows.Add(listprecio.ListName, listprecio.PriceList, pro.CodInt, pro.Price);
                        updateAdm(pro.CodInt, pro.Price);
                        Producto producto = new Producto();
                        Items item = new Items();
                        item.CodInt = pro.CodInt;
                        item.Precio1 = pro.Price;
                        producto.Items.Add(item);
                        new ProductosDb().insertSqlite(producto);
                    }
                  //  frmdgv.Show();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                  //  MessageBox.Show("Error de lectura JSON\\" + e.Message);
                }

                return listprecio;
          
        }

        public void updateAdm(string codArt, String precio)
        {
            Double precioVenta = Convert.ToDouble(precio)*1.19;
            string precioVentaSinDecimales = precioVenta.ToString("N0", CultureInfo.CreateSpecificCulture("es-ES")).Replace(".","");
            ConnectDb con = new ConnectDb();
            DateTime thisDay = DateTime.Now;
            String fecha = String.Format("{0:yyyyMMddTHHmmss}", thisDay);
            String precioNeto = precio.ToString();
            OdbcConnection conexion = con.getConnect();
            OdbcCommand insert = new OdbcCommand();
            insert.Connection = conexion;
            insert.CommandText = "replace into precios ("
                + "cod_empresa,cod_lista,cod_art,margen_ant1,margen1,precio_ant1,precio1,impprecio_ant1,impprecio1,"
                + "unidad1,margen_ant2,margen2,precio_ant2,precio2,impprecio_ant2,impprecio2,unidad2,margen_ant3,margen3,precio_ant3,"
                + "precio3,impprecio_ant3,impprecio3,fecha_act_ant,fecha_act,flagprecio,cod_mon,com_porc1,com_dinero1,com_porc2,com_dinero2,"
                + "com_porc3,com_dinero3,com_activa "
                + ") values("
                + "1,"                       // cod_empresa
                + "1,"                       // cod_lista - Código de la lista de precios (1 = “BASICA”) de ADM TODO
                + codArt + ","               // cod_art Código del nuevo producto enviado por SAP
                + "0,"                       //   
                + "0,"                       // 
                + "0,"                       // 
                + precioNeto +","                       // Valor Neto del precio de venta
                + "0,"                       // Valor del precio de venta del producto (con IVA)
                + precioVentaSinDecimales + ","                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "'2015-07-07 14:56:29',"   // = null
                + "'" + fecha + "',"         // Fecha del día en el formato ‘2015-07-07 00:00:00’
                + "'N',"                     //
                + "1,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "0,"                       //
                + "'N')";                    //

            OdbcDataReader inserts = insert.ExecuteReader();
            // conexion.Close();

  
        }
    }

}
