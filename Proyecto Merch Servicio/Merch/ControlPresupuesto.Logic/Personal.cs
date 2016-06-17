using System;
using System.Collections.Generic;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Logic
{
    /// <summary>Contiene los métodos lógicos de la clase 'Personal'.</summary>
    public partial class Personal : Entity.Personal
    {
        public readonly ReturnValue RetValue = new ReturnValue();

        public Personal(){}

        public Personal(int? idPersona)
        {
            this._idPersona = idPersona;
        }

        /// <summary>Método que representa la llamada lógica de 'Actualizar'</summary>
        public virtual ReturnValue Actualizar()
        {
            var oCursor = new Data.Cursor();
            RetValue.Send(false);
            try
            {
                Data.Personal.Actualizar(this, oCursor);
                return RetValue.Send(true);
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                oCursor.Finalizar(RetValue.IsOk);
            }
        }

        /// <summary>Método que representa la llamada lógica de 'Insertar'</summary>
        public virtual ReturnValue Insertar()
        {
            var oCursor = new Data.Cursor();
            RetValue.Send(false);
            try
            {
                Data.Personal.Insertar(this, oCursor);
                return RetValue.Send(true);
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                oCursor.Finalizar(RetValue.IsOk);
            }
        }

        /// <summary>Método que representa la llamada lógica de 'Listar'</summary>
        public virtual new List<Listar> Listar()
        {
            var oCursor = new Data.Cursor();
            RetValue.Send(false);
            try
            {
                List<Listar> ResultSet = Data.Personal.Listar(this, oCursor);
                RetValue.Send(true);
                return ResultSet;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                oCursor.Finalizar(RetValue.IsOk);
            }
        }

        /// <summary>Método que representa la llamada lógica de 'ListarDes'</summary>
        public virtual new List<ListarDes> ListarDes()
        {
            var oCursor = new Data.Cursor();
            RetValue.Send(false);
            try
            {
                List<ListarDes> ResultSet = Data.Personal.ListarDes(this, oCursor);
                RetValue.Send(true);
                return ResultSet;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                oCursor.Finalizar(RetValue.IsOk);
            }
        }

        /// <summary>Método que representa la llamada lógica de 'ListarUso'</summary>
        public virtual new List<ListarUso> ListarUso()
        {
            var oCursor = new Data.Cursor();
            RetValue.Send(false);
            try
            {
                List<ListarUso> ResultSet = Data.Personal.ListarUso(this, oCursor);
                RetValue.Send(true);
                return ResultSet;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                oCursor.Finalizar(RetValue.IsOk);
            }
        }

        /// <summary>Método que representa la llamada lógica de 'Obtener'</summary>
        public virtual ReturnValue Obtener()
        {
            var oCursor = new Data.Cursor();
            RetValue.Send(false);
            try
            {
                Data.Personal.Obtener(this, oCursor);
                return RetValue.Send(true);
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                oCursor.Finalizar(RetValue.IsOk);
            }
        }

    }
}