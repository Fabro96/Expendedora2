using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Lata
    {
        //ATRIBUTOS
        private int _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;

        //CONSTRUCTORES
        public Lata()
        {

        }

        //PROPIEDADES
        public int Codigo
        {
            set { _codigo = value; }
            get { return _codigo;  }
        }
        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre;  }
        }
        public string Sabor
        {
            set { _sabor = value; }
            get { return _sabor;  }
        }
        public double Precio
        {
            set { _precio = value; }
            get { return _precio;  }
        }
        public double Volumen
        {
            set { _volumen = value; }
            get { return _volumen;  }
        }

        //MÉTODOS
        public double GetPrecioPorLitro()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
