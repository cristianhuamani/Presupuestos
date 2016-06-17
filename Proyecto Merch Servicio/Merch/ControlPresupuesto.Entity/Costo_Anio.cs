using System;

namespace ControlPresupuesto.Entity
{
    /// <summary>Contiene las propiedades y extructuras de la clase 'Costo_Anio'.</summary>
    public partial class Costo_Anio
    {
        protected string _idAnio;
        /// <summary>Propiedad usada por: Actualizar, Insertar, Obtener.</summary>
        public virtual string idAnio
        {
            get
            { return _idAnio;}
            set
            { _idAnio = value;}
        }

        protected string _anio;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual string anio
        {
            get
            { return _anio;}
            set
            { _anio = value;}
        }

        protected string _numero;
        /// <summary>Propiedad usada por: Actualizar, Insertar, out Obtener.</summary>
        public virtual string numero
        {
            get
            { return _numero;}
            set
            { _numero = value;}
        }

    }
}