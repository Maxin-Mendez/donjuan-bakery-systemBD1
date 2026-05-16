using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProyecto.ClasesCrud
{
    public class ProcesoProv
    {
        //Conexion Conexion = new
        //    Conexion();
        //public async Task<DataTable> MostrarProveedores()
        //{
        //    return await Task.Run(async() =>
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        SqlDataReader leer;

        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "MostrarProveedor";
        //        cmd.Connection = Conexion.Connect1;


        //        DataSet ds = new DataSet();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);

        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        await cmd.DisposeAsync();
        //        cmd.Dispose();
        //        da.Dispose();
        //        ds.Dispose();
        //        await Conexion.Connect1.CloseAsync();
        //        //GridView1.DataSource = dt;
        //        return dt;
        //    });



        //}

        //public async Task DardebajaProv(int id)
        //{
        //    await Task.Run(async() => { 
        //    SqlCommand cmd = new SqlCommand();

        //    SqlParameter[] param = new SqlParameter[1];
        //    param[0] = new SqlParameter("@IdProv", SqlDbType.Int);
        //    param[0].Value = id;


        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "DardebajaProv";
        //    cmd.Connection = Conexion.Connect1;
        //    cmd.Parameters.AddRange(param);

        //    DataSet ds = new DataSet();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);

        //    da.Fill(ds);
        //        await cmd.DisposeAsync();
        //        cmd.Dispose();
        //        da.Dispose();
        //        ds.Dispose();
        //        await Conexion.Connect1.CloseAsync();
        //    });
        //}

        //public async Task insertarProveedor(string ruc, string Nombre, string Direccion, string telefono, int id)
        //{


        //    await Task.Run(async()=> {


        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand();

        //            SqlParameter[] param = new SqlParameter[5];
        //            param[0] = new SqlParameter("@ruc", SqlDbType.Char);
        //            param[0].Value = ruc;
        //            param[1] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
        //            param[1].Value = Nombre;
        //            param[2] = new SqlParameter("@DirecionProv", SqlDbType.NVarChar);
        //            param[2].Value = Direccion;
        //            param[3] = new SqlParameter("@Telefono", SqlDbType.Char);
        //            param[3].Value = telefono;
        //            param[4] = new SqlParameter("@IdMunicipio ", SqlDbType.Int);
        //            param[4].Value = id;

        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = "InsertarProveedor";
        //            cmd.Connection = Conexion.Connect1;
        //            cmd.Parameters.AddRange(param);


        //            DataSet ds = new DataSet();
        //            SqlDataAdapter da = new SqlDataAdapter(cmd);

        //            da.Fill(ds);
                    
        //            await cmd.DisposeAsync();
        //            da.Dispose();
        //            ds.Dispose();
        //            await Conexion.Connect1.CloseAsync();
        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show(ex.Message);
        //            return;
        //        }

        //    });


        //}
        //public async Task ModificarProveedor(string IDP, string Nombre, string Direccion, string telefono, int id)
        //{


        //    await Task.Run(async () => {


        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand();

        //            SqlParameter[] param = new SqlParameter[5];
        //            param[0] = new SqlParameter("@ruc", SqlDbType.Char);
        //            param[0].Value = IDP;
        //            param[1] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
        //            param[1].Value = Nombre;
        //            param[2] = new SqlParameter("@DirecionProv", SqlDbType.NVarChar);
        //            param[2].Value = Direccion;
        //            param[3] = new SqlParameter("@Telefono", SqlDbType.Char);
        //            param[3].Value = telefono;
        //            param[4] = new SqlParameter("@IdMunicipio ", SqlDbType.Int);
        //            param[4].Value = id;

        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = "ModificarProveedor";
        //            cmd.Connection = Conexion.Connect1;
        //            cmd.Parameters.AddRange(param);


        //            DataSet ds = new DataSet();
        //            SqlDataAdapter da = new SqlDataAdapter(cmd);

        //            da.Fill(ds);
        //            await cmd.DisposeAsync();
        //            cmd.Dispose();
        //            da.Dispose();
        //            ds.Dispose();
        //            await Conexion.Connect1.CloseAsync();
        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show(ex.Message);
        //            return;
        //        }

        //    });

        //}
      
        
    }
}
