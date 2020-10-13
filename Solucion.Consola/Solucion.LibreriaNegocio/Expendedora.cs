using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Expendedora
    {
        //ATRIBUTOS
        private List<Lata> _latas;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;

        //CONSTRUCTORES
        public Expendedora()
        {

        }
        
        //PROPIEDADES
        public List<Lata> Latas
        {
            get { return _latas; }
        }
        public string Proveedor
        {
            set { _proveedor = value; }
            get { return _proveedor;  }
        }
        public int Capacidad
        {
            set { _capacidad = value; }
            get { return _capacidad;  }
        }
        public double Dinero
        {
            set { _dinero = value; }
            get { return _dinero;  }
        }
        public bool Encendida
        {
            get { return _encendida; }
        }

        //MÉTODOS
        public void AgregarLata(Lata lata)
        {
            throw new NotImplementedException();
        }
        public Lata ExtraerLata(string s, double d)
        {
            throw new NotImplementedException();
        }
        public string GetBalance()
        {
            throw new NotImplementedException();
        }
        public int GetCapacidadRestante()
        {
            throw new NotImplementedException();
        }
        public void EncenderMaquina()
        {
            throw new NotImplementedException();
        }
        public bool EstaVacia()
        {
            throw new NotImplementedException();
        }

    }
}
