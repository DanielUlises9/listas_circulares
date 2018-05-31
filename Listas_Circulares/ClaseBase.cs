using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    class ClaseBase
    {
        private string _nombre;
        public string Nombre { get {return _nombre; }}
        private int _tiempo;
        public int tiempo { get { return _tiempo; } }

        ClaseBase siguiente;
        public ClaseBase Siguiente
        {
           get => siguiente;
            set => siguiente = value;
        }

        ClaseBase anterior;
        public ClaseBase Anterior
        {
            get => anterior;
            set => anterior=value;
        }

        public ClaseBase(string nombre_,int tiempo_)
        {
            _nombre = nombre_;
            _tiempo = tiempo_;
        }

        public override string ToString()
        {
            return "Nombre "+ _nombre +" Tiempo " + _tiempo;
        }
    }
}
