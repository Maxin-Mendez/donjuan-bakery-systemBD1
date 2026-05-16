using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProyecto.ClasesCrud
{
    public class procesosDepto
    {
        //Conexion Conexion = new Conexion();

      
        //public async Task<DataTable> MostrarDepartamentos()
        //{
        //    return await Task.Run(() =>
        //    {
        //        SqlCommand cmd = new SqlCommand();

                
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "MostrarDepartamentos";
        //        cmd.Connection = Conexion.Connect1;


                
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);

        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
               
        //        return dt;
        //    });




        //}

        //public async Task insertarDepartamento(string nombre)
        //{


        //    await Task.Run(async () => {


        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand();

        //            SqlParameter[] param = new SqlParameter[1];
        //            param[0] = new SqlParameter("@Nombre", SqlDbType.NVarChar);
        //            param[0].Value = nombre;
                    

        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = "InsertarDepartamento";
        //            cmd.Connection = Conexion.Connect1;
        //            cmd.Parameters.AddRange(param);


        //            DataSet ds = new DataSet();
        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
                    
        //            da.Fill(ds);

        //           await cmd.DisposeAsync();
        //            da.Dispose();
        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show(ex.Message);
        //            return;
        //        }

        //    });


        //}

        //public async Task ModificarDepartamento(int Id, string Nombre) 
        //{
            
            
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand();

        //            SqlParameter[] param = new SqlParameter[2];
        //            param[0] = new SqlParameter("@IdDep", SqlDbType.Int);
        //            param[0].Value = Id;
        //            param[1] = new SqlParameter("@NomDep", SqlDbType.NVarChar);
        //            param[1].Value = Nombre;

        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = "ModidficarDepartamentos";
        //            cmd.Connection = Conexion.Connect1;
        //            cmd.Parameters.AddRange(param);

        //            DataSet ds = new DataSet();
        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
             

        //            da.Fill(ds);
        //            da.Dispose();
        //            ds.Dispose();
        //        }
        //        catch (Exception ex) { }
            
        //}
    }
}
