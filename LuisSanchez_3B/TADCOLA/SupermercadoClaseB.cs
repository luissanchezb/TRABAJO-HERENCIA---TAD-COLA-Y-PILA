using System;
using System.Collections.Generic;
using System.Text;

namespace TADCOLA
{
   public  class SupermercadoClaseB: Supermercado
    {

        //Propiedades o Carcteristicas de Supermercado

        public string Tipo { get; set; }
        public string ReconocimientoNacional { get; set; }




        //Metodo de polimorfismo
        public override void Propiedades()
        {
            Console.WriteLine("Tipo de Supermercado: {0}; Reconocimiento Nacional: {1}", Tipo, ReconocimientoNacional);
        }
    }
}
