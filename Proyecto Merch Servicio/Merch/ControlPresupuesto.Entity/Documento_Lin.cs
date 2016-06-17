using System;

namespace ControlPresupuesto.Entity
{
    /// <summary>Contiene las propiedades y extructuras de la clase 'Documento_Lin'.</summary>
    public partial class Documento_Lin
    {
        protected string _ccosto;
        /// <summary>Propiedad usada por: Actualizar, Eliminar, Insertar, Listar, ListarUso, Obtener.</summary>
        public virtual string ccosto
        {
            get
            { return _ccosto;}
            set
            { _ccosto = value;}
        }

        protected string _doc;
        /// <summary>Propiedad usada por: Actualizar, Eliminar, Insertar, Listar, ListarUso, Obtener.</summary>
        public virtual string doc
        {
            get
            { return _doc;}
            set
            { _doc = value;}
        }

        protected string _numero;
        /// <summary>Propiedad usada por: Actualizar, Eliminar, Insertar, Listar, ListarUso, Obtener.</summary>
        public virtual string numero
        {
            get
            { return _numero;}
            set
            { _numero = value;}
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

        protected int? _cantidad;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual int? cantidad
        {
            get
            { return _cantidad;}
            set
            { _cantidad = value;}
        }

        protected decimal? _precio;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual decimal? precio
        {
            get
            { return _precio;}
            set
            { _precio = value;}
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

        /// <summary>Representa la extructura retornada por el método 'Listar'.</summary>
        public class Listar
        {
            /// <summary>Propiedad enlazada al 'ccosto' de la extructura de retorno.</summary>
            public string ccosto { get; set; }

            /// <summary>Propiedad enlazada al 'doc' de la extructura de retorno.</summary>
            public string doc { get; set; }

            /// <summary>Propiedad enlazada al 'numero' de la extructura de retorno.</summary>
            public string numero { get; set; }

            /// <summary>Propiedad enlazada al 'partida' de la extructura de retorno.</summary>
            public string partida { get; set; }

            /// <summary>Propiedad enlazada al 'ej' de la extructura de retorno.</summary>
            public string ej { get; set; }

            /// <summary>Propiedad enlazada al 'mes' de la extructura de retorno.</summary>
            public string mes { get; set; }

            /// <summary>Propiedad enlazada al 'cantidad' de la extructura de retorno.</summary>
            public int cantidad { get; set; }

            /// <summary>Propiedad enlazada al 'precio' de la extructura de retorno.</summary>
            public decimal precio { get; set; }

            /// <summary>Propiedad enlazada al 'total' de la extructura de retorno.</summary>
            public decimal total { get; set; }

        }

        /// <summary>Representa la extructura retornada por el método 'ListarUso'.</summary>
        public class ListarUso
        {
            
            /// <summary>Propiedad enlazada al 'idPartida' de la extructura de retorno.</summary>
            public string idPartida { get; set; }

            /// <summary>Propiedad enlazada al 'partida' de la extructura de retorno.</summary>
            public string partida { get; set; }

            /// <summary>Propiedad enlazada al 'cantidad' de la extructura de retorno.</summary>
            public int cantidad { get; set; }

            /// <summary>Propiedad enlazada al 'precio' de la extructura de retorno.</summary>
            public decimal precio { get; set; }

            /// <summary>Propiedad enlazada al 'total' de la extructura de retorno.</summary>
            public decimal total { get; set; }

        }

    }
}