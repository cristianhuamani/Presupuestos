using System;

namespace ControlPresupuesto.Entity
{
    /// <summary>Contiene las propiedades y extructuras de la clase 'Usuario'.</summary>
    public partial class Usuario
    {
        protected string _usr;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, ListarUso, Obtener.</summary>
        public virtual string usr
        {
            get
            { return _usr;}
            set
            { _usr = value;}
        }

        protected string _codigoPersona;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, out Obtener.</summary>
        public virtual string codigoPersona
        {
            get
            { return _codigoPersona;}
            set
            { _codigoPersona = value;}
        }

        protected string _usrNombre;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string usrNombre
        {
            get
            { return _usrNombre;}
            set
            { _usrNombre = value;}
        }

        protected string _clave;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string clave
        {
            get
            { return _clave;}
            set
            { _clave = value;}
        }

        protected string _idEstado;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, out Obtener.</summary>
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
            /// <summary>Propiedad enlazada al 'usr' de la extructura de retorno.</summary>
            public string usr { get; set; }

            /// <summary>Propiedad enlazada al 'codigoPersona' de la extructura de retorno.</summary>
            public string codigoPersona { get; set; }

            /// <summary>Propiedad enlazada al 'usrNombre' de la extructura de retorno.</summary>
            public string usrNombre { get; set; }

            /// <summary>Propiedad enlazada al 'clave' de la extructura de retorno.</summary>
            public string clave { get; set; }

            /// <summary>Propiedad enlazada al 'idEstado' de la extructura de retorno.</summary>
            public string idEstado { get; set; }

        }

        /// <summary>Representa la extructura retornada por el método 'ListarUso'.</summary>
        public class ListarUso
        {
            /// <summary>Propiedad enlazada al 'usr' de la extructura de retorno.</summary>
            public string usr { get; set; }

            /// <summary>Propiedad enlazada al 'nombre' de la extructura de retorno.</summary>
            public string nombre { get; set; }

            /// <summary>Propiedad enlazada al 'usrNombre' de la extructura de retorno.</summary>
            public string usrNombre { get; set; }

            /// <summary>Propiedad enlazada al 'clave' de la extructura de retorno.</summary>
            public string clave { get; set; }

            /// <summary>Propiedad enlazada al 'estado' de la extructura de retorno.</summary>
            public string estado { get; set; }

        }

    }
}