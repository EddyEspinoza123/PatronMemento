using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron
{
    [Serializable]
    class Originador
    {

        private string nombre;
        private int modelo;
        private double costo;
        private string combustible;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public double Costo { get => costo; set => costo = value; }
        public string Combustible { get => combustible; set => combustible= value; }

        public Originador(string pNombre, int pModelo, double pCosto, string pCombustible)
        {
            nombre = pNombre;
            modelo = pModelo;
            costo = pCosto;
            combustible = pCombustible;
        }

        public void Mostrar()
        {
            Console.WriteLine("{0} {1},con costo de ${2}, Tipo de combustible {3}", nombre, modelo, costo, combustible);
        }

        public Memento CreaMemento()
        {
            Memento miMemento = new Memento();
            miMemento.Salvar(this);
            return miMemento;
        }

        public void Restaura(Memento pMemento)
        {
            Originador temp = pMemento.Restaurar();
            nombre = temp.Nombre;
            modelo = temp.Modelo;
            costo = temp.Costo;
            combustible = temp.Combustible;

        }

    }   
}
