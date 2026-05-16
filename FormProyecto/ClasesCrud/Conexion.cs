using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProyecto.ClasesCrud
{
    public class Conexion
    {
        public SqlConnection Connect = new SqlConnection();


        public Conexion(String user, String pass)
        {
            try
            {

                Connect = new SqlConnection("Server=192.168.43.168;Database=ProyectoBD;UID=" + user + ";PWD=" + pass);
                Connect.Open();
                //"Server=LAPTOP-GJAFQBRR\\SQLEXPRESS;Database=ProyectoBD;UID=" + user + ";PWD=" + pass
                //MessageBox.Show((ConnectionState.Open).ToString());
            }
            catch (Exception es)
            {
                //MessageBox.Show(es.Message);

            }
        }
        public async Task<DataTable> MostrarDetVenta()
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarDetalleV";
            cmd.Connection = Connect;

            SqlDataAdapter ds = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            await Task.Run(() =>
            {
                ds.Fill(dt);

            });
            return dt;

        }

        public async Task InsertarVentaDetVenta(int idp, int Idc, int cantP)
        {

            SqlParameter[] param = new SqlParameter[3];


            SqlCommand cmd = new SqlCommand();
            param[0] = new SqlParameter("@IDP", SqlDbType.Int);
            param[0].Value = idp;
            param[1] = new SqlParameter("@IdCli", SqlDbType.Int);
            param[1].Value = Idc;
            param[2] = new SqlParameter("@CP", SqlDbType.Int);
            param[2].Value = cantP;


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Nventa";
            cmd.Connection = Connect;

            cmd.Parameters.AddRange(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            await Task.Run(() => {

                da.Fill(ds);

            });

        }
        public async Task<DataTable> MostrarVenta()
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarVentas";
            cmd.Connection = Connect;

            SqlDataAdapter ds = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            await Task.Run(() =>
            {
                ds.Fill(dt);

            });
            return dt;

        }
        public async Task InsertarMateria(string nombre, string descrip,int cantidas, int id)
        {

            SqlParameter[] param = new SqlParameter[4];


            SqlCommand cmd = new SqlCommand();
            param[0] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
            param[0].Value = nombre;
            param[1] = new SqlParameter("@Descripcion", SqlDbType.NVarChar);
            param[1].Value = descrip;
            param[2] = new SqlParameter("@Cantidad", SqlDbType.Int);
            param[2].Value = cantidas;
            param[3] = new SqlParameter("@IdProv", SqlDbType.Int);
            param[3].Value = id;
           


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertarMateriaPrima";
            cmd.Connection = Connect;

            cmd.Parameters.AddRange(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            await Task.Run(() => {

                da.Fill(ds);

            });

        }
        public async Task ModificarMateria(int id,string nombre, string descrip, int cantidas, int idp)
        {

            SqlParameter[] param = new SqlParameter[5];


            SqlCommand cmd = new SqlCommand();
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
            param[1].Value = nombre;
            param[2] = new SqlParameter("@Descripcion", SqlDbType.NVarChar);
            param[2].Value = descrip;
            param[3] = new SqlParameter("@Cantidad", SqlDbType.Int);
            param[3].Value = cantidas;
            param[4] = new SqlParameter("@IdProv", SqlDbType.Int);
            param[4].Value = idp;



            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ModificarMateriaPrima";
            cmd.Connection = Connect;

            cmd.Parameters.AddRange(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            await Task.Run(() => {

                da.Fill(ds);

            });

        }
        public async Task<DataTable> MostrarMateria()
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarMateriaPrima";
            cmd.Connection = Connect;

            SqlDataAdapter ds = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            await Task.Run(() =>
            {
                ds.Fill(dt);

            });
            return dt;

        }
        public async Task InsertarCliente(string nombre, string Snombre, string Apellido, string Sapellido, string direccion, int idm)
        {

            SqlParameter[] param = new SqlParameter[6];


            SqlCommand cmd = new SqlCommand();
            param[0] = new SqlParameter("@PNomC", SqlDbType.NVarChar);
            param[0].Value = nombre;
            param[1] = new SqlParameter("@SNomC", SqlDbType.NVarChar);
            param[1].Value = Snombre;
            param[2] = new SqlParameter("@PApeC", SqlDbType.NVarChar);
            param[2].Value = Apellido;
            param[3] = new SqlParameter("@SApeC", SqlDbType.NVarChar);
            param[3].Value = Sapellido;
            param[4] = new SqlParameter("@DirC", SqlDbType.NVarChar);
            param[4].Value = direccion;
            param[5] = new SqlParameter("@IdMunC", SqlDbType.Int);
            param[5].Value = idm;


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "NuevoCliente";
            cmd.Connection = Connect;

            cmd.Parameters.AddRange(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            await Task.Run(() => {

                da.Fill(ds);

            });

        }

        public async Task ModidficarCliente(int id, string nombre, string Snombre, string Apellido, string Sapellido, string direccion, int idm)
        {



            SqlParameter[] param = new SqlParameter[7];

            SqlCommand cmd = new SqlCommand();
            param[0] = new SqlParameter("@IdC", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@PNomC", SqlDbType.NVarChar);
            param[1].Value = nombre;
            param[2] = new SqlParameter("@SNomC", SqlDbType.NVarChar);
            param[2].Value = Snombre;
            param[3] = new SqlParameter("@PApeC", SqlDbType.NVarChar);
            param[3].Value = Apellido;
            param[4] = new SqlParameter("@SApeC", SqlDbType.NVarChar);
            param[4].Value = Sapellido;
            param[5] = new SqlParameter("@DirC", SqlDbType.NVarChar);
            param[5].Value = direccion;
            param[6] = new SqlParameter("@IdMunC", SqlDbType.Int);
            param[6].Value = idm;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ModificarCliente";
            cmd.Connection = Connect;

            cmd.Parameters.AddRange(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            await Task.Run(() => {

                da.Fill(ds);

            });

        }
        public async Task<DataTable> MostrarCliente()
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarClientes";
            cmd.Connection = Connect;

            SqlDataAdapter ds = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            await Task.Run(() =>
            {
                ds.Fill(dt);

            });
            return dt;

        }
        public async Task BajaCliente(int id)
        {

            SqlParameter param = new SqlParameter("@IdC", SqlDbType.Int);
            param.Value = id;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DarBajaCliente";
            cmd.Connection = Connect;

            cmd.Parameters.Add(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            await Task.Run(() => {

                da.Fill(ds);

            });
        }
        public async Task BajaSucursal(int id)
        {

            SqlParameter param = new SqlParameter("@Id", SqlDbType.Int);
            param.Value = id;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BajaSucursal";
            cmd.Connection = Connect;

            cmd.Parameters.Add(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            await Task.Run(() =>
            {

                da.Fill(ds);

            });
        }
        public async Task InsertarSucursal(string nombre, string telefono, string Direccion, int id)
        {



            SqlParameter[] param = new SqlParameter[4];

            SqlCommand cmd = new SqlCommand();
            param[0] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
            param[0].Value = nombre;
            param[1] = new SqlParameter("@Telefono", SqlDbType.Char);
            param[1].Value = telefono;
            param[2] = new SqlParameter("@Direccion", SqlDbType.NVarChar);
            param[2].Value = Direccion;
            param[3] = new SqlParameter("@IdMunicipio", SqlDbType.Int);
            param[3].Value = id;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertarSucursal";
            cmd.Connection = Connect;

            cmd.Parameters.AddRange(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            await Task.Run(() =>
            {

                da.Fill(ds);

            });


        }

        public async Task ModidficarSucursal(int ids, string nombre, string telefono, string Direccion, int id)
        {



            SqlParameter[] param = new SqlParameter[5];

            SqlCommand cmd = new SqlCommand();
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ids;
            param[1] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
            param[1].Value = nombre;
            param[2] = new SqlParameter("@Telefono", SqlDbType.Char);
            param[2].Value = telefono;
            param[3] = new SqlParameter("@Direccion", SqlDbType.NVarChar);
            param[3].Value = Direccion;
            param[4] = new SqlParameter("@Idm", SqlDbType.Int);
            param[4].Value = id;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ModificarSucursal";
            cmd.Connection = Connect;

            cmd.Parameters.AddRange(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            await Task.Run(() =>
            {

                da.Fill(ds);

            });




        }

        public async Task<DataTable> MostrarSucursal()
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarSucursal";
            cmd.Connection = Connect;

            SqlDataAdapter ds = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            await Task.Run(() =>
            {
                ds.Fill(dt);

            });
            return dt;

        }

        public async Task<DataTable> MostrarProductos()
        {
            return await Task.Run(() =>
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader leer;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MostrarProductos";
                cmd.Connection = Connect;


                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                ds.Dispose();
                da.Dispose();
                //GridView1.DataSource = dt;
                return dt;
            });



        }

        public async Task insertarProducto(string nombre, string descripcion, float Precio, int existencias)
        {


            await Task.Run(() =>
            {


                try
                {
                    SqlCommand cmd = new SqlCommand();

                    SqlParameter[] param = new SqlParameter[4];
                    param[0] = new SqlParameter("@NombreProducto", SqlDbType.NVarChar);
                    param[0].Value = nombre;
                    param[1] = new SqlParameter("@DescripcionProducto", SqlDbType.NVarChar);
                    param[1].Value = descripcion;
                    param[2] = new SqlParameter("@PrecioProducto", SqlDbType.Float);
                    param[2].Value = Precio;
                    param[3] = new SqlParameter("@Existencias", SqlDbType.Int);
                    param[3].Value = existencias;


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertarProductos";
                    cmd.Connection = Connect;
                    cmd.Parameters.AddRange(param);


                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds);
                    da.Dispose();
                    ds.Dispose();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }

            });


        }
        public async Task ModificarProdutos(int id, string nombre, string descripcion, float Precio, int existencias)
        {

            await Task.Run(() =>
            {


                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@CodP", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@NombreProducto", SqlDbType.NVarChar);
                param[1].Value = nombre;
                param[2] = new SqlParameter("@DescripcionProducto", SqlDbType.NVarChar);
                param[2].Value = descripcion;
                param[3] = new SqlParameter("@PrecioProducto", SqlDbType.Float);
                param[3].Value = Precio;
                param[4] = new SqlParameter("@Existencias", SqlDbType.Int);
                param[4].Value = existencias;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ModidficarProductos";
                cmd.Connection = Connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
                da.Dispose();
                ds.Dispose();
            });
        }
        public async Task BajaProductos(int idP)
        {

            await Task.Run(async () =>
            {

                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@IdProductos", SqlDbType.Int);
                param[0].Value = idP;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Dardebajaproductos";
                cmd.Connection = Connect;
                cmd.Parameters.AddRange(param);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                await cmd.DisposeAsync();
                cmd.Dispose();
                da.Dispose();
                ds.Dispose();
                await Connect.CloseAsync();
            });
        }

        public async Task<DataTable> MostrarProveedores()
        {
            return await Task.Run(async () =>
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader leer;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MostrarProveedor";
                cmd.Connection = Connect;


                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                await cmd.DisposeAsync();
                cmd.Dispose();
                da.Dispose();
                ds.Dispose();
                await Connect.CloseAsync();
                //GridView1.DataSource = dt;
                return dt;
            });



        }

        public async Task DardebajaProv(int id)
        {
            await Task.Run(async () =>
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@IdProv", SqlDbType.Int);
                param[0].Value = id;


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DardebajaProv";
                cmd.Connection = Connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
                await cmd.DisposeAsync();
                cmd.Dispose();
                da.Dispose();
                ds.Dispose();
                await Connect.CloseAsync();
            });
        }

        public async Task insertarProveedor(string ruc, string Nombre, string Direccion, string telefono, int id)
        {


            await Task.Run(async () =>
            {


                try
                {
                    SqlCommand cmd = new SqlCommand();

                    SqlParameter[] param = new SqlParameter[5];
                    param[0] = new SqlParameter("@ruc", SqlDbType.Char);
                    param[0].Value = ruc;
                    param[1] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                    param[1].Value = Nombre;
                    param[2] = new SqlParameter("@DirecionProv", SqlDbType.NVarChar);
                    param[2].Value = Direccion;
                    param[3] = new SqlParameter("@Telefono", SqlDbType.Char);
                    param[3].Value = telefono;
                    param[4] = new SqlParameter("@IdMunicipio ", SqlDbType.Int);
                    param[4].Value = id;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertarProveedor";
                    cmd.Connection = Connect;
                    cmd.Parameters.AddRange(param);


                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds);

                    await cmd.DisposeAsync();
                    da.Dispose();
                    ds.Dispose();
                    await Connect.CloseAsync();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }

            });


        }
        public async Task ModificarProveedor(int IDP, string Nombre, string Direccion, string telefono, int id, string ruc)
        {


            await Task.Run(async () =>
            {


                try
                {
                    SqlCommand cmd = new SqlCommand();

                    SqlParameter[] param = new SqlParameter[6];
                    param[0] = new SqlParameter("@IDP", SqlDbType.Int);
                    param[0].Value = IDP;
                    param[1] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                    param[1].Value = Nombre;
                    param[2] = new SqlParameter("@DirecionProv", SqlDbType.NVarChar);
                    param[2].Value = Direccion;
                    param[3] = new SqlParameter("@Telefono", SqlDbType.Char);
                    param[3].Value = telefono;
                    param[4] = new SqlParameter("@IdMunicipio ", SqlDbType.Int);
                    param[4].Value = id;
                    param[5] = new SqlParameter("@ruc ", SqlDbType.Char, 14);
                    param[5].Value = ruc;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ModificarProveedor";
                    cmd.Connection = Connect;
                    cmd.Parameters.AddRange(param);


                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds);
                    await cmd.DisposeAsync();
                    cmd.Dispose();
                    da.Dispose();
                    ds.Dispose();
                    await Connect.CloseAsync();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }

            });

        }
        public async Task<DataTable> MostrarDepartamentos()
        {
            
                return await Task.Run(() =>
                   {


                       SqlCommand cmd = new SqlCommand();


                       cmd.CommandType = CommandType.StoredProcedure;
                       cmd.CommandText = "MostrarDepartamentos";
                       cmd.Connection = Connect;



                       SqlDataAdapter da = new SqlDataAdapter(cmd);

                       DataTable dt = new DataTable();
                       da.Fill(dt);

                       return dt;

                });
            

        }

        public async Task insertarDepartamento(string nombre)
        {


            await Task.Run(async () =>
            {


                try
                {
                    SqlCommand cmd = new SqlCommand();

                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                    param[0].Value = nombre;


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertarDepartamento";
                    cmd.Connection = Connect;
                    cmd.Parameters.AddRange(param);


                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds);

                    await cmd.DisposeAsync();
                    da.Dispose();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }

            });


        }

        public async Task ModificarDepartamento(int Id, string Nombre)
        {


            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@IdDep", SqlDbType.Int);
                param[0].Value = Id;
                param[1] = new SqlParameter("@NomDep", SqlDbType.NVarChar);
                param[1].Value = Nombre;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ModidficarDepartamentos";
                cmd.Connection = Connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);


                da.Fill(ds);
                da.Dispose();
                ds.Dispose();
            }
            catch (Exception ex) { }

        }

        public async Task<DataTable> MostrarMunicipios()
        {
            return await Task.Run(async () =>
            {
                SqlCommand cmd = new SqlCommand();


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MostrarMunicipios";
                cmd.Connection = Connect;



                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                await cmd.DisposeAsync();
                da.Dispose();
                await Connect.CloseAsync();

                return dt;
            });




        }

        public async Task InsertarMunicipio(int id, string nombre)
        {


            await Task.Run(async () =>
            {


                try
                {
                    SqlCommand cmd = new SqlCommand();

                    SqlParameter[] param = new SqlParameter[2];
                    param[0] = new SqlParameter("@IdDd", SqlDbType.Int);
                    param[0].Value = id;
                    param[1] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                    param[1].Value = nombre;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertarMunicipio";
                    cmd.Connection = Connect;
                    cmd.Parameters.AddRange(param);


                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds);

                    await cmd.DisposeAsync();
                    da.Dispose();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }

            });

        }

        public async Task<DataTable> MostrarDetCompra()
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarDetalleC";
            cmd.Connection = Connect;

            SqlDataAdapter ds = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            await Task.Run(() =>
            {
                ds.Fill(dt);

            });
            return dt;

        }

        public async Task InsertarCompra(int idProveedor, int cantidad, int idMatP, int precio,DateTime date)
        {
            await Task.Run(async () =>
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();

                    SqlParameter[] param = new SqlParameter[5];
                    param[0] = new SqlParameter("@IdProveedor", SqlDbType.Int);
                    param[0].Value = idProveedor;
                    param[1] = new SqlParameter("@cantidad", SqlDbType.Int);
                    param[1].Value = cantidad;
                    param[2] = new SqlParameter("@IdmateriaP", SqlDbType.Int);
                    param[2].Value = idMatP;
                    param[3] = new SqlParameter("@precio", SqlDbType.Int);
                    param[3].Value = precio;
                    param[4] = new SqlParameter("@fecha", SqlDbType.Date);
                    param[4].Value = date.Date;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "NCompra";
                    cmd.Connection = Connect;
                    cmd.Parameters.AddRange(param);


                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds);

                    await cmd.DisposeAsync();
                    da.Dispose();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }
            });

        }

        public async Task<DataTable> MostrarCompras()
        {
            return await Task.Run(async () =>
            {
                SqlCommand cmd = new SqlCommand();


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "VerCompras";
                cmd.Connection = Connect;



                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                await cmd.DisposeAsync();
                da.Dispose();
                await Connect.CloseAsync();

                return dt;
            });




        }


    }
}
