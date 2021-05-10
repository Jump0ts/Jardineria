using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jardineria
{
    class ControladorBBDD
    {
        private MySqlConnection conexion = new MySqlConnection();
        private static ControladorBBDD control = null;


        private ControladorBBDD() { }

        public static ControladorBBDD getInstance()
        {
            if (control == null) control = new ControladorBBDD();
            return control;
        }

        public Boolean conectar()
        {
            conexion.ConnectionString = "Server=localhost;Database=jardineria;Uid=root;Pwd=''";
            try
            {
                conexion.Open();
            }
            catch (MySqlException ex)
            {
                return false;
            }
            return true;
        }

        public void desconectar()
        {
            conexion.Close();
        }

        public List<String> getGama()
        {
            List<String> gamas = new List<String>();
            MySqlCommand query = new MySqlCommand("SELECT GAMA FROM GAMA_PRODUCTO",conexion);
            MySqlDataReader reader = query.ExecuteReader();

            while (reader.Read()) gamas.Add(reader.GetString(0));

            reader.Close();
            return gamas;
        }

        public int insertProd(String cod, String nombre, String gama, float dimensiones, String proveedor, String desc, float cant, float venta, float pprov)
        {
            try
            {
                MySqlCommand insert = new MySqlCommand();
                insert.Connection = conexion;
                insert.CommandText = "INSERT INTO PRODUCTO (codigo_producto, nombre, gama, dimensiones, proveedor, descripcion, cantidad_en_stock, precio_venta, precio_proveedor) " +
                    "VALUES(?cod, ?nom, ?gama, ?dim, ?prov, ?desc, ?stock, ?venta, ?pprov)";

                insert.Parameters.AddWithValue("cod", cod);
                insert.Parameters.AddWithValue("nom", nombre);
                insert.Parameters.AddWithValue("gama", gama);
                insert.Parameters.AddWithValue("dim", dimensiones);
                insert.Parameters.AddWithValue("prov", proveedor);
                insert.Parameters.AddWithValue("desc", desc);
                insert.Parameters.AddWithValue("stock", cant);
                insert.Parameters.AddWithValue("venta", venta);
                insert.Parameters.AddWithValue("pprov", pprov);

                return insert.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                //MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public void eliminaGama(String gama)
        {
            MySqlCommand delete = new MySqlCommand();

            delete.Connection = conexion;

            delete.CommandText = "ALTER TABLE producto DROP FOREIGN KEY producto_ibfk_1; ALTER TABLE producto ADD FOREIGN KEY producto_ibfk_1(gama) REFERENCES gama_producto(gama) ON DELETE CASCADE";
            delete.ExecuteNonQuery();

            delete.CommandText = "ALTER TABLE detalle_pedido DROP FOREIGN KEY detalle_pedido_ibfk_2; ALTER TABLE detalle_pedido ADD FOREIGN KEY detalle_pedido_ibfk_2(codigo_producto) REFERENCES producto(codigo_producto) ON DELETE CASCADE";
            delete.ExecuteNonQuery();

            delete.CommandText = "DELETE FROM GAMA_PRODUCTO WHERE GAMA = '" + gama + "'";
            delete.ExecuteNonQuery();
        }     

        public String getDescGama(String gama)
        {
            String desc = "";
            MySqlCommand query = new MySqlCommand("SELECT DESCRIPCION_TEXTO FROM GAMA_PRODUCTO WHERE GAMA = '"+gama+"'", conexion);
            MySqlDataReader reader = query.ExecuteReader();

            while (reader.Read()) desc = reader.GetString(0);

            reader.Close();
            return desc;
        }

        public DataTable pedidosMes(int mes)
        {
            MySqlCommand query = new MySqlCommand("SELECT * FROM pedido WHERE MONTH(fecha_entrega)=" + mes + " AND estado='Entregado'", conexion);
            DataTable table = new DataTable();
            MySqlDataReader reader = query.ExecuteReader();

            if (reader.HasRows) table.Load(reader);

            reader.Close();

            return table;
        }

        public List<Empleado> empleadosJefe(String idJefe)
        {
            List<Empleado> empleados = new List<Empleado>();
            MySqlCommand query = new MySqlCommand("SELECT nombre, apellido1, apellido2, email FROM empleado WHERE codigo_jefe = '"+idJefe+"'", conexion);
            MySqlDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                empleados.Add(new Empleado(reader.GetString(0), reader.GetString(1)+" "+reader.GetString(2), reader.GetString(3)));
            }
            reader.Close();
            if (empleados.Count > 0) return empleados;
            else return null;
        }

        public DataTable clientesNoPaga()
        {
            DataTable tabla = new DataTable();
            MySqlCommand query = new MySqlCommand("SELECT * FROM cliente WHERE codigo_cliente " +
                "IN (SELECT codigo_cliente FROM PEDIDO) AND codigo_cliente " +
                "NOT IN (SELECT codigo_cliente FROM pago)", conexion);
            MySqlDataReader reader = query.ExecuteReader();

            tabla.Columns.Add("Código cliente", typeof(String));
            tabla.Columns.Add("Nombre cliente", typeof(String));
            tabla.Columns.Add("Nombre contacto", typeof(String));
            tabla.Columns.Add("Apellido contacto", typeof(String));
            tabla.Columns.Add("Teléfono", typeof(String));
            tabla.Columns.Add("Fax", typeof(String));
            tabla.Columns.Add("Línea dirección 1", typeof(String));
            tabla.Columns.Add("Línea dirección 2", typeof(String));
            tabla.Columns.Add("Ciudad", typeof(String));
            tabla.Columns.Add("Región", typeof(String));
            tabla.Columns.Add("País", typeof(String));
            tabla.Columns.Add("Código postal", typeof(String));
            tabla.Columns.Add("Cod empleado rep ventas", typeof(int));
            tabla.Columns.Add("Límite crédito", typeof(long));

            DataRow fila;

            while (reader.Read())
            {
                fila = tabla.NewRow();

                fila["Código cliente"] = reader.GetString(0);
                fila["Nombre cliente"] = reader.GetString(1);
                fila["Nombre contacto"] = reader.GetString(2);
                fila["Apellido contacto"] = reader.GetString(3);
                fila["Teléfono"] = reader.GetString(4);
                fila["Fax"] = reader.GetString(5);
                fila["Línea dirección 1"] = reader.GetString(6);

                try
                {
                    fila["Línea dirección 2"] = reader.GetString(7);
                }
                catch (Exception) { fila["Línea dirección 2"] = "Null"; }

                fila["Ciudad"] = reader.GetString(8);
                fila["Región"] = reader.GetString(9);
                fila["País"] = reader.GetString(10);
                fila["Código postal"] = reader.GetString(11);
                fila["Cod empleado rep ventas"] = reader.GetInt32(0);
                fila["Límite crédito"] = reader.GetInt64(0);

                tabla.Rows.Add(fila);
            }

            reader.Close();
            return tabla;
        }

        public List<long> maxMin()
        {
            List<long> precios = new List<long>();
            MySqlCommand query = new MySqlCommand("SELECT MAX(precio_venta), MIN(precio_venta) FROM producto", conexion);
            MySqlDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                precios.Add(reader.GetInt64(0));
                precios.Add(reader.GetInt64(1));
            }

            reader.Close();
            return precios;
        }
    }
}
