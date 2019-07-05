using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pregunta1_FizzBuzz.ModeloPregunta4
{
    public class Grupo
    {
        public string nombreOficina { get; set; }
        [Range(1,23, ErrorMessage ="El código departamental debe encontrarse entre 1 - 23")]
        public int codAreaDep { get; set; }
        public virtual List<Empleado> listaEmpleados { get; set; }

        public Grupo() { }
    }
}
