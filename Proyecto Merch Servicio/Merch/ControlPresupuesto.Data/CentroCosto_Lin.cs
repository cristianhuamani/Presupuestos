using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Data
{
    /// <summary>Contiene los métodos de acceso a datos de la clase 'CentroCosto_Lin'.</summary>
    public partial class CentroCosto_Lin
    {
        private CentroCosto_Lin(){}

        /// <summary>Método que representa la llamada al procedure 'CentroCosto_Lin_Actualizar'</summary>
        static public int Actualizar(Entity.CentroCosto_Lin Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "CentroCosto_Lin_Actualizar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
                oP.AddWithValue("idPartida", Uso.NoNulo(Item.idPartida, DBNull.Value));
                oP.AddWithValue("total", Uso.NoNulo(Item.total, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'CentroCosto_Lin_Eliminar'</summary>
        static public int Eliminar(Entity.CentroCosto_Lin Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "CentroCosto_Lin_Eliminar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'CentroCosto_Lin_Insertar'</summary>
        static public int Insertar(Entity.CentroCosto_Lin Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "CentroCosto_Lin_Insertar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
                oP.AddWithValue("idPartida", Uso.NoNulo(Item.idPartida, DBNull.Value));
                oP.AddWithValue("total", Uso.NoNulo(Item.total, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'CentroCosto_Lin_Listar'</summary>
        static public List<Entity.CentroCosto_Lin.Listar> Listar(Entity.CentroCosto_Lin Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.CentroCosto_Lin.Listar>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "CentroCosto_Lin_Listar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.CentroCosto_Lin.Listar();
                       
                        LItem.idPartida = (string)oLector["idPartida"];
                        LItem.partida = (string)oLector["Partida"];
                        ResultSet.Add(LItem);
                    }
                }
                return ResultSet;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'CentroCosto_Lin_ListarUso'</summary>
        static public List<Entity.CentroCosto_Lin.ListarUso> ListarUso(Entity.CentroCosto_Lin Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.CentroCosto_Lin.ListarUso>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "CentroCosto_Lin_ListarUso";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.CentroCosto_Lin.ListarUso();
                        LItem.idPartida = (string)oLector["idPartida"];
                        LItem.Partida = (string)oLector["Partida"];
                        LItem.total = (decimal)oLector["total"];
                        ResultSet.Add(LItem);
                    }
                }
                return ResultSet;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'CentroCosto_Lin_Obtener'</summary>
        static public int Obtener(Entity.CentroCosto_Lin Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "CentroCosto_Lin_Obtener";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
                oP.AddWithValue("idPartida", Uso.NoNulo(Item.idPartida, DBNull.Value));
                oP.Add(new SqlParameter("total", SqlDbType.Decimal, 0, ParameterDirection.Output, false, 12, 2, null, DataRowVersion.Default, null));

                int NumFila = oComando.ExecuteNonQuery();

                Item.total = (decimal?)Uso.NoNulo(oP["total"].Value);

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}