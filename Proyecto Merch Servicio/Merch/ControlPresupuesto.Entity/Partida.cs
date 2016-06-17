using System;

namespace ControlPresupuesto.Entity
{
    /// <summary>Contiene las propiedades y extructuras de la clase 'Partida'.</summary>
    public partial class Partida
    {
        protected string _idPartida;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, ListarUso, Obtener.</summary>
        public virtual string idPartida
        {
            get
            { return _idPartida;}
            set
            { _idPartida = value;}
        }

        protected string _partida;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string partida
        {
            get
            { return _partida;}
            set
            { _partida = value;}
        }

        protected string _idEstado;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string idEstado
        {
            get
            { return _idEstado; }
            set
            { _idEstado = value; }
        }
        

        /// <summary>Representa la extructura retornada por el método 'Listar'.</summary>
        public class Listar
        {
            /// <summary>Propiedad enlazada al 'idPartida' de la extructura de retorno.</summary>
            public string idPartida { get; set; }

            /// <summary>Propiedad enlazada al 'Partida' de la extructura de retorno.</summary>
            public string Partida { get; set; }
            public string Estado { get; set; }
        }

        /// <summary>Representa la extructura retornada por el método 'ListarDes'.</summary>
        public class ListarDes
        {
            /// <summary>Propiedad enlazada al 'idPartida' de la extructura de retorno.</summary>
            public string idPartida { get; set; }

            /// <summary>Propiedad enlazada al 'Partida' de la extructura de retorno.</summary>
            public string Partida { get; set; }

        }

        /// <summary>Representa la extructura retornada por el método 'ListarUso'.</summary>
        public class ListarUso
        {
            /// <summary>Propiedad enlazada al 'idPartida' de la extructura de retorno.</summary>
            public string idPartida { get; set; }

            /// <summary>Propiedad enlazada al 'Partida' de la extructura de retorno.</summary>
            public string Partida { get; set; }

        }

    }
}