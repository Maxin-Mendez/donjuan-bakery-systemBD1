using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FormProyecto.ClasesCrud
{
    public class ProcedimientosProductos

    {      
        //Conexion Conexion = new
        //    Conexion(); 
        //public async Task<DataTable> MostrarProductos()
        //{
        //    return await Task.Run(() =>
        //     {
        //         SqlCommand cmd = new SqlCommand();
        //         SqlDataReader leer;

        //         cmd.CommandType = CommandType.StoredProcedure;
        //         cmd.CommandText = "MostrarProductos";
        //         cmd.Connection =Conexion.Connect1;


        //         DataSet ds = new DataSet();
        //         SqlDataAdapter da = new SqlDataAdapter(cmd);

        //         DataTable dt = new DataTable();
        //         da.Fill(dt);
        //         ds.Dispose();
        //         da.Dispose();
        //         //GridView1.DataSource = dt;
        //         return dt;
        //     });



        //}

        //public async Task  insertarProducto(string nombre, string descripcion, float Precio, int existencias)
        //{


        //    await Task.Run(() => {


        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand();

        //            SqlParameter[] param = new SqlParameter[4];
        //            param[0] = new SqlParameter("@NombreProducto", SqlDbType.NVarChar);
        //            param[0].Value = nombre;
        //            param[1] = new SqlParameter("@DescripcionProducto", SqlDbType.NVarChar);
        //            param[1].Value = descripcion;
        //            param[2] = new SqlParameter("@PrecioProducto", SqlDbType.Float);
        //            param[2].Value = Precio;
        //            param[3] = new SqlParameter("@Existencias", SqlDbType.Int);
        //            param[3].Value = existencias;


        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = "InsertarProductos";
        //            cmd.Connection = Conexion.Connect1;
        //            cmd.Parameters.AddRange(param);


        //            DataSet ds = new DataSet();
        //            SqlDataAdapter da = new SqlDataAdapter(cmd);

        //            da.Fill(ds);
        //            da.Dispose();
        //            ds.Dispose();
        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show(ex.Message);
        //            return;
        //        }

        //    });

            
        //}
        //public async Task ModificarProdutos(int id ,string nombre , string descripcion,float Precio, int existencias) {

        //    await Task.Run(() => {


        //        SqlCommand cmd = new SqlCommand();

        //        SqlParameter[] param = new SqlParameter[5];
        //        param[0] = new SqlParameter("@CodP", SqlDbType.Int);
        //        param[0].Value = id;
        //        param[1] = new SqlParameter("@NombreProducto", SqlDbType.NVarChar);
        //        param[1].Value = nombre;
        //        param[2] = new SqlParameter("@DescripcionProducto", SqlDbType.NVarChar);
        //        param[2].Value = descripcion;
        //        param[3] = new SqlParameter("@PrecioProducto", SqlDbType.Float);
        //        param[3].Value = Precio;
        //        param[4] = new SqlParameter("@Existencias", SqlDbType.Int);
        //        param[4].Value = existencias;

        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "ModidficarProductos";
        //        cmd.Connection = Conexion.Connect1;
        //        cmd.Parameters.AddRange(param);

        //        DataSet ds = new DataSet();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);

        //        da.Fill(ds);
        //        da.Dispose();
        //        ds.Dispose();
        //    });
        //}
        //public async Task BajaProductos(int idP) {

        //    await Task.Run(async() => {

        //        SqlCommand cmd = new SqlCommand();

        //        SqlParameter[] param = new SqlParameter[1];
        //        param[0] = new SqlParameter("@IdProductos", SqlDbType.Int);
        //        param[0].Value = idP;

        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "Dardebajaproductos";
        //        cmd.Connection = Conexion.Connect1;
        //        cmd.Parameters.AddRange(param);
        //        DataSet ds = new DataSet();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(ds);
        //        await cmd.DisposeAsync();
        //        cmd.Dispose();
        //        da.Dispose();
        //        ds.Dispose();
        //        await Conexion.Connect1.CloseAsync();
        //    });
        //}
    }
}
