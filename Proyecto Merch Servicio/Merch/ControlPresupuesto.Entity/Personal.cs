using System;

namespace ControlPresupuesto.Entity
{
    /// <summary>Contiene las propiedades y extructuras de la clase 'Personal'.</summary>
    public partial class Personal
    {
        protected int? _idPersona;
        /// <summary>Propiedad usada por: Actualizar, out Insertar, Listar, Obtener.</summary>
        public virtual int? idPersona
        {
            get
            { return _idPersona;}
            set
            { _idPersona = value;}
        }

        protected string _codigoPersona;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string codigoPersona
        {
            get
            { return _codigoPersona;}
            set
            { _codigoPersona = value;}
        }

        protected string _nombre;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string nombre
        {
            get
            { return _nombre;}
            set
            { _nombre = value;}
        }

        protected string _apellidoPaterno;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string apellidoPaterno
        {
            get
            { return _apellidoPaterno;}
            set
            { _apellidoPaterno = value;}
        }

        protected string _apellidoMarterno;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string apellidoMarterno
        {
            get
            { return _apellidoMarterno;}
            set
            { _apellidoMarterno = value;}
        }

        protected string _direccion;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string direccion
        {
            get
            { return _direccion;}
            set
            { _direccion = value;}
        }

        protected string _tefelofono;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual string tefelofono
        {
            get
            { return _tefelofono;}
            set
            { _tefelofono = value;}
        }

        protected object _fechaNac;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual object fechaNac
        {
            get
            { return _fechaNac;}
            set
            { _fechaNac = value;}
        }

        protected string _idSexo;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, ListarDes, out Obtener.</summary>
        public virtual string idSexo
        {
            get
            { return _idSexo;}
            set
            { _idSexo = value;}
        }

        protected string _idEstado;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, ListarDes, out Obtener.</summary>
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
            /// <summary>Propiedad enlazada al 'idPersona' de la extructura de retorno.</summary>
            public int idPersona { get; set; }

            /// <summary>Propiedad enlazada al 'codigoPersona' de la extructura de retorno.</summary>
            public string codigoPersona { get; set; }

            /// <summary>Propiedad enlazada al 'nombre' de la extructura de retorno.</summary>
            public string nombre { get; set; }

            /// <summary>Propiedad enlazada al 'apellidoPaterno' de la extructura de retorno.</summary>
            public string apellidoPaterno { get; set; }

            /// <summary>Propiedad enlazada al 'apellidoMarterno' de la extructura de retorno.</summary>
            public string apellidoMarterno { get; set; }

            /// <summary>Propiedad enlazada al 'direccion' de la extructura de retorno.</summary>
            public string direccion { get; set; }

            /// <summary>Propiedad enlazada al 'tefelofono' de la extructura de retorno.</summary>
            public string tefelofono { get; set; }

            /// <summary>Propiedad enlazada al 'fechaNac' de la extructura de retorno.</summary>
            public object fechaNac { get; set; }

            /// <summary>Propiedad enlazada al 'idSexo' de la extructura de retorno.</summary>
            public string idSexo { get; set; }

            /// <summary>Propiedad enlazada al 'idEstado' de la extructura de retorno.</summary>
            public string idEstado { get; set; }

        }

        /// <summary>Representa la extructura retornada por el método 'ListarDes'.</summary>
        public class ListarDes
        {
            /// <summary>Propiedad enlazada al 'idPersona' de la extructura de retorno.</summary>
            public int idPersona { get; set; }

            /// <summary>Propiedad enlazada al 'nombre' de la extructura de retorno.</summary>
            public string nombre { get; set; }

        }

        /// <summary>Representa la extructura retornada por el método 'ListarUso'.</summary>
        public class ListarUso
        {
            /// <summary>Propiedad enlazada al 'idPersona' de la extructura de retorno.</summary>
            public int idPersona { get; set; }

            /// <summary>Propiedad enlazada al 'codigoPersona' de la extructura de retorno.</summary>
            public string codigoPersona { get; set; }

            /// <summary>Propiedad enlazada al 'nombre' de la extructura de retorno.</summary>
            public string nombre { get; set; }

            /// <summary>Propiedad enlazada al 'apellidoPaterno' de la extructura de retorno.</summary>
            public string apellidoPaterno { get; set; }

            /// <summary>Propiedad enlazada al 'apellidoMarterno' de la extructura de retorno.</summary>
            public string apellidoMarterno { get; set; }

            /// <summary>Propiedad enlazada al 'direccion' de la extructura de retorno.</summary>
            public string direccion { get; set; }

            /// <summary>Propiedad enlazada al 'tefelofono' de la extructura de retorno.</summary>
            public string tefelofono { get; set; }

            /// <summary>Propiedad enlazada al 'fechaNac' de la extructura de retorno.</summary>
            public object fechaNac { get; set; }

            /// <summary>Propiedad enlazada al 'sexo' de la extructura de retorno.</summary>
            public string sexo { get; set; }

            /// <summary>Propiedad enlazada al 'estado' de la extructura de retorno.</summary>
            public string estado { get; set; }

        }

    }
}