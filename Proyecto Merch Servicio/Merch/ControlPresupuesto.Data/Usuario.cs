using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Data
{
    /// <summary>Contiene los métodos de acceso a datos de la clase 'Usuario'.</summary>
    public partial class Usuario
    {
        private Usuario(){}

        /// <summary>Método que representa la llamada al procedure 'Usuario_Actualizar'</summary>
        static public int Actualizar(Entity.Usuario Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Usuario_Actualizar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("usr", Uso.NoNulo(Item.usr, DBNull.Value));
                oP.AddWithValue("codigoPersona", Uso.NoNulo(Item.codigoPersona, DBNull.Value));
                oP.AddWithValue("usrNombre", Uso.NoNulo(Item.usrNombre, DBNull.Value));
                oP.AddWithValue("clave", Uso.NoNulo(Item.clave, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Usuario_Insertar'</summary>
        static public int Insertar(Entity.Usuario Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Usuario_Insertar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("usr", Uso.NoNulo(Item.usr, DBNull.Value));
                oP.AddWithValue("codigoPersona", Uso.NoNulo(Item.codigoPersona, DBNull.Value));
                oP.AddWithValue("usrNombre", Uso.NoNulo(Item.usrNombre, DBNull.Value));
                oP.AddWithValue("clave", Uso.NoNulo(Item.clave, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Usuario_Listar'</summary>
        static public List<Entity.Usuario.Listar> Listar(Entity.Usuario Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Usuario.Listar>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Usuario_Listar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("usr", Uso.NoNulo(Item.usr, DBNull.Value));
                oP.AddWithValue("codigoPersona", Uso.NoNulo(Item.codigoPersona, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Usuario.Listar();
                        LItem.usr = (string)oLector["usr"];
                        LItem.codigoPersona = (string)Uso.NoNulo(oLector["codigoPersona"]);
                        LItem.usrNombre = (string)oLector["usrNombre"];
                        LItem.clave = (string)oLector["clave"];
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

        /// <summary>Método que representa la llamada al procedure 'Usuario_ListarUso'</summary>
        static public List<Entity.Usuario.ListarUso> ListarUso(Entity.Usuario Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Usuario.ListarUso>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Usuario_ListarUso";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("usr", Uso.NoNulo(Item.usr, DBNull.Value));
                oP.AddWithValue("usrNombre", Uso.NoNulo(Item.usrNombre, DBNull.Value));
                oP.AddWithValue("clave", Uso.NoNulo(Item.clave, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Usuario.ListarUso();
                        LItem.usr = (string)oLector["usr"];
                        LItem.nombre = (string)Uso.NoNulo(oLector["nombre"]);
                        LItem.usrNombre = (string)oLector["usrNombre"];
                        LItem.clave = (string)oLector["clave"];
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

        /// <summary>Método que representa la llamada al procedure 'Usuario_Obtener'</summary>
        static public int Obtener(Entity.Usuario Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Usuario_Obtener";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("usr", Uso.NoNulo(Item.usr, DBNull.Value));
                oP.Add("codigoPersona", SqlDbType.Char, 8).Direction = ParameterDirection.Output;
                oP.Add("usrNombre", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output;
                oP.Add("clave", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                oP.Add("idEstado", SqlDbType.Char, 1).Direction = ParameterDirection.Output;

                int NumFila = oComando.ExecuteNonQuery();

                Item.codigoPersona = (string)Uso.NoNulo(oP["codigoPersona"].Value);
                Item.usrNombre = (string)Uso.NoNulo(oP["usrNombre"].Value);
                Item.clave = (string)Uso.NoNulo(oP["clave"].Value);
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