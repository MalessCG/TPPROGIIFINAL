using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Impletacion
{
    public class VehiculoDao : IVehiculoDao
    {
        public bool Actualizar(Vehiculo oVehiculo)
        {
            bool ok = true;
            SqlConnection cnn = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "SP_MODIFICAR_VEHICULO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", oVehiculo.Nombre);
                cmd.Parameters.AddWithValue("@id_tipoV", oVehiculo.TipoV.IdTipoV);
                cmd.Parameters.AddWithValue("@id_color", oVehiculo.Color.IdColor);
                cmd.Parameters.AddWithValue("@id_autoparte", oVehiculo.Id);
                cmd.Parameters.AddWithValue("@precio", oVehiculo.Precio);
                cmd.Parameters.AddWithValue("@modelo", oVehiculo.Modelo);
                cmd.ExecuteNonQuery();

                t.Commit();
            }

            catch (Exception)
            {
                if (t != null)
                {
                    t.Rollback();
                    ok = false;
                }

            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok; ; ;
        }

        public bool Borrar(int nro)
        {
            bool aux = true;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_VEHICULO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idVehiculo", nro);
            cmd.ExecuteNonQuery();
            conexion.Close();
            return aux;
        }

        public bool Crear(Vehiculo oVehiculo)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_VEHICULO";
                comando.Parameters.AddWithValue("@nombre", oVehiculo.Nombre);
                comando.Parameters.AddWithValue("@idcolor", oVehiculo.Color.IdColor);
                comando.Parameters.AddWithValue("@idtipov", oVehiculo.TipoV.IdTipoV);
                comando.Parameters.AddWithValue("@pre", oVehiculo.Precio);
                comando.Parameters.AddWithValue("@modelo", oVehiculo.Modelo);
                comando.ExecuteNonQuery();


                t.Commit();
            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();
                    resultado = false;
                }

            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resultado;
        }

        public List<Color> ObtenerColores()
        {
            List<Color> lis = new List<Color>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_colores");

            foreach (DataRow row in tabla.Rows)
            {
                Color c = new Color();
                c.IdColor = Convert.ToInt32(row["id_color"]);
                c.NombreColor = Convert.ToString(row["descripcion"]);

                lis.Add(c);
            }
            return lis;
        }

        public List<TiposVehiculos> ObtenerTiposVehiculos()
        {
            List<TiposVehiculos> lis = new List<TiposVehiculos>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_tiposV");

            foreach (DataRow row in tabla.Rows)
            {
                TiposVehiculos t = new TiposVehiculos();
                t.IdTipoV = Convert.ToInt32(row["id_tipo_vehiculo"]);
                t.NombreTipoV = Convert.ToString(row["nombre_tipo"]);

                lis.Add(t);
            }
            return lis; ;
        }

        public List<Vehiculo> ObtenerVehiculosPorFiltros(decimal desde, decimal hasta, int tipov)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            string sp = "SP_CONSULTAR_VEHICULOS";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("precio_desde", desde));
            lst.Add(new Parametro("@precio_hasta", hasta));
            lst.Add(new Parametro("@tipov", tipov));
            DataTable dt = HelperDao.ObtenerInstancia().Consultar(sp, lst);

            foreach (DataRow row in dt.Rows)
            {
                Vehiculo v = new Vehiculo();
                v.Nombre = row["nombre"].ToString();
                v.Id = int.Parse(row["id_vehiculo"].ToString());
                v.Color.IdColor = int.Parse(row["color"].ToString());
                v.TipoV.IdTipoV = int.Parse(row["id_tipo_vehiculo"].ToString());
                v.Modelo = int.Parse(row["modelo"].ToString());
                v.Precio = decimal.Parse(row["precio"].ToString());
                vehiculos.Add(v);
            }

            return vehiculos;
        }
    }
}

