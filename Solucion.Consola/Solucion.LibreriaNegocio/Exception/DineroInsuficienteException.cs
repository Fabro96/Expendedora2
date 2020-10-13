using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class DineroInsuficienteException : Exception
    {
        public DineroInsuficienteException() : base("\nEl Dinero es insuficiente.") { }
    }
}
