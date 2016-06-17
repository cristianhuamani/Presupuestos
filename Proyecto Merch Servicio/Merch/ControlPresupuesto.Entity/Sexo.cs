using System;

namespace ControlPresupuesto.Entity
{
    /// <summary>Contiene las propiedades y extructuras de la clase 'Sexo'.</summary>
    public partial class Sexo
    {
        /// <summary>Representa la extructura retornada por el método 'ListarDes'.</summary>
        public class ListarDes
        {
            /// <summary>Propiedad enlazada al 'idSexo' de la extructura de retorno.</summary>
            public string idSexo { get; set; }

            /// <summary>Propiedad enlazada al 'sexo' de la extructura de retorno.</summary>
            public string sexo { get; set; }

        }

    }
}