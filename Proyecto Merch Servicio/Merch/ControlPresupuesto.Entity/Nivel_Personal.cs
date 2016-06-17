using System;

namespace ControlPresupuesto.Entity
{
    /// <summary>Contiene las propiedades y extructuras de la clase 'Nivel_Personal'.</summary>
    public partial class Nivel_Personal
    {
        protected string _idNivel;
        /// <summary>Propiedad usada por: Actualizar, Eliminar, Insertar, Listar, ListarUso, Obtener.</summary>
        public virtual string idNivel
        {
            get
            { return _idNivel;}
            set
            { _idNivel = value;}
        }

        protected string _codigoPersona;
        /// <summary>Propiedad usada por: Actualizar, Eliminar, Insertar, Listar, ListarUso, Obtener.</summary>
        public virtual string codigoPersona
        {
            get
            { return _codigoPersona;}
            set
            { _codigoPersona = value;}
        }

        protected string _idEstado;
        /// <summary>Propiedad usada por: Actualizar, Eliminar, Insertar, Listar, out Obtener.</summary>
        public virtual string idEstado
        {
            get
            { return _idEstado;}
            set
            { _idEstado = value;}
        }

        /// <summary>Representa la extructura retornada por el método 'Listar'.</summary>
        public class Listar
        {
            /// <summary>Propiedad enlazada al 'idNivel' de la extructura de retorno.</summary>
            public string idNivel { get; set; }

            /// <summary>Propiedad enlazada al 'codigoPersona' de la extructura de retorno.</summary>
            public string codigoPersona { get; set; }

            /// <summary>Propiedad enlazada al 'idEstado' de la extructura de retorno.</summary>
            public string idEstado { get; set; }

        }

        /// <summary>Representa la extructura retornada por el método 'ListarUso'.</summary>
        public class ListarUso
        {
            /// <summary>Propiedad enlazada al 'Nivel' de la extructura de retorno.</summary>
            public string Nivel { get; set; }

            /// <summary>Propiedad enlazada al 'nombre' de la extructura de retorno.</summary>
            public string nombre { get; set; }

            /// <summary>Propiedad enlazada al 'estado' de la extructura de retorno.</summary>
            public string estado { get; set; }

        }

        public class ListarDes
        {
            /// <summary>Propiedad enlazada al 'idNivel' de la extructura de retorno.</summary>
            public int idPersona { get; set; }

            /// <summary>Propiedad enlazada al 'codigoPersona' de la extructura de retorno.</summary>
            public string Nombre { get; set; }

            
        }

    }
}