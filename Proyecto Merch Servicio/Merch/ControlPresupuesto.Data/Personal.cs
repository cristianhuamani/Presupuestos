using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Data
{
    /// <summary>Contiene los métodos de acceso a datos de la clase 'Personal'.</summary>
    public partial class Personal
    {
        private Personal(){}

        /// <summary>Método que representa la llamada al procedure 'Personal_Actualizar'</summary>
        static public int Actualizar(Entity.Personal Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Personal_Actualizar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idPersona", Uso.NoNulo(Item.idPersona, DBNull.Value));
                oP.AddWithValue("codigoPersona", Uso.NoNulo(Item.codigoPersona, DBNull.Value));
                oP.AddWithValue("nombre", Uso.NoNulo(Item.nombre, DBNull.Value));
                oP.AddWithValue("apellidoPaterno", Uso.NoNulo(Item.apellidoPaterno, DBNull.Value));
                oP.AddWithValue("apellidoMarterno", Uso.NoNulo(Item.apellidoMarterno, DBNull.Value));
                oP.AddWithValue("direccion", Uso.NoNulo(Item.direccion, DBNull.Value));
                oP.AddWithValue("tefelofono", Uso.NoNulo(Item.tefelofono, DBNull.Value));
                oP.AddWithValue("fechaNac", Uso.NoNulo(Item.fechaNac, DBNull.Value));
                oP.AddWithValue("idSexo", Uso.NoNulo(Item.idSexo, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Personal_Insertar'</summary>
        static public int Insertar(Entity.Personal Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Personal_Insertar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.Add("idPersona", SqlDbType.Int).Direction = ParameterDirection.Output;
                oP.AddWithValue("codigoPersona", Uso.NoNulo(Item.codigoPersona, DBNull.Value));
                oP.AddWithValue("nombre", Uso.NoNulo(Item.nombre, DBNull.Value));
                oP.AddWithValue("apellidoPaterno", Uso.NoNulo(Item.apellidoPaterno, DBNull.Value));
                oP.AddWithValue("apellidoMarterno", Uso.NoNulo(Item.apellidoMarterno, DBNull.Value));
                oP.AddWithValue("direccion", Uso.NoNulo(Item.direccion, DBNull.Value));
                oP.AddWithValue("tefelofono", Uso.NoNulo(Item.tefelofono, DBNull.Value));
                oP.AddWithValue("fechaNac", Uso.NoNulo(Item.fechaNac, DBNull.Value));
                oP.AddWithValue("idSexo", Uso.NoNulo(Item.idSexo, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                Item.idPersona = (int?)Uso.NoNulo(oP["idPersona"].Value);

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Personal_Listar'</summary>
        static public List<Entity.Personal.Listar> Listar(Entity.Personal Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Personal.Listar>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Personal_Listar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idPersona", Uso.NoNulo(Item.idPersona, DBNull.Value));
                oP.AddWithValue("idSexo", Uso.NoNulo(Item.idSexo, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Personal.Listar();
                        LItem.idPersona = (int)oLector["idPersona"];
                        LItem.codigoPersona = (string)oLector["codigoPersona"];
                        LItem.nombre = (string)oLector["nombre"];
                        LItem.apellidoPaterno = (string)oLector["apellidoPaterno"];
                        LItem.apellidoMarterno = (string)oLector["apellidoMarterno"];
                        LItem.direccion = (string)oLector["direccion"];
                        LItem.tefelofono = (string)Uso.NoNulo(oLector["tefelofono"]);
                        LItem.fechaNac = (object)oLector["fechaNac"];
                        LItem.idSexo = (string)Uso.NoNulo(oLector["idSexo"]);
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

        /// <summary>Método que representa la llamada al procedure 'Personal_ListarDes'</summary>
        static public List<Entity.Personal.ListarDes> ListarDes(Entity.Personal Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Personal.ListarDes>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Personal_ListarDes";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idSexo", Uso.NoNulo(Item.idSexo, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Personal.ListarDes();
                        LItem.idPersona = (int)oLector["idPersona"];
                        LItem.nombre = (string)oLector["nombre"];
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

        /// <summary>Método que representa la llamada al procedure 'Personal_ListarUso'</summary>
        static public List<Entity.Personal.ListarUso> ListarUso(Entity.Personal Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Personal.ListarUso>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Personal_ListarUso";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("codigoPersona", Uso.NoNulo(Item.codigoPersona, DBNull.Value));
                oP.AddWithValue("nombre", Uso.NoNulo(Item.nombre, DBNull.Value));
                oP.AddWithValue("apellidoPaterno", Uso.NoNulo(Item.apellidoPaterno, DBNull.Value));
                oP.AddWithValue("apellidoMarterno", Uso.NoNulo(Item.apellidoMarterno, DBNull.Value));
                oP.AddWithValue("direccion", Uso.NoNulo(Item.direccion, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Personal.ListarUso();
                        LItem.idPersona = (int)oLector["idPersona"];
                        LItem.codigoPersona = (string)oLector["codigoPersona"];
                        LItem.nombre = (string)oLector["nombre"];
                        LItem.apellidoPaterno = (string)oLector["apellidoPaterno"];
                        LItem.apellidoMarterno = (string)oLector["apellidoMarterno"];
                        LItem.direccion = (string)oLector["direccion"];
                        LItem.tefelofono = (string)Uso.NoNulo(oLector["tefelofono"]);
                        LItem.fechaNac = (object)oLector["fechaNac"];
                        LItem.sexo = (string)Uso.NoNulo(oLector["sexo"]);
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

        /// <summary>Método que representa la llamada al procedure 'Personal_Obtener'</summary>
        static public int Obtener(Entity.Personal Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Personal_Obtener";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idPersona", Uso.NoNulo(Item.idPersona, DBNull.Value));
                oP.Add("codigoPersona", SqlDbType.Char, 8).Direction = ParameterDirection.Output;
                oP.Add("nombre", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                oP.Add("apellidoPaterno", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                oP.Add("apellidoMarterno", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                oP.Add("direccion", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                oP.Add("tefelofono", SqlDbType.VarChar, 11).Direction = ParameterDirection.Output;
                oP.Add("fechaNac", SqlDbType.Variant).Direction = ParameterDirection.Output;
                oP.Add("idSexo", SqlDbType.Char, 1).Direction = ParameterDirection.Output;
                oP.Add("idEstado", SqlDbType.Char, 1).Direction = ParameterDirection.Output;

                int NumFila = oComando.ExecuteNonQuery();

                Item.codigoPersona = (string)Uso.NoNulo(oP["codigoPersona"].Value);
                Item.nombre = (string)Uso.NoNulo(oP["nombre"].Value);
                Item.apellidoPaterno = (string)Uso.NoNulo(oP["apellidoPaterno"].Value);
                Item.apellidoMarterno = (string)Uso.NoNulo(oP["apellidoMarterno"].Value);
                Item.direccion = (string)Uso.NoNulo(oP["direccion"].Value);
                Item.tefelofono = (string)Uso.NoNulo(oP["tefelofono"].Value);
                Item.fechaNac = (object)Uso.NoNulo(oP["fechaNac"].Value);
                Item.idSexo = (string)Uso.NoNulo(oP["idSexo"].Value);
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