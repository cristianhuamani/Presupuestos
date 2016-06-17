using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Data
{
    /// <summary>Contiene los métodos de acceso a datos de la clase 'Nivel_Personal'.</summary>
    public partial class Nivel_Personal
    {
        private Nivel_Personal(){}

        /// <summary>Método que representa la llamada al procedure 'Nivel_Personal_Actualizar'</summary>
        static public int Actualizar(Entity.Nivel_Personal Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Nivel_Personal_Actualizar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idNivel", Uso.NoNulo(Item.idNivel, DBNull.Value));
                oP.AddWithValue("codigoPersona", Uso.NoNulo(Item.codigoPersona, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Nivel_Personal_Eliminar'</summary>
        static public int Eliminar(Entity.Nivel_Personal Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Nivel_Personal_Eliminar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idNivel", Uso.NoNulo(Item.idNivel, DBNull.Value));
                oP.AddWithValue("codigoPersona", Uso.NoNulo(Item.codigoPersona, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Nivel_Personal_Insertar'</summary>
        static public int Insertar(Entity.Nivel_Personal Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Nivel_Personal_Insertar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idNivel", Uso.NoNulo(Item.idNivel, DBNull.Value));
                oP.AddWithValue("codigoPersona", Uso.NoNulo(Item.codigoPersona, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Nivel_Personal_Listar'</summary>
        static public List<Entity.Nivel_Personal.Listar> Listar(Entity.Nivel_Personal Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Nivel_Personal.Listar>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Nivel_Personal_Listar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idNivel", Uso.NoNulo(Item.idNivel, DBNull.Value));
                oP.AddWithValue("codigoPersona", Uso.NoNulo(Item.codigoPersona, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Nivel_Personal.Listar();
                        LItem.idNivel = (string)oLector["idNivel"];
                        LItem.codigoPersona = (string)oLector["codigoPersona"];
                        LItem.idEstado = (string)Uso.NoNulo(oLector["idEstado"]);
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

        /// <summary>Método que representa la llamada al procedure 'Nivel_Personal_ListarUso'</summary>
        static public List<Entity.Nivel_Personal.ListarUso> ListarUso(Entity.Nivel_Personal Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Nivel_Personal.ListarUso>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Nivel_Personal_ListarUso";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idNivel", Uso.NoNulo(Item.idNivel, DBNull.Value));
                oP.AddWithValue("codigoPersona", Uso.NoNulo(Item.codigoPersona, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Nivel_Personal.ListarUso();
                        LItem.Nivel = (string)oLector["Nivel"];
                        LItem.nombre = (string)oLector["nombre"];
                        LItem.estado = (string)Uso.NoNulo(oLector["estado"]);
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

        /// <summary>Método que representa la llamada al procedure 'Nivel_Personal_Obtener'</summary>
        static public int Obtener(Entity.Nivel_Personal Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Nivel_Personal_Obtener";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idNivel", Uso.NoNulo(Item.idNivel, DBNull.Value));
                oP.AddWithValue("codigoPersona", Uso.NoNulo(Item.codigoPersona, DBNull.Value));
                oP.Add("idEstado", SqlDbType.Char, 1).Direction = ParameterDirection.Output;

                int NumFila = oComando.ExecuteNonQuery();

                Item.idEstado = (string)Uso.NoNulo(oP["idEstado"].Value);

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        static public List<Entity.Nivel_Personal.ListarDes> ListarDes(Entity.Nivel_Personal Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Nivel_Personal.ListarDes>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Nivel_Personal_ListarDes";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idNivel", Uso.NoNulo(Item.idNivel, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Nivel_Personal.ListarDes();
                        LItem.idPersona = (int)oLector["idPersona"];
                        LItem.Nombre= (string)oLector["Nombre"];
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

    }
}