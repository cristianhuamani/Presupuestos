using System;

namespace ControlPresupuesto.Entity
{
    /// <summary>Contiene las propiedades y extructuras de la clase 'Cliente'.</summary>
    public partial class Cliente
    {
        protected int? _idCliente;
        /// <summary>Propiedad usada por: Actualizar, out Insertar, Listar, Obtener.</summary>
        public virtual int? idCliente
        {
            get
            { return _idCliente;}
            set
            { _idCliente = value;}
        }

        protected string _ruc;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string ruc
        {
            get
            { return _ruc;}
            set
            { _ruc = value;}
        }

        protected string _cliente;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string cliente
        {
            get
            { return _cliente;}
            set
            { _cliente = value;}
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

        protected string _contacto;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string contacto
        {
            get
            { return _contacto;}
            set
            { _contacto = value;}
        }

        protected string _correo;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual string correo
        {
            get
            { return _correo;}
            set
            { _correo = value;}
        }

        protected string _telefono;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string telefono
        {
            get
            { return _telefono;}
            set
            { _telefono = value;}
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
            /// <summary>Propiedad enlazada al 'idCliente' de la extructura de retorno.</summary>
            public int idCliente { get; set; }

            /// <summary>Propiedad enlazada al 'ruc' de la extructura de retorno.</summary>
            public string ruc { get; set; }

            /// <summary>Propiedad enlazada al 'cliente' de la extructura de retorno.</summary>
            public string cliente { get; set; }

            /// <summary>Propiedad enlazada al 'direccion' de la extructura de retorno.</summary>
            public string direccion { get; set; }

            /// <summary>Propiedad enlazada al 'contacto' de la extructura de retorno.</summary>
            public string contacto { get; set; }

            /// <summary>Propiedad enlazada al 'correo' de la extructura de retorno.</summary>
            public string correo { get; set; }

            /// <summary>Propiedad enlazada al 'telefono' de la extructura de retorno.</summary>
            public string telefono { get; set; }

            /// <summary>Propiedad enlazada al 'idEstado' de la extructura de retorno.</summary>
            public string idEstado { get; set; }

        }

        /// <summary>Representa la extructura retornada por el método 'ListarDes'.</summary>
        public class ListarDes
        {
            /// <summary>Propiedad enlazada al 'idCliente' de la extructura de retorno.</summary>
            public int idCliente { get; set; }

            /// <summary>Propiedad enlazada al 'cliente' de la extructura de retorno.</summary>
            public string cliente { get; set; }

        }

        /// <summary>Representa la extructura retornada por el método 'ListarUso'.</summary>
        public class ListarUso
        {
            /// <summary>Propiedad enlazada al 'idCliente' de la extructura de retorno.</summary>
            public int idCliente { get; set; }

            /// <summary>Propiedad enlazada al 'ruc' de la extructura de retorno.</summary>
            public string ruc { get; set; }

            /// <summary>Propiedad enlazada al 'cliente' de la extructura de retorno.</summary>
            public string cliente { get; set; }

            /// <summary>Propiedad enlazada al 'direccion' de la extructura de retorno.</summary>
            public string direccion { get; set; }

            /// <summary>Propiedad enlazada al 'contacto' de la extructura de retorno.</summary>
            public string contacto { get; set; }

            /// <summary>Propiedad enlazada al 'correo' de la extructura de retorno.</summary>
            public string correo { get; set; }

            /// <summary>Propiedad enlazada al 'telefono' de la extructura de retorno.</summary>
            public string telefono { get; set; }

            /// <summary>Propiedad enlazada al 'estado' de la extructura de retorno.</summary>
            public string estado { get; set; }

        }

    }
}