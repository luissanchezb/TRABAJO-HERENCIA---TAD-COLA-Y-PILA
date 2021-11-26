using System;
using System.Collections.Generic;
using System.Text;

namespace TADPILA
{
    public class SupermercadoClaseA:Supermercado
    {
        //Propiedades o Carcteristicas de Supermercado

        public string Premios { get; set; }
        public string ReconocimientoInternacional { get; set; }






        //Metodo de polimorfismo
        public override void Propiedades()
        {
            Console.WriteLine("Premios obtenidos: {0}; Reconocimiento Internacional: {1}", Premios, ReconocimientoInternacional);

        }

    }
}
