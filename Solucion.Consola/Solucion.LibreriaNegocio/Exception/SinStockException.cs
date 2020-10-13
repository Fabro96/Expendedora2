using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class SinStockException : Exception
    {
        public SinStockException() : base("\nNo hay stock en estos momentos.") { }
    }
}
