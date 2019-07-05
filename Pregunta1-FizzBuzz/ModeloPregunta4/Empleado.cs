using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pregunta1_FizzBuzz.ModeloPregunta4
{
    public class Empleado
    {
        public string nombre { get; set;  }
        public int codNumerico { get; set; }
        public string puestoTrabajo { get; set; }
        [DataType(DataType.Currency)]
        public decimal sueldoBase { get; set; }
        public string referenciaSuperior { get; set; }
        public string referenciaGrupo { get; set; }


        public Empleado() {            
        }

        public Empleado(string nombre, int codNumerico, string puestoTrabajo, decimal sueldoBase, string referenciaSup, string referenciaGrupo )
        {
            this.nombre = nombre;
            this.codNumerico = codNumerico;
            this.puestoTrabajo = puestoTrabajo;
            this.sueldoBase = sueldoBase;
            this.referenciaSuperior = referenciaSup;
            this.referenciaGrupo = referenciaGrupo;
        }

    }
}
