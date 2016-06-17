using System;
using System.Collections.Generic;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Logic
{
    /// <summary>Contiene los métodos lógicos de la clase 'CentroCosto_Cab'.</summary>
    public partial class CentroCosto_Cab : Entity.CentroCosto_Cab
    {
        public readonly ReturnValue RetValue = new ReturnValue();

        public CentroCosto_Cab(){}

        public CentroCosto_Cab(string ccosto)
        {
            this._ccosto = ccosto;
        }

        /// <summary>Método que representa la llamada lógica de 'Actualizar'</summary>
        public virtual ReturnValue Actualizar(List<CentroCosto_Lin> oListar)
        {
            var oCursor = new Data.Cursor(true); //True: Para realizarlo con transaccion.
            RetValue.Send(false);
            try
            {
                Data.CentroCosto_Cab.Actualizar(this, oCursor);

                var oCentroCosto_Lin = new CentroCosto_Lin(ccosto, null);
                Data.CentroCosto_Lin.Eliminar(oCentroCosto_Lin, oCursor);
                for (int i = 0; i <= oListar.Count - 1; i++)
                {
                    //Aqui le pasamos los valores de la llave de la cabecera al detalle
                    oListar[i].ccosto = this.ccosto;
                    Data.CentroCosto_Lin.Insertar(oListar[i], oCursor);
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
        public virtual ReturnValue Insertar(List<CentroCosto_Lin> oListar)
        {
            var oCursor = new Data.Cursor(true);
            RetValue.Send(false);
            try
            {
                Data.CentroCosto_Cab.Insertar(this, oCursor);

                for (int i = 0; i <= oListar.Count - 1; i++)
                {
                    //Aqui le pasamos los valores de la llave de la cabecera al detalle
                    oListar[i].ccosto = this.ccosto;
                    Data.CentroCosto_Lin.Insertar(oListar[i], oCursor);
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
                List<Listar> ResultSet = Data.CentroCosto_Cab.Listar(this, oCursor);
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
                List<ListarDes> ResultSet = Data.CentroCosto_Cab.ListarDes(this, oCursor);
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
                List<ListarUso> ResultSet = Data.CentroCosto_Cab.ListarUso(this, oCursor);
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
                Data.CentroCosto_Cab.Obtener(this, oCursor);
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