using System;
using System.Collections.Generic;
using System.Text;

namespace TADCOLA
{
    public abstract class Supermercado
    {
        //Propiedades o Carcteristicas

        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public int Añodecreacion { get; set; }


        //Metodo para mostrar


        public virtual void mostrar()
        {
            Console.WriteLine("Nombre del Supermercado: {0}; Ciudad del Supermercado: {1}; Año de Creeacion: {2}", Nombre, Ciudad, Añodecreacion);
        }

        //Metodo de polimorfismo

        public abstract void Propiedades();
    }
}
