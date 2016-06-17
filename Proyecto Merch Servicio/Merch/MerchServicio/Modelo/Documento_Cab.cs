using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MerchServicio.Modelo
{
    public class Documento_Cab
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
            { return _ccosto; }
            set
            { _ccosto = value; }
        }

        protected string _doc;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, ListarUso, Obtener.</summary>
        public virtual string doc
        {
            get
            { return _doc; }
            set
            { _doc = value; }
        }

        protected string _numero;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, ListarUso, Obtener.</summary>
        public virtual string numero
        {
            get
            { return _numero; }
            set
            { _numero = value; }
        }

        protected string _ej;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string ej
        {
            get
            { return _ej; }
            set
            { _ej = value; }
        }

        protected string _mes;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string mes
        {
            get
            { return _mes; }
            set
            { _mes = value; }
        }

        protected int _idPersona;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual int idPersona
        {
            get
            { return _idPersona; }
            set
            { _idPersona = value; }
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

        protected string _usr;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string usr
        {
            get
            { return _usr; }
            set
            { _usr = value; }
        }

        protected object _fechaReg;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual object fechaReg
        {
            get
            { return _fechaReg; }
            set
            { _fechaReg = value; }
        }

        protected string _hora;
        /// <summary>Propiedad usada por: Actualizar, Insertar, ListarUso, out Obtener.</summary>
        public virtual string hora
        {
            get
            { return _hora; }
            set
            { _hora = value; }
        }

        protected string _usrMod;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual string usrMod
        {
            get
            { return _usrMod; }
            set
            { _usrMod = value; }
        }

        protected object _fechaMod;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual object fechaMod
        {
            get
            { return _fechaMod; }
            set
            { _fechaMod = value; }
        }

        protected string _horaMod;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual string horaMod
        {
            get
            { return _horaMod; }
            set
            { _horaMod = value; }
        }

        protected string _usrTermino;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual string usrTermino
        {
            get
            { return _usrTermino; }
            set
            { _usrTermino = value; }
        }

        protected object _fechaTermino;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual object fechaTermino
        {
            get
            { return _fechaTermino; }
            set
            { _fechaTermino = value; }
        }

        protected string _horaTermino;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual string horaTermino
        {
            get
            { return _horaTermino; }
            set
            { _horaTermino = value; }
        }

        protected string _idEstado;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, out Obtener.</summary>
        public virtual string idEstado
        {
            get
            { return _idEstado; }
            set
            { _idEstado = value; }
        }

        protected string _descripcion;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, out Obtener.</summary>
        public virtual string descripcion
        {
            get
            { return _descripcion; }
            set
            { _descripcion = value; }
        }

        protected string _cliente;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, out Obtener.</summary>
        public virtual string cliente
        {
            get
            { return _cliente; }
            set
            { _cliente = value; }
        }

        protected string _ejecutivo;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Listar, out Obtener.</summary>
        public virtual string ejecutivo
        {
            get
            { return _ejecutivo; }
            set
            { _ejecutivo = value; }
        }

        /// <summary>Representa la extructura retornada por el método 'Listar'.</summary>
        public class Listar
        {
            /// <summary>Propiedad enlazada al 'ccosto' de la extructura de retorno.</summary>
            public string ccosto { get; set; }

            /// <summary>Propiedad enlazada al 'doc' de la extructura de retorno.</summary>
            public string doc { get; set; }

            /// <summary>Propiedad enlazada al 'numero' de la extructura de retorno.</summary>
            public string numero { get; set; }

            /// <summary>Propiedad enlazada al 'ej' de la extructura de retorno.</summary>
            public string ej { get; set; }

            /// <summary>Propiedad enlazada al 'mes' de la extructura de retorno.</summary>
            public string mes { get; set; }

            /// <summary>Propiedad enlazada al 'solicitante' de la extructura de retorno.</summary>
            public string solicitante { get; set; }

            /// <summary>Propiedad enlazada al 'total' de la extructura de retorno.</summary>
            public decimal total { get; set; }

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

            /// <summary>Propiedad enlazada al 'usrTermino' de la extructura de retorno.</summary>
            public string usrTermino { get; set; }

            /// <summary>Propiedad enlazada al 'fechaTermino' de la extructura de retorno.</summary>
            public object fechaTermino { get; set; }

            /// <summary>Propiedad enlazada al 'horaTermino' de la extructura de retorno.</summary>
            public string horaTermino { get; set; }

            /// <summary>Propiedad enlazada al 'idEstado' de la extructura de retorno.</summary>
            public string idEstado { get; set; }

        }

        /// <summary>Representa la extructura retornada por el método 'ListarUso'.</summary>
        public class ListarUso
        {

            /// <summary>Propiedad enlazada al 'ej' de la extructura de retorno.</summary>
            public string ej { get; set; }

            /// <summary>Propiedad enlazada al 'ccosto' de la extructura de retorno.</summary>
            public string ccosto { get; set; }

            /// <summary>Propiedad enlazada al 'doc' de la extructura de retorno.</summary>
            public string doc { get; set; }

            /// <summary>Propiedad enlazada al 'numero' de la extructura de retorno.</summary>
            public string numero { get; set; }

            /// <summary>Propiedad enlazada al 'descripcion' de la extructura de retorno.</summary>
            public string descripcion { get; set; }

            /// <summary>Propiedad enlazada al 'fechaReg' de la extructura de retorno.</summary>
            public DateTime fechaReg { get; set; }

            /// <summary>Propiedad enlazada al 'cliente' de la extructura de retorno.</summary>
            public string cliente { get; set; }

            /// <summary>Propiedad enlazada al 'estado' de la extructura de retorno.</summary>
            public string estado { get; set; }

        }

    }
}