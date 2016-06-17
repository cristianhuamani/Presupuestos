using System;
using System.Collections.Generic;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Logic
{
    /// <summary>Contiene los métodos lógicos de la clase 'Documento_Cab'.</summary>
    public partial class Documento_Cab : Entity.Documento_Cab
    {
        public readonly ReturnValue RetValue = new ReturnValue();

        public Documento_Cab(){}

        public Documento_Cab(string ccosto, string doc, string numero)
        {
            this._ccosto = ccosto;
            this._doc = doc;
            this._numero = numero;
        }

        /// <summary>Método que representa la llamada lógica de 'Actualizar'</summary>
        public virtual ReturnValue Actualizar(List<Documento_Lin> oLista)
        {
            var oCursor = new Data.Cursor(true);
            RetValue.Send(false);
            try
            {
                Data.Documento_Cab.Actualizar(this, oCursor);

                var oDocumento_Lin = new Documento_Lin(ccosto,doc,numero, null);
                Data.Documento_Lin.Eliminar(oDocumento_Lin, oCursor);
                for (int i = 0; i <= oLista.Count - 1; i++)
                {
                    //Aqui le pasamos los valores de la llave de la cabecera al detalle
                    oLista[i].ccosto = this.ccosto;
                    oLista[i].doc = this.doc;
                    oLista[i].numero = this.numero;
                    Data.Documento_Lin.Insertar(oLista[i], oCursor);
                }
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
        public virtual ReturnValue Insertar(List<Documento_Lin> oListar)
        {
            var oCursor = new Data.Cursor(true);
            RetValue.Send(false);
            try
            {
                Data.Documento_Cab.Insertar(this, oCursor);

                for (int i = 0; i <= oListar.Count - 1; i++)
                {
                    //Aqui le pasamos los valores de la llave de la cabecera al detalle
                    oListar[i].ccosto = this.ccosto;
                    oListar[i].doc = this.doc;
                    oListar[i].numero = this.numero;
                    Data.Documento_Lin.Insertar(oListar[i], oCursor);
                }

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
                List<Listar> ResultSet = Data.Documento_Cab.Listar(this, oCursor);
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
                List<ListarUso> ResultSet = Data.Documento_Cab.ListarUso(this, oCursor);
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
                Data.Documento_Cab.Obtener(this, oCursor);
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