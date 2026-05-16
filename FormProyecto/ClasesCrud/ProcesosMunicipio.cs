using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProyecto.ClasesCrud
{
    public class ProcesosMunicipio
    {
        //Conexion Conexion = new Conexion();

        //public async Task<DataTable> MostrarMunicipios()
        //{
        //    return await Task.Run(async() =>
        //    {
        //        SqlCommand cmd = new SqlCommand();


        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "MostrarMunicipios";
        //        cmd.Connection = Conexion.Connect1;



        //        SqlDataAdapter da = new SqlDataAdapter(cmd);

        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        await cmd.DisposeAsync();
        //        da.Dispose();
        //        await Conexion.Connect1.CloseAsync();

        //        return dt;
        //    });




        //}

        //public async Task InsertarMunicipio(int id ,string nombre)
        //{


        //    await Task.Run(async () => {


        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand();

        //            SqlParameter[] param = new SqlParameter[2];
        //            param[0] = new SqlParameter("@IdDd", SqlDbType.Int);
        //            param[0].Value = id;
        //            param[1] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
        //            param[1].Value = nombre;

        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = "InsertarMunicipio";
        //            cmd.Connection = Conexion.Connect1;
        //            cmd.Parameters.AddRange(param);


        //            DataSet ds = new DataSet();
        //            SqlDataAdapter da = new SqlDataAdapter(cmd);

        //            da.Fill(ds);

        //            await cmd.DisposeAsync();
        //            da.Dispose();
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
