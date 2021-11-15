using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidad;

namespace Cdatos
{
    public class CDgym
    {
        conexion oconexion = new conexion();
        SqlCommand ocmd = new SqlCommand();

        //Procedimineto  para guardar la rutina
        public bool GuardarRutina(CEgym ogym)
        {
            //Se realiza un crud dependiendo 
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.BDGimnasio("BDGimnasio");
                ocmd.CommandText = "GuardarRutina";
                ocmd.Parameters.Add("@id",ogym.Id1);
                ocmd.Parameters.Add("@Musculos", ogym.Musculos1);
                ocmd.Parameters.Add("@EjericiosR", ogym.EjercR1);
                ocmd.Parameters.Add("@Repeticiones", ogym.Reps1);
                ocmd.Parameters.Add("@Series", ogym.Series1);

                ocmd.ExecuteNonQuery();
                return true;

            } catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        //Procedimiento de consultar la rutina
        public DataSet ConsultarRutina(CEgym ogym)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.BDGimnasio("BDGimnasio");
                ocmd.CommandText = "ConsultarRutina";
                ocmd.Parameters.Add("@id", ogym.Id1);
                ocmd.Parameters.Add("@Musculos", ogym.Musculos1);
                ocmd.Parameters.Add("@EjericiosR", ogym.EjercR1);
                ocmd.Parameters.Add("@Repeticiones", ogym.Reps1);
                ocmd.Parameters.Add("@Series", ogym.Series1);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;  
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        public bool EliminarRutina(CEgym ogym)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.BDGimnasio("BDGimnasio");
                ocmd.CommandText = "EliminarRutina";
                ocmd.Parameters.Add("@id", ogym.Id1);
                ocmd.Parameters.Add("@Musculos", ogym.Musculos1);
                ocmd.Parameters.Add("@EjericiosR", ogym.EjercR1);
                ocmd.Parameters.Add("@Repeticiones", ogym.Reps1);
                ocmd.Parameters.Add("@Series", ogym.Series1);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

    }
}
