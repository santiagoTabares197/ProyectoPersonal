using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //linea para sql
using System.Configuration; // ConfigurationSettings

namespace Cdatos
{
    public class conexion
    {
        //codigo para conectar a la base de datos
        
        public SqlConnection BDGimnasio(String Cnx) //Es una funcion que sirve para abrir la base de datos
        {
            try //Desactiva la recoleccion automatica de errores
            {
                SqlConnection oconectar = new SqlConnection(ConfigurationSettings.AppSettings[Cnx].ToString());
                oconectar.Open(); //Metodo que abre nuestra BD
                return oconectar; //Retorna lo que necesitamos

            }catch(Exception err)
            {
                throw new Exception(err.Message); //En caso de error se ejecuta esta linea
            }
        }

        }



    }

