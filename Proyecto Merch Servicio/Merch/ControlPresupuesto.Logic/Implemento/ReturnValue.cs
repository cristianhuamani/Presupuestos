using System;

namespace ControlPresupuesto.Logic
{
    /// <summary>Clase que contiene la respuesta de la ejecución de un metodo lógico.</summary>
    public class ReturnValue
    {
        /// <summary>Método que instancia el objeto ReturnValue.</summary>
        internal  ReturnValue(){}

        /// <summary>Método que instancia el objeto ReturnValue.</summary>
        internal ReturnValue Send(int Id, string Message)
        {
            _Id = Id;
            _Message = Message;
            return this;
        }

        /// <summary>Método que instancia el objeto cursor.</summary>
        internal ReturnValue Send(bool IsOk, string Message)
        {
            Send(Convert.ToInt32(!IsOk), Message);
            return this;
        }

        /// <summary>Método que instancia el objeto cursor.</summary>
        internal ReturnValue Send(bool IsOk)
        {
            Send(Convert.ToInt32(!IsOk), string.Empty);
            return this;
        }

        private int _Id;
        /// <summary>Propiedad que indica el identificador a la respuesta de la ejecución.</summary>
        public int Id
        {
            get
            { return _Id; }
        }

        private string _Message;
        /// <summary>Propiedad que indica el mensaje a la respuesta de la ejecución.</summary>
        public string Message
        {
            get
            { return _Message; }
        }

        /// <summary>Propiedad que indica si la ejecución ha sido exitosa.</summary>
        public bool IsOk
        {
            get
            { return (_Id == 0); }
        }

    }
}