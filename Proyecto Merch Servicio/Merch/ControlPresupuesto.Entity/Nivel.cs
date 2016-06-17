using System;

namespace ControlPresupuesto.Entity
{
    /// <summary>Contiene las propiedades y extructuras de la clase 'Nivel'.</summary>
    public partial class Nivel
    {
        /// <summary>Representa la extructura retornada por el método 'ListarDes'.</summary>
        public class ListarDes
        {
            /// <summary>Propiedad enlazada al 'idNivel' de la extructura de retorno.</summary>
            public string idNivel { get; set; }

            /// <summary>Propiedad enlazada al 'Nivel' de la extructura de retorno.</summary>
            public string Nivel { get; set; }

        }

    }
}