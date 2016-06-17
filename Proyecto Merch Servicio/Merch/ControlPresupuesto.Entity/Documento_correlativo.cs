using System;

namespace ControlPresupuesto.Entity
{
    /// <summary>Contiene las propiedades y extructuras de la clase 'Documento_correlativo'.</summary>
    public partial class Documento_correlativo
    {
        protected string _doc;
        /// <summary>Propiedad usada por: Act, Insertar, Obtener.</summary>
        public virtual string doc
        {
            get
            { return _doc;}
            set
            { _doc = value;}
        }

        protected string _numero;
        /// <summary>Propiedad usada por: Act, Insertar, out Obtener.</summary>
        public virtual string numero
        {
            get
            { return _numero;}
            set
            { _numero = value;}
        }

    }
}