using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DogoHelp;

namespace MerchServicio.Data
{
    internal enum Contexto
    {
        CnControlPresupuesto = 0,
    }

    /// <summary>Clase que contiene los métodos de administración de las Conexiones.</summary>
    public class Cursor
    {
        private List<SqlCommand> Comandos = new List<SqlCommand>();
        private List<Contexto> Contextos = new List<Contexto>();

        protected bool _EsTransaccion = false;
        public virtual bool EsTransaccion
        {
            get
            { return _EsTransaccion; }
            set
            {
                if (!(_EsTransaccion && value == false))
                    _EsTransaccion = value;
            }
        }

        /// <summary>Método que instancia el objeto cursor.</summary>
        public Cursor() { }

        /// <summary>Método que instancia el objeto cursor.</summary>
        public Cursor(bool EsTransaccion)
        {
            this.EsTransaccion = EsTransaccion;
        }

        /// <summary>Método que retorna una instancia del comando preparado con la conexión.</summary>
        internal SqlCommand ObtenerComando(Contexto oContexto)
        {
            try
            {
                SqlCommand oComando = null;
                SqlConnection oConexion = null;

                //si ya existe el comando, lo retorna.
                for (int i = 0; i <= Contextos.Count - 1; i++)
                    if (Contextos[i] == oContexto)
                    {
                        oComando = Comandos[i];
                        oConexion = oComando.Connection;
                        break;
                    }

                if (oComando == null)
                {
                    //si no existe lo crea.
                    string CadenaConexion = Galeria.Conexiones[(int)oContexto].CadenaConexion;
                    string Proveedor = Galeria.Conexiones[(int)oContexto].Proveedor;

                    oConexion = new SqlConnection(CadenaConexion);
                    oComando = new SqlCommand();
                    oComando.CommandType = CommandType.StoredProcedure;
                    oComando.Connection = oConexion;
                    oComando.Connection.Open();

                    Comandos.Add(oComando);
                    Contextos.Add(oContexto);
                }
                else
                    oComando.Parameters.Clear();

                if (EsTransaccion && oComando.Transaction == null)
                    oComando.Transaction = oConexion.BeginTransaction();

                return oComando;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>Método que finaliza las conexiones.</summary>
        public void Finalizar(bool IsOk)
        {
            Exception oException = null;
            for (int i = 0; i <= Comandos.Count - 1; i++)
            {
                try
                {
                    FinalizarConexion(Comandos[i], IsOk);
                }
                catch (Exception ex)
                {
                    IsOk = false;
                    if (oException == null) oException = ex;
                }
            }
            Comandos.Clear();
            Contextos.Clear();

            if (oException != null) throw oException;
        }

        /// <summary>Método que finaliza la conexión y transacción (opcional).</summary>
        private void FinalizarConexion(SqlCommand oComando, bool IsOk)
        {
            try
            {
                SqlTransaction oTransaccion = oComando.Transaction;
                if (oTransaccion != null)
                {
                    if (IsOk)
                        oTransaccion.Commit();
                    else
                        oTransaccion.Rollback();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                if (oComando.Connection.State == ConnectionState.Open)
                    oComando.Connection.Close();
            }
        }

    }
}