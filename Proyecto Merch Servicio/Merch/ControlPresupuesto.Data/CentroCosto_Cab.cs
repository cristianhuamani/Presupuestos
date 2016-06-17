using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Data
{
    /// <summary>Contiene los métodos de acceso a datos de la clase 'CentroCosto_Cab'.</summary>
    public partial class CentroCosto_Cab
    {
        private CentroCosto_Cab(){}

        /// <summary>Método que representa la llamada al procedure 'CentroCosto_Cab_Actualizar'</summary>
        static public int Actualizar(Entity.CentroCosto_Cab Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "CentroCosto_Cab_Actualizar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
                oP.AddWithValue("descripcion", Uso.NoNulo(Item.descripcion, DBNull.Value));
                oP.AddWithValue("idcliente", Uso.NoNulo(Item.idcliente, DBNull.Value));
                oP.AddWithValue("idPersona", Uso.NoNulo(Item.idPersona, DBNull.Value));
                oP.AddWithValue("usrMod", Uso.NoNulo(Item.usrMod, DBNull.Value));
                oP.AddWithValue("total", Uso.NoNulo(Item.total, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'CentroCosto_Cab_Insertar'</summary>
        static public int Insertar(Entity.CentroCosto_Cab Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "CentroCosto_Cab_Insertar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.Add("ccosto",SqlDbType.Char,6).Direction = ParameterDirection.Output;
                oP.Add("ej", SqlDbType.Char, 4).Direction = ParameterDirection.Output;
                oP.Add("mes", SqlDbType.Char, 2).Direction = ParameterDirection.Output;

                oP.AddWithValue("descripcion", Uso.NoNulo(Item.descripcion, DBNull.Value));
                oP.AddWithValue("idcliente", Uso.NoNulo(Item.idcliente, DBNull.Value));
                oP.AddWithValue("idPersona", Uso.NoNulo(Item.idPersona, DBNull.Value));
                oP.AddWithValue("usr", Uso.NoNulo(Item.usr, DBNull.Value));
                oP.AddWithValue("total", Uso.NoNulo(Item.total, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                Item.ccosto = oP["ccosto"].Value.ToString();
                Item.ej = oP["ej"].Value.ToString();
                Item.mes= oP["mes"].Value.ToString();
                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'CentroCosto_Cab_Listar'</summary>
        static public List<Entity.CentroCosto_Cab.Listar> Listar(Entity.CentroCosto_Cab Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.CentroCosto_Cab.Listar>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "CentroCosto_Cab_Listar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
                oP.AddWithValue("cliente", Uso.NoNulo(Item.idcliente, DBNull.Value));
                oP.AddWithValue("idPersona", Uso.NoNulo(Item.idPersona, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.CentroCosto_Cab.Listar();
                        LItem.ccosto = (string)oLector["ccosto"];
                        LItem.ej = (string)oLector["ej"];
                        LItem.mes = (string)oLector["mes"];
                        LItem.descripcion = (string)oLector["descripcion"];
                        LItem.cliente = (string)Uso.NoNulo(oLector["cliente"]);
                        LItem.responsable = (string)Uso.NoNulo(oLector["responsable"]);
                        LItem.usr = (string)oLector["usr"];
                        LItem.fechaReg = (object)oLector["fechaReg"];
                        LItem.hora = (string)oLector["hora"];
                        LItem.usrMod = (string)oLector["usrMod"];
                        LItem.fechaMod = (object)Uso.NoNulo(oLector["fechaMod"]);
                        LItem.horaMod = (string)Uso.NoNulo(oLector["horaMod"]);
                        LItem.total = (decimal)oLector["total"];
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

        /// <summary>Método que representa la llamada al procedure 'CentroCosto_Cab_ListarDes'</summary>
        static public List<Entity.CentroCosto_Cab.ListarDes> ListarDes(Entity.CentroCosto_Cab Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.CentroCosto_Cab.ListarDes>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "CentroCosto_Cab_ListarDes";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("cliente", Uso.NoNulo(Item.idcliente, DBNull.Value));
                oP.AddWithValue("idPersona", Uso.NoNulo(Item.idPersona, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.CentroCosto_Cab.ListarDes();
                        LItem.ccosto = (string)oLector["ccosto"];
                        LItem.descripcion = (string)oLector["descripcion"];
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

        /// <summary>Método que representa la llamada al procedure 'CentroCosto_Cab_ListarUso'</summary>
        static public List<Entity.CentroCosto_Cab.ListarUso> ListarUso(Entity.CentroCosto_Cab Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.CentroCosto_Cab.ListarUso>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "CentroCosto_Cab_ListarUso";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("filtro", Uso.NoNulo(Item.filtro, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.CentroCosto_Cab.ListarUso();
                        LItem.ej = (string)oLector["ej"];
                        LItem.ccosto = (string)oLector["ccosto"];
                        LItem.descripcion = (string)oLector["descripcion"];
                        LItem.fechaReg = (string)oLector["fechaReg"];
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

        /// <summary>Método que representa la llamada al procedure 'CentroCosto_Cab_Obtener'</summary>
        static public int Obtener(Entity.CentroCosto_Cab Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "CentroCosto_Cab_Obtener";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
                oP.Add("ej", SqlDbType.Char, 4).Direction = ParameterDirection.Output;
                oP.Add("mes", SqlDbType.Char, 2).Direction = ParameterDirection.Output;
                oP.Add("descripcion", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                oP.Add("idcliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                oP.Add("idPersona", SqlDbType.Int).Direction = ParameterDirection.Output;
                oP.Add("usr", SqlDbType.Char, 3).Direction = ParameterDirection.Output;
                oP.Add("fechaReg", SqlDbType.Date).Direction = ParameterDirection.Output;
                oP.Add("hora", SqlDbType.Char, 8).Direction = ParameterDirection.Output;
                oP.Add("usrMod", SqlDbType.Char, 3).Direction = ParameterDirection.Output;
                oP.Add("fechaMod", SqlDbType.Date).Direction = ParameterDirection.Output;
                oP.Add("horaMod", SqlDbType.Char, 8).Direction = ParameterDirection.Output;
                oP.Add(new SqlParameter("total", SqlDbType.Decimal, 0, ParameterDirection.Output, false, 12, 2, null, DataRowVersion.Default, null));
                oP.Add("idEstado", SqlDbType.Char, 1).Direction = ParameterDirection.Output;

                int NumFila = oComando.ExecuteNonQuery();

                Item.ej = (string)Uso.NoNulo(oP["ej"].Value);
                Item.mes = (string)Uso.NoNulo(oP["mes"].Value);
                Item.descripcion = (string)Uso.NoNulo(oP["descripcion"].Value);
                Item.idcliente = (int?)Uso.NoNulo(oP["idcliente"].Value);
                Item.idPersona = (int?)Uso.NoNulo(oP["idPersona"].Value);
                Item.usr = (string)Uso.NoNulo(oP["usr"].Value);
                Item.fechaReg = (DateTime?)Uso.NoNulo(oP["fechaReg"].Value);
                Item.hora = (string)Uso.NoNulo(oP["hora"].Value);
                Item.usrMod = (string)Uso.NoNulo(oP["usrMod"].Value);
                Item.fechaMod = (DateTime?)Uso.NoNulo(oP["fechaMod"].Value);
                Item.horaMod = (string)Uso.NoNulo(oP["horaMod"].Value);
                Item.total = (decimal?)Uso.NoNulo(oP["total"].Value);
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