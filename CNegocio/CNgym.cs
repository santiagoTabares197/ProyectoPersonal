using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cdatos;
using CEntidad;
using System.Data;
namespace CNegocio
{
    public class CNgym
    {

        CDgym odagym = new CDgym();
        public bool GuardarRutina(CEgym oentgym)
        {
            return odagym.GuardarRutina(oentgym);
        }
        public bool EliminarRutina(CEgym oentgym)
        {
            return odagym.EliminarRutina(oentgym);
        }
        public DataSet ConsultarRutina(CEgym oentgym)
        {
            return odagym.ConsultarRutina(oentgym);
        }
    }

}
