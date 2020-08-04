using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//solucion es permitir capturar el estado interno de un objeto y salvarlo de forma externa para restaurarlo después en este caso los datos de un vehiculo
namespace Patron
{
    class Program
    {

        static void Main(string[] args)
        {
        
            // Creamos el originador
            Originador auto = new Originador("Mercedes Benz", 2020, 350000,"Gasolina");
            auto.Mostrar();
           

            // Creamos el caretaker
            CareTaker ct = new CareTaker();

            // Guardamos el estado
            ct.Memento = auto.CreaMemento();  //el memento que se crea queda guardado en el caretaker

            //Modificamos el objeto
            auto.Nombre = "McLaren";
            auto.Modelo = 1970;
            auto.Costo = 26000;
            auto.Combustible = "Diesel";
            auto.Mostrar();
           

            // Restauramos el estado anterior
            auto.Restaura(ct.Memento);
            auto.Mostrar();
            Console.ReadLine();
        }
    }
}
