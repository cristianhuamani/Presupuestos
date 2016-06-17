using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Data
{
    /// <summary>Contiene los métodos de acceso a datos de la clase 'Partida'.</summary>
    public partial class Partida
    {
        private Partida(){}

        /// <summary>Método que representa la llamada al procedure 'Partida_Actualizar'</summary>
        static public int Actualizar(Entity.Partida Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Partida_Actualizar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idPartida", Uso.NoNulo(Item.idPartida, DBNull.Value));
                oP.AddWithValue("partida", Uso.NoNulo(Item.partida, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Partida_Insertar'</summary>
        static public int Insertar(Entity.Partida Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Partida_Insertar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("partida", Uso.NoNulo(Item.partida, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Partida_Listar'</summary>
        static public List<Entity.Partida.Listar> Listar(Entity.Partida Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Partida.Listar>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Partida_Listar";
            try
            {
                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Partida.Listar();
                        LItem.idPartida = (string)oLector["idPartida"];
                        LItem.Partida = (string)oLector["Partida"];
                        LItem.Estado = (string)oLector["Estado"];
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

        /// <summary>Método que representa la llamada al procedure 'Partida_ListarDes'</summary>
        static public List<Entity.Partida.ListarDes> ListarDes(Entity.Partida Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Partida.ListarDes>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Partida_ListarDes";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Partida.ListarDes();
                        LItem.idPartida = (string)oLector["idPartida"];
                        LItem.Partida = (string)oLector["Partida"];
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

        /// <summary>Método que representa la llamada al procedure 'Partida_ListarUso'</summary>
        static public List<Entity.Partida.ListarUso> ListarUso(Entity.Partida Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Partida.ListarUso>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Partida_ListarUso";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idPartida", Uso.NoNulo(Item.idPartida, DBNull.Value));
                oP.AddWithValue("partida", Uso.NoNulo(Item.partida, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Partida.ListarUso();
                        LItem.idPartida = (string)oLector["idPartida"];
                        LItem.Partida = (string)oLector["Partida"];
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

        /// <summary>Método que representa la llamada al procedure 'Partida_Obtener'</summary>
        static public int Obtener(Entity.Partida Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Partida_Obtener";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idPartida", Uso.NoNulo(Item.idPartida, DBNull.Value));
                oP.Add("partida", SqlDbType.Char, 50).Direction = ParameterDirection.Output;
                oP.Add("idEstado", SqlDbType.Char, 1).Direction = ParameterDirection.Output;

                int NumFila = oComando.ExecuteNonQuery();

                Item.partida = (string)Uso.NoNulo(oP["partida"].Value);
                Item.idEstado = (string)Uso.NoNulo(oP["idEstado"].Value);

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}