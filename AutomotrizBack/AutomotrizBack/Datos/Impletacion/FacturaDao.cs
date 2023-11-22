using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Entidades;

using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;

namespace AutomotrizBack.Datos.Implementacion
{
    public class FacturaDao : IFacturaDao
    {
        public bool Actualizar(Factura oFactura)
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
                cmd.CommandText = "SP_MODIFICAR_MAESTRO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cliente", oFactura.Cliente);
                cmd.Parameters.AddWithValue("@fecha", oFactura.Fecha);
                cmd.Parameters.AddWithValue("@fac_nro", oFactura.Nro);
                cmd.ExecuteNonQuery();

                SqlCommand cmdDetalle;
                
                foreach (DetalleFactura df in oFactura.ListaDetalles)
                {
                    cmdDetalle = new SqlCommand("SP_MODIFICAR_DETALLE", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@fac", oFactura.Nro);
                    cmdDetalle.Parameters.AddWithValue("@id_autoparte", df.Autoparte.IdAutoparte);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", df.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@precio", df.Autoparte.PrecioA);
                    cmdDetalle.ExecuteNonQuery();
                }
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

            return ok;
        }

        public bool Borrar(int nro)
        {
            SqlConnection con = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            bool aux = true;
            try
            {
                con.Open();
                t = con.BeginTransaction();

                SqlCommand cmd = new SqlCommand("sp_baja_factura", con, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nro", nro);
                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();
                    aux = false;
                }
            }
            finally
            {
                if (con != null || con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return aux;

        }

        public bool Crear(Factura oFactura)
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
                comando.CommandText = "SP_INSERTAR_MAESTRO";
                comando.Parameters.AddWithValue("@cliente", oFactura.Cliente);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@nroFac";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int facturaNro = (int)parametro.Value;
                SqlCommand cmdDetalle;


                foreach (DetalleFactura df in oFactura.ListaDetalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@fac", facturaNro);
                    cmdDetalle.Parameters.AddWithValue("@id_autoparte", df.Autoparte.IdAutoparte);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", df.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@precio", df.Autoparte.PrecioA);
                    cmdDetalle.ExecuteNonQuery();

                }
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

        public List<Autoparte> ObtenerAutopartes()
        {
            List<Autoparte> lAutopartes = new List<Autoparte>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_AUTOPARTES");
            foreach (DataRow fila in tabla.Rows)
            {
                Autoparte autoparte = new Autoparte();
                autoparte.IdAutoparte = int.Parse(fila["id_Autoparte"].ToString());
                autoparte.NombreA = fila["nombre"].ToString();
                autoparte.PrecioA = decimal.Parse(fila["precio"].ToString());
                autoparte.TipoA.IdTipoA = int.Parse(fila["id_tipo_autoparte"].ToString());
                autoparte.StockAct = int.Parse(fila["stock_actual"].ToString());
                autoparte.StockMin = int.Parse(fila["stock_minimo"].ToString());
                
                lAutopartes.Add(autoparte);
            }
            return lAutopartes;
        }

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> lClientes = new List<Cliente>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_CLIENTES");
            foreach (DataRow fila in tabla.Rows)
            {
                int numero = int.Parse(fila["Id_cliente"].ToString());
                string nombre = fila["nom_cliente"].ToString();
                string apellido = fila["ape_cliente"].ToString();
                int tipoA = int.Parse(fila["id_tipo_cliente"].ToString());
                Cliente c = new Cliente(numero, nombre, apellido, tipoA);
                lClientes.Add(c);
            }
            return lClientes;
        }

        public Factura ObtenerFacturaPorNro(int nro)
        {

            List<Parametro> param = new List<Parametro>();
            param.Add(new Parametro("@nro", nro));
            DataTable t = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_FACTURAS_BY_ID", param);

            Factura factura = null;
            foreach (DataRow row in t.Rows)
            {
                factura = new Factura();
                factura.Cliente = int.Parse(row["id_cliente"].ToString());
                factura.Nro = int.Parse(row["nroFac"].ToString());
                factura.Fecha = DateTime.Parse(row["fecha"].ToString());
                
            }
            return factura;

        }

        public List<Factura> ObtenerFacturasPorFiltros(DateTime desde, DateTime hasta, int cliente)
        {
            List<Factura> facturas = new List<Factura>();
            string sp = "SP_CONSULTAR_FACTURAS";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@fecha_desde", desde));
            lst.Add(new Parametro("@fecha_hasta", hasta));
            lst.Add(new Parametro("@cliente_id", cliente));
            DataTable dt = HelperDao.ObtenerInstancia().Consultar(sp, lst);

            foreach (DataRow row in dt.Rows)
            {
                Factura factura = new Factura();
                factura.Cliente = int.Parse(row["id_cliente"].ToString());
                factura.Nro = int.Parse(row["nroFac"].ToString());
                factura.Fecha = DateTime.Parse(row["fecha"].ToString());
                facturas.Add(factura);
            }

            return facturas;
        }

        public int ObtenerProximaFactura()
        {
            return HelperDao.ObtenerInstancia().ConsultarEscalar("SP_PROXIMO_ID", "@next");
        }
    }
}

