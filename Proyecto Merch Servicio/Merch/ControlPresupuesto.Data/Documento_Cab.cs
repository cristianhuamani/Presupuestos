using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Data
{
    /// <summary>Contiene los métodos de acceso a datos de la clase 'Documento_Cab'.</summary>
    public partial class Documento_Cab
    {
        private Documento_Cab(){}

        /// <summary>Método que representa la llamada al procedure 'Documento_Cab_Actualizar'</summary>
        static public int Actualizar(Entity.Documento_Cab Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Documento_Cab_Actualizar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
                oP.AddWithValue("doc", Uso.NoNulo(Item.doc, DBNull.Value));
                oP.AddWithValue("numero", Uso.NoNulo(Item.numero, DBNull.Value));
                oP.AddWithValue("idPersona", Uso.NoNulo(Item.idPersona, DBNull.Value));
                oP.AddWithValue("total", Uso.NoNulo(Item.total, DBNull.Value));
                oP.AddWithValue("usrMod", Uso.NoNulo(Item.usrMod, DBNull.Value));
                oP.AddWithValue("fechaMod", Uso.NoNulo(Item.fechaMod, DBNull.Value));
                oP.AddWithValue("horaMod", Uso.NoNulo(Item.horaMod, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Documento_Cab_Insertar'</summary>
        static public int Insertar(Entity.Documento_Cab Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Documento_Cab_Insertar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
                oP.AddWithValue("doc", Uso.NoNulo(Item.doc, DBNull.Value));
                oP.Add("numero", SqlDbType.Char, 5).Direction = ParameterDirection.Output; 
                oP.Add("ej", SqlDbType.Char, 4).Direction = ParameterDirection.Output;
                oP.Add("mes", SqlDbType.Char, 2).Direction = ParameterDirection.Output;

                oP.AddWithValue("idPersona", Uso.NoNulo(Item.idPersona, DBNull.Value));
                oP.AddWithValue("total", Uso.NoNulo(Item.total, DBNull.Value));
                oP.AddWithValue("usr", Uso.NoNulo(Item.usr, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                Item.numero = (string)oP["numero"].Value;
                Item.ej = (string)oP["ej"].Value;
                Item.mes = (string)oP["mes"].Value;

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Documento_Cab_Listar'</summary>
        static public List<Entity.Documento_Cab.Listar> Listar(Entity.Documento_Cab Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Documento_Cab.Listar>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Documento_Cab_Listar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
                oP.AddWithValue("doc", Uso.NoNulo(Item.doc, DBNull.Value));
                oP.AddWithValue("numero", Uso.NoNulo(Item.numero, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Documento_Cab.Listar();
                        LItem.ccosto = (string)oLector["ccosto"];
                        LItem.doc = (string)oLector["doc"];
                        LItem.numero = (string)oLector["numero"];
                        LItem.ej = (string)oLector["ej"];
                        LItem.mes = (string)oLector["mes"];
                        LItem.solicitante = (string)Uso.NoNulo(oLector["solicitante"]);
                        LItem.total = (decimal)oLector["total"];
                        LItem.usr = (string)oLector["usr"];
                        LItem.fechaReg = (object)oLector["fechaReg"];
                        LItem.hora = (string)oLector["hora"];
                        LItem.usrMod = (string)Uso.NoNulo(oLector["usrMod"]);
                        LItem.fechaMod = (object)Uso.NoNulo(oLector["fechaMod"]);
                        LItem.horaMod = (string)Uso.NoNulo(oLector["horaMod"]);
                        LItem.usrTermino = (string)Uso.NoNulo(oLector["usrTermino"]);
                        LItem.fechaTermino = (object)Uso.NoNulo(oLector["fechaTermino"]);
                        LItem.horaTermino = (string)Uso.NoNulo(oLector["horaTermino"]);
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

        /// <summary>Método que representa la llamada al procedure 'Documento_Cab_ListarUso'</summary>
        static public List<Entity.Documento_Cab.ListarUso> ListarUso(Entity.Documento_Cab Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Documento_Cab.ListarUso>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Documento_Cab_ListarUso";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("filtro", Uso.NoNulo(Item.filtro, DBNull.Value));
               

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Documento_Cab.ListarUso();
                        LItem.ej = (string)oLector["ej"];
                        LItem.ccosto = (string)oLector["ccosto"];
                        LItem.doc = (string)oLector["doc"];
                        LItem.numero = (string)oLector["numero"];
                        LItem.descripcion = (string)oLector["descripcion"];
                        LItem.fechaReg = (DateTime)oLector["fechaReg"];
                        LItem.cliente = (string)oLector["cliente"];
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

        /// <summary>Método que representa la llamada al procedure 'Documento_Cab_Obtener'</summary>
        static public int Obtener(Entity.Documento_Cab Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Documento_Cab_Obtener";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
                oP.AddWithValue("doc", Uso.NoNulo(Item.doc, DBNull.Value));
                oP.AddWithValue("numero", Uso.NoNulo(Item.numero, DBNull.Value));
                oP.Add("Descripcion", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                oP.Add("Cliente", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                oP.Add("Ejecutivo", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                oP.Add("ej", SqlDbType.Char, 4).Direction = ParameterDirection.Output;
                oP.Add("mes", SqlDbType.Char, 2).Direction = ParameterDirection.Output;
                oP.Add("IdPersona", SqlDbType.Int).Direction = ParameterDirection.Output;
                oP.Add(new SqlParameter("total", SqlDbType.Decimal, 0, ParameterDirection.Output, false, 12, 2, null, DataRowVersion.Default, null));
                oP.Add("usr", SqlDbType.Char, 3).Direction = ParameterDirection.Output;
                oP.Add("fechareg", SqlDbType.Date).Direction = ParameterDirection.Output;
                oP.Add("hora", SqlDbType.Char, 8).Direction = ParameterDirection.Output;
                oP.Add("usrMod", SqlDbType.Char, 3).Direction = ParameterDirection.Output;
                oP.Add("fechaMod", SqlDbType.Date).Direction = ParameterDirection.Output;
                oP.Add("horaMod", SqlDbType.Char, 8).Direction = ParameterDirection.Output;
                oP.Add("usrTermino", SqlDbType.Char, 3).Direction = ParameterDirection.Output;
                oP.Add("fechaTermino", SqlDbType.Date).Direction = ParameterDirection.Output;
                oP.Add("horaTermino", SqlDbType.Char, 8).Direction = ParameterDirection.Output;
                oP.Add("idEstado", SqlDbType.Char, 1).Direction = ParameterDirection.Output;

                int NumFila = oComando.ExecuteNonQuery();

                Item.descripcion = (string)Uso.NoNulo(oP["descripcion"].Value);
                Item.cliente = (string)Uso.NoNulo(oP["cliente"].Value);
                Item.ejecutivo = (string)Uso.NoNulo(oP["ejecutivo"].Value);
                Item.ej = (string)Uso.NoNulo(oP["ej"].Value);
                Item.mes = (string)Uso.NoNulo(oP["mes"].Value);
                Item.idPersona = (int)Uso.NoNulo(oP["idPersona"].Value);
                Item.total = (decimal?)Uso.NoNulo(oP["total"].Value);
                Item.usr = (string)Uso.NoNulo(oP["usr"].Value);
                Item.fechaReg = (object)Uso.NoNulo(oP["fechaReg"].Value);
                Item.hora = (string)Uso.NoNulo(oP["hora"].Value);
                Item.usrMod = (string)Uso.NoNulo(oP["usrMod"].Value);
                Item.fechaMod = (object)Uso.NoNulo(oP["fechaMod"].Value);
                Item.horaMod = (string)Uso.NoNulo(oP["horaMod"].Value);
                Item.usrTermino = (string)Uso.NoNulo(oP["usrTermino"].Value);
                Item.fechaTermino = (object)Uso.NoNulo(oP["fechaTermino"].Value);
                Item.horaTermino = (string)Uso.NoNulo(oP["horaTermino"].Value);
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