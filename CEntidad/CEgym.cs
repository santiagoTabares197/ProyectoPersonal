using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ESTE ES EL ENCAPSULAMIENTO PARA LA CAPA ENTIDAD
namespace CEntidad
{
    public class CEgym
    {
        //Se declaran cada uno de los datos o atributos que se recogeran en la base de datos
        private int id;
        private String musculos;
        private String ejercR;
        private int reps;
        private int series;

        //metodos para cada uno de los atributos previamente creados
     


        public int Id1 { get => id; set => id = value; }
        public string Musculos1 { get => musculos; set => musculos = value; }
        public string EjercR1 { get => ejercR; set => ejercR = value; }
        public int Reps1 { get => reps; set => reps = value; }
        public int Series1 { get => series; set => series = value; }
    }
}
