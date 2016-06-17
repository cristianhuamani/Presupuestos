using System;

namespace ControlPresupuesto.Entity
{
    /// <summary>Contiene las propiedades y extructuras de la clase 'CentroCosto_Cab'.</summary>
    public partial class CentroCosto_Cab
    {
        protected string _filtro;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, ListarUso, Obtener.</summary>
        public virtual string filtro
        {
            get
            { return _filtro; }
            set
            { _filtro = value; }
        }

        protected string _ccosto;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, ListarUso, Obtener.</summary>
        public virtual string ccosto
        {
            get
            { return _ccosto;}
            set
            { _ccosto = value;}
        }

        protected string _ej;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string ej
        {
            get
            { return _ej;}
            set
            { _ej = value;}
        }

        protected string _mes;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string mes
        {
            get
            { return _mes;}
            set
            { _mes = value;}
        }

        protected string _descripcion;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string descripcion
        {
            get
            { return _descripcion;}
            set
            { _descripcion = value;}
        }

        protected int? _idcliente;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, ListarDes, out Obtener.</summary>
        public virtual int? idcliente
        {
            get
            { return _idcliente; }
            set
            { _idcliente = value;}
        }

        protected int? _idPersona;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, ListarDes, out Obtener.</summary>
        public virtual int? idPersona
        {
            get
            { return _idPersona; }
            set
            { _idPersona = value;}
        }

        protected string _usr;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string usr
        {
            get
            { return _usr;}
            set
            { _usr = value;}
        }

        protected DateTime? _fechaReg;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual DateTime? fechaReg
        {
            get
            { return _fechaReg;}
            set
            { _fechaReg = value;}
        }

        protected string _hora;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string hora
        {
            get
            { return _hora;}
            set
            { _hora = value;}
        }

        protected string _usrMod;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string usrMod
        {
            get
            { return _usrMod;}
            set
            { _usrMod = value;}
        }

        protected DateTime? _fechaMod;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual DateTime? fechaMod
        {
            get
            { return _fechaMod;}
            set
            { _fechaMod = value;}
        }

        protected string _horaMod;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual string horaMod
        {
            get
            { return _horaMod;}
            set
            { _horaMod = value;}
        }

        protected decimal? _total;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual decimal? total
        {
            get
            { return _total;}
            set
            { _total = value;}
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
            /// <summary>Propiedad enlazada al 'ccosto' de la extructura de retorno.</summary>
            public string ccosto { get; set; }

            /// <summary>Propiedad enlazada al 'ej' de la extructura de retorno.</summary>
            public string ej { get; set; }

            /// <summary>Propiedad enlazada al 'mes' de la extructura de retorno.</summary>
            public string mes { get; set; }

            /// <summary>Propiedad enlazada al 'descripcion' de la extructura de retorno.</summary>
            public string descripcion { get; set; }

            /// <summary>Propiedad enlazada al 'cliente' de la extructura de retorno.</summary>
            public string cliente { get; set; }

            /// <summary>Propiedad enlazada al 'responsable' de la extructura de retorno.</summary>
            public string responsable { get; set; }

            /// <summary>Propiedad enlazada al 'usr' de la extructura de retorno.</summary>
            public string usr { get; set; }

            /// <summary>Propiedad enlazada al 'fechaReg' de la extructura de retorno.</summary>
            public object fechaReg { get; set; }

            /// <summary>Propiedad enlazada al 'hora' de la extructura de retorno.</summary>
            public string hora { get; set; }

            /// <summary>Propiedad enlazada al 'usrMod' de la extructura de retorno.</summary>
            public string usrMod { get; set; }

            /// <summary>Propiedad enlazada al 'fechaMod' de la extructura de retorno.</summary>
            public object fechaMod { get; set; }

            /// <summary>Propiedad enlazada al 'horaMod' de la extructura de retorno.</summary>
            public string horaMod { get; set; }

            /// <summary>Propiedad enlazada al 'total' de la extructura de retorno.</summary>
            public decimal total { get; set; }

            /// <summary>Propiedad enlazada al 'idEstado' de la extructura de retorno.</summary>
            public string idEstado { get; set; }

        }

        /// <summary>Representa la extructura retornada por el método 'ListarDes'.</summary>
        public class ListarDes
        {
            /// <summary>Propiedad enlazada al 'ccosto' de la extructura de retorno.</summary>
            public string ccosto { get; set; }

            /// <summary>Propiedad enlazada al 'descripcion' de la extructura de retorno.</summary>
            public string descripcion { get; set; }

        }

        /// <summary>Representa la extructura retornada por el método 'ListarUso'.</summary>
        public class ListarUso
        {

            /// <summary>Propiedad enlazada al 'ej' de la extructura de retorno.</summary>
            public string ej { get; set; }

            /// <summary>Propiedad enlazada al 'ccosto' de la extructura de retorno.</summary>
            public string ccosto { get; set; }

            /// <summary>Propiedad enlazada al 'descripcion' de la extructura de retorno.</summary>
            public string descripcion { get; set; }

            /// <summary>Propiedad enlazada al 'fechaReg' de la extructura de retorno.</summary>
            public string fechaReg { get; set; }

            /// <summary>Propiedad enlazada al 'estado' de la extructura de retorno.</summary>
            public string estado { get; set; }

        }

    }
}