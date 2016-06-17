using System;

namespace ControlPresupuesto.Entity
{
    /// <summary>Contiene las propiedades y extructuras de la clase 'CentroCosto_Lin'.</summary>
    public partial class CentroCosto_Lin
    {
        protected string _ccosto;
        /// <summary>Propiedad usada por: Actualizar, Eliminar, Insertar, Listar, ListarUso, Obtener.</summary>
        public virtual string ccosto
        {
            get
            { return _ccosto; }
            set
            { _ccosto = value; }
        }

        protected string _idPartida;
        /// <summary>Propiedad usada por: Actualizar, Eliminar, Insertar, Listar, ListarUso, Obtener.</summary>
        public virtual string idPartida
        {
            get
            { return _idPartida; }
            set
            { _idPartida = value; }
        }

        protected decimal? _total;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual decimal? total
        {
            get
            { return _total; }
            set
            { _total = value; }
        }

        /// <summary>Representa la extructura retornada por el método 'Listar'.</summary>
        public class Listar
        {
            /// <summary>Propiedad enlazada al 'ccosto' de la extructura de retorno.</summary>
            
            /// <summary>Propiedad enlazada al 'idPartida' de la extructura de retorno.</summary>
            public string idPartida { get; set; }

            /// <summary>Propiedad enlazada al 'total' de la extructura de retorno.</summary>
            public string partida { get; set; }

        }

        /// <summary>Representa la extructura retornada por el método 'ListarUso'.</summary>
        public class ListarUso
        {
            /// <summary>Propiedad enlazada al 'Partida' de la extructura de retorno.</summary>
            public string idPartida { get; set; }


            /// <summary>Propiedad enlazada al 'descripcion' de la extructura de retorno.</summary>
            public string Partida { get; set; }


            /// <summary>Propiedad enlazada al 'total' de la extructura de retorno.</summary>
            public decimal total { get; set; }

        }

    }
}