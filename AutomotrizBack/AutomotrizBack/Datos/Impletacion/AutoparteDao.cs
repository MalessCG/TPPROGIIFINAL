using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Impletacion
{
    public class AutoparteDao : IAutoparteDao
    {
        public bool Borrar(int nro)
        {
            bool aux = true;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_AUTOPARTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idAutoparte", nro);
            cmd.ExecuteNonQuery();
            conexion.Close();
            return aux;
        }

        public bool Crear(Autoparte oAutoparte)
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
                comando.CommandText = "SP_INSERTAR_AUTOPARTE";
                comando.Parameters.AddWithValue("@nombre", oAutoparte.NombreA);
                comando.Parameters.AddWithValue("@idtipoa", oAutoparte.TipoA.IdTipoA);
                comando.Parameters.AddWithValue("@pre", oAutoparte.PrecioA);
                comando.Parameters.AddWithValue("@stock_min", oAutoparte.StockMin);
                comando.Parameters.AddWithValue("@stock_act", oAutoparte.StockAct);
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

            return resultado; ;
        }

        public List<TipoAutoparte> ObtenerTiposA()
        {
            List<TipoAutoparte> lis = new List<TipoAutoparte>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("sp_consultar_tiposA");

            foreach (DataRow row in tabla.Rows)
            {
                TipoAutoparte t = new TipoAutoparte();
                t.IdTipoA = Convert.ToInt32(row["id_tipo_autoparte"]);
                t.NombreAutoparte = Convert.ToString(row["descripcion"]);

                lis.Add(t);
            }
            return lis;
        }

        public List<Autoparte> ObtenerAutopartesPorFiltros(int stock, int tipoa)
        {
            List<Autoparte> autopartes = new List<Autoparte>();
            string sp = "SP_CONSULTAR_AUTOPARTES_FILTROS";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("stock", stock));
            lst.Add(new Parametro("@tipoa", tipoa));
            DataTable dt = HelperDao.ObtenerInstancia().Consultar(sp, lst);

            foreach (DataRow row in dt.Rows)
            {
                Autoparte a = new Autoparte();
                a.NombreA = row["nombre"].ToString();
                a.IdAutoparte = int.Parse(row["id_Autoparte"].ToString());
                a.TipoA.IdTipoA = int.Parse(row["id_tipo_autoparte"].ToString());
                a.StockMin = int.Parse(row["stock_minimo"].ToString());
                a.StockAct = int.Parse(row["stock_actual"].ToString());
                a.PrecioA = decimal.Parse(row["precio"].ToString());
                autopartes.Add(a);
            }

            return autopartes; ;
        }

        public bool Actualizar(Autoparte oAutoparte)
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
                cmd.CommandText = "SP_MODIFICAR_AUTOPARTE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", oAutoparte.NombreA);
                cmd.Parameters.AddWithValue("@id_tipoA", oAutoparte.TipoA.IdTipoA);
                cmd.Parameters.AddWithValue("@id_autoparte", oAutoparte.IdAutoparte);
                cmd.Parameters.AddWithValue("@precio", oAutoparte.PrecioA);
                cmd.Parameters.AddWithValue("@stockAct", oAutoparte.StockAct);
                cmd.Parameters.AddWithValue("@stockMin", oAutoparte.StockMin);
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

            return ok; ;
        }
    }
}
